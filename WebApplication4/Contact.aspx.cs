using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;

namespace WebApplication4
{
    public partial class Contact : Page
    {
        ShopingEntities db = new ShopingEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
           // db.insert_contact(txtName.Text, txtemail.Text,Convert.ToInt32(phn.Text), txtsubject.Text, txtmsg.Text);

        }
    }
}