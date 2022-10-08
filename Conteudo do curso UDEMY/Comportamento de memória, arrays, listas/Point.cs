

namespace Course
{/*Tipos referencia vs. tipo Valor*/
    /* classes são tipos referencias - Variaveis cujo tipo 
       são classes nao devem ser intendidos como caixas, 
       mas sim "tentaculos"(ponteiros para caixas)


    product p1, p2 variaveis que vao para stack

    stack por sua vez guarda o endereço (0x100358) que a variavel 
    p1 apontara para o conteudo armazenado = ("TV",900.00,0),
    mas somente quando a variavel for utilizada:
    p1 = new Product("TV", 900.00, 0)

    p2 = p1 = apontam para o mesmo objeto

    Valor = null
    tipos referencia aceitam o valor "null", que indica que a variavel aponta pra ninguem.
    product p1, p2;
    p1 = new Product("TV", 900.00, 0)
    p2 =null

    structs são os tipos valor
    a liguagem C# possui tambem tipos valor, que são os "structs". Structs são CAIXAS e não ponteiros.

    double x,y;
    x=10; caixa tem 10
    y = x; caixa recebe copia de x=10

    Point p;
    p.X = 10;
    p.Y = 20;

    Console.WriteLine(p);

    p = new Point();
    Console.WriteLine(p);

    valores padrão de qualquer tipo estruturado alocado em (new):
        *   numeros:0;
        *   bool: False;
        *   char: caractere código 0;
        *   objeto:null;

    ATENÇÂO: uma variavel apenas declarada, mas não instanciada, inicia em estado "Não atribuida", e o proprio
             compilador não permite que ela seja acessada.

    Point p;
    Console.WriteLine(p); p = variavel nao atribuida

    Garbage collector
    é gerenciador automatizado de memoria em tempo de execução.
    monitora usos temporarios da memoria e desaloca os objetos não mais utilizados.

    desalocação por escopo

    * objetos alocados dinamicamente, quando não possuem mais referencia para eles, serão desalocados pelo garbage collector.
    * Variaveis locais são desalocadas imediantamente assim que seu escopo local sai de execução.
     
    NULLABLE

    é um recurso de C# para que dados de tipo (structs) possam receber Valo null.

    uso comun:
    * Campos de banco de dados que podem valer nulo ( data de nascimento, algum valor numérico, etc.).
    * Dados e paramêtros opcionais.
    

    //      Nullable<double> x = null;

            double? x = null;
            double? y = 10.0;
            
            // GetValueOrDefault >> getValue= valor do (X ou Y) / orDefault  = ou valor padrao
            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue); // false =  nao existi valor
            Console.WriteLine(y.HasValue); // true =  existi valor

            if (x.HasValue)
            {
                Console.WriteLine(x.Value); // lança excessão se tentar chamar um objeto nullable que vale null
            }
            else
            {
                Console.WriteLine("X is null");
            }
            if (x.HasValue)
            {
                Console.WriteLine(y.Value); // lança excessão se tentar chamar um objeto nullable que vale null
            }
            else
            {
                Console.WriteLine("Y is null");
            }


    OPERADOR DE COALESCÊNCIA NULA

       ?? = double? x = null; //se caso o valor de x não for nulo: o valor de y é o especificado em x
            double? y = 10;
            //double? y = x ?? 0.0;  se for ele joga o valor digitado ao (direto) das duplas ?? no caso 0;

            double a = x ?? 5;
            double b = y ?? 5;

            Console.WriteLine(a); // impressão = 5 porque o x é null
            Console.WriteLine(b); // impressão = 10 porque o y não é null


    VETORES - Parte 1
    Chekclist
    vetor(array) = arranjos unidimensionais;

    estrutura de array(arranjos):
    Homogenea: dados de mesmo tipo;
    Ordenada: elementos acessados por meio de posições;
    Alocada: Alocada de uma vez só, em um bloco continuo da memoria.

    vantagem: Acesso imediato aos elementos pela sua posição: pesquisa posição 500 resposta posição 500;

    desvantagens: 
                tamanho fixo: realocações da memoria.
                Dificuldade para fazer inserções e deleções: ajustes.


    conceito de vetor:

    Manipulação de vetor de elementos tipo structs:
    
    Manipulação de vetor de elementos tipo classe:

    acesso aos elementos:

    Propriedade lenght:

    exemplo 1 de vetro:

    int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;
            for(int i = 0; i < n; i++)
            {
                sum+= vect[i];
            }
            double avg = sum/n;

            Console.WriteLine("AVERAGE HEIGHT = " + avg.ToString("F2", CultureInfo.InvariantCulture));


    exemplo2 de vetor do tipo classe:

        
    *//*
       ATENÇÃO - DESCOMENTAR COM CUIDADO
    struct Point
    { 
       public double X;
        public double Y;

        public override string ToString()
        {
            return "(" + X + ", "+ Y +")";
        }
        
        
    }*/
}
