namespace TVshowTracker
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TVShowBox = new System.Windows.Forms.ListBox();
            this.EpisodeBox = new System.Windows.Forms.ListBox();
            this.AddShow = new System.Windows.Forms.Button();
            this.RemoveShow = new System.Windows.Forms.Button();
            this.AddEpisode = new System.Windows.Forms.Button();
            this.RemoveEpisode = new System.Windows.Forms.Button();
            this.ShowINFO = new System.Windows.Forms.Button();
            this.MarkedAsWatched = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TVShowBox
            // 
            this.TVShowBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TVShowBox.BackColor = System.Drawing.Color.Black;
            this.TVShowBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TVShowBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.TVShowBox.ForeColor = System.Drawing.SystemColors.Window;
            this.TVShowBox.FormattingEnabled = true;
            this.TVShowBox.ItemHeight = 23;
            this.TVShowBox.Location = new System.Drawing.Point(12, 12);
            this.TVShowBox.Name = "TVShowBox";
            this.TVShowBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TVShowBox.Size = new System.Drawing.Size(401, 391);
            this.TVShowBox.TabIndex = 0;
            this.TVShowBox.SelectedIndexChanged += new System.EventHandler(this.TVshows_SelectedIndexChanged);
            // 
            // EpisodeBox
            // 
            this.EpisodeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EpisodeBox.BackColor = System.Drawing.Color.Black;
            this.EpisodeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EpisodeBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.EpisodeBox.ForeColor = System.Drawing.SystemColors.Window;
            this.EpisodeBox.FormattingEnabled = true;
            this.EpisodeBox.ItemHeight = 23;
            this.EpisodeBox.Location = new System.Drawing.Point(554, 12);
            this.EpisodeBox.Name = "EpisodeBox";
            this.EpisodeBox.Size = new System.Drawing.Size(401, 391);
            this.EpisodeBox.TabIndex = 1;
            this.EpisodeBox.SelectedIndexChanged += new System.EventHandler(this.EpisodeBox_SelectedIndexChanged);
            // 
            // AddShow
            // 
            this.AddShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddShow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.AddShow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddShow.Location = new System.Drawing.Point(12, 465);
            this.AddShow.Name = "AddShow";
            this.AddShow.Size = new System.Drawing.Size(118, 32);
            this.AddShow.TabIndex = 2;
            this.AddShow.Text = "Add";
            this.AddShow.UseVisualStyleBackColor = false;
            this.AddShow.Click += new System.EventHandler(this.AddShow_Click);
            // 
            // RemoveShow
            // 
            this.RemoveShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveShow.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RemoveShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.RemoveShow.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RemoveShow.Location = new System.Drawing.Point(295, 465);
            this.RemoveShow.Name = "RemoveShow";
            this.RemoveShow.Size = new System.Drawing.Size(118, 32);
            this.RemoveShow.TabIndex = 3;
            this.RemoveShow.Text = "Remove";
            this.RemoveShow.UseVisualStyleBackColor = false;
            this.RemoveShow.Click += new System.EventHandler(this.RemoveShow_Click);
            // 
            // AddEpisode
            // 
            this.AddEpisode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddEpisode.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddEpisode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEpisode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.AddEpisode.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddEpisode.Location = new System.Drawing.Point(554, 465);
            this.AddEpisode.Name = "AddEpisode";
            this.AddEpisode.Size = new System.Drawing.Size(81, 37);
            this.AddEpisode.TabIndex = 4;
            this.AddEpisode.Text = "Add";
            this.AddEpisode.UseVisualStyleBackColor = false;
            this.AddEpisode.Click += new System.EventHandler(this.AddEpisode_Click);
            // 
            // RemoveEpisode
            // 
            this.RemoveEpisode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveEpisode.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RemoveEpisode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveEpisode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.RemoveEpisode.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RemoveEpisode.Location = new System.Drawing.Point(874, 465);
            this.RemoveEpisode.Name = "RemoveEpisode";
            this.RemoveEpisode.Size = new System.Drawing.Size(81, 37);
            this.RemoveEpisode.TabIndex = 5;
            this.RemoveEpisode.Text = "Remove";
            this.RemoveEpisode.UseVisualStyleBackColor = false;
            this.RemoveEpisode.Click += new System.EventHandler(this.RemoveEpisode_Click);
            // 
            // ShowINFO
            // 
            this.ShowINFO.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ShowINFO.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ShowINFO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowINFO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ShowINFO.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ShowINFO.Location = new System.Drawing.Point(149, 465);
            this.ShowINFO.Name = "ShowINFO";
            this.ShowINFO.Size = new System.Drawing.Size(129, 33);
            this.ShowINFO.TabIndex = 6;
            this.ShowINFO.Text = "INFO / EDIT";
            this.ShowINFO.UseVisualStyleBackColor = false;
            this.ShowINFO.Click += new System.EventHandler(this.ShowINFO_Click);
            // 
            // MarkedAsWatched
            // 
            this.MarkedAsWatched.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MarkedAsWatched.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MarkedAsWatched.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MarkedAsWatched.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.MarkedAsWatched.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MarkedAsWatched.Location = new System.Drawing.Point(660, 465);
            this.MarkedAsWatched.Name = "MarkedAsWatched";
            this.MarkedAsWatched.Size = new System.Drawing.Size(193, 37);
            this.MarkedAsWatched.TabIndex = 7;
            this.MarkedAsWatched.Text = "Mark as watched";
            this.MarkedAsWatched.UseVisualStyleBackColor = false;
            this.MarkedAsWatched.Click += new System.EventHandler(this.MarkedAsWatched_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.Color.White;
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.SearchBox.Location = new System.Drawing.Point(419, 39);
            this.SearchBox.Multiline = true;
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(129, 30);
            this.SearchBox.TabIndex = 8;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.Location = new System.Drawing.Point(451, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(967, 612);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.MarkedAsWatched);
            this.Controls.Add(this.ShowINFO);
            this.Controls.Add(this.RemoveEpisode);
            this.Controls.Add(this.AddEpisode);
            this.Controls.Add(this.RemoveShow);
            this.Controls.Add(this.AddShow);
            this.Controls.Add(this.EpisodeBox);
            this.Controls.Add(this.TVShowBox);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TV show tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox TVShowBox;
        private System.Windows.Forms.ListBox EpisodeBox;
        private System.Windows.Forms.Button AddShow;
        private System.Windows.Forms.Button RemoveShow;
        private System.Windows.Forms.Button AddEpisode;
        private System.Windows.Forms.Button RemoveEpisode;
        private System.Windows.Forms.Button ShowINFO;
        private System.Windows.Forms.Button MarkedAsWatched;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label label1;
    }
}

