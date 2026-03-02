
#nullable enable

namespace Hedra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PagedResponseGeneration
    {
        /// <summary>
        /// Paging information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_info")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Hedra.PageInfo PageInfo { get; set; } = default!;

        /// <summary>
        /// Page data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::Hedra.Generation> Data { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PagedResponseGeneration" /> class.
        /// </summary>
        /// <param name="pageInfo">
        /// Paging information.
        /// </param>
        /// <param name="data">
        /// Page data.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PagedResponseGeneration(
            global::Hedra.PageInfo pageInfo,
            global::System.Collections.Generic.IList<global::Hedra.Generation> data)
        {
            this.PageInfo = pageInfo ?? throw new global::System.ArgumentNullException(nameof(pageInfo));
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PagedResponseGeneration" /> class.
        /// </summary>
        public PagedResponseGeneration()
        {
        }
    }
}