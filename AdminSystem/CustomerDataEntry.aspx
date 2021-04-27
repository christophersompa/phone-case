<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 239px">
    <form id="form1" runat="server">
        <div style="height: 241px">
            <asp:Label ID="lblCustomer" runat="server" style="z-index: 1; left: 10px; top: 15px; position: absolute" Text="Customer Number"></asp:Label>
            <asp:TextBox ID="txtCustomerNo" runat="server" style="z-index: 1; left: 134px; top: 13px; position: absolute" OnTextChanged="txtCustomerNo_TextChanged"></asp:TextBox>
            
            <asp:Label ID="lblAddress" runat="server" style="z-index: 1; left: 10px; top: 105px; position: absolute" Text="Address" width="113px"></asp:Label>
            <asp:TextBox ID="txtAddress" runat="server" style="z-index: 1; left: 134px; top: 105px; position: absolute"></asp:TextBox>
            
            <asp:Label ID="lblDateAdded" runat="server" style="z-index: 1; left: 10px; top: 140px; position: absolute" Text="Date Added" width="113px"></asp:Label>
        
            <asp:Label ID="lblFirstName" runat="server" style="z-index: 1; left: 10px; top: 40px; position: absolute; bottom: 512px" Text="First Name" width="113px"></asp:Label>
            <asp:TextBox ID="txtFirstName" runat="server" style="z-index: 1; left: 134px; top: 40px; position: absolute"></asp:TextBox>
            
            <asp:Label ID="lblSurname" runat="server" style="z-index: 1; left: 10px; top: 75px; position: absolute" Text="Surname" width="113px"></asp:Label>
            <asp:TextBox ID="txtSurname" runat="server" style="z-index: 1; left: 134px; top: 70px; position: absolute; height: 21px"></asp:TextBox>

            <asp:CheckBox ID="chkOver18" runat="server" style="z-index: 1; left: 10px; top: 170px; position: absolute" Text="Over 18?" />

            <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 134px; top: 140px; position: absolute" OnTextChanged="txtDateAdded_TextChanged"></asp:TextBox>

            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 10px; top: 200px; position: absolute" Text="[lblError]"></asp:Label>

            <asp:Button ID="btnOK" runat="server" style="z-index: 1; left: 10px; top: 225px; position: absolute" Text="OK" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 60px; top: 225px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />

            <asp:Button ID="btnFind" runat="server" style="z-index: 1; left: 400px; top: 15px; position: absolute" Text="Find" OnClick="btnFind_Click" />

        </div>
    </form>
</body>
</html>
