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

namespace LiveDiscography
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FormArtist fA = new FormArtist();
        FormAlbum fAl = new FormAlbum();
        FormSong fS = new FormSong();
        Artist addedArtist;
        Song addedSong;
        ArrayList artists = new ArrayList();
        ArrayList songs = new ArrayList();
        int i;

        FileStream fs;
        BinaryWriter bw;
        BinaryReader br;

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            if (fA.ShowDialog() == DialogResult.OK)
            {
                if (artists.Contains(fA.Name))
                {

                }
                else
                {
                    addedArtist = new Artist(fA.txtArName.Text, fA.txtArGenre.Text, fA.txtArLabel.Text, fA.txtArRealName.Text);
                    artists.Add(addedArtist);
                    lbArtist.Items.Add(addedArtist.Name);
                }
                
                lbArtist.Refresh();
                this.writeFile();
            }
        }

        private void lbArtist_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (i = 0; i < artists.Count; i++)
            {

                if (lbArtist.SelectedIndex.Equals(i))
                {
                    
                    
                        txtArtistInfoDisplay.Text = ((Artist)artists[i]).Name + "\n" + ((Artist)artists[i]).Genre + "\n" + ((Artist)artists[i]).Labels + "\n" + ((Artist)artists[i]).RealName;
                    

                }



            }

            foreach (Artist a in artists)
            {

            }
        }

        private void btnAddSong_Click(object sender, EventArgs e)
        {
            if (fS.ShowDialog() == DialogResult.OK)
            {
                if (songs.Contains(fA.Name))
                {

                }
                else
                {
                    //addedArtist = new Artist(fA.txtArName.Text, fA.txtArGenre.Text, fA.txtArLabel.Text, fA.txtArRealName.Text);
                    //artists.Add(addedArtist);
                    //lbArtist.Items.Add(addedArtist.Name);
                }

                lbArtist.Refresh();
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
                    //addedArtist = new Artist(fA.txtArName.Text, fA.txtArGenre.Text, fA.txtArLabel.Text, fA.txtArRealName.Text);
                    //artists.Add(addedArtist);
                    //lbArtist.Items.Add(addedArtist.Name);
                }

                lbArtist.Refresh();
            }
        }

        private void writeFile()
        {
            try
            {
                fs = new FileStream("C:\\Users\\Usuario\\artistData.bin", FileMode.OpenOrCreate, FileAccess.Write);
                bw = new BinaryWriter(fs);

                for(i=0; i<artists.Count; i++)
                {
                    bw.Write("Prueba"+(i+1));
                }
                bw.Close();
                fs.Close();
            }
            catch
            {
                MessageBox.Show("Imposible guardar", "Error detectado",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

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

            }
        }
    }
}
