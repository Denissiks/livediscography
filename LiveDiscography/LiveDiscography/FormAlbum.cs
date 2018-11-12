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
    public partial class FormAlbum : Form
    {


        public FormAlbum()
        {
            InitializeComponent();

        }


        String[] meses = new String[12] {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };




        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void FormAlbum_Load(object sender, EventArgs e)
        {         

            cbMonth.DataSource = meses;
          
            this.Refresh();
        }
    }
}
