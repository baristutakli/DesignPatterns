namespace DesignPatterns.Decorator
{
    public interface IRepository<T> where T : class
    {
        public T Get(int id);
        public T GetAll();
        public void Add(T model);
        public void Delete(T model);
        public void Update(T model);
    }
}