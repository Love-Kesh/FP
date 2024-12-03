using System;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class AddPetForm : Form
    {
        private readonly User loggedInUser;

        public AddPetForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;
            FormStyling.ApplyFormStyling(this);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPetName.Text) || string.IsNullOrEmpty(txtPetType.Text) || string.IsNullOrEmpty(txtPetBreed.Text))
            {
                MessageBox.Show("Please fill out all pet information.");
                return;
            }

            loggedInUser.Pets.Add(new Pet
            {
                Name = txtPetName.Text,
                Type = txtPetType.Text,
                Breed = txtPetBreed.Text,
                Tasks = new List<Task>(),
                Schedule = new List<Schedule>()
            });

            MessageBox.Show("Pet added successfully!");
            txtPetName.Clear();
            txtPetType.Clear();
            txtPetBreed.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
