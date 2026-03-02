
#nullable enable

namespace Hedra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UploadedImage
    {
        /// <summary>
        /// Default Value: uploaded_image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Width of the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int Width { get; set; } = default!;

        /// <summary>
        /// Height of the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int Height { get; set; } = default!;

        /// <summary>
        /// URL of the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadedImage" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: uploaded_image
        /// </param>
        /// <param name="width">
        /// Width of the image.
        /// </param>
        /// <param name="height">
        /// Height of the image.
        /// </param>
        /// <param name="url">
        /// URL of the image.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UploadedImage(
            int width,
            int height,
            string url,
            string? type)
        {
            this.Width = width;
            this.Height = height;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadedImage" /> class.
        /// </summary>
        public UploadedImage()
        {
        }
    }
}