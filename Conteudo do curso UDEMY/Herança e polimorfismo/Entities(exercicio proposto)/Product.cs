using System.Globalization;

namespace Course.Entities
{
    class Product
    {
        /*
            // EXERCICIO PROPOSTO PARA FIXAÇÂO DE CONTEUDO


          List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Product #{i} data: ");
                Console.Write("Product of type: (common, used or imported - c/u/i)? ");
                char type = char.Parse(Console.ReadLine());
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (type == 'c')
                {
                    list.Add(new Product(name, price));
                }
                else if (type == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(name, price, customsFee));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAG's: ");
            foreach (Product prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }
         */
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public virtual string PriceTag()
        {
            return Name
                + " R$"
                + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
