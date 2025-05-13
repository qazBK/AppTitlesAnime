namespace AppTitleAnime
{
    partial class FormListStatuses
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
            btAddStatuse = new Button();
            btUpdateStatuse = new Button();
            btDeleteStatuse = new Button();
            PanelFill = new Panel();
            dateGridViewStatuses = new DataGridView();
            errorProvider = new ErrorProvider(components);
            flowLayoutPanelTop.SuspendLayout();
            PanelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dateGridViewStatuses).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelTop
            // 
            flowLayoutPanelTop.AutoSize = true;
            flowLayoutPanelTop.BackColor = Color.DarkSlateBlue;
            flowLayoutPanelTop.Controls.Add(btAddStatuse);
            flowLayoutPanelTop.Controls.Add(btUpdateStatuse);
            flowLayoutPanelTop.Controls.Add(btDeleteStatuse);
            flowLayoutPanelTop.Dock = DockStyle.Top;
            flowLayoutPanelTop.Location = new Point(0, 0);
            flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            flowLayoutPanelTop.Padding = new Padding(10);
            flowLayoutPanelTop.Size = new Size(934, 61);
            flowLayoutPanelTop.TabIndex = 6;
            // 
            // btAddStatuse
            // 
            btAddStatuse.AutoSize = true;
            btAddStatuse.BackColor = Color.SlateBlue;
            btAddStatuse.ForeColor = Color.White;
            btAddStatuse.Location = new Point(13, 13);
            btAddStatuse.Name = "btAddStatuse";
            btAddStatuse.Size = new Size(106, 35);
            btAddStatuse.TabIndex = 0;
            btAddStatuse.Text = "Добавить";
            btAddStatuse.UseVisualStyleBackColor = false;
            btAddStatuse.Click += BtAddStatuse_Click;
            // 
            // btUpdateStatuse
            // 
            btUpdateStatuse.AutoSize = true;
            btUpdateStatuse.BackColor = Color.SlateBlue;
            btUpdateStatuse.ForeColor = Color.White;
            btUpdateStatuse.Location = new Point(125, 13);
            btUpdateStatuse.Name = "btUpdateStatuse";
            btUpdateStatuse.Size = new Size(107, 35);
            btUpdateStatuse.TabIndex = 2;
            btUpdateStatuse.Text = "Изменить";
            btUpdateStatuse.UseVisualStyleBackColor = false;
            btUpdateStatuse.Click += BtUpdateStatuse_Click;
            // 
            // btDeleteStatuse
            // 
            btDeleteStatuse.AutoSize = true;
            btDeleteStatuse.BackColor = Color.SlateBlue;
            btDeleteStatuse.ForeColor = Color.White;
            btDeleteStatuse.Location = new Point(238, 13);
            btDeleteStatuse.Name = "btDeleteStatuse";
            btDeleteStatuse.Size = new Size(92, 35);
            btDeleteStatuse.TabIndex = 1;
            btDeleteStatuse.Text = "Удалить";
            btDeleteStatuse.UseVisualStyleBackColor = false;
            btDeleteStatuse.Click += BtDeleteStatuse_Click;
            // 
            // PanelFill
            // 
            PanelFill.BackColor = Color.FromArgb(64, 64, 64);
            PanelFill.Controls.Add(dateGridViewStatuses);
            PanelFill.Dock = DockStyle.Fill;
            PanelFill.Location = new Point(0, 61);
            PanelFill.Name = "PanelFill";
            PanelFill.Padding = new Padding(10);
            PanelFill.Size = new Size(934, 450);
            PanelFill.TabIndex = 7;
            // 
            // dateGridViewStatuses
            // 
            dateGridViewStatuses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dateGridViewStatuses.BackgroundColor = Color.FromArgb(64, 64, 64);
            dateGridViewStatuses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dateGridViewStatuses.Dock = DockStyle.Fill;
            dateGridViewStatuses.Location = new Point(10, 10);
            dateGridViewStatuses.MultiSelect = false;
            dateGridViewStatuses.Name = "dateGridViewStatuses";
            dateGridViewStatuses.ReadOnly = true;
            dateGridViewStatuses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dateGridViewStatuses.Size = new Size(914, 430);
            dateGridViewStatuses.TabIndex = 1;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FormListStatuses
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 511);
            Controls.Add(PanelFill);
            Controls.Add(flowLayoutPanelTop);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormListStatuses";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Статус выхода аниме";
            flowLayoutPanelTop.ResumeLayout(false);
            flowLayoutPanelTop.PerformLayout();
            PanelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dateGridViewStatuses).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelTop;
        private Button btAddStatuse;
        private Button btUpdateStatuse;
        private Button btDeleteStatuse;
        private Panel PanelFill;
        private DataGridView dateGridViewStatuses;
        private ErrorProvider errorProvider;
    }
}