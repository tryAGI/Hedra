
#nullable enable

namespace Hedra
{
    public partial class HedraClient
    {
        partial void PrepareGenerateImageEndpointArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Hedra.ImageGenerationRequestBody request);
        partial void PrepareGenerateImageEndpointRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Hedra.ImageGenerationRequestBody request);
        partial void ProcessGenerateImageEndpointResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGenerateImageEndpointResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Generate Image Endpoint<br/>
        /// Generate an image from a text prompt or modify an existing image using advanced parameters.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Hedra.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Hedra.ImageGenerationResponseBody> GenerateImageEndpointAsync(
            global::Hedra.ImageGenerationRequestBody request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareGenerateImageEndpointArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::Hedra.PathBuilder(
                path: "/v1/images/text-to-image",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGenerateImageEndpointRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGenerateImageEndpointResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation Error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::Hedra.HTTPValidationError? __value_422 = null;
                if (ReadResponseAsString)
                {
                    __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                    __value_422 = global::Hedra.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                }
                else
                {
                    var __contentStream_422 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                    __value_422 = await global::Hedra.HTTPValidationError.FromJsonStreamAsync(__contentStream_422, JsonSerializerContext).ConfigureAwait(false);
                }

                throw new global::Hedra.ApiException<global::Hedra.HTTPValidationError>(
                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_422,
                    ResponseObject = __value_422,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessGenerateImageEndpointResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::Hedra.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                return
                    global::Hedra.ImageGenerationResponseBody.FromJson(__content, JsonSerializerContext) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
                {
                    throw new global::Hedra.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }

                using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                return
                    await global::Hedra.ImageGenerationResponseBody.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

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
        public async global::System.Threading.Tasks.Task<global::Hedra.ImageGenerationResponseBody> GenerateImageEndpointAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Hedra.ImageGenerationRequestBody
            {
                Prompt = prompt,
                NumInferenceSteps = numInferenceSteps,
                Controlnets = controlnets,
                ControlnetUnions = controlnetUnions,
                IpAdapters = ipAdapters,
                GuidanceScale = guidanceScale,
                RealCfgScale = realCfgScale,
                NumImages = numImages,
                EnableSafetyChecker = enableSafetyChecker,
                ReferenceStrength = referenceStrength,
                ReferenceEnd = referenceEnd,
                ImageUrl = imageUrl,
                Strength = strength,
                AspectRatio = aspectRatio,
                Seed = seed,
            };

            return await GenerateImageEndpointAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}