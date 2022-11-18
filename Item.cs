using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactureItem
{
    public class Item
    {
        public string nom;
        public string code;
        public double prix;
        public int quantite;

        public Item(string nom, string code, double prix, int quantite)
        {
            this.nom = nom;
            this.code = code;
            this.prix = prix;
            this.quantite = quantite;
        }
    }
}
