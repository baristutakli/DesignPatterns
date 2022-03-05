using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class CasperBuilder : PhoneBuilder
    {
        public CasperBuilder()
        {
            // Create a product
            Phone = new Phone();
        }
        public override void SetColor() => Phone.Brand = "Casper";

        public override void SetName() => Phone.Color = "Red";

        public override void SetPrice() => Phone.Price = 120;

        public override void SetStock() => Phone.Stock = 2000;

    }
}
