/*
             //=====================DISCUSSÃO INICIAL SOBRE EXCEÇÕES
            EXCEÇÔES:
            é uma exceção qualquer condição de erro ou comportamento inesperado encontrado por um programa EM EXECUÇÃO

            No .NET, uma exceção é um objeto herdado da classe SYSTEM.EXCEPTION

            Quando lançada, uma exceção é propagada na pilha de chamadas de métodos em execução, 
            até que seja capturada(tratada) ou o programa seja encerrado.


            porque excessões:
                o modelo de tratamento de exceções permite que erros sejam tratados de forma consistente
                e flexivel, usando boas praticas;

            vantagens:
                Delega a lógica de erro para a classe / método responsável por conhecer as regras que podem ocasionar o erro;
                
                Trata de forma organizada (inclusive hierarquica) exceções de tipos diferentes;
                
                A esceção pode carregar dados quaisquer.

            //==============================================================================
            ESTRUTURA TRY-CATCH

            Bloco try : 
                Contém o código que representa a execução normal do trecho de código que pode acarretar em uma exceção;

            Bloco catch:
                contém o código a ser executado caso uma exceção ocorra;
                Deve ser especificado o tipo da exceção a ser tratada(upcasting e downcating)
            Bloco finally:
                é um bloco que contém código a ser executado independentemente de ter ocorrido ou não uma exceção.
                Exemplo clássico: fechar um arquivo ou conexão de banco de dados ao final do processamento.
            SINTAXE
                try{
            }
                catch (ExceptionType e){

            }
                catch (ExceptionType e){

            }
                catch (ExceptionType e){

            }
                finally{

            }
            DEMO - 1:
                try { 
            int n1 = int.Parse(Console.ReadLine());

            int n2 = int.Parse(Console.ReadLine());

            int result = n1 / n2;
            Console.WriteLine(result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Division by zero is not allowed! ");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error! "+ e.Message);
            }    
            try
            {
                int n1 = int.Parse(Console.ReadLine());

                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Division by zero is not allowed! ");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format Incorrect!");
            }
            finally // executa este bloco dando try or catch (true or false)
            {
                Console.WriteLine("Até a proxima!");
            }      
            

            Solução de problema
            Solução 1( MUITO RUIM ): lógica de validação no programa principal
                -   Lógica de validação não delegada à reserva

            Solução dois( RUIM ): método retornando string
                -   A semantica da operação é prejudicada
                    *   Retornar strting não tem nada haver com atualização de reserva
                    *   e se a operação tivesse que retornar um string? daria conflito
                -   Ainda não é possivel tratar exceções em construtores
                    *   a logica de tratamento de exceções ainda estava no progarama principal ao invés de está na classe.
                    
                -   A lógica fica estruturada em condicionais aninhadas
                    *   ainda tem a estrutura if-else no program principal
            
            Solução 3(Boa): tratando com exceções
                -   Resumo
                    *   Clausula throw: lança a exceção / "corta" o metodo
                    *   O modelo de tratamento de exceções permite que erros sejam tratados de forma consistente e flexivel, usando boas praticas
                -   Vantagens:
                    *   Lógica delegada;
                    *   Construtores podem ter exceções;
                    *   Código mais simples. Não há aninhamento de condicionais: a qualquer momento que uma exceção for disparada, a execução é 
                        interrompida e cai no bloco correspondente.
                    *   É possivel capturar inclusive outras exceções de sistema.
                
                
                try
                {
                    //CONSULTA DE RESERVA

                    Console.Write("Room number: ");
                    int number = int.Parse(Console.ReadLine());
                    Console.Write("Check-In date (dd/mm/yyyy): ");
                    DateTime checkIn = DateTime.Parse(Console.ReadLine());
                    Console.Write("Check-Out date (dd/mm/yyyy): ");
                    DateTime checkOut = DateTime.Parse(Console.ReadLine());

                    Reservation reservation = new Reservation(number, checkIn, checkOut);
                    Console.WriteLine("Reservation: " + reservation);

                    //=========================================================================================================

                    // ATUALIZAÇÂO DE RESERVA

                    Console.WriteLine();
                    Console.WriteLine("Enter data to update the reservation: ");
                    Console.Write("Check-In date (dd/mm/yyyy): ");
                    checkIn = DateTime.Parse(Console.ReadLine());
                    Console.Write("Check-Out date (dd/mm/yyyy): ");
                    checkOut = DateTime.Parse(Console.ReadLine());

                    reservation.UpdateDates(checkIn, checkOut);
                    Console.WriteLine("Reservation: " + reservation);
                }
                catch ( DomainException e )
                {
                    Console.WriteLine("Error in reservation: " + e.Message); // IMPRESSÂO DO CONSOLE: Error in reservation: + mensagem escrita na classe "DOMAINEXCEPTIO"
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Format error: "+ e.Message); // IMPRESSÂO DO CONSOLE: Format error: Input string was not in a correct format.
                }
                catch(Exception e)
                {
                    Console.WriteLine("Unexpected error: " + e.Message); // IMPRESSÂO DO CONSOLE: Unexpected error: Input string was not in a correct format.
                }
             */
using Course.Entities.Exceptions;

namespace Course.Entities
{
    internal class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {
        }
        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-Out date must be after check-in date!");
            }

            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }
        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }
       
        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn <= now || checkOut <= now)
            {
                throw new DomainException("Reservation dates for update must be future dates ");
            }
            if (checkOut <= checkIn)
            {
                throw new DomainException("Check-Out date must be after check-in date!") ;
            }

            CheckIn = checkIn;
            CheckOut = checkOut;
        }
        public override string ToString()
        {
            return "Room: "
                + RoomNumber
                + ", check-In: "
                + CheckIn.ToString("dd/MM/yyyy")
                + ", check-Out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                +" nights.";
        }
    }
}
