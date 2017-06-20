<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SetGrade.aspx.cs" Inherits="DBDemo.Admin.SetGrade" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="Label1" runat="server" Text="学号:"></asp:Label>
    <asp:TextBox ID="stuIDTB" runat="server" OnTextChanged="stuIDTB_TextChanged"></asp:TextBox>
    <asp:Button ID="submitIDBt" runat="server" Text="确认" OnClick="submitIDBt_Click" />
    <hr />
    <asp:RadioButtonList ID="RadioButtonList1" runat="server">

    </asp:RadioButtonList>

<%--    <asp:Label ID="Label2" runat="server" Text="课程号:"></asp:Label>
    <asp:TextBox ID="cnoTB" runat="server"></asp:TextBox>--%>

    <hr />
    <asp:Label ID="Label3" runat="server" Text="成绩:"></asp:Label>
    <asp:TextBox ID="gradeTB" runat="server"></asp:TextBox>

    <hr />
    <asp:Button ID="submit" runat="server" Text="确认提交" OnClick="submit_Click" />
</asp:Content>
