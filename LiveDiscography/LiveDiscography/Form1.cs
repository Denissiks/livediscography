using System;
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

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAddArtist_Click(object sender, EventArgs e)
        {
            if (fA.ShowDialog()==DialogResult.OK)
            {
                addedArtist = new Artist(fA.txtArName.Text,(String)fA.cbArGenre.SelectedItem,fA.txtArLabel.Text, fA.txtArName.Text);
                
            }
        }
    }
}
