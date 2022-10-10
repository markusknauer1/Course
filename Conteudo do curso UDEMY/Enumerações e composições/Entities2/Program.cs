/*
    
        EXERCICIO:
            Ler os dados de um trabalhador com N contratos(N fornecido pelo usuario). Depois, 
            solicitar do usuario um mes e mostrar qual foi o salario do funcionario ness mes,
            conforme exemplo:


             
                using Course.Entities.Enums;
                using Course.Entities;
                using System.Globalization;

                Console.Write("Enter department's name: ");
                string deptName = Console.ReadLine();// Nome do departamento

                Console.WriteLine("Enter worker data: ");
                Console.Write("Name: ");
                string name = Console.ReadLine();// Nome do funcionario

                Console.Write("level(Junior, MideLevel, Senior): ");
                WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());// nivel do funcionário

                Console.Write("Base Salary: ");
                double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);// base salarial


                //  * instanciando os dois objetos(worker e departamento):
                // instanciando o departamento 
                Department dept = new Department(deptName);

                // instanciando o trabalhador com o departamento 
                Worker worker = new Worker(name, level, baseSalary, dept);





                Console.Write("How many contracts to this worker?: ");
                int n = int.Parse(Console.ReadLine());  // numero de contratos

                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine($"Enter #{i} contract data: "); // ID do contrato (#1, #2, #3, etc...) / {i} = interpolação
                    Console.Write("Date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine()); // Data do contrato

                    Console.WriteLine("Value per hour: ");
                    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Valor por hora

                    Console.WriteLine("Duration (hours)");
                    int hours = int.Parse(Console.ReadLine()); // Quantidade de horas trabalhadas

                    HoursContract contract = new HoursContract(date, valuePerHour, hours);

                    worker.AddContract(contract); // adicionar contrato ao trabalhador
                }

                //========================================(0,1,2,3,4,5)
                Console.WriteLine();    //========================================(M M/Y Y Y Y)
                Console.WriteLine(" Enter month and year to calculate Income (MM/YYYY): ");

                string monthAndYear = Console.ReadLine();
                //========================================(0,1,2,3,4,5,6) > posição do recorte
                //========================================(M M / Y Y Y Y) > item da posição
                int month = int.Parse(monthAndYear.Substring(0, 2));
                //(0, 2) recorte da data, apartir da posição 0, duas posições(0,1) = 08 de "08/2022"

                int year = int.Parse(monthAndYear.Substring(3));
                //(3) recorte do ano,  apartir da posição 3, resto(3,4,5,6) = 2022 de "08/2022"

                //impressão dos dados do funcionario:
                Console.WriteLine("Name: " + worker.Name);
                Console.WriteLine("Department: " + worker.Department.Name);
                Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month), CultureInfo.InvariantCulture);
*/