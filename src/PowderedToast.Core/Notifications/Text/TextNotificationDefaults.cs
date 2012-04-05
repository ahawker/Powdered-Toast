using System.Text;

namespace PowderedToast.Notifications.Text
{
    /// <summary>
    /// Contains default field values for basic <see cref="ITextNotification"/> objects.
    /// </summary>
    internal static class TextNotificationDefaults
    {
        /// <summary>
        /// Creates <see cref="ITextNotification"/> object with default values.
        /// </summary>
        internal static readonly TextNotification Instance;

        /// <summary>
        /// Default ITextNotification.Title == "&lt;PowderedToast Notification&gt;".
        /// </summary>
        internal static readonly string Title;

        /// <summary>
        /// Default ITextNotification.Payload == "&lt;This notification is powered by PowderedToast&gt;".
        /// </summary>
        internal static readonly string Payload;

        /// <summary>
        /// Default ITextNotification.Encoding == "Encoding.Unicode".
        /// </summary>
        internal static readonly Encoding Encoding;

        /// <summary>
        /// Static constructor for initializing default fields.
        /// </summary>
        static TextNotificationDefaults()
        {
            Title = "<PowderedToast Notification>";
            Payload = "<This notification is powered by PowderedToast>";
            Encoding = Encoding.Unicode;
            Instance = new TextNotification { Title = Title, Payload = Payload, Encoding = Encoding };
        }
    }
}