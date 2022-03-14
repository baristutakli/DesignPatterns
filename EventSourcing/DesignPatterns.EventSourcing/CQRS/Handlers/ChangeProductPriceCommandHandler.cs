using DesignPatterns.EventSourcing.CQRS.Requests;
using DesignPatterns.EventSourcing.CQRS.Responses;
using DesignPatterns.EventSourcing.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.EventSourcing.CQRS.Handlers
{
    public class ChangeProductPriceCommandHandler
    {
        public ChangeProductPriceCommandResponse ChangeName(ChangeProductPriceCommandRequest request)
        {
            Product product = DataGenerator.Products.FirstOrDefault(p => p.Id == request.Id);
            product.SetPrice(request.Price);
            return new ChangeProductPriceCommandResponse
            {
               Success = true
            };
        }
    }
}
