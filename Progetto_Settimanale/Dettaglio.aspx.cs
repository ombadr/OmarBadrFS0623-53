using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Progetto_Settimanale
{
    public partial class Dettaglio : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                var articolo = FakeDB.GetArticoloById(id);
                if(articolo != null)
                {
                    lblNome.InnerText = articolo.Nome;
                    lblDescrizione.InnerText = articolo.Descrizione;
                    lblPrezzo.InnerText = $"{articolo.Prezzo}";
                    imgArticolo.Src = articolo.ImmagineUrl;
                }
            }
        }

        protected void btnAggiungiAlCarrello_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            var articolo = FakeDB.GetArticoloById(id);
            FakeDB.AggiungiAlCarrello(articolo);
            Response.Redirect("Carrello.aspx");
        }

        protected void btnTornaHomePage_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
}