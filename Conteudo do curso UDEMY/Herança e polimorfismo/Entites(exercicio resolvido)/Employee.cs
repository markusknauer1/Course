using System;
using System.Collections.Generic;
namespace Course.Entites
{
    class Employee
    {
        /*  // SERVIÇO A SER APLICADO PELO DIRETORIO PROGRAM.CS
         

            List<Employee> list = new List<Employee>();

            Console.WriteLine("Enter the number of Employees: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced(y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours? ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valueperhour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if(ch == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsourcedEmployee(name, hours, valueperhour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valueperhour));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS: ");
            foreach(Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - R$"+ emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
         */
        public string Name { get; set; }
        public int Hours { get; set; }//integer = int
        public double ValuePerHour { get; set; }

        public Employee()
        {
        }
        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            return Hours * ValuePerHour;    
        }
    }
}
