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
    class GetProductQueryHandler
    {
        public GetProductQueryResponse GetProduct(GetProductQueryRequest request)
        {
            Product product = DataGenerator.Products.FirstOrDefault(p => p.Id == request.Id);
            return new GetProductQueryResponse
            {
                Product = product
            };
        }
    }
}
