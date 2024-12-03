using System;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class ViewPetsForm : Form
    {
        private readonly User loggedInUser;

        public ViewPetsForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;
            LoadUserPets();
            FormStyling.ApplyFormStyling(this);
            InitializeDataGridView();  // Initialize DataGridView columns
        }

        // Initialize the DataGridView columns
        private void InitializeDataGridView()
        {
            // Ensure columns are added programmatically only if not already defined
            if (dataGridView.Columns.Count == 0)
            {
                dataGridView.Columns.Add("Name", "Pet Name");  // Column for pet name
                dataGridView.Columns.Add("Type", "Pet Type");  // Column for pet type (e.g., Dog, Cat)
                dataGridView.Columns.Add("Breed", "Pet Breed");  // Column for pet breed

                // Optional: Set column widths
                dataGridView.Columns["Type"].Width = 100;
                dataGridView.Columns["Breed"].Width = 120;
                dataGridView.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void LoadUserPets()
        {
            dataGridView.Rows.Clear();  // Clear any existing rows

            // Iterate through all pets of the logged-in user and add them to the DataGridView
            foreach (var pet in loggedInUser.Pets)
            {
                dataGridView.Rows.Add(pet.Name, pet.Type, pet.Breed);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
