namespace PowderedToast.Notifications
{
    /// <summary>
    /// Responsible for creation of all <see cref="INotification"/> and derived types.
    /// </summary>
    public interface INotificationFactory
    {
        /// <summary>
        /// Create <see cref="INotification"/> instance with default values.
        /// </summary>
        /// <returns>Default <see cref="INotification"/>.</returns>
        INotification CreateNotification();

        /// <summary>
        /// Create <see cref="INotification"/> instance with default values.
        /// </summary>
        /// <param name="owner">Owner/application who requested this notification.</param>
        /// <returns><see cref="INotification"/> for given <paramref name="owner"/>.</returns>
        INotification CreateNotification(string owner);
    }
}