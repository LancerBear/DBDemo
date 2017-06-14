<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StuInfo.aspx.cs" Inherits="DBDemo.Account.StuInfo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div align ="center">
        <asp:Label ID="Label1" runat="server" Text="学号:"></asp:Label>
        <asp:Label ID="sidLable" runat="server" Text="N/A"></asp:Label>
        <br />
        <asp:Label ID="Label2" runat="server" Text="姓名:"></asp:Label>
        <asp:Label ID="snameLable" runat="server" Text="N/A"></asp:Label>
        <br />
        <asp:Label ID="Label3" runat="server" Text="性别:"></asp:Label>
        <asp:Label ID="ssexLable" runat="server" Text="N/A"></asp:Label>
        <br />
        <asp:Label ID="Label4" runat="server" Text="生日:"></asp:Label>
        <asp:Label ID="sbirthLable" runat="server" Text="N/A"></asp:Label>
        <br />
        <asp:Label ID="Label5" runat="server" Text="系别:"></asp:Label>
        <asp:Label ID="sdeptLable" runat="server" Text="N/A"></asp:Label>
    </div>
</asp:Content>
