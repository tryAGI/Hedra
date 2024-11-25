
#nullable enable

namespace Hedra
{
    /// <summary>
    /// 
    /// </summary>
    public enum AvatarProjectStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Failed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AvatarProjectStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AvatarProjectStatus value)
        {
            return value switch
            {
                AvatarProjectStatus.Queued => "Queued",
                AvatarProjectStatus.InProgress => "InProgress",
                AvatarProjectStatus.Completed => "Completed",
                AvatarProjectStatus.Failed => "Failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AvatarProjectStatus? ToEnum(string value)
        {
            return value switch
            {
                "Queued" => AvatarProjectStatus.Queued,
                "InProgress" => AvatarProjectStatus.InProgress,
                "Completed" => AvatarProjectStatus.Completed,
                "Failed" => AvatarProjectStatus.Failed,
                _ => null,
            };
        }
    }
}