namespace PowderedToast.Notifications
{
    /// <summary>
    /// Responsible for creation of all <see cref="INotification"/> and derived types.
    /// </summary>
    public class NotificationFactory : INotificationFactory
    {
        /// <summary>
        /// Create <see cref="INotification"/> instance with default values.
        /// </summary>
        /// <returns><see cref="INotification"/> with default values.</returns>
        public INotification CreateNotification()
        {
            return Notification.DefaultNotification;
        }

        /// <summary>
        /// Create <see cref="INotification"/> instance with default values.
        /// </summary>
        /// <param name="owner">Application who owns this notification.</param>
        /// <returns><see cref="INotification"/> with the given values.</returns>
        public INotification CreateNotification(string owner)
        {
            return new Notification { Owner = owner };
        }
    }
}