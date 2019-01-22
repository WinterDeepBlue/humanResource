<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signIn.aspx.cs" Inherits="humanResource.LOGIN.UI.SignIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>host</title>
    <link href="design.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
   <div class="bgimg-1">
              <div class="cover">
            
            <header class="_header">
            	<div style="width: 80px; height: 25px;margin-top:20px;border:1px solid #333333;margin-right:40px;float:right;">
                    <div style="width: 40px; height: 25px;float:right;background-color:#333333">
                        <asp:Button ID="Button2" style="opacity:0.3;background-color:black;width:100%;height:98%;border:1px solid black;color:white;" runat="server" Text="A" OnClick="Button2_Click" />
                </div>
                </div>
            </header>
        <div class="container">
        
        <div class="log">
     <div class="overload" >
   
     </div>
            <div class="wrap_user">
                <asp:TextBox ID="TextBox1" class="form-control" runat="server" placeholder="u s e r n a m e" ></asp:TextBox>
             <asp:TextBox ID="TextBox2" type="password" class="form-control" style="margin-top: 10px;" runat="server" placeholder="p a s s w o r d"></asp:TextBox>
                <div style="float:left; width: 399px; height: 26px; margin-top:5px;">
                    <p style="font-size:12px;color:white;text-align:center;opacity:0.8;">forgot your password?</p>
                </div>
           
            </div>
            
            
            
            </div> 
              <asp:Button class="btn btn-default" ID="Button3" runat="server" Text="sign_in" Visible="true" OnClick="Button3_Click" />                
                 <asp:Button class="btn btn-default" ID="Button1" runat="server" Text="forgot" Visible="false"/>
           
        </div>
    
        </div>
        
    </div>
    </form>
</body>
</html>
