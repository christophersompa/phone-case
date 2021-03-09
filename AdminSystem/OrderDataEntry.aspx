<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    This is the order entry page
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblOrderNo" runat="server" Text="Order Number" width="138px"></asp:Label>
        &nbsp;<asp:TextBox ID="txtOrderNo" runat="server"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
            <br />
            <asp:Label ID="lblCustomerName" runat="server" Text="Customer Name" width="138px"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblCustomerEmail" runat="server" Text="Customer Email" width="138px"></asp:Label>
&nbsp;<asp:TextBox ID="txtCustomerEmail" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblProductCode" runat="server" Text="Product Code" width="138px"></asp:Label>
&nbsp;<asp:TextBox ID="txtProductCode" runat="server" Width="53px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            &nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;<br />
            <asp:Label ID="lblQuantity" runat="server" Text="Quantity" width="138px"></asp:Label>
&nbsp;<asp:TextBox ID="txtQuantity" runat="server" Width="28px"></asp:TextBox>
            <br />
            <asp:Label ID="lblTotalPrice" runat="server" Text="Total Price" width="138px"></asp:Label>
&nbsp;<asp:TextBox ID="txtTotalPrice" runat="server" Width="57px"></asp:TextBox>
            <br />
            <asp:Label ID="lblOrderDate" runat="server" Text="Order Date" width="138px"></asp:Label>
&nbsp;<asp:TextBox ID="txtOrderDate" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblTrackingNo" runat="server" Text="Tracking Number"></asp:Label>
&nbsp;<asp:TextBox ID="txtTrackingNo" runat="server"></asp:TextBox>
            <br />
            <asp:CheckBox ID="chkDispatched" runat="server" Text="Dispatched" />
            <br />
&nbsp;<br />
        </div>
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" style="height: 29px" />
&nbsp;<asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
    </form>
</body>
</html>
