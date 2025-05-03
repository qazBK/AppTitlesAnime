namespace AppTitleAnime
{
    partial class FormAddUpdateTitle
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
            panelFill = new Panel();
            textBoxDescription = new TextBox();
            labelDescription = new Label();
            textBoxStudio = new TextBox();
            labelStudio = new Label();
            numericUpDownDuration = new NumericUpDown();
            labelDuration = new Label();
            numUpDownCountSerias = new NumericUpDown();
            labelCountSerias = new Label();
            comboBoxType = new ComboBox();
            labelType = new Label();
            textBoxName = new TextBox();
            labelName = new Label();
            textBoxOriginalName = new TextBox();
            labelOriginalName = new Label();
            flowLayoutPanelBottom = new FlowLayoutPanel();
            btSaveChenges = new Button();
            btConcel = new Button();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUpDownCountSerias).BeginInit();
            flowLayoutPanelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // panelFill
            // 
            panelFill.BackColor = Color.FromArgb(64, 64, 64);
            panelFill.Controls.Add(textBoxDescription);
            panelFill.Controls.Add(labelDescription);
            panelFill.Controls.Add(textBoxStudio);
            panelFill.Controls.Add(labelStudio);
            panelFill.Controls.Add(numericUpDownDuration);
            panelFill.Controls.Add(labelDuration);
            panelFill.Controls.Add(numUpDownCountSerias);
            panelFill.Controls.Add(labelCountSerias);
            panelFill.Controls.Add(comboBoxType);
            panelFill.Controls.Add(labelType);
            panelFill.Controls.Add(textBoxName);
            panelFill.Controls.Add(labelName);
            panelFill.Controls.Add(textBoxOriginalName);
            panelFill.Controls.Add(labelOriginalName);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10, 10, 20, 10);
            panelFill.Size = new Size(859, 535);
            panelFill.TabIndex = 2;
            // 
            // textBoxDescription
            // 
            textBoxDescription.Dock = DockStyle.Fill;
            textBoxDescription.Location = new Point(10, 383);
            textBoxDescription.Multiline = true;
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.ScrollBars = ScrollBars.Vertical;
            textBoxDescription.Size = new Size(829, 142);
            textBoxDescription.TabIndex = 29;
            // 
            // labelDescription
            // 
            labelDescription.AutoSize = true;
            labelDescription.Dock = DockStyle.Top;
            labelDescription.ForeColor = Color.White;
            labelDescription.Location = new Point(10, 358);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(99, 25);
            labelDescription.TabIndex = 28;
            labelDescription.Text = "Описание";
            // 
            // textBoxStudio
            // 
            textBoxStudio.Dock = DockStyle.Top;
            textBoxStudio.Location = new Point(10, 325);
            textBoxStudio.Name = "textBoxStudio";
            textBoxStudio.Size = new Size(829, 33);
            textBoxStudio.TabIndex = 27;
            // 
            // labelStudio
            // 
            labelStudio.AutoSize = true;
            labelStudio.Dock = DockStyle.Top;
            labelStudio.ForeColor = Color.White;
            labelStudio.Location = new Point(10, 300);
            labelStudio.Name = "labelStudio";
            labelStudio.Size = new Size(72, 25);
            labelStudio.TabIndex = 26;
            labelStudio.Text = "Студия";
            // 
            // numericUpDownDuration
            // 
            numericUpDownDuration.Dock = DockStyle.Top;
            numericUpDownDuration.Location = new Point(10, 267);
            numericUpDownDuration.Maximum = new decimal(new int[] { 1442, 0, 0, 0 });
            numericUpDownDuration.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownDuration.Name = "numericUpDownDuration";
            numericUpDownDuration.Size = new Size(829, 33);
            numericUpDownDuration.TabIndex = 25;
            numericUpDownDuration.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelDuration
            // 
            labelDuration.AutoSize = true;
            labelDuration.Dock = DockStyle.Top;
            labelDuration.ForeColor = Color.White;
            labelDuration.Location = new Point(10, 242);
            labelDuration.Name = "labelDuration";
            labelDuration.Size = new Size(292, 25);
            labelDuration.TabIndex = 24;
            labelDuration.Text = "Продолжительность серии мин.";
            // 
            // numUpDownCountSerias
            // 
            numUpDownCountSerias.Dock = DockStyle.Top;
            numUpDownCountSerias.Location = new Point(10, 209);
            numUpDownCountSerias.Maximum = new decimal(new int[] { 50000, 0, 0, 0 });
            numUpDownCountSerias.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numUpDownCountSerias.Name = "numUpDownCountSerias";
            numUpDownCountSerias.Size = new Size(829, 33);
            numUpDownCountSerias.TabIndex = 23;
            numUpDownCountSerias.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelCountSerias
            // 
            labelCountSerias.AutoSize = true;
            labelCountSerias.Dock = DockStyle.Top;
            labelCountSerias.ForeColor = Color.White;
            labelCountSerias.Location = new Point(10, 184);
            labelCountSerias.Name = "labelCountSerias";
            labelCountSerias.Size = new Size(176, 25);
            labelCountSerias.TabIndex = 22;
            labelCountSerias.Text = "Количество серий ";
            // 
            // comboBoxType
            // 
            comboBoxType.Dock = DockStyle.Top;
            comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(10, 151);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(829, 33);
            comboBoxType.TabIndex = 21;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Dock = DockStyle.Top;
            labelType.ForeColor = Color.White;
            labelType.Location = new Point(10, 126);
            labelType.Name = "labelType";
            labelType.Size = new Size(44, 25);
            labelType.TabIndex = 4;
            labelType.Text = "Тип";
            // 
            // textBoxName
            // 
            textBoxName.Dock = DockStyle.Top;
            textBoxName.Location = new Point(10, 93);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(829, 33);
            textBoxName.TabIndex = 3;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Dock = DockStyle.Top;
            labelName.ForeColor = Color.White;
            labelName.Location = new Point(10, 68);
            labelName.Name = "labelName";
            labelName.Size = new Size(155, 25);
            labelName.TabIndex = 2;
            labelName.Text = "Название аниме";
            // 
            // textBoxOriginalName
            // 
            textBoxOriginalName.Dock = DockStyle.Top;
            textBoxOriginalName.Location = new Point(10, 35);
            textBoxOriginalName.Name = "textBoxOriginalName";
            textBoxOriginalName.Size = new Size(829, 33);
            textBoxOriginalName.TabIndex = 1;
            // 
            // labelOriginalName
            // 
            labelOriginalName.AutoSize = true;
            labelOriginalName.Dock = DockStyle.Top;
            labelOriginalName.ForeColor = Color.White;
            labelOriginalName.Location = new Point(10, 10);
            labelOriginalName.Name = "labelOriginalName";
            labelOriginalName.Size = new Size(225, 25);
            labelOriginalName.TabIndex = 0;
            labelOriginalName.Text = "Оригинальное название";
            // 
            // flowLayoutPanelBottom
            // 
            flowLayoutPanelBottom.AutoSize = true;
            flowLayoutPanelBottom.BackColor = Color.DarkSlateBlue;
            flowLayoutPanelBottom.Controls.Add(btSaveChenges);
            flowLayoutPanelBottom.Controls.Add(btConcel);
            flowLayoutPanelBottom.Dock = DockStyle.Bottom;
            flowLayoutPanelBottom.Location = new Point(0, 535);
            flowLayoutPanelBottom.Name = "flowLayoutPanelBottom";
            flowLayoutPanelBottom.Padding = new Padding(10, 10, 20, 10);
            flowLayoutPanelBottom.Size = new Size(859, 61);
            flowLayoutPanelBottom.TabIndex = 3;
            // 
            // btSaveChenges
            // 
            btSaveChenges.AutoSize = true;
            btSaveChenges.BackColor = Color.SlateBlue;
            btSaveChenges.DialogResult = DialogResult.OK;
            btSaveChenges.ForeColor = Color.White;
            btSaveChenges.Location = new Point(13, 13);
            btSaveChenges.Name = "btSaveChenges";
            btSaveChenges.Size = new Size(115, 35);
            btSaveChenges.TabIndex = 0;
            btSaveChenges.Text = "Сохранить";
            btSaveChenges.UseVisualStyleBackColor = false;
            // 
            // btConcel
            // 
            btConcel.AutoSize = true;
            btConcel.BackColor = Color.SlateBlue;
            btConcel.DialogResult = DialogResult.Cancel;
            btConcel.ForeColor = Color.White;
            btConcel.Location = new Point(134, 13);
            btConcel.Name = "btConcel";
            btConcel.Size = new Size(88, 35);
            btConcel.TabIndex = 1;
            btConcel.Text = "Отмена";
            btConcel.UseVisualStyleBackColor = false;
            // 
            // FormAddUpdateTitle
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 596);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelBottom);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormAddUpdateTitle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Информация об тайтле";
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUpDownCountSerias).EndInit();
            flowLayoutPanelBottom.ResumeLayout(false);
            flowLayoutPanelBottom.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        protected internal TextBox textBoxOriginalName;
        private Label labelOriginalName;
        private FlowLayoutPanel flowLayoutPanelBottom;
        private Button btSaveChenges;
        private Button btConcel;
        private Label labelType;
        protected internal TextBox textBoxName;
        private Label labelName;
        protected internal TextBox textBoxDescription;
        private Label labelDescription;
        protected internal TextBox textBoxStudio;
        private Label labelStudio;
        private Label labelDuration;
        private Label labelCountSerias;
        protected internal Panel panelFill;
        protected internal ComboBox comboBoxType;
        protected internal NumericUpDown numericUpDownDuration;
        protected internal NumericUpDown numUpDownCountSerias;
    }
}