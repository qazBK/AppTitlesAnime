using System.ComponentModel;

namespace AppTitleAnime
{
    public partial class FormAddGenre : Form
    {
        public FormAddGenre()
        {
            InitializeComponent();
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
    }
}
