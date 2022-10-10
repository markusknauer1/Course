using System;

namespace Course.Entities
{
    class HoursContract
    {
        public DateTime Date{ get; set; } // data do contrato
        public double ValuePerHour { get; set; } // valor por hora
        public int Hours{ get; set; } // duração em horas

        public HoursContract()
        {
        }
        public HoursContract(DateTime data, double valuePerHour, int hours) // (construtor)
        {
            Date = data;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue() // retornar o valor total do contrato(metodo)
        {
            return Hours * ValuePerHour; // horas X valor por hora
        }
    }
}