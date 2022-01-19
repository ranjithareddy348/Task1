<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication2.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body{
            background-color:aqua;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="margin:auto;border:5px solid black">
                <tr>
                    <td> <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label> </td>
                    <td> <asp:TextBox ID="textUsername" runat="server"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td> <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label> </td>
                    <td> <asp:TextBox ID="textPassword" runat="server" TextMode="Password"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td> <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click1" /></td>
                </tr>
                <tr>
                    <td> <asp:Label ID="lblErrorMessage" runat="server" Text="Incorrect User Credentials"></asp:Label> </td>
                </tr>
            </table>
            
        </div>
    </form>
</body>
</html>
