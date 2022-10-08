using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class Circunferencia
    {
        // ATENÇÂO : CODIGOS QUE DEVEM SER INSERIDO APENAS NO PROGRAM

        //static double Pi = 3.14;
        //static void Main(string[] args)
        //{
            //atributos = dados ---- metodos = são as funções e operações;

            /* Mebros estaticos tambem chamados de membros de classe: em oposição são mebros de instâncias.*/

            /* mebros que fazem sentido independententemente de objetos, não precisam de objetos, são chamados
               direto pelo nome da classe. */

            /* Aplicações comuns: 
                    classes utilitarias: exemplo de uso  ==> Math.Sqrt(double)
                    declarações de constantes: 
            */

            /* uma classe que possui somente membros estaticos, pode ser uma classe estatica tbm, essa classe 
               não podera ser instânciada. */

            /* EXEMPLO 

            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia(raio);
            double Vol = Volume(raio);

            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + Vol.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + Pi.ToString("F2", CultureInfo.InvariantCulture));

            */

        //}
        /*
        static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }
        static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }
        */
        
    }
}
