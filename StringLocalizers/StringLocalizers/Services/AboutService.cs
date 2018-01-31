using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StringLocalizers.Services
{
    public class AboutService : IAboutService
    {
        private IStringLocalizer _localizer;
        public AboutService(IStringLocalizer<AboutService> localizer)
        {
            _localizer = localizer;
        }
        public string Reply(string searchTerm)
        {
            LocalizedString resource = _localizer[searchTerm];
            if (resource.ResourceNotFound)
                return _localizer["help"];
            return resource;
        } 
    }
}
