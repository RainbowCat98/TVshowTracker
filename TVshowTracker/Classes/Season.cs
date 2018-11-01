using System.Collections.Generic;

namespace TVshowTracker
{
    /// <summary>
    /// Contains information about TV shows season
    /// </summary>
    class Season
    {
        /// <summary>
        /// Holds seasons name. Used for indentification.
        /// </summary>
        public string SeasonName { get; set; }

        /// <summary>
        /// Holds all episodes of the season
        /// </summary>
        public List<Episode> Episodes { get; set; } = new List<Episode>();

        public Season(string seasonName, Episode episode)
        {
            SeasonName = seasonName;
            Episodes.Add(episode);
        }
    }
}
