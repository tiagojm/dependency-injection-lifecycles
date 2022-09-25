namespace di_services_lifetime.Interface
{
    public interface ISystemLogging 
    {
        void SaveLastLog(string logDescription);
        string GetLog();
        void Log(Action action);
    }
}
