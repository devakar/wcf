<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="HelloWebClient.WebForm1" %>

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
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                        <asp:Button ID="Button1" runat="server" Text="Get Message" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="LabelMsg" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
           </table>

    </div>
    </form>
</body>
</html>
