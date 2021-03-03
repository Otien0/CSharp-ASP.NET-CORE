using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Services
{
    public class MuchImprovedSiteVisitorsCounter : ISiteVisitorsCounter
    {
        public int Counter { get; set; }

        public int GetCounter()
        {
            Counter++;
            return (Counter);
        }
    }
}
