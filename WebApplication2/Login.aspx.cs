using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblErrorMessage.Visible = false;
        }

        

        protected void Button1_Click1(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;initial Catalog=logindb;integrated Security=True;"))
            {
                sqlCon.Open();
                string query = "SELECT COUNT(1) FROM tblUser WHERE username=@username AND password=@password";

                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.Parameters.AddWithValue("@username", textUsername.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@password", textPassword.Text.Trim());
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());

                if (count == 1)
                {
                    Session["username"] = textUsername.Text.Trim();
                    Response.Redirect("Dashboard.aspx");
                }
                else
                {
                    lblErrorMessage.Visible = true;
                }
            }
        }
    }
}