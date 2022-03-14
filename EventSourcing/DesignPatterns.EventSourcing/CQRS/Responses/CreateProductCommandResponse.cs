using DesignPatterns.EventSourcing.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.EventSourcing.CQRS.Responses
{
    public class CreateProductCommandResponse
    {
        public Product Product { get; set; }
    }
}
