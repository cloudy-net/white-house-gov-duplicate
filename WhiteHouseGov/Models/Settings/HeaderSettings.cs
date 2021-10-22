using Cloudy.CMS.ContentTypeSupport;
using Cloudy.CMS.SingletonSupport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhiteHouseGov.Models.Settings
{
    [Singleton(23657)]
    [ContentType("9bde2611-f79c-4ed1-8d77-2a7f5e44fb09")]
    public class HeaderSettings : SettingsContainer
    {
        public IEnumerable<string> PageLinks { get; set; }
    }
}
