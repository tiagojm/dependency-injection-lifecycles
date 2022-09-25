using di_services_lifetime.Interface;

namespace di_services_lifetime.Services
{
    public class Logging : ISystemLogging
    {
        private string lastLogDescrption;

        public Logging() 
        {
            this.lastLogDescrption = "None resource has been accessed yet";
        }

        public string GetLog()
        {
            return this.lastLogDescrption;
        }

        public void SaveLastLog(string logDescription)
        {
            this.lastLogDescrption = logDescription;
        }

        public void Log(Action action)
        {
            action.Invoke();
        }
    }
}
