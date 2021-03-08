<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplyDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblPhoneCaseId" runat="server" Text="Phone Case ID     "></asp:Label>
        <asp:TextBox ID="txtPhoneCaseId" runat="server"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" Text="Find" />
        <br />
        <asp:Label ID="lblPhoneModel" runat="server" Text="Phone Model     " width="97px"></asp:Label>
        <asp:TextBox ID="txtPhoneModel" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblDateOrdered" runat="server" Text="Date Ordered     " width="97px"></asp:Label>
        <asp:TextBox ID="txtDateOrdered" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblSupplierName" runat="server" Text="Supplier Name     " width="97px"></asp:Label>
        <asp:TextBox ID="txtSupplierName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblPrice" runat="server" Text="Price     " width="97px"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        <br />
        <asp:CheckBox ID="chkAvaliableStock" runat="server" Text="Avaliable Stock" />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        <br />
    </form>
</body>
</html>
