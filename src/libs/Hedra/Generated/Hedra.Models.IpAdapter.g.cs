
#nullable enable

namespace Hedra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IpAdapter
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("weight")]
        public double? Weight { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IpAdapter" /> class.
        /// </summary>
        /// <param name="imageUrl"></param>
        /// <param name="weight"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IpAdapter(
            string? imageUrl,
            double? weight)
        {
            this.ImageUrl = imageUrl;
            this.Weight = weight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IpAdapter" /> class.
        /// </summary>
        public IpAdapter()
        {
        }
    }
}