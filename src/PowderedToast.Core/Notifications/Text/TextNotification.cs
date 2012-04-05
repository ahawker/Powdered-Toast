using System;
using System.Text;

namespace PowderedToast.Notifications.Text
{
    /// <summary>
    /// <see cref="TextNotification"/> extends <see cref="Notification"/> with a title and encoded string payload.
    /// </summary>
    [Serializable]
    public class TextNotification : Notification, ITextNotification
    {
        /// <summary>
        /// Text notification with default values.
        /// </summary>
        public static readonly TextNotification DefaultTextNotification = TextNotificationDefaults.Instance;

        /// <summary>
        /// Text title to be shown in notification header.
        /// </summary>
        public string Title { get; protected internal set; }

        /// <summary>
        /// Character encoding type of the payload. 
        /// </summary>
        public Encoding Encoding { get; protected internal set; }

        /// <summary>
        /// Data payload of this notification.
        /// </summary>
        public string Payload { get; protected internal set; }

        /// <summary>
        /// Creates a <see cref="TextNotification"/> from the <see cref="Notification"/> defaults.
        /// </summary>
        internal TextNotification()
            : this(NotificationDefaults.Instance)
        {
        }

        /// <summary>
        /// Create a <see cref="TextNotification"/> from the given <paramref name="notification"/>.
        /// </summary>
        /// <param name="notification">Notification to copy parameters from.</param>
        internal TextNotification(INotification notification)
        {
            Owner = notification.Owner;
            Priority = notification.Priority;

            Title = TextNotificationDefaults.Title;
            Encoding = TextNotificationDefaults.Encoding;
            Payload = TextNotificationDefaults.Payload;
        }

        /// <summary>
        /// Produces a deep copy of this text notification.
        /// </summary>
        /// <returns>Exact copy of notification.</returns>
        public new ITextNotification DeepCopy()
        {
            return Utilities.DeepCopy<ITextNotification>(this);
        }
    }
}