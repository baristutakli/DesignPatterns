namespace DesignPatterns.Facade
{
    public class CustomerManager
    {
        private ICrossCuttingConcern _crossCuttingConcern;

        public CustomerManager(ICrossCuttingConcern crossCuttingConcern)
        {
            _crossCuttingConcern = crossCuttingConcern;
        }

        public void Save()
        {
            _crossCuttingConcern.Cacher.Cache();
            _crossCuttingConcern.Authorizer.CheckUser();
            _crossCuttingConcern.Logger.Log();
        }
    }
}
