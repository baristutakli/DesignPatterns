using DesignPatterns.CQRSWithMediator.Interfaces;
using DesignPatterns.CQRSWithMediator.RequestModels.CommandRequestModels;
using DesignPatterns.CQRSWithMediator.RequestModels.QueryRequestModels;
using System;

namespace DesignPatterns.CQRSWithMediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Add dependecies using IOC 
            IMediator mediator = new Mediator();

            GetBookRequestModel requestModel = new();
            var GetBookResponseModel = mediator.Handle(requestModel);

            CreateBookRequestModel CreateBookrequestModel = new();
            var CreateBookResponseModel = mediator.Handle(CreateBookrequestModel);
        }
    }
}
