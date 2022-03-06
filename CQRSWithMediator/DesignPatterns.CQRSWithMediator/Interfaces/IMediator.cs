using DesignPatterns.CQRSWithMediator.RequestModels.CommandRequestModels;
using DesignPatterns.CQRSWithMediator.RequestModels.QueryRequestModels;
using DesignPatterns.CQRSWithMediator.ResponseModels.CommandResponseModels;
using DesignPatterns.CQRSWithMediator.ResponseModels.QueryResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CQRSWithMediator.Interfaces
{
   public interface IMediator
    {
        public GetBookResponseModel Handle(GetBookRequestModel requestModel);
        public CreateBookResponseModel Handle(CreateBookRequestModel requestModel);
        
    }
}
