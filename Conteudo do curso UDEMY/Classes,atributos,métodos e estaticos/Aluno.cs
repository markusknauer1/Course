using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class Aluno
    {


        /* ============================ CONTEUDO A SER COLOCADO NO CLASS PROGRAM ==================================
        
        (MEDIA DE ALUNOS)

         Aluno m = new Aluno();

            Console.WriteLine("MEDIA DO ALUNO(A)");
            Console.Write("NOME DO ALUNO(A): ");
            m.NomeAluno = Console.ReadLine();

            Console.WriteLine("DIGITE AS TRÊS NOTAS DO ALUNO" + m.NomeAluno + ": ");
            m.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            m.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            m.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = "
            + m.Media().ToString("F2", CultureInfo.InvariantCulture));
            if (m.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM "
                + m.NotaRestante().ToString("F2", CultureInfo.InvariantCulture)
                + " PONTOS");
            }
           ===================================================================================================== */
        public string NomeAluno;
        public double nota1,nota2,nota3;

        public double Media()
        {
            return nota1 + nota2 + nota3;
        }

        public bool Aprovado()
        {
            if (Media() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - Media();
            }
        }
    }
}
