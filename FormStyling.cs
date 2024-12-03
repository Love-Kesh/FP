using System;
using System.Drawing;
using System.Windows.Forms;

namespace Final_Project
{
    public static class FormStyling
    {
        // Method to apply the general styling to a form
        public static void ApplyFormStyling(Form form)
        {
            // Apply general background color to the form
            form.BackColor = Color.MistyRose;

            // Apply button styling (flat, color, font)
            foreach (var control in form.Controls)
            {
                if (control is Button button)
                {
                    ApplyButtonStyling(button); // Apply the button styling
                }
                else if (control is Label label)
                {
                    ApplyLabelStyling(label);  // Apply Label styling
                }
                else if (control is DataGridView dataGridView)
                {
                    ApplyDataGridViewStyling(dataGridView);  // Apply DataGridView styling
                }
                else if (control is ComboBox comboBox)
                {
                    ApplyComboBoxStyling(comboBox);  // Apply ComboBox styling
                }
                else if (control is TextBox textBox)
                {
                    ApplyTextBoxStyling(textBox);  // Apply TextBox styling
                }
            }
        }

        // Method to apply Button styling
        public static void ApplyButtonStyling(Button button)
        {
            button.BackColor = Color.Coral;
            button.ForeColor = Color.White;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        // Method to apply DataGridView styling
        public static void ApplyDataGridViewStyling(DataGridView dataGridView)
        {
            dataGridView.BackgroundColor = Color.WhiteSmoke;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.Font = new Font("Arial", 10);
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Coral;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.SkyBlue;
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        // Method to apply ListBox styling
        public static void ApplyListBoxStyling(ListBox listBox)
        {
            listBox.BackColor = Color.WhiteSmoke;
            listBox.Font = new Font("Arial", 10);
            listBox.ForeColor = Color.DarkSlateGray;
        }

        // Method to apply TextBox styling
        public static void ApplyTextBoxStyling(TextBox textBox)
        {
            textBox.BackColor = Color.White;
            textBox.Font = new Font("Arial", 10);
        }

        // Method to apply ComboBox styling
        public static void ApplyComboBoxStyling(ComboBox comboBox)
        {
            comboBox.BackColor = Color.WhiteSmoke;
            comboBox.Font = new Font("Arial", 10);
        }

        // Method to apply Label styling
        public static void ApplyLabelStyling(Label label)
        {
            label.Font = new Font("Arial", 12, FontStyle.Bold);  // Bold font for labels
            label.ForeColor = Color.DarkSlateGray;  // Dark gray color for labels
        }
    }
}
