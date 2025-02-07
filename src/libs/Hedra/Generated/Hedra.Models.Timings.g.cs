
#nullable enable

namespace Hedra
{
    /// <summary>
    /// Timing information for the generation process
    /// </summary>
    public sealed partial class Timings
    {
        /// <summary>
        /// Total time taken for generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Total { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Timings" /> class.
        /// </summary>
        /// <param name="total">
        /// Total time taken for generation
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Timings(
            double total)
        {
            this.Total = total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Timings" /> class.
        /// </summary>
        public Timings()
        {
        }
    }
}