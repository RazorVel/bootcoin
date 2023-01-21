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
    public partial class WebForm3 : System.Web.UI.Page
    {
        string strcon = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
       
        protected void Page_Load(object sender, EventArgs e)
        {
            emailTxt.Attributes.Add("onkeyup", "ValidateEmail();");
            confirm.Attributes.Add("onkeyup", "ValidateConfirmation();");
            password.Attributes.Add("onkeyup", "ValidateConfirmation();");
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM [user] WHERE email='" + emailTxt.Text.Trim()+ "'", con);
                SqlDataReader dr = cmd.ExecuteReader();
               

                if (dr.HasRows)
                {
                    dr.Close();
                    Response.Write("<script>alert('Email already registered!');</script>");

                }
                else
                {
                    dr.Close();
                    SqlCommand insertcmd = new SqlCommand("INSERT INTO [user](email,password) values(@email,@password)", con);
                    insertcmd.Parameters.AddWithValue("@email", emailTxt.Text.Trim());
                    insertcmd.Parameters.AddWithValue("@password", password.Text.Trim());

                    insertcmd.ExecuteNonQuery();
                    con.Close();
                    Response.Write("<script>alert('Sign up successful. Go to User Login to login');</script>");
                    
                }
                emailTxt.Text = string.Empty;
                password.Text = string.Empty;
                confirm.Text = string.Empty;

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");

            }


        }

        protected void loginlink_Click(object sender, EventArgs e)
        {
            Response.Redirect("sign-in.aspx");
        }
        

    }
}