﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="practice.aspx.cs" Inherits="Sample2.practice" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>
                    First Name
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Last Name
                </td>
                <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
