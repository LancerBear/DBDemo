<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="QueryGrade.aspx.cs" Inherits="DBDemo.Admin.QueryGrade" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:RadioButtonList ID="RadioButtonList1" runat="server">

    </asp:RadioButtonList>
    <br />
    <asp:Button ID="queryAvgBt" runat="server" Text="查询" OnClick="queryAvgBt_Click" />

    <hr />

    <asp:Label ID="Lable1" runat="server" Text="平均成绩:" Width="100px"></asp:Label>
    <asp:Label ID="AvgLable" runat="server" Text="N/A"></asp:Label>

    <br />
    <br />


    <asp:Label ID="Label1" runat="server" Text="最高成绩:" Width="100px"></asp:Label>
    <asp:Label ID="MaxLable" runat="server" Text="N/A"></asp:Label>

    <br />
    <br />

    <asp:Label ID="Label3" runat="server" Text="最低成绩:" Width="100px"></asp:Label>
    <asp:Label ID="MinLable" runat="server" Text="N/A"></asp:Label>

    <br />
    <br />

</asp:Content>
