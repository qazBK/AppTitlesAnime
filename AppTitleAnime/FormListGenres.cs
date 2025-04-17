using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Data;
using AppContext = AppTitleAnime.Models.AppContext;
using Genre = AppTitleAnime.Models.Genre;


namespace AppTitleAnime
{
    public partial class FormListGenres : Form
    {
        private AppContext db;
        public FormListGenres()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.Genres.Load();
            this.dateGridViewGenres.DataSource = this.db.Genres.Local.OrderBy(o => o.GenreAnime).ToList();

            //Скрытие столбцов
            dateGridViewGenres.Columns["id"].Visible = false;
            dateGridViewGenres.Columns["TitlesGenres"].Visible = false;

            //Изменение названий
            dateGridViewGenres.Columns["GenreAnime"].HeaderText = "Жанр аниме";
        }
        protected override void OnClosing(CancelEventArgs e)
        {

            base.OnClosing(e);
            this.db?.Dispose();
            this.db = null;
        }
        private void BtAddGenre_Click(object sender, EventArgs e)
        {
            FormAddGenre formAddGenre = new FormAddGenre();
            DialogResult = formAddGenre.ShowDialog();

            if (DialogResult == DialogResult.Cancel) // чек позже result
                return;
            Genre genre = new Genre();
            genre.GenreAnime = formAddGenre.textBoxGenre.Text;

            db.Genres.Add(genre);
            db.SaveChanges();

            MessageBox.Show("Новый жанр добавлен");
            this.dateGridViewGenres.DataSource = this.db.Genres.Local.OrderBy(o => o.GenreAnime).ToList();
        }

        private void BtUpdateGenre_Click(object sender, EventArgs e)
        {
            if (dateGridViewGenres.SelectedRows.Count == 0)
                return;

            int index = dateGridViewGenres.SelectedRows[0].Index;

            short id = 0;
            bool converted = Int16.TryParse(dateGridViewGenres[0, index].Value.ToString(), out id);
            if (!converted)
                return;




            Genre genre = db.Genres.Find(id);
            FormAddGenre formAddGenre = new();
            formAddGenre.textBoxGenre.Text = genre.GenreAnime;

            DialogResult result = formAddGenre.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            genre.GenreAnime = formAddGenre.textBoxGenre.Text;
            db.Genres.Update(genre);
            db.SaveChanges();

            MessageBox.Show("Жанр изменён");

            this.dateGridViewGenres.DataSource = this.db.Genres.Local.OrderBy(o => o.GenreAnime).ToList();
        }

        private void BtDeleteGenre_Click(object sender, EventArgs e)
        {
            if (dateGridViewGenres.SelectedRows.Count == 0)
                return;
            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите удалить объект? \nВсе связаные данные будут удалены",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (result == DialogResult.No)
                return;

            int index = dateGridViewGenres.SelectedRows[0].Index;

            short id = 0;
            bool converted = Int16.TryParse(dateGridViewGenres[0, index].Value.ToString(), out id);
            if (!converted)
                return;
            Genre gener = db.Genres.Find(id);

            db.Genres.Remove(gener);
            db.SaveChanges();

            MessageBox.Show("Жанр удалён");
            this.dateGridViewGenres.DataSource = this.db.Genres.OrderBy(o => o.GenreAnime).ToList();
        }
    }
}
