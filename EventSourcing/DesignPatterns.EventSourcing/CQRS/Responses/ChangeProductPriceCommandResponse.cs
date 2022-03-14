using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.EventSourcing.CQRS.Responses
{
   public class ChangeProductPriceCommandResponse
    {
        public bool Success { get; set; } = true;
    }
}
