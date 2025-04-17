namespace AppTitleAnime
{
    partial class FormListGenres
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            flowLayoutPanelTop = new FlowLayoutPanel();
            btAddGenre = new Button();
            btUpdateGenre = new Button();
            btDeleteGenre = new Button();
            PanelFill = new Panel();
            dateGridViewGenres = new DataGridView();
            errorProvider = new ErrorProvider(components);
            flowLayoutPanelTop.SuspendLayout();
            PanelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dateGridViewGenres).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelTop
            // 
            flowLayoutPanelTop.AutoSize = true;
            flowLayoutPanelTop.BackColor = Color.DarkSlateBlue;
            flowLayoutPanelTop.Controls.Add(btAddGenre);
            flowLayoutPanelTop.Controls.Add(btUpdateGenre);
            flowLayoutPanelTop.Controls.Add(btDeleteGenre);
            flowLayoutPanelTop.Dock = DockStyle.Top;
            flowLayoutPanelTop.Location = new Point(0, 0);
            flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            flowLayoutPanelTop.Padding = new Padding(10);
            flowLayoutPanelTop.Size = new Size(934, 61);
            flowLayoutPanelTop.TabIndex = 5;
            // 
            // btAddGenre
            // 
            btAddGenre.AutoSize = true;
            btAddGenre.BackColor = Color.SlateBlue;
            btAddGenre.ForeColor = Color.White;
            btAddGenre.Location = new Point(13, 13);
            btAddGenre.Name = "btAddGenre";
            btAddGenre.Size = new Size(106, 35);
            btAddGenre.TabIndex = 0;
            btAddGenre.Text = "Добавить";
            btAddGenre.UseVisualStyleBackColor = false;
            btAddGenre.Click += BtAddGenre_Click;
            // 
            // btUpdateGenre
            // 
            btUpdateGenre.AutoSize = true;
            btUpdateGenre.BackColor = Color.SlateBlue;
            btUpdateGenre.ForeColor = Color.White;
            btUpdateGenre.Location = new Point(125, 13);
            btUpdateGenre.Name = "btUpdateGenre";
            btUpdateGenre.Size = new Size(107, 35);
            btUpdateGenre.TabIndex = 2;
            btUpdateGenre.Text = "Изменить";
            btUpdateGenre.UseVisualStyleBackColor = false;
            btUpdateGenre.Click += BtUpdateGenre_Click;
            // 
            // btDeleteGenre
            // 
            btDeleteGenre.AutoSize = true;
            btDeleteGenre.BackColor = Color.SlateBlue;
            btDeleteGenre.ForeColor = Color.White;
            btDeleteGenre.Location = new Point(238, 13);
            btDeleteGenre.Name = "btDeleteGenre";
            btDeleteGenre.Size = new Size(92, 35);
            btDeleteGenre.TabIndex = 1;
            btDeleteGenre.Text = "Удалить";
            btDeleteGenre.UseVisualStyleBackColor = false;
            btDeleteGenre.Click += BtDeleteGenre_Click;
            // 
            // PanelFill
            // 
            PanelFill.BackColor = Color.FromArgb(64, 64, 64);
            PanelFill.Controls.Add(dateGridViewGenres);
            PanelFill.Dock = DockStyle.Fill;
            PanelFill.Location = new Point(0, 61);
            PanelFill.Name = "PanelFill";
            PanelFill.Padding = new Padding(10);
            PanelFill.Size = new Size(934, 450);
            PanelFill.TabIndex = 6;
            // 
            // dateGridViewGenres
            // 
            dateGridViewGenres.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dateGridViewGenres.BackgroundColor = Color.FromArgb(64, 64, 64);
            dateGridViewGenres.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dateGridViewGenres.Dock = DockStyle.Fill;
            dateGridViewGenres.Location = new Point(10, 10);
            dateGridViewGenres.MultiSelect = false;
            dateGridViewGenres.Name = "dateGridViewGenres";
            dateGridViewGenres.ReadOnly = true;
            dateGridViewGenres.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dateGridViewGenres.Size = new Size(914, 430);
            dateGridViewGenres.TabIndex = 1;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FormListGenre
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(934, 511);
            Controls.Add(PanelFill);
            Controls.Add(flowLayoutPanelTop);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormListGenre";
            Text = "Жанры аниме";
            flowLayoutPanelTop.ResumeLayout(false);
            flowLayoutPanelTop.PerformLayout();
            PanelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dateGridViewGenres).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelTop;
        private Button btAddGenre;
        private Button btUpdateGenre;
        private Button btDeleteGenre;
        private Panel PanelFill;
        private DataGridView dateGridViewGenres;
        private ErrorProvider errorProvider;
    }
}