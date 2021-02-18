<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblProductId" runat="server" Text="Product Number" width="89px"></asp:Label>
        <asp:TextBox ID="txtProductId" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="lblProductName" runat="server" Text="Product Name"></asp:Label>
            <asp:TextBox ID="txtProductName" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblSmartphoneBrand" runat="server" Text="Smartphone Brand" width="89px"></asp:Label>
            <asp:TextBox ID="txtSmartphoneBrand" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblSmartphoneModel" runat="server" Text="Smartphone Model" width="89px"></asp:Label>
            <asp:TextBox ID="txtSmartphoneModel" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="chkActive" runat="server" Text="Active" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
&nbsp;
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
