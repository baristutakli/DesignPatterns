using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
   public class Repository<T> : IRepository<T> where T : class
    {
        public T Get(int id)
        {
            Console.WriteLine("A specific t");
            return null;
        }
        public T GetAll()
        {
            Console.WriteLine("List of T");
            return null;
        }
        public void Add(T model)
        {
            Console.WriteLine("Added");
        }
        public void Delete(T model)
        {
            Console.WriteLine("Deleted");
        }
        public void Update(T model)
        {
            Console.WriteLine("Updated");
        }
    }
}
