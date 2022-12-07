namespace DemoObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            Produit coca = new Produit("Coca 50cl");
            Produit cecemel = new Produit("Cécémel 30cl");
            Client mehdy = new Client("Mehdy");
            Client david = new Client("David");

            coca.PropertyChanged += mehdy.Reagit;
            coca.PropertyChanged += david.Reagit;

            coca.Prix = .8;

        }
    }
}
