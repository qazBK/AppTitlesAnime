namespace AppTitleAnime
{
    partial class FormListStudio
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
            btAddStudio = new Button();
            btUpdateStudio = new Button();
            btDeleteStudio = new Button();
            PanelFill = new Panel();
            dateGridViewStudio = new DataGridView();
            flowLayoutPanelTop.SuspendLayout();
            PanelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dateGridViewStudio).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelTop
            // 
            flowLayoutPanelTop.AutoSize = true;
            flowLayoutPanelTop.BackColor = Color.DarkSlateBlue;
            flowLayoutPanelTop.Controls.Add(btAddStudio);
            flowLayoutPanelTop.Controls.Add(btUpdateStudio);
            flowLayoutPanelTop.Controls.Add(btDeleteStudio);
            flowLayoutPanelTop.Dock = DockStyle.Top;
            flowLayoutPanelTop.Location = new Point(0, 0);
            flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            flowLayoutPanelTop.Padding = new Padding(10);
            flowLayoutPanelTop.Size = new Size(934, 61);
            flowLayoutPanelTop.TabIndex = 7;
            // 
            // btAddStudio
            // 
            btAddStudio.AutoSize = true;
            btAddStudio.BackColor = Color.SlateBlue;
            btAddStudio.ForeColor = Color.White;
            btAddStudio.Location = new Point(13, 13);
            btAddStudio.Name = "btAddStudio";
            btAddStudio.Size = new Size(106, 35);
            btAddStudio.TabIndex = 0;
            btAddStudio.Text = "Добавить";
            btAddStudio.UseVisualStyleBackColor = false;
            btAddStudio.Click += btAddStudio_Click;
            // 
            // btUpdateStudio
            // 
            btUpdateStudio.AutoSize = true;
            btUpdateStudio.BackColor = Color.SlateBlue;
            btUpdateStudio.ForeColor = Color.White;
            btUpdateStudio.Location = new Point(125, 13);
            btUpdateStudio.Name = "btUpdateStudio";
            btUpdateStudio.Size = new Size(107, 35);
            btUpdateStudio.TabIndex = 2;
            btUpdateStudio.Text = "Изменить";
            btUpdateStudio.UseVisualStyleBackColor = false;
            // 
            // btDeleteStudio
            // 
            btDeleteStudio.AutoSize = true;
            btDeleteStudio.BackColor = Color.SlateBlue;
            btDeleteStudio.ForeColor = Color.White;
            btDeleteStudio.Location = new Point(238, 13);
            btDeleteStudio.Name = "btDeleteStudio";
            btDeleteStudio.Size = new Size(92, 35);
            btDeleteStudio.TabIndex = 1;
            btDeleteStudio.Text = "Удалить";
            btDeleteStudio.UseVisualStyleBackColor = false;
            // 
            // PanelFill
            // 
            PanelFill.BackColor = Color.FromArgb(64, 64, 64);
            PanelFill.Controls.Add(dateGridViewStudio);
            PanelFill.Dock = DockStyle.Fill;
            PanelFill.Location = new Point(0, 61);
            PanelFill.Name = "PanelFill";
            PanelFill.Padding = new Padding(10);
            PanelFill.Size = new Size(934, 450);
            PanelFill.TabIndex = 8;
            // 
            // dateGridViewStudio
            // 
            dateGridViewStudio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dateGridViewStudio.BackgroundColor = Color.FromArgb(64, 64, 64);
            dateGridViewStudio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dateGridViewStudio.Dock = DockStyle.Fill;
            dateGridViewStudio.Location = new Point(10, 10);
            dateGridViewStudio.MultiSelect = false;
            dateGridViewStudio.Name = "dateGridViewStudio";
            dateGridViewStudio.ReadOnly = true;
            dateGridViewStudio.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dateGridViewStudio.Size = new Size(914, 430);
            dateGridViewStudio.TabIndex = 1;
            // 
            // FormListStudio
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 511);
            Controls.Add(PanelFill);
            Controls.Add(flowLayoutPanelTop);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormListStudio";
            Text = "FormListStudio";
            flowLayoutPanelTop.ResumeLayout(false);
            flowLayoutPanelTop.PerformLayout();
            PanelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dateGridViewStudio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelTop;
        private Button btAddStudio;
        private Button btUpdateStudio;
        private Button btDeleteStudio;
        private Panel PanelFill;
        private DataGridView dateGridViewStudio;
    }
}