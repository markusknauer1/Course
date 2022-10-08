using System;
using System.Globalization;

namespace Course
{
    class ProdutoCap
    {
        /* ATENÇÂO: CODIGO QUE DEVE SER INSERIDO NO CLASS PROGRAM: 
         // construtor  é uma operação especial de classe, que executa no momento da instanciação do objeto

            // Usos comuns:
            /* Iniciar valores dos atributos; */
        /* Permitir ou obrigar objetos a receber dados / dependencias no momento de sua instaciação(injeção
           de dependencias ) */

        // se um construtor customizado não for especificado, a classe disponibiliza o construtor padrao:
        /* Produto p = new Produto(); */

        // é possivel especificar mais de um construtor na mesma classe (SOBRECARGA).

        /*====================================================================================================*/
        /*  
                Sobrecarga = é um recurso que uma classe possui de apresentar mais de uma
                operação com o mesmo nome porem com diferentes listas de parametros.  
                
                criação de construtor opcional o qual recebe  apenas nome e preço do produto. a 
                quantidade em estoque desse novo produto, por padrão é iniciada com o valor 0.

                NOTA: é possivel tambem incluir um CONSTRUTOR PADRÃO (sem paramêtros).

        
                //Palavra THIS
                // é uma referencia para o proprio objeto

                // usos comuns:
                    // diferenciar atributos de variaveis locais (Java);
                    // Referenciar outro construtor em um construtor;
                    // Passar o proprio objeto como argumento na chamada de um metodo ou construtor;

                Encapsulamento = 
                    é o principio que consiste em esconder detalhes de implementação de um componente, expondo 
                    apenas operações seguras e que o mantenha em um estado consistente;

                    REGRA DE OURO::: o objeto(ou componente) deve sempre estar em um estado consistente, e a propria classe
                    deve garantir isso.
                
            opção 1 =   ===implementação manual===
                      {Todo atributo é definido como private}
                      {Implementa-se métodos Get; Set; para cada atributo, conforme regras de negocio.}
                      {NOTA: não é usual da plataforma C#}
            
                 Propriedades
                    são definições de métodos encapsulados, porém expondo uma sintaxe similar à de atributos e não de métodos.
                    
                    Uma propriedade é um membro que oferece um mecanismo flexivel para ler, 
                    gravar ou calcular o valor de campo em particular. as propriedades pode ser usadas
                    como se fossem atributos publicos, mas na verdade elas são métodos especiais chamados 
                    "acessadores". Isso permite que os dados sejam acessados facilmente e ainda ajuda a promover
                    a segurança e a flexibilidade dos métodos.
                
                 propriedades autoimplementadas
                    são uma forma de se declarar propriedades que não necessitam de lógicas particulares para as operações
                    GET e SET;

                    // public double Preco{get; private set;}

                ordem sugerida da construção da classe:
                * Atributos privados;
                * Propriedades autoImplementadas;
                * Construtores;
                * propriedades Customizadas;
                * outros métodos.
                
                Modificadores de acesso=  / podem ser acessado por:
                para membros de uma classe
                
                * public = propria class/ subClasse no assembly / classes do assembly / subClasses fora do assembly / classes fora do assembly
                * protected internal = todos menos classes fora do assembly
                * internal =  todos menos subClasses e classes fora do assembly
                * protected = todos menos as classes do assembly e fora do assembly
                * pivate protected = propia classe e subClasses do assembly
                * private = somente a propria classe.
                
                Classes
                Acesso por qualquer classe
                    PUBLIC CLASS PRODUCT
                Acesso somente dentro do assembly
                    INTERNAL CLASS PRODUCT
                    CLASS PRODUCT
                Acesso somente pela classe-mãe
                    PRIVATE CLASS PRODUCT
                    NOTA: CLASSE ANINHADA, POR PADRÃO, É PRIVATE.
                
        */
        /*

            Console.WriteLine("Entre com os dados do produto: ");

            Console.WriteLine();
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            ProdutoCap p = new ProdutoCap(nome, preco);


            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a serem adicionados ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a serem removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);


            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
         */




        //atributos
        // public string _nome; FACIL ateração de valores pelo programador.
        // private string _nome; DIFICIL ateração de valores pelo programador.
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }


        /* EM CASO DE NECESSIDADE DE USAR UM CONSTRUTOR PADRÃO:*/
        public ProdutoCap() 
        {
        }
        public ProdutoCap(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;

        }


        //property
        public string Nome
        {
            //encapsulamento
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }





        /*public ProdutoCap(string Nome, double preco) : this()
       // atributos nome e preco escrito com letra maiuscula(string Nome, double Preco)
       // pode ser chamado com o this da forma que foi colocado abaixo após as barra (//)
       // this ajuda a diferenciar atributos de variaveis locais,
               /* em outras palavras, podem ser usadas para liberar uso de atributos com letra incial em maiuscula.*/

        /* {*/
        /*forma um      this.Nome = Nome; ou Nome = nome;*/
        /*forma dois    Preco = preco; ou this.Preco = Preco;*/
        /*              Quantidade = 5; 
            ATENÇÂO: QUANDO O ATRIBUTO DEFINIDO NÂO É ADICIONADO AO CONSTRUTOR, O VALOR INICIAL È ( 0 ).*/
        /* }*/

        /* EM CASO DE NECESSIDADE DE USAR UM CONSTRUTOR COM INFORMAÇÔES OBRIGATORIAS:*/
        /*public ProdutoCap(string Nome, double preco, int quantidade) : this(Nome, preco) // para usar o construtor com nome e preco  // Construtor //
        {
            Quantidade = quantidade;
        }*/

        /* EM CASO DE NECESSIDADE DE USAR UM CONSTRUTOR COM ATRIBUTOS COM VALOR DEFINIDO:*/


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
            return _nome
                + ", R$"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: R$ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }



    }
}
