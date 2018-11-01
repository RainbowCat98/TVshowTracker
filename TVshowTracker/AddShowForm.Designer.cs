namespace TVshowTracker
{
    partial class AddShowForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ShowName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ShowTags = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ReleaseDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EndingDate = new System.Windows.Forms.TextBox();
            this.CancelButon = new System.Windows.Forms.Button();
            this.AddButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shows name";
            // 
            // ShowName
            // 
            this.ShowName.Location = new System.Drawing.Point(87, 54);
            this.ShowName.Name = "ShowName";
            this.ShowName.Size = new System.Drawing.Size(381, 20);
            this.ShowName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tags";
            // 
            // ShowTags
            // 
            this.ShowTags.Location = new System.Drawing.Point(87, 80);
            this.ShowTags.Name = "ShowTags";
            this.ShowTags.Size = new System.Drawing.Size(381, 20);
            this.ShowTags.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Release date";
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.Location = new System.Drawing.Point(87, 106);
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.Size = new System.Drawing.Size(100, 20);
            this.ReleaseDate.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ending date";
            // 
            // EndingDate
            // 
            this.EndingDate.Location = new System.Drawing.Point(87, 132);
            this.EndingDate.Name = "EndingDate";
            this.EndingDate.Size = new System.Drawing.Size(100, 20);
            this.EndingDate.TabIndex = 7;
            // 
            // CancelButon
            // 
            this.CancelButon.Location = new System.Drawing.Point(392, 192);
            this.CancelButon.Name = "CancelButon";
            this.CancelButon.Size = new System.Drawing.Size(75, 23);
            this.CancelButon.TabIndex = 8;
            this.CancelButon.Text = "Cancel";
            this.CancelButon.UseVisualStyleBackColor = true;
            this.CancelButon.Click += new System.EventHandler(this.CancelButon_Click);
            // 
            // AddButon
            // 
            this.AddButon.Location = new System.Drawing.Point(311, 191);
            this.AddButon.Name = "AddButon";
            this.AddButon.Size = new System.Drawing.Size(75, 23);
            this.AddButon.TabIndex = 9;
            this.AddButon.Text = "Add";
            this.AddButon.UseVisualStyleBackColor = true;
            this.AddButon.Click += new System.EventHandler(this.AddButon_Click);
            // 
            // AddShowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 227);
            this.Controls.Add(this.AddButon);
            this.Controls.Add(this.CancelButon);
            this.Controls.Add(this.EndingDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ReleaseDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ShowTags);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ShowName);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddShowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Show";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ShowName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ShowTags;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ReleaseDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EndingDate;
        private System.Windows.Forms.Button CancelButon;
        private System.Windows.Forms.Button AddButon;
    }
}