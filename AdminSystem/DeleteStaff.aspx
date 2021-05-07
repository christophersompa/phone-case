<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteStaff.aspx.cs" Inherits="DeleteStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 327px">
            <asp:Label ID="lblConfirmDelete" runat="server" style="z-index: 1; left: 20px; top: 24px; position: absolute; height: 23px; width: 268px" Text="Are you sure you want to delete this record?"></asp:Label>
            <asp:Button ID="btnYesDelete" runat="server" OnClick="btnYesDelete_Click" style="z-index: 1; left: 50px; top: 57px; position: absolute; right: 749px; width: 80px" Text="Yes" />
            <asp:Button ID="btnNoDelete" runat="server" style="z-index: 1; left: 163px; top: 57px; position: absolute; width: 80px" Text="No" />
        </div>
    </form>
</body>
</html>
