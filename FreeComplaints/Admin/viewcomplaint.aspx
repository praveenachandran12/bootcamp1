<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true" CodeBehind="viewcomplaint.aspx.cs" Inherits="FreeComplaints.Admin.viewcomplaint" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <center>
        <br /><br /><br /><br />
    <asp:GridView ID="GridView1" runat="server"  AutoGenerateColumns="False" DataKeyNames="Complaint_id" Height="141px" Width="747px" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDeleting="GridView1_RowDeleting">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="Complaint_id" HeaderText="id" />
            <asp:BoundField DataField="User_name" HeaderText="username" />
            <asp:BoundField DataField="Product_name" HeaderText="product name" />
            <asp:BoundField DataField="Date" HeaderText="Date" />
            <asp:BoundField DataField="Complaint" HeaderText="Complaint" />
            <asp:BoundField DataField="C_status" HeaderText="Complaint status" />

            <asp:CommandField DeleteText="Confirm" HeaderText="Confirmation" ShowDeleteButton="True" />

            
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
        </center>
</asp:Content>
