using PowderedToast.Notifications.Text;

namespace PowderedToast.Notifications.Toast
{
    internal static class ToastNotificationDefaults
    {
        /// <summary>
        /// Creates <see cref="IToastNotification"/> object with default values.
        /// </summary>
        internal static readonly ToastNotification Instance;

        /// <summary>
        /// Default IToastNotification.Style == TODO.
        /// </summary>
        internal static readonly IToastNotificationStyle Style;

        /// <summary>
        /// Default IToastNotification.Icon == TODO.
        /// </summary>
        internal static readonly IToastNotificationIcon Icon;

        /// <summary>
        /// Static constructor for initializing default fields.
        /// </summary>
        static ToastNotificationDefaults()
        {
            Style = new NotificationStyle();
            Icon = new NotificationIcon();
            Instance = new ToastNotification { Style = Style, Icon = Icon };
        }
    }
}