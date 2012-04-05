namespace PowderedToast.Notifications.Toast
{
    /// <summary>
    /// Defines INotificationFactory extensions with additional method overloads for creating toast notifications.
    /// </summary>
    public static class ToastNotificationFactoryExtensions
    {
        /// <summary>
        /// Creates a <see cref="IToastNotification"/> object from default values.
        /// </summary>
        /// <param name="factory">INotification factory type to extend.</param>
        /// <returns><see cref="IToastNotification"/> with default values.</returns>
        public static IToastNotification CreateToastNotification(this INotificationFactory factory)
        {
            return ToastNotification.DefaultToastNotification;
        }

        /// <summary>
        /// Creates a <see cref="IToastNotification"/> object with the given <paramref name="message"/>.
        /// </summary>
        /// <param name="factory">INotification factory type to extend.</param>
        /// <param name="message">Text message to use.</param>
        /// <returns><see cref="IToastNotification"/> containing the given values.</returns>
        public static IToastNotification CreateToastNotification(this INotificationFactory factory, string message)
        {
            return new ToastNotification { Payload = message };
        }

        /// <summary>
        /// Creates a <see cref="IToastNotification"/> object with the 
        /// given <paramref name="message"/> and <paramref name="title"/>.
        /// </summary>
        /// <param name="factory">INotification factory type to extend.</param>
        /// <param name="message">Text message to use.</param>
        /// <param name="title">Title of text message.</param>
        /// <returns><see cref="IToastNotification"/> containing the given values.</returns>
        public static IToastNotification CreateToastNotification(
            this INotificationFactory factory,
            string message,
            string title)
        {
            return new ToastNotification { Payload = message, Title = title };
        }

        /// <summary>
        /// Creates a <see cref="IToastNotification"/> object with the given <paramref name="message"/>,
        /// <paramref name="title"/> and <paramref name="owner"/>.
        /// </summary>
        /// <param name="factory">INotification factory type to extend.</param>
        /// <param name="message">Text message to use.</param>
        /// <param name="title">Title of text message.</param>
        /// <param name="owner">Application who owns this notification.</param>
        /// <returns><see cref="IToastNotification"/> containing the given values.</returns>
        public static IToastNotification CreateToastNotification(
            this INotificationFactory factory,
            string message,
            string title,
            string owner)
        {
            return new ToastNotification { Payload = message, Title = title, Owner = owner };
        }

        /// <summary>
        /// Creates a <see cref="IToastNotification"/> object with the 
        /// given <paramref name="message"/>, <paramref name="title"/>, <paramref name="title"/>,
        /// and <paramref name="priority"/>.
        /// </summary>
        /// <param name="factory">INotification factory type to extend.</param>
        /// <param name="message">Text message to use.</param>
        /// <param name="title">Title of text message.</param>
        /// <param name="owner">Application who owns this notification.</param>
        /// <param name="priority">Priority to use.</param>
        /// <returns><see cref="IToastNotification"/> containing the given values.</returns>
        public static IToastNotification CreateToastNotification(
            this INotificationFactory factory,
            string message,
            string title,
            string owner,
            NotificationPriority priority)
        {
            return new ToastNotification { Payload = message, Title = title, Owner = owner, Priority = priority };
        }

        /// <summary>
        /// Creates a <see cref="IToastNotification"/> object with the given <paramref name="message"/>, 
        /// <paramref name="title"/>, <paramref name="title"/>, <paramref name="priority"/> and <paramref name="style"/>.
        /// </summary>
        /// <param name="factory">INotification factory type to extend.</param>
        /// <param name="message">Text message to use.</param>
        /// <param name="title">Title of text message.</param>
        /// <param name="owner">Application who owns this notification.</param>
        /// <param name="priority">Priority to use.</param>
        /// <param name="style">Gui style of the toast.</param>
        /// <returns><see cref="IToastNotification"/> containing the given values.</returns>
        public static IToastNotification CreateToastNotification(
            this INotificationFactory factory,
            string message,
            string title,
            string owner,
            NotificationPriority priority,
            IToastNotificationStyle style)
        {
            return new ToastNotification 
            {
                Payload = message,
                Title = title,
                Owner = owner,
                Priority = priority,
                Style = style 
            };
        }

        /// <summary>
        /// Creates a <see cref="IToastNotification"/> object with the given <paramref name="message"/>, 
        /// <paramref name="title"/>, <paramref name="title"/>, <paramref name="priority"/>, 
        /// <paramref name="style"/> and <paramref name="icon"/>.
        /// </summary>
        /// <param name="factory">INotification factory type to extend.</param>
        /// <param name="message">Text message to use.</param>
        /// <param name="title">Title of text message.</param>
        /// <param name="owner">Application who owns this notification.</param>
        /// <param name="priority">Priority to use.</param>
        /// <param name="style">Gui style of the toast.</param>
        /// <param name="icon">Gui icon of the toast.</param>
        /// <returns></returns>
        public static IToastNotification CreateToastNotification(
            this INotificationFactory factory,
            string message,
            string title,
            string owner,
            NotificationPriority priority,
            IToastNotificationStyle style,
            IToastNotificationIcon icon)
        {
            return new ToastNotification 
            {
                Payload = message,
                Title = title,
                Owner = owner,
                Priority = priority,
                Style = style,
                Icon = icon
            };
        }
    }
}