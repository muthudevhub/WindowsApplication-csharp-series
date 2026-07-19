using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleInterestApp
{
    public partial class ToastDemoForm : Form
    {
        public ToastDemoForm()
        {
            InitializeComponent();
        }

        // 1. Success Demo Action Trigger
        private void btnDemoSuccess_Click(object sender, EventArgs e)
        {
            ToastManager.ShowSuccess("Data saved securely to the database!");
        }

        // 2. Warning Demo Action Trigger
        private void btnDemoWarning_Click(object sender, EventArgs e)
        {
            ToastManager.ShowWarning("Connection running slow. Retrying...");
        }

        // 3. Simulated Error Demo Action Trigger
        private void btnDemoError_Click(object sender, EventArgs e)
        {
            try
            {
                // Deliberately force a fake system exception for the camera
                throw new System.IO.IOException("Database connection timed out after 30 seconds.");
            }
            catch (Exception ex)
            {
                ToastManager.ShowError($"Critical Failure: {ex.Message}");
            }
        }
    }
}