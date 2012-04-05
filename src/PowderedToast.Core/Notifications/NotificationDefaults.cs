namespace PowderedToast.Notifications
{
    /// <summary>
    /// Contains default field values for basic <see cref="INotification"/> objects.
    /// </summary>
    internal static class NotificationDefaults
    {
        /// <summary>
        /// Creates <see cref="INotification"/> object with default values.
        /// </summary>
        internal static readonly Notification Instance;

        /// <summary>
        /// Default INotification.Owner == "&lt;Powdered Toast&gt;".
        /// </summary>
        internal static readonly string Owner;

        /// <summary>
        /// Default INotification.Priority == "NotificationPriority.Default".
        /// </summary>
        internal static readonly NotificationPriority Priority;

        /// <summary>
        /// Static constructor for initializing default fields.
        /// </summary>
        static NotificationDefaults()
        {
            Owner = "<PowderedToast>";
            Priority = NotificationPriority.Default;
            Instance = new Notification { Owner = Owner, Priority = Priority };
        }
    }
}