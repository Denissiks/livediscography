using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LiveDiscography
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        FormArtist fA = new FormArtist();
        FormAlbum fAl = new FormAlbum();
        FormSong fS = new FormSong();
        Artist addedArtist;
        Song addedSong;
        Album addedAlbum;
        ArrayList artists = new ArrayList();
        ArrayList albums = new ArrayList();
        ArrayList songs = new ArrayList();
        int i;
        bool flag;


        FileStream fs;
        BinaryWriter bw;
        BinaryReader br;

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            flag = true;

            if (fA.ShowDialog() == DialogResult.OK)
            {
                flag = true;
                if (artists.Count > 0)
                {
                    for (int j = 0; j < artists.Count; j++)
                    {
                        addedArtist = new Artist(fA.txtArName.Text, fA.txtArGenre.Text, fA.txtArLabel.Text, fA.txtArRealName.Text);

                        if (addedArtist.Name.Equals(((Artist)artists[j]).Name))
                        {
                            
                            flag = true;
                           
                        }
                        else
                        {
                            flag = false;
                            
                        }
                    }

                    if (flag == false)
                    {
                        artists.Add(addedArtist);
                        lbArtist.Items.Add(addedArtist.Name);
                        lbArtist.Refresh();
                        this.writeFile();
                    }
                    else
                    {
                        MessageBox.Show("Ese artista ya existe en la base de datos"+Environment.NewLine +"No se permiten duplicados");
                    }
                }
                else
                {
                    addedArtist = new Artist(fA.txtArName.Text, fA.txtArGenre.Text, fA.txtArLabel.Text, fA.txtArRealName.Text);
                    artists.Add(addedArtist);
                    lbArtist.Items.Add(addedArtist.Name);
                    lbArtist.Refresh();
                    this.writeFile();
                }

            }
        }

        private void lbArtist_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (i = 0; i < artists.Count; i++)
            {
                if (lbArtist.SelectedIndex.Equals(i))
                {
                    txtArtistInfoDisplay.Clear();
                    txtArtistInfoDisplay.Text += "Name: " + ((Artist)artists[i]).Name;
                    txtArtistInfoDisplay.Text += Environment.NewLine + "Genre: " + ((Artist)artists[i]).Genre;
                    txtArtistInfoDisplay.Text += Environment.NewLine + "Record Label: " + ((Artist)artists[i]).Labels;
                    txtArtistInfoDisplay.Text += Environment.NewLine + "Real Name: " + ((Artist)artists[i]).RealName;

                }
            }

            foreach (Artist a in artists)
            {

            }
        }

        private void lbAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (i = 0; i < albums.Count; i++)
            {
                if (lbAlbum.SelectedIndex.Equals(i))
                {
                    txtAlbumInfoDisplay.Clear();
                    txtAlbumInfoDisplay.Text += "Title: " + ((Album)albums[i]).Title;
                    txtAlbumInfoDisplay.Text += Environment.NewLine + "Artist: " + ((Album)albums[i]).AlbumArtist;
                    txtAlbumInfoDisplay.Text += Environment.NewLine + "Release Date: " + ((Album)albums[i]).ReleaseYear + " / " + ((Album)albums[i]).ReleaseMonth + " / " + ((Album)albums[i]).ReleaseDay;
                    txtAlbumInfoDisplay.Text += Environment.NewLine + "Country: " + ((Album)albums[i]).ReleaseCountry;
                    txtAlbumInfoDisplay.Text += Environment.NewLine + "Record Label: " + ((Album)albums[i]).RecordLabel;
                    txtAlbumInfoDisplay.Text += Environment.NewLine + "Genre: " + ((Album)albums[i]).Genre;
                    txtAlbumInfoDisplay.Text += Environment.NewLine + "Total Length: " + ((Album)albums[i]).TotalMinLength;
                    txtAlbumInfoDisplay.Text += Environment.NewLine + "Number Of Tracks: " + ((Album)albums[i]).NumberOfTracks;

                }
            }

            foreach (Artist a in artists)
            {

            }
        }

        private void lbSong_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (i = 0; i < songs.Count; i++)
            {
                if (lbSong.SelectedIndex.Equals(i))
                {
                    txtSongInfoDisplay.Clear();
                    txtSongInfoDisplay.Text += "Title: " + ((Song)songs[i]).SongName;
                    txtSongInfoDisplay.Text += Environment.NewLine + "Album: " + ((Song)songs[i]).SongAlbum;
                    txtSongInfoDisplay.Text += Environment.NewLine + "Artist: " + ((Song)songs[i]).SongArtist;
                    txtSongInfoDisplay.Text += Environment.NewLine + "Length: " + ((Song)songs[i]).MinLength + ":" + ((Song)songs[i]).SecLength;
                    txtSongInfoDisplay.Text += Environment.NewLine + "Genre: " + ((Song)songs[i]).Genre;
                }
            }

            foreach (Song s in songs)
            {

            }
        }



        private void btnAddSong_Click(object sender, EventArgs e)
        {
            if (fS.ShowDialog() == DialogResult.OK)
            {
                if (songs.Contains(fS.Name))
                {

                }
                else
                {
                    addedSong = new Song(fS.txtTitle.Text, fS.txtAlbum.Text, fS.txtArtist.Text, Convert.ToInt16(fS.txtLenMin.Text), Convert.ToInt16(fS.txtLenSec.Text), fS.txtGenre.Text);
                    songs.Add(addedSong);
                    lbSong.Items.Add(addedSong.SongName);
                }

                lbSong.Refresh();
            }

        }

        private void btnAddAlbum_Click(object sender, EventArgs e)
        {
            if (fAl.ShowDialog() == DialogResult.OK)
            {
                if (songs.Contains(fA.Name))
                {

                }
                else
                {
                    addedAlbum = new Album(fAl.txtTitle.Text, Convert.ToInt16(fAl.txtYear.Text), eMonth.January, Convert.ToInt16(fAl.txtDay.Text), fAl.txtCountry.Text, fAl.txtRecordLabel.Text, fAl.txtGenre.Text, Convert.ToInt16(fAl.txtLength.Text), Convert.ToInt16(fAl.txtTracks.Text), fAl.txtArtist.Text);
                    albums.Add(addedAlbum);
                    lbAlbum.Items.Add(addedAlbum.Title);
                }

                lbAlbum.Refresh();
            }
        }

        //Metodo de guardado
        private void writeFile()
        {
            try
            {
                fs = new FileStream("C:\\Users\\Usuario\\artistData.bin", FileMode.OpenOrCreate, FileAccess.Write);
                bw = new BinaryWriter(fs);

                //Primero guardamos los primitivos de cada artista
                for (i = 0; i < artists.Count; i++)
                {

                    bw.Write(((Artist)artists[i]).Name);
                    bw.Write(((Artist)artists[i]).Genre);
                    bw.Write(((Artist)artists[i]).Labels);
                    bw.Write(((Artist)artists[i]).RealName);
                }

                //Despues guardamos los primitivos de cada album
                for (i = 0; i < albums.Count; i++)
                {
                    bw.Write(((Album)albums[i]).Title);
                    bw.Write(((Album)albums[i]).ReleaseYear);
                    bw.Write(((Album)albums[i]).ToString());
                    bw.Write(((Album)albums[i]).ReleaseDay);
                    bw.Write(((Album)albums[i]).ReleaseCountry);
                    bw.Write(((Album)albums[i]).RecordLabel);
                    bw.Write(((Album)albums[i]).Genre);
                    bw.Write(((Album)albums[i]).TotalMinLength);
                    bw.Write(((Album)albums[i]).NumberOfTracks);
                    bw.Write(((Album)albums[i]).AlbumArtist);
                }

                //Despues guardamos los primitivos de cada cancion
                for (i = 0; i < songs.Count; i++)
                {
                    bw.Write(((Song)songs[i]).SongName);
                    bw.Write(((Song)songs[i]).SongAlbum);
                    bw.Write(((Song)songs[i]).SongArtist);
                    bw.Write(((Song)songs[i]).MinLength);
                    bw.Write(((Song)songs[i]).SecLength);
                    bw.Write(((Song)songs[i]).Genre);
                }
                bw.Close();
                fs.Close();
            }
            catch
            {
                MessageBox.Show("Imposible guardar", "Error detectado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Metodo de lectura
        private void readFile()
        {
            try
            {
                fs = new FileStream("C:\\Users\\Usuario\\artistData.bin", FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);

                while (br.Read() != -1)
                {

                }
            }
            catch
            {
                MessageBox.Show("Fallo al leer", "Error detectado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


    }
}
