<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <h2> All people in the directory </h2>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
            <asp:BoundField DataField="MiddleName" HeaderText="MiddleName" SortExpression="MiddleName" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [FirstName], [MiddleName], [LastName] FROM [Table]"></asp:SqlDataSource>
    <br />
    <asp:Label ID="Label1" Text=" To view address of this people click the 'View Address' button" runat = "server"/>
    <asp:Button runat="server" ID="Button1" text="View Address" runat ="server"/>
    <br />
</asp:Content>
