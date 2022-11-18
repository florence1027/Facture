using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactureItem
{
    public class Facture
    {
        double taxe;
        double sousTotalCalcul = 0;
        public Facture() 
        {
            taxe = 0.14975;
            sousTotalCalcul = 0;
        }
        public double sousTotal(Item[] items)
        {
            double valeur = 0;

            for (int i = 0; i < items.Length; i++)
            {
                valeur += items[i].prix * items[i].quantite;
            }
            this.sousTotalCalcul = valeur;

            return valeur;
        }

        public double taxes()
        {
            double taxes = sousTotalCalcul * taxe;

            return taxes;
        }

        public double calculerTotal()
        {
            double total = this.sousTotalCalcul + taxes();

            return total;
        }

    }
}
