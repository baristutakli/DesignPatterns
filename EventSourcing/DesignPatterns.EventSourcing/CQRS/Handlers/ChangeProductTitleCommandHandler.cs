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
    public class ChangeProductTitleCommandHandler
    {
        public ChangeProductTitleCommandResponse ChangeName(ChangeProductTitleCommandRequest request)
        {
            Product product = DataGenerator.Products.FirstOrDefault(p => p.Id == request.Id);
            product.SetTitle(request.Title);
            return new ChangeProductTitleCommandResponse
            {
               Success = true
            };
        }
    }
}
