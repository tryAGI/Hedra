
#nullable enable

namespace Hedra
{
    /// <summary>
    /// Per-workspace credit usage for the current period, from the workspace credit pool.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkspaceCreditUsage(
            int used,
            int allocated,
            int available)
        {
            this.Used = used;
            this.Allocated = allocated;
            this.Available = available;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceCreditUsage" /> class.
        /// </summary>
        public WorkspaceCreditUsage()
        {
        }

    }
}