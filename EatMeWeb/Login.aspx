<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EatMeWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br /><br />
   
    <img src="./Content/images/EatMe.png" height="125" />
    <p>
        <br />
    </p>
    <p>
        Login Name</p>
    <p>
        <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
    </p>
    <p>
        Password</p>
    <p>
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
    </p>
   

</asp:Content>
