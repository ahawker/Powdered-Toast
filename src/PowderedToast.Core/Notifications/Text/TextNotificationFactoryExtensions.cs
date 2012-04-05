namespace PowderedToast.Notifications.Text
{
    /// <summary>
    /// Defines INotificationFactory extensions with additional method overloads for creating text notifications.
    /// </summary>
    public static class TextNotificationFactoryExtensions
    {
        /// <summary>
        /// Creates a <see cref="ITextNotification"/> object from default values.
        /// </summary>
        /// <param name="factory">INotificationFactory type to extend.</param>
        /// <returns><see cref="ITextNotification"/> with default values.</returns>
        public static ITextNotification CreateTextNotification(this INotificationFactory factory)
        {
            return TextNotification.DefaultTextNotification;
        }

        /// <summary>
        /// Creates a <see cref="ITextNotification"/> object with the given <paramref name="message"/>.
        /// </summary>
        /// <param name="factory">INotificationFactory type to extend.</param>
        /// <param name="message">Text message to be use.</param>
        /// <returns><see cref="ITextNotification"/> containing the given values.</returns>
        public static ITextNotification CreateTextNotification(this INotificationFactory factory, string message)
        {
            return new TextNotification { Payload = message };
        }

        /// <summary>
        /// Creates a <see cref="ITextNotification"/> object with the given <paramref name="message"/> 
        /// and <paramref name="title"/>.
        /// </summary>
        /// <param name="factory">INotificationFactory type to extend.</param>
        /// <param name="message">Text message to be use.</param>
        /// <param name="title">Title of text message.</param>
        /// <returns><see cref="ITextNotification"/> containing the given values.</returns>
        public static ITextNotification CreateTextNotification(
            this INotificationFactory factory, 
            string message, 
            string title)
        {
            return new TextNotification { Payload = message, Title = title };
        }

        /// <summary>
        /// Creates a <see cref="ITextNotification"/> object with the given <paramref name="message"/>,
        /// <paramref name="title"/> and <paramref name="owner"/>.
        /// </summary>
        /// <param name="factory">INotificationFactory type to extend.</param>
        /// <param name="message">Text message to be use.</param>
        /// <param name="title">Title of text message.</param>
        /// <param name="owner">Application who owns this notification.</param>
        /// <returns></returns>
        public static ITextNotification CreateTextNotification(
            this INotificationFactory factory,
            string message,
            string title,
            string owner)
        {
            return new TextNotification { Payload = message, Title = title, Owner = owner };
        }

        /// <summary>
        /// Creates a <see cref="ITextNotification"/> object with the given <paramref name="message"/>,
        /// <paramref name="title"/>, <paramref name="title"/> and <paramref name="priority"/>.
        /// </summary>
        /// <param name="factory">INotificationFactory type to extend.</param>
        /// <param name="message">Text message to be use.</param>
        /// <param name="title">Title of text message.</param>
        /// <param name="owner">Application who owns this notification.</param>
        /// <param name="priority">Priority to use.</param>
        /// <returns><see cref="ITextNotification"/> containing the given values.</returns>
        public static ITextNotification CreateTextNotification(
            this INotificationFactory factory,
            string message,
            string title,
            string owner,
            NotificationPriority priority)
        {
            return new TextNotification { Payload = message, Title = title, Owner = owner, Priority = priority };
        }
    }
}