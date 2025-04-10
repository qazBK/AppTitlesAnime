namespace AppTitleAnime
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void ButnShowTypes_Click(object sender, EventArgs e)
        {
            FormListTypes formmlisiTypes = new FormListTypes();
            formmlisiTypes.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ButnShowGenre_Click(object sender, EventArgs e)
        {
            FormListGenre formListGenre = new FormListGenre();
            formListGenre.Show();
        }
    }
}
