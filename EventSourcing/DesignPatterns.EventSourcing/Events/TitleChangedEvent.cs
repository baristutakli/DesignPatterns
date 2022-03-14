using DesignPatterns.EventSourcing.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.EventSourcing.Events
{
    public class TitleChangedEvent:IEvent
    {
        public Product Product { get; set; }

        private readonly string oldTitle;
        private readonly string newTitle;

        public TitleChangedEvent(Product product, string oldTitle, string newTitle)
        {
            Product = product;
            this.oldTitle = oldTitle;
            this.newTitle = newTitle;
        }
        public override string ToString()
        => $"{newTitle}+----+ {oldTitle}";
    }

}

