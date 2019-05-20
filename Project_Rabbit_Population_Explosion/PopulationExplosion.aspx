<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PopulationExplosion.aspx.cs" Inherits="Project_Rabbit_Population_Explosion.PopulationExplosion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h1>Population Explosion</h1>
    <h2>Please enter the Maxium Population number</h2>
    
    <asp:Label ID="Label1" runat="server" Text="Results :"></asp:Label>
   
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <hr />
     <asp:Label ID="Label2" runat="server" ></asp:Label>
    <hr />

    <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />













</asp:Content>
