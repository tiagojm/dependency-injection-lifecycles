using di_services_lifetime.Interface;

namespace di_services_lifetime.Services
{
    public class ScopedService : IService
    {
        private static int _accessCount;

        public int AccessCount => _accessCount;

        public ScopedService() 
        {
            _accessCount++;
        }

        public override string ToString()
        {
            return $"{nameof(ScopedService)}";
        }

        public int GetAccessCount()
        {
            return _accessCount;
        }
    }
}
