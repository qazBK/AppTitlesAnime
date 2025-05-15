using AppTitleAnime.Models_2;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppContext = AppTitleAnime.Models_2.AppContext;
using Studio = AppTitleAnime.Models_2.Studio;
namespace AppTitleAnime
{
    public partial class FormListStudio : Form
    {
        private AppContext db;

        public FormListStudio()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.Studios.Load();
            this.dateGridViewStudio.DataSource = this.db.Studios.Local.OrderBy(o => o.AnimeStudio).ToList();


            //Скрытие столбцов
            dateGridViewStudio.Columns["id"].Visible = false;
            dateGridViewStudio.Columns["AnimeTitles"].Visible = false;

            //Изменение названий
            dateGridViewStudio.Columns["AnimeStudio"].HeaderText = "Студия";


        }
        protected override void OnClosing(CancelEventArgs e)
        {

            base.OnClosing(e);
            this.db?.Dispose();
            this.db = null;
        }
        private void btAddStudio_Click(object sender, EventArgs e)
        {
            FormAddUpdateStudio formAddStudio = new FormAddUpdateStudio();
            DialogResult = formAddStudio.ShowDialog();

            if (DialogResult == DialogResult.Cancel)
                return;
            Studio studio = new Studio();
            studio.AnimeStudio = formAddStudio.textBoxStudio.Text;

            db.Studios.Add(studio);
            db.SaveChanges();

            MessageBox.Show("Новый объект добавлен");
            this.dateGridViewStudio.DataSource = this.db.Studios.Local.OrderBy(o => o.AnimeStudio).ToList();
        }

        private void btUpdateStudio_Click(object sender, EventArgs e)
        {
            if (dateGridViewStudio.SelectedRows.Count == 0)
                return;

            int index = dateGridViewStudio.SelectedRows[0].Index;

            short id = 0;
            bool converted = Int16.TryParse(dateGridViewStudio[0, index].Value.ToString(), out id);
            if (!converted)
                return;

            Studio studio = db.Studios.Find(id);
            FormAddUpdateStudio formAddStudio = new();
            formAddStudio.textBoxStudio.Text = studio.AnimeStudio;



            DialogResult result = formAddStudio.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;


            studio.AnimeStudio = formAddStudio.textBoxStudio.Text;

            db.Studios.Update(studio);
            db.SaveChanges();

            MessageBox.Show("Объект изменён");
            this.dateGridViewStudio.DataSource = this.db.Studios.Local.OrderBy(o => o.AnimeStudio).ToList();
        }

        private void btDeleteStudio_Click(object sender, EventArgs e)
        {
            if (dateGridViewStudio.SelectedRows.Count == 0)
                return;
            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите удалить объект? \nВсе связаные данные будут удалены",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (result == DialogResult.No)
                return;

            int index = dateGridViewStudio.SelectedRows[0].Index;

            short id = 0;
            bool converted = Int16.TryParse(dateGridViewStudio[0, index].Value.ToString(), out id);
            if (!converted)
                return;


            Studio studio = db.Studios.Find(id);

            db.Studios.Remove(studio);
            db.SaveChanges();

            MessageBox.Show("Объект удалён");
            this.dateGridViewStudio.DataSource = this.db.Studios.Local.OrderBy(o => o.AnimeStudio).ToList();
        }
    }
}
