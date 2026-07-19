namespace SimpleInterestApp
{
    partial class ToastDemoForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnDemoSuccess = new Button();
            btnDemoWarning = new Button();
            btnDemoError = new Button();
            lblTitle = new Label();
            SuspendLayout();

            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(40, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(320, 37);
            lblTitle.Text = "Notification Sandbox";

            // 
            // btnDemoSuccess
            // 
            btnDemoSuccess.BackColor = Color.FromArgb(0, 230, 118); // Emerald Green
            btnDemoSuccess.FlatAppearance.BorderSize = 0;
            btnDemoSuccess.FlatStyle = FlatStyle.Flat;
            btnDemoSuccess.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDemoSuccess.ForeColor = Color.FromArgb(20, 20, 20);
            btnDemoSuccess.Location = new Point(40, 100);
            btnDemoSuccess.Name = "btnDemoSuccess";
            btnDemoSuccess.Size = new Size(320, 50);
            btnDemoSuccess.Text = "Trigger Success Alert";
            btnDemoSuccess.UseVisualStyleBackColor = false;
            btnDemoSuccess.Click += btnDemoSuccess_Click;

            // 
            // btnDemoWarning
            // 
            btnDemoWarning.BackColor = Color.FromArgb(255, 196, 0); // Amber Gold
            btnDemoWarning.FlatAppearance.BorderSize = 0;
            btnDemoWarning.FlatStyle = FlatStyle.Flat;
            btnDemoWarning.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDemoWarning.ForeColor = Color.FromArgb(20, 20, 20);
            btnDemoWarning.Location = new Point(40, 170);
            btnDemoWarning.Name = "btnDemoWarning";
            btnDemoWarning.Size = new Size(320, 50);
            btnDemoWarning.Text = "Trigger Warning Alert";
            btnDemoWarning.UseVisualStyleBackColor = false;
            btnDemoWarning.Click += btnDemoWarning_Click;

            // 
            // btnDemoError
            // 
            btnDemoError.BackColor = Color.FromArgb(255, 23, 68); // Crimson Red
            btnDemoError.FlatAppearance.BorderSize = 0;
            btnDemoError.FlatStyle = FlatStyle.Flat;
            btnDemoError.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDemoError.ForeColor = Color.White;
            btnDemoError.Location = new Point(40, 240);
            btnDemoError.Name = "btnDemoError";
            btnDemoError.Size = new Size(320, 50);
            btnDemoError.Text = "Trigger System Error";
            btnDemoError.UseVisualStyleBackColor = false;
            btnDemoError.Click += btnDemoError_Click;

            // 
            // ToastDemoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 25, 25); // Sleek UI Matte Dark Background
            ClientSize = new Size(400, 340);
            Controls.Add(lblTitle);
            Controls.Add(btnDemoError);
            Controls.Add(btnDemoWarning);
            Controls.Add(btnDemoSuccess);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "ToastDemoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Async UI Demo Control Panel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDemoSuccess;
        private Button btnDemoWarning;
        private Button btnDemoError;
        private Label lblTitle;
    }
}