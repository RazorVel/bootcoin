using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bootcoin
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            emailTxt.Attributes.Add("onkeyup", "ValidateEmail();");
            password.Attributes.Add("onkeyup", "ValidateConfirmation();");
        }

        protected void registerlink_Click(object sender, EventArgs e)
        {
            Response.Redirect("sign-up.aspx");
        }

        protected void signin_button_Click(object sender, EventArgs e)
        {
            
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                //check database connection
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * FROM user WHERE email='"+ emailTxt.Text.Trim() + "' AND password='"+ password.Text.Trim() + "'", con);
                




                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Response.Write("<script>alert('Sign up successful. Go to User Login to login');</script>");
                    }
                }
                else
                {
                    Response.Write("<script>alert('Your Password and Email is either not registered or incorrect');</script>");
                }

                //cmd.ExecuteNonQuery();
                //con.Close();
                Response.Write("<script>alert('Sign up successful. Go to User Login to login');</script>");
                emailTxt.Text = string.Empty;
                password.Text = string.Empty;
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");

            }
        }
    }
}