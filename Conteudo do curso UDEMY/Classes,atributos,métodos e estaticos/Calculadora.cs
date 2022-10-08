namespace Course
{
    /*membros estaticos - parte 2 - ATENÇÂO: CODIGO COMENTADO DEVE SER COLOCADO NA CLASSE PROGRAM*/


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

    double circ = Calculadora.Circunferencia(raio);
    double Vol = Calculadora.Volume(raio);

    Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Volume: " + Vol.ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("Valor de Pi: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
*/
    public class Calculadora
    {
        public static double Pi = 3.14;
        public static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }
        public static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);
        }
    }
    
}
