using Course.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    class Order1 //pedidos
    {
        /* CLASS ENUM = ENUMERAÇÔES
        
            CheckList:
                *   Definição / discusão;
                *   Exemplo: estado de um pedido;
                *   Conversão de string para enum;
                *   Representação UML;

            
            ENUMERAÇÔES
                * o que é: É um tipo especial que serve para especificar de forma literal um conjunto de constantes relacionadas;
                
                *   Palavra chave em C#: ENUM
                    - NOTA: enum é um tipo valor;

                *   Vantagem: melhor semântica, Código mais legível e auxiliado pelo compilador;
                
                *   referencia no material de apoio;  
                
                EXEMPLO:
                    ciclo de vida de um pedido.
                                        ocorre pagamento               ocorre o envio             ocorre entrega
               0 => pagamento pendente =================> Processando ================> Enviado =================> Entregue => 0
                Diagrama da UML;
                diagrama de maquina de estados


        =============================================================================================
        ATENÇÂO: CODIGO A SER COLOCADO NO PROGRAM:
        Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            global::System.Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString(); // convert de ENUM para string

            global::System.Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");// convert de string para ENUM

            global::System.Console.WriteLine(os);
         */
        public int Id { get; set; }
        public DateTime Moment { get; set; }

        public OrderStatus Status { get; set; }


        public override string ToString()
        {
            return Id
                + ", "
                + Moment
                + ", "
                + Status;
        }
    }
}
