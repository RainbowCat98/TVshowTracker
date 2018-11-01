using System;
using System.IO;
using System.Windows.Forms;
using TVshowTracker.Classes;

namespace TVshowTracker
{
    public partial class AddShowForm : Form
    {
        public AddShowForm()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void CancelButon_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButon_Click(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory() + @"\TV Shows\";
            string NewFilePath = string.Format("{0}{1}.csv", path, ShowName.Text);
            using (var writeFile = new StreamWriter(NewFilePath))
            {
                writeFile.WriteLine(string.Format("{0};{1};{2};{3};", ShowName.Text, ReleaseDate.Text, EndingDate.Text, ShowTags.Text));
            }

            TVshowManager.TVshows.Add(new TVShow(ShowName.Text, ReleaseDate.Text, EndingDate.Text, ShowTags.Text, NewFilePath)); // Adds new show to the container
            Close();
        }
    }
}
