using Dependency_Injection_3_Main_Methods_WebApi.Interfaces;

namespace Dependency_Injection_3_Main_Methods_WebApi.Classes
{
    public class RequestSingletonService : IRequestSingletonService
    {
        public Guid IRequestSingletonServiceId { get; }
        public RequestSingletonService()
        {
            IRequestSingletonServiceId = Guid.NewGuid();
        }
    }
}
