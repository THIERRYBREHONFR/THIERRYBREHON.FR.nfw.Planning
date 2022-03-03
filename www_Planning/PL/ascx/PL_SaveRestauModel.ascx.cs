using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using THIERRYBREHON.FR.Web;

public partial class PL_SaveRestauModel : System.Web.UI.UserControl
{

    public TBfr_ComboBox Id_ModelePerso { get => FId_ModelePerso; } 
    public TBfr_ComboBox Id_ModeleStd { get => FId_ModeleStd; } 
    public TBfr_ComboBox Id_ModeleAutre { get => FId_ModeleAutre; } 
    public TBfr_TextBox NomModeleSave { get => FNomModeleSave; } 
    public TBfr_ComboBox Id_ModeleSave { get => FId_ModeleSave; } 

    public SqlDataSource SqlDataSourceMdlStd { get => FSqlDataSourceMdlStd; } 
    public SqlDataSource SqlDataSourceMdlPerso { get => FSqlDataSourceMdlPerso; } 
    public SqlDataSource SqlDataSourceMdlAutre { get => FSqlDataSourceMdlAutre; } 
    public SqlDataSource SqlDataSourceMdlPersoModif { get => FSqlDataSourceMdlPersoModif; } 

    public bool AfficherListeStd { set => MdlStd.Visible = value; } 
    public bool AfficherListePerso { set => MdlPerso.Visible = value; } 
    public bool AfficherListeAutre { set => MdlAutre.Visible = value; } 
}
