using System;
using PowderedToast.Notifications;
using PowderedToast.Subscription;

namespace PowderedToast.Api
{
    public static class PowderedToastApi
    {
        public static INotifier GetNotifier()
        {
            return null;
        }

        public static INotifier GetNotifier(string owner)
        {
            return null;
        }

        public static void RegisterSubscriber(INotificationSubscriber subscriber)
        {
        }

        public static void DeregisterSubscriber(INotificationSubscriber subscriber)
        {
        }
    }
}