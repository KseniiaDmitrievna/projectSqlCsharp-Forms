namespace kursah
{
    partial class Form
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
            this.comboBoxZach = new System.Windows.Forms.ComboBox();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.textBoxOcenka = new System.Windows.Forms.TextBox();
            this.comboBoxPrep = new System.Windows.Forms.ComboBox();
            this.comboBoxProfil = new System.Windows.Forms.ComboBox();
            this.comboBoxEkz = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxZach
            // 
            this.comboBoxZach.FormattingEnabled = true;
            this.comboBoxZach.Location = new System.Drawing.Point(48, 110);
            this.comboBoxZach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxZach.Name = "comboBoxZach";
            this.comboBoxZach.Size = new System.Drawing.Size(357, 24);
            this.comboBoxZach.TabIndex = 5;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(39, 540);
            this.buttonSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(359, 57);
            this.buttonSelect.TabIndex = 4;
            this.buttonSelect.Text = "Показать";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // textBoxOcenka
            // 
            this.textBoxOcenka.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxOcenka.Location = new System.Drawing.Point(226, 272);
            this.textBoxOcenka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxOcenka.Name = "textBoxOcenka";
            this.textBoxOcenka.Size = new System.Drawing.Size(172, 22);
            this.textBoxOcenka.TabIndex = 3;
            // 
            // comboBoxPrep
            // 
            this.comboBoxPrep.FormattingEnabled = true;
            this.comboBoxPrep.Location = new System.Drawing.Point(49, 184);
            this.comboBoxPrep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPrep.Name = "comboBoxPrep";
            this.comboBoxPrep.Size = new System.Drawing.Size(357, 24);
            this.comboBoxPrep.TabIndex = 2;
            // 
            // comboBoxProfil
            // 
            this.comboBoxProfil.FormattingEnabled = true;
            this.comboBoxProfil.Location = new System.Drawing.Point(48, 48);
            this.comboBoxProfil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxProfil.Name = "comboBoxProfil";
            this.comboBoxProfil.Size = new System.Drawing.Size(357, 24);
            this.comboBoxProfil.TabIndex = 1;
            // 
            // comboBoxEkz
            // 
            this.comboBoxEkz.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.comboBoxEkz.FormattingEnabled = true;
            this.comboBoxEkz.Items.AddRange(new object[] {
            "Зачет",
            "Экзамен",
            "Курсовая",
            "Реферат",
            "Ргр",
            "Практика",
            "Рр"});
            this.comboBoxEkz.Location = new System.Drawing.Point(39, 272);
            this.comboBoxEkz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxEkz.Name = "comboBoxEkz";
            this.comboBoxEkz.Size = new System.Drawing.Size(172, 24);
            this.comboBoxEkz.TabIndex = 0;
            this.comboBoxEkz.Text = "Не выбрано";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1059, 678);
            this.dataGridView1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 618);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(359, 57);
            this.button1.TabIndex = 7;
            this.button1.Text = "Экспорт в excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(44, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Профиль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(44, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Номер зачетной книжки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(44, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Преподаватель";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(35, 235);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Тип работы";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(222, 235);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Оценка";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBoxPrep);
            this.panel1.Controls.Add(this.comboBoxProfil);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBoxEkz);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxOcenka);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxZach);
            this.panel1.Controls.Add(this.buttonSelect);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1045, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(418, 705);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 705);
            this.panel1.TabIndex = 14;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 705);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form";
            this.Text = "Поиск по категории";
            this.Load += new System.EventHandler(this.FormOtchet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxProfil;
        private System.Windows.Forms.ComboBox comboBoxEkz;
        private System.Windows.Forms.ComboBox comboBoxPrep;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.TextBox textBoxOcenka;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxZach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}