<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DBDemo.Acount.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 25px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <div >
        <table border="1" style="margin: 10px auto" align=center>  
                <tr>  
                    <th>  
                        <asp:Label ID="Label1" runat="server" Text="学号"></asp:Label>  
                    </th>  
                    <td>  
                        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>  
                    </td>  
                </tr>  
                <tr>  
                    <th class="auto-style1">  
                        <asp:Label ID="Label2" runat="server" Text="密码"></asp:Label>  
  
                    </th>  
                    <td class="auto-style1">  
                        <asp:TextBox ID="txtPassWord" runat="server" TextMode="Password"></asp:TextBox>  
  
                    </td>  
                </tr>  
                <tr>  
                    <td>  
                        <div align="center" style="width: 85px">
                            <asp:Button ID="submit" runat="server" Text="登陆" OnClick="submit_Click" />  
                        </div>
                    </td> 
                </tr>  
  
            </table>
    </div>
</asp:Content>
