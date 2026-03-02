
#nullable enable

namespace Hedra
{
    /// <summary>
    /// 
    /// </summary>
    public enum AssetType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Video,
        /// <summary>
        /// 
        /// </summary>
        Voice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AssetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AssetType value)
        {
            return value switch
            {
                AssetType.Text => "text",
                AssetType.Image => "image",
                AssetType.Audio => "audio",
                AssetType.Video => "video",
                AssetType.Voice => "voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AssetType? ToEnum(string value)
        {
            return value switch
            {
                "text" => AssetType.Text,
                "image" => AssetType.Image,
                "audio" => AssetType.Audio,
                "video" => AssetType.Video,
                "voice" => AssetType.Voice,
                _ => null,
            };
        }
    }
}