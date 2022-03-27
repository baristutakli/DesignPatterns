using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadiatorPattern.FirstExample
{
    public class EkranKarti : Birim
    {
        public EkranKarti(IAnakart anakart) : base(anakart)
        {
        }
        public void GorselVer(string videoData)
        {
            string[] datas = videoData.Split(",");
            foreach (string data in datas)
                Console.WriteLine($"Gelen görüntü : {data}");
        }
    }
}
