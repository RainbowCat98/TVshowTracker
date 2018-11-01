using System.Collections.Generic;
using System.Linq;

namespace TVshowTracker.Classes
{
    static class TVshowManager
    {
        public static List<TVShow> TVshows { get; set; } = new List<TVShow>();
        public static void SortShows()
        {
            TVshows = TVshows.OrderBy(x => x.TVname).ToList();
        }
    }
}
