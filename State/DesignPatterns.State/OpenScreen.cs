using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class OpenScreen:State
    {
        public override void Handle(Context context)
        {
            context.State = new CloseScreen();
        }
    }
}
