using DesignPatterns.CQRSWithMediator.RequestModels.CommandRequestModels;
using DesignPatterns.CQRSWithMediator.ResponseModels.CommandResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CQRSWithMediator.Interfaces
{
    public interface ICommandHandler<TRequest, TResponse>
        where TRequest : class
        where TResponse : class
    {
        CreateBookResponseModel Handle(CreateBookRequestModel requestModel);
    }
}
