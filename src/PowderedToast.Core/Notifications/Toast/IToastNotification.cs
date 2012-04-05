using PowderedToast.Notifications.Text;

namespace PowderedToast.Notifications.Toast
{
    public interface IToastNotification : ITextNotification
    {
        /// <summary>
        /// Visual style options to customize this toast.
        /// </summary>
        IToastNotificationStyle Style { get; }

        /// <summary>
        /// Icon to be displayed on this toast.
        /// </summary>
        IToastNotificationIcon Icon { get; }
    }
}