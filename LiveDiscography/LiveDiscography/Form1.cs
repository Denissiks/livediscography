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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FormArtist fA=new FormArtist();
        Artist addedArtist;
        ArrayList artists=new ArrayList();
        int i ;
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            if (fA.ShowDialog()==DialogResult.OK)
            {
                addedArtist = new Artist(fA.txtArName.Text,(String)fA.cbArGenre.SelectedItem,fA.txtArLabel.Text, fA.txtArRealName.Text);
                artists.Add(addedArtist);
                lbArtist.Items.Add(addedArtist.Name);
                lbArtist.Refresh();
            }
        }

        private void lbArtist_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (i= 0; i < artists.Count; i++)
            {
                if (lbArtist.SelectedIndex.Equals(i))
                {
                    txtArtistInfoDisplay.Text = ((Artist)artists[i]).Name + "\n" + ((Artist)artists[i]).Genre + "\n" + ((Artist)artists[i]).Labels + "\n" + ((Artist)artists[i]).RealName;
                }
            }

            foreach(Artist a in artists)
            {
                 
            }
        }
    }
}
