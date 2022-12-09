<%@ Page Title="" Language="C#" MasterPageFile="~/User/usermaster.Master" AutoEventWireup="true" CodeBehind="complaintstatus.aspx.cs" Inherits="FreeComplaints.User.complaintstatus" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <center><h1>Complaint Status</h1>
    <asp:GridView runat="server"  ID="GridView1" runat="server"   DataKeyNames="Complaint_id" AutoGenerateColumns="False" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" Height="317px" style="margin-top: 64px" Width="818px">
        <Columns>
            <asp:BoundField DataField="Product_name" HeaderText="Product name" />
            <asp:BoundField DataField="Complaint" HeaderText="Your Complaint" />
            <asp:BoundField DataField="Date" HeaderText="Date" />
            <asp:BoundField DataField="C_status" HeaderText="Admin Status" />
        </Columns>
        <FooterStyle BackColor="White" ForeColor="#333333" />
        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F7F7F7" />
        <SortedAscendingHeaderStyle BackColor="#487575" />
        <SortedDescendingCellStyle BackColor="#E5E5E5" />
        <SortedDescendingHeaderStyle BackColor="#275353" />
    </asp:GridView>
        </center>
    <br />
    <br />
    <br />
    <br />
</asp:Content>
