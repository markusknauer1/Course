using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course
{
    class ProdutoCap5
    {
        /*
            ATENÇÂO: DADOS A SEREM ADICIONADOS AO CLASS PROGRAM PARA VER FUNCIONANDO

        Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: "); p.Nome = Console.ReadLine();
            Console.Write("Preço: "); p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: "); p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a serem adicionados ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: "+ p);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a serem removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);


            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

         */
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            //formula para calcular valor total de estoque de produtos
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            //formula para adição de produtos:
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            //formula para subtração de produtos:
            Quantidade -= quantidade;
        }



        //sobreposição
        public override string ToString()
        {
                            /* formula to string para apresentação de frase complementada aos produtos
                               adicionados aos objetos citados acima:                                   */
            return Nome 
                + ", R$" 
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                +", "
                + Quantidade
                + " unidades, Total: R$ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

        
        
    }
}
