
#nullable enable

namespace Hedra
{
    /// <summary>
    /// 
    /// </summary>
    public enum GenerationStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Complete,
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Processing,
        /// <summary>
        /// 
        /// </summary>
        Queued,
        /// <summary>
        /// 
        /// </summary>
        Finalizing,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerationStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerationStatus value)
        {
            return value switch
            {
                GenerationStatus.Complete => "complete",
                GenerationStatus.Error => "error",
                GenerationStatus.Processing => "processing",
                GenerationStatus.Queued => "queued",
                GenerationStatus.Finalizing => "finalizing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerationStatus? ToEnum(string value)
        {
            return value switch
            {
                "complete" => GenerationStatus.Complete,
                "error" => GenerationStatus.Error,
                "processing" => GenerationStatus.Processing,
                "queued" => GenerationStatus.Queued,
                "finalizing" => GenerationStatus.Finalizing,
                _ => null,
            };
        }
    }
}