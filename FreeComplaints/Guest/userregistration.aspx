<%@ Page Title="" Language="C#" MasterPageFile="~/Guest/Guestmaster.Master" AutoEventWireup="true" CodeBehind="userregistration.aspx.cs" Inherits="FreeComplaints.Guest.userregistration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
   
        <div class="container">
      
        <!--First name-->
    		<div class="box">
          <label for="firstName" class="fl fontLabel">  Name </label>
    			<div class="new iconBox">
            <i class="fa fa-user" aria-hidden="true"></i>
          </div>
    			<div class="fr">
                    <asp:TextBox ID="USERNAME" runat="server"></asp:TextBox>
    			</div>
    			<div class="clr"></div>
    		</div>
    	
    		<div class="box">
          <label for="secondName" class="fl fontLabel"> User Address </label>
    			<div class="fl iconBox"><i class="fa fa-user" aria-hidden="true"></i></div>
    			<div class="fr">
                    <asp:TextBox ID="USERADDRESS" runat="server"></asp:TextBox>
    			</div>
    			<div class="clr"></div>
    		</div>
    		<!--Second name-->


    		<!---Phone No.------>
    		<div class="box">
          <label for="phone" class="fl fontLabel"> Phone No.: </label>
    			<div class="fl iconBox"><i class="fa fa-phone-square" aria-hidden="true"></i></div>
    			<div class="fr">
                    <asp:TextBox ID="USERPHONE" runat="server"></asp:TextBox>
    			</div>
    			<div class="clr"></div>
    		</div>
    		<!---Phone No.---->


    		<!---Email ID---->
    		<div class="box">
          <label for="email" class="fl fontLabel"> Email ID: </label>
    			<div class="fl iconBox"><i class="fa fa-envelope" aria-hidden="true"></i></div>
    			<div class="fr">
                    <asp:TextBox ID="USEREMAIL" runat="server"></asp:TextBox>	
    			</div>
    			<div class="clr"></div>
    		</div>
    		
    		<div class="box">
          <label for="Username" class="fl fontLabel"> Usename </label>
    			<div class="fl iconBox"><i class="fa fa-envelope" aria-hidden="true"></i></div>
    			<div class="fr">
                    <asp:TextBox ID="User1" runat="server"></asp:TextBox>	
    			</div>
    			<div class="clr"></div>
    		</div>
    			<div class="box">
          <label for="Password" class="fl fontLabel"> Password </label>
    			<div class="fl iconBox"><i class="fa fa-envelope" aria-hidden="true"></i></div>
    			<div class="fr">
                    <asp:TextBox ID="passoword1" runat="server"></asp:TextBox>	
    			</div>
    			<div class="clr"></div>
    		</div>
    		
    		<div class="box terms">
    				<input type="checkbox" name="Terms" required> &nbsp; I accept the terms and conditions
    		</div>
    		<!--Terms and Conditions------>



    		<!---Submit Button------>
    		<div class="box" style="background: #2d3e3f">
                <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click"  />
    		</div>
    		<!---Submit Button----->
      
  </div>
   
         
</asp:Content>
