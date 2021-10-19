using Cloudy.CMS.ContentTypeSupport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScholarlySummaries.Models.Pages
{
    [ContentType("4c796987-e198-48fe-9175-4ada770cd298")]
    public class StartPage : Page
    {
        public string HeroHeading { get; set; }
        public string Blocks { get; set; }
    }
}
