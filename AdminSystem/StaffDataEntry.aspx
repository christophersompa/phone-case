<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblStaffId" runat="server" style="z-index: 1; left: 150px; top: 73px; position: absolute" Text="Staff Id" width="93px"></asp:Label>
        <asp:TextBox ID="txtStaffId" runat="server" style="z-index: 1; left: 150px; top: 105px; position: absolute; width: 150px;"></asp:TextBox>
        <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 150px; top: 144px; position: absolute" Text="Name" width="93px"></asp:Label>
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 150px; top: 177px; position: absolute; width: 150px;"></asp:TextBox>
        <asp:Label runat="server" style="z-index: 1; left: 150px; top: 217px; position: absolute; right: 1400px;" Text="Address" ID="lblAddress"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 150px; top: 251px; position: absolute; width:150px;"></asp:TextBox>
        <asp:Label ID="lblPostCode" runat="server" style="z-index: 1; left: 150px; top: 290px; position: absolute" Text="Post Code" width="93px"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 150px; top: 325px; position: absolute; width: 150px;"></asp:TextBox>
        <asp:Label ID="lblDoB" runat="server" style="z-index: 1; left: 150px; top: 365px; position: absolute" Text="Date of Birth" width="93px"></asp:Label>
        <asp:TextBox ID="txtDoB" runat="server" style="z-index: 1; left: 150px; top: 398px; position: absolute; width: 150px;"></asp:TextBox>
        <asp:CheckBox ID="chkAvailable" runat="server" style="z-index: 1; left: 150px; top: 438px; position: absolute; right: 1359px;" Text=" Available" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 150px; top: 474px; position: absolute"></asp:Label>
        <asp:Button ID="btnOk" runat="server" style="z-index: 1; left: 370px; top: 100px; position: absolute; width: 100px;" Text="Ok" OnClick="btnOk_Click" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 370px; top: 175px; position: absolute; width: 100px;" Text="Cancel" />
    </form>
</body>
</html>
