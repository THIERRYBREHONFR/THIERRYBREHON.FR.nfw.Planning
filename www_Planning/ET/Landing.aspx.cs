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

public partial class Landing : ETForm
{
    protected override bool RequiredAuthentication => false;
        protected override string ObjectName => "Landing : ";
        protected override string PageTitle => "Accueil";

    protected override void Page_PreRender(object sender, EventArgs e)
    {
        base.Page_PreRender(sender, e);
    }

}
