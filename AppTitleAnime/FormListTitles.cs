using System.ComponentModel;
using System.Data;
using AppTitleAnime.Models_2;
using Microsoft.EntityFrameworkCore;
using AnimeTitle = AppTitleAnime.Models_2.AnimeTitle;
using AppContext = AppTitleAnime.Models_2.AppContext;
using Type = AppTitleAnime.Models_2.Type;
using Studio = AppTitleAnime.Models_2.Studio;
namespace AppTitleAnime
{
    public partial class FormListTitles : Form
    {
        private AppContext db;
        public FormListTitles()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.AnimeTitles.Load();
            LoadTitlesAnime();

            //Скрытие столбцов
            dateGridViewTitles.Columns["id"].Visible = false;

            //Изменение названий
            dateGridViewTitles.Columns["TypeAnime"].HeaderText = "Тип";
            dateGridViewTitles.Columns["OriginalName"].HeaderText = "Оригинальное название";
            dateGridViewTitles.Columns["Name"].HeaderText = "Тайтел";
            dateGridViewTitles.Columns["CountSeries"].HeaderText = "Кол-во эпизодов";
            dateGridViewTitles.Columns["Duration"].HeaderText = "Продолжительность";
            dateGridViewTitles.Columns["AnimeStudio"].HeaderText = "Студия";
        }
        protected override void OnClosing(CancelEventArgs e)
        {

            
            this.db?.Dispose();
            this.db = null;
        }
        private void BtAddTitle_Click(object sender, EventArgs e)
        {
            FormAddUpdateTitle formAddUpdateTitle = new FormAddUpdateTitle();

            this.db.Types.Load();
            List<Type> types = this.db.Types.Local.OrderBy(o => o.TypeAnime).ToList();
            formAddUpdateTitle.comboBoxType.DataSource = types;
            formAddUpdateTitle.comboBoxType.DisplayMember = "TypeAnime";
            formAddUpdateTitle.comboBoxType.ValueMember = "id";

            /*--------------------------------*/
            

            this.db.Studios.Load();
            List<Studio> studios = this.db.Studios.Local.OrderBy(o => o.AnimeStudio).ToList();
            formAddUpdateTitle.comboBoxStudio.DataSource = studios;
            formAddUpdateTitle.comboBoxStudio.DisplayMember = "AnimeStudio";
            formAddUpdateTitle.comboBoxStudio.ValueMember = "id";
            /*----------------------------------*/
            DialogResult = formAddUpdateTitle.ShowDialog();

            if (DialogResult == DialogResult.Cancel)
                return;

            AnimeTitle animeTitle = new()
            {
                OriginalName = formAddUpdateTitle.textBoxOriginalName.Text,
                Name = formAddUpdateTitle.textBoxName.Text,
                CountSeries = Convert.ToInt16(formAddUpdateTitle.numUpDownCountSerias.Value),
                Duration = Convert.ToInt16(formAddUpdateTitle.numericUpDownDuration.Value),
                //Studio = formAddUpdateTitle.textBoxStudio.Text,
                Description = formAddUpdateTitle.textBoxDescription.Text

            };
            Type type = (Type)formAddUpdateTitle.comboBoxType.SelectedItem;
            animeTitle.IdType = type.Id;
            db.AnimeTitles.Add(animeTitle);
            /*------------------------*/
            Studio studio = (Studio)formAddUpdateTitle.comboBoxStudio.SelectedItem;
            animeTitle.IdStudio = studio.Id;
            db.AnimeTitles.Add(animeTitle);
            /*----------------------------*/
            db.SaveChanges();

            MessageBox.Show("Новый объект добавлен", "",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadTitlesAnime();
        }

        private void BtUpdateTitle_Click(object sender, EventArgs e)
        {
            if (dateGridViewTitles.SelectedRows.Count == 0)
                return;

            int index = dateGridViewTitles.SelectedRows[0].Index;

            int id = 0;
            bool converted = Int32.TryParse(dateGridViewTitles[0, index].Value.ToString(), out id);
            if (!converted)
                return;

            AnimeTitle animeTitle = db.AnimeTitles.Find(id);

            FormAddUpdateTitle formAddUpdateTitle = new();
            formAddUpdateTitle.textBoxName.Text = animeTitle.OriginalName;
            formAddUpdateTitle.textBoxOriginalName.Text = animeTitle.Name;
            formAddUpdateTitle.numUpDownCountSerias.Value = animeTitle.CountSeries;
            formAddUpdateTitle.numericUpDownDuration.Value = animeTitle.Duration;
           // formAddUpdateTitle.textBoxStudio.Text = animeTitle.Studio;
            formAddUpdateTitle.textBoxDescription.Text = animeTitle.Description;

            this.db.Types.Load();
            List<Type> types = this.db.Types.Local.OrderBy(o => o.TypeAnime).ToList();
            formAddUpdateTitle.comboBoxType.DataSource = types;
            formAddUpdateTitle.comboBoxType.DisplayMember = "TypeAnime";
            formAddUpdateTitle.comboBoxType.ValueMember = "id";
            formAddUpdateTitle.comboBoxType.SelectedItem = animeTitle.Type;

            ///////////////////////////////
            this.db.Studios.Load();
            List<Studio> studios = this.db.Studios.Local.OrderBy(o => o.AnimeStudio).ToList();
            formAddUpdateTitle.comboBoxStudio.DataSource = studios;
            formAddUpdateTitle.comboBoxStudio.DisplayMember = "AnimeStudio";
            formAddUpdateTitle.comboBoxStudio.ValueMember = "id";
            formAddUpdateTitle.comboBoxStudio.SelectedItem = animeTitle.Studio;
            ////////////////////

            DialogResult result = formAddUpdateTitle.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;


            animeTitle.OriginalName = formAddUpdateTitle.textBoxOriginalName.Text;
            animeTitle.Name = formAddUpdateTitle.textBoxName.Text;
            animeTitle.CountSeries = Convert.ToInt16(formAddUpdateTitle.numUpDownCountSerias.Value);
            animeTitle.Duration = Convert.ToInt16(formAddUpdateTitle.numericUpDownDuration.Value);
           // animeTitle.Studio = formAddUpdateTitle.textBoxStudio.Text;
            animeTitle.Description = formAddUpdateTitle.textBoxDescription.Text;


            Type type = (Type)formAddUpdateTitle.comboBoxType.SelectedItem;
            animeTitle.IdType = type.Id;
            db.AnimeTitles.Update(animeTitle);


            ///

            Studio studio = (Studio)formAddUpdateTitle.comboBoxStudio.SelectedItem;
            animeTitle.IdStudio = studio.Id;
            db.AnimeTitles.Update(animeTitle);
            /////
            db.SaveChanges();
            MessageBox.Show("Объект изменён", "",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadTitlesAnime();
        }

        private void BtDeleteTitle_Click(object sender, EventArgs e)
        {
            if (dateGridViewTitles.SelectedRows.Count == 0)
                return;
            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите удалить объект? \nВсе связаные данные будут удалены",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (result == DialogResult.No)
                return;
            int index = dateGridViewTitles.SelectedRows[0].Index;

            int id = 0;
            bool converted = Int32.TryParse(dateGridViewTitles[0, index].Value.ToString(), out id);
            if (!converted)
                return;

            AnimeTitle animeTitle = db.AnimeTitles.Find(id);

            

            db.AnimeTitles.Remove(animeTitle);
            db.SaveChanges();

            MessageBox.Show("Объект удалён",
                "",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            LoadTitlesAnime();
        }
        private void LoadTitlesAnime()
        {
            this.dateGridViewTitles.DataSource = this.db.AnimeTitles.
              Include(o => o.Type).
              Select(o => new
              {
                  o.Id,
                  o.Type.TypeAnime,
                  o.OriginalName,
                  o.Name,
                  o.CountSeries,
                  o.Duration,
                  o.Studio.AnimeStudio
              }).
              OrderBy(o => o.TypeAnime).ThenBy(o => o.OriginalName).
              ToList();
        }
    }
}
