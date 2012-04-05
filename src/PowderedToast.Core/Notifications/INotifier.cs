namespace PowderedToast.Notifications
{
    public interface INotifier
    {
        /// <summary>
        /// Sends an empty notification.
        /// </summary>
        void Send();

        /// <summary>
        /// Sends a basic notification with no payload.
        /// </summary>
        /// <param name="notification">Notification to send.</param>
        void Send(INotification notification);

        /// <summary>
        /// Sends a type <typeparamref name="T"/> notification.
        /// </summary>
        /// <typeparam name="T"><see cref="INotification"/> derived type.</typeparam>
        /// <param name="notification">Notification to send.</param>
        void Send<T>(T notification) where T : INotification;
    }
}