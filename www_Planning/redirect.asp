<%
EnableSessionState=False
host = Request.ServerVariables("HTTP_HOST")
'if host = "thierrybrehon.fr" or host = "www.thierrybrehon.fr" then 
    response.redirect("https://www.thierrybrehon.fr/login.aspx")
'else response.redirect("https://www.thierrybrehon.fr/redirecterror.html")
'end if
%>