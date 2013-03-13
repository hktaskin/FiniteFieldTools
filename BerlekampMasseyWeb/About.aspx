<%@ Page Title="About" Language="C#" MasterPageFile="Site.master" AutoEventWireup="true"
    CodeBehind="About.aspx.cs" Inherits="BerlekampMasseyWeb.About" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        About
    </h2>
    <p>
        This web application implements the well-known "Berlekamp-Massey Algorithm" for sequences over any Finite Field. The total library has been written by <a href="http://www.hkt.me/" target="_blank">HKT</a>. 
    </p>
    <p>
    kriptografi.net &copy; <% Response.Write(DateTime.Now.Year.ToString()); %>
    </p>
</asp:Content>
