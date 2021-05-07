<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplyList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstSupplierList" runat="server" Height="352px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="394px"></asp:ListBox>
        </div>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
            <asp:Button ID="btnEdit" runat="server" Text="Edit" />
        </p>
        <p>
            Enter a Supplier Name
            <asp:TextBox ID="txtbox_eSupplierName" runat="server" OnTextChanged="TextBox_TextChanged"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnApply" runat="server" Text="Apply" />
            <asp:Button ID="btnClear" runat="server" Text="Clear" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
