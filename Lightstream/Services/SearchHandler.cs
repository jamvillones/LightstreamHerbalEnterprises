using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightstream.Services
{
    public enum FilteringFlow { StopUponSatisfaction, LoopAll }
    public static class SearchHandler
    {
        /// <summary>
        /// handles filtering by supplied conditions`
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <param name="flow"></param>
        /// <param name="filteringConditions"></param>
        /// <returns></returns>
        public static IEnumerable<T> FilterList<T>(IEnumerable<T> items, FilteringFlow flow = FilteringFlow.StopUponSatisfaction, params Func<T, bool>[] filteringConditions) where T : class
        {
            IEnumerable<T> itemRef = items.ToList();
            foreach (var i in filteringConditions)
            {
                itemRef = itemRef.Where(i);

                if (itemRef.Count() > 0 && flow == FilteringFlow.StopUponSatisfaction)
                    break;
            }
            return itemRef;
        }

    }
}
