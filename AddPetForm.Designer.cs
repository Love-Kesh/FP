namespace Final_Project
{
    partial class AddPetForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPetName = new TextBox();
            txtPetType = new TextBox();
            txtPetBreed = new TextBox();
            btnSave = new Button();
            cmbScheduledTask = new ComboBox();
            dtpScheduledDate = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 69);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Pet Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 122);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 194);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 2;
            label3.Text = "Breed";
            // 
            // txtPetName
            // 
            txtPetName.Location = new Point(238, 58);
            txtPetName.Name = "txtPetName";
            txtPetName.Size = new Size(100, 23);
            txtPetName.TabIndex = 3;
            // 
            // txtPetType
            // 
            txtPetType.Location = new Point(238, 122);
            txtPetType.Name = "txtPetType";
            txtPetType.Size = new Size(100, 23);
            txtPetType.TabIndex = 4;
            // 
            // txtPetBreed
            // 
            txtPetBreed.Location = new Point(238, 191);
            txtPetBreed.Name = "txtPetBreed";
            txtPetBreed.Size = new Size(100, 23);
            txtPetBreed.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(246, 313);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cmbScheduledTask
            // 
            cmbScheduledTask.FormattingEnabled = true;
            cmbScheduledTask.Location = new Point(487, 50);
            cmbScheduledTask.Name = "cmbScheduledTask";
            cmbScheduledTask.Size = new Size(121, 23);
            cmbScheduledTask.TabIndex = 7;
            // 
            // dtpScheduledDate
            // 
            dtpScheduledDate.Location = new Point(448, 140);
            dtpScheduledDate.Name = "dtpScheduledDate";
            dtpScheduledDate.Size = new Size(200, 23);
            dtpScheduledDate.TabIndex = 8;
            // 
            // AddPetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtpScheduledDate);
            Controls.Add(cmbScheduledTask);
            Controls.Add(btnSave);
            Controls.Add(txtPetBreed);
            Controls.Add(txtPetType);
            Controls.Add(txtPetName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddPetForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddPetForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPetName;
        private TextBox txtPetType;
        private TextBox txtPetBreed;
        private Button btnSave;
        private ComboBox cmbScheduledTask;
        private DateTimePicker dtpScheduledDate;
    }
}