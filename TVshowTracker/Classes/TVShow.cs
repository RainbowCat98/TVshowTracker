using System;
using System.Collections.Generic;

namespace TVshowTracker
{
    /// <summary>
    /// Contains information of a TV show
    /// </summary>
    class TVShow
    {
        public string FilePath { get; set; }

        /// <summary>
        /// Gives TV shows name
        /// </summary>
        public string TVname { get; set; }

        /// <summary>
        /// Gives TV shows release date
        /// </summary>
        public string ReleaseDate { get; set; }

        /// <summary>
        /// Gives TV shows ending date
        /// </summary>
        public string EndingDate { get; set; }

        /// <summary>
        /// Gives TV Shows tags
        /// </summary>
        public string Tags { get; set; }

        public TVShow(string Name, string releasedate, string endingdate, string tags, string filepath)
        {
            TVname = Name;
            ReleaseDate = releasedate;
            EndingDate = endingdate;
            Tags = tags;
            FilePath = filepath;
        }

        /// <summary>
        /// Contains TV shows seasons with episode information in them
        /// </summary>
        public List<Season> Seasons { get; set; } = new List<Season>();

        public bool ContainsSeason(string seasonsName)
        {
            foreach (var season in Seasons)
            {
                if (season.SeasonName == seasonsName)
                {
                    return true;
                }
            }
            return false;
        }

        public int GetSeasonIndex(string seasonName)
        {
            for (int i = 0; i < Seasons.Count; i++)
            {
                if (Seasons[i].SeasonName == seasonName)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
