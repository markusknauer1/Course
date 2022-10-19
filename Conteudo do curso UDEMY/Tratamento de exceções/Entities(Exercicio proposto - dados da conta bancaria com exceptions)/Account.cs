/*
    
            //CONSULTA DE DADOS DA CONTA

            Console.WriteLine("Enter account data: ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string name = Console.ReadLine();
            Console.Write("Balance: ");
            double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("WithdrawLimit: ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account acc = new Account(number, name, balance, withdrawLimit);
            Console.WriteLine("Dados da conta: " + acc);



            //=====================================================================
            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            try
            {
                acc.Withdraw(amount);
                Console.WriteLine("Dados da conta Atualizados: " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture)); // para mostrar somente valor atualizado da conta.
                //OR
                
                Console.WriteLine("Dados da conta Atualizados: " + acc); // para mostrar informações da conta completa, junto com o valor atualizado da conta.
            }
            catch (LimitException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
 */
using Course.Entities.Exceptions;

namespace Course.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }
        public double WithdrawLimit { get; protected set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public virtual void Deposit(double amount)
        {
            Balance += amount;
        }
        public virtual void Withdraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new LimitException("valor inadimplente para saque neste momento!");
            }
            if (amount > Balance)
            {
                throw new LimitException("valor acima do disponivel em conta!");
            }
            Balance -= amount;
        }
       
        public override string ToString()
        {
            return "Number: "
                + Number
                + ", Holder: "
                + Holder
                + ", Balance: R$"
                + Balance
                + ", WithdrawLimit R$"
                + WithdrawLimit
                + ".";
        }
    }
}
