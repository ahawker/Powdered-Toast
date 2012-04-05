namespace PowderedToast
{
    /// <summary>
    /// Supports a deep copy of the object via serialization.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDeepCopy<out T>
    {
        /// <summary>
        /// Makes a deep copy of the object using serialization. Implementer must be marked as [Serializable].
        /// </summary>
        /// <returns>Deep copy of the implementer.</returns>
        T DeepCopy();
    }
}