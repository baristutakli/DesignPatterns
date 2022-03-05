using System.Threading;

namespace DesignPatterns.Proxy
{
    public class CreditManager : CreditBase
    {
        public override int Calculate()
        {
            int result = 0;
            for (int i = 0; i <20; i++)
            {
                result += i;
                Thread.Sleep(1000);
            }
            return result;
        }
    }
}
