using DesignPatterns.CQRSWithMediator.RequestModels.QueryRequestModels;
using DesignPatterns.CQRSWithMediator.ResponseModels.QueryResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CQRSWithMediator.Interfaces
{
    public interface IQueryHandler<TRequest, TResponse>
        where TRequest :class
        where TResponse:class
    {
        GetBookResponseModel Handle(GetBookRequestModel requestModel);
    }
}
