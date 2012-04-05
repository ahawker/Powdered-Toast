using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PowderedToast
{
    /// <summary>
    /// Contains common helper and utility methods.
    /// </summary>
    internal static class Utilities
    {
        /// <summary>
        /// Performs a deep copy of an <typeparamref name="T"/> object using serialization. 
        /// <typeparamref name="T"/> must be marked as [Serializable].
        /// </summary>
        /// <typeparam name="T">Object type.</typeparam>
        /// <param name="obj">Object to copy.</param>
        /// <returns>Deep copy of object.</returns>
        /// <remarks>
        /// http://stackoverflow.com/questions/129389/how-do-you-do-a-deep-copy-an-object-in-net-c-specifically
        /// </remarks>
        internal static T DeepCopy<T>(T obj)
        {
            using (var stream = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(stream, obj);
                stream.Position = 0;
                return (T)formatter.Deserialize(stream);
            }
        }
    }
}