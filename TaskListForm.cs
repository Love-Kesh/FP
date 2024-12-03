using System;
using System.Linq;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class TaskListForm : Form
    {
        private readonly User loggedInUser;

        public TaskListForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;
            FormStyling.ApplyFormStyling(this);  // Apply form styling
            InitializeDataGridView();  // Initialize DataGridView columns
            LoadPetNames();  // Load pet names into the ComboBox
            LoadPetsTasks();  // Load all pets and their tasks into the DataGridView
        }

        // Initialize the DataGridView columns
        private void InitializeDataGridView()
        {
            // Ensure columns are added programmatically only if not already defined
            if (dataGridView.Columns.Count == 0)
            {
                dataGridView.Columns.Add("Name", "Pet Name");  // Column for pet name
                dataGridView.Columns.Add("Description", "Task Description");  // Column for task description
                dataGridView.Columns.Add("Status", "Status");  // Column for task status

                // Optional: Set column widths
                dataGridView.Columns["Status"].Width = 100;
                dataGridView.Columns["Description"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        // Load the pet names for the logged-in user into the ComboBox
        private void LoadPetNames()
        {
            cmbPetNames.Items.Clear();  // Clear existing items in the ComboBox

            // Ensure ComboBox is populated with logged-in user's pets
            foreach (var pet in loggedInUser.Pets)
            {
                cmbPetNames.Items.Add(pet.Name);
            }

            if (cmbPetNames.Items.Count > 0)
            {
                cmbPetNames.SelectedIndex = 0;  // Set the first pet as selected by default
            }
            else
            {
                cmbPetNames.Enabled = false;  // Disable ComboBox if no pets are available
            }
        }

        // Load all pets and their tasks for the logged-in user into the DataGridView
        private void LoadPetsTasks()
        {
            dataGridView.Rows.Clear();  // Clear any existing rows

            // Iterate through all pets of the logged-in user
            foreach (var pet in loggedInUser.Pets)
            {
                // For each pet, load their tasks into the DataGridView
                foreach (var task in pet.Tasks)
                {
                    dataGridView.Rows.Add(pet.Name, task.Description, task.IsCompleted ? "Completed" : "Pending");
                }
            }

            if (dataGridView.Rows.Count == 0)
            {
                dataGridView.Rows.Add("No tasks available", "", "");  // If no tasks, show this message
            }
        }

        // Handle task selection in the DataGridView
        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView.SelectedRows[0];
                var taskDescription = selectedRow.Cells[1].Value?.ToString();
                var taskStatus = selectedRow.Cells[2].Value?.ToString();

            }
        }

        // Mark the selected task as completed
        private void btnMarkComplete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a task to mark as completed.");
                return;
            }

            var selectedRow = dataGridView.SelectedRows[0];
            var petName = selectedRow.Cells[0].Value?.ToString();
            var taskDescription = selectedRow.Cells[1].Value?.ToString();

            var pet = loggedInUser.Pets.FirstOrDefault(p => p.Name == petName);
            var task = pet?.Tasks.FirstOrDefault(t => t.Description == taskDescription);

            if (task != null)
            {
                task.IsCompleted = true;
                MessageBox.Show($"Task '{task.Description}' marked as completed.");
                LoadPetsTasks();  // Refresh the DataGridView with updated task status
            }
        }

        // Add a new task for the selected pet
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            var selectedPetName = cmbPetNames.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedPetName))
            {
                MessageBox.Show("Please select a pet to add a task.");
                return;
            }

            var pet = loggedInUser.Pets.FirstOrDefault(p => p.Name == selectedPetName);
            if (pet == null)
            {
                MessageBox.Show("Pet not found.");
                return;
            }

            var taskDescription = txtTaskDescription.Text;
            if (string.IsNullOrEmpty(taskDescription))
            {
                MessageBox.Show("Please provide a task description.");
                return;
            }

            // Create a new task and add it to the pet's task list
            var newTask = new Task
            {
                Description = taskDescription,
                IsCompleted = false
            };

            pet.Tasks.Add(newTask);
            MessageBox.Show($"Task '{taskDescription}' added for {pet.Name}.");
            txtTaskDescription.Clear();  // Clear the task description textbox

            // Refresh the DataGridView with the new task
            LoadPetsTasks();
        }

        // Back button to close the form
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
