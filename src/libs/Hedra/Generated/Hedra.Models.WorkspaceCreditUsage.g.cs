
#nullable enable

namespace Hedra
{
    /// <summary>
    /// Per-workspace credit usage for the current period, from the workspace credit pool.<br/>
    /// All three fields are display credits and stay continuous across the USD<br/>
    /// cutover: for converted pools `available`/`used` are floor views of the<br/>
    /// pool's micro-dollar buckets computed on read, and `allocated` serves the<br/>
    /// frozen credit value, which round-trips exactly (regrants re-denominate<br/>
    /// it at ENG-8818). Pinned by test_display_coherence_usd.py.
    /// </summary>
    public sealed partial class WorkspaceCreditUsage
    {
        /// <summary>
        /// Credits consumed in the current period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("used")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Used { get; set; }

        /// <summary>
        /// Credits allocated to the workspace for the current period.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allocated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Allocated { get; set; }

        /// <summary>
        /// Credits currently available in the pool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("available")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Available { get; set; }

        /// <summary>
        /// Segregated API wallet balance in integer micro-dollars (1e-6 USD). Only present while the API wallet is enabled and funded; spent exclusively by programmatic API usage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_usd_micros")]
        public int? ApiUsdMicros { get; set; }

        /// <summary>
        /// Display-credit view of api_usd_micros (floor at 140 credits/$). Informational; API charges are USD-denominated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_credits")]
        public int? ApiCredits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceCreditUsage" /> class.
        /// </summary>
        /// <param name="used">
        /// Credits consumed in the current period.
        /// </param>
        /// <param name="allocated">
        /// Credits allocated to the workspace for the current period.
        /// </param>
        /// <param name="available">
        /// Credits currently available in the pool.
        /// </param>
        /// <param name="apiUsdMicros">
        /// Segregated API wallet balance in integer micro-dollars (1e-6 USD). Only present while the API wallet is enabled and funded; spent exclusively by programmatic API usage.
        /// </param>
        /// <param name="apiCredits">
        /// Display-credit view of api_usd_micros (floor at 140 credits/$). Informational; API charges are USD-denominated.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkspaceCreditUsage(
            int used,
            int allocated,
            int available,
            int? apiUsdMicros,
            int? apiCredits)
        {
            this.Used = used;
            this.Allocated = allocated;
            this.Available = available;
            this.ApiUsdMicros = apiUsdMicros;
            this.ApiCredits = apiCredits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceCreditUsage" /> class.
        /// </summary>
        public WorkspaceCreditUsage()
        {
        }

    }
}