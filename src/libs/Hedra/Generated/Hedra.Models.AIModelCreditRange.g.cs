
#nullable enable

namespace Hedra
{
    /// <summary>
    /// Min and max credits one generation can cost across the model's resolution/duration menu, computed server-side through the model's own pricing (sentinel durations billed as charged, audio-off discounts included). Null for models priced from a resolved asset (audio-driven, extension) — render the base price_details cost instead.
    /// </summary>
    public sealed partial class AIModelCreditRange
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}