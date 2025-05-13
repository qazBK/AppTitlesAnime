using System.ComponentModel;
using AppContext = AppTitleAnime.Models.AppContext;
namespace AppTitleAnime
{
    public partial class FormAddUpdateStatus : Form
    {
        private AppContext db;
        public FormAddUpdateStatus()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();

        }
        private void BtSaveChenges_Click(object sender, EventArgs e)
        {

        }

        private void textBoxStatuse_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxStatuse.Text))//если поле пустое
            {
                errorProvider.SetError(textBoxStatuse, "Поле не может быть пустым!");
                btSaveChenges.Enabled = false;
            }
            else
            {
                errorProvider.Clear();
                btSaveChenges.Enabled = true;//пропускаем

            }
            FormAddUpdateStatus formAddStatus = new FormAddUpdateStatus();
            string newStatusAnime = textBoxStatuse.Text;//сохраняем текст в newStatusAnime

            bool exists = db.Statuses.Any(t => t.StatusAnime == newStatusAnime);//.ToLower()
            //сраваниваем newStatusAnime с бд если есть совпадения то true
            bool exists2 = db.Statuses.Any(t=>t.StatusAnime == newStatusAnime);


            if (exists)
            {
                btSaveChenges.Enabled = false;//уходим в ошибку 
                errorProvider.SetError(textBoxStatuse, "Поле должно быть уникальным");

            }
            else
            {
                errorProvider.Clear();
                btSaveChenges.Enabled = true;//пропускаем

            }
        }

        private void textBoxStatuse_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxStatuse.Text))//если поле пустое
            {
                errorProvider.SetError(textBoxStatuse, "Поле не может быть пустым!");
                btSaveChenges.Enabled = false;//уходим в ошибку 
            }
            else
            {
                errorProvider.Clear();
                btSaveChenges.Enabled = true;//пропускаем

            }
        }
    }
}
