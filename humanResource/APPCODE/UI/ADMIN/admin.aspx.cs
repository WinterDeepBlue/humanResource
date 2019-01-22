using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using humanResource.LOGIN.SLAYER;
using humanResource.LOGIN.SLAYER.SESSION;
using System.Data;
using System.Drawing;

namespace humanResource.APPCODE.UI.ADMIN
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TextBox1.Text))
            {
                Response.Redirect(@"\LOGIN\UI\signIn.aspx");
            }
               // HashBasic pBuffer = new HashBasic();
                Securehash sBuffer = new Securehash();
            //Securehash sbuf;
            //new Securehash();
               Register key = new Register();
            string keyA = key.AKeyFsequence().Tables[0].Rows[0][0].ToString();
            string keyB = sBuffer.Guid(TextBox5.Text);
            if (keyA.Equals(keyB, StringComparison.Ordinal))
                //if (key.AKeyFsequence().Tables[0].Rows[0][0].ToString().Equals(sBuffer.Guid(TextBox5.Text), StringComparison.Ordinal))//comparison {DATABSEphaseaKEY & Akey}
                {
                     if(key.KeyFsequenceAll(TextBox1.Text).Tables[0].Rows.Count != 0)                   
                     {
                         if(key.KeyFsequenceAll(TextBox1.Text).Tables[0].Rows[0][1].ToString().Equals(TextBox1.Text, StringComparison.Ordinal))
                         {
                             //returns ture when username exist.                       
                             TextBox1.ForeColor = Color.Red;
                             Button1.Text = "R E L O A D";
                         }
                     }
                    else
                    {
                        string passphase = sBuffer.Guid(TextBox4.Text);
                        string stream = AESThenHMAC.SimpleEncryptWithPassword(TextBox4.Text, passphase);

                        if((key.KeyManagerInsertQ(TextBox1.Text, TextBox2.Text, TextBox3.Text, stream)).Equals(1))
                        {
                            Response.Redirect(@"\LOGIN\UI\signIn.aspx");
                        }
                        else
                        {
                            Button1.Text = "I -E R R O R.";//@non-updation
                        }
                    }
                }
                else
                {
                    Button1.Text = "permission denied";
                }
            }
    }
}