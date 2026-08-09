
#nullable enable

namespace Hedra
{
    /// <summary>
    /// Ordered `slug`s of models to suggest when the user switches away after a failed generation (moderation/capacity rejection). Slug is the stable catalog identity to match on; the legacy `id` is nullable and absent on newer models, so it cannot address them. Only models present and not disabled in this build are listed. Null when the model declares no alternatives.
    /// </summary>
    public sealed partial class AIModelAlternativeModelSlugs
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}