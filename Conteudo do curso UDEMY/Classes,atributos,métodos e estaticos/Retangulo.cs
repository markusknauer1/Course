using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Retangulo
    {
        /* ============================  CODIGO A SER INSERIDO NO CLASS PROGRAM  ==================================
         
        Retangulo a = new Retangulo();

        Console.WriteLine("Entre com a largura e a altura do retangulo: ");
        a.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        a.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        Console.WriteLine();
        Console.WriteLine("AREA = " + a.Area().ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine();
        Console.WriteLine("PERÍMETRO = " + a.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine();
        Console.WriteLine("DIAGONAL = " + a.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        
         ======================================================================================================= */
        public double Largura;
        public double Altura;
        public double Area() // calculo de area 
        {
            return Largura * Altura;
        }
        public double Perimetro() // calculo do perimetro
        {
            return 2*(Largura + Altura);
        }
        public double Diagonal() // calculo da diagonal 
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }
    }
}
