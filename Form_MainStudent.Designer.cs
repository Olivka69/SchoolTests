
namespace SchoolTests
{
    partial class Form_MainStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MainStudent));
            this.Test_ComboBox = new System.Windows.Forms.ComboBox();
            this.modulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schooltestDataSet = new SchoolTests.schooltestDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.modulesTableAdapter = new SchoolTests.schooltestDataSetTableAdapters.ModulesTableAdapter();
            this.Tests_DataGridView = new System.Windows.Forms.DataGridView();
            this.iDmoduleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namemoduleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDdisciplineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Questions_DataGridView = new System.Windows.Forms.DataGridView();
            this.iDquestionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textquestionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ans1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ans2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ans3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ans4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rightansDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDmoduleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questionsTableAdapter = new SchoolTests.schooltestDataSetTableAdapters.QuestionsTableAdapter();
            this.Question_GroupBox = new System.Windows.Forms.GroupBox();
            this.Questions_TextBox = new System.Windows.Forms.TextBox();
            this.Answers_GroupBox = new System.Windows.Forms.GroupBox();
            this.Ans_TextBox = new System.Windows.Forms.TextBox();
            this.Ans_Label = new System.Windows.Forms.Label();
            this.AnsVar4_RadioButton = new System.Windows.Forms.RadioButton();
            this.AnsVar3_RadioButton = new System.Windows.Forms.RadioButton();
            this.AnsVar2_RadioButton = new System.Windows.Forms.RadioButton();
            this.AnsVar1_RadioButton = new System.Windows.Forms.RadioButton();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.ResponceConfirmation_Button = new System.Windows.Forms.Button();
            this.TestBegin_Button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TestStatus_StatusStrip = new System.Windows.Forms.StatusStrip();
            this.TestStatus_StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TestTime_StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TestResults_StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TestStudent_StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Wait_PictureBox = new System.Windows.Forms.PictureBox();
            this.Test_Timer = new System.Windows.Forms.Timer(this.components);
            this.Results_DataGridView = new System.Windows.Forms.DataGridView();
            this.iDresultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateresultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDstudentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDmoduleDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumpointsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resultsTableAdapter = new SchoolTests.schooltestDataSetTableAdapters.ResultsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.modulesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schooltestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tests_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Questions_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).BeginInit();
            this.Question_GroupBox.SuspendLayout();
            this.Answers_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TestStatus_StatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Wait_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Results_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Test_ComboBox
            // 
            this.Test_ComboBox.DataSource = this.modulesBindingSource;
            this.Test_ComboBox.DisplayMember = "Name_module";
            this.Test_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Test_ComboBox.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Test_ComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Test_ComboBox.FormattingEnabled = true;
            this.Test_ComboBox.Location = new System.Drawing.Point(103, 6);
            this.Test_ComboBox.Name = "Test_ComboBox";
            this.Test_ComboBox.Size = new System.Drawing.Size(383, 27);
            this.Test_ComboBox.TabIndex = 69;
            this.Test_ComboBox.ValueMember = "ID_module";
            // 
            // modulesBindingSource
            // 
            this.modulesBindingSource.DataMember = "Modules";
            this.modulesBindingSource.DataSource = this.schooltestDataSet;
            // 
            // schooltestDataSet
            // 
            this.schooltestDataSet.DataSetName = "schooltestDataSet";
            this.schooltestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 19);
            this.label1.TabIndex = 68;
            this.label1.Text = "Тема теста:";
            // 
            // modulesTableAdapter
            // 
            this.modulesTableAdapter.ClearBeforeFill = true;
            // 
            // Tests_DataGridView
            // 
            this.Tests_DataGridView.AutoGenerateColumns = false;
            this.Tests_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tests_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDmoduleDataGridViewTextBoxColumn,
            this.namemoduleDataGridViewTextBoxColumn,
            this.iDdisciplineDataGridViewTextBoxColumn});
            this.Tests_DataGridView.DataSource = this.modulesBindingSource;
            this.Tests_DataGridView.Location = new System.Drawing.Point(744, 10);
            this.Tests_DataGridView.Name = "Tests_DataGridView";
            this.Tests_DataGridView.Size = new System.Drawing.Size(40, 23);
            this.Tests_DataGridView.TabIndex = 71;
            this.Tests_DataGridView.Visible = false;
            // 
            // iDmoduleDataGridViewTextBoxColumn
            // 
            this.iDmoduleDataGridViewTextBoxColumn.DataPropertyName = "ID_module";
            this.iDmoduleDataGridViewTextBoxColumn.HeaderText = "ID_module";
            this.iDmoduleDataGridViewTextBoxColumn.Name = "iDmoduleDataGridViewTextBoxColumn";
            this.iDmoduleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namemoduleDataGridViewTextBoxColumn
            // 
            this.namemoduleDataGridViewTextBoxColumn.DataPropertyName = "Name_module";
            this.namemoduleDataGridViewTextBoxColumn.HeaderText = "Name_module";
            this.namemoduleDataGridViewTextBoxColumn.Name = "namemoduleDataGridViewTextBoxColumn";
            // 
            // iDdisciplineDataGridViewTextBoxColumn
            // 
            this.iDdisciplineDataGridViewTextBoxColumn.DataPropertyName = "ID_discipline";
            this.iDdisciplineDataGridViewTextBoxColumn.HeaderText = "ID_discipline";
            this.iDdisciplineDataGridViewTextBoxColumn.Name = "iDdisciplineDataGridViewTextBoxColumn";
            // 
            // Questions_DataGridView
            // 
            this.Questions_DataGridView.AutoGenerateColumns = false;
            this.Questions_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Questions_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDquestionDataGridViewTextBoxColumn,
            this.textquestionDataGridViewTextBoxColumn,
            this.ans1DataGridViewTextBoxColumn,
            this.ans2DataGridViewTextBoxColumn,
            this.ans3DataGridViewTextBoxColumn,
            this.ans4DataGridViewTextBoxColumn,
            this.rightansDataGridViewTextBoxColumn,
            this.iDmoduleDataGridViewTextBoxColumn1});
            this.Questions_DataGridView.DataSource = this.questionsBindingSource;
            this.Questions_DataGridView.Location = new System.Drawing.Point(790, 9);
            this.Questions_DataGridView.Name = "Questions_DataGridView";
            this.Questions_DataGridView.Size = new System.Drawing.Size(41, 23);
            this.Questions_DataGridView.TabIndex = 72;
            this.Questions_DataGridView.Visible = false;
            // 
            // iDquestionDataGridViewTextBoxColumn
            // 
            this.iDquestionDataGridViewTextBoxColumn.DataPropertyName = "ID_question";
            this.iDquestionDataGridViewTextBoxColumn.HeaderText = "ID_question";
            this.iDquestionDataGridViewTextBoxColumn.Name = "iDquestionDataGridViewTextBoxColumn";
            this.iDquestionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // textquestionDataGridViewTextBoxColumn
            // 
            this.textquestionDataGridViewTextBoxColumn.DataPropertyName = "Text_question";
            this.textquestionDataGridViewTextBoxColumn.HeaderText = "Text_question";
            this.textquestionDataGridViewTextBoxColumn.Name = "textquestionDataGridViewTextBoxColumn";
            // 
            // ans1DataGridViewTextBoxColumn
            // 
            this.ans1DataGridViewTextBoxColumn.DataPropertyName = "Ans1";
            this.ans1DataGridViewTextBoxColumn.HeaderText = "Ans1";
            this.ans1DataGridViewTextBoxColumn.Name = "ans1DataGridViewTextBoxColumn";
            // 
            // ans2DataGridViewTextBoxColumn
            // 
            this.ans2DataGridViewTextBoxColumn.DataPropertyName = "Ans2";
            this.ans2DataGridViewTextBoxColumn.HeaderText = "Ans2";
            this.ans2DataGridViewTextBoxColumn.Name = "ans2DataGridViewTextBoxColumn";
            // 
            // ans3DataGridViewTextBoxColumn
            // 
            this.ans3DataGridViewTextBoxColumn.DataPropertyName = "Ans3";
            this.ans3DataGridViewTextBoxColumn.HeaderText = "Ans3";
            this.ans3DataGridViewTextBoxColumn.Name = "ans3DataGridViewTextBoxColumn";
            // 
            // ans4DataGridViewTextBoxColumn
            // 
            this.ans4DataGridViewTextBoxColumn.DataPropertyName = "Ans4";
            this.ans4DataGridViewTextBoxColumn.HeaderText = "Ans4";
            this.ans4DataGridViewTextBoxColumn.Name = "ans4DataGridViewTextBoxColumn";
            // 
            // rightansDataGridViewTextBoxColumn
            // 
            this.rightansDataGridViewTextBoxColumn.DataPropertyName = "Right_ans";
            this.rightansDataGridViewTextBoxColumn.HeaderText = "Right_ans";
            this.rightansDataGridViewTextBoxColumn.Name = "rightansDataGridViewTextBoxColumn";
            // 
            // iDmoduleDataGridViewTextBoxColumn1
            // 
            this.iDmoduleDataGridViewTextBoxColumn1.DataPropertyName = "ID_module";
            this.iDmoduleDataGridViewTextBoxColumn1.HeaderText = "ID_module";
            this.iDmoduleDataGridViewTextBoxColumn1.Name = "iDmoduleDataGridViewTextBoxColumn1";
            // 
            // questionsBindingSource
            // 
            this.questionsBindingSource.DataMember = "Questions";
            this.questionsBindingSource.DataSource = this.schooltestDataSet;
            // 
            // questionsTableAdapter
            // 
            this.questionsTableAdapter.ClearBeforeFill = true;
            // 
            // Question_GroupBox
            // 
            this.Question_GroupBox.Controls.Add(this.Questions_TextBox);
            this.Question_GroupBox.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Question_GroupBox.ForeColor = System.Drawing.Color.Navy;
            this.Question_GroupBox.Location = new System.Drawing.Point(12, 64);
            this.Question_GroupBox.Name = "Question_GroupBox";
            this.Question_GroupBox.Size = new System.Drawing.Size(474, 111);
            this.Question_GroupBox.TabIndex = 73;
            this.Question_GroupBox.TabStop = false;
            this.Question_GroupBox.Text = "Текст вопроса";
            // 
            // Questions_TextBox
            // 
            this.Questions_TextBox.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Questions_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Questions_TextBox.Location = new System.Drawing.Point(6, 24);
            this.Questions_TextBox.Multiline = true;
            this.Questions_TextBox.Name = "Questions_TextBox";
            this.Questions_TextBox.ReadOnly = true;
            this.Questions_TextBox.Size = new System.Drawing.Size(460, 76);
            this.Questions_TextBox.TabIndex = 0;
            // 
            // Answers_GroupBox
            // 
            this.Answers_GroupBox.Controls.Add(this.Ans_TextBox);
            this.Answers_GroupBox.Controls.Add(this.Ans_Label);
            this.Answers_GroupBox.Controls.Add(this.AnsVar4_RadioButton);
            this.Answers_GroupBox.Controls.Add(this.AnsVar3_RadioButton);
            this.Answers_GroupBox.Controls.Add(this.AnsVar2_RadioButton);
            this.Answers_GroupBox.Controls.Add(this.AnsVar1_RadioButton);
            this.Answers_GroupBox.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Answers_GroupBox.ForeColor = System.Drawing.Color.Navy;
            this.Answers_GroupBox.Location = new System.Drawing.Point(12, 211);
            this.Answers_GroupBox.Name = "Answers_GroupBox";
            this.Answers_GroupBox.Size = new System.Drawing.Size(474, 208);
            this.Answers_GroupBox.TabIndex = 74;
            this.Answers_GroupBox.TabStop = false;
            this.Answers_GroupBox.Text = "Варианты ответов";
            // 
            // Ans_TextBox
            // 
            this.Ans_TextBox.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ans_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Ans_TextBox.Location = new System.Drawing.Point(64, 107);
            this.Ans_TextBox.Name = "Ans_TextBox";
            this.Ans_TextBox.Size = new System.Drawing.Size(378, 26);
            this.Ans_TextBox.TabIndex = 70;
            // 
            // Ans_Label
            // 
            this.Ans_Label.AutoSize = true;
            this.Ans_Label.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ans_Label.ForeColor = System.Drawing.Color.Purple;
            this.Ans_Label.Location = new System.Drawing.Point(59, 61);
            this.Ans_Label.Name = "Ans_Label";
            this.Ans_Label.Size = new System.Drawing.Size(191, 19);
            this.Ans_Label.TabIndex = 69;
            this.Ans_Label.Text = "Необходим точный ответ:";
            // 
            // AnsVar4_RadioButton
            // 
            this.AnsVar4_RadioButton.AutoSize = true;
            this.AnsVar4_RadioButton.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnsVar4_RadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.AnsVar4_RadioButton.Location = new System.Drawing.Point(17, 166);
            this.AnsVar4_RadioButton.Name = "AnsVar4_RadioButton";
            this.AnsVar4_RadioButton.Size = new System.Drawing.Size(149, 23);
            this.AnsVar4_RadioButton.TabIndex = 3;
            this.AnsVar4_RadioButton.TabStop = true;
            this.AnsVar4_RadioButton.Text = "Вариант ответа 4";
            this.AnsVar4_RadioButton.UseVisualStyleBackColor = true;
            // 
            // AnsVar3_RadioButton
            // 
            this.AnsVar3_RadioButton.AutoSize = true;
            this.AnsVar3_RadioButton.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnsVar3_RadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.AnsVar3_RadioButton.Location = new System.Drawing.Point(17, 123);
            this.AnsVar3_RadioButton.Name = "AnsVar3_RadioButton";
            this.AnsVar3_RadioButton.Size = new System.Drawing.Size(149, 23);
            this.AnsVar3_RadioButton.TabIndex = 2;
            this.AnsVar3_RadioButton.TabStop = true;
            this.AnsVar3_RadioButton.Text = "Вариант ответа 3";
            this.AnsVar3_RadioButton.UseVisualStyleBackColor = true;
            // 
            // AnsVar2_RadioButton
            // 
            this.AnsVar2_RadioButton.AutoSize = true;
            this.AnsVar2_RadioButton.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnsVar2_RadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.AnsVar2_RadioButton.Location = new System.Drawing.Point(17, 83);
            this.AnsVar2_RadioButton.Name = "AnsVar2_RadioButton";
            this.AnsVar2_RadioButton.Size = new System.Drawing.Size(149, 23);
            this.AnsVar2_RadioButton.TabIndex = 1;
            this.AnsVar2_RadioButton.TabStop = true;
            this.AnsVar2_RadioButton.Text = "Вариант ответа 2";
            this.AnsVar2_RadioButton.UseVisualStyleBackColor = true;
            // 
            // AnsVar1_RadioButton
            // 
            this.AnsVar1_RadioButton.AutoSize = true;
            this.AnsVar1_RadioButton.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnsVar1_RadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.AnsVar1_RadioButton.Location = new System.Drawing.Point(17, 40);
            this.AnsVar1_RadioButton.Name = "AnsVar1_RadioButton";
            this.AnsVar1_RadioButton.Size = new System.Drawing.Size(149, 23);
            this.AnsVar1_RadioButton.TabIndex = 0;
            this.AnsVar1_RadioButton.TabStop = true;
            this.AnsVar1_RadioButton.Text = "Вариант ответа 1";
            this.AnsVar1_RadioButton.UseVisualStyleBackColor = true;
            // 
            // Save_Button
            // 
            this.Save_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Save_Button.Enabled = false;
            this.Save_Button.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Save_Button.ForeColor = System.Drawing.Color.Navy;
            this.Save_Button.Location = new System.Drawing.Point(492, 386);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(185, 36);
            this.Save_Button.TabIndex = 78;
            this.Save_Button.Text = "Запись результатов";
            this.Save_Button.UseVisualStyleBackColor = false;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Exit_Button.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Exit_Button.Location = new System.Drawing.Point(696, 390);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(185, 32);
            this.Exit_Button.TabIndex = 77;
            this.Exit_Button.Text = "Выход";
            this.Exit_Button.UseVisualStyleBackColor = false;
            this.Exit_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // ResponceConfirmation_Button
            // 
            this.ResponceConfirmation_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ResponceConfirmation_Button.Enabled = false;
            this.ResponceConfirmation_Button.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResponceConfirmation_Button.ForeColor = System.Drawing.Color.Green;
            this.ResponceConfirmation_Button.Location = new System.Drawing.Point(696, 346);
            this.ResponceConfirmation_Button.Name = "ResponceConfirmation_Button";
            this.ResponceConfirmation_Button.Size = new System.Drawing.Size(185, 36);
            this.ResponceConfirmation_Button.TabIndex = 76;
            this.ResponceConfirmation_Button.Text = "Подтверждение ответа";
            this.ResponceConfirmation_Button.UseVisualStyleBackColor = false;
            this.ResponceConfirmation_Button.Click += new System.EventHandler(this.ResponceConfirmation_Button_Click);
            // 
            // TestBegin_Button
            // 
            this.TestBegin_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TestBegin_Button.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TestBegin_Button.ForeColor = System.Drawing.Color.Green;
            this.TestBegin_Button.Location = new System.Drawing.Point(492, 346);
            this.TestBegin_Button.Name = "TestBegin_Button";
            this.TestBegin_Button.Size = new System.Drawing.Size(185, 36);
            this.TestBegin_Button.TabIndex = 75;
            this.TestBegin_Button.Text = "Начать тест";
            this.TestBegin_Button.UseVisualStyleBackColor = false;
            this.TestBegin_Button.Click += new System.EventHandler(this.TestBegin_Button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(492, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(389, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            // 
            // TestStatus_StatusStrip
            // 
            this.TestStatus_StatusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TestStatus_StatusStrip.Font = new System.Drawing.Font("Garamond", 10F, System.Drawing.FontStyle.Bold);
            this.TestStatus_StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TestStatus_StatusLabel,
            this.TestTime_StatusLabel,
            this.TestResults_StatusLabel,
            this.TestStudent_StatusLabel});
            this.TestStatus_StatusStrip.Location = new System.Drawing.Point(0, 430);
            this.TestStatus_StatusStrip.Name = "TestStatus_StatusStrip";
            this.TestStatus_StatusStrip.Size = new System.Drawing.Size(883, 22);
            this.TestStatus_StatusStrip.TabIndex = 80;
            this.TestStatus_StatusStrip.Text = "statusStrip1";
            this.TestStatus_StatusStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.TestStatus_StatusStrip_ItemClicked);
            // 
            // TestStatus_StatusLabel
            // 
            this.TestStatus_StatusLabel.AutoSize = false;
            this.TestStatus_StatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TestStatus_StatusLabel.ForeColor = System.Drawing.Color.Navy;
            this.TestStatus_StatusLabel.Name = "TestStatus_StatusLabel";
            this.TestStatus_StatusLabel.Size = new System.Drawing.Size(200, 17);
            // 
            // TestTime_StatusLabel
            // 
            this.TestTime_StatusLabel.AutoSize = false;
            this.TestTime_StatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TestTime_StatusLabel.ForeColor = System.Drawing.Color.Maroon;
            this.TestTime_StatusLabel.Name = "TestTime_StatusLabel";
            this.TestTime_StatusLabel.Size = new System.Drawing.Size(200, 17);
            // 
            // TestResults_StatusLabel
            // 
            this.TestResults_StatusLabel.AutoSize = false;
            this.TestResults_StatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TestResults_StatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TestResults_StatusLabel.Name = "TestResults_StatusLabel";
            this.TestResults_StatusLabel.Size = new System.Drawing.Size(200, 17);
            // 
            // TestStudent_StatusLabel
            // 
            this.TestStudent_StatusLabel.AutoSize = false;
            this.TestStudent_StatusLabel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TestStudent_StatusLabel.ForeColor = System.Drawing.Color.Olive;
            this.TestStudent_StatusLabel.Name = "TestStudent_StatusLabel";
            this.TestStudent_StatusLabel.Size = new System.Drawing.Size(270, 17);
            // 
            // Wait_PictureBox
            // 
            this.Wait_PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Wait_PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("Wait_PictureBox.Image")));
            this.Wait_PictureBox.Location = new System.Drawing.Point(12, 39);
            this.Wait_PictureBox.Name = "Wait_PictureBox";
            this.Wait_PictureBox.Size = new System.Drawing.Size(474, 380);
            this.Wait_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Wait_PictureBox.TabIndex = 81;
            this.Wait_PictureBox.TabStop = false;
            // 
            // Test_Timer
            // 
            this.Test_Timer.Interval = 1000;
            this.Test_Timer.Tick += new System.EventHandler(this.Test_Timer_Tick);
            // 
            // Results_DataGridView
            // 
            this.Results_DataGridView.AutoGenerateColumns = false;
            this.Results_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Results_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDresultDataGridViewTextBoxColumn,
            this.dateresultDataGridViewTextBoxColumn,
            this.iDstudentDataGridViewTextBoxColumn,
            this.iDmoduleDataGridViewTextBoxColumn2,
            this.sumpointsDataGridViewTextBoxColumn});
            this.Results_DataGridView.DataSource = this.resultsBindingSource;
            this.Results_DataGridView.Location = new System.Drawing.Point(695, 10);
            this.Results_DataGridView.Name = "Results_DataGridView";
            this.Results_DataGridView.Size = new System.Drawing.Size(43, 23);
            this.Results_DataGridView.TabIndex = 82;
            this.Results_DataGridView.Visible = false;
            // 
            // iDresultDataGridViewTextBoxColumn
            // 
            this.iDresultDataGridViewTextBoxColumn.DataPropertyName = "ID_result";
            this.iDresultDataGridViewTextBoxColumn.HeaderText = "ID_result";
            this.iDresultDataGridViewTextBoxColumn.Name = "iDresultDataGridViewTextBoxColumn";
            this.iDresultDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateresultDataGridViewTextBoxColumn
            // 
            this.dateresultDataGridViewTextBoxColumn.DataPropertyName = "Date_result";
            this.dateresultDataGridViewTextBoxColumn.HeaderText = "Date_result";
            this.dateresultDataGridViewTextBoxColumn.Name = "dateresultDataGridViewTextBoxColumn";
            // 
            // iDstudentDataGridViewTextBoxColumn
            // 
            this.iDstudentDataGridViewTextBoxColumn.DataPropertyName = "ID_student";
            this.iDstudentDataGridViewTextBoxColumn.HeaderText = "ID_student";
            this.iDstudentDataGridViewTextBoxColumn.Name = "iDstudentDataGridViewTextBoxColumn";
            // 
            // iDmoduleDataGridViewTextBoxColumn2
            // 
            this.iDmoduleDataGridViewTextBoxColumn2.DataPropertyName = "ID_module";
            this.iDmoduleDataGridViewTextBoxColumn2.HeaderText = "ID_module";
            this.iDmoduleDataGridViewTextBoxColumn2.Name = "iDmoduleDataGridViewTextBoxColumn2";
            // 
            // sumpointsDataGridViewTextBoxColumn
            // 
            this.sumpointsDataGridViewTextBoxColumn.DataPropertyName = "Sum_points";
            this.sumpointsDataGridViewTextBoxColumn.HeaderText = "Sum_points";
            this.sumpointsDataGridViewTextBoxColumn.Name = "sumpointsDataGridViewTextBoxColumn";
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
            // Form_MainStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(883, 452);
            this.Controls.Add(this.Results_DataGridView);
            this.Controls.Add(this.Wait_PictureBox);
            this.Controls.Add(this.TestStatus_StatusStrip);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.ResponceConfirmation_Button);
            this.Controls.Add(this.TestBegin_Button);
            this.Controls.Add(this.Answers_GroupBox);
            this.Controls.Add(this.Question_GroupBox);
            this.Controls.Add(this.Questions_DataGridView);
            this.Controls.Add(this.Tests_DataGridView);
            this.Controls.Add(this.Test_ComboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_MainStudent";
            this.Text = "Прохождение тестирования";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_MainStudent_FormClosed);
            this.Load += new System.EventHandler(this.Form_MainStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.modulesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schooltestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tests_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Questions_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).EndInit();
            this.Question_GroupBox.ResumeLayout(false);
            this.Question_GroupBox.PerformLayout();
            this.Answers_GroupBox.ResumeLayout(false);
            this.Answers_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TestStatus_StatusStrip.ResumeLayout(false);
            this.TestStatus_StatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Wait_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Results_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox Test_ComboBox;
        private System.Windows.Forms.Label label1;
        private schooltestDataSet schooltestDataSet;
        private System.Windows.Forms.BindingSource modulesBindingSource;
        private schooltestDataSetTableAdapters.ModulesTableAdapter modulesTableAdapter;
        private System.Windows.Forms.DataGridView Tests_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDmoduleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namemoduleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDdisciplineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView Questions_DataGridView;
        private System.Windows.Forms.BindingSource questionsBindingSource;
        private schooltestDataSetTableAdapters.QuestionsTableAdapter questionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDquestionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textquestionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ans1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ans2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ans3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ans4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rightansDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDmoduleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.GroupBox Question_GroupBox;
        private System.Windows.Forms.TextBox Questions_TextBox;
        private System.Windows.Forms.GroupBox Answers_GroupBox;
        private System.Windows.Forms.RadioButton AnsVar3_RadioButton;
        private System.Windows.Forms.RadioButton AnsVar2_RadioButton;
        private System.Windows.Forms.RadioButton AnsVar1_RadioButton;
        private System.Windows.Forms.RadioButton AnsVar4_RadioButton;
        private System.Windows.Forms.Label Ans_Label;
        private System.Windows.Forms.TextBox Ans_TextBox;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Button ResponceConfirmation_Button;
        private System.Windows.Forms.Button TestBegin_Button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip TestStatus_StatusStrip;
        private System.Windows.Forms.PictureBox Wait_PictureBox;
        private System.Windows.Forms.Timer Test_Timer;
        private System.Windows.Forms.ToolStripStatusLabel TestStatus_StatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel TestTime_StatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel TestResults_StatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel TestStudent_StatusLabel;
        private System.Windows.Forms.DataGridView Results_DataGridView;
        private System.Windows.Forms.BindingSource resultsBindingSource;
        private schooltestDataSetTableAdapters.ResultsTableAdapter resultsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDresultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateresultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDstudentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDmoduleDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumpointsDataGridViewTextBoxColumn;
    }
}