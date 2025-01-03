#nullable enable

namespace Hedra
{
    public partial interface IHedraClient
    {
        /// <summary>
        /// Generate Image Endpoint<br/>
        /// Generate an image from a text prompt or modify an existing image using advanced parameters.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Hedra.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Hedra.ImageGenerationResponseBody> GenerateImageEndpointAsync(
            global::Hedra.ImageGenerationRequestBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Generate Image Endpoint<br/>
        /// Generate an image from a text prompt or modify an existing image using advanced parameters.
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Hedra.ImageGenerationResponseBody> GenerateImageEndpointAsync(
            string prompt,
            int? numInferenceSteps = default,
            global::System.Collections.Generic.IList<global::Hedra.ControlNet>? controlnets = default,
            global::System.Collections.Generic.IList<global::Hedra.ControlNetUnion>? controlnetUnions = default,
            global::System.Collections.Generic.IList<global::Hedra.IpAdapter>? ipAdapters = default,
            double? guidanceScale = default,
            double? realCfgScale = default,
            int? numImages = default,
            bool? enableSafetyChecker = default,
            double? referenceStrength = default,
            double? referenceEnd = default,
            string? imageUrl = default,
            double? strength = default,
            global::Hedra.ImageGenerationRequestBodyAspectRatio? aspectRatio = default,
            int? seed = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}