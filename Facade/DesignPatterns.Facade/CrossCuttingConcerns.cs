namespace DesignPatterns.Facade
{
    public class CrossCuttingConcerns :ICrossCuttingConcern
    {
        public ILogger Logger { get; private set; }

        public ICache Cacher { get; private set; }

        public IAuthorize Authorizer { get; private set; }
    }
}
