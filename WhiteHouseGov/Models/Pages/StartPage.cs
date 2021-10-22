using Cloudy.CMS.ContentTypeSupport;
using Cloudy.CMS.SingletonSupport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhiteHouseGov.Models.Pages
{
    [Singleton(1)]
    [ContentType("4c796987-e198-48fe-9175-4ada770cd298")]
    public class StartPage : Page
    {
        public string HeroHeading { get; set; }
        public string Blocks { get; set; }
    }
}
