using System.ComponentModel;
using AppContext = AppTitleAnime.Models.AppContext;

namespace AppTitleAnime
{
    public partial class FormAddType : Form
    {
        private AppContext db;
        public FormAddType()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            
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
            FormAddType formAddType = new FormAddType();
            string newTypeAnime = textBoxType.Text;

            bool exists = db.Types.Any(t => t.TypeAnime == newTypeAnime);//.ToLower()



            if (exists)
            {
                btSaveChenges.Enabled = false;
                errorProvider.SetError(textBoxType, "Поле должно быть уникальным");

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
