using DesignPatterns.CQRSWithMediator.RequestModels.CommandRequestModels;
using DesignPatterns.CQRSWithMediator.ResponseModels.CommandResponseModels;

namespace DesignPatterns.CQRSWithMediator.Interfaces
{
    public interface ICommandHandler<TRequest, TResponse>
        where TRequest : class
        where TResponse : class
    {
        CreateBookResponseModel Handle(CreateBookRequestModel requestModel);
    }
}
