using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using THIERRYBREHON.FR.Web;

public partial class ET_PopupExport : System.Web.UI.UserControl
{

    public void Page_LoadLinkEvents(System.EventHandler btGridExport_click)
    {
        FExportButton.Click += btGridExport_click;
    }

    public TBfr_CheckBox ExpImp { get => FExpImp; }
    public TBfr_TextBox BottomMargin { get => FBottomMargin; }
    public TBfr_TextBox TopMargin { get => FTopMargin; }
    public TBfr_TextBox LeftMargin { get => FLeftMargin; }
    public TBfr_TextBox RightMargin { get => FRightMargin; }
    public TBfr_RadioButton Portrait { get => FPortrait; }
    public TBfr_RadioButton Paysage { get => FPaysage; }
    public TBfr_RadioButton A4 { get => FA4; }
    public TBfr_RadioButton A3 { get => FA3; }
    public TBfr_RadioButton DataLikeOnScreen { get => FDataLikeOnScreen; }
    public TBfr_RadioButton Xls { get => FXls; }
    public TBfr_RadioButton XlsBrut { get => FXlsBrut; }
    public TBfr_RadioButton Csv { get => FCsv; }
    public TBfr_RadioButton Pdf { get => FPdf; }
    public TBfr_RadioButton Xlsx { get => FXlsx; }
    public TBfr_RadioButton XlsxBrut { get => FXlsxBrut; }
    public bool PCompatibiliteImportVisible { set { FCompatibiliteImport.Visible = value; FExpImp.Checked = false; } }
    public bool PLikeOnScreenVisible { set => FLikeOnScreenVisible.Visible = value; }
}