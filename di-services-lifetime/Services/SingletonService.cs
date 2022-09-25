
using di_services_lifetime.Interface;

namespace di_services_lifetime.Services
{
    public class SingletonService : IService
    {
        private static int _accessCount;

        public int AccessCount => _accessCount;

        public SingletonService() 
        {
            _accessCount++;
        }

        public override string ToString()
        {
            return $"{nameof(SingletonService)}";
        }

        public int GetAccessCount()
        {
            return _accessCount;
        }
    }
}
