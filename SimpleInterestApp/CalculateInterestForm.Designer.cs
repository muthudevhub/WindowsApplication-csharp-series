namespace SimpleInterestApp
{
    partial class CalculateInterestForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblResult = new Label();
            txtPrincipal = new TextBox();
            txtRate = new TextBox();
            txtTime = new TextBox();
            btnCalculate = new Button();
            dgvResult = new DataGridView();
            Principal = new DataGridViewTextBoxColumn();
            Rate = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            Interest = new DataGridViewTextBoxColumn();
            btnSaveInterest = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F);
            label1.Location = new Point(284, 69);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 0;
            label1.Text = "Principal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F);
            label2.Location = new Point(284, 114);
            label2.Name = "label2";
            label2.Size = new Size(77, 25);
            label2.TabIndex = 1;
            label2.Text = "Rate (%)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F);
            label3.Location = new Point(284, 168);
            label3.Name = "label3";
            label3.Size = new Size(105, 25);
            label3.TabIndex = 2;
            label3.Text = "Time (Years)";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 10.8F);
            lblResult.Location = new Point(284, 221);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(59, 25);
            lblResult.TabIndex = 3;
            lblResult.Text = "Result";
            // 
            // txtPrincipal
            // 
            txtPrincipal.Font = new Font("Segoe UI", 10.8F);
            txtPrincipal.Location = new Point(466, 62);
            txtPrincipal.Name = "txtPrincipal";
            txtPrincipal.Size = new Size(125, 31);
            txtPrincipal.TabIndex = 4;
            // 
            // txtRate
            // 
            txtRate.Font = new Font("Segoe UI", 10.8F);
            txtRate.Location = new Point(466, 111);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(125, 31);
            txtRate.TabIndex = 5;
            // 
            // txtTime
            // 
            txtTime.Font = new Font("Segoe UI", 10.8F);
            txtTime.Location = new Point(466, 165);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(125, 31);
            txtTime.TabIndex = 6;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 12F);
            btnCalculate.Location = new Point(359, 285);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(141, 43);
            btnCalculate.TabIndex = 7;
            btnCalculate.Text = "Calculate Interest";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // dgvResult
            // 
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Columns.AddRange(new DataGridViewColumn[] { Principal, Rate, Time, Interest });
            dgvResult.Location = new Point(-2, 363);
            dgvResult.Name = "dgvResult";
            dgvResult.RowHeadersWidth = 51;
            dgvResult.Size = new Size(701, 144);
            dgvResult.TabIndex = 8;
            // 
            // Principal
            // 
            Principal.HeaderText = "Principal";
            Principal.MinimumWidth = 6;
            Principal.Name = "Principal";
            Principal.Width = 125;
            // 
            // Rate
            // 
            Rate.HeaderText = "Rate";
            Rate.MinimumWidth = 6;
            Rate.Name = "Rate";
            Rate.Width = 125;
            // 
            // Time
            // 
            Time.HeaderText = "Time";
            Time.MinimumWidth = 6;
            Time.Name = "Time";
            Time.Width = 125;
            // 
            // Interest
            // 
            Interest.HeaderText = "Interest";
            Interest.MinimumWidth = 6;
            Interest.Name = "Interest";
            Interest.Width = 125;
            // 
            // btnSaveInterest
            // 
            btnSaveInterest.Font = new Font("Segoe UI", 12F);
            btnSaveInterest.Location = new Point(522, 285);
            btnSaveInterest.Name = "btnSaveInterest";
            btnSaveInterest.RightToLeft = RightToLeft.Yes;
            btnSaveInterest.Size = new Size(141, 43);
            btnSaveInterest.TabIndex = 9;
            btnSaveInterest.Text = "Save Interest";
            btnSaveInterest.UseVisualStyleBackColor = true;
            btnSaveInterest.Click += btnSaveInterest_Click;
            // 
            // CalculateInterestForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(920, 572);
            Controls.Add(btnSaveInterest);
            Controls.Add(dgvResult);
            Controls.Add(btnCalculate);
            Controls.Add(txtTime);
            Controls.Add(txtRate);
            Controls.Add(txtPrincipal);
            Controls.Add(lblResult);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CalculateInterestForm";
            Text = "Form1";
            Load += CalculateInterestForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblResult;
        private TextBox txtPrincipal;
        private TextBox txtRate;
        private TextBox txtTime;
        private Button btnCalculate;
        private DataGridView dgvResult;
        private DataGridViewTextBoxColumn Principal;
        private DataGridViewTextBoxColumn Rate;
        private DataGridViewTextBoxColumn Time;
        private DataGridViewTextBoxColumn Interest;
        private Button btnSaveInterest;
    }
}
