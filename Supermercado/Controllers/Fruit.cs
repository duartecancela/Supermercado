namespace Supermercado.Controllers
{
    public class Fruit
    {
        public int id;
        public string name;
        public double price;

        // Parameterized Constructor
        // User defined
        public Fruit(int i, string s, double d)
        {
            id = i;
            name = s;
            price = d;
        }
    }
}
