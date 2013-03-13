<%@ Page Title="Berlekamp-Massey Algorithm for Finite Fields - kriptografi.net" Language="C#" MasterPageFile="Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="BerlekampMasseyWeb._Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <p>
        Please write a prime number (for now only 2,3,5 and 7) to generate the finite field and write the sequence 
        where each element of the sequence should be in the corresponding finite field.</p>
    <p>
        Finite Field of size
        <asp:TextBox ID="txtSize" runat="server" Width="48px">2</asp:TextBox>
    </p>
<p>
        <strong>Sequence</strong><br />
        <asp:TextBox ID="txtSeq" runat="server" Height="136px" Width="493px" 
            TextMode="MultiLine">110100110100011101001000001101111010101101100100010010010111110100001001100010101111000001000110000000101001010101000101110111010111001001110110000101100011111101101011001101101110000111000110101001111100010000110010100000011110111111110011100110011110010</asp:TextBox>
    </p>
<p>
        <asp:Button ID="btnRunBM" runat="server" onclick="btnRunBM_Click" 
            Text="Run the Berlekamp-Massey Algorithm" />
    </p>
<p>
        <strong>Result</strong><br />
        <asp:Label ID="lblResult" runat="server"></asp:Label>
    </p>
</asp:Content>
