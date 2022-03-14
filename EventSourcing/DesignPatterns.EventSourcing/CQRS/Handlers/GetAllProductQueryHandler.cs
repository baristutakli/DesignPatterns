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
    class GetAllProductQueryHandler
    {
        public List<GetAllProductQueryResponse> GetAll(GetAllProductQueryRequest request)
        {
            return DataGenerator.Products.Select(product => new GetAllProductQueryResponse
            {
                Id = product.Id,
                Title = product.Title,
                Price = product.Price
            }).ToList();
        }
    }
}
