namespace AppTitleAnime
{
    partial class FormListTypes
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
            flowLayoutPanelTop = new Panel();
            btUpdateType = new Button();
            btDeleteType = new Button();
            btAddType = new Button();
            dateGridViewTypes = new DataGridView();
            PanelFill = new Panel();
            flowLayoutPanelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dateGridViewTypes).BeginInit();
            PanelFill.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanelTop
            // 
            flowLayoutPanelTop.AutoSize = true;
            flowLayoutPanelTop.BackColor = Color.DarkSlateBlue;
            flowLayoutPanelTop.Controls.Add(btUpdateType);
            flowLayoutPanelTop.Controls.Add(btDeleteType);
            flowLayoutPanelTop.Controls.Add(btAddType);
            flowLayoutPanelTop.Dock = DockStyle.Top;
            flowLayoutPanelTop.Location = new Point(0, 0);
            flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            flowLayoutPanelTop.Padding = new Padding(10);
            flowLayoutPanelTop.Size = new Size(934, 61);
            flowLayoutPanelTop.TabIndex = 0;
            flowLayoutPanelTop.Paint += panel1_Paint;
            // 
            // btUpdateType
            // 
            btUpdateType.AutoSize = true;
            btUpdateType.BackColor = Color.SlateBlue;
            btUpdateType.ForeColor = Color.White;
            btUpdateType.Location = new Point(124, 13);
            btUpdateType.Name = "btUpdateType";
            btUpdateType.Size = new Size(107, 35);
            btUpdateType.TabIndex = 2;
            btUpdateType.Text = "Изменить";
            btUpdateType.UseVisualStyleBackColor = false;
            btUpdateType.Click += BtUpdateType_Click;
            // 
            // btDeleteType
            // 
            btDeleteType.AutoSize = true;
            btDeleteType.BackColor = Color.SlateBlue;
            btDeleteType.ForeColor = Color.White;
            btDeleteType.Location = new Point(237, 13);
            btDeleteType.Name = "btDeleteType";
            btDeleteType.Size = new Size(92, 35);
            btDeleteType.TabIndex = 1;
            btDeleteType.Text = "Удалить";
            btDeleteType.UseVisualStyleBackColor = false;
            btDeleteType.Click += BtDeleteType_Click;
            // 
            // btAddType
            // 
            btAddType.AutoSize = true;
            btAddType.BackColor = Color.SlateBlue;
            btAddType.ForeColor = Color.White;
            btAddType.Location = new Point(12, 12);
            btAddType.Name = "btAddType";
            btAddType.Size = new Size(106, 35);
            btAddType.TabIndex = 0;
            btAddType.Text = "Добавить";
            btAddType.UseVisualStyleBackColor = false;
            btAddType.Click += BtAddType_Click;
            // 
            // dateGridViewTypes
            // 
            dateGridViewTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dateGridViewTypes.BackgroundColor = Color.FromArgb(64, 64, 64);
            dateGridViewTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dateGridViewTypes.Dock = DockStyle.Fill;
            dateGridViewTypes.Location = new Point(10, 10);
            dateGridViewTypes.MultiSelect = false;
            dateGridViewTypes.Name = "dateGridViewTypes";
            dateGridViewTypes.ReadOnly = true;
            dateGridViewTypes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dateGridViewTypes.Size = new Size(914, 430);
            dateGridViewTypes.TabIndex = 1;
            dateGridViewTypes.CellContentClick += ryy_CellContentClick;
            // 
            // PanelFill
            // 
            PanelFill.BackColor = Color.FromArgb(64, 64, 64);
            PanelFill.Controls.Add(dateGridViewTypes);
            PanelFill.Dock = DockStyle.Fill;
            PanelFill.Location = new Point(0, 61);
            PanelFill.Name = "PanelFill";
            PanelFill.Padding = new Padding(10);
            PanelFill.Size = new Size(934, 450);
            PanelFill.TabIndex = 2;
            // 
            // FormListTypes
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(934, 511);
            Controls.Add(PanelFill);
            Controls.Add(flowLayoutPanelTop);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormListTypes";
            Text = "Список типов аниме";
            Load += FormListTypes_Load;
            flowLayoutPanelTop.ResumeLayout(false);
            flowLayoutPanelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dateGridViewTypes).EndInit();
            PanelFill.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel flowLayoutPanelTop;
        private Button btUpdateType;
        private Button btDeleteType;
        private Button btAddType;
        private DataGridView dateGridViewTypes;
        private Panel PanelFill;
    }
}