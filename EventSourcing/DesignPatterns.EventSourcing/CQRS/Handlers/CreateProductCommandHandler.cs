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
    public class CreateProductCommandHandler
    {
        public CreateProductCommandResponse ChangeName(CreateProductCommandRequest request)
        {
            DataGenerator.Products.Add(new Product( request.Title, request.Price));
            return new CreateProductCommandResponse
            {
                Product = DataGenerator.Products.Last()
            };
        }
    }
}
