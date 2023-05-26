
namespace SchoolTests
{
    partial class Form_Auth
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Auth));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Teacher_RadioButton = new System.Windows.Forms.RadioButton();
            this.Student_RadioButton = new System.Windows.Forms.RadioButton();
            this.Lecturers_DataGridView = new System.Windows.Forms.DataGridView();
            this.schooltestDataSet = new SchoolTests.schooltestDataSet();
            this.lecturersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lecturersTableAdapter = new SchoolTests.schooltestDataSetTableAdapters.LecturersTableAdapter();
            this.iDlecturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnamelecturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namelecturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginlecturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordlecturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDspecialtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Students_DataGridView = new System.Windows.Forms.DataGridView();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new SchoolTests.schooltestDataSetTableAdapters.StudentsTableAdapter();
            this.iDstudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnamestudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namestudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classstudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginstudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordstudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login_ComboBox = new System.Windows.Forms.ComboBox();
            this.Password_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Auth_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lecturers_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schooltestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Students_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Student_RadioButton);
            this.groupBox1.Controls.Add(this.Teacher_RadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вариант авторизации";
            // 
            // Teacher_RadioButton
            // 
            this.Teacher_RadioButton.AutoSize = true;
            this.Teacher_RadioButton.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Teacher_RadioButton.ForeColor = System.Drawing.Color.Navy;
            this.Teacher_RadioButton.Location = new System.Drawing.Point(36, 34);
            this.Teacher_RadioButton.Name = "Teacher_RadioButton";
            this.Teacher_RadioButton.Size = new System.Drawing.Size(86, 23);
            this.Teacher_RadioButton.TabIndex = 0;
            this.Teacher_RadioButton.TabStop = true;
            this.Teacher_RadioButton.Text = "Педагог";
            this.Teacher_RadioButton.UseVisualStyleBackColor = true;
            this.Teacher_RadioButton.CheckedChanged += new System.EventHandler(this.Teacher_RadioButton_CheckedChanged);
            // 
            // Student_RadioButton
            // 
            this.Student_RadioButton.AutoSize = true;
            this.Student_RadioButton.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Student_RadioButton.ForeColor = System.Drawing.Color.Navy;
            this.Student_RadioButton.Location = new System.Drawing.Point(184, 34);
            this.Student_RadioButton.Name = "Student_RadioButton";
            this.Student_RadioButton.Size = new System.Drawing.Size(94, 23);
            this.Student_RadioButton.TabIndex = 1;
            this.Student_RadioButton.TabStop = true;
            this.Student_RadioButton.Text = "Учащийся";
            this.Student_RadioButton.UseVisualStyleBackColor = true;
            this.Student_RadioButton.CheckedChanged += new System.EventHandler(this.Student_RadioButton_CheckedChanged);
            // 
            // Lecturers_DataGridView
            // 
            this.Lecturers_DataGridView.AutoGenerateColumns = false;
            this.Lecturers_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Lecturers_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDlecturerDataGridViewTextBoxColumn,
            this.surnamelecturerDataGridViewTextBoxColumn,
            this.namelecturerDataGridViewTextBoxColumn,
            this.loginlecturerDataGridViewTextBoxColumn,
            this.passwordlecturerDataGridViewTextBoxColumn,
            this.iDspecialtyDataGridViewTextBoxColumn});
            this.Lecturers_DataGridView.DataSource = this.lecturersBindingSource;
            this.Lecturers_DataGridView.Location = new System.Drawing.Point(89, 173);
            this.Lecturers_DataGridView.Name = "Lecturers_DataGridView";
            this.Lecturers_DataGridView.Size = new System.Drawing.Size(39, 22);
            this.Lecturers_DataGridView.TabIndex = 1;
            this.Lecturers_DataGridView.Visible = false;
            // 
            // schooltestDataSet
            // 
            this.schooltestDataSet.DataSetName = "schooltestDataSet";
            this.schooltestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lecturersBindingSource
            // 
            this.lecturersBindingSource.DataMember = "Lecturers";
            this.lecturersBindingSource.DataSource = this.schooltestDataSet;
            // 
            // lecturersTableAdapter
            // 
            this.lecturersTableAdapter.ClearBeforeFill = true;
            // 
            // iDlecturerDataGridViewTextBoxColumn
            // 
            this.iDlecturerDataGridViewTextBoxColumn.DataPropertyName = "ID_lecturer";
            this.iDlecturerDataGridViewTextBoxColumn.HeaderText = "ID_lecturer";
            this.iDlecturerDataGridViewTextBoxColumn.Name = "iDlecturerDataGridViewTextBoxColumn";
            this.iDlecturerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnamelecturerDataGridViewTextBoxColumn
            // 
            this.surnamelecturerDataGridViewTextBoxColumn.DataPropertyName = "Surname_lecturer";
            this.surnamelecturerDataGridViewTextBoxColumn.HeaderText = "Surname_lecturer";
            this.surnamelecturerDataGridViewTextBoxColumn.Name = "surnamelecturerDataGridViewTextBoxColumn";
            // 
            // namelecturerDataGridViewTextBoxColumn
            // 
            this.namelecturerDataGridViewTextBoxColumn.DataPropertyName = "Name_lecturer";
            this.namelecturerDataGridViewTextBoxColumn.HeaderText = "Name_lecturer";
            this.namelecturerDataGridViewTextBoxColumn.Name = "namelecturerDataGridViewTextBoxColumn";
            // 
            // loginlecturerDataGridViewTextBoxColumn
            // 
            this.loginlecturerDataGridViewTextBoxColumn.DataPropertyName = "Login_lecturer";
            this.loginlecturerDataGridViewTextBoxColumn.HeaderText = "Login_lecturer";
            this.loginlecturerDataGridViewTextBoxColumn.Name = "loginlecturerDataGridViewTextBoxColumn";
            // 
            // passwordlecturerDataGridViewTextBoxColumn
            // 
            this.passwordlecturerDataGridViewTextBoxColumn.DataPropertyName = "Password_lecturer";
            this.passwordlecturerDataGridViewTextBoxColumn.HeaderText = "Password_lecturer";
            this.passwordlecturerDataGridViewTextBoxColumn.Name = "passwordlecturerDataGridViewTextBoxColumn";
            // 
            // iDspecialtyDataGridViewTextBoxColumn
            // 
            this.iDspecialtyDataGridViewTextBoxColumn.DataPropertyName = "ID_specialty";
            this.iDspecialtyDataGridViewTextBoxColumn.HeaderText = "ID_specialty";
            this.iDspecialtyDataGridViewTextBoxColumn.Name = "iDspecialtyDataGridViewTextBoxColumn";
            // 
            // Students_DataGridView
            // 
            this.Students_DataGridView.AutoGenerateColumns = false;
            this.Students_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Students_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDstudentDataGridViewTextBoxColumn,
            this.surnamestudentDataGridViewTextBoxColumn,
            this.namestudentDataGridViewTextBoxColumn,
            this.classstudentDataGridViewTextBoxColumn,
            this.loginstudentDataGridViewTextBoxColumn,
            this.passwordstudentDataGridViewTextBoxColumn});
            this.Students_DataGridView.DataSource = this.studentsBindingSource;
            this.Students_DataGridView.Location = new System.Drawing.Point(134, 173);
            this.Students_DataGridView.Name = "Students_DataGridView";
            this.Students_DataGridView.Size = new System.Drawing.Size(42, 22);
            this.Students_DataGridView.TabIndex = 2;
            this.Students_DataGridView.Visible = false;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.schooltestDataSet;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // iDstudentDataGridViewTextBoxColumn
            // 
            this.iDstudentDataGridViewTextBoxColumn.DataPropertyName = "ID_student";
            this.iDstudentDataGridViewTextBoxColumn.HeaderText = "ID_student";
            this.iDstudentDataGridViewTextBoxColumn.Name = "iDstudentDataGridViewTextBoxColumn";
            this.iDstudentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnamestudentDataGridViewTextBoxColumn
            // 
            this.surnamestudentDataGridViewTextBoxColumn.DataPropertyName = "Surname_student";
            this.surnamestudentDataGridViewTextBoxColumn.HeaderText = "Surname_student";
            this.surnamestudentDataGridViewTextBoxColumn.Name = "surnamestudentDataGridViewTextBoxColumn";
            // 
            // namestudentDataGridViewTextBoxColumn
            // 
            this.namestudentDataGridViewTextBoxColumn.DataPropertyName = "Name_student";
            this.namestudentDataGridViewTextBoxColumn.HeaderText = "Name_student";
            this.namestudentDataGridViewTextBoxColumn.Name = "namestudentDataGridViewTextBoxColumn";
            // 
            // classstudentDataGridViewTextBoxColumn
            // 
            this.classstudentDataGridViewTextBoxColumn.DataPropertyName = "Class_student";
            this.classstudentDataGridViewTextBoxColumn.HeaderText = "Class_student";
            this.classstudentDataGridViewTextBoxColumn.Name = "classstudentDataGridViewTextBoxColumn";
            // 
            // loginstudentDataGridViewTextBoxColumn
            // 
            this.loginstudentDataGridViewTextBoxColumn.DataPropertyName = "Login_student";
            this.loginstudentDataGridViewTextBoxColumn.HeaderText = "Login_student";
            this.loginstudentDataGridViewTextBoxColumn.Name = "loginstudentDataGridViewTextBoxColumn";
            // 
            // passwordstudentDataGridViewTextBoxColumn
            // 
            this.passwordstudentDataGridViewTextBoxColumn.DataPropertyName = "Password_student";
            this.passwordstudentDataGridViewTextBoxColumn.HeaderText = "Password_student";
            this.passwordstudentDataGridViewTextBoxColumn.Name = "passwordstudentDataGridViewTextBoxColumn";
            // 
            // Login_ComboBox
            // 
            this.Login_ComboBox.DataSource = this.lecturersBindingSource;
            this.Login_ComboBox.DisplayMember = "Login_lecturer";
            this.Login_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Login_ComboBox.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login_ComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Login_ComboBox.FormattingEnabled = true;
            this.Login_ComboBox.Location = new System.Drawing.Point(89, 97);
            this.Login_ComboBox.Name = "Login_ComboBox";
            this.Login_ComboBox.Size = new System.Drawing.Size(239, 27);
            this.Login_ComboBox.TabIndex = 42;
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Password_TextBox.Location = new System.Drawing.Point(88, 147);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.PasswordChar = '*';
            this.Password_TextBox.Size = new System.Drawing.Size(240, 26);
            this.Password_TextBox.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(7, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 40;
            this.label3.Text = "Пароль :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(7, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 39;
            this.label1.Text = "Логин :";
            // 
            // Exit_Button
            // 
            this.Exit_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Exit_Button.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_Button.ForeColor = System.Drawing.Color.Maroon;
            this.Exit_Button.Location = new System.Drawing.Point(183, 201);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(144, 32);
            this.Exit_Button.TabIndex = 44;
            this.Exit_Button.Text = "Выход";
            this.Exit_Button.UseVisualStyleBackColor = false;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Auth_Button
            // 
            this.Auth_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Auth_Button.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Auth_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Auth_Button.Location = new System.Drawing.Point(11, 201);
            this.Auth_Button.Name = "Auth_Button";
            this.Auth_Button.Size = new System.Drawing.Size(144, 32);
            this.Auth_Button.TabIndex = 43;
            this.Auth_Button.Text = "Авторизация";
            this.Auth_Button.UseVisualStyleBackColor = false;
            this.Auth_Button.Click += new System.EventHandler(this.Auth_Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(333, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(386, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // Form_Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(726, 239);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Auth_Button);
            this.Controls.Add(this.Login_ComboBox);
            this.Controls.Add(this.Password_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Students_DataGridView);
            this.Controls.Add(this.Lecturers_DataGridView);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Auth";
            this.Text = "Авторизация в системе";
            this.Load += new System.EventHandler(this.Form_Auth_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Lecturers_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schooltestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Students_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Student_RadioButton;
        private System.Windows.Forms.RadioButton Teacher_RadioButton;
        private System.Windows.Forms.DataGridView Lecturers_DataGridView;
        private schooltestDataSet schooltestDataSet;
        private System.Windows.Forms.BindingSource lecturersBindingSource;
        private schooltestDataSetTableAdapters.LecturersTableAdapter lecturersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDlecturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnamelecturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namelecturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginlecturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordlecturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDspecialtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView Students_DataGridView;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private schooltestDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDstudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnamestudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namestudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classstudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginstudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordstudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox Login_ComboBox;
        private System.Windows.Forms.TextBox Password_TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Button Auth_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

