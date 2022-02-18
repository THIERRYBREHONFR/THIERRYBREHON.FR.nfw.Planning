using DevExpress.Web;
using DevExpress.Web.ASPxPivotGrid;
using DevExpress.XtraPivotGrid.Customization;
using System;
using System.Linq;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;
using THIERRYBREHON.FR.X;
using THIERRYBREHON.FR.Web;
namespace Planning.NSP

{
    static class PL_Const
    {
        public const string Padding = "5px";
        public const double FontSize = 18;
        public const UnitType FontUnit = UnitType.Pixel;
    }

    [ToolboxData("<{0}:PL_RoundPanel runat=server></{0}:PL_RoundPanel>")]
    [ToolboxBitmap(typeof(PL_RoundPanel), "PL_RoundPanel")]
    public class PL_RoundPanel : TBfr_RoundPanel
    {
        public PL_RoundPanel()
            : base()
        {
            //CornerRadius = 0;
            //this.HeaderStyle.BackColor = Color.Gray;
            //this.HeaderStyle.ForeColor = Color.White;
            //this.BackColor = Color.White;
            //this.HeaderStyle.Font.Size = new FontUnit(120, UnitType.Percentage);
        }
    }

    [ToolboxData("<{0}:PL_ImageButton runat=server></{0}:PL_ImageButton>")]
    [ToolboxBitmap(typeof(PL_ImageButton), "PL_ImageButton")]
    public class PL_ImageButton : TBfr_ImageButton
    {
        public PL_ImageButton()
            : base()
        {
        }
    }

    [ToolboxData("<{0}:PL_HyperLink runat=server></{0}:PL_HyperLink>")]
    [ToolboxBitmap(typeof(PL_HyperLink), "PL_HyperLink")]
    public class PL_HyperLink : TBfr_HyperLink
    {
        public PL_HyperLink()
            : base()
        {
        }
    }

    [ToolboxData("<{0}:PL_Button runat=server></{0}:PL_Button>")]
    [ToolboxBitmap(typeof(PL_Button), "PL_Button")]
    public class PL_Button : TBfr_Button
    {
        public PL_Button()
            : base()
        {
        }
    }

    [ToolboxData("<{0}:PL_CheckBox runat=server></{0}:PL_CheckBox>")]
    [ToolboxBitmap(typeof(PL_CheckBox), "PL_CheckBox")]
    public class PL_CheckBox : TBfr_CheckBox
    {
        public PL_CheckBox()
            : base()
        {
            //Style.Add("Padding", PL_Const.Padding);
            //Font.Size = new FontUnit(PL_Const.FontSize, PL_Const.FontUnit);
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            //if (Look == "CURSOR")
            //{
            //    CheckedImage.Url = "~/Commun/Images/Check.PNG";
            //    CheckedImage.Height = Unit.Pixel(14);
            //    CheckedImage.Width = Unit.Pixel(24);
            //    UncheckedImage.Url = "~/Commun/Images/UnCheck.PNG";
            //    UncheckedImage.Height = Unit.Pixel(14);
            //    UncheckedImage.Width = Unit.Pixel(24);
            //}
        }

        [DefaultValue(false)]
        public override bool ReadOnly
        {
            get
            {
                return base.ReadOnly;
            }
            set
            {
                base.ReadOnly = value;
                //BackColor = value ? Color.FromArgb(221, 221, 221) : Color.White;
            }
        }
    }

    [ToolboxData("<{0}:PL_ComboBox runat=server></{0}:PL_ComboBox>")]
    [ToolboxBitmap(typeof(PL_ComboBox), "PL_ComboBox")]
    public class PL_ComboBox : TBfr_ComboBox
    {
        public PL_ComboBox()
            : base()
        {
            //Style.Add("Padding", PL_Const.Padding);
            //Font.Size = new FontUnit(PL_Const.FontSize, PL_Const.FontUnit);
            //ReadOnlyStyle.BackColor = Color.FromArgb(221, 221, 221);
        }
    }

    [ToolboxData("<{0}:PL_DateEdit runat=server></{0}:PL_DateEdit>")]
    [ToolboxBitmap(typeof(PL_DateEdit), "PL_DateEdit")]
    public class PL_DateEdit : TBfr_DateEdit
    {
        public PL_DateEdit()
            : base()
        {
            //ReadOnlyStyle.BackColor = Color.FromArgb(221, 221, 221);
            //Style.Add("Padding", PL_Const.Padding);
            //Font.Size = new FontUnit(PL_Const.FontSize, PL_Const.FontUnit);
        }
    }

    [ToolboxData("<{0}:PL_DateTimeEdit runat=server></{0}:PL_DateTimeEdit>")]
    [ToolboxBitmap(typeof(PL_DateTimeEdit), "PL_DateTimeEdit")]
    public class PL_DateTimeEdit : TBfr_DateTimeEdit
    {
        public PL_DateTimeEdit()
            : base()
        {
            //ReadOnlyStyle.BackColor = Color.FromArgb(221, 221, 221);
            //Style.Add("Padding", PL_Const.Padding);
            //Font.Size = new FontUnit(PL_Const.FontSize, PL_Const.FontUnit);
        }
    }

    [ToolboxData("<{0}:PL_DropDownEdit runat=server></{0}:PL_DropDownEdit>")]
    [ToolboxBitmap(typeof(PL_DropDownEdit), "PL_DropDownEdit")]
    public class PL_DropDownEdit : TBfr_DropDownEdit//, ITBfr_Control
    {
        public PL_DropDownEdit()
            : base()
        {
            //DropDownWindowStyle.BackColor = Color.FromArgb(237, 237, 237);
            ////DropDownWindowTemplate = new BA_DropDownEditListBoxTemplate();
            ////ListBox.TextField = fTextField;
            ////ListBox.ValueField = fValueField;
            ////ListBox.ClientInstanceName = fTemplateClientInstanceName;
            ////ListBox.ClientSideEvents.SelectedIndexChanged = fTemplateOnSelectedIndexChanged;

            //ReadOnlyStyle.BackColor = Color.FromArgb(221, 221, 221);
            //Style.Add("Padding", PL_Const.Padding);
            //Font.Size = new FontUnit(PL_Const.FontSize, PL_Const.FontUnit);
        }

        //private string fTextField;
        //private string fValueField;
        //private string fTemplateClientInstanceName;
        //private string fTemplateOnSelectedIndexChanged;

        ////public TBfr_ListBox ListBox { get { return (CL_ListBox)FindControl("TemplateListBox"); } }
        //public string TextField { set { if (ListBox != null) ListBox.TextField = value; fTextField = value; } }
        //public string ValueField { set { if (ListBox != null) ListBox.ValueField = value; fValueField = value; } }
        //public string TemplateClientInstanceName { set { if (ListBox != null) ListBox.ClientInstanceName = value; fTemplateClientInstanceName = value; } }
        //public string TemplateOnSelectedIndexChanged { set { if (ListBox != null) ListBox.ClientSideEvents.SelectedIndexChanged = value; fTemplateOnSelectedIndexChanged = value; } }

        //private string _value;

        //public string TexteAffiche
        //{
        //  get
        //  {
        //    if (SelectedIndex == -1)
        //      return null;
        //    else
        //      return Items[SelectedIndex].Text;
        //  }
        //}

        //public string Valeur { get { return Value == null ? string.Empty : Value.ToString(); } set { Value = value; /*_value = value;*/ } }

        //public bool Masque { get { return !Visible; } set { Visible = !value; } }

        //public string NavigatorValue(HttpRequest request) { throw new NotSupportedException("BA_DropDownEdit.NavigatorValue"); }

        //protected override void OnDataBound(EventArgs e)
        //{
        //  base.OnDataBound(e);
        //  if (_value.IsCompleted())
        //    Valeur = _value;
        //}
    }

    [ToolboxData("<{0}:PL_GridView runat=server></{0}:PL_GridView>")]
    [ToolboxBitmap(typeof(PL_GridView), "PL_GridView")]
    public class PL_GridView : TBfr_GridView
    {
        public PL_GridView()
            : base()
        {

            //Width = Unit.Percentage(100);

            //StylesPager.Summary.Font.Bold = true;
            //StylesPager.Summary.ForeColor = Color.Black;
            //StylesPager.PageNumber.ForeColor = Color.Black;

            //Styles.Header.BackColor = Color.FromArgb(79, 46, 41);//#4F2E29
            //Styles.Header.ForeColor = Color.White;
            //Styles.Header.Font.Bold = true;

            //Styles.FilterRow.BackColor = Color.FromArgb(79, 46, 41);//System.Drawing.Color.FromArgb(255, 204, 153);

            //StylesPager.Summary.Font.Size = FontUnit.Parse("14px");
        }

        public override void ColumnsReadOnly()
        {
            ColumnsReadOnly(Color.FromArgb(218, 193, 186));//#DAC1BA
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            if (ModeAffichage == DisplayMode.Adaptative)
            {
                ////Width = Unit.Percentage(100);
                //Settings.HorizontalScrollBarMode = ScrollBarMode.Hidden;
                //SettingsAdaptivity.AdaptivityMode = GridViewAdaptivityMode.HideDataCellsWindowLimit;
                //SettingsAdaptivity.HideDataCellsAtWindowInnerWidth = (PasserEnModeAdaptatifAtEcranLargeur == 0) ?
                //                                                                Convert.ToInt32(VisibleColumns.Select(x => x.Width.Value).Sum())
                //                                                                : PasserEnModeAdaptatifAtEcranLargeur;
                //SettingsAdaptivity.AllowOnlyOneAdaptiveDetailExpanded = true;
                //SettingsAdaptivity.AdaptiveDetailColumnCount = NbreColsVisiblesEnModeAdaptative;
            }
        }
    }

    public class PL_GridViewPostBackButtonsTemplate : TBfr_GridViewPostBackButtonsTemplate
    {
        public PL_GridViewPostBackButtonsTemplate(ImageClickEventHandler editButton_Click, ImageClickEventHandler duplicateButton_Click,
    ImageClickEventHandler archiveButton_Click, ImageClickEventHandler visualizationButton_Click,
    string editImageUrl, string duplicateImageUrl, string archiveImageUrl, string visualizationImageUrl)
: base(editButton_Click, duplicateButton_Click, archiveButton_Click, visualizationButton_Click,
     editImageUrl, duplicateImageUrl, archiveImageUrl, visualizationImageUrl)
        {
        }

        public override ImageButton CreateButton() => new PL_ImageButton();
    }

    [ToolboxData("<{0}:PL_HtmlEditor runat=server></{0}:PL_HtmlEditor>")]
    [ToolboxBitmap(typeof(PL_HtmlEditor), "PL_HtmlEditor")]
    public class PL_HtmlEditor : TBfr_HtmlEditor
    {
        public PL_HtmlEditor()
            : base() { }
    }

    [ToolboxData("<{0}:PL_Label runat=server></{0}:PL_Label>")]
    [ToolboxBitmap(typeof(PL_Label), "PL_Label")]
    public class PL_Label : TBfr_Label
    {
        public PL_Label()
                 : base()
        {
            //Style.Add("Padding", PL_Const.Padding);
            //Font.Size = new FontUnit(PL_Const.FontSize, PL_Const.FontUnit);
        }
    }

    [ToolboxData("<{0}:PL_ListBox runat=server></{0}:PL_ListBox>")]
    [ToolboxBitmap(typeof(PL_ListBox), "PL_ListBox")]
    public class PL_ListBox : TBfr_ListBox
    {
        public PL_ListBox()
            : base()
        {
            //ReadOnlyStyle.BackColor = Color.FromArgb(221, 221, 221);
            //Style.Add("Padding", PL_Const.Padding);
            //Font.Size = new FontUnit(PL_Const.FontSize, PL_Const.FontUnit);
        }
    }

    [ToolboxData("<{0}:PL_Memo runat=server></{0}:PL_Memo>")]
    [ToolboxBitmap(typeof(PL_Memo), "PL_Memo")]
    public class PL_Memo : TBfr_Memo
    {
        public PL_Memo()
            : base()
        {
            //ReadOnlyStyle.BackColor = Color.FromArgb(221, 221, 221);
            //Rows = 5;
            //Style.Add("Padding", PL_Const.Padding);
            //Font.Size = new FontUnit(PL_Const.FontSize, PL_Const.FontUnit);
        }
    }

    [ToolboxData("<{0}:PL_DropDownEditMultiListBoxTemplate runat=server></{0}:PL_DropDownEditMultiListBoxTemplate>")]
    [ToolboxBitmap(typeof(PL_DropDownEditMultiListBoxTemplate), "PL_DropDownEditMultiListBoxTemplate")]
    public class PL_DropDownEditMultiListBoxTemplate : TBfr_DropDownEditMultiListBoxTemplate
    {
        //public override void InstantiateIn(Control container)
        //{
        //    TBfr_ListBox fListBox = new TBfr_ListBox();
        //    fListBox.ID = "TemplateListBox";
        //    fListBox.SelectionMode = ListEditSelectionMode.CheckColumn;
        //    fListBox.Width = Unit.Percentage(100);
        //    fListBox.Border.BorderStyle = BorderStyle.None;
        //    fListBox.BorderBottom.BorderStyle = BorderStyle.Solid;
        //    fListBox.BorderBottom.BorderWidth = Unit.Pixel(1);
        //    fListBox.Rows = 5;
        //    container.Controls.Add(fListBox);
        //}
    }

    [ToolboxData("<{0}:PL_DropDownEditMulti runat=server></{0}:PL_DropDownEditMulti>")]
    [ToolboxBitmap(typeof(PL_DropDownEditMulti), "PL_DropDownEditMulti")]
    public class PL_DropDownEditMulti : TBfr_DropDownEditMulti
    {
        public PL_DropDownEditMulti()
            : base()
        {
            //DropDownWindowStyle.BackColor = Color.FromArgb(237, 237, 237);
            //DropDownWindowTemplate = new BA_DropDownEditMultiListBoxTemplate();
            //ListBox.TextField = fTextField;
            //ListBox.ValueField = fValueField;
            //ListBox.ClientInstanceName = fTemplateClientInstanceName;
            //ListBox.ClientSideEvents.SelectedIndexChanged = fTemplateOnSelectedIndexChanged;

            //ReadOnlyStyle.BackColor = Color.FromArgb(221, 221, 221);

            //Style.Add("Padding", PL_Const.Padding);
            //Font.Size = new FontUnit(PL_Const.FontSize, PL_Const.FontUnit);

        }
    }

    [ToolboxData("<{0}:PL_PivotCustomizationControl runat=server></{0}:PL_PivotCustomizationControl>")]
    [ToolboxBitmap(typeof(PL_PivotCustomizationControl), "PL_PivotCustomizationControl")]
    public class PL_PivotCustomizationControl : TBfr_PivotCustomizationControl
    {
        public PL_PivotCustomizationControl()
            : base()
        {
            //Height = Unit.Pixel(600);
            //Width = Unit.Pixel(300);
        }
    }

    [ToolboxData("<{0}:PL_PivotGrid runat=server></{0}:PL_PivotGrid>")]
    [ToolboxBitmap(typeof(PL_PivotGrid), "PL_PivotGrid")]
    public class PL_PivotGrid : TBfr_PivotGrid
    {
        public PL_PivotGrid()
            : base()
        {
            ////AutoGenerateColumns = false;
            ////Width = Unit.Percentage(100);

            //StylesPager.Summary.Font.Bold = true;
            //StylesPager.Summary.ForeColor = Color.Black;
            //StylesPager.Summary.Font.Size = FontUnit.Parse("14px");
            //StylesPager.PageNumber.ForeColor = Color.Black;

            //Styles.HeaderStyle.BackColor = Color.FromArgb(226, 0, 26);
            //Styles.HeaderStyle.ForeColor = Color.White;
            //Styles.HeaderStyle.Font.Bold = true;

            //OptionsCustomization.CustomizationFormStyle = CustomizationFormStyle.Excel2007;
            //OptionsCustomization.CustomizationFormLayout = CustomizationFormLayout.StackedSideBySide;

            ////SettingsBehavior.EnableCustomizationWindow = true;

            ////Settings.ShowHeaderFilterButton = true;
            ////Settings.ShowFilterRow = true;
            ////Settings.ShowFilterRowMenu = true;

            //BorderBottom.BorderStyle = System.Web.UI.WebControls.BorderStyle.NotSet;
            ////SettingsPager.Mode = PivotGridPagerMode.ShowPager;
            ////SettingsPager.Position = PagerPosition.TopAndBottom;
            ////SettingsPager.PageSizeItemSettings.Visible = true;
            ////SettingsPager.PageSizeItemSettings.ShowAllItem = true;
            //////SettingsPager.PageSizeItemSettings.AllItemText="Tout";

            ////SettingsPopup.CustomizationWindow.Width = new Unit(200, UnitType.Pixel);
            ////SettingsPopup.CustomizationWindow.HorizontalAlign = DevExpress.Web.ASPxClasses.PopupHorizontalAlign.WindowCenter;
            ////SettingsPopup.CustomizationWindow.VerticalAlign = DevExpress.Web.ASPxClasses.PopupVerticalAlign.WindowCenter;

            ////SettingsPopup.HeaderFilter.Height = new Unit(200, UnitType.Pixel);
            ////SettingsPopup.HeaderFilter.Width = new Unit(200, UnitType.Pixel);

            ////SettingsPopup.EditForm.AllowResize = true;
            ////SettingsPopup.EditForm.HorizontalAlign = DevExpress.Web.ASPxClasses.PopupHorizontalAlign.WindowCenter;
            ////SettingsPopup.EditForm.VerticalAlign = DevExpress.Web.ASPxClasses.PopupVerticalAlign.WindowCenter;

            ////GroupSummary.Add(new ASPxSummaryItem("Nombre", DevExpress.Data.SummaryItemType.Count));

            ////Styles.AlternatingRow.Enabled = DevExpress.Utils.DefaultBoolean.True;
            ////      ClientSideEvents.CustomizationFieldsVisibleChanged = @"function(s, e) {
            ////    if(btnCustomPivotGridWindow != null &amp;&amp; pivotGrid != null) {
            ////        btnCustomPivotGridWindow.SetText((pivotGrid.GetCustomizationFieldsVisibility() ? &quot;Hide&quot; : &quot;Show&quot;) + &quot; Customization Window&quot;);
            ////    }
            ////}";
        }
    }

    [ToolboxData("<{0}:PL_RadioButton runat=server></{0}:PL_RadioButton>")]
    [ToolboxBitmap(typeof(PL_RadioButton), "PL_RadioButton")]
    public class PL_RadioButton : TBfr_RadioButton
    {
        public PL_RadioButton()
            : base()
        {
            //Style.Add("Padding", PL_Const.Padding);
            //Font.Size = new FontUnit(PL_Const.FontSize, PL_Const.FontUnit);
        }

        [DefaultValue(false)]
        public override bool ReadOnly
        {
            get
            {
                return base.ReadOnly;
            }
            set
            {
                base.ReadOnly = value;
                //BackColor = value ? Color.FromArgb(221, 221, 221) : Color.White;
            }
        }
    }

    [DefaultProperty("Text")]
    [ToolboxData("<{0}:PL_SpinEdit runat=server></{0}:PL_SpinEdit>")]
    [ToolboxBitmap(typeof(PL_SpinEdit), "PL_SpinEdit")]
    public class PL_SpinEdit : TBfr_SpinEdit
    {

        public PL_SpinEdit()
            : base()
        {
            //ReadOnlyStyle.BackColor = Color.FromArgb(221, 221, 221);
            //Style.Add("Padding", PL_Const.Padding);
            //Font.Size = new FontUnit(PL_Const.FontSize, PL_Const.FontUnit);
        }
    }

    [DefaultProperty("Text")]
    [ToolboxData("<{0}:PL_TextBox runat=server></{0}:PL_TextBox>")]
    [ToolboxBitmap(typeof(PL_TextBox), "PL_TextBox")]
    public class PL_TextBox : TBfr_TextBox
    {
        public PL_TextBox()
            : base()
        {
            //ReadOnlyStyle.BackColor = Color.FromArgb(221, 221, 221);
            //Style.Add("Padding", PL_Const.Padding);
            //Font.Size = new FontUnit(PL_Const.FontSize, PL_Const.FontUnit);
        }
    }

    [DefaultProperty("Text")]
    [ToolboxData("<{0}:PL_TimeEdit runat=server></{0}:PL_TimeEdit>")]
    [ToolboxBitmap(typeof(PL_TimeEdit), "PL_TimeEdit")]
    public class PL_TimeEdit : TBfr_TimeEdit
    {
        public PL_TimeEdit()
            : base()
        {
            //ReadOnlyStyle.BackColor = Color.FromArgb(221, 221, 221);
            //Style.Add("Padding", PL_Const.Padding);
            //Font.Size = new FontUnit(PL_Const.FontSize, PL_Const.FontUnit);
        }
    }

    [DefaultProperty("Text")]
    [ToolboxData("<{0}:PL_TokenBox runat=server></{0}:PL_TokenBox>")]
    [ToolboxBitmap(typeof(PL_TokenBox), "PL_TokenBox")]
    public class PL_TokenBox : TBfr_TokenBox
    {

        public PL_TokenBox()
            : base()
        {
            //ReadOnlyStyle.BackColor = Color.FromArgb(221, 221, 221);
            //Style.Add("Padding", PL_Const.Padding);
            //Font.Size = new FontUnit(PL_Const.FontSize, PL_Const.FontUnit);
        }
    }

    [DefaultProperty("Text")]
    [ToolboxData("<{0}:PL_TrackBar runat=server></{0}:PL_TrackBar>")]
    [ToolboxBitmap(typeof(PL_TrackBar), "PL_TrackBar")]
    public class PL_TrackBar : TBfr_TrackBar
    {
        public PL_TrackBar()
            : base()
        {
            //ReadOnlyStyle.BackColor = Color.FromArgb(221, 221, 221);
            //LeftTopLabelStyle.ForeColor = Color.Black;
            //Style.Add("Padding", PL_Const.Padding);
            //Font.Size = new FontUnit(PL_Const.FontSize, PL_Const.FontUnit);
        }
    }

    [ToolboxData("<{0}:PL_TreeList runat=server></{0}:PL_TreeList>")]
    [ToolboxBitmap(typeof(PL_TreeList), "PL_TreeList")]
    public class PL_TreeList : TBfr_TreeList
    {
        public PL_TreeList() : base()
        {
            //Style.Add("Padding", PL_Const.Padding);
            //Font.Size = new FontUnit(PL_Const.FontSize, PL_Const.FontUnit);
        }
    }

    [DefaultProperty("Text")]
    [ToolboxData("<{0}:PL_Image runat=server></{0}:PL_Image>")]
    [ToolboxBitmap(typeof(PL_Image), "PL_Image")]
    public class PL_Image : TBfr_Image
    {
        public PL_Image() : base()
        {
        }
    }


}
