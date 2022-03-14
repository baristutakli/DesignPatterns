using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.EventSourcing.CQRS.Responses
{
    public class GetAllProductQueryResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get;  set; }
    }
}
