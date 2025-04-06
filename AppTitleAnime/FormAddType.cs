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
    public partial class FormAddType : Form
    {
        public FormAddType()
        {
            InitializeComponent();
        }

        private void TextBoxType_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxType.Text))
            {
                errorProvider.SetError(textBoxType, "Поле не может быть пустым!");
                btSaveChenges.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                btSaveChenges.Enabled = true;

            }

        }

        private void textBoxType_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxType.Text))
            {
                errorProvider.SetError(textBoxType, "Поле не может быть пустым!");
                btSaveChenges.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                btSaveChenges.Enabled = true;

            }
        }
    }
}
