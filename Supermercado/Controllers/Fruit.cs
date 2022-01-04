namespace Supermercado.Controllers
{
    public class Fruit
    {
        private int id { get; set; }
        private string name { get; set; }
        private double price { get; set; }

        // Parameterized Constructor
        // User defined
        public Fruit(int id, string name, double price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        //public int Id
        //{
        //    get { return id; }
        //    set { id = value; }
        //}

        //public int Id
        //{
        //    get { return id; }
        //    set { id = value; }
        //}

        //public double Price
        //{
        //    get { return price; }
        //    set { price = value; }
        //}

    }
}
