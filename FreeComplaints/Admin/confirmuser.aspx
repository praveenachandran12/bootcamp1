<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/admin.Master" AutoEventWireup="true" CodeBehind="confirmuser.aspx.cs" Inherits="FreeComplaints.Admin.confirmuser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>User Details</h2>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="User_id" OnRowDeleting="GridView1_RowDeleting" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
            <Columns>
                <asp:BoundField DataField="User_id" HeaderText="ID" />
                <asp:BoundField DataField="User_name" HeaderText="Name" />
                <asp:BoundField DataField="User_address" HeaderText="Address" />
                <asp:BoundField DataField="User_email" HeaderText="email" />
                <asp:BoundField />
                <asp:BoundField DataField="User_phone" HeaderText="phone" />
                <asp:BoundField DataField="Username" HeaderText="username" />
                <asp:CommandField DeleteText="Confirm" HeaderText="STATUS" ShowDeleteButton="True" />
            </Columns>

            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FFF1D4" />
            <SortedAscendingHeaderStyle BackColor="#B95C30" />
            <SortedDescendingCellStyle BackColor="#F1E5CE" />
            <SortedDescendingHeaderStyle BackColor="#93451F" />

        </asp:GridView>
</asp:Content>
