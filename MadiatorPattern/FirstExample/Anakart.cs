using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadiatorPattern.FirstExample
{
    public class Anakart : IAnakart
    {
        CDDriver _cdDriver;
        CPU _cpu;
        EkranKarti _ekranKarti;
        SesKarti _sesKarti;

        public CDDriver CDDriver { set => _cdDriver = value; }
        public CPU CPU { set => _cpu = value; }
        public EkranKarti EkranKarti { set => _ekranKarti = value; }
        public SesKarti SesKarti { set => _sesKarti = value; }

        public void Degistir(Birim birim)
        {
            if (birim is CDDriver)
            {
                string cdData = _cdDriver.CDData;
                _cpu.DataIsle(cdData);
            }
            else if (birim is CPU)
            {
                string videoData = _cpu.VideoData, sesData = _cpu.SesData;
                _ekranKarti.GorselVer(videoData);
                _sesKarti.SesVer(sesData);
            }
        }
    }
}
