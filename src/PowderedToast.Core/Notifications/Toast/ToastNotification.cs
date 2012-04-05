using System;
using PowderedToast.Notifications.Text;

namespace PowderedToast.Notifications.Toast
{
    /// <summary>
    /// <see cref="ToastNotification"/> extends <see cref="TextNotification"/> with gui style and icon data.
    /// </summary>
    [Serializable]
    public class ToastNotification : TextNotification, IToastNotification
    {
        /// <summary>
        /// Toast notification with default values.
        /// </summary>
        public static readonly ToastNotification DefaultToastNotification = ToastNotificationDefaults.Instance;

        /// <summary>
        /// Visual style options to customize this toast.
        /// </summary>
        public IToastNotificationStyle Style { get; protected internal set; }

        /// <summary>
        /// Icon to be displayed on this toast.
        /// </summary>
        public IToastNotificationIcon Icon { get; protected internal set; }

        /// <summary>
        /// Creates a <see cref="ToastNotification"/> from the <see cref="TextNotification"/> defaults.
        /// </summary>
        internal ToastNotification()
            : this(TextNotificationDefaults.Instance)
        {
        }

        /// <summary>
        /// Creates a <see cref="ToastNotification"/> from the given <paramref name="notification"/>.
        /// </summary>
        /// <param name="notification">Notification to copy parameters from.</param>
        internal ToastNotification(ITextNotification notification)
            : base(notification)
        {
            Title = notification.Title;
            Payload = notification.Payload;
            Encoding = notification.Encoding;

            Style = ToastNotificationDefaults.Style;
            Icon = ToastNotificationDefaults.Icon;
        }

        /// <summary>
        /// Produces a deep copy of this toast notification.
        /// </summary>
        /// <returns>Exact copy of notification.</returns>
        public new IToastNotification DeepCopy()
        {
            return Utilities.DeepCopy<IToastNotification>(this);
        }
    }
}