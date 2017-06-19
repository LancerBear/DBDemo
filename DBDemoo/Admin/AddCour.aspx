<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddCour.aspx.cs" Inherits="DBDemo.Admin.AddCour" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="Label4" runat="server" Text="已有课程:"></asp:Label>
    <br />
    <asp:CheckBoxList ID="CheckBoxList1" runat="server">

    </asp:CheckBoxList>
    <asp:Button ID="cancelCourBt" runat="server" Text="取消课程" OnClick="cancelCourBt_Click" style="height: 21px" />

    <hr />

    <asp:Label ID="Label1" runat="server" Text="课程号:"></asp:Label>
    <asp:TextBox ID="CnoTB" runat="server"></asp:TextBox>

    <hr />

    <asp:Label ID="Label2" runat="server" Text="课程名:"></asp:Label>
    <asp:TextBox ID="CnameTB" runat="server"></asp:TextBox>

    <hr />

    <asp:Label ID="Label3" runat="server" Text="学分:"></asp:Label>
    <asp:TextBox ID="CcreditTB" runat="server"></asp:TextBox>

    <hr />

    <asp:Button ID="submitBt" runat="server" Text="确认提交" OnClick="submitBt_Click" />
</asp:Content>
