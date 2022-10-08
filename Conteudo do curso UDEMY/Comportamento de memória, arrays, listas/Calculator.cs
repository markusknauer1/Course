using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class Calculator
    {
        /*
         //modificador de parametros: PARAMS =======================

            int s1 = Calculator.Sum(2, 3);// com params
            int s2 = Calculator.Sum(new int[] {2, 4, 3 }); //sem params
            int s3 = Calculator.Sum(new int[] {2, 4, 3, 5 });

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
         
        public static int Sum(params int[] numbers)
        {
            int sum = 0;    
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }
          /*
            //modificador de parametros: REF e OUT =======================

            //out:  
              /o modificador out é similar ao ref(faz o parametro ser uma referencia para a variavel original),
              //mas não exige que a variavel original seja iniciada. 


            CONSIDERAÇÔES:
            DIFERENÇA: variaveis de parametros REF deve ser INICIADA;
                       variaveis de parametros OUT nao precisam ser iniciada;

            CONCULSÃO: ambos são muito similares, mas o para metro REF força o 
                       compilador a obrigar o usuario a iniciar as variaveis.

            NOTA: ambos são considerados "code smells" (design ruim) e devem ser evitados.

            ============================================
            int a = 10;
            int triple;
            Calculator.Triple(a, out triple);

            Console.WriteLine(triple);

        
        public static void Triple(int origin, out int result) {

            //x = x * 3;

            result = origin * 3;
        }

        =============================================================================
            
            // Boxing e umboxing

            // Boxing: conversão de objeto tipo valor para objeto tipo referencia compativel;

            int x = 20;

            object obj = x;

            // unBoxing: conversão de objeto tipo referencia  para objeto tipo valor compativel;

            int y = (int) obj;

        ==============================================================================
            
            // Sintaxe opcional: laço foreach

            //sintaxe opcional e simpleficada para percorrer coleções;
            // Leitura:"para cada objeto 'obj' contido em vect, faça:";

            string[] vect = new string[] { "Maria", "Bob", "Alex" };

            for(int i = 0; i < vect.Length; i++) { 
                
                Console.WriteLine(vect[i]);
            }
            Console.WriteLine("-------------------------------------------");
            foreach (string obj in vect)
            {
                Console.WriteLine(obj);
            }
            
        ==============================================================================



        ==============================================================================
         */
    }
}
