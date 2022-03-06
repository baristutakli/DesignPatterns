using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FluentInterface
{
    public abstract class Validate
    {
        private string _testString { get; set; }
        private List<Exception> _exceptions = new List<Exception>();

        public Validate RuleFor(string value)
        {
            _testString = value;
            return this;
        }
        public Validate IsNotNull()
        {
            if (_testString is null) { _exceptions.Add(new Exception($"Value can not be null!")); }
            return this;
        }
        public Validate IsNotEmpty()
        {
            if (_testString == "") { _exceptions.Add(new Exception("Value can not be empty!")); }
            return this;
        }
        public void ValidateAndThrow()
        {
            if (_exceptions.Count > 0)
            {
                throw new AggregateException("Exceptions:\n", _exceptions);
            }
        }

    }
}
