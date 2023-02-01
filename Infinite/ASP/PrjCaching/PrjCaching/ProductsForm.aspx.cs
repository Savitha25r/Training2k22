using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace PrjCaching
{
    public partial class ProductsForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //SqlConnection con = new SqlConnection("Data Source=LAPTOP-TJJ7D977;" +
                //    "Initial Catalog=InfiniteDB; Integrated Security=true");
                //SqlDataAdapter da = new SqlDataAdapter("spGetProducts", con);
                //da.SelectCommand.CommandType = CommandType.StoredProcedure;
                //DataSet ds = new DataSet();
                //da.Fill(ds);
                //GridView1.DataSource = ds;
                //GridView1.DataBind();
                GetProductByName("All");
            }
            //else
            //{
            //    GetProductByName("Laptops");
            //}
            lbltime.Text = "This Page is Cached " + DateTime.Now.ToString();
        }

        protected void Dpdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetProductByName(Dpdown1.SelectedValue);
        }

        private void GetProductByName(string Productname)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-TJJ7D977;" +
                "Initial Catalog=InfiniteDB; Integrated Security=true");
            SqlDataAdapter da = new SqlDataAdapter("spGetProductsByName", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter sqlparam = new SqlParameter();
            sqlparam.ParameterName = "@prodname";
            sqlparam.Value = Productname;
            da.SelectCommand.Parameters.Add(sqlparam);

            DataSet ds = new DataSet();
            da.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }


    }
        
}