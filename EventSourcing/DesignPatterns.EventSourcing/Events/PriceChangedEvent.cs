using DesignPatterns.EventSourcing.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.EventSourcing.Events
{
    public class PriceChangedEvent:IEvent
    {
        public Product Product { get; set; }

        public double oldPrice;
        public double newPrice;

        public PriceChangedEvent(Product product, double oldPrice, double newPrice)
        {
            Product = product;
            this.oldPrice = oldPrice;
            this.newPrice = newPrice;
        }
        public override string ToString()
        => $"{newPrice}+----+ {oldPrice}";
    }

}

