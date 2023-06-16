namespace kursah
{
    partial class FormStudents
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.GroupCb = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.CourseTb = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.OtchestvoTb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SurNameTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.NumberIDTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(867, 628);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.GroupCb);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.CourseTb);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.OtchestvoTb);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.NameTb);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.SurNameTb);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.NumberIDTb);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1181, 657);
            this.panel1.TabIndex = 14;
            // 
            // GroupCb
            // 
            this.GroupCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GroupCb.FormattingEnabled = true;
            this.GroupCb.Location = new System.Drawing.Point(899, 409);
            this.GroupCb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GroupCb.Name = "GroupCb";
            this.GroupCb.Size = new System.Drawing.Size(265, 24);
            this.GroupCb.TabIndex = 27;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(899, 448);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(267, 62);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(899, 383);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "Номер группы";
            // 
            // CourseTb
            // 
            this.CourseTb.Location = new System.Drawing.Point(899, 343);
            this.CourseTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CourseTb.Name = "CourseTb";
            this.CourseTb.Size = new System.Drawing.Size(265, 22);
            this.CourseTb.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(899, 318);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Курс";
            // 
            // OtchestvoTb
            // 
            this.OtchestvoTb.Location = new System.Drawing.Point(899, 278);
            this.OtchestvoTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OtchestvoTb.Name = "OtchestvoTb";
            this.OtchestvoTb.Size = new System.Drawing.Size(265, 22);
            this.OtchestvoTb.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(899, 252);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Отчество";
            // 
            // NameTb
            // 
            this.NameTb.Location = new System.Drawing.Point(899, 213);
            this.NameTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(265, 22);
            this.NameTb.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(899, 187);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Имя";
            // 
            // SurNameTb
            // 
            this.SurNameTb.Location = new System.Drawing.Point(899, 148);
            this.SurNameTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SurNameTb.Name = "SurNameTb";
            this.SurNameTb.Size = new System.Drawing.Size(265, 22);
            this.SurNameTb.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(899, 122);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Фамилия";
            // 
            // NumberIDTb
            // 
            this.NumberIDTb.Location = new System.Drawing.Point(899, 82);
            this.NumberIDTb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NumberIDTb.Name = "NumberIDTb";
            this.NumberIDTb.Size = new System.Drawing.Size(265, 22);
            this.NumberIDTb.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(899, 57);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Номер зачетной книжки";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(899, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Добавление студента";
            // 
            // FormStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 656);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormStudents";
            this.Text = "Данные студента";
            this.Load += new System.EventHandler(this.FormStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox GroupCb;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox CourseTb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox OtchestvoTb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox NameTb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox SurNameTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NumberIDTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}