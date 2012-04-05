using System;

namespace PowderedToast.Notifications
{
    /// <summary>
    /// Base class of the <see cref="Notification"/> type hierarchy which has no payload.
    /// </summary>
    [Serializable]
    public class Notification : INotification
    {
        /// <summary>
        /// Notification with default values.
        /// </summary>
        public static readonly Notification DefaultNotification = NotificationDefaults.Instance;

        /// <summary>
        /// Unique identifier for this notification. 
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Name of the owner/application that created this notification.
        /// </summary>
        public string Owner { get; protected internal set; }

        /// <summary>
        /// Priority to determine the importance of this notification.
        /// </summary>
        public NotificationPriority Priority { get; protected internal set; }

        /// <summary>
        /// Produces a deep copy of this notification.
        /// </summary>
        /// <returns>Exact copy of notification.</returns>
        public INotification DeepCopy()
        {
            return Utilities.DeepCopy<INotification>(this);
        }

        /// <summary>
        /// Create a new <see cref="Notification"/> object with a unique id.
        /// </summary>
        protected internal Notification()
        {
            Id = Guid.NewGuid();

            Owner = NotificationDefaults.Owner;
            Priority = NotificationDefaults.Priority;
        }


    }
}