using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class Funcionario
    {
        /*===================================CODIGO A SER INSERIDO NA CLASS "PROGRAM"===========================
         
            Funcionario a = new Funcionario(); 

            Console.WriteLine("Dados do funcionario: ");

            Console.WriteLine("Nome do funcionario: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Salario Bruto do funcionario: ");
            a.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Descontos: ");
            a.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Líquido a receber: " + a);
            Console.WriteLine();

            Console.Write("Digite a porcentagem para o aumento do salario de "+a.Nome+": ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.AumentarSalario(porcentagem);

            Console.WriteLine();
            Console.WriteLine("liquido atualizado: " + a);
            
         ========================================================================================================*/
        //informações do funcionario

        public string Nome;
        public double SalarioBruto;
        public double Imposto;


        public double SalarioLiquido() // Salario liquido 
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem) // aumento de salario sobre a porcentagem
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0);
        }


        public override string ToString()
        {
            return Nome
            + ", R$ "
            + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
