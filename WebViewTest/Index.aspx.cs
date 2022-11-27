using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebViewTest
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            string CategoryName = TextBoxCategoryName.Text;
            string UnitPrice = TextBoxUnitPrice.Text;
            string ProductName = TextBoxProductName.Text;
            if(CategoryName == "" && UnitPrice == "" && ProductName == "")
            {
                GridView1.DataSource = CandPDAL.GetInfo();
                GridView1.DataBind();
                Label1.Text = "";
                return;
            }

            DataView dataView = CandPDAL.GetInfo(CategoryName, UnitPrice, ProductName);
            if (dataView == null)
            {
                Label1.Text = "No results found!";
                GridView1.DataSource = null;
                GridView1.DataBind();
                return;
            }
            GridView1.DataSource = dataView;
            GridView1.DataBind();
        }
    }
}