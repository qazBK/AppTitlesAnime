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
    public partial class FormAddGenre : Form
    {
        public FormAddGenre()
        {
            InitializeComponent();
        }

        private void textBoxType_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormAddGenre_Load(object sender, EventArgs e)
        {

        }

        private void TextBoxGenre_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxGenre.Text))
            {
                errorProvider.SetError(textBoxGenre, "Поле не может быть пустым!");
                btSaveChenges.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                btSaveChenges.Enabled = true;

            }
        }

        private void panelFill_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
