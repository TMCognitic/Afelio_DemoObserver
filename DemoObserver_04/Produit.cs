using DemoObserver.PatternObserver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObserver
{
    public class Produit : Subject
    {
        public string Nom { get; init; }

        public Produit(string nom)
        {
            Nom = nom;
        }

        private double _prix;

        public double Prix
        {
            get
            {
                return _prix;
            }

            set
            {
                if(_prix != value)
                {
                    _prix = value;
                    Notify();
                }
            }
        }

    }
}
