namespace AppTitleAnime
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            butnShowTypes = new Button();
            butnShowGenre = new Button();
            butnShowStatuse = new Button();
            SuspendLayout();
            // 
            // butnShowTypes
            // 
            butnShowTypes.AutoSize = true;
            butnShowTypes.BackColor = Color.SlateBlue;
            butnShowTypes.ForeColor = Color.White;
            butnShowTypes.Location = new Point(12, 12);
            butnShowTypes.Name = "butnShowTypes";
            butnShowTypes.Size = new Size(337, 35);
            butnShowTypes.TabIndex = 0;
            butnShowTypes.Text = "Отобразить список \"Типы аниме\"";
            butnShowTypes.UseVisualStyleBackColor = false;
            butnShowTypes.Click += ButnShowTypes_Click;
            // 
            // butnShowGenre
            // 
            butnShowGenre.AutoSize = true;
            butnShowGenre.BackColor = Color.SlateBlue;
            butnShowGenre.ForeColor = Color.White;
            butnShowGenre.Location = new Point(12, 64);
            butnShowGenre.Name = "butnShowGenre";
            butnShowGenre.Size = new Size(337, 35);
            butnShowGenre.TabIndex = 2;
            butnShowGenre.Text = "Отобразить список \"Жанры аниме\"";
            butnShowGenre.UseVisualStyleBackColor = false;
            butnShowGenre.Click += ButnShowGenre_Click;
            // 
            // butnShowStatuse
            // 
            butnShowStatuse.AutoSize = true;
            butnShowStatuse.BackColor = Color.SlateBlue;
            butnShowStatuse.ForeColor = Color.White;
            butnShowStatuse.Location = new Point(12, 115);
            butnShowStatuse.Name = "butnShowStatuse";
            butnShowStatuse.Size = new Size(337, 35);
            butnShowStatuse.TabIndex = 3;
            butnShowStatuse.Text = "Отобразить список \"Статусы аниме\"";
            butnShowStatuse.UseVisualStyleBackColor = false;
            butnShowStatuse.Click += ButnShowStatuse_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(914, 547);
            Controls.Add(butnShowStatuse);
            Controls.Add(butnShowGenre);
            Controls.Add(butnShowTypes);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormMain";
            Text = "Главная форма";
            Load += FormMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button butnShowTypes;
        private Button butnShowGenre;
        private Button butnShowStatuse;
    }
}
