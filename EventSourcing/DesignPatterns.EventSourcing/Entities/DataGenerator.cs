using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.EventSourcing.Entities
{
   public class DataGenerator
    {
        public static int Count { get; set; } = 3;
        public static List<Product> Products { get; } = new()
        {
            new Product( "Iphone", 10),
            new Product( "Volvo", 100),
            new Product( "Samsung", 20)
        };
    }
}
