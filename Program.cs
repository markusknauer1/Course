using System.Globalization;
using System.Net.Http.Headers;
using System.Xml.Linq;
using System.Collections.Generic;
using Course.Entities.Enums;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}