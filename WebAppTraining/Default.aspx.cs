using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebAppTraining
{
    public partial class Default : System.Web.UI.Page
    {
        static string themeValue;

        public Default()
        {
            this.PreInit += Default_PreInit;   
        }

        private void Default_PreInit(object sender, EventArgs e)
        {
            Page.Theme = themeValue;
        }

        //protected void Page_PreInit(object sender,EventArgs e)
        //{
        //    // dynamic css changes (themes)
        //    Page.Theme = themeValue;
        //}

        protected void Page_InitComplete(object sender,EventArgs e)
        {

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Hi");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var textValue = txtContent.Text;
            Response.Write("<script>alert('"+ textValue+ "')</script>");
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            themeValue = ListBox1.SelectedItem.Value;
            Response.Redirect(Request.Url.ToString());
        }
    }
}