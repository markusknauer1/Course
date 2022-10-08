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
        Console.WriteLine(order);

        }
    }
}