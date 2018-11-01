using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            
        }

        private void CancelButon_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
