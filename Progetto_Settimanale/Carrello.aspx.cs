using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Progetto_Settimanale
{
    public partial class Carrello : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                MostraCarrello();
                TotaleCarrello();
            }
        }

        private void MostraCarrello()
        {
            rptCarrello.DataSource = FakeDB.GetCarrello();
            rptCarrello.DataBind();
        }

        protected void btnSvuotaCarrello_Click(object sender, EventArgs e)
        {
            FakeDB.SvuotaCarrello();
            Response.Redirect("Carrello.aspx");
        }

        protected void btnRimuovi_Command(object sender, CommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            FakeDB.RimuoviDalCarrello(id);
            Response.Redirect("Carrello.aspx");
        }

        private void TotaleCarrello()
        {
            decimal totale = FakeDB.GetCarrello().Sum(articolo => articolo.Prezzo);
            lblTotale.Text = $"Totale: {totale} EUR";
        }

        protected void btnTornaHomePage_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}