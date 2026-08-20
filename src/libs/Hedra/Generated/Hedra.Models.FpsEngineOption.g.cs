
#nullable enable

namespace Hedra
{
    /// <summary>
    /// One published frame-interpolation engine (see `AIModel.fps_engines`).
    /// </summary>
    public sealed partial class FpsEngineOption
    {
        /// <summary>
        /// Wire name; the `fps_engine` request value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Factor applied to the whole upscale charge when this engine is selected; the default engine is 1.0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price_multiplier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PriceMultiplier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FpsEngineOption" /> class.
        /// </summary>
        /// <param name="name">
        /// Wire name; the `fps_engine` request value.
        /// </param>
        /// <param name="priceMultiplier">
        /// Factor applied to the whole upscale charge when this engine is selected; the default engine is 1.0.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public FpsEngineOption(
            string name,
            double priceMultiplier)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PriceMultiplier = priceMultiplier;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FpsEngineOption" /> class.
        /// </summary>
        public FpsEngineOption()
        {
        }

    }
}