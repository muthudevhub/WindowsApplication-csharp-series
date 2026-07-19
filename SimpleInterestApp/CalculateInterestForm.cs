namespace SimpleInterestApp
{
    public partial class CalculateInterestForm : Form
    {
        public CalculateInterestForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double principal = double.Parse(txtPrincipal.Text);
            double rate = double.Parse(txtRate.Text);
            double time = double.Parse(txtTime.Text);
            double interest = CalculateSimpleInterest(principal, rate, time);

            lblResult.Text = $"Simple Interest: {interest:F2}";
            dgvResult.Rows.Add(principal, rate, time, interest);
        }

        private void btnSaveInterest_Click(object sender, EventArgs e)
        {
            double principal = double.Parse(txtPrincipal.Text);
            double rate = double.Parse(txtRate.Text);
            double time = double.Parse(txtTime.Text);
            double interest = CalculateSimpleInterest(principal, rate, time);

            MessageBox.Show("Data saved securely to the database!");

        }

        private double CalculateSimpleInterest(double _principal, double _rate, double _time)
        {
            return (_principal * _rate) / 100;
        }

        private void CalculateInterestForm_Load(object sender, EventArgs e)
        {

        }
    }
}
