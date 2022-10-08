using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class ConversorDeMoeda
    {   /* 
                       ATENÇÂO: CONTEUDO COMENTADO QUE DEVE SER COLOCADO NO CLASS PROGRAM
         
        Console.Write("Qual a cotação do dolar: ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine();
            Console.Write("Quantos dolares voce vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine();
            double result = ConversorDeMoeda.Conversao(quantia, cotacao);
        Console.WriteLine();
            Console.WriteLine("Valor a ser pago: " + result.ToString("F2", CultureInfo.InvariantCulture));
        */

        public static double Iof = 6.0;
        public static double Conversao(double quantia, double cotacao)
        {
            double total = quantia * cotacao;
            return total + total * Iof / 100.0;
        }
    }
}
