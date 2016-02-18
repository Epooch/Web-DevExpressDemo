<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridControls.aspx.cs" Inherits="DevExpressWebDemo.GridControls" %>

<%@ Register assembly="DevExpress.Web.v15.2, Version=15.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>DevExpress: GridView control</h1>
        <h3>Contributers: Eric Calvano</h3>
    </div>
        <dx:ASPxGridView ID="dxgvGridViewDemo" runat="server" Width="345px">
            <%-- NamingConvention: dxgvUniqueName --%>
            <%-- Prefix: dxgv [DevExpressGridView] --%>
            <%-- Any other standards to be aware of ? --%>
        </dx:ASPxGridView>
    </form>
</body>
</html>
