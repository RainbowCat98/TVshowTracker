namespace TVshowTracker
{
    /// <summary>
    /// Contains information about TV shows episode
    /// </summary>
    class Episode
    {
        /// <summary>
        /// Episodes name
        /// </summary>
        public string EpisodeName { get; set; }

        /// <summary>
        /// Tells if the show was watched
        /// </summary>
        public bool IsWatched { get; set; }

        public Episode(string episodeName, bool watched)
        {
            EpisodeName = episodeName;
            IsWatched = watched;

        }
    }
}
