using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using humanResource.LOGIN.SLAYER;
using humanResource.LOGIN.SLAYER.SESSION;

namespace humanResource.LOGIN.UI
{
    public partial class SignIn : System.Web.UI.Page
    {
        AESThenHMAC obj = new AESThenHMAC();
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect(@"\APPCODE\UI\ADMIN\admin.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(TextBox1.Text)&&String.IsNullOrEmpty(TextBox2.Text))
           {
               TextBox1.Focus();
           }
            else
            {
                Register key = new Register();
                Securehash sbuffer = new Securehash();
                string usrname = sbuffer.Guid(TextBox1.Text);
                    if (key.KeyFsequenceAll(TextBox1.Text).Tables[0].Rows[0][1].ToString().Equals(TextBox1.Text, StringComparison.Ordinal))//compare->guid(username{textbox})|username from dataset
                    {
                       //enters us username exists
                       
                       if (AESThenHMAC.SimpleDecryptWithPassword(key.KeyFsequence(TextBox1.Text).ToString(),sbuffer.Guid(TextBox2.Text)).Equals(TextBox2.Text,StringComparison.Ordinal))
                       {
                           TextBox1.Text = "success";
                       }
                       else
                       {
                           TextBox1.Text = "failed";
                       }
                    }
                    else
                    {
                        TextBox1.Text =key.KeyFsequenceAll(TextBox1.Text).Tables[0].Rows[0][1].ToString();
                    }
            }
        }
    }
}