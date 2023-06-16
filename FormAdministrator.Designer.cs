namespace kursah
{
    partial class FormAdministrator
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
            this.ToolStripAttest = new System.Windows.Forms.ToolStripMenuItem();
            this.преподавательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripOtchet = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripRedact = new System.Windows.Forms.ToolStripMenuItem();
            this.специальностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTables = new System.Windows.Forms.Button();
            this.btnOtchet = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnTeacher = new System.Windows.Forms.Button();
            this.btnUnivers = new System.Windows.Forms.Button();
            this.btnAttest = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonOtchet = new System.Windows.Forms.Button();
            this.Меню = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolStripAttest
            // 
            this.ToolStripAttest.Name = "ToolStripAttest";
            this.ToolStripAttest.Size = new System.Drawing.Size(32, 19);
            // 
            // преподавательToolStripMenuItem
            // 
            this.преподавательToolStripMenuItem.Name = "преподавательToolStripMenuItem";
            this.преподавательToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // студентToolStripMenuItem
            // 
            this.студентToolStripMenuItem.Name = "студентToolStripMenuItem";
            this.студентToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // ToolStripOtchet
            // 
            this.ToolStripOtchet.Name = "ToolStripOtchet";
            this.ToolStripOtchet.Size = new System.Drawing.Size(32, 19);
            // 
            // ToolStripRedact
            // 
            this.ToolStripRedact.Name = "ToolStripRedact";
            this.ToolStripRedact.Size = new System.Drawing.Size(32, 19);
            // 
            // специальностьToolStripMenuItem
            // 
            this.специальностьToolStripMenuItem.Name = "специальностьToolStripMenuItem";
            this.специальностьToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // btnTables
            // 
            this.btnTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTables.Location = new System.Drawing.Point(73, 325);
            this.btnTables.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTables.Name = "btnTables";
            this.btnTables.Size = new System.Drawing.Size(320, 49);
            this.btnTables.TabIndex = 7;
            this.btnTables.Text = "Работа с таблицами";
            this.btnTables.UseVisualStyleBackColor = true;
            this.btnTables.Click += new System.EventHandler(this.btnTables_Click);
            // 
            // btnOtchet
            // 
            this.btnOtchet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOtchet.Location = new System.Drawing.Point(73, 379);
            this.btnOtchet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOtchet.Name = "btnOtchet";
            this.btnOtchet.Size = new System.Drawing.Size(320, 44);
            this.btnOtchet.TabIndex = 9;
            this.btnOtchet.Text = "Категории";
            this.btnOtchet.UseVisualStyleBackColor = true;
            this.btnOtchet.Click += new System.EventHandler(this.btnOtchet_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudents.Location = new System.Drawing.Point(7, 26);
            this.btnStudents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(319, 47);
            this.btnStudents.TabIndex = 6;
            this.btnStudents.Text = "Студенты";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnTeacher
            // 
            this.btnTeacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTeacher.Location = new System.Drawing.Point(7, 73);
            this.btnTeacher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(319, 50);
            this.btnTeacher.TabIndex = 5;
            this.btnTeacher.Text = "Преподаватели";
            this.btnTeacher.UseVisualStyleBackColor = true;
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
            // 
            // btnUnivers
            // 
            this.btnUnivers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUnivers.Location = new System.Drawing.Point(7, 123);
            this.btnUnivers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUnivers.Name = "btnUnivers";
            this.btnUnivers.Size = new System.Drawing.Size(319, 52);
            this.btnUnivers.TabIndex = 8;
            this.btnUnivers.Text = "Об университете";
            this.btnUnivers.UseVisualStyleBackColor = true;
            this.btnUnivers.Click += new System.EventHandler(this.btnUniverse_Click);
            // 
            // btnAttest
            // 
            this.btnAttest.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAttest.Location = new System.Drawing.Point(7, 175);
            this.btnAttest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAttest.Name = "btnAttest";
            this.btnAttest.Size = new System.Drawing.Size(319, 48);
            this.btnAttest.TabIndex = 4;
            this.btnAttest.Text = "Аттестация";
            this.btnAttest.UseVisualStyleBackColor = true;
            this.btnAttest.Click += new System.EventHandler(this.btnAttest_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAttest);
            this.groupBox1.Controls.Add(this.btnUnivers);
            this.groupBox1.Controls.Add(this.btnTeacher);
            this.groupBox1.Controls.Add(this.btnStudents);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(67, 74);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.groupBox1.Size = new System.Drawing.Size(333, 246);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавление данных";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonOtchet);
            this.panel1.Controls.Add(this.Меню);
            this.panel1.Controls.Add(this.btnOtchet);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnTables);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 521);
            this.panel1.TabIndex = 13;
            // 
            // buttonOtchet
            // 
            this.buttonOtchet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.buttonOtchet.Location = new System.Drawing.Point(73, 437);
            this.buttonOtchet.Name = "buttonOtchet";
            this.buttonOtchet.Size = new System.Drawing.Size(320, 52);
            this.buttonOtchet.TabIndex = 14;
            this.buttonOtchet.Text = "Отчет успеваемости";
            this.buttonOtchet.UseVisualStyleBackColor = true;
            this.buttonOtchet.Click += new System.EventHandler(this.buttonOtchet_Click);
            // 
            // Меню
            // 
            this.Меню.AutoSize = true;
            this.Меню.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Меню.Location = new System.Drawing.Point(187, 23);
            this.Меню.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Меню.Name = "Меню";
            this.Меню.Size = new System.Drawing.Size(86, 31);
            this.Меню.TabIndex = 14;
            this.Меню.Text = "Меню";
            // 
            // FormAdministrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 491);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormAdministrator";
            this.Text = "Меню";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem ToolStripAttest;
        private System.Windows.Forms.ToolStripMenuItem преподавательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripOtchet;
        private System.Windows.Forms.ToolStripMenuItem ToolStripRedact;
        private System.Windows.Forms.ToolStripMenuItem специальностьToolStripMenuItem;
        private System.Windows.Forms.Button btnTables;
        private System.Windows.Forms.Button btnOtchet;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnTeacher;
        private System.Windows.Forms.Button btnUnivers;
        private System.Windows.Forms.Button btnAttest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Меню;
        private System.Windows.Forms.Button buttonOtchet;
    }
}