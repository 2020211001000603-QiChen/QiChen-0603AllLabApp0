<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowListControls.aspx.cs" Inherits="LabAss4.ShowListControls" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div><h1>ListBox</h1>
            <h1>
                <asp:ListBox ID="ListBox1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Username" DataValueField="Username" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"></asp:ListBox>
            </h1></div>
        <div><h1>DroupDownList</h1>
            <h1>
                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Username" DataValueField="Username">
                </asp:DropDownList>
            </h1></div>
        <div><h1>BulletedList</h1>
            <asp:BulletedList ID="BulletedList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Username" DataValueField="Username">
            </asp:BulletedList>
        </div>
        <div><h1>CheckBoxList<asp:CheckBoxList ID="CheckBoxList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="Username" DataValueField="Username">
            </asp:CheckBoxList>
            </h1></div>
        <div><h1>RadioButtonList<asp:RadioButtonList ID="RadioButtonList1" runat="server">
            </asp:RadioButtonList>
            </h1></div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:SimpleDatabaseConnectionString %>" ProviderName="<%$ ConnectionStrings:SimpleDatabaseConnectionString.ProviderName %>" SelectCommand="SELECT [Password], [Username] FROM [Logon]"></asp:SqlDataSource>
    </form>
</body>
</html>
