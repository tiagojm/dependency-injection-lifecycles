using di_services_lifetime.Interface;

namespace di_services_lifetime.Services
{
    public sealed class AccessResourceB : AccessResourceBase
    {
        public AccessResourceB(SingletonService networkAccess, ScopedService apiAccess, TransientService resourceAccess, ISystemLogging logger) : base(networkAccess, apiAccess, resourceAccess, logger) { }
    }
}
