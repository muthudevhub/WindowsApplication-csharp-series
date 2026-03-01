namespace SimpleInterestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double principal = double.Parse(txtPrincipal.Text);
            double rate = double.Parse(txtRate.Text);
            double time = double.Parse(txtTime.Text);
            double interest = CalculateSimpleInterest(principal, rate,time);

            lblResult.Text = $"Simple Interest: {interest:F2}";
            dgvResult.Rows.Add(principal, rate, time, interest);
        }

        private void btnSaveInterest_Click(object sender, EventArgs e)
        {
            double principal = double.Parse(txtPrincipal.Text);
            double rate = double.Parse(txtRate.Text);
            double time = double.Parse(txtTime.Text);
            double interest = CalculateSimpleInterest(principal, rate, time);

            MessageBox.Show ($"Simple Interest: {interest:F2}");
            
        }

        private double CalculateSimpleInterest(double _principal, double _rate, double _time)
        {
            return (_principal * _rate) / 100;
        }
    }
}
