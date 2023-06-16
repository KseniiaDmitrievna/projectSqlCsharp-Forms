namespace kursah
{
    partial class FormUspevaemost
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
            this.comboBoxSp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPrep = new System.Windows.Forms.ComboBox();
            this.comboBoxSt = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxFak = new System.Windows.Forms.ComboBox();
            this.buttonSp = new System.Windows.Forms.Button();
            this.buttonSt = new System.Windows.Forms.Button();
            this.buttonPr = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonText = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxGruppa = new System.Windows.Forms.ComboBox();
            this.comboBoxGruppa2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonGr = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxSp
            // 
            this.comboBoxSp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSp.FormattingEnabled = true;
            this.comboBoxSp.Location = new System.Drawing.Point(190, 59);
            this.comboBoxSp.Name = "comboBoxSp";
            this.comboBoxSp.Size = new System.Drawing.Size(604, 24);
            this.comboBoxSp.TabIndex = 0;
            this.comboBoxSp.SelectedIndexChanged += new System.EventHandler(this.comboBoxSp_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Специальность";
            // 
            // comboBoxPrep
            // 
            this.comboBoxPrep.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxPrep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrep.FormattingEnabled = true;
            this.comboBoxPrep.Location = new System.Drawing.Point(3, 18);
            this.comboBoxPrep.Name = "comboBoxPrep";
            this.comboBoxPrep.Size = new System.Drawing.Size(512, 24);
            this.comboBoxPrep.TabIndex = 3;
            // 
            // comboBoxSt
            // 
            this.comboBoxSt.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxSt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSt.FormattingEnabled = true;
            this.comboBoxSt.Location = new System.Drawing.Point(3, 18);
            this.comboBoxSt.Name = "comboBoxSt";
            this.comboBoxSt.Size = new System.Drawing.Size(458, 24);
            this.comboBoxSt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(62, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Факультет";
            // 
            // comboBoxFak
            // 
            this.comboBoxFak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFak.FormattingEnabled = true;
            this.comboBoxFak.Location = new System.Drawing.Point(190, 12);
            this.comboBoxFak.Name = "comboBoxFak";
            this.comboBoxFak.Size = new System.Drawing.Size(604, 24);
            this.comboBoxFak.TabIndex = 7;
            this.comboBoxFak.SelectedIndexChanged += new System.EventHandler(this.comboBoxFak_SelectedIndexChanged);
            // 
            // buttonSp
            // 
            this.buttonSp.Location = new System.Drawing.Point(825, 59);
            this.buttonSp.Name = "buttonSp";
            this.buttonSp.Size = new System.Drawing.Size(202, 23);
            this.buttonSp.TabIndex = 8;
            this.buttonSp.Text = "Отчет по специальности";
            this.buttonSp.UseVisualStyleBackColor = true;
            this.buttonSp.Click += new System.EventHandler(this.buttonSp_Click);
            // 
            // buttonSt
            // 
            this.buttonSt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonSt.Location = new System.Drawing.Point(3, 75);
            this.buttonSt.Name = "buttonSt";
            this.buttonSt.Size = new System.Drawing.Size(458, 33);
            this.buttonSt.TabIndex = 9;
            this.buttonSt.Text = "Отчет по студенту";
            this.buttonSt.UseVisualStyleBackColor = true;
            this.buttonSt.Click += new System.EventHandler(this.buttonSt_Click);
            // 
            // buttonPr
            // 
            this.buttonPr.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPr.Location = new System.Drawing.Point(3, 68);
            this.buttonPr.Name = "buttonPr";
            this.buttonPr.Size = new System.Drawing.Size(512, 40);
            this.buttonPr.TabIndex = 10;
            this.buttonPr.Text = "Вывести отчет по преподавателю в определенной группе";
            this.buttonPr.UseVisualStyleBackColor = true;
            this.buttonPr.Click += new System.EventHandler(this.buttonPr_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 281);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(788, 43);
            this.textBox1.TabIndex = 11;
            // 
            // buttonText
            // 
            this.buttonText.Location = new System.Drawing.Point(1100, 206);
            this.buttonText.Name = "buttonText";
            this.buttonText.Size = new System.Drawing.Size(309, 108);
            this.buttonText.TabIndex = 12;
            this.buttonText.Text = "Экспорт";
            this.buttonText.UseVisualStyleBackColor = true;
            this.buttonText.Click += new System.EventHandler(this.buttonText_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 345);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1397, 331);
            this.dataGridView1.TabIndex = 13;
            // 
            // comboBoxGruppa
            // 
            this.comboBoxGruppa.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxGruppa.FormattingEnabled = true;
            this.comboBoxGruppa.Location = new System.Drawing.Point(3, 42);
            this.comboBoxGruppa.Name = "comboBoxGruppa";
            this.comboBoxGruppa.Size = new System.Drawing.Size(512, 24);
            this.comboBoxGruppa.TabIndex = 14;
            this.comboBoxGruppa.SelectedIndexChanged += new System.EventHandler(this.comboBoxGruppa_SelectedIndexChanged);
            // 
            // comboBoxGruppa2
            // 
            this.comboBoxGruppa2.FormattingEnabled = true;
            this.comboBoxGruppa2.Location = new System.Drawing.Point(190, 105);
            this.comboBoxGruppa2.Name = "comboBoxGruppa2";
            this.comboBoxGruppa2.Size = new System.Drawing.Size(293, 24);
            this.comboBoxGruppa2.TabIndex = 15;
            this.comboBoxGruppa2.SelectedIndexChanged += new System.EventHandler(this.comboBoxGruppa2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(89, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Группа";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonPr);
            this.groupBox1.Controls.Add(this.comboBoxGruppa);
            this.groupBox1.Controls.Add(this.comboBoxPrep);
            this.groupBox1.Location = new System.Drawing.Point(512, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 111);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите группу и преподавателя";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxSt);
            this.groupBox2.Controls.Add(this.buttonSt);
            this.groupBox2.Location = new System.Drawing.Point(19, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(464, 111);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выберите Студента";
            // 
            // buttonGr
            // 
            this.buttonGr.Location = new System.Drawing.Point(512, 105);
            this.buttonGr.Name = "buttonGr";
            this.buttonGr.Size = new System.Drawing.Size(139, 23);
            this.buttonGr.TabIndex = 20;
            this.buttonGr.Text = "Отчет по группе";
            this.buttonGr.UseVisualStyleBackColor = true;
            this.buttonGr.Click += new System.EventHandler(this.buttonGr_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(621, 701);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(788, 43);
            this.textBox2.TabIndex = 21;
            // 
            // FormUspevaemost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1494, 777);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonGr);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxGruppa2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonText);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonSp);
            this.Controls.Add(this.comboBoxFak);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSp);
            this.Name = "FormUspevaemost";
            this.Text = "Успеваемость";
            this.Load += new System.EventHandler(this.FormUspevaemost_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPrep;
        private System.Windows.Forms.ComboBox comboBoxSt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxFak;
        private System.Windows.Forms.Button buttonSp;
        private System.Windows.Forms.Button buttonSt;
        private System.Windows.Forms.Button buttonPr;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonText;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxGruppa;
        private System.Windows.Forms.ComboBox comboBoxGruppa2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonGr;
        private System.Windows.Forms.TextBox textBox2;
    }
}