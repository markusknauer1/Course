using Course.Entities;
using Course.Entities.Enums;

namespace Course.Entities
{
    class Worker//Trabalhador
    {
        public string Name { get; set; } // nome do trabalhador
        public WorkerLevel Level { get; set;} // nivel do funcionario
        public double BaseSalary { get; set; } // salario base

        public Department Department { get; set; } 
        // propriedade Departamento que traz a COMPOSIÇÂO de objetos(Associação entre worker e departamento) 
        // associcação entre classes diferentes
        // objetos na memoria:
        // Worker: Name, level, basSalary ========> Department: name (Diagrama de objetos);


        public List<HoursContract> Contracts { get; set; } = new List<HoursContract>();
        // por ser varios contratos; a propriedade foi instanciada como lista(List),
        // e logo apos o get;set; foi instaciado a propriedade com o new para garantir que não seja nula(nullable)


        public Worker()
        {
            //Construtor padrão
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;    
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
            // construtor com argumentos;
            // ATENÇÃO: ASSOCIAÇÂO PARA MUITOS NÂO DEVE SER CRIADOS, POR NÂO SER USUAL, E ASSIM A LISTA SERA INCREMENTADA 
            //          DE ACORDO COM A NECESSIDADE;
        }

        public void AddContract(HoursContract contract)//METODO DE ADICIONAR ITEMS NA LISTA 
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HoursContract contract)//METODO DE REMOVER ITEMS NA LISTA
        {
            Contracts.Remove(contract);
        }

        public double  Income(int year, int month) // METODO GANHO: PARA SABER QUANTO O FUNCIONARIO GANHOU NO ANO E MES
        {
            double sum = BaseSalary; // soma =  salario base fixo

            foreach (/*pra cada*/ HoursContract contract /*na lista*/ in Contracts) // percorrer a lista
            {
                
                // se o ano e o mes recebido no argumento acima bater com o registrado na lista,
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    // estes serão adicionados a soma
                    sum += contract.TotalValue(); //soma + o valor total do contrato/ totalvalue retorna o valor total do contrato
                }
            }
            return sum; // dps de percorrido a lista e consultado as informações solicitadas, retornar a soma
        }

    }


}