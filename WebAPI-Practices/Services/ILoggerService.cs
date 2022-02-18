using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_Practices.Services
{
    public interface ILoggerService
    {
        void Log(string message);
    }
}
