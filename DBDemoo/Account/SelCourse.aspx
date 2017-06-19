<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SelCourse.aspx.cs" Inherits="DBDemo.Account.SelCourse" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label runat="server" Text="已选课程:"></asp:Label>
    <br />
    <asp:CheckBoxList ID="CheckBoxList2" runat="server">

    </asp:CheckBoxList>
    <br />
    <asp:Button ID="DeSelectButton" runat="server" Text="确认退课" OnClick="DeSelectButton_Click" />
    <hr />
    


    <asp:Label runat="server" Text="未选课程:"></asp:Label>
    <asp:Panel ID="Panel1" runat="server" >
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged">
        
        </asp:CheckBoxList>
        <br />


        <asp:Button ID="submitButton" runat="server" Text="提交选课" OnClick="submitButton_Click" style="height: 21px" />
    </asp:Panel>
</asp:Content>
