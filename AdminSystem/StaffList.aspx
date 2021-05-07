<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 572px">
    <form id="form1" runat="server">
        <div style="height: 571px">
            <asp:ListBox ID="lstStaffList" runat="server" style="z-index: 1; left: 21px; top: 20px; position: absolute; height: 296px; width: 380px"></asp:ListBox>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 39px; top: 324px; position: absolute; height: 35px; width: 100px;" Text="Add" />
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 141px; top: 324px; position: absolute; height: 35px; width: 100px" Text="Delete" />
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 48px; top: 479px; position: absolute"></asp:Label>
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 243px; top: 324px; position: absolute; width: 100px; height: 35px" Text="Edit" />
            <asp:Label ID="lblDataEntry" runat="server" style="z-index: 1; left: 43px; top: 376px; position: absolute" Text="Enter a Name"></asp:Label>
            <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 145px; top: 376px; position: absolute; width: 190px"></asp:TextBox>
        </div>
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 243px; top: 417px; position: absolute; width: 100px" Text="Clear" />
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 43px; top: 417px; position: absolute; width: 100px" Text="Apply" />
    </form>
</body>
</html>
