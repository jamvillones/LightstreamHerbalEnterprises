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
            if (items.Count() == 0 || items is null)
                return Enumerable.Empty<T>();

            IEnumerable<T> itemRef = items.ToList();

            foreach (var i in filteringConditions)
            {
                itemRef = itemRef.Where(i);

                //if (itemRef.Count() > 0 && flow == FilteringFlow.StopUponSatisfaction)
                //    break;

                //else if (flow == FilteringFlow.LoopAll)
                //    itemRef = items.ToList();

                if (flow == FilteringFlow.StopUponSatisfaction)
                {
                    if (itemRef.Count() > 0)
                        break;

                    if (!i.Equals(filteringConditions.Last()))
                        itemRef = items.ToList();
                }
            }

            return itemRef;
        }

    }
}
