using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    /// <summary>
    /// Director
    /// </summary>
    public class PhoneManager
    {
        public void Create(PhoneBuilder phone)
        {
            phone.SetColor();
            phone.SetName();
            phone.SetPrice();
            phone.SetStock();
        }
    }
}
