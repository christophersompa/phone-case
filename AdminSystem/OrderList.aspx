﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 450px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstOrdersList" runat="server" Height="235px" Width="393px"></asp:ListBox>
        <br />
        <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
        <br />
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="margin-bottom: 14px" Text="Add" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click1" style="margin-top: 0px; margin-bottom: 13px" Text="Edit" Width="46px" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnDelete" runat="server" Height="31px" OnClick="btnDelete_Click" style="margin-top: 3px" Text="Delete" Width="60px" />
        <br />
        <br />
        Enter a Customer Name
        <asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" />
&nbsp;<asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
