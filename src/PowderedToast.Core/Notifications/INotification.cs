using System;

namespace PowderedToast.Notifications
{
    /// <summary>
    /// Defines the most basic type of notification which contains no payload.
    /// </summary>
    public interface INotification : IDeepCopy<INotification>
    {
        /// <summary>
        /// Unique identifier for this notification. 
        /// </summary>
        Guid Id { get; }

        /// <summary>
        /// Name of the owner/application that created this notification.
        /// </summary>
        string Owner { get; }

        /// <summary>
        /// Priority to determine the importance of this notification.
        /// </summary>
        NotificationPriority Priority { get; }
    }

    /// <summary>
    /// Defines the most basic type of notification which contains a <typeparamref name="T"/> payload.
    /// </summary>
    /// <typeparam name="T">Payload type.</typeparam>
    public interface INotification<out T> : INotification
    {
        /// <summary>
        /// Data payload of this notification.
        /// </summary>
        T Payload { get; }
    }
}