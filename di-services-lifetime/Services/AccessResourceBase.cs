using di_services_lifetime.Interface;

namespace di_services_lifetime.Services
{
    public abstract class AccessResourceBase : IResource
    {
        private readonly IService _singletonNetworkAccess;
        private readonly IService _scopedApiAccess;
        private readonly IServiceAccess _transientResourceAccess;
        private readonly ISystemLogging _logger;

        public AccessResourceBase(SingletonService networkAccess, ScopedService apiAccess, TransientService resourceAccess, ISystemLogging logger)
        {
            _singletonNetworkAccess = networkAccess;
            _scopedApiAccess = apiAccess;
            _transientResourceAccess = resourceAccess;
            _logger = logger;
        }

        public virtual void DoAnything()
        {
            //Do Anything

            //Logging
            this.Log();
        }

        protected void Log()
        {
            this._logger.Log(() => _transientResourceAccess.RegisterAccess());
            this._logger.SaveLastLog($"Network Access Count: {_singletonNetworkAccess.GetAccessCount()} - Requests Count: {_scopedApiAccess.GetAccessCount()} - Resource Access Count: {_transientResourceAccess.GetAccessCount()}");
        }
    }
}
