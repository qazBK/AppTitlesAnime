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
            FormListGenres formListGenre = new FormListGenres();
            formListGenre.Show();
        }

        private void ButnShowStatuse_Click(object sender, EventArgs e)
        {
            FormListStatuses formListStatuse = new FormListStatuses();
            formListStatuse.Show();
        }
    }
}
