using System;
using System.Windows.Forms;
using TVshowTracker.Classes;

namespace TVshowTracker
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            LoadInformation();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoadInformation()
        {
            var obj = TVshowManager.TVshows[TVshowManager.SelectedShow];
            InfoName.Text = obj.TVname;
            InfoTags.Text = obj.Tags;
            InfoRelease.Text = obj.ReleaseDate;
            InfoEnding.Text = obj.EndingDate;
            InfoSeasons.Text = obj.Seasons.Count.ToString();
            InfoEpisodes.Text = obj.NumberOfEpisodes().ToString();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var Show = TVshowManager.SelectedShow;
            TVshowManager.TVshows[Show].TVname = InfoName.Text;
            TVshowManager.TVshows[Show].Tags = InfoTags.Text;
            TVshowManager.TVshows[Show].ReleaseDate = InfoRelease.Text;
            TVshowManager.TVshows[Show].EndingDate = InfoEnding.Text;

            MainForm.RewriteFile(Show);
        }
    }
}
