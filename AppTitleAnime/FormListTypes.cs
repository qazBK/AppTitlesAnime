using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTitleAnime
{
    public partial class FormListTypes : Form
    {
        public FormListTypes()
        {
            InitializeComponent();
        }

        private void btDeletType_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ryy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtAddType_Click(object sender, EventArgs e)
        {
            FormAddType formAddType = new FormAddType();
            formAddType.ShowDialog();
        }
    }
}
