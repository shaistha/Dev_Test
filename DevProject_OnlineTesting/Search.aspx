<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="DevProject_OnlineTesting.Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table id="table1"; cellspacing="5px" cellpadding="5%" border="0">  
                <tr>
                    <td>
                        <asp:Label ID="lblKeyword" runat="server" Text="Label">Enter a Keyword</asp:Label>
                    </td>
                    <td>
                         <asp:TextBox ID="txtKeyword" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblUrl" runat="server" Text="Label">Enter URL</asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtUrl" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                      <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click"/>
                    </td>
                </tr>

                 <tr>
                    <td>
                      <p id="result" runat ="server">
                      </p>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
