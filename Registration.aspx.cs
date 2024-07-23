using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Collections;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            conn.Open();
          
            string Gender = "";
            bool isChecked = maleRadioId.Checked;
            if (isChecked == true)
            {
                Gender = maleRadioId.Text;
            }
            else
                Gender= femaleRadioId.Text;
            SqlCommand cmd;
           
            


                String query = "INSERT INTO Registration_Details(User_Id,Password,First_Name,Last_Name, userName,Gender,Address,Country,State,City,Contact_No,Email_ID)VALUES('" + userId.Text + "','" + password.Text + "','" + firstName.Text + "','" + lastName.Text + "','" + userName.Text + "','" + Gender + "','" + fullAddressId.Text + "','" + countryId.Text + "','" + stateId.Text + "','" + cityId.Text + "','" + numberId.Text + "','" + emailId.Text + "')";
            cmd = new SqlCommand(query, conn);

                cmd.ExecuteNonQuery();
                Label1.ForeColor = System.Drawing.Color.Green;
                Label1.Text = "Record is Save...";

                conn.Close();
            
        }
        catch (Exception)
        {
            Label1.ForeColor = System.Drawing.Color.Red;
            Label1.Text = "Please Check The Data ...";
        }

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        //userId.Text = string.Empty;
        // firstName.Text = string.Empty;
        // lastName.Text = string.Empty;
        //  userName.Text = string.Empty;

        //  password.Text = string.Empty;
        // confirmPassword.Text = string.Empty;
        //  TextBox6.Text = string.Empty;
        // TextBox7.Text = string.Empty;
        //  TextBox8.Text = string.Empty;
        // TextBox9.Text = string.Empty;
        // TextBox10.Text = string.Empty;
        // TextBox11.Text = string.Empty;
        userId.Text = "";
        userName.Text = "";
        firstName.Text = "";
        lastName.Text = "";
        password.Text = "";
        confirmPassword.Text = "";
        emailId.Text = "";
        numberId.Text = "";
        cityId.Text = "";
        fullAddressId.Text = "";
        stateId.Text = "";
        countryId.Text = "";


    }

}