using DesignPatterns.CQRSWithMediator.Interfaces;
using DesignPatterns.CQRSWithMediator.ResponseModels.CommandResponseModels;

namespace DesignPatterns.CQRSWithMediator.RequestModels.CommandRequestModels
{
    public class CreateBookRequestModel : IRequest<CreateBookResponseModel>
    {
        public string Title { get; set; }
    }
}
