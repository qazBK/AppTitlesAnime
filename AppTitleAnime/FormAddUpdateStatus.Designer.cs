namespace AppTitleAnime
{
    partial class FormAddUpdateStatus
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
            flowLayoutPanelBottom = new FlowLayoutPanel();
            btSaveChenges = new Button();
            btConcel = new Button();
            panelFill = new Panel();
            textBoxStatuse = new TextBox();
            labelStatuse = new Label();
            errorProvider = new ErrorProvider(components);
            flowLayoutPanelBottom.SuspendLayout();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelBottom
            // 
            flowLayoutPanelBottom.AutoSize = true;
            flowLayoutPanelBottom.BackColor = Color.DarkSlateBlue;
            flowLayoutPanelBottom.Controls.Add(btSaveChenges);
            flowLayoutPanelBottom.Controls.Add(btConcel);
            flowLayoutPanelBottom.Dock = DockStyle.Bottom;
            flowLayoutPanelBottom.Location = new Point(0, 80);
            flowLayoutPanelBottom.Name = "flowLayoutPanelBottom";
            flowLayoutPanelBottom.Padding = new Padding(10, 10, 20, 10);
            flowLayoutPanelBottom.Size = new Size(434, 61);
            flowLayoutPanelBottom.TabIndex = 0;
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
            btSaveChenges.Click += BtSaveChenges_Click;
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
            btConcel.TabIndex = 0;
            btConcel.Text = "Отмена";
            btConcel.UseVisualStyleBackColor = false;
            // 
            // panelFill
            // 
            panelFill.BackColor = Color.FromArgb(64, 64, 64);
            panelFill.Controls.Add(textBoxStatuse);
            panelFill.Controls.Add(labelStatuse);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 0);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10, 10, 20, 10);
            panelFill.Size = new Size(434, 80);
            panelFill.TabIndex = 0;
            // 
            // textBoxStatuse
            // 
            textBoxStatuse.Dock = DockStyle.Top;
            textBoxStatuse.Location = new Point(10, 35);
            textBoxStatuse.Name = "textBoxStatuse";
            textBoxStatuse.Size = new Size(404, 33);
            textBoxStatuse.TabIndex = 1;
            textBoxStatuse.TextChanged += textBoxStatuse_TextChanged;
            textBoxStatuse.Validating += textBoxStatuse_Validating;
            // 
            // labelStatuse
            // 
            labelStatuse.AutoSize = true;
            labelStatuse.Dock = DockStyle.Top;
            labelStatuse.ForeColor = Color.White;
            labelStatuse.Location = new Point(10, 10);
            labelStatuse.Name = "labelStatuse";
            labelStatuse.Size = new Size(136, 25);
            labelStatuse.TabIndex = 0;
            labelStatuse.Text = "Статус выхода";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FormAddUpdateStatus
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 141);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelBottom);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormAddUpdateStatus";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Статус аниме";
            flowLayoutPanelBottom.ResumeLayout(false);
            flowLayoutPanelBottom.PerformLayout();
            panelFill.ResumeLayout(false);
            panelFill.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelBottom;
        private Button btSaveChenges;
        private Button btConcel;
        private Panel panelFill;
        protected internal TextBox textBoxStatuse;
        private Label labelStatuse;
        private ErrorProvider errorProvider;
    }
}