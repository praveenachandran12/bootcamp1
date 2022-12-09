<%@ Page Title="" Language="C#" MasterPageFile="~/User/usermaster.Master" AutoEventWireup="true" CodeBehind="viewproduct.aspx.cs" Inherits="FreeComplaints.User.complaintadd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center style="margin-top: 81px; margin-bottom: 51px">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Product_id" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" Width="801px" >
        <Columns>
            <asp:BoundField DataField="Product_id" HeaderText="productid" />
            <asp:BoundField DataField="Product_name" HeaderText="product name" />
            <asp:BoundField DataField="Product_description" HeaderText="description" />
            
        </Columns>
        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" Font-Bold="True" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFFBD6" ForeColor="#330099" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
        <SortedAscendingCellStyle BackColor="#FEFCEB" />
        <SortedAscendingHeaderStyle BackColor="#AF0101" />
        <SortedDescendingCellStyle BackColor="#F6F0C0" />
        <SortedDescendingHeaderStyle BackColor="#7E0000" />
    </asp:GridView>
    <asp:Button runat="server" Text="Click here to add complaint" onclientclick='redirect()' OnClick="Unnamed1_Click" Height="49px" style="margin-top: 35px" />
    </center>
</asp:Content>
