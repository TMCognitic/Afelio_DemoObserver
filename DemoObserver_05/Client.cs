using DemoObserver.PatternObserver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObserver
{
    public class Client
    {
        public string Nom { get; init; }

        public Client(string nom)
        {
            Nom = nom;
        }

        public void Reagit(object? sender, PropertyChangedEventArgs e)
        {
            Produit? produit = sender as Produit;

            if (produit is not null)
            {
                switch (e.PropertyName)
                {
                    case nameof(Produit.Prix):
                        Console.WriteLine($"{Nom} recoit la notification du changement de prix de {produit.Nom} : {produit.Prix}");
                        break;
                    default:
                        Console.WriteLine($"une propriété du produit {produit.Nom} a changé de valeur");
                        break;
                }
            }
        }
    }
}
