
#nullable enable

namespace Hedra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GeneratedVideo
    {
        /// <summary>
        /// Default Value: generated_video
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
        public string? Url { get; set; }

        /// <summary>
        /// URL to download the video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("download_url")]
        public string? DownloadUrl { get; set; }

        /// <summary>
        /// URL to stream the video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("streaming_url")]
        public string? StreamingUrl { get; set; }

        /// <summary>
        /// URL of the poster image
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("poster_url")]
        public string? PosterUrl { get; set; }

        /// <summary>
        /// Duration of the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int DurationMs { get; set; } = default!;

        /// <summary>
        /// URL of the preview for animated thumbnails.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preview_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string PreviewUrl { get; set; } = default!;

        /// <summary>
        /// Inputs for generating the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_video_inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Hedra.GeneratedVideoInputs GeneratedVideoInputs { get; set; } = default!;

        /// <summary>
        /// URL of the Image asset used as the start keyframe.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyframe_start")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Hedra.Asset? KeyframeStart { get; set; } = default!;

        /// <summary>
        /// URL of the Image asset used as the end keyframe.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keyframe_end")]
        public global::Hedra.Asset? KeyframeEnd { get; set; }

        /// <summary>
        /// URL of the Audio asset used as the basis for the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audio")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::Hedra.Asset? Audio { get; set; } = default!;

        /// <summary>
        /// The id(s) of the audio(s) referenced in the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_audio_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ReferenceAudioIds { get; set; }

        /// <summary>
        /// The id(s) of the image(s) referenced in the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_image_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ReferenceImageIds { get; set; }

        /// <summary>
        /// The id(s) of the video(s) referenced in the generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reference_video_ids")]
        public global::System.Collections.Generic.IList<global::System.Guid>? ReferenceVideoIds { get; set; }

        /// <summary>
        /// The id of the Video asset used as source input for motion control/video-to-video generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_video_id")]
        public global::System.Guid? SourceVideoId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratedVideo" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: generated_video
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
        /// <param name="downloadUrl">
        /// URL to download the video
        /// </param>
        /// <param name="streamingUrl">
        /// URL to stream the video
        /// </param>
        /// <param name="posterUrl">
        /// URL of the poster image
        /// </param>
        /// <param name="durationMs">
        /// Duration of the video.
        /// </param>
        /// <param name="previewUrl">
        /// URL of the preview for animated thumbnails.
        /// </param>
        /// <param name="generatedVideoInputs">
        /// Inputs for generating the video.
        /// </param>
        /// <param name="keyframeStart">
        /// URL of the Image asset used as the start keyframe.
        /// </param>
        /// <param name="keyframeEnd">
        /// URL of the Image asset used as the end keyframe.
        /// </param>
        /// <param name="audio">
        /// URL of the Audio asset used as the basis for the video.
        /// </param>
        /// <param name="referenceAudioIds">
        /// The id(s) of the audio(s) referenced in the generation.
        /// </param>
        /// <param name="referenceImageIds">
        /// The id(s) of the image(s) referenced in the generation.
        /// </param>
        /// <param name="referenceVideoIds">
        /// The id(s) of the video(s) referenced in the generation.
        /// </param>
        /// <param name="sourceVideoId">
        /// The id of the Video asset used as source input for motion control/video-to-video generation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GeneratedVideo(
            int width,
            int height,
            int durationMs,
            string previewUrl,
            global::Hedra.GeneratedVideoInputs generatedVideoInputs,
            global::Hedra.Asset? keyframeStart,
            global::Hedra.Asset? audio,
            string? type,
            string? url,
            string? downloadUrl,
            string? streamingUrl,
            string? posterUrl,
            global::Hedra.Asset? keyframeEnd,
            global::System.Collections.Generic.IList<global::System.Guid>? referenceAudioIds,
            global::System.Collections.Generic.IList<global::System.Guid>? referenceImageIds,
            global::System.Collections.Generic.IList<global::System.Guid>? referenceVideoIds,
            global::System.Guid? sourceVideoId)
        {
            this.Width = width;
            this.Height = height;
            this.DurationMs = durationMs;
            this.PreviewUrl = previewUrl ?? throw new global::System.ArgumentNullException(nameof(previewUrl));
            this.GeneratedVideoInputs = generatedVideoInputs ?? throw new global::System.ArgumentNullException(nameof(generatedVideoInputs));
            this.KeyframeStart = keyframeStart ?? throw new global::System.ArgumentNullException(nameof(keyframeStart));
            this.Audio = audio ?? throw new global::System.ArgumentNullException(nameof(audio));
            this.Type = type;
            this.Url = url;
            this.DownloadUrl = downloadUrl;
            this.StreamingUrl = streamingUrl;
            this.PosterUrl = posterUrl;
            this.KeyframeEnd = keyframeEnd;
            this.ReferenceAudioIds = referenceAudioIds;
            this.ReferenceImageIds = referenceImageIds;
            this.ReferenceVideoIds = referenceVideoIds;
            this.SourceVideoId = sourceVideoId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratedVideo" /> class.
        /// </summary>
        public GeneratedVideo()
        {
        }
    }
}