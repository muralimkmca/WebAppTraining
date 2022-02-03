using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppTraining
{
    public partial class ASPNETTags : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = Calendar1.SelectedDate.ToShortDateString() +" "+ 
                Calendar1.SelectedDate.ToLongTimeString();
        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(CheckBoxList1.SelectedItem.ToString() =="Item1")
            {
                Response.Write("Item 1 selected");
            }
            else if (CheckBoxList1.SelectedItem.ToString() == "Item2")
            {
                Response.Write("Item 2 selected");
            }
            else
            {
                Response.Write("Item 3 selected");
            }
        }
    }
}
