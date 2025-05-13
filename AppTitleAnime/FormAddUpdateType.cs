using System.ComponentModel;
using AppContext = AppTitleAnime.Models_2.AppContext;

namespace AppTitleAnime
{
    public partial class FormAddUpdateType : Form
    {
        private AppContext db;
        public FormAddUpdateType()
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
            FormAddUpdateType formAddType = new FormAddUpdateType();
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
