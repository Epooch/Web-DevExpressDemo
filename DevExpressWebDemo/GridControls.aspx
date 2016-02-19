<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridControls.aspx.cs" Inherits="DevExpressWebDemo.GridControls" %>

<%@ Register assembly="DevExpress.Web.v15.2, Version=15.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dxw" %>

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
        <a href="https://www.youtube.com/watch?v=-rqxsCR5L5E">Awesome DevExpress GridView Tutorial</a>
    </div>
        <div id="divEpukDemoGrid">
            <dxw:ASPxGridView ID="dxgvGridViewDemo" runat="server" Width="345px" AutoGenerateColumns="False" DataSourceID="GridViewTest1DataSource" KeyFieldName="ProductID">
                <%-- NamingConvention: dxgvUniqueName --%>
                <%-- Prefix: dxgv [DevExpressGridView] --%>
                <%-- Any other standards to be aware of ? --%>
                <Columns>
                    <dxw:GridViewCommandColumn ShowDeleteButton="True" ShowEditButton="True" ShowNewButtonInHeader="True" VisibleIndex="0">
                    </dxw:GridViewCommandColumn>
                    <dxw:GridViewDataTextColumn FieldName="ProductID" ReadOnly="True" ShowInCustomizationForm="True" VisibleIndex="1">
                    </dxw:GridViewDataTextColumn>
                    <dxw:GridViewDataTextColumn FieldName="ProductName" ShowInCustomizationForm="True" VisibleIndex="2">
                    </dxw:GridViewDataTextColumn>
                    <dxw:GridViewDataTextColumn FieldName="SupplierID" ShowInCustomizationForm="True" VisibleIndex="3">
                    </dxw:GridViewDataTextColumn>
                    <dxw:GridViewDataTextColumn FieldName="CategoryID" ShowInCustomizationForm="True" VisibleIndex="4">
                    </dxw:GridViewDataTextColumn>
                    <dxw:GridViewDataTextColumn FieldName="QuantityPerUnit" ShowInCustomizationForm="True" VisibleIndex="5">
                    </dxw:GridViewDataTextColumn>
                    <dxw:GridViewDataTextColumn FieldName="UnitPrice" ShowInCustomizationForm="True" VisibleIndex="6">
                    </dxw:GridViewDataTextColumn>
                    <dxw:GridViewDataTextColumn FieldName="UnitsInStock" ShowInCustomizationForm="True" VisibleIndex="7">
                    </dxw:GridViewDataTextColumn>
                    <dxw:GridViewDataTextColumn FieldName="UnitsOnOrder" ShowInCustomizationForm="True" VisibleIndex="8">
                    </dxw:GridViewDataTextColumn>
                    <dxw:GridViewDataTextColumn FieldName="ReorderLevel" ShowInCustomizationForm="True" VisibleIndex="9">
                    </dxw:GridViewDataTextColumn>
                    <dxw:GridViewDataCheckColumn FieldName="Discontinued" ShowInCustomizationForm="True" VisibleIndex="10">
                    </dxw:GridViewDataCheckColumn>
                    <dxw:GridViewDataTextColumn FieldName="CategoryName" ShowInCustomizationForm="True" VisibleIndex="11">
                    </dxw:GridViewDataTextColumn>
                </Columns>
<Styles AdaptiveDetailButtonWidth="22"></Styles>
            </dxw:ASPxGridView>
            <asp:SqlDataSource ID="GridViewTest1DataSource" runat="server" ConnectionString="Data Source=GFE-8300-02\SQLEXPRESS;Initial Catalog=NORTHWND;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Alphabetical list of products]"></asp:SqlDataSource>
        </div>
        <%--<div id="divEpukGrid" runat="server" visible="false">
            <%-- DO NOT SET THE GRIDVIEW TO  EnableRowsCache="true", IT WILL CAUSE POSTBACK DATABINDING ISSUES!!!!!
            <dxw:ASPxGridView ID="CustomizableGridView" runat="server"
                AutoGenerateColumns="false" EnableCallBacks="false" EnableRowsCache="false"
                CssFilePath="<%$ Resources:WebResources, DevExpressVariableCssPath %>" CssPostfix="<%$ Resources:WebResources, DevExpressCssPostfix %>"
                OnRowDeleting="CustomizableGridView_RowDeleting" OnRowUpdating="CustomizableGridView_RowUpdating"
                OnHtmlRowPrepared="CustomizableGridView_HtmlRowPrepared" OnCustomButtonCallback="CustomizableGridView_CustomButtonCallback"
                onhtmlcommandcellprepared="CustomizableGridView_HtmlCommandCellPrepared" 
                onhtmldatacellprepared="CustomizableGridView_HtmlDataCellPrepared" 
                onfocusedrowchanged="CustomizableGridView_FocusedRowChanged"
                 Width="100%" onhtmlrowcreated="CustomizableGridView_HtmlRowCreated">
                <Settings ShowFilterRow="False" ShowFooter="False" ShowGroupPanel="True" ShowTitlePanel="True" />
                <SettingsBehavior AllowFocusedRow="False" />
                <SettingsPager PageSize="5" NumericButtonCount="5" Position="Bottom">
                    <PageSizeItemSettings Visible="false" Items="10, 20, 50" />
                </SettingsPager>
                <Styles>
                    <AlternatingRow Enabled="true" />
                </Styles>
                <Images ImageFolder="<%$ Resources:WebResources, DevExpressImagesVariablePath %>">
                    <CollapsedButton Url="<%$ Resources:WebResources, DevExpressGridViewCollapseImageUrl %>"
                        Width="15px" Height="15px" />
                    <ExpandedButton Url="<%$ Resources:WebResources, DevExpressGridViewExpandImageUrl %>"
                        Width="15px" Height="15px" />
                </Images>
            </dxw:ASPxGridView>
        </div>--%>
    </form>
</body>
</html>
