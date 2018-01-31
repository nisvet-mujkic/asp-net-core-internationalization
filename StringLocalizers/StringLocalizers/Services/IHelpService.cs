using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StringLocalizers.Services
{
    public interface IHelpService
    {
        string GetHelpFor(string serviceName);
    }
}
