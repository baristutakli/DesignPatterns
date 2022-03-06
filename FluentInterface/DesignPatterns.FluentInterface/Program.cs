using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DesignPatterns.FluentInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                Validator validator = new Validator();
                validator.ValidateAndThrow();
            }
            catch(AggregateException ex)
            {
                Console.WriteLine(ex.Message.ToString().Replace("(","").Replace(")", "\n"));
            }
        }
    }
}


