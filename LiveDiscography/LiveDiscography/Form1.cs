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
        FormShowSongs fSs = new FormShowSongs();

        //Clases de objetos
        Artist addedArtist;
        Song addedSong;
        Album addedAlbum;

        //Contenedores
        public ArrayList artists = new ArrayList();
        public ArrayList albums = new ArrayList();
        public ArrayList songs = new ArrayList();

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
            fA.Text = "New Artist";
            fA.txtArName.Clear();
            fA.txtArGenre.Clear();
            fA.txtArLabel.Clear();
            fA.txtArRealName.Clear();

            try
            {
                if (fA.ShowDialog() == DialogResult.OK)
                {
                    flag = true;
                    if (artists.Count > 0)
                    {
                        addedArtist = new Artist(fA.txtArName.Text, fA.txtArGenre.Text, fA.txtArLabel.Text, fA.txtArRealName.Text);

                        if (comprobar(addedArtist) == false)
                        {

                            foreach (DataTable dtr in ds.Tables)
                            {
                                if (dtr.TableName.Equals("Artists"))
                                {
                                    this.addToDataTable(dtr, addedArtist);
                                }
                            }
                            lbArtist.Items.Add(addedArtist.Name);
                            artists.Add(addedArtist);
                            lbArtist.Refresh();

                        }
                        else
                        {
                            MessageBox.Show("You can't add an artist that is already in the database");
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
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("No SQL server found, your changes cannot be saved");

            }

        }

        //Evento "Click" del botón Add New Song
        private void btnAddSong_Click(object sender, EventArgs e)
        {

            try
            {
                if (fS.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        addedSong = new Song(fS.txtTitle.Text, fS.txtAlbum.Text, fS.txtArtist.Text, Convert.ToInt16(fS.txtLenMin.Text), Convert.ToInt16(fS.txtLenSec.Text), fS.txtGenre.Text);

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
                    songs.Add(addedSong);
                    lbSong.Items.Add(addedSong.SongName);
                    lbSong.Refresh();
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("No SQL server found, your changes cannot be saved");

            }
        }

        //Evento "Click" del botón Add New Album
        private void btnAddAlbum_Click(object sender, EventArgs e)
        {
            fAl.Text = "New Album";
            try
            {
                if (fAl.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        addedAlbum = new Album(fAl.txtTitle.Text, Convert.ToInt16(fAl.txtYear.Text), (fAl.cbMonth.SelectedItem).ToString(), Convert.ToInt16(fAl.txtDay.Text), fAl.txtCountry.Text, fAl.txtRecordLabel.Text, fAl.txtGenre.Text, Convert.ToInt16(fAl.txtLength.Text), Convert.ToInt16(fAl.txtTracks.Text), fAl.txtArtist.Text);

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
                    albums.Add(addedAlbum);
                    lbAlbum.Items.Add(addedAlbum.Title);
                    lbAlbum.Refresh();
                }

            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                MessageBox.Show("No SQL server found, your changes cannot be saved");

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
            try
            {
                creaDataset();
            }
            catch
            {
                MessageBox.Show("In order to use this app your SQL must be active" + Environment.NewLine + "The program will now close");
                this.Close();
            }

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
                catch (MySql.Data.MySqlClient.MySqlException)
                {
                    MessageBox.Show("No SQL server found, your changes cannot be saved");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("None artist selected, please chose one");
                }
            }
            txtArtistInfoDisplay.Clear();
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
                catch (MySql.Data.MySqlClient.MySqlException)
                {
                    MessageBox.Show("No SQL server found, your changes cannot be saved");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("None album selected, please chose one");
                }
            }
            txtAlbumInfoDisplay.Clear();
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
                catch (MySql.Data.MySqlClient.MySqlException)
                {
                    MessageBox.Show("No SQL server found, your changes cannot be saved");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("None song selected, please chose one");
                }
            }
            txtSongInfoDisplay.Clear();
            lbSong.Refresh();
        }

        //Evento "Click" que muestra la información del programa
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Original idea & development by Denis Siks, 2018", "LiveDiscography Ver. 1.0");
        }

        //Evento "Click" del botón Edit Artist
        private void btnEditArtist_Click(object sender, EventArgs e)
        {
            try
            {
                Artist editedArtist;
                string editedArtistName = lbArtist.SelectedItem.ToString();
                fA.Text = "Edit Artist";
                DataRow[] artistRow = ds.Tables["Artists"].Select("Name=\'" + lbArtist.SelectedItem.ToString() + "\'");
                int editLbItemIndex = lbArtist.SelectedIndex;

                foreach (Artist eA in artists)
                {
                    if (eA.Name.Equals(editedArtistName))
                    {
                        fA.txtArName.Text = eA.Name;
                        fA.txtArGenre.Text = eA.Genre;
                        fA.txtArLabel.Text = eA.Labels;
                        fA.txtArRealName.Text = eA.RealName;
                    }
                }

                if (fA.ShowDialog() == DialogResult.OK)
                {

                    //MessageBox.Show(artistRow.Count() + "");
                    artistRow[0]["Name"] = fA.txtArName.Text;
                    artistRow[0]["Genre"] = fA.txtArGenre.Text;
                    artistRow[0]["Labels"] = fA.txtArLabel.Text;
                    artistRow[0]["RealName"] = fA.txtArRealName.Text;

                    conexion.Open();

                    objCommandBuilder = new MySqlCommandBuilder(daArtists);
                    try
                    {
                        daArtists.Update(ds, "Artists");
                    }
                    catch
                    {

                    }

                    conexion.Close();
                    editedArtist = new Artist(fA.txtArName.Text, fA.txtArGenre.Text, fA.txtArLabel.Text, fA.txtArRealName.Text);
                    artists.RemoveAt(lbArtist.SelectedIndex);
                    artists.Insert(lbArtist.SelectedIndex, editedArtist);

                    MessageBox.Show("Tamaño: " + artists.Count);
                    lbArtist.Items.RemoveAt(lbArtist.SelectedIndex);
                    lbArtist.Items.Insert(editLbItemIndex, fA.txtArName.Text);
                    lbArtist.Refresh();

                    lbArtist.SetSelected(editLbItemIndex, true);
                }
            }
            catch (System.NullReferenceException nrEx)
            {
                MessageBox.Show("None artist selected, please chose one");
            }


        }

        //Evento "Click" del botón Edit Album
        private void btnEditAlbum_Click(object sender, EventArgs e)
        {
            try
            {
                Album editedAlbum;
                string editedAlbumName = lbAlbum.SelectedItem.ToString();
                fAl.Text = "Edit Album";
                DataRow[] albumRow = ds.Tables["Albums"].Select("Title=\'" + lbAlbum.SelectedItem.ToString() + "\'");
                int editLbItemIndex = lbAlbum.SelectedIndex;

                foreach (Album eAl in albums)
                {
                    if (eAl.Title.Equals(editedAlbumName))
                    {
                        fAl.txtTitle.Text = eAl.Title;
                        fAl.txtYear.Text = eAl.ReleaseYear.ToString();
                        fAl.cbMonth.Text = eAl.ReleaseMonth;
                        fAl.txtDay.Text = eAl.ReleaseDay.ToString();
                        fAl.txtCountry.Text = eAl.ReleaseCountry;
                        fAl.txtRecordLabel.Text = eAl.RecordLabel;
                        fAl.txtGenre.Text = eAl.Genre;
                        fAl.txtLength.Text = eAl.TotalMinLength.ToString();
                        fAl.txtTracks.Text = eAl.NumberOfTracks.ToString();
                        fAl.txtArtist.Text = eAl.AlbumArtist;

                    }
                }

                if (fAl.ShowDialog() == DialogResult.OK)
                {

                    //MessageBox.Show(artistRow.Count() + "");
                    albumRow[0]["Title"] = fAl.txtTitle.Text;
                    albumRow[0]["ReleaseYear"] = fAl.txtYear.Text;
                    albumRow[0]["ReleaseMonth"] = fAl.cbMonth.SelectedItem.ToString();
                    albumRow[0]["ReleaseDay"] = fAl.txtDay.Text;
                    albumRow[0]["ReleaseCountry"] = fAl.txtCountry.Text;
                    albumRow[0]["RecordLabel"] = fAl.txtRecordLabel.Text;
                    albumRow[0]["Genre"] = fAl.txtGenre.Text;
                    albumRow[0]["TotalMinLength"] = fAl.txtLength.Text;
                    albumRow[0]["NumberOfTracks"] = fAl.txtTracks.Text;
                    albumRow[0]["AlbumArtist"] = fAl.txtArtist.Text;

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
                    editedAlbum = new Album(fAl.txtTitle.Text, Convert.ToInt32(fAl.txtYear.Text), fAl.cbMonth.SelectedItem.ToString(), Convert.ToInt32(fAl.txtDay.Text), fAl.txtCountry.Text, fAl.txtRecordLabel.Text, fAl.txtGenre.Text, Convert.ToInt32(fAl.txtLength.Text), Convert.ToInt32(fAl.txtTracks.Text), fAl.txtArtist.Text);
                    albums.RemoveAt(lbAlbum.SelectedIndex);
                    albums.Insert(lbAlbum.SelectedIndex, editedAlbum);

                    MessageBox.Show("Tamaño: " + albums.Count);
                    lbAlbum.Items.RemoveAt(lbAlbum.SelectedIndex);
                    lbAlbum.Items.Insert(editLbItemIndex, fAl.txtTitle.Text);
                    lbAlbum.Refresh();

                    lbAlbum.SetSelected(editLbItemIndex, true);
                }
            }
            catch (System.NullReferenceException nrEx)
            {
                MessageBox.Show("No album selected, please chose one");
            }
        }

        //Evento "Click" del botón Edit Song
        private void btnEditSong_Click(object sender, EventArgs e)
        {
            try
            {
                Song editedSong;
                string editedSongName = lbSong.SelectedItem.ToString();
                fS.Text = "Edit Song";
                DataRow[] songRow = ds.Tables["Songs"].Select("Name=\'" + lbSong.SelectedItem.ToString() + "\'");
                int editLbItemIndex = lbSong.SelectedIndex;

                foreach (Song eS in songs)
                {
                    if (eS.SongName.Equals(editedSongName))
                    {
                        fS.txtTitle.Text = eS.SongName;
                        fS.txtAlbum.Text = eS.SongAlbum;
                        fS.txtArtist.Text = eS.SongArtist;
                        fS.txtLenMin.Text = eS.MinLength.ToString();
                        fS.txtLenSec.Text = eS.SecLength.ToString();
                        fS.txtGenre.Text = eS.Genre;

                    }
                }

                if (fS.ShowDialog() == DialogResult.OK)
                {

                    //MessageBox.Show(artistRow.Count() + "");
                    songRow[0]["Name"] = fS.txtTitle.Text;
                    songRow[0]["Album"] = fS.txtAlbum.Text;
                    songRow[0]["Artist"] = fS.txtArtist.Text;
                    songRow[0]["MinLength"] = fS.txtLenMin.Text;
                    songRow[0]["SecLength"] = fS.txtLenSec.Text;
                    songRow[0]["Genre"] = fS.txtGenre.Text;

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
                    editedSong = new Song(fS.txtTitle.Text, fS.txtAlbum.Text, fS.txtArtist.Text, Convert.ToInt16(fS.txtLenMin.Text), Convert.ToInt16(fS.txtLenSec.Text), fS.txtGenre.Text);
                    songs.RemoveAt(lbSong.SelectedIndex);
                    songs.Insert(lbSong.SelectedIndex, editedSong);

                    MessageBox.Show("Tamaño: " + songs.Count);
                    lbSong.Items.RemoveAt(lbSong.SelectedIndex);
                    lbSong.Items.Insert(editLbItemIndex, fS.txtTitle.Text);
                    lbSong.Refresh();

                    lbSong.SetSelected(editLbItemIndex, true);
                }
            }
            catch (System.NullReferenceException nrEx)
            {
                MessageBox.Show("No song selected, please chose one");
            }
        }

        //Evento "Click" del botón Search>Songs per album
        private void songsPerAlbumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fSs.searchSongs = songs;
            fSs.searchAlbums = albums;
            fSs.searchArtists = artists;
            fSs.txtSearch.Clear();
            fSs.lbSearchItem.Items.Clear();
            fSs.lblFoundElements.Visible = false;
            if (fSs.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
