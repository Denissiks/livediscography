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
using System.Data.Sql;
using MySql.Data.MySqlClient;

namespace LiveDiscography
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        //Formularios Secundarios
        FormArtist fA = new FormArtist();
        FormAlbum fAl = new FormAlbum();
        FormSong fS = new FormSong();

        //Clases de objetos
        Artist addedArtist;
        Song addedSong;
        Album addedAlbum;

        //Contenedores
        ArrayList artists = new ArrayList();
        ArrayList albums = new ArrayList();
        ArrayList songs = new ArrayList();

        //Variables
        int i;
        Boolean flag;

        //SQL
        DataSet ds = new DataSet();
        String conexionn = "Server=127.0.0.1; Database=livediscography; Uid=root; Pwd= ";
        MySqlDataAdapter daArtists = new MySqlDataAdapter();
        MySqlDataAdapter daAlbums = new MySqlDataAdapter();
        MySqlDataAdapter daSongs = new MySqlDataAdapter();
        MySqlConnection conexion = null;
        MySqlCommandBuilder objCommandBuilder = null;
        //Creación de DataSet a partir de Database
        private void creaDataset()
        {
            conexion = new MySqlConnection(conexionn);
            try
            {
                conexion.Open();
                daArtists = new MySqlDataAdapter("SELECT * FROM ARTISTS", conexionn);
                daAlbums = new MySqlDataAdapter("SELECT * FROM ALBUMS", conexionn);
                daSongs = new MySqlDataAdapter("SELECT * FROM SONGS", conexionn);
                daArtists.Fill(ds, "Artists");
                daAlbums.Fill(ds, "Albums");
                daSongs.Fill(ds, "Songs");
            }
            finally
            {
                conexion.Close();
            }
        }

        //Comprobación de duplicados
        private Boolean comprobar(Artist artista)
        {
            bool flagComp = false;

            for (int i = 0; i < artists.Count; i++)
            {
                if (artista.Name.Equals(((Artist)artists[i]).Name))
                {
                    flagComp = true;
                }
                else
                {
                    flagComp = false;
                }
            }
            return flagComp;
        }

        //Evento "Click" del botón Add New Artist
        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            flag = true;

            if (fA.ShowDialog() == DialogResult.OK)
            {
                flag = true;
                if (artists.Count > 0)
                {
                    addedArtist = new Artist(fA.txtArName.Text, fA.txtArGenre.Text, fA.txtArLabel.Text, fA.txtArRealName.Text);

                    if (comprobar(addedArtist) == false)
                    {
                        artists.Add(addedArtist);
                        lbArtist.Items.Add(addedArtist.Name);

                        foreach (DataTable dtr in ds.Tables)
                        {
                            if (dtr.TableName.Equals("Artists"))
                            {
                                this.addToDataTable(dtr, addedArtist);
                            }
                        }

                        lbArtist.Refresh();
                        //this.writeFile();
                    }
                    else
                    {
                        MessageBox.Show("Ese artista ya existe en la base de datos" + Environment.NewLine + "No se permiten duplicados");
                    }

                }
                else
                {
                    addedArtist = new Artist(fA.txtArName.Text, fA.txtArGenre.Text, fA.txtArLabel.Text, fA.txtArRealName.Text);
                    artists.Add(addedArtist);
                    lbArtist.Items.Add(addedArtist.Name);
                    lbArtist.Refresh();
                }
            }
        }

        //Evento "Click" del botón Add New Song
        private void btnAddSong_Click(object sender, EventArgs e)
        {
            if (fS.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    addedSong = new Song(fS.txtTitle.Text, fS.txtAlbum.Text, fS.txtArtist.Text, Convert.ToInt16(fS.txtLenMin.Text), Convert.ToInt16(fS.txtLenSec.Text), fS.txtGenre.Text);
                    songs.Add(addedSong);
                    lbSong.Items.Add(addedSong.SongName);
                }
                catch
                {
                    MessageBox.Show("Numeric values can't include letters or characters");
                }

                foreach (DataTable dtr in ds.Tables)
                {
                    if (dtr.TableName.Equals("Songs"))
                    {
                        this.addToDataTable(dtr, addedSong);
                    }
                }

                lbSong.Refresh();
            }
        }

        //Evento "Click" del botón Add New Album
        private void btnAddAlbum_Click(object sender, EventArgs e)
        {
            if (fAl.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    addedAlbum = new Album(fAl.txtTitle.Text, Convert.ToInt16(fAl.txtYear.Text), (fAl.cbMonth.SelectedItem).ToString(), Convert.ToInt16(fAl.txtDay.Text), fAl.txtCountry.Text, fAl.txtRecordLabel.Text, fAl.txtGenre.Text, Convert.ToInt16(fAl.txtLength.Text), Convert.ToInt16(fAl.txtTracks.Text), fAl.txtArtist.Text);
                    albums.Add(addedAlbum);
                    lbAlbum.Items.Add(addedAlbum.Title);
                }
                catch
                {
                    MessageBox.Show("Numeric values can't include letters or characters");
                }



                foreach (DataTable dtr in ds.Tables)
                {
                    if (dtr.TableName.Equals("Albums"))
                    {
                        this.addToDataTable(dtr, addedAlbum);
                    }
                }
                lbAlbum.Refresh();
            }
        }

        //Evento de cambio de índice seleccionado en la listbox de Artistas
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
        }

        //Evento de cambio de índice en la listbox de Albums
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
        }

        //Evento de cambio de índice en la listbox de Songs
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
        }

        //Metodo de guardado en database
        private void addToDataTable(DataTable d, Object objeto)
        {
            DataRow newRow;

            switch (d.TableName)
            {

                case "Artists":
                    Artist dbArtist = (Artist)objeto;
                    newRow = ds.Tables["Artists"].NewRow();
                    newRow["Name"] = dbArtist.Name.ToString();
                    newRow["Genre"] = dbArtist.Genre.ToString();
                    newRow["Labels"] = dbArtist.Labels.ToString();
                    newRow["RealName"] = dbArtist.RealName.ToString();
                    conexion.Open();
                    ds.Tables["Artists"].Rows.Add(newRow);
                    objCommandBuilder = new MySqlCommandBuilder(daArtists);
                    try
                    {
                        daArtists.Update(ds, "Artists");
                    }
                    catch
                    {

                    }

                    conexion.Close();
                    break;

                case "Albums":
                    Album dbAlbum = (Album)objeto;
                    newRow = ds.Tables["Albums"].NewRow();
                    newRow["Title"] = dbAlbum.Title.ToString();
                    newRow["ReleaseYear"] = Convert.ToInt32(dbAlbum.ReleaseYear);
                    newRow["ReleaseMonth"] = dbAlbum.ReleaseMonth.ToString();
                    newRow["ReleaseDay"] = Convert.ToInt32(dbAlbum.ReleaseDay);
                    newRow["ReleaseCountry"] = dbAlbum.ReleaseCountry.ToString();
                    newRow["RecordLabel"] = dbAlbum.RecordLabel.ToString();
                    newRow["Genre"] = dbAlbum.Genre.ToString();
                    newRow["TotalMinLength"] = Convert.ToInt32(dbAlbum.TotalMinLength);
                    newRow["NumberOfTracks"] = Convert.ToInt32(dbAlbum.NumberOfTracks);
                    newRow["AlbumArtist"] = dbAlbum.AlbumArtist.ToString();
                    ds.Tables["Albums"].Rows.Add(newRow);
                    conexion.Open();
                    objCommandBuilder = new MySqlCommandBuilder(daAlbums);
                    try
                    {
                        daAlbums.Update(ds, "Albums");
                    }
                    catch
                    {

                    }

                    conexion.Close();
                    break;

                case "Songs":
                    Song dbSong = (Song)objeto;
                    newRow = ds.Tables["Songs"].NewRow();
                    newRow["Name"] = dbSong.SongName.ToString();
                    newRow["Album"] = dbSong.SongAlbum.ToString();
                    newRow["Artist"] = dbSong.SongArtist.ToString();
                    newRow["Minlength"] = Convert.ToInt32(dbSong.MinLength);
                    newRow["Seclength"] = Convert.ToInt32(dbSong.SecLength);
                    newRow["Genre"] = dbSong.Genre.ToString();
                    ds.Tables["Songs"].Rows.Add(newRow);
                    conexion.Open();
                    objCommandBuilder = new MySqlCommandBuilder(daSongs);
                    try
                    {
                        daSongs.Update(ds, "Songs");
                    }
                    catch
                    {

                    }

                    conexion.Close();
                    break;
            }
        }

        //Metodo de borrado de database
        private void deleteFromDataTable(DataTable d, int indexx)
        {
            switch (d.TableName)
            {
                case "Artists":

                    d.Rows[indexx].Delete();
                    conexion.Open();
                    objCommandBuilder = new MySqlCommandBuilder(daArtists);
                    daArtists.Update(ds, "Artists");
                    conexion.Close();
                    break;

                case "Albums":

                    d.Rows[indexx].Delete();
                    conexion.Open();
                    objCommandBuilder = new MySqlCommandBuilder(daAlbums);
                    daAlbums.Update(ds, "Albums");
                    conexion.Close();
                    break;

                case "Songs":

                    d.Rows[indexx].Delete();
                    conexion.Open();
                    objCommandBuilder = new MySqlCommandBuilder(daSongs);
                    daSongs.Update(ds, "Songs");
                    conexion.Close();
                    break;
            }
        }

        //Evento de carga del formulario principal
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            creaDataset();
            foreach (DataTable dt in ds.Tables)
            {
                if (dt.TableName.Equals("Artists"))
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        addedArtist = new Artist(dr[0] + "", dr[1] + "", dr[2] + "", dr[3] + "");
                        artists.Add(addedArtist);
                        lbArtist.Items.Add(addedArtist.Name);
                    }
                }

                if (dt.TableName.Equals("Albums"))
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        addedAlbum = new Album(dr[0] + "", Convert.ToInt32(dr[1]), dr[2] + "", Convert.ToInt32(dr[3]), dr[4] + "", dr[5] + "", dr[6] + "", Convert.ToInt32(dr[7]), Convert.ToInt32(dr[8]), dr[9] + "");
                        albums.Add(addedAlbum);
                        lbAlbum.Items.Add(addedAlbum.Title);
                    }
                }
                if (dt.TableName.Equals("Songs"))
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        addedSong = new Song(dr[0] + "", dr[1] + "", dr[2] + "", Convert.ToInt32(dr[3]), Convert.ToInt32(dr[4]), dr[5] + "");
                        songs.Add(addedSong);
                        lbSong.Items.Add(addedSong.SongName);

                    }
                }
            }
            this.Refresh();
        }

        //Evento "Click" del botón Delete Artist 
        private void btnDelArtist_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure about deleting this element?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                try
                {
                    deleteFromDataTable(ds.Tables["Artists"], lbArtist.SelectedIndex);
                    artists.RemoveAt(lbArtist.SelectedIndex);
                    lbArtist.Items.RemoveAt(lbArtist.SelectedIndex);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("None artist selected, please chose one");
                }
            }

            lbArtist.Refresh();
        }

        //Evento "Click" del botón Delete Album 
        private void btnDelAlbum_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure about deleting this element?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                try
                {
                    deleteFromDataTable(ds.Tables["Albums"], lbAlbum.SelectedIndex);
                    albums.RemoveAt(lbAlbum.SelectedIndex);
                    lbAlbum.Items.RemoveAt(lbAlbum.SelectedIndex);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("None album selected, please chose one");
                }
            }

            lbAlbum.Refresh();
        }

        //Evento "Click" del botón Delete Song 
        private void btnDelSong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure about deleting this element?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                try
                {
                    deleteFromDataTable(ds.Tables["Songs"], lbSong.SelectedIndex);
                    songs.RemoveAt(lbSong.SelectedIndex);
                    lbSong.Items.RemoveAt(lbSong.SelectedIndex);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("None song selected, please chose one");
                }
            }

            lbSong.Refresh();
        }

        //Evento "Click" que muestra la información del programa
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Original idea & development by Denis Siks, 2018","LiveDiscography Ver. 1.0");
        }
    }
}
