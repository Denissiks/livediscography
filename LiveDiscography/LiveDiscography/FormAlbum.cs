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
    public partial class FormAlbum : Form
    {
        public FormAlbum()
        {
            InitializeComponent();
        }

        eMonth mes;
        String[] meses=new String[13];
        

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void FormAlbum_Load(object sender, EventArgs e)
        {
            
            for(int i=0;i<13;i++)
            {
                cbMonth.Items.Add(mes[i]);
            }
            
            this.Refresh();
        }
    }
}
