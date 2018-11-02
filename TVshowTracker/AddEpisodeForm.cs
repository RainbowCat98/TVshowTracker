using System;
using System.IO;
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

            using (var add = File.AppendText(TVshowManager.TVshows[TVshowManager.SelectedShow].FilePath))
            {
                add.WriteLine("{0};{1};{2};", TVshowManager.SelectedSeason + 1,EpisodesNameBox.Text,WatchedBox.Checked); // Adds episode to the ending of the file
            }
            
            Close();
        }

        private void CancelButon_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
