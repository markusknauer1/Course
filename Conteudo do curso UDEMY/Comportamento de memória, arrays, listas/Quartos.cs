using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class Quartos
    {
        /* ATENÇÂO: CODIGO A SER INSERIDO NO ARQUIVO CLASS PROGRAM
         * 
         Quartos[] vect = new Quartos[10];

            Console.Write("quantos quartos serão alugados? "); int n = int.Parse(Console.ReadLine());
            



            for (int i = 1; i < n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"aluguel #{i}:");
                Console.Write("Nome:");
                string name = Console.ReadLine();
                Console.Write("Email:");
                string mail = Console.ReadLine();
                Console.Write("Quarto:");
                int quarto = int.Parse(Console.ReadLine());

                vect[quarto] = new Quartos(name, mail);
            }
            Console.WriteLine();
            Console.WriteLine("Quartos alugados: ");
            for(int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i+": " + vect[i]);
                }
            }
         */
        public string Name { get; set; }
        public string Mail { get; set; }

        public Quartos(string name, string mail)
        {
            Name = name;
            Mail = mail;

        }
        public override string ToString()
        {
            return Name + ", " + Mail;
        }
    }
}
