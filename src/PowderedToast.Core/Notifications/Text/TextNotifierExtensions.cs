namespace PowderedToast.Notifications.Text
{
    /// <summary>
    /// Defines INotifier extension methods with additional method overloads for sending text notifications.
    /// </summary>
    public static class TextNotifierExtensions
    {
        /// <summary>
        /// Factory responsible for creating <see cref="INotification"/> objects.
        /// </summary>
        private static readonly INotificationFactory NotificationFactory = new NotificationFactory();

        /// <summary>
        /// Sends a text notification with the given <paramref name="message"/>.
        /// </summary>
        /// <param name="notifier">INotifier type to extend.</param>
        /// <param name="message">Text message to be sent.</param>
        public static void SendText(this INotifier notifier, string message)
        {
            var text = NotificationFactory.CreateTextNotification(message);
            notifier.Send(text);
        }

        /// <summary>
        /// Sends a text notification with the given <paramref name="message"/> and <paramref name="title"/>.
        /// </summary>
        /// <param name="notifier">INotifier type to extend.</param>
        /// <param name="message">Text message to be sent.</param>
        /// <param name="title">Title of text message.</param>
        public static void SendText(this INotifier notifier, string message, string title)
        {
            var text = NotificationFactory.CreateTextNotification(message, title);
            notifier.Send(text);
        }

        /// <summary>
        /// Sends a text notification with the given <paramref name="message"/>, <paramref name="title"/>
        /// and <paramref name="owner"/>.
        /// </summary>
        /// <param name="notifier">INotifier type to extend.</param>
        /// <param name="message">Text message to be sent.</param>
        /// <param name="title">Title of text message.</param>
        /// <param name="owner">Application who owns this notification.</param>
        public static void SendText(this INotifier notifier, string message, string title, string owner)
        {
            var text = NotificationFactory.CreateTextNotification(message, title, owner);
            notifier.Send(text);
        }

        /// <summary>
        /// Sends a text notification with the given <paramref name="message"/>, <paramref name="title"/>,
        /// <paramref name="owner"/> and <paramref name="priority"/>.
        /// </summary>
        /// <param name="notifier">INotifier type to extend.</param>
        /// <param name="message">Text message to be sent.</param>
        /// <param name="title">Title of text message.</param>
        /// <param name="owner">Application who owns this notification.</param>
        /// <param name="priority">Message priority.</param>
        public static void SendText(
            this INotifier notifier, 
            string message, 
            string title, 
            string owner, 
            NotificationPriority priority)
        {
            var text = NotificationFactory.CreateTextNotification(message, title, owner, priority);
            notifier.Send(text);
        }

        /// <summary>
        /// Sends the given text notification.
        /// </summary>
        /// <param name="notifier">INotifier type to extend.</param>
        /// <param name="notification">Text notification to be sent.</param>
        public static void SendText(this INotifier notifier, ITextNotification notification)
        {
            notifier.Send(notification);
        }
    }
}