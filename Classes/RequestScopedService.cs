using Dependency_Injection_3_Main_Methods_WebApi.Interfaces;

namespace Dependency_Injection_3_Main_Methods_WebApi.Classes
{
    public class RequestScopedService : IRequestScopedService
    {
        public Guid IRequestScopedServiceId { get; }
        public RequestScopedService()
        {
            IRequestScopedServiceId = Guid.NewGuid();
        }
    }
}
