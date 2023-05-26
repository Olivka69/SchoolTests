
namespace SchoolTests
{
    partial class Form_TestsResults
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_TestsResults));
            this.TestsResults_DataGridView = new System.Windows.Forms.DataGridView();
            this.iDresultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateresultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDstudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schooltestDataSet = new SchoolTests.schooltestDataSet();
            this.iDmoduleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.modulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sumpointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resultsTableAdapter = new SchoolTests.schooltestDataSetTableAdapters.ResultsTableAdapter();
            this.studentsTableAdapter = new SchoolTests.schooltestDataSetTableAdapters.StudentsTableAdapter();
            this.modulesTableAdapter = new SchoolTests.schooltestDataSetTableAdapters.ModulesTableAdapter();
            this.Teachers_DataGridView = new System.Windows.Forms.DataGridView();
            this.iDlecturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnamelecturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namelecturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginlecturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordlecturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDspecialtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecturersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lecturersTableAdapter = new SchoolTests.schooltestDataSetTableAdapters.LecturersTableAdapter();
            this.Conformity_DataGridView = new System.Windows.Forms.DataGridView();
            this.iDconformityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDspecialtyDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDdisciplineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conformityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.conformityTableAdapter = new SchoolTests.schooltestDataSetTableAdapters.ConformityTableAdapter();
            this.Tests_DataGridView = new System.Windows.Forms.DataGridView();
            this.iDmoduleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namemoduleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDdisciplineDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Choice_Button = new System.Windows.Forms.Button();
            this.Test_ComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Close_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TestsResults_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schooltestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Teachers_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Conformity_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conformityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tests_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TestsResults_DataGridView
            // 
            this.TestsResults_DataGridView.AutoGenerateColumns = false;
            this.TestsResults_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TestsResults_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TestsResults_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDresultDataGridViewTextBoxColumn,
            this.dateresultDataGridViewTextBoxColumn,
            this.iDstudentDataGridViewTextBoxColumn,
            this.iDmoduleDataGridViewTextBoxColumn,
            this.sumpointsDataGridViewTextBoxColumn});
            this.TestsResults_DataGridView.DataSource = this.resultsBindingSource;
            this.TestsResults_DataGridView.Location = new System.Drawing.Point(2, 63);
            this.TestsResults_DataGridView.Name = "TestsResults_DataGridView";
            this.TestsResults_DataGridView.ReadOnly = true;
            this.TestsResults_DataGridView.Size = new System.Drawing.Size(628, 322);
            this.TestsResults_DataGridView.TabIndex = 0;
            // 
            // iDresultDataGridViewTextBoxColumn
            // 
            this.iDresultDataGridViewTextBoxColumn.DataPropertyName = "ID_result";
            this.iDresultDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDresultDataGridViewTextBoxColumn.Name = "iDresultDataGridViewTextBoxColumn";
            this.iDresultDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateresultDataGridViewTextBoxColumn
            // 
            this.dateresultDataGridViewTextBoxColumn.DataPropertyName = "Date_result";
            this.dateresultDataGridViewTextBoxColumn.HeaderText = "Дата тестирования";
            this.dateresultDataGridViewTextBoxColumn.Name = "dateresultDataGridViewTextBoxColumn";
            this.dateresultDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDstudentDataGridViewTextBoxColumn
            // 
            this.iDstudentDataGridViewTextBoxColumn.DataPropertyName = "ID_student";
            this.iDstudentDataGridViewTextBoxColumn.DataSource = this.studentsBindingSource;
            this.iDstudentDataGridViewTextBoxColumn.DisplayMember = "Surname_student";
            this.iDstudentDataGridViewTextBoxColumn.HeaderText = "Фамилия учащегося";
            this.iDstudentDataGridViewTextBoxColumn.Name = "iDstudentDataGridViewTextBoxColumn";
            this.iDstudentDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDstudentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDstudentDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDstudentDataGridViewTextBoxColumn.ValueMember = "ID_student";
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.schooltestDataSet;
            // 
            // schooltestDataSet
            // 
            this.schooltestDataSet.DataSetName = "schooltestDataSet";
            this.schooltestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iDmoduleDataGridViewTextBoxColumn
            // 
            this.iDmoduleDataGridViewTextBoxColumn.DataPropertyName = "ID_module";
            this.iDmoduleDataGridViewTextBoxColumn.DataSource = this.modulesBindingSource;
            this.iDmoduleDataGridViewTextBoxColumn.DisplayMember = "Name_module";
            this.iDmoduleDataGridViewTextBoxColumn.HeaderText = "Тест";
            this.iDmoduleDataGridViewTextBoxColumn.Name = "iDmoduleDataGridViewTextBoxColumn";
            this.iDmoduleDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDmoduleDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDmoduleDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDmoduleDataGridViewTextBoxColumn.ValueMember = "ID_module";
            // 
            // modulesBindingSource
            // 
            this.modulesBindingSource.DataMember = "Modules";
            this.modulesBindingSource.DataSource = this.schooltestDataSet;
            // 
            // sumpointsDataGridViewTextBoxColumn
            // 
            this.sumpointsDataGridViewTextBoxColumn.DataPropertyName = "Sum_points";
            this.sumpointsDataGridViewTextBoxColumn.HeaderText = "Правильных ответов (%)";
            this.sumpointsDataGridViewTextBoxColumn.Name = "sumpointsDataGridViewTextBoxColumn";
            this.sumpointsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resultsBindingSource
            // 
            this.resultsBindingSource.DataMember = "Results";
            this.resultsBindingSource.DataSource = this.schooltestDataSet;
            // 
            // resultsTableAdapter
            // 
            this.resultsTableAdapter.ClearBeforeFill = true;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // modulesTableAdapter
            // 
            this.modulesTableAdapter.ClearBeforeFill = true;
            // 
            // Teachers_DataGridView
            // 
            this.Teachers_DataGridView.AutoGenerateColumns = false;
            this.Teachers_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Teachers_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDlecturerDataGridViewTextBoxColumn,
            this.surnamelecturerDataGridViewTextBoxColumn,
            this.namelecturerDataGridViewTextBoxColumn,
            this.loginlecturerDataGridViewTextBoxColumn,
            this.passwordlecturerDataGridViewTextBoxColumn,
            this.iDspecialtyDataGridViewTextBoxColumn});
            this.Teachers_DataGridView.DataSource = this.lecturersBindingSource;
            this.Teachers_DataGridView.Location = new System.Drawing.Point(651, 21);
            this.Teachers_DataGridView.Name = "Teachers_DataGridView";
            this.Teachers_DataGridView.Size = new System.Drawing.Size(43, 23);
            this.Teachers_DataGridView.TabIndex = 1;
            this.Teachers_DataGridView.Visible = false;
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
            // lecturersBindingSource
            // 
            this.lecturersBindingSource.DataMember = "Lecturers";
            this.lecturersBindingSource.DataSource = this.schooltestDataSet;
            // 
            // lecturersTableAdapter
            // 
            this.lecturersTableAdapter.ClearBeforeFill = true;
            // 
            // Conformity_DataGridView
            // 
            this.Conformity_DataGridView.AutoGenerateColumns = false;
            this.Conformity_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Conformity_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDconformityDataGridViewTextBoxColumn,
            this.iDspecialtyDataGridViewTextBoxColumn1,
            this.iDdisciplineDataGridViewTextBoxColumn});
            this.Conformity_DataGridView.DataSource = this.conformityBindingSource;
            this.Conformity_DataGridView.Location = new System.Drawing.Point(700, 21);
            this.Conformity_DataGridView.Name = "Conformity_DataGridView";
            this.Conformity_DataGridView.Size = new System.Drawing.Size(43, 26);
            this.Conformity_DataGridView.TabIndex = 2;
            this.Conformity_DataGridView.Visible = false;
            // 
            // iDconformityDataGridViewTextBoxColumn
            // 
            this.iDconformityDataGridViewTextBoxColumn.DataPropertyName = "ID_conformity";
            this.iDconformityDataGridViewTextBoxColumn.HeaderText = "ID_conformity";
            this.iDconformityDataGridViewTextBoxColumn.Name = "iDconformityDataGridViewTextBoxColumn";
            this.iDconformityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDspecialtyDataGridViewTextBoxColumn1
            // 
            this.iDspecialtyDataGridViewTextBoxColumn1.DataPropertyName = "ID_specialty";
            this.iDspecialtyDataGridViewTextBoxColumn1.HeaderText = "ID_specialty";
            this.iDspecialtyDataGridViewTextBoxColumn1.Name = "iDspecialtyDataGridViewTextBoxColumn1";
            // 
            // iDdisciplineDataGridViewTextBoxColumn
            // 
            this.iDdisciplineDataGridViewTextBoxColumn.DataPropertyName = "ID_discipline";
            this.iDdisciplineDataGridViewTextBoxColumn.HeaderText = "ID_discipline";
            this.iDdisciplineDataGridViewTextBoxColumn.Name = "iDdisciplineDataGridViewTextBoxColumn";
            // 
            // conformityBindingSource
            // 
            this.conformityBindingSource.DataMember = "Conformity";
            this.conformityBindingSource.DataSource = this.schooltestDataSet;
            // 
            // conformityTableAdapter
            // 
            this.conformityTableAdapter.ClearBeforeFill = true;
            // 
            // Tests_DataGridView
            // 
            this.Tests_DataGridView.AutoGenerateColumns = false;
            this.Tests_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tests_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDmoduleDataGridViewTextBoxColumn1,
            this.namemoduleDataGridViewTextBoxColumn,
            this.iDdisciplineDataGridViewTextBoxColumn1});
            this.Tests_DataGridView.DataSource = this.modulesBindingSource;
            this.Tests_DataGridView.Location = new System.Drawing.Point(749, 21);
            this.Tests_DataGridView.Name = "Tests_DataGridView";
            this.Tests_DataGridView.Size = new System.Drawing.Size(42, 26);
            this.Tests_DataGridView.TabIndex = 3;
            this.Tests_DataGridView.Visible = false;
            // 
            // iDmoduleDataGridViewTextBoxColumn1
            // 
            this.iDmoduleDataGridViewTextBoxColumn1.DataPropertyName = "ID_module";
            this.iDmoduleDataGridViewTextBoxColumn1.HeaderText = "ID_module";
            this.iDmoduleDataGridViewTextBoxColumn1.Name = "iDmoduleDataGridViewTextBoxColumn1";
            this.iDmoduleDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // namemoduleDataGridViewTextBoxColumn
            // 
            this.namemoduleDataGridViewTextBoxColumn.DataPropertyName = "Name_module";
            this.namemoduleDataGridViewTextBoxColumn.HeaderText = "Name_module";
            this.namemoduleDataGridViewTextBoxColumn.Name = "namemoduleDataGridViewTextBoxColumn";
            // 
            // iDdisciplineDataGridViewTextBoxColumn1
            // 
            this.iDdisciplineDataGridViewTextBoxColumn1.DataPropertyName = "ID_discipline";
            this.iDdisciplineDataGridViewTextBoxColumn1.HeaderText = "ID_discipline";
            this.iDdisciplineDataGridViewTextBoxColumn1.Name = "iDdisciplineDataGridViewTextBoxColumn1";
            // 
            // Choice_Button
            // 
            this.Choice_Button.BackColor = System.Drawing.Color.Silver;
            this.Choice_Button.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Choice_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Choice_Button.Location = new System.Drawing.Point(507, 18);
            this.Choice_Button.Name = "Choice_Button";
            this.Choice_Button.Size = new System.Drawing.Size(123, 28);
            this.Choice_Button.TabIndex = 70;
            this.Choice_Button.Text = "Выбрать";
            this.Choice_Button.UseVisualStyleBackColor = false;
            this.Choice_Button.Click += new System.EventHandler(this.Choice_Button_Click);
            // 
            // Test_ComboBox
            // 
            this.Test_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Test_ComboBox.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Test_ComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Test_ComboBox.FormattingEnabled = true;
            this.Test_ComboBox.Location = new System.Drawing.Point(98, 18);
            this.Test_ComboBox.Name = "Test_ComboBox";
            this.Test_ComboBox.Size = new System.Drawing.Size(403, 27);
            this.Test_ComboBox.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(-2, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 68;
            this.label1.Text = "Тема теста:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(171, 399);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(396, 20);
            this.label10.TabIndex = 74;
            this.label10.Text = "Результаты тестирования учащися по заданной теме";
            // 
            // Close_Button
            // 
            this.Close_Button.BackColor = System.Drawing.Color.Silver;
            this.Close_Button.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Close_Button.ForeColor = System.Drawing.Color.Maroon;
            this.Close_Button.Location = new System.Drawing.Point(2, 391);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(163, 32);
            this.Close_Button.TabIndex = 73;
            this.Close_Button.Text = "Закрыть";
            this.Close_Button.UseVisualStyleBackColor = false;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(632, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 322);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            // 
            // Form_TestsResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(975, 425);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Close_Button);
            this.Controls.Add(this.Choice_Button);
            this.Controls.Add(this.Test_ComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tests_DataGridView);
            this.Controls.Add(this.Conformity_DataGridView);
            this.Controls.Add(this.Teachers_DataGridView);
            this.Controls.Add(this.TestsResults_DataGridView);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_TestsResults";
            this.Text = "Результаты тестирования";
            this.Load += new System.EventHandler(this.Form_TestsResults_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TestsResults_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schooltestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modulesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Teachers_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Conformity_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conformityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tests_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TestsResults_DataGridView;
        private schooltestDataSet schooltestDataSet;
        private System.Windows.Forms.BindingSource resultsBindingSource;
        private schooltestDataSetTableAdapters.ResultsTableAdapter resultsTableAdapter;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private schooltestDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.BindingSource modulesBindingSource;
        private schooltestDataSetTableAdapters.ModulesTableAdapter modulesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDresultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateresultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDstudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDmoduleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumpointsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView Teachers_DataGridView;
        private System.Windows.Forms.BindingSource lecturersBindingSource;
        private schooltestDataSetTableAdapters.LecturersTableAdapter lecturersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDlecturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnamelecturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namelecturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginlecturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordlecturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDspecialtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView Conformity_DataGridView;
        private System.Windows.Forms.BindingSource conformityBindingSource;
        private schooltestDataSetTableAdapters.ConformityTableAdapter conformityTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDconformityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDspecialtyDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDdisciplineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView Tests_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDmoduleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn namemoduleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDdisciplineDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button Choice_Button;
        private System.Windows.Forms.ComboBox Test_ComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Close_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}