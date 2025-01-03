
#nullable enable

namespace Hedra
{
    /// <summary>
    /// Response body for image generation requests
    /// </summary>
    public sealed partial class ImageGenerationResponseBody
    {
        /// <summary>
        /// The generated image files info
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("images")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Hedra.GeneratedImage> Images { get; set; }

        /// <summary>
        /// Timing information for the generation process
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timings")]
        public global::Hedra.Timings? Timings { get; set; }

        /// <summary>
        /// Seed used for generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Whether images contain NSFW concepts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_nsfw_concepts")]
        public global::System.Collections.Generic.IList<bool>? HasNsfwConcepts { get; set; }

        /// <summary>
        /// The prompt used for generating the image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationResponseBody" /> class.
        /// </summary>
        /// <param name="images">
        /// The generated image files info
        /// </param>
        /// <param name="timings">
        /// Timing information for the generation process
        /// </param>
        /// <param name="seed">
        /// Seed used for generation
        /// </param>
        /// <param name="hasNsfwConcepts">
        /// Whether images contain NSFW concepts
        /// </param>
        /// <param name="prompt">
        /// The prompt used for generating the image
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ImageGenerationResponseBody(
            global::System.Collections.Generic.IList<global::Hedra.GeneratedImage> images,
            string prompt,
            global::Hedra.Timings? timings,
            int? seed,
            global::System.Collections.Generic.IList<bool>? hasNsfwConcepts)
        {
            this.Images = images ?? throw new global::System.ArgumentNullException(nameof(images));
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.Timings = timings;
            this.Seed = seed;
            this.HasNsfwConcepts = hasNsfwConcepts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationResponseBody" /> class.
        /// </summary>
        public ImageGenerationResponseBody()
        {
        }
    }
}