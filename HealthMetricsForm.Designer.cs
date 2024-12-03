namespace Final_Project
{
    partial class HealthMetricsForm
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
            lblMetrics = new Label();
            txtMetrics = new TextBox();
            btnSaveMetrics = new Button();
            btnBack = new Button();
            cmbPetNames = new ComboBox();
            SuspendLayout();
            // 
            // lblMetrics
            // 
            lblMetrics.AutoSize = true;
            lblMetrics.Location = new Point(78, 125);
            lblMetrics.Name = "lblMetrics";
            lblMetrics.Size = new Size(38, 15);
            lblMetrics.TabIndex = 0;
            lblMetrics.Text = "label1";
            // 
            // txtMetrics
            // 
            txtMetrics.Location = new Point(212, 117);
            txtMetrics.Name = "txtMetrics";
            txtMetrics.Size = new Size(121, 23);
            txtMetrics.TabIndex = 1;
            // 
            // btnSaveMetrics
            // 
            btnSaveMetrics.Location = new Point(119, 187);
            btnSaveMetrics.Name = "btnSaveMetrics";
            btnSaveMetrics.Size = new Size(121, 43);
            btnSaveMetrics.TabIndex = 2;
            btnSaveMetrics.Text = "Save Metrics";
            btnSaveMetrics.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(146, 290);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // cmbPetNames
            // 
            cmbPetNames.FormattingEnabled = true;
            cmbPetNames.Location = new Point(119, 61);
            cmbPetNames.Name = "cmbPetNames";
            cmbPetNames.Size = new Size(121, 23);
            cmbPetNames.TabIndex = 4;
            cmbPetNames.SelectedIndexChanged += cmbPetNames_SelectedIndexChanged;
            // 
            // HealthMetricsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(365, 363);
            Controls.Add(cmbPetNames);
            Controls.Add(btnBack);
            Controls.Add(btnSaveMetrics);
            Controls.Add(txtMetrics);
            Controls.Add(lblMetrics);
            Name = "HealthMetricsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "HealthMetricsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMetrics;
        private TextBox txtMetrics;
        private Button btnSaveMetrics;
        private Button btnBack;
        private ComboBox cmbPetNames;
    }
}