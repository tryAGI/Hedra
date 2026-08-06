
#nullable enable

namespace Hedra
{
    /// <summary>
    /// Per-workspace credit usage for the current period, from the workspace<br/>
    /// credit pool. `used`/`allocated`/`available` are display credits; the<br/>
    /// `api_*` fields expose the segregated, USD-denominated API wallet.
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
        /// Lifetime micro-dollars spent from the API wallet (carried across billing periods — the wallet has none). Only present while the API wallet is enabled and funded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_consumed_usd_micros")]
        public int? ApiConsumedUsdMicros { get; set; }

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
        /// <param name="apiConsumedUsdMicros">
        /// Lifetime micro-dollars spent from the API wallet (carried across billing periods — the wallet has none). Only present while the API wallet is enabled and funded.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkspaceCreditUsage(
            int used,
            int allocated,
            int available,
            int? apiUsdMicros,
            int? apiCredits,
            int? apiConsumedUsdMicros)
        {
            this.Used = used;
            this.Allocated = allocated;
            this.Available = available;
            this.ApiUsdMicros = apiUsdMicros;
            this.ApiCredits = apiCredits;
            this.ApiConsumedUsdMicros = apiConsumedUsdMicros;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceCreditUsage" /> class.
        /// </summary>
        public WorkspaceCreditUsage()
        {
        }

    }
}