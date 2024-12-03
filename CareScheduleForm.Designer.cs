namespace Final_Project
{
    partial class CareScheduleForm
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
            lblSchedule = new Label();
            btnBack = new Button();
            lblScheduledTasks = new Label();
            monthCalendar = new MonthCalendar();
            cmbPetNames = new ComboBox();
            txtScheduledTask = new TextBox();
            dtpScheduledDate = new DateTimePicker();
            btnAddSchedule = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblSchedule
            // 
            lblSchedule.AutoSize = true;
            lblSchedule.Location = new Point(34, 32);
            lblSchedule.Name = "lblSchedule";
            lblSchedule.Size = new Size(117, 15);
            lblSchedule.TabIndex = 0;
            lblSchedule.Text = "Upcoming Schedule:";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(245, 297);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(98, 52);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblScheduledTasks
            // 
            lblScheduledTasks.AutoSize = true;
            lblScheduledTasks.Location = new Point(223, 32);
            lblScheduledTasks.Name = "lblScheduledTasks";
            lblScheduledTasks.Size = new Size(38, 15);
            lblScheduledTasks.TabIndex = 4;
            lblScheduledTasks.Text = "label1";
            // 
            // monthCalendar
            // 
            monthCalendar.Location = new Point(34, 66);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 5;
            monthCalendar.DateChanged += monthCalendar_DateChanged;
            // 
            // cmbPetNames
            // 
            cmbPetNames.FormattingEnabled = true;
            cmbPetNames.Location = new Point(287, 118);
            cmbPetNames.Name = "cmbPetNames";
            cmbPetNames.Size = new Size(121, 23);
            cmbPetNames.TabIndex = 6;
            // 
            // txtScheduledTask
            // 
            txtScheduledTask.Location = new Point(441, 118);
            txtScheduledTask.Name = "txtScheduledTask";
            txtScheduledTask.Size = new Size(121, 23);
            txtScheduledTask.TabIndex = 7;
            // 
            // dtpScheduledDate
            // 
            dtpScheduledDate.Location = new Point(318, 170);
            dtpScheduledDate.Name = "dtpScheduledDate";
            dtpScheduledDate.Size = new Size(200, 23);
            dtpScheduledDate.TabIndex = 8;
            // 
            // btnAddSchedule
            // 
            btnAddSchedule.Location = new Point(365, 222);
            btnAddSchedule.Name = "btnAddSchedule";
            btnAddSchedule.Size = new Size(121, 44);
            btnAddSchedule.TabIndex = 9;
            btnAddSchedule.Text = "Add";
            btnAddSchedule.UseVisualStyleBackColor = true;
            btnAddSchedule.Click += btnAddSchedule_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(365, 66);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 10;
            label1.Text = " Add New Schedule";
            // 
            // CareScheduleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 373);
            Controls.Add(label1);
            Controls.Add(btnAddSchedule);
            Controls.Add(dtpScheduledDate);
            Controls.Add(txtScheduledTask);
            Controls.Add(cmbPetNames);
            Controls.Add(monthCalendar);
            Controls.Add(lblScheduledTasks);
            Controls.Add(btnBack);
            Controls.Add(lblSchedule);
            Name = "CareScheduleForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CareScheduleForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSchedule;
        private Button btnBack;
        private Label lblScheduledTasks;
        private MonthCalendar monthCalendar;
        private ComboBox cmbPetNames;
        private TextBox txtScheduledTask;
        private DateTimePicker dtpScheduledDate;
        private Button btnAddSchedule;
        private Label label1;
    }
}