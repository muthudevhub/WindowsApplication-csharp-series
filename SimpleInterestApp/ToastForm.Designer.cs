partial class ToastForm
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

    private void InitializeComponent()
    {
        SuspendLayout();
        // 
        // ToastForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(450, 100);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(4, 4, 4, 4);
        Name = "ToastForm";
        Text = "ToastForm";
        ResumeLayout(false);
    }
}