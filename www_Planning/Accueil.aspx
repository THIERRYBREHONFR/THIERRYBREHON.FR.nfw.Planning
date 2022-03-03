<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Accueil.aspx.cs" Inherits="Accueil" %>

<!DOCTYPE html>
<html>
<head>
    <title>default</title>
    <script src="Commun/Scripts/jquery.min.js"></script>
    <script src="Commun/Scripts/THIERRYBREHON.FR.js"></script>
    <script src="Commun/Scripts/THIERRYBREHON.FR.ACCORDION.js"></script>
    <script src="Commun/Scripts/THIERRYBREHON.FR.3DPrinter.js"></script>
    <link href="Commun/Styles/THIERRYBREHON.FR.ACCORDION.js.css" rel="stylesheet" />
    <link href="Commun/Styles/THIERRYBREHON.FR.ACCORDION.css" rel="stylesheet" />
    <script> 
        $(document).ready(function () { TBfr_printer3DInstall("TBfr_3DPRINT_2", 250, 25, 4); TBfr_printer3DInstall("TBfr_3DPRINT", 250, 25, 4); });
    </script>
</head>
<body style="background-color: aqua;">
    <ul>
        <li class="TBfr_ACCORDION_GROUP_JS TBfr_ACCORDION_GROUP_CSS">
            <!--<ul>
                <li class="TBfr_ACCORDION_HIDE_ALL_JS TBfr_ACCORDION_HIDE_ALL_CSS"></li>
                <li class="TBfr_ACCORDION_SHOW_ALL_JS TBfr_ACCORDION_SHOW_ALL_CSS"></li>
            </ul>-->
            <ul>
                <li>TBfr_ACCORDION_HEADER</li>
                <li>TBfr_ACCORDION_BODY</li>
            </ul>
            <ul>
                <li>TBfr_ACCORDION_HEADER</li>
                <li class="TBfr_ACCORDION_GROUP_JS TBfr_ACCORDION_GROUP_CSS">
                    <!--<ul>
                        <li class="TBfr_ACCORDION_HIDE_ALL_JS TBfr_ACCORDION_HIDE_ALL_CSS"></li>
                        <li class="TBfr_ACCORDION_SHOW_ALL_JS TBfr_ACCORDION_SHOW_ALL_CSS"></li>
                    </ul>-->
                    <ul>
                        <li>TBfr_ACCORDION_HEADER</li>
                        <li>TBfr_ACCORDION_BODY</li>
                    </ul>
                    <ul>
                        <li>TBfr_ACCORDION_HEADER</li>
                        <li>TBfr_ACCORDION_BODY</li>
                    </ul>
                </li>
            </ul>
            <img id="TBfr_3DPRINT" src="Commun/Images/headPrinter.png" style="position: absolute;" />
        </li>
        <li class="TBfr_ACCORDION_NOGROUP_JS TBfr_ACCORDION_NOGROUP_CSS">
            <ul>
                <li class="TBfr_ACCORDION_HIDE_ALL_JS TBfr_ACCORDION_HIDE_ALL_CSS"></li>
                <li class="TBfr_ACCORDION_SHOW_ALL_JS TBfr_ACCORDION_SHOW_ALL_CSS"></li>
            </ul>
            <ul>
                <li>TBfr_ACCORDION_HEADER</li>
                <li>TBfr_ACCORDION_BODY</li>
            </ul>
            <ul>
                <li>TBfr_ACCORDION_HEADER</li>
                <li class="TBfr_ACCORDION_NOGROUP_JS TBfr_ACCORDION_NOGROUP_CSS">
                    <ul>
                        <li class="TBfr_ACCORDION_HIDE_ALL_JS TBfr_ACCORDION_HIDE_ALL_CSS">Hide</li>
                        <li class="TBfr_ACCORDION_SHOW_ALL_JS TBfr_ACCORDION_SHOW_ALL_CSS">Show</li>
                    </ul>
                    <ul>
                        <li>TBfr_ACCORDION_HEADER</li>
                        <li>TBfr_ACCORDION_BODY</li>
                    </ul>
                    <ul>
                        <li>TBfr_ACCORDION_HEADER</li>
                        <li>TBfr_ACCORDION_BODY</li>
                    </ul>
                    <img id="TBfr_3DPRINT_2" src="Commun/Images/headPrinter.png" style="position: absolute;" />
                </li>
            </ul>
        </li>
    </ul>

</body>
</html>
