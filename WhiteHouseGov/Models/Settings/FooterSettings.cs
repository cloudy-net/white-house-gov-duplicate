using Cloudy.CMS.ContentTypeSupport;
using Cloudy.CMS.SingletonSupport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhiteHouseGov.Models.Settings
{
    [Singleton]
    [ContentType("a810f653-f2ed-4290-b93d-c3e1c813576b")]
    public class FooterSettings : SettingsContainer
    {
        public IEnumerable<string> MainLinks { get; set; }
        public IEnumerable<string> SecondaryLinks { get; set; }
    }
}
