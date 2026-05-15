namespace TaskWinForms
{
    partial class MainForm
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
            panel1 = new Panel();
            splitContainer1 = new SplitContainer();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            StudyingDaysBox = new TextBox();
            BirthHourBox = new TextBox();
            LastNameBox = new TextBox();
            BirthDatePicker = new DateTimePicker();
            TodayDatePicker = new DateTimePicker();
            panel2 = new Panel();
            OutputBox = new ListBox();
            ButtonAccept = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(splitContainer1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(412, 208);
            panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label5);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(StudyingDaysBox);
            splitContainer1.Panel2.Controls.Add(BirthHourBox);
            splitContainer1.Panel2.Controls.Add(LastNameBox);
            splitContainer1.Panel2.Controls.Add(BirthDatePicker);
            splitContainer1.Panel2.Controls.Add(TodayDatePicker);
            splitContainer1.Size = new Size(412, 208);
            splitContainer1.SplitterDistance = 180;
            splitContainer1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 170);
            label5.Name = "label5";
            label5.Size = new Size(169, 15);
            label5.TabIndex = 4;
            label5.Text = "Сколько хотите ещё учиться?";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 133);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 3;
            label4.Text = "Час рождения";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 97);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 2;
            label3.Text = "Дата рождения";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 62);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Фамилия";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 25);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Сегодня";
            // 
            // StudyingDaysBox
            // 
            StudyingDaysBox.Location = new Point(3, 167);
            StudyingDaysBox.Name = "StudyingDaysBox";
            StudyingDaysBox.Size = new Size(200, 23);
            StudyingDaysBox.TabIndex = 4;
            StudyingDaysBox.Text = "1000"; //Меняем на рандомное число (ток попробуй, блять, сюда текст вставить >:( )
            // 
            // BirthHourBox
            // 
            BirthHourBox.Location = new Point(3, 130);
            BirthHourBox.Name = "BirthHourBox";
            BirthHourBox.Size = new Size(200, 23);
            BirthHourBox.TabIndex = 3;
            BirthHourBox.Text = "12"; //Меняем на любое число от 0 до 24 
            // 
            // LastNameBox
            // 
            LastNameBox.Location = new Point(3, 54);
            LastNameBox.Name = "LastNameBox";
            LastNameBox.Size = new Size(200, 23);
            LastNameBox.TabIndex = 2;
            LastNameBox.Text = "Смурова"; //Меняем на свою фамилию
            // 
            // BirthDatePicker
            // 
            BirthDatePicker.Location = new Point(3, 91);
            BirthDatePicker.Name = "BirthDatePicker";
            BirthDatePicker.Size = new Size(200, 23);
            BirthDatePicker.TabIndex = 1;
            BirthDatePicker.Value = new DateTime(2003, 3, 31, 0, 0, 0, 0); //Меняем на свою ДРшечку
            // 
            // TodayDatePicker
            // 
            TodayDatePicker.Location = new Point(3, 19);
            TodayDatePicker.Name = "TodayDatePicker";
            TodayDatePicker.Size = new Size(200, 23);
            TodayDatePicker.TabIndex = 0;
            TodayDatePicker.Value = new DateTime(2026, 5, 8, 21, 46, 11, 0);
            // 
            // panel2
            // 
            panel2.Controls.Add(OutputBox);
            panel2.Location = new Point(12, 275);
            panel2.Name = "panel2";
            panel2.Size = new Size(412, 250);
            panel2.TabIndex = 1;
            // 
            // OutputBox
            // 
            OutputBox.FormattingEnabled = true;
            OutputBox.Location = new Point(3, 2);
            OutputBox.Name = "OutputBox";
            OutputBox.Size = new Size(406, 244);
            OutputBox.TabIndex = 0;
            // 
            // ButtonAccept
            // 
            ButtonAccept.Location = new Point(12, 236);
            ButtonAccept.Name = "ButtonAccept";
            ButtonAccept.Size = new Size(75, 23);
            ButtonAccept.TabIndex = 2;
            ButtonAccept.Text = "Принять";
            ButtonAccept.UseVisualStyleBackColor = true;
            ButtonAccept.Click += ButtonAccept_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 547);
            Controls.Add(ButtonAccept);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "Date Information Application";
            panel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private ListBox OutputBox;
        private SplitContainer splitContainer1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox StudyingDaysBox;
        private TextBox BirthHourBox;
        private TextBox LastNameBox;
        private DateTimePicker BirthDatePicker;
        private DateTimePicker TodayDatePicker;
        private Button ButtonAccept;
    }
}
