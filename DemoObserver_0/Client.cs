using DemoObserver.PatternObserver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObserver
{
    public class Client : Observer
    {
        public string Nom { get; init; }

        public Client(string nom)
        {
            Nom = nom;
        }

        public override void Update(Subject sender)
        {
            Produit? produit = sender as Produit;

            if(produit is not null)
            {
                Console.WriteLine($"{Nom} recoit la notification du changement de prix de {produit.Nom} : {produit.Prix}");
            }
        }
    }
}
