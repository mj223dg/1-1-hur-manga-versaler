<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CountCapitals.Default" ViewStateMode="Disabled" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <title></title>
        <link href="StyleSheet.css" rel="stylesheet" />
    </head>
    <body>
        <form id="form1" runat="server">
            <div>
                <h1>Hur många versaler?</h1>
                <asp:TextBox ID="TextBox" runat="server" TextMode="MultiLine"></asp:TextBox>
                <asp:Button ID="SendButton" runat="server" Text="Beräkna antalet versaler." OnClick="SendButton_Click" />
                <asp:Label ID="Result" runat="server"></asp:Label>

                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Fältet kan inte vara tomt." Display="Dynamic" Text="*" ControlToValidate="TextBox"></asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Test fältet skall bara innehålla text." Display="Dynamic" Text="*" ControlToValidate="TextBox" Operator="DataTypeCheck" Type="String"></asp:CompareValidator>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" DisplayMode="SingleParagraph" />
            </div>
                
                
        </form>
</body>
</html>
