<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SendingMail.aspx.cs" Inherits="Email_Integration.SendingMail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 320px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p class="auto-style1">
                &nbsp;</p>
            <p class="auto-style1">
                Email Sending</p>
            <p class="auto-style1">
                Email Id&nbsp; :&nbsp;&nbsp;&nbsp;
                <asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple" Width="233px">
                    <asp:ListItem>rajeshnarkar05@gmail.com</asp:ListItem>
                    <asp:ListItem>vaishnavghangale19@gmail.com</asp:ListItem>
                    <asp:ListItem>rajeshnarkar005@gmail.com</asp:ListItem>
                </asp:ListBox>
                <br class="auto-style1" />
                <br class="auto-style1" />
                Subject :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <br class="auto-style1" />
                <br class="auto-style1" />
                Messages :&nbsp;&nbsp; <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </p>
            <p class="auto-style1">
                Attachment:<asp:FileUpload ID="FileUpload1" runat="server" AllowMultiple="true" />
            </p>
            <p class="auto-style1">
                <br class="auto-style1" />
                <br class="auto-style1" />
                <br class="auto-style1" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="Button1" runat="server" BackColor="#0033CC" ForeColor="White" OnClick="Button1_Click" Text="Send" Width="97px" />
            </p>
        </div>
    </form>
</body>
</html>
