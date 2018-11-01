using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVshowTracker.Classes;

namespace TVshowTracker
{
    public partial class MainForm : Form
    {
        bool IsShowingEpisodes = false;

        public MainForm()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            ShowTVshows(); // loads show names to TVshowBox
        }

        private void ShowTVshows()
        {
            TVshowManager.SortShows(); // Sorts TV show list before writing to listbox
            foreach (var item in TVshowManager.TVshows)
            {
                TVShowBox.Items.Add(string.Format("{0} \n", item.TVname));
            }
        }

        private void ShowSeasons(int ShowIndex)
        {
            if (TVshowManager.TVshows[ShowIndex].Seasons.Count == 0)
            {
                EpisodeBox.Items.Add("No seasons available");
                return;
            }
            TVshowManager.TVshows[ShowIndex].SortSeasons();
            foreach (var item in TVshowManager.TVshows[ShowIndex].Seasons)
            {
                EpisodeBox.Items.Add(string.Format("{0} \n", item.SeasonName));
            }
            IsShowingEpisodes = false;
        }

        private void ShowEpisodes(int EpisodeIndex)
        {
            if (TVshowManager.TVshows[TVShowBox.SelectedIndex].Seasons[EpisodeIndex].Episodes.Count == 0)
            {
                EpisodeBox.Items.Add("No episodes available");
                return;
            }
            EpisodeBox.Items.Clear();
            foreach (var item in TVshowManager.TVshows[TVShowBox.SelectedIndex].Seasons[EpisodeIndex].Episodes)
            {
                EpisodeBox.Items.Add(string.Format("{0} \n", item.EpisodeName));
            }
            IsShowingEpisodes = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void TVshows_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = TVShowBox.SelectedIndex;
            if (index < 0)
            {
                return;
            }
            EpisodeBox.Items.Clear();
            ShowSeasons(index);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newform = new AddShowForm();
            Hide();
            newform.ShowDialog();
            newform.Close();
            
            TVShowBox.Items.Clear(); // Clears listbox to write updated information
            ShowTVshows(); // Writes updates show list
            Show();
        }

        private void AddEpisode_Click(object sender, EventArgs e)
        {
            var newform = new AddEpisodeForm();
            Hide();
            newform.ShowDialog();
            newform.Close();       
            Show();

           
        }

        private void RemoveShow_Click(object sender, EventArgs e)
        {
            if (TVShowBox.SelectedIndex >= 0)
            {
                File.Delete(TVshowManager.TVshows[TVShowBox.SelectedIndex].FilePath); // Deletes show's file in "TV shows" folder
                TVshowManager.TVshows.RemoveAt(TVShowBox.SelectedIndex); // Removes selected item in listbox from TvshowManager
                TVShowBox.Items.Clear(); // Clears listbox
                ShowTVshows(); // Writes updates show list
            }        
        }

        private void MarkedAsWatched_Click(object sender, EventArgs e)
        {

        }

        private void RemoveEpisode_Click(object sender, EventArgs e)
        {

        }

        private void EpisodeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = EpisodeBox.SelectedIndex;
            if (index < 0 || IsShowingEpisodes)
            {
                return;
            }

            ShowEpisodes(index);
          
        }
    }
}
