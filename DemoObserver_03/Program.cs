namespace DemoObserver
{
    class Program
    {
        static void Main(string[] args)
        {
            Produit coca = new Produit("Coca 50cl");
            Client mehdy = new Client("Mehdy");
            Client david = new Client("David");

            coca.Attach(mehdy.Reagit);
            coca.Attach(david.Reagit);

            coca.Prix = .8;
        }
    }
}
