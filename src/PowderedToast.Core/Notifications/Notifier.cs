using System;
using System.Collections.Generic;

namespace PowderedToast.Notifications
{
    public sealed class Notifier : INotifier, INotificationProvider
    {
        private readonly INotificationFactory m_NotificationFactory;
        private readonly INotificationQueue m_NotificationQueue;

        /// <summary>
        /// Event raised when a notification is available to be processed.
        /// </summary>
        public event EventHandler NotificationAvailable;

        /// <summary>
        /// Returns the number of notifications available.
        /// </summary>
        public int Count
        {
            get { return m_NotificationQueue.Count; }
        }

        /// <summary>
        /// Returns true if there are notifications available to be processed.
        /// </summary>
        public bool NotificationsAvailable
        {
            get { return !m_NotificationQueue.IsEmpty; }
        }

        /// <summary>
        /// Creates a new <see cref="Notifier"/> object.
        /// </summary>
        public Notifier()
            : this(new NotificationQueue(), new NotificationFactory())
        {
        }

        /// <summary>
        /// Creates a new <see cref="Notifier"/> with the given <see cref="INotification"/> queue.
        /// </summary>
        /// <param name="queue"><see cref="INotificationQueue"/> to use.</param>
        /// <param name="factory"> </param>
        internal Notifier(INotificationQueue queue, INotificationFactory factory)
        {
            m_NotificationQueue = queue;
            m_NotificationFactory = factory;
        }

        /// <summary>
        /// Retrieves a notification from the provider.
        /// </summary>
        /// <returns>Notification if one exists, null otherwise.</returns>
        public INotification GetNotification()
        {
            if (m_NotificationQueue == null)
                return null;

            return m_NotificationQueue.Dequeue();
        }

        /// <summary>
        /// Retrieves all notifications from the provider.
        /// </summary>
        /// <returns>Notifications is one or more exist, null otherwise.</returns>
        public IList<INotification> GetNotifications()
        {
            if (m_NotificationQueue == null)
                return null;

            return m_NotificationQueue.DequeueAll();
        }

        /// <summary>
        /// Callback raised when this notification provider is registered in the system.
        /// </summary>
        public void OnProviderRegistered()
        {
        }

        /// <summary>
        /// Callback raised when this notification provider is deregistered in the system.
        /// </summary>
        public void OnProviderDeregistered()
        {
        }

        /// <summary>
        /// Sends an empty notification.
        /// </summary>
        public void Send()
        {
            if (m_NotificationQueue == null)
                return;

            m_NotificationQueue.Enqueue(m_NotificationFactory.CreateNotification());
        }

        /// <summary>
        /// Sends a basic notification with no payload.
        /// </summary>
        /// <param name="notification">Notification to send.</param>
        public void Send(INotification notification)
        {
            if (m_NotificationQueue == null)
                return;

            m_NotificationQueue.Enqueue(notification.DeepCopy());
        }

        /// <summary>
        /// Sends a <typeparamref name="T"/> notification.
        /// </summary>
        /// <typeparam name="T"><see cref="INotification"/> derived type.</typeparam>
        /// <param name="notification">Notification to send.</param>
        public void Send<T>(T notification) where T : INotification
        {
            if (m_NotificationQueue == null)
                return;

            m_NotificationQueue.Enqueue(notification.DeepCopy());
        }
    }
}