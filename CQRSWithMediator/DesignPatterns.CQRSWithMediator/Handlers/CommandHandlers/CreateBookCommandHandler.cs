using DesignPatterns.CQRSWithMediator.Interfaces;
using DesignPatterns.CQRSWithMediator.RequestModels.CommandRequestModels;
using DesignPatterns.CQRSWithMediator.ResponseModels.CommandResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CQRSWithMediator.Handlers.CommandHandlers
{
    public class CreateBookCommandHandler : ICommandHandler<CreateBookRequestModel, CreateBookResponseModel>
    {
        public CreateBookResponseModel Handle(CreateBookRequestModel requestModel)
        {
            /// your business rules
            throw new NotImplementedException();
        }
    }
}
