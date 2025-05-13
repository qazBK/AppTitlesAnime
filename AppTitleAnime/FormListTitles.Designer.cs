namespace AppTitleAnime
{
    partial class FormListTitles
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
            flowLayoutPanelTop = new FlowLayoutPanel();
            btAddTitle = new Button();
            btUpdateTitle = new Button();
            btDeleteTitle = new Button();
            PanelFill = new Panel();
            dateGridViewTitles = new DataGridView();
            flowLayoutPanelTop.SuspendLayout();
            PanelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dateGridViewTitles).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelTop
            // 
            flowLayoutPanelTop.AutoSize = true;
            flowLayoutPanelTop.BackColor = Color.DarkSlateBlue;
            flowLayoutPanelTop.Controls.Add(btAddTitle);
            flowLayoutPanelTop.Controls.Add(btUpdateTitle);
            flowLayoutPanelTop.Controls.Add(btDeleteTitle);
            flowLayoutPanelTop.Dock = DockStyle.Top;
            flowLayoutPanelTop.Location = new Point(0, 0);
            flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            flowLayoutPanelTop.Padding = new Padding(10);
            flowLayoutPanelTop.Size = new Size(934, 61);
            flowLayoutPanelTop.TabIndex = 5;
            // 
            // btAddTitle
            // 
            btAddTitle.AutoSize = true;
            btAddTitle.BackColor = Color.SlateBlue;
            btAddTitle.ForeColor = Color.White;
            btAddTitle.Location = new Point(13, 13);
            btAddTitle.Name = "btAddTitle";
            btAddTitle.Size = new Size(106, 35);
            btAddTitle.TabIndex = 0;
            btAddTitle.Text = "Добавить";
            btAddTitle.UseVisualStyleBackColor = false;
            btAddTitle.Click += BtAddTitle_Click;
            // 
            // btUpdateTitle
            // 
            btUpdateTitle.AutoSize = true;
            btUpdateTitle.BackColor = Color.SlateBlue;
            btUpdateTitle.ForeColor = Color.White;
            btUpdateTitle.Location = new Point(125, 13);
            btUpdateTitle.Name = "btUpdateTitle";
            btUpdateTitle.Size = new Size(107, 35);
            btUpdateTitle.TabIndex = 2;
            btUpdateTitle.Text = "Изменить";
            btUpdateTitle.UseVisualStyleBackColor = false;
            btUpdateTitle.Click += BtUpdateTitle_Click;
            // 
            // btDeleteTitle
            // 
            btDeleteTitle.AutoSize = true;
            btDeleteTitle.BackColor = Color.SlateBlue;
            btDeleteTitle.ForeColor = Color.White;
            btDeleteTitle.Location = new Point(238, 13);
            btDeleteTitle.Name = "btDeleteTitle";
            btDeleteTitle.Size = new Size(92, 35);
            btDeleteTitle.TabIndex = 1;
            btDeleteTitle.Text = "Удалить";
            btDeleteTitle.UseVisualStyleBackColor = false;
            btDeleteTitle.Click += BtDeleteTitle_Click;
            // 
            // PanelFill
            // 
            PanelFill.BackColor = Color.FromArgb(64, 64, 64);
            PanelFill.Controls.Add(dateGridViewTitles);
            PanelFill.Dock = DockStyle.Fill;
            PanelFill.Location = new Point(0, 61);
            PanelFill.Name = "PanelFill";
            PanelFill.Padding = new Padding(10);
            PanelFill.Size = new Size(934, 450);
            PanelFill.TabIndex = 6;
            // 
            // dateGridViewTitles
            // 
            dateGridViewTitles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dateGridViewTitles.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dateGridViewTitles.BackgroundColor = Color.FromArgb(64, 64, 64);
            dateGridViewTitles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dateGridViewTitles.Dock = DockStyle.Fill;
            dateGridViewTitles.Location = new Point(10, 10);
            dateGridViewTitles.MultiSelect = false;
            dateGridViewTitles.Name = "dateGridViewTitles";
            dateGridViewTitles.ReadOnly = true;
            dateGridViewTitles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dateGridViewTitles.Size = new Size(914, 430);
            dateGridViewTitles.TabIndex = 1;
            // 
            // FormListTitles
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 511);
            Controls.Add(PanelFill);
            Controls.Add(flowLayoutPanelTop);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormListTitles";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Аниме тайтлы";
            flowLayoutPanelTop.ResumeLayout(false);
            flowLayoutPanelTop.PerformLayout();
            PanelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dateGridViewTitles).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelTop;
        private Button btAddTitle;
        private Button btUpdateTitle;
        private Button btDeleteTitle;
        private Panel PanelFill;
        private DataGridView dateGridViewTitles;
    }
}