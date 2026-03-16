<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebFormsApp.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
        <h2 id="title">
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="https://www.google.com" Target="_blank" ToolTip="External Site">Click Me!</asp:HyperLink>
    </h2>
    <h2>
        <asp:ImageButton ID="ImageButton1" runat="server" Height="48px" ImageUrl="https://toppng.com/free-image/minions-png-transparent-image-minion-stuart-PNG-free-PNG-Images_185517" />
        <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="https://toppng.com/free-image/minions-png-transparent-image-minion-stuart-PNG-free-PNG-Images_185517" />
        <asp:HyperLink ID="HyperLink2" runat="server" ImageUrl="https://toppng.com/free-image/minions-png-transparent-image-minion-stuart-PNG-free-PNG-Images_185517">HyperLink</asp:HyperLink>
        <asp:HyperLink ID="HyperLink3" runat="server" ImageUrl="https://toppng.com/free-image/minions-png-transparent-image-minion-stuart-PNG-free-PNG-Images_185517">Image Link</asp:HyperLink>
    </h2>
    <h2>&nbsp;</h2>
    <h2>&nbsp;</h2>
    <h2>&nbsp;</h2>
    <h2><%: Title %>.</h2>
        <h3>Your application description page.</h3>
        <p>Use this area to provide additional information.</p>
    </main>
</asp:Content>
