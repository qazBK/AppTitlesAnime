using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Data;
using AppContext = AppTitleAnime.Models.AppContext;
using Status = AppTitleAnime.Models.Status;

namespace AppTitleAnime
{
    public partial class FormListStatuses : Form
    {
        private AppContext db;
        public FormListStatuses()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.db = new AppContext(); 
            this.db.Statuses.Load();//прогружаем таблицук Statuses
            this.dateGridViewStatuses.DataSource = this.db.Statuses.Local.OrderBy(o => o.StatusAnime).ToList();//вывод таблтци

            //Скрытие столбцов
            dateGridViewStatuses.Columns["id"].Visible = false;
            dateGridViewStatuses.Columns["TitlesStatuses"].Visible = false;

            //Изменение названий
            dateGridViewStatuses.Columns["StatusAnime"].HeaderText = "Статус аниме";
        }
        protected override void OnClosing(CancelEventArgs e)
        {

            base.OnClosing(e);
            this.db?.Dispose();
            this.db = null;
        }

        private void BtAddStatuse_Click(object sender, EventArgs e)
        {
            FormAddUpdateStatus formAddStatuse = new FormAddUpdateStatus();//создаём новый объект формы 
            DialogResult = formAddStatuse.ShowDialog();

            if (DialogResult == DialogResult.Cancel) //выход если окно закрыли
                return;
            Status status = new Status(); //создоём новый статус
            status.StatusAnime = formAddStatuse.textBoxStatuse.Text;//закладываем текст из textBoxStatuse в  status

            db.Statuses.Add(status);//добовляем статус
            db.SaveChanges();//запоминаем

            MessageBox.Show("Новый статус добавлен");
            this.dateGridViewStatuses.DataSource = this.db.Statuses.Local.OrderBy(o => o.StatusAnime).ToList();//вывод тблтци
        }
        private void BtUpdateStatuse_Click(object sender, EventArgs e)
        {
            if (dateGridViewStatuses.SelectedRows.Count == 0)//проверяем выброно ли поле для изменения если нет заканчиваем
                return;

            int index = dateGridViewStatuses.SelectedRows[0].Index; //получаем индекс поля 

            short id = 0;
            bool converted = Int16.TryParse(dateGridViewStatuses[0, index].Value.ToString(), out id); //конвертируем  index поля в тип short и сохроняем в id
            if (!converted)//если не сконвертировали заканчиваем
                return;

            Status status = db.Statuses.Find(id);//ищим поле с таким id
            FormAddUpdateStatus formAddStatuse = new();//cоздается новый экземпляр формы 
            formAddStatuse.textBoxStatuse.Text = status.StatusAnime;//выводим в текстовое поле садержимое status.

            DialogResult result = formAddStatuse.ShowDialog(this); //запоминаем нажатую кнопку 

            if (result == DialogResult.Cancel)//если нажали Cancel заканчиваем
                return;
                                                //иначе
            status.StatusAnime = formAddStatuse.textBoxStatuse.Text;//заменяем статус на новый из textBoxStatuse.
            db.Statuses.Update(status);//обновляем 
            db.SaveChanges();//запоминаем

            MessageBox.Show("Статус изменён");

            this.dateGridViewStatuses.DataSource = this.db.Statuses.Local.OrderBy(o => o.StatusAnime).ToList();//вывод тблтци
        }

        private void BtDeleteStatuse_Click(object sender, EventArgs e)
        {
        



            if (dateGridViewStatuses.SelectedRows.Count == 0)//проверяем выброно ли поле для удаления если нет заканчиваем
                return;
            DialogResult result = MessageBox.Show(
                "Вы уверены, что хотите удалить объект? \nВсе связаные данные будут удалены",
                "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );
            if (result == DialogResult.No)//если нажали no зака=ниваем
                return;
                                        //иначе
            int index = dateGridViewStatuses.SelectedRows[0].Index;//получаем индекс поля 

            short id = 0;
            bool converted = Int16.TryParse(dateGridViewStatuses[0, index].Value.ToString(), out id);//конвертируем  index поля в тип short и сохроняем в id
            if (!converted)//если не сконвертировали заканчиваем
                return;
            Status status = db.Statuses.Find(id);//ищим поле с таким id

            db.Statuses.Remove(status);//удаляем
            db.SaveChanges();//запоминаем

            MessageBox.Show("Статус удалён");

            this.dateGridViewStatuses.DataSource = this.db.Statuses.Local.OrderBy(o => o.StatusAnime).ToList();//вывод тблтци
        }
    }
}
