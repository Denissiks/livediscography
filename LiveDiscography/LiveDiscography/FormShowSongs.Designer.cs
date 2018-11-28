namespace LiveDiscography
{
    partial class FormShowSongs
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
            this.lbSearchItem = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lbFieldName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAcceptShow = new System.Windows.Forms.Button();
            this.lblFoundElements = new System.Windows.Forms.Label();
            this.gbSearchType = new System.Windows.Forms.GroupBox();
            this.rbAlbumsByGenre = new System.Windows.Forms.RadioButton();
            this.rbSongsByGenre = new System.Windows.Forms.RadioButton();
            this.rbArtistsByLabel = new System.Windows.Forms.RadioButton();
            this.rbSongsByAlbum = new System.Windows.Forms.RadioButton();
            this.rbAlbumsByArtist = new System.Windows.Forms.RadioButton();
            this.rbSongsByArtist = new System.Windows.Forms.RadioButton();
            this.gbSearchType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSearchItem
            // 
            this.lbSearchItem.FormattingEnabled = true;
            this.lbSearchItem.Location = new System.Drawing.Point(12, 214);
            this.lbSearchItem.Name = "lbSearchItem";
            this.lbSearchItem.Size = new System.Drawing.Size(424, 303);
            this.lbSearchItem.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 127);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(424, 20);
            this.txtSearch.TabIndex = 1;
            // 
            // lbFieldName
            // 
            this.lbFieldName.AutoSize = true;
            this.lbFieldName.Location = new System.Drawing.Point(12, 111);
            this.lbFieldName.Name = "lbFieldName";
            this.lbFieldName.Size = new System.Drawing.Size(103, 13);
            this.lbFieldName.TabIndex = 2;
            this.lbFieldName.Text = "Select a search filter";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 164);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(424, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAcceptShow
            // 
            this.btnAcceptShow.Location = new System.Drawing.Point(189, 523);
            this.btnAcceptShow.Name = "btnAcceptShow";
            this.btnAcceptShow.Size = new System.Drawing.Size(75, 23);
            this.btnAcceptShow.TabIndex = 4;
            this.btnAcceptShow.Text = "Close";
            this.btnAcceptShow.UseVisualStyleBackColor = true;
            this.btnAcceptShow.Click += new System.EventHandler(this.btnAcceptShow_Click);
            // 
            // lblFoundElements
            // 
            this.lblFoundElements.AutoSize = true;
            this.lblFoundElements.Location = new System.Drawing.Point(12, 198);
            this.lblFoundElements.Name = "lblFoundElements";
            this.lblFoundElements.Size = new System.Drawing.Size(35, 13);
            this.lblFoundElements.TabIndex = 5;
            this.lblFoundElements.Text = "label1";
            // 
            // gbSearchType
            // 
            this.gbSearchType.Controls.Add(this.rbAlbumsByGenre);
            this.gbSearchType.Controls.Add(this.rbSongsByGenre);
            this.gbSearchType.Controls.Add(this.rbArtistsByLabel);
            this.gbSearchType.Controls.Add(this.rbSongsByAlbum);
            this.gbSearchType.Controls.Add(this.rbAlbumsByArtist);
            this.gbSearchType.Controls.Add(this.rbSongsByArtist);
            this.gbSearchType.Location = new System.Drawing.Point(12, 21);
            this.gbSearchType.Name = "gbSearchType";
            this.gbSearchType.Size = new System.Drawing.Size(340, 84);
            this.gbSearchType.TabIndex = 6;
            this.gbSearchType.TabStop = false;
            this.gbSearchType.Text = "Search Type";
            // 
            // rbAlbumsByGenre
            // 
            this.rbAlbumsByGenre.AutoSize = true;
            this.rbAlbumsByGenre.Location = new System.Drawing.Point(224, 44);
            this.rbAlbumsByGenre.Name = "rbAlbumsByGenre";
            this.rbAlbumsByGenre.Size = new System.Drawing.Size(106, 17);
            this.rbAlbumsByGenre.TabIndex = 5;
            this.rbAlbumsByGenre.TabStop = true;
            this.rbAlbumsByGenre.Text = "Albums By Genre";
            this.rbAlbumsByGenre.UseVisualStyleBackColor = true;
            this.rbAlbumsByGenre.CheckedChanged += new System.EventHandler(this.rbAlbumsByArtist_CheckedChanged);
            // 
            // rbSongsByGenre
            // 
            this.rbSongsByGenre.AutoSize = true;
            this.rbSongsByGenre.Location = new System.Drawing.Point(7, 44);
            this.rbSongsByGenre.Name = "rbSongsByGenre";
            this.rbSongsByGenre.Size = new System.Drawing.Size(101, 17);
            this.rbSongsByGenre.TabIndex = 4;
            this.rbSongsByGenre.TabStop = true;
            this.rbSongsByGenre.Text = "Songs by Genre";
            this.rbSongsByGenre.UseVisualStyleBackColor = true;
            this.rbSongsByGenre.CheckedChanged += new System.EventHandler(this.rbAlbumsByArtist_CheckedChanged);
            // 
            // rbArtistsByLabel
            // 
            this.rbArtistsByLabel.AutoSize = true;
            this.rbArtistsByLabel.Location = new System.Drawing.Point(224, 20);
            this.rbArtistsByLabel.Name = "rbArtistsByLabel";
            this.rbArtistsByLabel.Size = new System.Drawing.Size(96, 17);
            this.rbArtistsByLabel.TabIndex = 3;
            this.rbArtistsByLabel.TabStop = true;
            this.rbArtistsByLabel.Text = "Artists by Label";
            this.rbArtistsByLabel.UseVisualStyleBackColor = true;
            this.rbArtistsByLabel.CheckedChanged += new System.EventHandler(this.rbAlbumsByArtist_CheckedChanged);
            // 
            // rbSongsByAlbum
            // 
            this.rbSongsByAlbum.AutoSize = true;
            this.rbSongsByAlbum.Location = new System.Drawing.Point(116, 44);
            this.rbSongsByAlbum.Name = "rbSongsByAlbum";
            this.rbSongsByAlbum.Size = new System.Drawing.Size(102, 17);
            this.rbSongsByAlbum.TabIndex = 2;
            this.rbSongsByAlbum.TabStop = true;
            this.rbSongsByAlbum.Text = "Songs By Album";
            this.rbSongsByAlbum.UseVisualStyleBackColor = true;
            this.rbSongsByAlbum.CheckedChanged += new System.EventHandler(this.rbAlbumsByArtist_CheckedChanged);
            // 
            // rbAlbumsByArtist
            // 
            this.rbAlbumsByArtist.AutoSize = true;
            this.rbAlbumsByArtist.Location = new System.Drawing.Point(8, 20);
            this.rbAlbumsByArtist.Name = "rbAlbumsByArtist";
            this.rbAlbumsByArtist.Size = new System.Drawing.Size(100, 17);
            this.rbAlbumsByArtist.TabIndex = 1;
            this.rbAlbumsByArtist.TabStop = true;
            this.rbAlbumsByArtist.Text = "Albums By Artist";
            this.rbAlbumsByArtist.UseVisualStyleBackColor = true;
            this.rbAlbumsByArtist.CheckedChanged += new System.EventHandler(this.rbAlbumsByArtist_CheckedChanged);
            // 
            // rbSongsByArtist
            // 
            this.rbSongsByArtist.AutoSize = true;
            this.rbSongsByArtist.Location = new System.Drawing.Point(116, 19);
            this.rbSongsByArtist.Name = "rbSongsByArtist";
            this.rbSongsByArtist.Size = new System.Drawing.Size(96, 17);
            this.rbSongsByArtist.TabIndex = 0;
            this.rbSongsByArtist.TabStop = true;
            this.rbSongsByArtist.Text = "Songs By Artist";
            this.rbSongsByArtist.UseVisualStyleBackColor = true;
            this.rbSongsByArtist.CheckedChanged += new System.EventHandler(this.rbAlbumsByArtist_CheckedChanged);
            // 
            // FormShowSongs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 554);
            this.Controls.Add(this.gbSearchType);
            this.Controls.Add(this.lblFoundElements);
            this.Controls.Add(this.btnAcceptShow);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lbFieldName);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lbSearchItem);
            this.Name = "FormShowSongs";
            this.ShowIcon = false;
            this.Text = "Search";
            this.Load += new System.EventHandler(this.FormShowSongs_Load);
            this.gbSearchType.ResumeLayout(false);
            this.gbSearchType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox lbSearchItem;
        public System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lbFieldName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAcceptShow;
        public System.Windows.Forms.Label lblFoundElements;
        private System.Windows.Forms.GroupBox gbSearchType;
        private System.Windows.Forms.RadioButton rbAlbumsByGenre;
        private System.Windows.Forms.RadioButton rbSongsByGenre;
        private System.Windows.Forms.RadioButton rbArtistsByLabel;
        private System.Windows.Forms.RadioButton rbSongsByAlbum;
        private System.Windows.Forms.RadioButton rbAlbumsByArtist;
        private System.Windows.Forms.RadioButton rbSongsByArtist;
    }
}