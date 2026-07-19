using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

public partial class ToastForm : Form
{
    private Timer animationTimer = new Timer();
    private Timer displayTimer = new Timer();
    private int targetY;
    private int currentY;
    private bool isFadingOut = false;

    public ToastForm(string message, Color accentColor)
    {
        // Force high-end rendering settings
        this.DoubleBuffered = true;
        this.FormBorderStyle = FormBorderStyle.None;
        this.ShowInTaskbar = false;
        this.StartPosition = FormStartPosition.Manual;

        // Mobile-friendly size adjustments
        this.Size = new Size(360, 80);
        this.BackColor = Color.FromArgb(30, 30, 30); // Dark Slate

        // Reusable Custom Layout Engine
        InitLayout(message, accentColor);

        // Frame-rate settings (60 FPS fluid targets)
        animationTimer.Interval = 15;
        animationTimer.Tick += AnimationTimer_Tick;

        displayTimer.Interval = 3000; // Visible duration
        displayTimer.Tick += (s, e) => { displayTimer.Stop(); isFadingOut = true; animationTimer.Start(); };
    }

    private void InitLayout(string message, Color accentColor)
    {
        // Left Accent Border Pillar
        Panel accentBar = new Panel
        {
            BackColor = accentColor,
            Width = 6,
            Dock = DockStyle.Left
        };
        this.Controls.Add(accentBar);

        // Mobile-Readable Typography Container
        Label lblMessage = new Label
        {
            Text = message,
            ForeColor = Color.White,
            Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel), // Crisp readability scale
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleLeft,
            Padding = new Padding(15, 0, 15, 0)
        };
        this.Controls.Add(lblMessage);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        // Subtle crisp bounding line for high contrast
        using (Pen p = new Pen(Color.FromArgb(50, 50, 50), 1))
        {
            e.Graphics.DrawRectangle(p, 0, 0, this.Width - 1, this.Height - 1);
        }
    }

    public void Launch(int activeOffsetIndex)
    {
        this.Opacity = 0.0;
        Rectangle workingArea = Screen.PrimaryScreen.WorkingArea;

        int startX = workingArea.Right - this.Width - 20;

        // Dynamically calculates stack positions safely without overlap crashes
        targetY = workingArea.Bottom - ((this.Height + 15) * activeOffsetIndex) - 20;
        currentY = targetY + 30; // Starts 30px low for dynamic "pop-up" feel

        this.Location = new Point(startX, currentY);
        this.Show();

        animationTimer.Start();
    }

    private void AnimationTimer_Tick(object sender, EventArgs e)
    {
        if (!isFadingOut)
        {
            // Entrance: Move Up & Fade In
            if (currentY > targetY) currentY -= 3;
            if (this.Opacity < 1.0) this.Opacity += 0.15;

            this.Location = new Point(this.Location.X, currentY);

            if (currentY <= targetY && this.Opacity >= 1.0)
            {
                animationTimer.Stop();
                displayTimer.Start();
            }
        }
        else
        {
            // Exit: Slide Down & Fade Out
            currentY += 2;
            this.Opacity -= 0.1;
            this.Location = new Point(this.Location.X, currentY);

            if (this.Opacity <= 0.0)
            {
                animationTimer.Stop();
                this.Close();
            }
        }
    }
}