using di_services_lifetime.Interface;

namespace di_services_lifetime.Services
{
    public class TransientService : IServiceAccess
    {
        private static int _accessCount;

        public int AccessCount => _accessCount;

        public TransientService() { }

        public override string ToString()
        {
            return $"{nameof(TransientService)}";
        }

        public int GetAccessCount()
        {
            return _accessCount;
        }

        public void RegisterAccess()
        {
            _accessCount++;
        }
    }
}
