using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using WebApplication4.Models;
using System.Data.Sql;
using System.Data.SqlClient;


namespace WebApplication4.Account
{
    public partial class Register : Page
    {
        ShopingEntities db = new ShopingEntities();
        protected void CreateUser_Click(object sender, EventArgs e)
        {
            db.Register_sp(username.Text, Email.Text, Password.Text, address.Text, Convert.ToDateTime(dob.Text), Convert.ToInt32(contact.Text));
            Response.Redirect("~/Default.aspx");
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}