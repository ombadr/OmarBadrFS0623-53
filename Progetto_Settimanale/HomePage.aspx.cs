using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Progetto_Settimanale
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                rptArticoli.DataSource = FakeDB.GetArticoli();
                rptArticoli.DataBind();
            }
        }

        protected void btnCarrello_Click(object sender, EventArgs e)
        {
            Response.Redirect("Carrello.aspx");
        }
    }
}