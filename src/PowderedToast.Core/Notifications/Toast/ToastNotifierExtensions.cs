namespace PowderedToast.Notifications.Toast
{
    /// <summary>
    /// Defines INotifier extension methods with additional method overloads for sending toast notifications.
    /// </summary>
    public static class ToastNotifierExtensions
    {
        /// <summary>
        /// Factory responsible for creating <see cref="INotification"/> objects.
        /// </summary>
        private static readonly INotificationFactory NotificationFactory = new NotificationFactory();

        /// <summary>
        /// Sends a toast notification with the given <paramref name="message"/>.
        /// </summary>
        /// <param name="notifier">INotifier type to extend.</param>
        /// <param name="message">Toast message body.</param>
        public static void SendToast(this INotifier notifier, string message)
        {
            var toast = NotificationFactory.CreateToastNotification(message);
            SendToast(notifier, toast);
        }

        /// <summary>
        /// Sends a toast notification with the given <paramref name="message"/> and <paramref name="title"/>.
        /// </summary>
        /// <param name="notifier">INotifier type to extend.</param>
        /// <param name="message">Toast message body.</param>
        /// <param name="title">Toast title</param>
        public static void SendToast(this INotifier notifier, string message, string title)
        {
            var toast = NotificationFactory.CreateToastNotification(message, title);
            SendToast(notifier, toast);
        }

        /// <summary>
        /// Sends a toast notification with the given <paramref name="message"/>, <paramref name="title"/>
        /// and <paramref name="owner"/>.
        /// </summary>
        /// <param name="notifier">INotifier type to extend.</param>
        /// <param name="message">Toast message body.</param>
        /// <param name="title">Toast title</param>
        /// <param name="owner">Application who owns this notification.</param>
        public static void SendToast(this INotifier notifier, string message, string title, string owner)
        {
            var toast = NotificationFactory.CreateToastNotification(message, title, owner);
            SendToast(notifier, toast);
        }

        /// <summary>
        /// Sends a toast notification with the given <paramref name="message"/>, <paramref name="title"/>
        /// and assigned <paramref name="priority"/>.
        /// </summary>
        /// <param name="notifier">INotifier type to extend.</param>
        /// <param name="message">Toast message body.</param>
        /// <param name="title">Toast title</param>
        /// <param name="owner">Application who owns this notification.</param>
        /// <param name="priority">Toast sending priority.</param>
        public static void SendToast(
            this INotifier notifier, 
            string message, 
            string title, 
            string owner,
            NotificationPriority priority)
        {
            var toast = NotificationFactory.CreateToastNotification(message, title, owner, priority);
            SendToast(notifier, toast);
        }

        /// <summary>
        /// Sends a toast notification with the given <paramref name="message"/>, <paramref name="title"/>,
        /// <paramref name="priority"/> and <paramref name="style"/>.
        /// </summary>
        /// <param name="notifier">INotifier type to extend.</param>
        /// <param name="message">Toast message body.</param>
        /// <param name="title">Toast title</param>
        /// <param name="owner">Application who owns this notification.</param>
        /// <param name="priority">Toast sending priority.</param>
        /// <param name="style">Toast GUI style options.</param>
        public static void SendToast(
            this INotifier notifier,
            string message,
            string title,
            string owner,
            NotificationPriority priority,
            IToastNotificationStyle style)
        {
            var toast = NotificationFactory.CreateToastNotification(message, title, owner, priority, style);
            SendToast(notifier, toast);
        }

        /// <summary>
        /// Sends a toast notification with the given <paramref name="message"/>, <paramref name="title"/>,
        /// <paramref name="priority"/>, <paramref name="style"/> and <paramref name="icon"/>.
        /// </summary>
        /// <param name="notifier">INotifier type to extend.</param>
        /// <param name="message">Toast message body.</param>
        /// <param name="title">Toast title</param>
        /// <param name="owner">Application who owns this notification.</param>
        /// <param name="priority">Toast sending priority.</param>
        /// <param name="style">Toast Gui style options.</param>
        /// <param name="icon">Toast Gui icon.</param>
        public static void SendToast(
            this INotifier notifier,
            string message,
            string title,
            string owner,
            NotificationPriority priority,
            IToastNotificationStyle style,
            IToastNotificationIcon icon)
        {
            var toast = NotificationFactory.CreateToastNotification(message, title, owner, priority, style, icon);
            SendToast(notifier, toast);
        }

        /// <summary>
        /// Sends the given <paramref name="notification"/>.
        /// </summary>
        /// <param name="notifier">INotifier type to extend.</param>
        /// <param name="notification">Notification to send.</param>
        public static void SendToast(this INotifier notifier, IToastNotification notification)
        {
            notifier.Send(notification);
        }
    }
}