<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="humanResource.APPCODE.UI.ADMIN.admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Login</title>
      
        <link href="//netdna.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrapcss" />
        <script src="//netdna.bootstrapcdn.com/bootstrap/3.2.0/js/bootstrap.min.js"></script>
        <script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
        <link href="style.css" rel="stylesheet" />

    </head>
<body>
    <form id="form1" runat="server">
        
            <div class="page-container">
                <div style="padding-top:10px;">
                    <h1>Admin</h1>
                    <hr/>
                </div>
                <div>
                   
                        <h3><span style="color:black;font-weight:bold;">namaste !</span></h3>
                        <asp:TextBox ID="TextBox1" type="text" runat="server" name="name" class="Name" placeholder="USERNAME"></asp:TextBox>
                        <asp:TextBox ID="TextBox2" type="text" runat="server" name="fname" class="Tele" placeholder="F NAME"></asp:TextBox>
                        <asp:TextBox ID="TextBox3" type="text" runat="server" name="lname" class="Email" placeholder="L NAME"></asp:TextBox>
                        <asp:TextBox ID="TextBox4" runat="server" type="password" name="password" class="Address" placeholder="PASSWORD"></asp:TextBox>
                        <asp:TextBox ID="TextBox5" type="text" runat="server" name="admin_key" class="Email" placeholder="ADMIN KEY"></asp:TextBox>
                        <div class="form-group">
                            <asp:Button ID="Button1" runat="server" type="submit" class="btn btn-lg btn-primary btn-block grad" Text="L A N D F A L L" OnClick="Button1_Click" />
                        </div>
                </div>
            </div>
    </form>
</body>
</html>

