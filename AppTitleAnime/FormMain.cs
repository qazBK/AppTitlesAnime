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
    }
}
