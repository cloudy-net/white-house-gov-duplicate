using Cloudy.CMS.ContentTypeSupport;
using Cloudy.CMS.UI.FormSupport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhiteHouseGov.Models.Blocks
{
    [ContentType("9a155050-3f53-41e7-ae07-6a3b9ccc9669")]
    public class HeroBlock : IStartPageBlock
    {
        public string Heading { get; set; }
        public string Link { get; set; }
    }
}
