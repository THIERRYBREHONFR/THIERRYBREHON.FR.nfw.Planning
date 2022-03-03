using System;
using System.Data;
using System.Web.Configuration;
using System.Collections;
using System.Net;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using THIERRYBREHON.FR.X;
using System.Data.SqlClient;
using THIERRYBREHON.FR.SERVICE.NSB;
using THIERRYBREHON.FR.SERVICE.NSD;
using THIERRYBREHON.FR.Mail;
using THIERRYBREHON.FR.NSD;
using THIERRYBREHON.FR.Web;
using THIERRYBREHON.FR.NSP;
using Thierry.NSB;
using Thierry.NSP;
using Thierry.NSD;

public partial class ReLogin : ETForm
{
    protected override bool RequiredAuthentication => false;

    protected override void Page_Init(object sender, EventArgs e)
    {
        //base.Page_Init(sender, e);
    }

    protected override void Page_PreRender(object sender, EventArgs e)
    {
        base.Page_PreRender(sender, e);
        if (IDataSession == null)
            throw new ArgumentException();
        if (IDataSession.Id_connecte == 0)
            Identifiant.Focus();
        else
        {
            Identifiant.ReadOnly = true;
            Avatar.ReadOnly = true;
            var vBSERV_V_SERV9_Droits = new BSERV_V_SERV9_Droits(IServiceStorageAccess);
            Identifiant.Valeur = ((DSERV_V_SERV9_Droits)vBSERV_V_SERV9_Droits.ReadOneRow(IDataSession.Id_connecte, TBfrData_Type.Base, null)).Login;
            if (IDataSession.Id_connecte != IDataSession.Id_utilisa)
                Avatar.Valeur = ((DSERV_V_SERV9_Droits)vBSERV_V_SERV9_Droits.ReadOneRow(IDataSession.Id_utilisa, TBfrData_Type.Base, null)).Login;
            Password.Focus();
        }
    }

    protected override string PageTitle => Request.Params["re"] == "1" ? "Réidentification" : "Identification";

    protected override void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            PAppli.Valeur = Request.QueryString["ap"];
            PIdAppli.Valeur = Request.QueryString["id"];
            POpAppli.Valeur = Request.QueryString["op"];
            PItAppli.Valeur = Request.QueryString["it"];
            EcrireLog(IServiceStorageAccess,
                2, WebConfigurationManager.AppSettings["LogLogin"].ToIntOrDefault(default), Request, 0, "T", "Login", "Login", "Init", null, null,
                PAppli.Valeur, PIdAppli.Valeur + "/" + POpAppli.Valeur + "/" + PItAppli.Valeur, null, null, null);
        }
    }

    protected void EnterButton_Click(object sender, EventArgs e)
    {
        string vMessage = null;
        if (IDataSession == null)
            throw new ArgumentException();

        var vBSERV_V_SERV9_Droits = new BSERV_V_SERV9_Droits(IServiceStorageAccess);

        long vId_utilisa = 0;
        // vérification de l'avatar
        if (IDataSession.Id_utilisa != 0)
        {
            if (IDataSession.Id_utilisa != IDataSession.Id_connecte)
                vId_utilisa = IDataSession.Id_utilisa;
        }
        else if (Avatar.Valeur.ToTrim().IsCompleted())
        {
            var vDSERV_V_SERV9_Droits = vBSERV_V_SERV9_Droits.ReadOneRow(Avatar.Valeur.ToTrim());
            if (vDSERV_V_SERV9_Droits == null)
                vMessage = "Avatar inexistant.";
            else
                vId_utilisa = vDSERV_V_SERV9_Droits.Id;
        }
        // vérification de l'authentification
        if (vMessage.IsNullOrEmpty())
        {
            string vLogin_connecte = IDataSession.Id_connecte == 0 ? Identifiant.Text
                    : ((DSERV_V_SERV9_Droits)vBSERV_V_SERV9_Droits.ReadOneRow(IDataSession.Id_connecte, TBfrData_Type.Base, null)).Login;
            var vDSERV_V_SERV9_Droits_Connecte = vBSERV_V_SERV9_Droits.ReadOneRow(vLogin_connecte, Password.Text);
            if (vDSERV_V_SERV9_Droits_Connecte == null)
                vMessage = "Authentification incorrecte.";
            else if (!vDSERV_V_SERV9_Droits_Connecte.Av_prendre && Avatar.Valeur.IsCompleted())
                vMessage = "Vous n'êtes pas autorisé à prendre l'identité d'un autre compte.";
            else
            {
                if (IDataSession.Id_connecte == 0)
                {
                    IStorageAccess.Id_espaceclient = vDSERV_V_SERV9_Droits_Connecte.Id_espclient;
                    vMessage = IBusinessSession.Update(IdAndCodeSession, vId_utilisa == 0 ? vDSERV_V_SERV9_Droits_Connecte.Id : vId_utilisa, vDSERV_V_SERV9_Droits_Connecte.Id, vDSERV_V_SERV9_Droits_Connecte.Id_espclient);
                }
                vMessage += IBusinessSession.Update(IdAndCodeSession);
            }
        }
        if (vMessage.IsCompleted())
            AppendToDisplayedMessage(-1, Environment.NewLine, vMessage);
        else if (Request.Params["re"] == "1")
        {
            Response.Clear();
            Response.Write("<script>window.close();</script>");
            Response.End();
        }
        else
        {
            string VChemin;
            if (PAppli.Valeur.IsStartingWith("TR")) VChemin = "TR/";
            else if (PAppli.Valeur.IsStartingWith("CO")) VChemin = "CO/";
            else if (PAppli.Valeur.IsStartingWith("CA")) VChemin = "CA/";
            else if (PAppli.Valeur.IsStartingWith("PT")) VChemin = "PT/";
            else if (PAppli.Valeur.IsStartingWith("ATR")) VChemin = "TR/";
            else if (PAppli.Valeur.IsStartingWith("ACO")) VChemin = "CO/";
            else if (PAppli.Valeur.IsStartingWith("ACA")) VChemin = "CA/";
            else if (PAppli.Valeur.IsStartingWith("APT")) VChemin = "PT/";
            else
            {
                VChemin = "ET/";
                PAppli.Valeur = "ET_Sommaire";
            }
            string VRedirect = $"~/{VChemin}{PAppli.Valeur}.aspx?code={IdAndCodeSession}";
            if (PIdAppli.Valeur.IsCompleted())
                VRedirect += "&id=" + PIdAppli.Valeur;
            if (POpAppli.Valeur.IsCompleted())
                VRedirect += "&op=" + POpAppli.Valeur;
            if (PItAppli.Valeur.IsCompleted())
                VRedirect += "&it=" + PItAppli.Valeur;
            Response.Redirect(VRedirect);
        }
    }

    protected void LostPasswordButton_Click(object sender, EventArgs e)
    {
        string vMessage = null;
        if (Identifiant.Valeur.IsNullOrEmpty())
            vMessage = "Veuillez renseigner l'identifiant";
        if (vMessage.IsNullOrEmpty())
        {
            var vBSERV_V_SERV9_Droits = new BSERV_V_SERV9_Droits(IServiceStorageAccess);
            var vDSERV_V_SERV9_Droits = vBSERV_V_SERV9_Droits.ReadOneRow(Identifiant.Valeur.ToTrim());
            if (vDSERV_V_SERV9_Droits != null)
            {
                IStorageAccess.Id_espaceclient = vDSERV_V_SERV9_Droits.Id_espclient;
                string vCode = IBusinessSession.Create(vDSERV_V_SERV9_Droits.Id, vDSERV_V_SERV9_Droits.Id_espclient, Request.UserHostAddress, "ET/AET_V_ET0_ReinitMotDePasse");
                //envoyer un mail 
                if (vCode.IsCompleted())
                {
                    var vMail = new TBfrMail(new NetworkCredential("pro@thierrybrehon.fr", "31Marz62pro$"), "THIERRYBREHON.FR", "<br />Ne répondez pas à ce mail.",
                                      "pro@thierrybrehon.fr", "smtp.ionos.fr", 587, true);
                    vMail.Init(vDSERV_V_SERV9_Droits.Mail, null, null, "Réinitialisation de votre mot de passe",
                        "Bonjour.<br />"
                      + "Pour réintialiser votre mot de passe, cliquez sur ce lien<br />"
                      + $"<a href='https://www.THIERRYBREHON.FR/ET/AET_V_ET0_ReinitMotDePasse.aspx?Code={vCode}&id={vDSERV_V_SERV9_Droits.Id}&op=3'>https://www.THIERRYBREHON.FR/ET/AET_V_ET0_ReinitMotDePasse.aspx?Code={vCode}&id={vDSERV_V_SERV9_Droits.Id}&op=3</a><br />"
                      + "Ce lien est valide 20 minutes.<br />");
                    vMail.Send();
                }
            }
            vMessage = "Si l'identifiant existe, un mail a été envoyé à l'adresse associée. Le cas échéant, consultez les indésirables.";
        }
        AppendToDisplayedMessage(-1, Environment.NewLine, vMessage);
    }
}
