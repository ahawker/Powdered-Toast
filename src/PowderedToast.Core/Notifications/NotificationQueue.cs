using System.Collections.Concurrent;
using System.Collections.Generic;

namespace PowderedToast.Notifications
{
    /// <summary>
    /// Thread-safe notification queue.
    /// </summary>
    internal class NotificationQueue : INotificationQueue
    {
        private readonly ConcurrentQueue<INotification> m_Queue;
 
        /// <summary>
        /// Returns true if queue is empty.
        /// </summary>
        public bool IsEmpty
        {
            get
            {
                return m_Queue == null || m_Queue.IsEmpty;
            }
        }

        /// <summary>
        /// Returns number of elements in the queue.
        /// </summary>
        public int Count
        {
            get
            {
                return m_Queue != null ? m_Queue.Count : 0;
            }
        }

        /// <summary>
        /// Creates new <see cref="NotificationQueue"/>.
        /// </summary>
        internal NotificationQueue()
        {
            m_Queue = new ConcurrentQueue<INotification>();
        }

        /// <summary>
        /// Adds given <see cref="INotification"/> to the queue.
        /// </summary>
        /// <param name="notification">Notification object to add.</param>
        public void Enqueue(INotification notification)
        {
            if (m_Queue == null)
                return;

            m_Queue.Enqueue(notification);
        }

        /// <summary>
        /// Removes and returns the first <see cref="INotification"/> from the queue.
        /// </summary>
        /// <returns>Returns first <see cref="INotification"/> or null.</returns>
        public INotification Dequeue()
        {
            if (m_Queue == null)
                return null;

            INotification notification;
            return m_Queue.TryDequeue(out notification) ? notification : null;
        }

        /// <summary>
        /// Removes and returns all <see cref="INotification"/> objects in the queue.
        /// </summary>
        /// <returns>Returns all <see cref="INotification"/>objects or null.</returns>
        public IList<INotification> DequeueAll()
        {
            if (m_Queue == null)
                return null;

            var items = new List<INotification>(m_Queue.Count);

            INotification notification;
            while (m_Queue.TryDequeue(out notification))
                items.Add(notification);

            return items;
        }
    }
}