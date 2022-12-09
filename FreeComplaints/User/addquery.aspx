<%@ Page Title="" Language="C#" MasterPageFile="~/User/usermaster.Master" AutoEventWireup="true" CodeBehind="addquery.aspx.cs" Inherits="FreeComplaints.User.addquery" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <style type="text/css">
        body
        {
            font-family: Arial;
            font-size: 10pt;
        }
        table
        {
            border: brown;
            border-collapse: collapse;
        }
        table th
        {
            background-color: #F7F7F7;
            color: #333;
            font-weight: bold;
        }
        table th, table td
        {
            padding: 5px;
            border: 0px solid #fff;
        }
        table input[type=text]
        {
           width:300px;
        }
    </style>


    <table border="0">
       <tr>
                    <td>
                        <asp:Label ID="product" runat="server" Text="Product_id" ></asp:Label>
                    </td>
                    <td>
                        <asp:DropDownList ID="ddlproduct" runat="server" Style="margin-left: 8px" Width="148px" Height="59px">
                        </asp:DropDownList></td>
                </tr><br /><br /> 
        
        
        
        <tr>
            <td valign="top">enter your query here:</td>
            <td><asp:TextBox ID="txtBody" runat="server" TextMode="MultiLine" Height="121px" /></td>
            
        </tr>
        <tr>
                    <td>
                <asp:Label ID="Label5" runat="server" Text="Date :"></asp:Label></td>
                 <td><asp:Label ID="Label6" runat="server" Text=""></asp:Label></td>
               </tr><br /><br />
        <tr>
            
            <td><asp:Button ID="btnSend" runat="server" Text="Send" Width="138px" OnClick="btnSend_Click"/></td>
            
        </tr>
        
    </table>
    
    
  
</asp:Content>
