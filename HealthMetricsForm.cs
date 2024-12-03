using System;
using System.Linq;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class HealthMetricsForm : Form
    {
        private readonly User loggedInUser;

        public HealthMetricsForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;
            LoadPetNames();
            FormStyling.ApplyFormStyling(this);
        }

        private void LoadPetNames()
        {
            cmbPetNames.Items.Clear();
            foreach (var pet in loggedInUser.Pets)
            {
                cmbPetNames.Items.Add(pet.Name);
            }
        }

        private void cmbPetNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedPetName = cmbPetNames.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedPetName)) return;

            var pet = loggedInUser.Pets.FirstOrDefault(p => p.Name == selectedPetName);
            if (pet != null)
            {
                txtMetrics.Text = $"Type: {pet.Type}{Environment.NewLine}Breed: {pet.Breed}";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
