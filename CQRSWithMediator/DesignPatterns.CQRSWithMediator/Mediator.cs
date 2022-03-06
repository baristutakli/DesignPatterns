using DesignPatterns.CQRSWithMediator.Interfaces;
using DesignPatterns.CQRSWithMediator.RequestModels.CommandRequestModels;
using DesignPatterns.CQRSWithMediator.RequestModels.QueryRequestModels;
using DesignPatterns.CQRSWithMediator.ResponseModels.CommandResponseModels;
using DesignPatterns.CQRSWithMediator.ResponseModels.QueryResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CQRSWithMediator
{
    public class Mediator : IMediator
    {
        private ICommandHandler<CreateBookRequestModel, CreateBookResponseModel> _commandHandler { get; set; }

        private IQueryHandler<GetBookRequestModel, GetBookResponseModel> _queryHandler { get;  set; }

        public Mediator(ICommandHandler<CreateBookRequestModel, CreateBookResponseModel> commandHandler, IQueryHandler<GetBookRequestModel, GetBookResponseModel> queryHandler)
        {
            _commandHandler = commandHandler;
            _queryHandler = queryHandler;
        }
        public GetBookResponseModel Handle(GetBookRequestModel requestModel)
        {
            return _queryHandler.Handle(requestModel);
        }
        public CreateBookResponseModel Handle(CreateBookRequestModel requestModel)
        {
            return _commandHandler.Handle(requestModel);
        }
    }

}