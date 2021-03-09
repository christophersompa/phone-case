<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 495px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblStaffId" runat="server" style="z-index: 1; left: 150px; top: 75px; position: absolute" Text="Staff Id" width="93px"></asp:Label>
        <asp:TextBox ID="txtStaffId" runat="server" style="z-index: 1; left: 150px; top: 100px; position: absolute; width: 150px;"></asp:TextBox>
        <asp:Label ID="lblName" runat="server" style="z-index: 1; left: 150px; top: 150px; position: absolute" Text="Name" width="93px"></asp:Label>
        <asp:TextBox ID="txtName" runat="server" style="z-index: 1; left: 150px; top: 175px; position: absolute; width: 150px;"></asp:TextBox>
        <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 150px; top: 225px; position: absolute; right: 573px;" Text="Address"></asp:Label>
        <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 150px; top: 250px; position: absolute; width:150px;"></asp:TextBox>
        <asp:Label ID="lblPostCode" runat="server" style="z-index: 1; left: 150px; top: 300px; position: absolute" Text="Post Code" width="93px"></asp:Label>
        <asp:TextBox ID="txtPostCode" runat="server" style="z-index: 1; left: 150px; top: 325px; position: absolute; width: 150px;"></asp:TextBox>
        <asp:Label ID="lblDoB" runat="server" style="z-index: 1; left: 150px; top: 375px; position: absolute" Text="Date of Birth" width="93px"></asp:Label>
        <asp:TextBox ID="txtDoB" runat="server" style="z-index: 1; left: 150px; top: 400px; position: absolute; width: 150px;"></asp:TextBox>
        <asp:CheckBox ID="chkAvailable" runat="server" style="z-index: 1; left: 150px; top: 440px; position: absolute; right: 575px;" Text=" Available" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 150px; top: 474px; position: absolute"></asp:Label>
        <asp:Button ID="btnOk" runat="server" style="z-index: 1; left: 370px; top: 100px; position: absolute; width: 100px;" Text="Ok" OnClick="btnOk_Click" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 370px; top: 175px; position: absolute; width: 100px;" Text="Cancel" />
        <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 370px; top: 250px; position: absolute; width: 100px;" Text="Find" OnClick="btnFind_Click" />
    </form>
</body>
</html>
