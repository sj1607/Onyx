
namespace Onyx.Classes
{
    public static class Notify
    {
        public static void NotifyToast(string title, string message, ToolTipIcon icon)
        {
            NotifyIcon notifyIcon = new NotifyIcon();
            notifyIcon.Icon = SystemIcons.Information;
            notifyIcon.Visible = true;
            notifyIcon.BalloonTipTitle = title;
            notifyIcon.BalloonTipText = message;
            notifyIcon.BalloonTipIcon = icon;
            notifyIcon.ShowBalloonTip(3000);
        }
    }
}
