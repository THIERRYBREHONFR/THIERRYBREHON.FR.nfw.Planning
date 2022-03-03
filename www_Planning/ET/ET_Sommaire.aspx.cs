using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using THIERRYBREHON.FR.NSD;
using System.Data.SqlClient;
using THIERRYBREHON.FR.X;
using THIERRYBREHON.FR.NSP;
using THIERRYBREHON.FR.Web;
using Thierry.NSP;
using THIERRYBREHON.FR.NSB;
using Thierry.NSB;
using Thierry.NSS;
using Thierry.NSD;
using THIERRYBREHON.FR.NSS;
using System.Xml;
using System.Net;

public partial class ET_Sommaire : ETForm
{

    protected override string ObjectName => "Accueil : ";
    protected override string PageTitle => "Accueil";

    protected override void Page_PreRender(object sender, EventArgs e)
    {
        base.Page_PreRender(sender, e);
        Identite.Valeur = D_ET9_Droits.Prenom + " " + D_ET9_Droits.Nom;
        if (SummaryButton != null) SummaryButton.Visible = false;
        Div_TR.Visible = D_ET9_Droits.Tr_visu;
        Div_CO.Visible = D_ET9_Droits.Co_visu;
        Div_PL.Visible = D_ET9_Droits.Pt_visu;
        Div_TA.Visible = D_ET9_Droits.Ta_visu;
        Div_SO.Visible = D_ET9_Droits.So_visu;
    }

}
