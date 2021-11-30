using Cloudy.CMS.ContentTypeSupport;
using Cloudy.CMS.UI.FormSupport;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WhiteHouseGov.Models.Blocks
{
    [ContentType("0730530d-ae62-4212-bbc2-cd649ba7571a")]
    public class TeaserBlock : IStartPageBlock
    {
        public string Heading { get; set; }
        [UIHint("html")]
        public string Body { get; set; }
    }
}
