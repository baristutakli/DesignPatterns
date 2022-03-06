using DesignPatterns.CQRSWithMediator.Interfaces;
using DesignPatterns.CQRSWithMediator.ResponseModels.QueryResponseModels;

namespace DesignPatterns.CQRSWithMediator.RequestModels.QueryRequestModels
{
    public class GetBookRequestModel : IRequest<GetBookResponseModel>
    {
        public int? Id { get; set; }
    }
}
