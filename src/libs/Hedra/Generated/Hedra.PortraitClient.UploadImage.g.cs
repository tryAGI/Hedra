
#nullable enable

namespace Hedra
{
    public partial class PortraitClient
    {
        partial void PrepareUploadImageArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? aspectRatio,
            ref int? contentLength,
            global::Hedra.BodyApiAccessUploadImageV1PortraitPost request);
        partial void PrepareUploadImageRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? aspectRatio,
            int? contentLength,
            global::Hedra.BodyApiAccessUploadImageV1PortraitPost request);
        partial void ProcessUploadImageResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessUploadImageResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Upload image
        /// </summary>
        /// <param name="aspectRatio">
        /// Default Value: 1:1
        /// </param>
        /// <param name="contentLength">
        /// Default Value: -1
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Hedra.UploadAudioResponseBody> UploadImageAsync(
            global::Hedra.BodyApiAccessUploadImageV1PortraitPost request,
            string? aspectRatio = default,
            int? contentLength = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareUploadImageArguments(
                httpClient: HttpClient,
                aspectRatio: ref aspectRatio,
                contentLength: ref contentLength,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: "/v1/portrait",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("aspect_ratio", aspectRatio) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

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

            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            if (aspectRatio != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{aspectRatio}"),
                    name: "aspect_ratio");
            } 
            if (contentLength != default)
            {
                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{contentLength}"),
                    name: "content-length");
            } 
            __httpRequestContent.Add(
                content: new global::System.Net.Http.ByteArrayContent(request.File ?? global::System.Array.Empty<byte>())
                {
                    Headers =
                    {
                        ContentType = global::System.Net.Http.Headers.MediaTypeHeaderValue.Parse("multipart/form-data"),
                    },
                },
                name: "file",
                fileName: request.Filename ?? string.Empty);
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareUploadImageRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                aspectRatio: aspectRatio,
                contentLength: contentLength,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessUploadImageResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessUploadImageResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::Hedra.UploadAudioResponseBody.FromJson(__content, JsonSerializerContext) ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }

        /// <summary>
        /// Upload image
        /// </summary>
        /// <param name="aspectRatio">
        /// Default Value: 1:1
        /// </param>
        /// <param name="contentLength">
        /// Default Value: -1
        /// </param>
        /// <param name="file"></param>
        /// <param name="filename"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Hedra.UploadAudioResponseBody> UploadImageAsync(
            byte[] file,
            string filename,
            string? aspectRatio = default,
            int? contentLength = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Hedra.BodyApiAccessUploadImageV1PortraitPost
            {
                File = file,
                Filename = filename,
            };

            return await UploadImageAsync(
                aspectRatio: aspectRatio,
                contentLength: contentLength,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}