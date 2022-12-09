<%@ Page Title="" Language="C#" MasterPageFile="~/User/usermaster.Master" AutoEventWireup="true" CodeBehind="viewquery.aspx.cs" Inherits="FreeComplaints.User.viewquery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <p>
        <br />
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
    <asp:GridView ID="GridView1" runat="server" DataKeyNames="Query_id" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Height="268px"  Width="621px">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="Product_name" HeaderText="product name" />
            <asp:BoundField DataField="Query" HeaderText="Query" />
            <asp:BoundField DataField="Date" HeaderText="Date" />
            <asp:BoundField DataField="Reply" HeaderText="Reply" />
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
</asp:Content>
