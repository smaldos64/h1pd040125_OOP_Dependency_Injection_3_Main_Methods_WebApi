using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dependency_Injection_3_Main_Methods_WebApi.Interfaces;

namespace Dependency_Injection_3_Main_Methods_WebApi.Classes
{
    public class RequestTransientService : IRequestTransientService
    {
        public Guid IRequestTransientServiceId { get; }
        public RequestTransientService() 
        {
            IRequestTransientServiceId = Guid.NewGuid();
        }
    }
}
