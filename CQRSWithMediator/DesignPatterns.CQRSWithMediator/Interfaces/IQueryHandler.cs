using DesignPatterns.CQRSWithMediator.RequestModels.QueryRequestModels;
using DesignPatterns.CQRSWithMediator.ResponseModels.QueryResponseModels;

namespace DesignPatterns.CQRSWithMediator.Interfaces
{
    public interface IQueryHandler<TRequest, TResponse>
        where TRequest : class
        where TResponse : class
    {
        GetBookResponseModel Handle(GetBookRequestModel requestModel);
    }
}
