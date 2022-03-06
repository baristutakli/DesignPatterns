using DesignPatterns.CQRSWithMediator.Interfaces;
using DesignPatterns.CQRSWithMediator.RequestModels.QueryRequestModels;
using DesignPatterns.CQRSWithMediator.ResponseModels.QueryResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CQRSWithMediator.Handlers.QueryHandlers
{
    public class GetBookQueryHandler : IQueryHandler<GetBookRequestModel, GetBookResponseModel>
    {
        public GetBookResponseModel Handle(GetBookRequestModel requestModel)
        {
            /// your business rules
            throw new NotImplementedException();
        }
    }
}
