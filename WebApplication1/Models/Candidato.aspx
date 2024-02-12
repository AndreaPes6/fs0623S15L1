<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Candidato.aspx.cs" Inherits="NomeApplicazione.Candidato" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Visualizza Candidato</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnVisualizza" runat="server" Text="Visualizza Candidato" OnClick="btnVisualizza_Click" Height="55px" Width="195px" />
            <br />
            <asp:Label ID="lblCandidato" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
