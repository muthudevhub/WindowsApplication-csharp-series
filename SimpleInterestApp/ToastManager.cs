using System.Collections.Generic;
using System.Drawing;

public static class ToastManager
{
    private static List<ToastForm> openToasts = new List<ToastForm>();

    // Clean modern theme color definitions
    private static readonly Color SuccessColor = Color.FromArgb(0, 230, 118); // Emerald Green
    private static readonly Color ErrorColor = Color.FromArgb(255, 23, 68);    // Crimson Red
    private static readonly Color WarningColor = Color.FromArgb(255, 196, 0);  // Amber Gold

    public static void ShowSuccess(string message) => TriggerToast(message, SuccessColor);
    public static void ShowError(string message) => TriggerToast(message, ErrorColor);
    public static void ShowWarning(string message) => TriggerToast(message, WarningColor);

    private static void TriggerToast(string message, Color accentColor)
    {
        // Clean up closed references cleanly before appending position arrays
        openToasts.RemoveAll(t => t.IsDisposed);

        // Limit maximum concurrent on-screen rendering layers for memory stability
        if (openToasts.Count >= 3)
        {
            openToasts[0].Close();
            openToasts.RemoveAt(0);
        }

        ToastForm toast = new ToastForm(message, accentColor);
        openToasts.Add(toast);

        // Safe tracking index calculation
        toast.Launch(openToasts.Count);
    }
}