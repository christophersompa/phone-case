<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 450px">
    <form id="form1" runat="server">
        <div style="height: 450px">
            <asp:Button ID="btnEdit" runat="server" style="z-index: 1; left: 65px; top: 340px; position: absolute" Text="Edit" OnClick="btnEdit_Click" />
            <asp:Button ID="btnApply" runat="server" style="z-index: 1; left: 10px; top: 420px; position: absolute" Text="Apply" OnClick="btnApply_Click" />
            <asp:ListBox ID="lstCustomersList" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute; height: 298px; width: 366px"></asp:ListBox>
            <asp:Button ID="btnAdd" runat="server" style="z-index: 1; left: 10px; top: 340px; position: absolute" Text="Add" OnClick="btnAdd_Click" />
            <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 120px; top: 340px; position: absolute" Text="Delete" OnClick="btnDelete_Click" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 315px; position: absolute" Text="[lblError]"></asp:Label>
            <asp:Label ID="lbl_eSurname" runat="server" style="z-index: 1; left: 10px; top: 380px; position: absolute" Text="Enter a Surname"></asp:Label>
            <asp:TextBox ID="txtbox_eSurname" runat="server" style="z-index: 1; left: 120px; top: 380px; position: absolute"></asp:TextBox>
            <asp:Button ID="btnClear" runat="server" style="z-index: 1; left: 70px; top: 420px; position: absolute" Text="Clear" OnClick="btnClear_Click" />
        </div>
    </form>
</body>
</html>
