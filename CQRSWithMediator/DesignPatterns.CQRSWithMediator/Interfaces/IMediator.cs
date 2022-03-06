using DesignPatterns.CQRSWithMediator.RequestModels.CommandRequestModels;
using DesignPatterns.CQRSWithMediator.RequestModels.QueryRequestModels;
using DesignPatterns.CQRSWithMediator.ResponseModels.CommandResponseModels;
using DesignPatterns.CQRSWithMediator.ResponseModels.QueryResponseModels;

namespace DesignPatterns.CQRSWithMediator.Interfaces
{
    public interface IMediator
    {
        public GetBookResponseModel Handle(GetBookRequestModel requestModel);
        public CreateBookResponseModel Handle(CreateBookRequestModel requestModel);

    }
}
