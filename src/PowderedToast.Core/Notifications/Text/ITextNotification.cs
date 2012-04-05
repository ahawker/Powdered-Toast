using System.Text;

namespace PowderedToast.Notifications.Text
{
    /// <summary>
    /// Basic notification type with a string payload.
    /// </summary>
    public interface ITextNotification : INotification<string>
    {
        /// <summary>
        /// Text title to be shown in notification header.
        /// </summary>
        string Title { get; }

        /// <summary>
        /// Character encoding type of the payload. 
        /// </summary>
        Encoding Encoding { get; }
    }
}