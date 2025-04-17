using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Data;
using AppContext = AppTitleAnime.Models.AppContext;
using Type = AppTitleAnime.Models.Type;

namespace AppTitleAnime
{
    public partial class FormListTypes : Form
    {
        private AppContext db;
        public FormListTypes()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext();
            this.db.Types.Load();
            this.dateGridViewTypes.DataSource = this.db.Types.Local.OrderBy(o => o.TypeAnime).ToList();


            //Скрытие столбцов
            dateGridViewTypes.Columns["id"].Visible = false;
            dateGridViewTypes.Columns["AnimeTitles"].Visible = false;

            //Изменение названий
            dateGridViewTypes.Columns["TypeAnime"].HeaderText = "Тип аниме";


        }

        protected override void OnClosing(CancelEventArgs e)
        {

            base.OnClosing(e);
            this.db?.Dispose();
            this.db = null;
        }


        

        private void BtAddType_Click(object sender, EventArgs e)
        {
            FormAddType formAddType = new FormAddType();
            DialogResult = formAddType.ShowDialog();

            if (DialogResult == DialogResult.Cancel) // чек позже result
                return;
          /*  ///////////////////////////
            string newTypeAnime = formAddType.textBoxType.Text;


            bool exists = db.Types.Any(t => t.TypeAnime == newTypeAnime);


            if (exists)
            {
                MessageBox.Show("Запись с таким типом аниме уже существует.");
                return;
            }
            //////////////////////////////////*/
            Type type = new Type();
            type.TypeAnime = formAddType.textBoxType.Text;

            db.Types.Add(type);
            db.SaveChanges();

            MessageBox.Show("Новый объект добавлен");
            this.dateGridViewTypes.DataSource = this.db.Types.Local.OrderBy(o => o.TypeAnime).ToList();



        }

        private void BtUpdateType_Click(object sender, EventArgs e)
        {
            if (dateGridViewTypes.SelectedRows.Count == 0)
                return;

            int index = dateGridViewTypes.SelectedRows[0].Index;

            short id = 0;
            bool converted = Int16.TryParse(dateGridViewTypes[0, index].Value.ToString(), out id);
            if (!converted)
                return;




            Type type = db.Types.Find(id);
            FormAddType formAddType = new();
            formAddType.textBoxType.Text = type.TypeAnime;

            DialogResult result = formAddType.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

           /* //////////////////
            string newTypeAnime = formAddType.textBoxType.Text;


            bool exists = db.Types.Any(t => t.TypeAnime == newTypeAnime);


            if (exists)
            {
                MessageBox.Show("Запись с таким типом аниме уже существует.");
                return;
            }
            ///////////////*/
            type.TypeAnime = formAddType.textBoxType.Text;
            db.Types.Update(type);
            db.SaveChanges();

            MessageBox.Show("Объект изменён");

            this.dateGridViewTypes.DataSource = this.db.Types.OrderBy(o => o.TypeAnime).ToList();


        }

        private void BtDeleteType_Click(object sender, EventArgs e)
        {
            if (dateGridViewTypes.SelectedRows.Count == 0)
                return;
            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите удалить объект? \nВсе связаные данные будут удалены",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (result == DialogResult.No)
                return;

            int index = dateGridViewTypes.SelectedRows[0].Index;

            short id = 0;
            bool converted = Int16.TryParse(dateGridViewTypes[0, index].Value.ToString(), out id);
            if (!converted)
                return;
            Type type = db.Types.Find(id);

            db.Types.Remove(type);
            db.SaveChanges();

            MessageBox.Show("Объект удалён");

            this.dateGridViewTypes.DataSource = this.db.Types.OrderBy(o => o.TypeAnime).ToList();

        }

        
    }
}
