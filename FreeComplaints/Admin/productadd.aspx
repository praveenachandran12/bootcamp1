<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true" CodeBehind="productadd.aspx.cs" Inherits="FreeComplaints.Admin.productadd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <center>
    <h6> ADD PRODUCT</h6>
    <div>  
        
        <asp:Label ID="Label1" runat="server" Text="product name"></asp:Label>&nbsp&nbsp
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /><br />
        <asp:Label ID="Label2" runat="server" Text="product description"></asp:Label>&nbsp&nbsp
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </div> <br /><br /> 
        <p>  
        <asp:Button ID="Button1" runat="server" Text="ADD" OnClick="Button1_Click" />
        </p>
    &nbsp;&nbsp;&nbsp;
   
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Product_id" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" CellPadding="4" ForeColor="#333333" GridLines="None" Height="227px" Width="447px">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="Product_id" HeaderText="productid" />
            <asp:BoundField DataField="Product_name" HeaderText="product name" />
            <asp:BoundField DataField="Product_description" HeaderText="description" />
            <asp:CommandField HeaderText="Edit" ShowEditButton="True" />
            <asp:CommandField HeaderText="delete" ShowDeleteButton="True" />
        </Columns>
        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        <SortedAscendingCellStyle BackColor="#FDF5AC" />
        <SortedAscendingHeaderStyle BackColor="#4D0000" />
        <SortedDescendingCellStyle BackColor="#FCF6C0" />
        <SortedDescendingHeaderStyle BackColor="#820000" />
    </asp:GridView>
        <br />
       <br />
       <br />
       <br />
        </center>
</asp:Content>
