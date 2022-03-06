using System;

namespace DesignPatterns.Decorator
{
    //ConcreteDecorator
    class SecurityRepositoryDecorator<T> : DecoratorRepository<T> where T : class
    {
        readonly IRepository<T> _repository;
        public SecurityRepositoryDecorator(IRepository<T> repository) : base(repository)
        {
            _repository = repository;
        }
        public override T Get(int id)
        {
            Console.WriteLine("Security");
            return base.Get(id);
        }

        public override T GetAll()
        {
            Console.WriteLine("Security");
            return base.GetAll();
        }
    }
}
