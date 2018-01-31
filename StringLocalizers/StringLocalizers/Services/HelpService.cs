using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StringLocalizers.Services
{
    public class HelpService : IHelpService
    {
        private readonly IStringLocalizer<AboutService> _aboutLocalizer;

        public HelpService(IStringLocalizer<AboutService> localizer)
        {
            this._aboutLocalizer = localizer;
        }

        public string GetHelpFor(string serviceName)
        {
            throw new NotImplementedException();
        }
    }
}
