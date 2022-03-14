using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.EventSourcing.Entities
{
    public class Product
    {
        public int Id { get;  }
        public string Title { get;private set; }
        public double Price { get;private set; }
        public Product( string title, double price)
        {
            DataGenerator.Count += 1;
            Id  += DataGenerator.Count +1;
            Title = title;
            Price = price;
        }

        public void SetTitle(string title) => Title = title;
        public void setPrice(double price) => Price = price;
    }
}
