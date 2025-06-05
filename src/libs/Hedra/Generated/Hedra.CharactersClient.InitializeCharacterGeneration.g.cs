
#nullable enable

namespace Hedra
{
    public partial class CharactersClient
    {
        partial void PrepareInitializeCharacterGenerationArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? contentLength,
            global::Hedra.ApiGenerateTalkingAvatarRequestBody request);
        partial void PrepareInitializeCharacterGenerationRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? contentLength,
            global::Hedra.ApiGenerateTalkingAvatarRequestBody request);
        partial void ProcessInitializeCharacterGenerationResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessInitializeCharacterGenerationResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Initialize character generation
        /// </summary>
        /// <param name="contentLength">
        /// Default Value: -1
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Hedra.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Hedra.ApiProjectInitializationResponseBody> InitializeCharacterGenerationAsync(
            global::Hedra.ApiGenerateTalkingAvatarRequestBody request,
            int? contentLength = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareInitializeCharacterGenerationArguments(
                httpClient: HttpClient,
                contentLength: ref contentLength,
                request: request);

            var __pathBuilder = new global::Hedra.PathBuilder(
                path: "/v1/characters",
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

            if (contentLength != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("content-length", contentLength.ToString());
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
            PrepareInitializeCharacterGenerationRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                contentLength: contentLength,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessInitializeCharacterGenerationResponse(
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
                ProcessInitializeCharacterGenerationResponseContent(
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
                    global::Hedra.ApiProjectInitializationResponseBody.FromJson(__content, JsonSerializerContext) ??
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
                    await global::Hedra.ApiProjectInitializationResponseBody.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Initialize character generation
        /// </summary>
        /// <param name="contentLength">
        /// Default Value: -1
        /// </param>
        /// <param name="text">
        /// text to convert to audio. Ignored if audio_source is not tts
        /// </param>
        /// <param name="voiceId">
        /// Voice ID
        /// </param>
        /// <param name="voiceUrl">
        /// URL of audio uploaded using the /v1/audio endpoint
        /// </param>
        /// <param name="avatarImage">
        /// URL of image uploaded via /v1/portrait or base64-encoded image
        /// </param>
        /// <param name="aspectRatio">
        /// Desired aspect ratio for the generated video<br/>
        /// Default Value: 1:1
        /// </param>
        /// <param name="audioSource">
        /// `tts` for text to speech or `audio`<br/>
        /// Default Value: audio
        /// </param>
        /// <param name="avatarImageInput"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Hedra.ApiProjectInitializationResponseBody> InitializeCharacterGenerationAsync(
            int? contentLength = default,
            string? text = default,
            string? voiceId = default,
            string? voiceUrl = default,
            string? avatarImage = default,
            global::Hedra.ApiGenerateTalkingAvatarRequestBodyAspectRatio? aspectRatio = default,
            global::Hedra.ApiGenerateTalkingAvatarRequestBodyAudioSource? audioSource = default,
            global::Hedra.AvatarImageInput? avatarImageInput = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Hedra.ApiGenerateTalkingAvatarRequestBody
            {
                Text = text,
                VoiceId = voiceId,
                VoiceUrl = voiceUrl,
                AvatarImage = avatarImage,
                AspectRatio = aspectRatio,
                AudioSource = audioSource,
                AvatarImageInput = avatarImageInput,
            };

            return await InitializeCharacterGenerationAsync(
                contentLength: contentLength,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}