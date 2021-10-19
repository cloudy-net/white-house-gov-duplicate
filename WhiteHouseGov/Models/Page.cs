using Cloudy.CMS.ContentSupport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScholarlySummaries.Models
{
    public abstract class Page : IRoutable, INameable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UrlSegment { get; set; }
    }
}
