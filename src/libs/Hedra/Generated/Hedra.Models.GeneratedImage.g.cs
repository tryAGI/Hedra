
#nullable enable

namespace Hedra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GeneratedImage
    {
        /// <summary>
        /// URL of the generated image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Content type of the image<br/>
        /// Default Value: image/jpeg
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_type")]
        public string? ContentType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratedImage" /> class.
        /// </summary>
        /// <param name="url">
        /// URL of the generated image
        /// </param>
        /// <param name="contentType">
        /// Content type of the image<br/>
        /// Default Value: image/jpeg
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public GeneratedImage(
            string url,
            string? contentType)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.ContentType = contentType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratedImage" /> class.
        /// </summary>
        public GeneratedImage()
        {
        }
    }
}