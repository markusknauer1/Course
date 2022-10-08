
using System.Globalization;

namespace Course
{
    class ContaBancaria
    {
        /* PROJETO DE ESTUDOS - COLOCAR O CODIGO COMENTADO NO CLASS PROGRAM
            ContaBancaria conta;

            Console.WriteLine("Entre com os dados da conta: ");

            Console.WriteLine();
            Console.Write("Nº da Conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Nome do Títular: ");
            string titular = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Haverá deposito inicial (S/N)? ");
            char resp = char.Parse(Console.ReadLine());
            if( resp == 's' || resp == 'S')
            {
                Console.Write("Entre com o valor inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(titular, numero, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(numero,titular);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);



            Console.WriteLine();
            Console.Write("Entre com o valor para deposito: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(quantia);
            Console.Write("Dados atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com o valor para Saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.Write("Dados atualizados: ");
            Console.WriteLine(conta);


         */
        public int NumeroConta { get; private set; }
        public string TitularConta { get; set; }
        public double Saldo { get; private set; }


        public ContaBancaria(int numero, string titular)
        {
            NumeroConta = numero;
            TitularConta = titular;
            /*
            Saldo = 0*/
        }
        public ContaBancaria(string titular, int numero, double depositoInicial) : this(numero, titular)
        {
            Deposito(depositoInicial);
            //Saldo = depositoInicial;
        }


        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
            //ou
            //Saldo -= quantia;
            //Saldo -= 5.0;
        }



        public override string ToString()
        {
            /* formula to string para apresentação de frase complementada aos produtos
               adicionados aos objetos citados acima:                                   */
            return "Conta: "
                + NumeroConta 
                + "  Titular: "
                + TitularConta
                +", saldo atual: R$"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
