
#nullable enable

namespace Hedra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GeneratedImage
    {
        /// <summary>
        /// Default Value: generated_image
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
        /// Inputs for generating the image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_image_inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Hedra.GeneratedImageInputs GeneratedImageInputs { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratedImage" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: generated_image
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
        /// <param name="generatedImageInputs">
        /// Inputs for generating the image.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GeneratedImage(
            int width,
            int height,
            string url,
            global::Hedra.GeneratedImageInputs generatedImageInputs,
            string? type)
        {
            this.Width = width;
            this.Height = height;
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.GeneratedImageInputs = generatedImageInputs ?? throw new global::System.ArgumentNullException(nameof(generatedImageInputs));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratedImage" /> class.
        /// </summary>
        public GeneratedImage()
        {
        }
    }
}