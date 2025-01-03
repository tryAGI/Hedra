
#nullable enable

namespace Hedra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ImageGenerationRequestBody
    {
        /// <summary>
        /// The prompt to generate the image from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Number of inference steps
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_inference_steps")]
        public int? NumInferenceSteps { get; set; }

        /// <summary>
        /// List of ControlNet configurations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("controlnets")]
        public global::System.Collections.Generic.IList<global::Hedra.ControlNet>? Controlnets { get; set; }

        /// <summary>
        /// List of ControlNet union configurations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("controlnet_unions")]
        public global::System.Collections.Generic.IList<global::Hedra.ControlNetUnion>? ControlnetUnions { get; set; }

        /// <summary>
        /// List of IP-Adapter configurations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ip_adapters")]
        public global::System.Collections.Generic.IList<global::Hedra.IpAdapter>? IpAdapters { get; set; }

        /// <summary>
        /// Guidance scale for the generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("guidance_scale")]
        public double? GuidanceScale { get; set; }

        /// <summary>
        /// Real CFG scale
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("real_cfg_scale")]
        public double? RealCfgScale { get; set; }

        /// <summary>
        /// Number of images to generate
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("num_images")]
        public int? NumImages { get; set; }

        /// <summary>
        /// Whether to enable safety checker
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_safety_checker")]
        public bool? EnableSafetyChecker { get; set; }

        /// <summary>
        /// Reference strength
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_strength")]
        public double? ReferenceStrength { get; set; }

        /// <summary>
        /// Reference end
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_end")]
        public double? ReferenceEnd { get; set; }

        /// <summary>
        /// Optional source image URL for image-to-image generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_url")]
        public string? ImageUrl { get; set; }

        /// <summary>
        /// Strength of the conditioning
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strength")]
        public double? Strength { get; set; }

        /// <summary>
        /// Desired aspect ratio for the generated image<br/>
        /// Default Value: 16:9
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Hedra.JsonConverters.ImageGenerationRequestBodyAspectRatioJsonConverter))]
        public global::Hedra.ImageGenerationRequestBodyAspectRatio? AspectRatio { get; set; }

        /// <summary>
        /// Seed for the generation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationRequestBody" /> class.
        /// </summary>
        /// <param name="prompt">
        /// The prompt to generate the image from
        /// </param>
        /// <param name="numInferenceSteps">
        /// Number of inference steps
        /// </param>
        /// <param name="controlnets">
        /// List of ControlNet configurations
        /// </param>
        /// <param name="controlnetUnions">
        /// List of ControlNet union configurations
        /// </param>
        /// <param name="ipAdapters">
        /// List of IP-Adapter configurations
        /// </param>
        /// <param name="guidanceScale">
        /// Guidance scale for the generation
        /// </param>
        /// <param name="realCfgScale">
        /// Real CFG scale
        /// </param>
        /// <param name="numImages">
        /// Number of images to generate
        /// </param>
        /// <param name="enableSafetyChecker">
        /// Whether to enable safety checker
        /// </param>
        /// <param name="referenceStrength">
        /// Reference strength
        /// </param>
        /// <param name="referenceEnd">
        /// Reference end
        /// </param>
        /// <param name="imageUrl">
        /// Optional source image URL for image-to-image generation
        /// </param>
        /// <param name="strength">
        /// Strength of the conditioning
        /// </param>
        /// <param name="aspectRatio">
        /// Desired aspect ratio for the generated image<br/>
        /// Default Value: 16:9
        /// </param>
        /// <param name="seed">
        /// Seed for the generation
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ImageGenerationRequestBody(
            string prompt,
            int? numInferenceSteps,
            global::System.Collections.Generic.IList<global::Hedra.ControlNet>? controlnets,
            global::System.Collections.Generic.IList<global::Hedra.ControlNetUnion>? controlnetUnions,
            global::System.Collections.Generic.IList<global::Hedra.IpAdapter>? ipAdapters,
            double? guidanceScale,
            double? realCfgScale,
            int? numImages,
            bool? enableSafetyChecker,
            double? referenceStrength,
            double? referenceEnd,
            string? imageUrl,
            double? strength,
            global::Hedra.ImageGenerationRequestBodyAspectRatio? aspectRatio,
            int? seed)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.NumInferenceSteps = numInferenceSteps;
            this.Controlnets = controlnets;
            this.ControlnetUnions = controlnetUnions;
            this.IpAdapters = ipAdapters;
            this.GuidanceScale = guidanceScale;
            this.RealCfgScale = realCfgScale;
            this.NumImages = numImages;
            this.EnableSafetyChecker = enableSafetyChecker;
            this.ReferenceStrength = referenceStrength;
            this.ReferenceEnd = referenceEnd;
            this.ImageUrl = imageUrl;
            this.Strength = strength;
            this.AspectRatio = aspectRatio;
            this.Seed = seed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImageGenerationRequestBody" /> class.
        /// </summary>
        public ImageGenerationRequestBody()
        {
        }
    }
}