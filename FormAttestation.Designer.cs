namespace kursah
{
    partial class FormAttestation
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonSendAtt = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.Box1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxSt = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBoxProfil = new System.Windows.Forms.ComboBox();
            this.comboBoxPr = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Box2 = new System.Windows.Forms.TextBox();
            this.Box3 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.Box6 = new System.Windows.Forms.TextBox();
            this.Box5 = new System.Windows.Forms.TextBox();
            this.Box4 = new System.Windows.Forms.TextBox();
            this.Box7 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.comboBoxGr = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1220, 628);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonSendAtt
            // 
            this.buttonSendAtt.Location = new System.Drawing.Point(1256, 519);
            this.buttonSendAtt.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSendAtt.Name = "buttonSendAtt";
            this.buttonSendAtt.Size = new System.Drawing.Size(267, 62);
            this.buttonSendAtt.TabIndex = 55;
            this.buttonSendAtt.Text = "Добавить";
            this.buttonSendAtt.UseVisualStyleBackColor = true;
            this.buttonSendAtt.Click += new System.EventHandler(this.buttonSendAtt_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(1256, 354);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 20);
            this.label15.TabIndex = 53;
            this.label15.Text = "Экзамен";
            // 
            // Box1
            // 
            this.Box1.Location = new System.Drawing.Point(1357, 299);
            this.Box1.Margin = new System.Windows.Forms.Padding(4);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(65, 22);
            this.Box1.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(1256, 274);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 20);
            this.label11.TabIndex = 49;
            this.label11.Text = "Оценки";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(1256, 208);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 20);
            this.label12.TabIndex = 47;
            this.label12.Text = "ID преподавателя";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(1256, 143);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(167, 20);
            this.label13.TabIndex = 45;
            this.label13.Text = "Id в учебном плане";
            // 
            // comboBoxSt
            // 
            this.comboBoxSt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSt.FormattingEnabled = true;
            this.comboBoxSt.Location = new System.Drawing.Point(1256, 104);
            this.comboBoxSt.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxSt.Name = "comboBoxSt";
            this.comboBoxSt.Size = new System.Drawing.Size(361, 24);
            this.comboBoxSt.TabIndex = 44;
            this.comboBoxSt.SelectedIndexChanged += new System.EventHandler(this.comboBoxSt_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(1256, 78);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(213, 20);
            this.label10.TabIndex = 43;
            this.label10.Text = "Номер зачетной книжки";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(1252, 15);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(179, 20);
            this.label16.TabIndex = 40;
            this.label16.Text = "Добавление данных";
            // 
            // comboBoxProfil
            // 
            this.comboBoxProfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProfil.FormattingEnabled = true;
            this.comboBoxProfil.Location = new System.Drawing.Point(1256, 169);
            this.comboBoxProfil.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxProfil.Name = "comboBoxProfil";
            this.comboBoxProfil.Size = new System.Drawing.Size(361, 24);
            this.comboBoxProfil.TabIndex = 56;
            // 
            // comboBoxPr
            // 
            this.comboBoxPr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPr.FormattingEnabled = true;
            this.comboBoxPr.Location = new System.Drawing.Point(1256, 234);
            this.comboBoxPr.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPr.Name = "comboBoxPr";
            this.comboBoxPr.Size = new System.Drawing.Size(361, 24);
            this.comboBoxPr.TabIndex = 57;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(1256, 304);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(61, 20);
            this.label17.TabIndex = 58;
            this.label17.Text = "Зачет";
            // 
            // Box2
            // 
            this.Box2.Location = new System.Drawing.Point(1357, 349);
            this.Box2.Margin = new System.Windows.Forms.Padding(4);
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(65, 22);
            this.Box2.TabIndex = 59;
            // 
            // Box3
            // 
            this.Box3.Location = new System.Drawing.Point(1357, 398);
            this.Box3.Margin = new System.Windows.Forms.Padding(4);
            this.Box3.Name = "Box3";
            this.Box3.Size = new System.Drawing.Size(65, 22);
            this.Box3.TabIndex = 60;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(1256, 403);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 20);
            this.label14.TabIndex = 61;
            this.label14.Text = "Курсовая";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(1451, 403);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 20);
            this.label18.TabIndex = 62;
            this.label18.Text = "Практика";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(1451, 354);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 20);
            this.label19.TabIndex = 63;
            this.label19.Text = "РГР";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(1451, 304);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(86, 20);
            this.label20.TabIndex = 64;
            this.label20.Text = "Реферат";
            // 
            // Box6
            // 
            this.Box6.Location = new System.Drawing.Point(1552, 398);
            this.Box6.Margin = new System.Windows.Forms.Padding(4);
            this.Box6.Name = "Box6";
            this.Box6.Size = new System.Drawing.Size(65, 22);
            this.Box6.TabIndex = 65;
            // 
            // Box5
            // 
            this.Box5.Location = new System.Drawing.Point(1552, 349);
            this.Box5.Margin = new System.Windows.Forms.Padding(4);
            this.Box5.Name = "Box5";
            this.Box5.Size = new System.Drawing.Size(65, 22);
            this.Box5.TabIndex = 66;
            // 
            // Box4
            // 
            this.Box4.Location = new System.Drawing.Point(1552, 299);
            this.Box4.Margin = new System.Windows.Forms.Padding(4);
            this.Box4.Name = "Box4";
            this.Box4.Size = new System.Drawing.Size(65, 22);
            this.Box4.TabIndex = 67;
            // 
            // Box7
            // 
            this.Box7.Location = new System.Drawing.Point(1552, 447);
            this.Box7.Margin = new System.Windows.Forms.Padding(4);
            this.Box7.Name = "Box7";
            this.Box7.Size = new System.Drawing.Size(65, 22);
            this.Box7.TabIndex = 68;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(1451, 452);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(31, 20);
            this.label21.TabIndex = 69;
            this.label21.Text = "РР";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(1256, 437);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(167, 44);
            this.buttonDelete.TabIndex = 70;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // comboBoxGr
            // 
            this.comboBoxGr.FormattingEnabled = true;
            this.comboBoxGr.Location = new System.Drawing.Point(1496, 15);
            this.comboBoxGr.Name = "comboBoxGr";
            this.comboBoxGr.Size = new System.Drawing.Size(121, 24);
            this.comboBoxGr.TabIndex = 71;
            this.comboBoxGr.SelectedIndexChanged += new System.EventHandler(this.comboBoxGr_SelectedIndexChanged);
            // 
            // FormAttestation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1632, 658);
            this.Controls.Add(this.comboBoxGr);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.Box7);
            this.Controls.Add(this.Box4);
            this.Controls.Add(this.Box5);
            this.Controls.Add(this.Box6);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Box3);
            this.Controls.Add(this.Box2);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.comboBoxPr);
            this.Controls.Add(this.comboBoxProfil);
            this.Controls.Add(this.buttonSendAtt);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Box1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comboBoxSt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAttestation";
            this.Text = "Аттестация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAttestation_FormClosed);
            this.Load += new System.EventHandler(this.FormAttestation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSendAtt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox Box1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxSt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox comboBoxProfil;
        private System.Windows.Forms.ComboBox comboBoxPr;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox Box2;
        private System.Windows.Forms.TextBox Box3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox Box6;
        private System.Windows.Forms.TextBox Box5;
        private System.Windows.Forms.TextBox Box4;
        private System.Windows.Forms.TextBox Box7;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ComboBox comboBoxGr;
    }
}