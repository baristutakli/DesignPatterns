using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CQRSWithMediator.ResponseModels.QueryResponseModels
{
    public class GetBookResponseModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
