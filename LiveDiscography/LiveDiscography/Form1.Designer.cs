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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.songToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.albumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
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
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
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
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.aboutToolStripMenuItem.Text = "About...";
            // 
            // lbArtist
            // 
            this.lbArtist.FormattingEnabled = true;
            this.lbArtist.Location = new System.Drawing.Point(12, 49);
            this.lbArtist.Name = "lbArtist";
            this.lbArtist.Size = new System.Drawing.Size(237, 121);
            this.lbArtist.TabIndex = 1;
            this.lbArtist.SelectedIndexChanged += new System.EventHandler(this.lbArtist_SelectedIndexChanged);
            // 
            // btnAddArtist
            // 
            this.btnAddArtist.Location = new System.Drawing.Point(12, 176);
            this.btnAddArtist.Name = "btnAddArtist";
            this.btnAddArtist.Size = new System.Drawing.Size(103, 23);
            this.btnAddArtist.TabIndex = 2;
            this.btnAddArtist.Text = "Add New Artist";
            this.btnAddArtist.UseVisualStyleBackColor = true;
            this.btnAddArtist.Click += new System.EventHandler(this.btnAddArtist_Click);
            // 
            // btnAddSong
            // 
            this.btnAddSong.Location = new System.Drawing.Point(533, 176);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(103, 23);
            this.btnAddSong.TabIndex = 3;
            this.btnAddSong.Text = "Add New Song";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // btnAddAlbum
            // 
            this.btnAddAlbum.Location = new System.Drawing.Point(269, 176);
            this.btnAddAlbum.Name = "btnAddAlbum";
            this.btnAddAlbum.Size = new System.Drawing.Size(103, 23);
            this.btnAddAlbum.TabIndex = 4;
            this.btnAddAlbum.Text = "Add New Album";
            this.btnAddAlbum.UseVisualStyleBackColor = true;
            this.btnAddAlbum.Click += new System.EventHandler(this.btnAddAlbum_Click);
            // 
            // txtArtistInfoDisplay
            // 
            this.txtArtistInfoDisplay.Enabled = false;
            this.txtArtistInfoDisplay.Location = new System.Drawing.Point(12, 244);
            this.txtArtistInfoDisplay.Multiline = true;
            this.txtArtistInfoDisplay.Name = "txtArtistInfoDisplay";
            this.txtArtistInfoDisplay.Size = new System.Drawing.Size(249, 121);
            this.txtArtistInfoDisplay.TabIndex = 5;
            // 
            // lbAlbum
            // 
            this.lbAlbum.FormattingEnabled = true;
            this.lbAlbum.Location = new System.Drawing.Point(269, 49);
            this.lbAlbum.Name = "lbAlbum";
            this.lbAlbum.Size = new System.Drawing.Size(249, 121);
            this.lbAlbum.TabIndex = 6;
            this.lbAlbum.SelectedIndexChanged += new System.EventHandler(this.lbAlbum_SelectedIndexChanged);
            // 
            // lblArInfo
            // 
            this.lblArInfo.AutoSize = true;
            this.lblArInfo.Location = new System.Drawing.Point(13, 228);
            this.lblArInfo.Name = "lblArInfo";
            this.lblArInfo.Size = new System.Drawing.Size(51, 13);
            this.lblArInfo.TabIndex = 7;
            this.lblArInfo.Text = "Artist Info";
            // 
            // lblAlInfo
            // 
            this.lblAlInfo.AutoSize = true;
            this.lblAlInfo.Location = new System.Drawing.Point(269, 225);
            this.lblAlInfo.Name = "lblAlInfo";
            this.lblAlInfo.Size = new System.Drawing.Size(57, 13);
            this.lblAlInfo.TabIndex = 9;
            this.lblAlInfo.Text = "Album Info";
            // 
            // lbSong
            // 
            this.lbSong.FormattingEnabled = true;
            this.lbSong.Location = new System.Drawing.Point(533, 49);
            this.lbSong.Name = "lbSong";
            this.lbSong.Size = new System.Drawing.Size(249, 121);
            this.lbSong.TabIndex = 10;
            this.lbSong.SelectedIndexChanged += new System.EventHandler(this.lbSong_SelectedIndexChanged);
            // 
            // lblSongInfo
            // 
            this.lblSongInfo.AutoSize = true;
            this.lblSongInfo.Location = new System.Drawing.Point(533, 225);
            this.lblSongInfo.Name = "lblSongInfo";
            this.lblSongInfo.Size = new System.Drawing.Size(53, 13);
            this.lblSongInfo.TabIndex = 12;
            this.lblSongInfo.Text = "Song Info";
            // 
            // txtAlbumInfoDisplay
            // 
            this.txtAlbumInfoDisplay.Enabled = false;
            this.txtAlbumInfoDisplay.Location = new System.Drawing.Point(269, 244);
            this.txtAlbumInfoDisplay.Multiline = true;
            this.txtAlbumInfoDisplay.Name = "txtAlbumInfoDisplay";
            this.txtAlbumInfoDisplay.Size = new System.Drawing.Size(249, 121);
            this.txtAlbumInfoDisplay.TabIndex = 13;
            // 
            // txtSongInfoDisplay
            // 
            this.txtSongInfoDisplay.Enabled = false;
            this.txtSongInfoDisplay.Location = new System.Drawing.Point(533, 244);
            this.txtSongInfoDisplay.Multiline = true;
            this.txtSongInfoDisplay.Name = "txtSongInfoDisplay";
            this.txtSongInfoDisplay.Size = new System.Drawing.Size(249, 121);
            this.txtSongInfoDisplay.TabIndex = 14;
            // 
            // btnDelArtist
            // 
            this.btnDelArtist.Location = new System.Drawing.Point(146, 176);
            this.btnDelArtist.Name = "btnDelArtist";
            this.btnDelArtist.Size = new System.Drawing.Size(103, 23);
            this.btnDelArtist.TabIndex = 15;
            this.btnDelArtist.Text = "Delete Artist";
            this.btnDelArtist.UseVisualStyleBackColor = true;
            // 
            // btnDelAlbum
            // 
            this.btnDelAlbum.Location = new System.Drawing.Point(415, 176);
            this.btnDelAlbum.Name = "btnDelAlbum";
            this.btnDelAlbum.Size = new System.Drawing.Size(103, 23);
            this.btnDelAlbum.TabIndex = 16;
            this.btnDelAlbum.Text = "Delete Album";
            this.btnDelAlbum.UseVisualStyleBackColor = true;
            // 
            // btnDelSong
            // 
            this.btnDelSong.Location = new System.Drawing.Point(679, 176);
            this.btnDelSong.Name = "btnDelSong";
            this.btnDelSong.Size = new System.Drawing.Size(103, 23);
            this.btnDelSong.TabIndex = 17;
            this.btnDelSong.Text = "Delete Song";
            this.btnDelSong.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 422);
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
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "LiveDiscography v1.0";
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
    }
}

