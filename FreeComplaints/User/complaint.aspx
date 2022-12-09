<%@ Page Title="" Language="C#" MasterPageFile="~/User/usermaster.Master" AutoEventWireup="true" CodeBehind="complaint.aspx.cs" Inherits="FreeComplaints.User.complaint" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    

    <body>
        <h1 align="center">Complaint Registration</h1>
        <br />
        <br />
        <center>
            <table border="4" color="pink">
                <tr>
                    <td>
                        <asp:Label ID="product" runat="server" Text="Product_id" ></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlproduct" runat="server" Style="margin-left: 8px" Width="148px" Height="59px">
                        </asp:DropDownList></td>
                </tr><br /><br />
                
               
                <tr>
                    <td>
                        <asp:Label ID="msg" runat="server" Text="Complaint " ></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="complaint1" runat="server" TextMode="MultiLine" Height="46px" Width="189px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                <asp:Label ID="Label5" runat="server" Text="Date :"></asp:Label></td>
                 <td><asp:Label ID="Label6" runat="server" Text=""></asp:Label></td>
               </tr>
                
                </table>
        </body>
    
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click1" Height="42px" style="margin-top: 45px" Width="175px"/><br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br /><br />
    </center>
            
</asp:Content>
