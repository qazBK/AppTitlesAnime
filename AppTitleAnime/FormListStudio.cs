using Microsoft.EntityFrameworkCore;
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
            dateGridViewStudio.Columns["TypeAnime"].HeaderText = "Тип аниме";


        }

        private void btAddStudio_Click(object sender, EventArgs e)
        {

        }
    }
}
