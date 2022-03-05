namespace DesignPatterns.Facade
{
    public interface ICrossCuttingConcern
    {
        ILogger Logger { get; }
        ICache Cacher { get; }
        IAuthorize Authorizer { get; }
    }
}
