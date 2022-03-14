using DesignPatterns.EventSourcing.CQRS.Handlers;
using DesignPatterns.EventSourcing.CQRS.Requests;
using DesignPatterns.EventSourcing.CQRS.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.EventSourcing.Events
{
    class EventBroker
    {
        public List<IEvent> allEvents = new();
        public event EventHandler<object> Commands;
        public event EventHandler<object> Queries;
        public EventBroker()
        {
            this.Commands += (sender, command) =>
            {
                if (command is ChangeProductPriceCommandRequest req1)
                {
                    ChangeProductPriceCommandHandler handler = new ChangeProductPriceCommandHandler();
                    ChangeProductPriceCommandResponse response = handler.ChangePrice(req1);
                    this.allEvents.Add(new PriceChangedEvent());
                }
                else if (command is ChangeProductTitleCommandRequest req2)
                {
                    ChangeProductTitleCommandHandler handler = new ChangeProductTitleCommandHandler();
                    ChangeProductTitleCommandResponse response = handler.ChangeTitle(req2);
                    this.allEvents.Add(new TitleChangedEvent( req2.Title));
                }
                else if (command is CreateProductCommandRequest req3)
                {
                    CreateProductCommandHandler handler = new CreateProductCommandHandler();
                    CreateProductCommandResponse response = handler.CreateProduct(req3);
                    this.allEvents.Add(new ProductCreatedEvent(response.Product));
                }
            };
            this.Queries += (sender, query) =>
            {
                if (query is GetProductQueryRequest req1)
                {
                    GetProductQueryHandler handler = new GetProductQueryHandler();
                    GetProductQueryResponse response = handler.GetProduct(req1);
                    Console.WriteLine($"Id\tTitle\tAge");
                    Console.WriteLine($"{response.Product.Id}\t{response.Product.Title}\t{response.Product.Price}\n***********");
                }
                else if (query is GetAllProductQueryRequest req2)
                {
                    GetAllProductQueryHandler handler = new GetAllProductQueryHandler();
                    List<GetAllProductQueryResponse> response = handler.GetAll(req2);
                    Console.WriteLine($"Id\tTitle\tAge");
                    response.ForEach(person => Console.WriteLine($"{person.Id}\t{person.Title}\t{person.Price}"));
                    Console.WriteLine("***********");
                }
            };
        }
        public void Command(object command)
            => Commands(this, command);
        public void Query(object query)
            => Queries(this, query);
        public void WriteAllEvent()
            => allEvents.ForEach(@event => Console.WriteLine($"{@event.ToString()}\n***********"));
    }
}
