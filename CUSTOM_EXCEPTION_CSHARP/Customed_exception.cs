using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUSTOM_EXCEPTION_CSHARP
{
    class Customed_exception:Exception
    {
        public override string Message => $"{DateTime.Now.ToString()} - Internal Exception at execuation";
    }
}
