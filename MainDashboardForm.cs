using System;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class MainDashboardForm : Form
    {
        private readonly User loggedInUser;

        public MainDashboardForm(User user)
        {
            InitializeComponent();
            loggedInUser = user;
            FormStyling.ApplyFormStyling(this);
        }

        private void btnViewPets_Click(object sender, EventArgs e)
        {
            var viewPetsForm = new ViewPetsForm(loggedInUser);
            viewPetsForm.Show();
        }

        private void btnAddPet_Click(object sender, EventArgs e)
        {
            var addPetsForm = new AddPetForm(loggedInUser);
            addPetsForm.Show();
        }

        private void btnHealthMetrics_Click(object sender, EventArgs e)
        {
            var healthMetricsForm = new HealthMetricsForm(loggedInUser);
            healthMetricsForm.Show();
        }

        private void btnCareSchedule_Click(object sender, EventArgs e)
        {
            var careScheduleForm = new CareScheduleForm(loggedInUser);
            careScheduleForm.Show();
        }

        private void btnTaskList_Click(object sender, EventArgs e)
        {
            var taskListForm = new TaskListForm(loggedInUser);
            taskListForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have been logged out.");
            this.Close();
        }
    }
}
