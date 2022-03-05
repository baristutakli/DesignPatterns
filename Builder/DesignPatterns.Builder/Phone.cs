using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class Phone
    {
        public string Brand { get; set; }
        public string Color { get; set; }
        public short Stock { get; set; }
        public double Price { get; set; }
        public override string ToString()
        {
            return $"Phone Details:\nName: {Brand}\nColor: {Color}\nStock{Stock}\nPrice: {Price}";
        }
    }
}
