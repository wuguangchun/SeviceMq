<%@ Page Language="C#" AutoEventWireup="true" ValidateRequest="false" EnableEventValidation="false" %>
<%@ Register TagPrefix="subsonic" Namespace="SubSonic" Assembly="SubSonic" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Scaffold Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <subsonic:Scaffold ID="scaffold" runat="server" UseEmbeddedStyles="true" ScaffoldType="Normal" TableName="Categories" ProviderName="Northwind"></subsonic:Scaffold>
    </div>
    </form>
</body>
</html>
