using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveDiscography
{
    public partial class FormShowSongs : Form
    {
        public ArrayList searchSongs;
        public ArrayList searchAlbums;
        public ArrayList searchArtists;
        RadioButton checkedRb;

        public FormShowSongs()
        {
            InitializeComponent();
        }

        private void resetRadioButtons()
        {            
            rbAlbumsByArtist.Checked = false;
            rbSongsByArtist.Checked = false;
            rbArtistsByLabel.Checked = false;
            rbSongsByGenre.Checked = false;
            rbSongsByAlbum.Checked = false;
            rbAlbumsByGenre.Checked = false;
            lbFieldName.Text = "Select a filter option";
            lbFieldName.Refresh();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
            lbSearchItem.Items.Clear();
            string toSearch = txtSearch.Text;
            try
            {
                switch (checkedRb.Name)
                {
                    case "rbAlbumsByArtist":

                        this.Refresh();
                        foreach (Album aLs in searchAlbums)
                        {
                            if (aLs.AlbumArtist.Equals(toSearch))
                            {
                                lbSearchItem.Items.Add(aLs.Title);
                                lbSearchItem.Refresh();
                            }
                        }

                        lblFoundElements.Visible = true;
                        lblFoundElements.Text = "Search found " + lbSearchItem.Items.Count + " songs";

                        if (lbSearchItem.Items.Count == 0)
                        {
                            MessageBox.Show("No elements found");
                        }
                        break;
                    case "rbSongsByArtist":
                        foreach (Song s in searchSongs)
                        {
                            if (s.SongArtist.Equals(toSearch))
                            {
                                lbSearchItem.Items.Add(s.SongName);
                                lbSearchItem.Refresh();
                            }
                        }

                        lblFoundElements.Visible = true;
                        lblFoundElements.Text = "Search found " + lbSearchItem.Items.Count + " songs";

                        if (lbSearchItem.Items.Count == 0)
                        {
                            MessageBox.Show("No elements found");
                        }
                        break;
                    case "rbArtistsByLabel":
                        foreach (Artist arS in searchArtists)
                        {
                            if (arS.Labels.Equals(toSearch))
                            {
                                lbSearchItem.Items.Add(arS.Name);
                                lbSearchItem.Refresh();
                            }
                        }

                        lblFoundElements.Visible = true;
                        lblFoundElements.Text = "Search found " + lbSearchItem.Items.Count + " songs";

                        if (lbSearchItem.Items.Count == 0)
                        {
                            MessageBox.Show("No elements found");
                        }
                        break;
                    case "rbSongsByGenre":
                        foreach (Song s in searchSongs)
                        {
                            if (s.Genre.Equals(toSearch))
                            {
                                lbSearchItem.Items.Add(s.SongName);
                                lbSearchItem.Refresh();
                            }
                        }

                        lblFoundElements.Visible = true;
                        lblFoundElements.Text = "Search found " + lbSearchItem.Items.Count + " songs";

                        if (lbSearchItem.Items.Count == 0)
                        {
                            MessageBox.Show("No elements found");
                        }
                        break;
                    case "rbSongsByAlbum":
                        foreach (Song s in searchSongs)
                        {
                            if (s.SongAlbum.Equals(toSearch))
                            {
                                lbSearchItem.Items.Add(s.SongName);
                                lbSearchItem.Refresh();
                            }
                        }

                        lblFoundElements.Visible = true;
                        lblFoundElements.Text = "Search found " + lbSearchItem.Items.Count + " songs";

                        if (lbSearchItem.Items.Count == 0)
                        {
                            MessageBox.Show("No elements found");
                        }
                        break;
                    case "rbAlbumsByGenre":
                        foreach (Album aLs in searchAlbums)
                        {
                            if (aLs.Genre.Equals(toSearch))
                            {
                                lbSearchItem.Items.Add(aLs.Title);
                                lbSearchItem.Refresh();
                            }
                        }

                        lblFoundElements.Visible = true;
                        lblFoundElements.Text = "Search found " + lbSearchItem.Items.Count + " songs";

                        if (lbSearchItem.Items.Count == 0)
                        {
                            MessageBox.Show("No elements found");
                        }
                        break;
                }
            }
            catch (System.NullReferenceException nrEx)
            {
                MessageBox.Show("No search filter type selected");
            }

        }

        private void btnAcceptShow_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void rbAlbumsByArtist_CheckedChanged(object sender, EventArgs e)
        {
            checkedRb = (RadioButton)sender;
            switch (checkedRb.Name)
            {
                case "rbAlbumsByArtist":
                    lbFieldName.Text = "Artist name: ";
                    break;
                case "rbSongsByArtist":
                    lbFieldName.Text = "Artist name: ";
                    break;
                case "rbArtistsByLabel":
                    lbFieldName.Text = "Label name: ";
                    break;
                case "rbSongsByGenre":
                    lbFieldName.Text = "Genre name: ";
                    break;
                case "rbSongsByAlbum":
                    lbFieldName.Text = "Album title: ";
                    break;
                case "rbAlbumsByGenre":
                    lbFieldName.Text = "Album genre: ";
                    break;
            }
            lbFieldName.Refresh();
        }

        private void FormShowSongs_Load(object sender, EventArgs e)
        {
            this.resetRadioButtons();
            
            
        }
    }
}
