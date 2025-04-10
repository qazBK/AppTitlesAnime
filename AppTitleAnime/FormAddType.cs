using System.ComponentModel;

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

        private void FormAddType_Load(object sender, EventArgs e)
        {

        }

        private void btSaveChenges_Click(object sender, EventArgs e)
        {

        }
    }
}
