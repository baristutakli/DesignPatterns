using DesignPatterns.CQRSWithMediator.Interfaces;
using DesignPatterns.CQRSWithMediator.ResponseModels.QueryResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CQRSWithMediator.RequestModels.QueryRequestModels
{
    public class GetBookRequestModel : IRequest<GetBookResponseModel>
    {
        public int? Id { get; set; }
    }
}
