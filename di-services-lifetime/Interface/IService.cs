namespace di_services_lifetime.Interface
{
    public interface IService
    {
        int AccessCount { get; }
        int GetAccessCount();
    }
}
