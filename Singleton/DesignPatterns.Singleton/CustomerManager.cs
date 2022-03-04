using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class CustomerManager
    {
        private static CustomerManager _customerManager;
        // to gurantee that objcet ccreated only once 
        static object _lockObject = new object();
        private CustomerManager()
        {

        }
        // That help us to decrease the load on the memory by avoiding unnecessary object creations
        public static CustomerManager CreateAsSingleton()
        {
            lock (_lockObject)
            {
                if (_customerManager ==null)
                {
                    _customerManager = new CustomerManager();
                }
            }
            return _customerManager;
        }
        public void Save()
        {

        }
    }
}
