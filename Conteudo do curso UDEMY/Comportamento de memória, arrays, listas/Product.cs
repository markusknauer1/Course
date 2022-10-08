

namespace Course
{
    public class Product
    {
        /* ATENÇÃO: CODIGO DE EXEMPLO DE CRIAÇÂO DE TIPO STRUCT DE ARRAY
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product(name, price);
            }
            double sum = 0.0;
            for(int i = 0; i < n; i++)
            {
                sum += vect[i].Price;
            }
            double avg = sum / n;

            Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2", CultureInfo.InvariantCulture));
         */
        public string Name{ get; set; }
        public double Price{ get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
