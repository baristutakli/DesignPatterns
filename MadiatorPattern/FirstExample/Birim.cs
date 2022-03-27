using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadiatorPattern.FirstExample
{
    public abstract class Birim
    {
        protected IAnakart _anakart;
        public Birim(IAnakart anakart)
        {
            _anakart = anakart;
        }
    }
}
