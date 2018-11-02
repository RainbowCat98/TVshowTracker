using System;
using System.Windows.Forms;
using TVshowTracker.Classes;

namespace TVshowTracker
{
    public partial class AddEpisodeForm : Form
    {
        public AddEpisodeForm()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void AddButon_Click(object sender, EventArgs e)
        {
            TVshowManager.TVshows[TVshowManager.SelectedShow].Seasons[TVshowManager.SelectedSeason].Episodes.Add(new Episode(EpisodesNameBox.Text,WatchedBox.Checked));
            Close();
        }

        private void CancelButon_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
