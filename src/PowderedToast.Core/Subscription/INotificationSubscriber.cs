using System;
using System.Collections.Generic;
using PowderedToast.Notifications;

namespace PowderedToast.Subscription
{
    public interface INotificationSubscriber
    {
        /// <summary>
        /// Register this subscriber to receive notifications of the given type.
        /// </summary>
        /// <typeparam name="T">Notification type.</typeparam>
        void RegisterNotificationType<T>() where T : INotification;

        /// <summary>
        /// Deregister this subscriber from receiving notifications of the given type.
        /// </summary>
        /// <typeparam name="T">Notification type.</typeparam>
        void DeregisterNotificationType<T>() where T : INotification;

        /// <summary>
        /// Retrieve all registered notification types for this subscriber.
        /// </summary>
        /// <typeparam name="T">Notification type.</typeparam>
        /// <returns>List of registered notification types.</returns>
        IList<T> GetNotificationTypes<T>() where T : INotification; 

        /// <summary>
        /// Callback raised when this subscriber is registered in the system.
        /// </summary>
        /// <param name="info">Information about the system which registered this subscriber.</param>
        void OnSubscriberRegistered(ISubscriptionInfo info);

        /// <summary>
        /// Callback raised when this subscriber is deregistered from the system.
        /// </summary>
        /// <param name="info">Information about the system which registered this subscriber.</param>
        void OnSubscriberDeregistered(ISubscriptionInfo info);

        //TODO: Can this be generic?
        /// <summary>
        /// Callback raised when a new notification is received.
        /// </summary>
        /// <param name="notification">Incoming notification.</param>
        void OnNotificationReceived(INotification notification);
    }
}