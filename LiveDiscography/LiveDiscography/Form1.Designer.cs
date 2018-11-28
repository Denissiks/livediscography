namespace LiveDiscography
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.songToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAlbumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteArtistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbArtist = new System.Windows.Forms.ListBox();
            this.btnAddArtist = new System.Windows.Forms.Button();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.btnAddAlbum = new System.Windows.Forms.Button();
            this.txtArtistInfoDisplay = new System.Windows.Forms.TextBox();
            this.lbAlbum = new System.Windows.Forms.ListBox();
            this.lblArInfo = new System.Windows.Forms.Label();
            this.lblAlInfo = new System.Windows.Forms.Label();
            this.lbSong = new System.Windows.Forms.ListBox();
            this.lblSongInfo = new System.Windows.Forms.Label();
            this.txtAlbumInfoDisplay = new System.Windows.Forms.TextBox();
            this.txtSongInfoDisplay = new System.Windows.Forms.TextBox();
            this.btnDelArtist = new System.Windows.Forms.Button();
            this.btnDelAlbum = new System.Windows.Forms.Button();
            this.btnDelSong = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnEditArtist = new System.Windows.Forms.Button();
            this.btnEditAlbum = new System.Windows.Forms.Button();
            this.btnEditSong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(798, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.archivoToolStripMenuItem.Text = "File";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artistToolStripMenuItem,
            this.songToolStripMenuItem,
            this.albumToolStripMenuItem});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.nuevoToolStripMenuItem.Text = "New...";
            // 
            // artistToolStripMenuItem
            // 
            this.artistToolStripMenuItem.Name = "artistToolStripMenuItem";
            this.artistToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.artistToolStripMenuItem.Text = "Artist";
            this.artistToolStripMenuItem.Click += new System.EventHandler(this.btnAddArtist_Click);
            // 
            // songToolStripMenuItem
            // 
            this.songToolStripMenuItem.Name = "songToolStripMenuItem";
            this.songToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.songToolStripMenuItem.Text = "Song";
            this.songToolStripMenuItem.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // albumToolStripMenuItem
            // 
            this.albumToolStripMenuItem.Name = "albumToolStripMenuItem";
            this.albumToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.albumToolStripMenuItem.Text = "Album";
            this.albumToolStripMenuItem.Click += new System.EventHandler(this.btnAddAlbum_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteAlbumToolStripMenuItem,
            this.deleteSongToolStripMenuItem,
            this.deleteArtistToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // deleteAlbumToolStripMenuItem
            // 
            this.deleteAlbumToolStripMenuItem.Name = "deleteAlbumToolStripMenuItem";
            this.deleteAlbumToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteAlbumToolStripMenuItem.Text = "Delete Album";
            this.deleteAlbumToolStripMenuItem.Click += new System.EventHandler(this.btnDelAlbum_Click);
            // 
            // deleteSongToolStripMenuItem
            // 
            this.deleteSongToolStripMenuItem.Name = "deleteSongToolStripMenuItem";
            this.deleteSongToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteSongToolStripMenuItem.Text = "Delete Song";
            this.deleteSongToolStripMenuItem.Click += new System.EventHandler(this.btnDelSong_Click);
            // 
            // deleteArtistToolStripMenuItem
            // 
            this.deleteArtistToolStripMenuItem.Name = "deleteArtistToolStripMenuItem";
            this.deleteArtistToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteArtistToolStripMenuItem.Text = "Delete Artist";
            this.deleteArtistToolStripMenuItem.Click += new System.EventHandler(this.btnDelArtist_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.songsPerAlbumToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lbArtist
            // 
            this.lbArtist.FormattingEnabled = true;
            this.lbArtist.Location = new System.Drawing.Point(12, 59);
            this.lbArtist.Name = "lbArtist";
            this.lbArtist.Size = new System.Drawing.Size(237, 121);
            this.lbArtist.TabIndex = 1;
            this.lbArtist.SelectedIndexChanged += new System.EventHandler(this.lbArtist_SelectedIndexChanged);
            // 
            // btnAddArtist
            // 
            this.btnAddArtist.Location = new System.Drawing.Point(19, 186);
            this.btnAddArtist.Name = "btnAddArtist";
            this.btnAddArtist.Size = new System.Drawing.Size(71, 23);
            this.btnAddArtist.TabIndex = 2;
            this.btnAddArtist.Text = "Add New Artist";
            this.toolTip1.SetToolTip(this.btnAddArtist, "Add a new artist to the database");
            this.btnAddArtist.UseVisualStyleBackColor = true;
            this.btnAddArtist.Click += new System.EventHandler(this.btnAddArtist_Click);
            // 
            // btnAddSong
            // 
            this.btnAddSong.Location = new System.Drawing.Point(546, 186);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(71, 23);
            this.btnAddSong.TabIndex = 3;
            this.btnAddSong.Text = "Add New Song";
            this.toolTip1.SetToolTip(this.btnAddSong, "Add a new song to the database");
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // btnAddAlbum
            // 
            this.btnAddAlbum.Location = new System.Drawing.Point(282, 186);
            this.btnAddAlbum.Name = "btnAddAlbum";
            this.btnAddAlbum.Size = new System.Drawing.Size(71, 23);
            this.btnAddAlbum.TabIndex = 4;
            this.btnAddAlbum.Text = "Add New Album";
            this.toolTip1.SetToolTip(this.btnAddAlbum, "Add new album to the database");
            this.btnAddAlbum.UseVisualStyleBackColor = true;
            this.btnAddAlbum.Click += new System.EventHandler(this.btnAddAlbum_Click);
            // 
            // txtArtistInfoDisplay
            // 
            this.txtArtistInfoDisplay.Enabled = false;
            this.txtArtistInfoDisplay.Location = new System.Drawing.Point(12, 254);
            this.txtArtistInfoDisplay.Multiline = true;
            this.txtArtistInfoDisplay.Name = "txtArtistInfoDisplay";
            this.txtArtistInfoDisplay.Size = new System.Drawing.Size(249, 121);
            this.txtArtistInfoDisplay.TabIndex = 5;
            // 
            // lbAlbum
            // 
            this.lbAlbum.FormattingEnabled = true;
            this.lbAlbum.Location = new System.Drawing.Point(269, 59);
            this.lbAlbum.Name = "lbAlbum";
            this.lbAlbum.Size = new System.Drawing.Size(249, 121);
            this.lbAlbum.TabIndex = 6;
            this.lbAlbum.SelectedIndexChanged += new System.EventHandler(this.lbAlbum_SelectedIndexChanged);
            // 
            // lblArInfo
            // 
            this.lblArInfo.AutoSize = true;
            this.lblArInfo.Location = new System.Drawing.Point(13, 238);
            this.lblArInfo.Name = "lblArInfo";
            this.lblArInfo.Size = new System.Drawing.Size(51, 13);
            this.lblArInfo.TabIndex = 7;
            this.lblArInfo.Text = "Artist Info";
            // 
            // lblAlInfo
            // 
            this.lblAlInfo.AutoSize = true;
            this.lblAlInfo.Location = new System.Drawing.Point(269, 235);
            this.lblAlInfo.Name = "lblAlInfo";
            this.lblAlInfo.Size = new System.Drawing.Size(57, 13);
            this.lblAlInfo.TabIndex = 9;
            this.lblAlInfo.Text = "Album Info";
            // 
            // lbSong
            // 
            this.lbSong.FormattingEnabled = true;
            this.lbSong.Location = new System.Drawing.Point(533, 59);
            this.lbSong.Name = "lbSong";
            this.lbSong.Size = new System.Drawing.Size(249, 121);
            this.lbSong.TabIndex = 10;
            this.lbSong.SelectedIndexChanged += new System.EventHandler(this.lbSong_SelectedIndexChanged);
            // 
            // lblSongInfo
            // 
            this.lblSongInfo.AutoSize = true;
            this.lblSongInfo.Location = new System.Drawing.Point(533, 235);
            this.lblSongInfo.Name = "lblSongInfo";
            this.lblSongInfo.Size = new System.Drawing.Size(53, 13);
            this.lblSongInfo.TabIndex = 12;
            this.lblSongInfo.Text = "Song Info";
            // 
            // txtAlbumInfoDisplay
            // 
            this.txtAlbumInfoDisplay.Enabled = false;
            this.txtAlbumInfoDisplay.Location = new System.Drawing.Point(269, 254);
            this.txtAlbumInfoDisplay.Multiline = true;
            this.txtAlbumInfoDisplay.Name = "txtAlbumInfoDisplay";
            this.txtAlbumInfoDisplay.Size = new System.Drawing.Size(249, 121);
            this.txtAlbumInfoDisplay.TabIndex = 13;
            // 
            // txtSongInfoDisplay
            // 
            this.txtSongInfoDisplay.Enabled = false;
            this.txtSongInfoDisplay.Location = new System.Drawing.Point(533, 254);
            this.txtSongInfoDisplay.Multiline = true;
            this.txtSongInfoDisplay.Name = "txtSongInfoDisplay";
            this.txtSongInfoDisplay.Size = new System.Drawing.Size(249, 121);
            this.txtSongInfoDisplay.TabIndex = 14;
            // 
            // btnDelArtist
            // 
            this.btnDelArtist.Location = new System.Drawing.Point(173, 186);
            this.btnDelArtist.Name = "btnDelArtist";
            this.btnDelArtist.Size = new System.Drawing.Size(71, 23);
            this.btnDelArtist.TabIndex = 15;
            this.btnDelArtist.Text = "Delete Artist";
            this.toolTip1.SetToolTip(this.btnDelArtist, "Delete selected artist from the database");
            this.btnDelArtist.UseVisualStyleBackColor = true;
            this.btnDelArtist.Click += new System.EventHandler(this.btnDelArtist_Click);
            // 
            // btnDelAlbum
            // 
            this.btnDelAlbum.Location = new System.Drawing.Point(436, 186);
            this.btnDelAlbum.Name = "btnDelAlbum";
            this.btnDelAlbum.Size = new System.Drawing.Size(71, 23);
            this.btnDelAlbum.TabIndex = 16;
            this.btnDelAlbum.Text = "Delete Album";
            this.toolTip1.SetToolTip(this.btnDelAlbum, "Delete selected album from the database");
            this.btnDelAlbum.UseVisualStyleBackColor = true;
            this.btnDelAlbum.Click += new System.EventHandler(this.btnDelAlbum_Click);
            // 
            // btnDelSong
            // 
            this.btnDelSong.Location = new System.Drawing.Point(700, 186);
            this.btnDelSong.Name = "btnDelSong";
            this.btnDelSong.Size = new System.Drawing.Size(71, 23);
            this.btnDelSong.TabIndex = 17;
            this.btnDelSong.Text = "Delete Song";
            this.toolTip1.SetToolTip(this.btnDelSong, "Delete selected song from the database");
            this.btnDelSong.UseVisualStyleBackColor = true;
            this.btnDelSong.Click += new System.EventHandler(this.btnDelSong_Click);
            // 
            // btnEditArtist
            // 
            this.btnEditArtist.Location = new System.Drawing.Point(96, 186);
            this.btnEditArtist.Name = "btnEditArtist";
            this.btnEditArtist.Size = new System.Drawing.Size(71, 23);
            this.btnEditArtist.TabIndex = 18;
            this.btnEditArtist.Text = "Edit Artist";
            this.btnEditArtist.UseVisualStyleBackColor = true;
            this.btnEditArtist.Click += new System.EventHandler(this.btnEditArtist_Click);
            // 
            // btnEditAlbum
            // 
            this.btnEditAlbum.Location = new System.Drawing.Point(359, 186);
            this.btnEditAlbum.Name = "btnEditAlbum";
            this.btnEditAlbum.Size = new System.Drawing.Size(71, 23);
            this.btnEditAlbum.TabIndex = 19;
            this.btnEditAlbum.Text = "Edit Album";
            this.btnEditAlbum.UseVisualStyleBackColor = true;
            this.btnEditAlbum.Click += new System.EventHandler(this.btnEditAlbum_Click);
            // 
            // btnEditSong
            // 
            this.btnEditSong.Location = new System.Drawing.Point(623, 186);
            this.btnEditSong.Name = "btnEditSong";
            this.btnEditSong.Size = new System.Drawing.Size(71, 23);
            this.btnEditSong.TabIndex = 20;
            this.btnEditSong.Text = "Edit Song";
            this.btnEditSong.UseVisualStyleBackColor = true;
            this.btnEditSong.Click += new System.EventHandler(this.btnEditSong_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Artists:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Albums: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(533, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Songs:";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 422);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditSong);
            this.Controls.Add(this.btnEditAlbum);
            this.Controls.Add(this.btnEditArtist);
            this.Controls.Add(this.btnDelSong);
            this.Controls.Add(this.btnDelAlbum);
            this.Controls.Add(this.btnDelArtist);
            this.Controls.Add(this.txtSongInfoDisplay);
            this.Controls.Add(this.txtAlbumInfoDisplay);
            this.Controls.Add(this.lblSongInfo);
            this.Controls.Add(this.lbSong);
            this.Controls.Add(this.lblAlInfo);
            this.Controls.Add(this.lblArInfo);
            this.Controls.Add(this.lbAlbum);
            this.Controls.Add(this.txtArtistInfoDisplay);
            this.Controls.Add(this.btnAddAlbum);
            this.Controls.Add(this.btnAddSong);
            this.Controls.Add(this.btnAddArtist);
            this.Controls.Add(this.lbArtist);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "LiveDiscography v1.0";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem songToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem albumToolStripMenuItem;
        private System.Windows.Forms.ListBox lbArtist;
        private System.Windows.Forms.Button btnAddArtist;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.Button btnAddAlbum;
        private System.Windows.Forms.TextBox txtArtistInfoDisplay;
        private System.Windows.Forms.ListBox lbAlbum;
        private System.Windows.Forms.Label lblArInfo;
        private System.Windows.Forms.Label lblAlInfo;
        private System.Windows.Forms.ListBox lbSong;
        private System.Windows.Forms.Label lblSongInfo;
        private System.Windows.Forms.TextBox txtAlbumInfoDisplay;
        private System.Windows.Forms.TextBox txtSongInfoDisplay;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnDelArtist;
        private System.Windows.Forms.Button btnDelAlbum;
        private System.Windows.Forms.Button btnDelSong;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteArtistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAlbumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSongToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnEditArtist;
        private System.Windows.Forms.Button btnEditAlbum;
        private System.Windows.Forms.Button btnEditSong;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

