namespace Supermercado.Controllers
{
    public class Fruit
    {
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }

        // Parameterized Constructor
        // User defined
        public Fruit(int id, string name, double price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

    }
}
