using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class SamsungBuilder : PhoneBuilder
    {
        public SamsungBuilder()
        {
            // Create a product
            Phone = new Phone();
        }
        public override void SetColor() => Phone.Brand = "Samsung";

        public override void SetName() => Phone.Color = "White";

        public override void SetPrice() => Phone.Price = 1299;

        public override void SetStock() => Phone.Stock = 10000;

    }
}
