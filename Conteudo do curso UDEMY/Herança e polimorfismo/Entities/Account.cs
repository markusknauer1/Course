/*
//  Herença
        É um tipo de associação que permite que uma classe herde dados e comportamento de outra.

//  definições importante
        * Realção "é-um"
        * Generalização/especialização
        * Superclasse(classe base) / subclasse (classe derivada)
        * Herança / extensão
        * Herança é uma associação entre classes(e não entre objetos)

//  Vantagens:
        * Reuso
        * Polimorfismo
            
//  Desvantagem:
        * :(estende)
        * bas(referência para a superclasse)


//  Upcasting: 
        *   casting = conversão de um tipo para outro;
        *   casting da subClasse para superclasse conversão de um objeto de um tipo para outro objeto
        *   Uso comum: polimorfismo
                
//  Downcasting;
        *   Casting da superclasse para subclasse; processo inverso
        *   palavra as
        *   palavra is
        *   uso comum: métodos que recebem parâmetros genéricos(ex: Equals)

    


            Account acc = new Account(1001, "Alex", 0.0);

            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

//UPCASTING
            // conversão aceita porque é uma relação "É-UM" - UPCASTING
            Account acc1 = bacc;

            // atribuição de dados da subClasse para a superclasse => Account acc2 = new Business()
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Wil", 0.0, 0.01);

//DOWNCASTING - operação insegura e precisa saber se a variavel é necessaria
            // atribuição de dados da superclasse para a subClasse, mas precisa de uma
            
            // "castin"() => BusinessAccount acc4 = ()acc2 
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);

            //  BusinessAccount acc5 = (BusinessAccount)acc3; - erro de conversão

            //  BusinessAccount acc5 = (BusinessAccount)acc3;
            if (acc3 is BusinessAccount)
            {
                //  BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;//instanciando as variaveis da subclasse com "as"
                acc5.Loan(200.00);
                Console.WriteLine("Loan");
            }
            if (acc3 is SavingsAccount)
            {
                //  SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;//instanciando as variaveis da subclasse com "as"
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
            
//sobreposição, Palavras Virtual, override e base
    //  SOBREPOSIÇÃO ou SOBRESCRITA
            -   é uma implementação de um método de uma superclasse na subclasse.
            -   para que um método comum (não abstrato) possa ser sobreposto, deve ser incluido nele o prefixo "virtual".
            -   Ao sobrescrever um método, devemos incluir nele o prefixo "override".
                
    //  PALAVRAS: VIRTUAL, OVERRIDE E BASE
            -   virtual: prefixo principal no arquivo account para descontar os "R$5,00";
            -   override: prefixo para sobrescrever o metodo na subclasse para não haver desconto;
            -   base: é possivel chamar a implementação da superclasse usando a palavra base.

            public override void Withdraw(double amount) // decrement
            {
            Balance -= amount;
            }

            public override void Withdraw(double amount) // decrement
            {
            base.Withdraw(amount);//increment      //base: serve para chamar o metodo comun de superclasse
            Balance -= 2.0;
            }

//  CLASSES E MÉTODOS SELADOS
    -   Palavra chave: sealed - selado
    -   CLASSE: evita que a classe seja herdada
        *   Nota: ainda é possivel extender a funcionalidade de uma classe selada usando: "extension methods";
        *   evita que seja criadas subclasses de subclasses;
                    
        namespace course{   
            sealed class SavinsAccount{
                    
    -   MÉTODO: evita que um método sobreposto possa ser sobreposto novamente
        *   Só pode ser aplicado a métodos sobrepostos 
                    
    PRA QUE SERVER?
            SEGURANÇA: dependendo das regras de negócio, ás vezes é desejavel garantir 
            que uma classe não seja herdada, ou que um método não seja sobreposto
                *   Geralmente convém sela métodos sobrepostos, pois sobreposições múltiplas podem 
                    ser uma porta de entrada para inconsistencias;
            PERFORMANCE: atributos de tipo de uma classe selada são analisados de forma mais rapida 
            em tempo de execusão.
                *   Exemplo clássico: String.
                               
// INTORUDUÇÃO  AO POLIMORFISMO
        PILARES DA OOP:
        - Emcapsulamento
        - Herança
        - Polimorfismo
              
    Polimorfismo: Em Programação Orientada a Objetos(OOP), polimorfismo é um recurso que permite que variaveis de 
    um mesmo tipo mais genérico possam apontar para objetos de tipos especifícos diferentes, tendo assim 
    comportamentos diferentes conforme cada tipo especifíco.em ouyras palavras são variaveis do mesmo tipo 
    instaciadas com objetos diferentes que terão comportamentos diferentes.

IMPORTANTE ENTENDER:
    A associação do tipo especifíco com o tipo genérico é feita EM TEMPO DE EXECUÇÃO(upcasting)
                
    o compilador não sabe para qual tipo especifíco a chamada do método Withdraw 
    está sendo feita (ele só sabe que são duas variaveis do tipo Account)
            
    acc1.Withdraw(10.0); //(ele só sabe que são duas variaveis do tipo Account)

*/

namespace Course.Entities
{
    class Account
    {
        public int Number { get;  private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw (double amount)
        {
            Balance -= amount + 5.0;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
