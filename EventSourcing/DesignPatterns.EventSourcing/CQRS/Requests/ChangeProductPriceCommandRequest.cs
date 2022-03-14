using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.EventSourcing.CQRS.Requests
{
    public class ChangeProductPriceCommandRequest
    {
        public int Id { get; set; }
        public double Price { get; set; }
    }
}
