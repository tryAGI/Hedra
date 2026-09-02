
#nullable enable

namespace Hedra
{
    /// <summary>
    /// Whether enhancement is unavailable, uses the generic contract, or uses a reviewed model-specific guide.<br/>
    /// Default Value: generic
    /// </summary>
    public enum AIModelPromptEnhancementMode
    {
        /// <summary>
        ///
        /// </summary>
        Generic,
        /// <summary>
        ///
        /// </summary>
        ModelSpecific,
        /// <summary>
        ///
        /// </summary>
        Unsupported,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AIModelPromptEnhancementModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AIModelPromptEnhancementMode value)
        {
            return value switch
            {
                AIModelPromptEnhancementMode.Generic => "generic",
                AIModelPromptEnhancementMode.ModelSpecific => "model_specific",
                AIModelPromptEnhancementMode.Unsupported => "unsupported",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AIModelPromptEnhancementMode? ToEnum(string value)
        {
            return value switch
            {
                "generic" => AIModelPromptEnhancementMode.Generic,
                "model_specific" => AIModelPromptEnhancementMode.ModelSpecific,
                "unsupported" => AIModelPromptEnhancementMode.Unsupported,
                _ => null,
            };
        }
    }
}