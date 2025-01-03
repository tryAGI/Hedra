
#nullable enable

namespace Hedra
{
    /// <summary>
    /// Desired aspect ratio for the generated image<br/>
    /// Default Value: 16:9
    /// </summary>
    public enum ImageGenerationRequestBodyAspectRatio
    {
        /// <summary>
        /// 
        /// </summary>
        x1_1,
        /// <summary>
        /// 
        /// </summary>
        x16_9,
        /// <summary>
        /// 
        /// </summary>
        x9_16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ImageGenerationRequestBodyAspectRatioExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenerationRequestBodyAspectRatio value)
        {
            return value switch
            {
                ImageGenerationRequestBodyAspectRatio.x1_1 => "1:1",
                ImageGenerationRequestBodyAspectRatio.x16_9 => "16:9",
                ImageGenerationRequestBodyAspectRatio.x9_16 => "9:16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenerationRequestBodyAspectRatio? ToEnum(string value)
        {
            return value switch
            {
                "1:1" => ImageGenerationRequestBodyAspectRatio.x1_1,
                "16:9" => ImageGenerationRequestBodyAspectRatio.x16_9,
                "9:16" => ImageGenerationRequestBodyAspectRatio.x9_16,
                _ => null,
            };
        }
    }
}