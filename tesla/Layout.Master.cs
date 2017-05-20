using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace tesla
{
    public partial class Layout : System.Web.UI.MasterPage
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataAdapter me = new SqlDataAdapter("select * from menu", conn);
            SqlDataAdapter adr = new SqlDataAdapter("select * from adr", conn);
            DataTable nu = new DataTable();
            DataTable ad = new DataTable();
            me.Fill(nu);
            adr.Fill(ad);
            Repeater_adr.DataSource = ad;
            Repeater_adr.DataBind();
            Repeater_menu.DataSource = nu;
            Repeater_menu.DataBind();
        }

        protected void Button_sog_Click(object sender, EventArgs e)
        {
            Response.Redirect("sog.aspx?sog=" + TextBox_sog.Text);
        }
    }
}