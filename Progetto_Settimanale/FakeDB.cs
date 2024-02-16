using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Progetto_Settimanale
{
    public static class FakeDB
    {
        private static List<Articolo> articoli = new List<Articolo>()
        {
             new Articolo { Id= 1, Nome = "Articolo 1", Descrizione = "Descrizione articolo 1", Prezzo = 10.99m, ImmagineUrl = "https://m.media-amazon.com/images/I/71NxKpg1NIL.__AC_SX300_SY300_QL70_ML2_.jpg"},
             new Articolo { Id= 2, Nome = "Articolo 2", Descrizione = "Descrizione articolo 1", Prezzo = 43.59m, ImmagineUrl = "https://m.media-amazon.com/images/I/71ne54oFjfL.__AC_SY300_SX300_QL70_ML2_.jpg"},
             new Articolo { Id= 3, Nome = "Articolo 3", Descrizione = "Descrizione articolo 1", Prezzo = 100.99m, ImmagineUrl = "https://m.media-amazon.com/images/I/61bAnOXDl7L.__AC_SX300_SY300_QL70_ML2_.jpg"},
             new Articolo { Id= 4, Nome = "Articolo 4", Descrizione = "Descrizione articolo 1", Prezzo = 54.99m, ImmagineUrl = "https://m.media-amazon.com/images/I/51Vn-oK+AkL._AC_SX300_SY300_.jpg"},
             new Articolo { Id= 5, Nome = "Articolo 5", Descrizione = "Descrizione articolo 1", Prezzo = 78.59m, ImmagineUrl = "https://m.media-amazon.com/images/I/61JrQ8KuM6L.__AC_SX300_SY300_QL70_ML2_.jpg"},
             new Articolo { Id= 6, Nome = "Articolo 6", Descrizione = "Descrizione articolo 1", Prezzo = 72.79m, ImmagineUrl = "https://m.media-amazon.com/images/I/61OggsZLBQL.__AC_SX300_SY300_QL70_ML2_.jpg"},
             new Articolo { Id= 7, Nome = "Articolo 7", Descrizione = "Descrizione articolo 1", Prezzo = 150.99m, ImmagineUrl = "https://m.media-amazon.com/images/I/51B1KX8a--L.__AC_SX300_SY300_QL70_ML2_.jpg"},
             new Articolo { Id= 8, Nome = "Articolo 8", Descrizione = "Descrizione articolo 1", Prezzo = 90.92m, ImmagineUrl = "https://m.media-amazon.com/images/I/61UsTJLR4HL.__AC_SX300_SY300_QL70_ML2_.jpg"},
             new Articolo { Id= 9, Nome = "Articolo 9", Descrizione = "Descrizione articolo 1", Prezzo = 3.99m, ImmagineUrl = "https://m.media-amazon.com/images/I/71d1I4p9e6L.__AC_SX300_SY300_QL70_ML2_.jpg"},
             new Articolo { Id= 10, Nome = "Articolo 10", Descrizione = "Descrizione articolo 1", Prezzo = 67.99m, ImmagineUrl = "https://m.media-amazon.com/images/I/41G1PeGX4iL._SY445_SX342_QL70_ML2_.jpg"}


        };

        private static List<Articolo> carrello = new List<Articolo>();

        public static IEnumerable<Articolo> GetArticoli() { return  articoli; }

        public static Articolo GetArticoloById(int id)
        {
            return articoli.Find(a => a.Id == id);
        }

        public static void AggiungiAlCarrello(Articolo articolo)
        {
            carrello.Add(articolo);
        }

        public static void RimuoviDalCarrello(int id)
        {
            var articolo = carrello.Find(a => a.Id == id);
            if(articolo != null)
            {
                carrello.Remove(articolo);
            }
        }

        public static void SvuotaCarrello()
        {
            carrello.Clear();
        }

        public static IEnumerable<Articolo> GetCarrello()
        {
            return carrello;
        }
    }
}