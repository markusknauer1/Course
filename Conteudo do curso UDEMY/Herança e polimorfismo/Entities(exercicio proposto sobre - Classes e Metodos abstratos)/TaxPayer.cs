
using System.Drawing;

namespace Course.Entities
{
    /*
                 List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)?: ");
                char typeTax = char.Parse(Console.ReadLine()); 
                Console.Write("Name; ");
                string name = Console.ReadLine();
                Console.Write("Value income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (typeTax == 'i')
                {
                    Console.Write("Health Expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("number of Employees: ");
                    int employees = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, anualIncome, employees));
                }
            }

            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID: ");
            foreach (TaxPayer tp in list)
            {
                double tax = tp.Tax();
                Console.WriteLine(tp.Name+": R$"+tax.ToString("F2",CultureInfo.InvariantCulture));
                sum += tax;
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: R$"+ sum.ToString("F2", CultureInfo.InvariantCulture));
     */
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }
       
        public TaxPayer()
        {
        }
        protected TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }
        public abstract double Tax();
    }
}
