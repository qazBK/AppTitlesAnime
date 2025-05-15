using System.ComponentModel;
using AppContext = AppTitleAnime.Models_2.AppContext;
namespace AppTitleAnime
{
    public partial class FormAddUpdateGenre : Form
    {   
        private AppContext db;
        public FormAddUpdateGenre()
        {
            InitializeComponent();
        }
        
       
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();

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

            FormAddUpdateGenre formAddGenre = new FormAddUpdateGenre();
            string newGenreAnime = textBoxGenre.Text;

            bool exists = db.Genres.Any(t => t.GenreAnime == newGenreAnime);//.ToLower()




            if (exists)
            {
                btSaveChenges.Enabled = false;
                errorProvider.SetError(textBoxGenre, "Поле должно быть уникальным");

            }
            else
            {
                errorProvider.Clear();
                btSaveChenges.Enabled = true;

            }
        }

        private void textBoxGenre_TextChanged(object sender, EventArgs e)
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
