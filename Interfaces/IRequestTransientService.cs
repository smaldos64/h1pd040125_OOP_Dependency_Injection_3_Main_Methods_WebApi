using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_Injection_3_Main_Methods_WebApi.Interfaces
{
    public interface IRequestTransientService
    {
        Guid IRequestTransientServiceId { get; }
    }
}
