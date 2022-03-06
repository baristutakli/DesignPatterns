using DesignPatterns.CQRSWithMediator.Interfaces;
using DesignPatterns.CQRSWithMediator.ResponseModels.CommandResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CQRSWithMediator.RequestModels.CommandRequestModels
{
    public class CreateBookRequestModel: IRequest<CreateBookResponseModel>
    {
        public string Title { get; set; }
    }
}
