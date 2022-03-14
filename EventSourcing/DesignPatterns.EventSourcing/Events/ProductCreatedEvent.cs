using DesignPatterns.EventSourcing.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.EventSourcing.Events
{
    public class ProductCreatedEvent:IEvent
    {
        public Product Product { get; set; }



        public ProductCreatedEvent(Product product)
        {
            Product = product;
  
        }
        public override string ToString()
        => "Product created";
    }

}

