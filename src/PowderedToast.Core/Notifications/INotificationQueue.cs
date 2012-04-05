using System.Collections.Generic;

namespace PowderedToast.Notifications
{
    /// <summary>
    /// Exposes functionality for a thread-safe FIFO collection.
    /// </summary>
    internal interface INotificationQueue
    {
        /// <summary>
        /// Returns true if queue is empty.
        /// </summary>
        bool IsEmpty { get; }

        /// <summary>
        /// Returns number of elements in the queue.
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Adds given <see cref="INotification"/> to the queue.
        /// </summary>
        /// <param name="notification">Notification object to add.</param>
        void Enqueue(INotification notification);

        /// <summary>
        /// Removes and returns the first <see cref="INotification"/> from the queue.
        /// </summary>
        /// <returns>Returns first <see cref="INotification"/> or null.</returns>
        INotification Dequeue();

        /// <summary>
        /// Removes and returns all <see cref="INotification"/> objects in the queue.
        /// </summary>
        /// <returns>Returns all <see cref="INotification"/>objects or null.</returns>
        IList<INotification> DequeueAll();

    }
}