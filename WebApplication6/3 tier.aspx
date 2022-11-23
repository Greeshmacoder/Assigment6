<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="3 tier.aspx.cs" Inherits="WebApplication6._2_tier" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
         <center><h1> WELCOME</h1></center>
        <br />
        <div>
            <center><asp:Label ID="Label1" runat="server" Text="Designation Name"></asp:Label>

            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></center>
            <center>
                <br />
            <asp:Label runat="server" Text="Department name"></asp:Label>
            <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="178px"></asp:DropDownList></center>
            <br />
          <center> <asp:Button ID="Button1" runat="server" Text="Submitt" OnClick="Button1_Click" /></center>
            <br />
            <br />
            <br />
            <center>
            <asp:GridView ID="GridView1" runat="server" DataKeyNames="Desid" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowDeleting="GridView1_RowDeleting" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" >
                <Columns>
                    <asp:BoundField DataField="Designationname" HeaderText="Designation Name" />
                    
                    <asp:BoundField DataField="Depid" HeaderText="Department Id" />
                    
                    <asp:CommandField HeaderText="edit" ShowEditButton="True" CancelText="" />
                    <asp:CommandField HeaderText="delete" ShowDeleteButton="True" />
                    
                </Columns>
            </asp:GridView>
                </center>
        </div>
    </form>
</body>
</html>
