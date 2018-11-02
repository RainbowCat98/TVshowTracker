namespace TVshowTracker
{
    partial class AddEpisodeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEpisodeForm));
            this.AddButon = new System.Windows.Forms.Button();
            this.CancelButon = new System.Windows.Forms.Button();
            this.EpisodesNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WatchedBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // AddButon
            // 
            this.AddButon.Location = new System.Drawing.Point(319, 83);
            this.AddButon.Name = "AddButon";
            this.AddButon.Size = new System.Drawing.Size(75, 23);
            this.AddButon.TabIndex = 19;
            this.AddButon.Text = "Add";
            this.AddButon.UseVisualStyleBackColor = true;
            this.AddButon.Click += new System.EventHandler(this.AddButon_Click);
            // 
            // CancelButon
            // 
            this.CancelButon.Location = new System.Drawing.Point(400, 83);
            this.CancelButon.Name = "CancelButon";
            this.CancelButon.Size = new System.Drawing.Size(75, 23);
            this.CancelButon.TabIndex = 18;
            this.CancelButon.Text = "Cancel";
            this.CancelButon.UseVisualStyleBackColor = true;
            this.CancelButon.Click += new System.EventHandler(this.CancelButon_Click);
            // 
            // EpisodesNameBox
            // 
            this.EpisodesNameBox.Location = new System.Drawing.Point(94, 35);
            this.EpisodesNameBox.Name = "EpisodesNameBox";
            this.EpisodesNameBox.Size = new System.Drawing.Size(381, 20);
            this.EpisodesNameBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Episodes name";
            // 
            // WatchedBox
            // 
            this.WatchedBox.AutoSize = true;
            this.WatchedBox.Location = new System.Drawing.Point(94, 62);
            this.WatchedBox.Name = "WatchedBox";
            this.WatchedBox.Size = new System.Drawing.Size(70, 17);
            this.WatchedBox.TabIndex = 20;
            this.WatchedBox.Text = "Watched";
            this.WatchedBox.UseVisualStyleBackColor = true;
            // 
            // AddEpisodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 118);
            this.Controls.Add(this.WatchedBox);
            this.Controls.Add(this.AddButon);
            this.Controls.Add(this.CancelButon);
            this.Controls.Add(this.EpisodesNameBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEpisodeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Episode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButon;
        private System.Windows.Forms.Button CancelButon;
        private System.Windows.Forms.TextBox EpisodesNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox WatchedBox;
    }
}