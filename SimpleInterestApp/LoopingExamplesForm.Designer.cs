namespace SimpleInterestApp
{
    partial class LoopingExamplesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstForLoopData = new ListBox();
            button1 = new Button();
            btnForEachLoop = new Button();
            btnStudentNameForLoop = new Button();
            SuspendLayout();
            // 
            // lstForLoopData
            // 
            lstForLoopData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstForLoopData.FormattingEnabled = true;
            lstForLoopData.Location = new Point(178, 88);
            lstForLoopData.Name = "lstForLoopData";
            lstForLoopData.Size = new Size(538, 228);
            lstForLoopData.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(49, 358);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 0;
            button1.Text = "For Loop";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnForLoop_Click;
            // 
            // btnForEachLoop
            // 
            btnForEachLoop.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnForEachLoop.Location = new Point(255, 341);
            btnForEachLoop.Name = "btnForEachLoop";
            btnForEachLoop.Size = new Size(242, 80);
            btnForEachLoop.TabIndex = 3;
            btnForEachLoop.Text = "Print student name using For each loop";
            btnForEachLoop.UseVisualStyleBackColor = true;
            btnForEachLoop.Click += btnForEachLoop_Click;
            // 
            // btnStudentNameForLoop
            // 
            btnStudentNameForLoop.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnStudentNameForLoop.Location = new Point(530, 341);
            btnStudentNameForLoop.Name = "btnStudentNameForLoop";
            btnStudentNameForLoop.Size = new Size(242, 80);
            btnStudentNameForLoop.TabIndex = 3;
            btnStudentNameForLoop.Text = "Print student name using for loop";
            btnStudentNameForLoop.UseVisualStyleBackColor = true;
            btnStudentNameForLoop.Click += btnStudentNameForLoop_Click;
            // 
            // LoopingExamplesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStudentNameForLoop);
            Controls.Add(btnForEachLoop);
            Controls.Add(lstForLoopData);
            Controls.Add(button1);
            Name = "LoopingExamplesForm";
            Text = "LoopingExamplesForm";
            ResumeLayout(false);
        }

        #endregion
        private ListBox lstForLoopData;
        private Button button1;
        private Button btnForEachLoop;
        private Button btnStudentNameForLoop;
    }
}