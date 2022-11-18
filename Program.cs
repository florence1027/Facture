using System.Security.Cryptography;

namespace FactureItem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool actif = true;
            int choix = 0;
            string nomItem = "";
            string codeItem = "";
            double prixItem = 0;
            int quantiteItem = 0;
            Facture facture = new Facture();
            Item[] listeItems = new Item[1];
            int nbItems = 0;


            while (actif)
            {
                affichage();
                int.TryParse(Console.ReadLine(), out choix);
                switch (choix)
                {
                    case 1:
                        Console.WriteLine("Entrez le nom de l'item, son code, son prix et sa quantité dans une ligne chaque");
                        nomItem = Console.ReadLine();
                        codeItem = Console.ReadLine();
                        double.TryParse(Console.ReadLine(), out prixItem);
                        int.TryParse(Console.ReadLine(), out quantiteItem);

                        if (nbItems == listeItems.Length)
                        {
                            Item[] listeTemporaire = new Item[nbItems + 1];
                            for (int i = 0; i < listeItems.Length; i++)
                            {
                                listeTemporaire[i] = listeItems[i];
                            }
                            listeItems = listeTemporaire;
                        }

                        listeItems[nbItems] = new Item(nomItem, codeItem, prixItem, quantiteItem);
                        nbItems++;

                        break;

                    case 2:
                        Console.WriteLine("Le sous-total est : " + facture.sousTotal(listeItems));
                        break;

                    case 3:
                        Console.WriteLine("Les taxes sont : " + facture.taxes());
                        break;

                    case 4:
                        Console.WriteLine("Le total est : " + facture.calculerTotal());
                        break; 
                    case 5:
                        for (int i = 0; i < listeItems.Length; i++)
                        {
                            Console.WriteLine(listeItems[i].nom + " : ");
                            Console.WriteLine("   Code : " + listeItems[i].code);
                            Console.WriteLine("   Prix : " + listeItems[i].prix);
                            Console.WriteLine("   Quantité : " + listeItems[i].quantite);
                        }
                        break;

                    case -1:
                        actif = false;
                        break;
                }

            }
        }
        static void affichage()
        {
            Console.WriteLine("Que voulez-vous faire? Entrez -1 pour arrêter");
            Console.WriteLine("1. Ajouter un item");
            Console.WriteLine("2. Calculer le sous-total");
            Console.WriteLine("3. Calculer les taxes");
            Console.WriteLine("4. Calculer le total");
            Console.WriteLine("5. Afficher tous les items");
        }
    }
}