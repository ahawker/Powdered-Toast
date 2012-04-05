using System;
using System.Collections.Generic;

namespace PowderedToast.Notifications
{
    internal interface INotificationProvider
    {
        /// <summary>
        /// Event raised when a notification is available to be processed.
        /// </summary>
        event EventHandler NotificationAvailable;

        /// <summary>
        /// Returns the number of notifications available.
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Returns true if there are notifications available to be processed.
        /// </summary>
        bool NotificationsAvailable { get; }

        /// <summary>
        /// Retrieves a notification from the provider.
        /// </summary>
        /// <returns>Notification if one exists, null otherwise.</returns>
        INotification GetNotification();

        /// <summary>
        /// Retrieves all notifications from the provider.
        /// </summary>
        /// <returns>Notifications is one or more exist, null otherwise.</returns>
        IList<INotification> GetNotifications(); 

        /// <summary>
        /// Callback raised when this notification provider is registered in the system.
        /// </summary>
        void OnProviderRegistered();

        /// <summary>
        /// Callback raised when this notification provider is deregistered in the system.
        /// </summary>
        void OnProviderDeregistered();
    }
}