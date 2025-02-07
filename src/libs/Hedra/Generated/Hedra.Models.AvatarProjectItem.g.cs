
#nullable enable

namespace Hedra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AvatarProjectItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createdAt")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("videoUrl")]
        public string? VideoUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatarImageUrl")]
        public string? AvatarImageUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspectRatio")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Hedra.JsonConverters.AvatarProjectItemAspectRatioJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Hedra.AvatarProjectItemAspectRatio AspectRatio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceId")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("voiceUrl")]
        public string? VoiceUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public string? UserId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobType")]
        public string? JobType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Hedra.JsonConverters.AvatarProjectStatusJsonConverter))]
        public global::Hedra.AvatarProjectStatus? Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stage")]
        public string? Stage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("progress")]
        public double? Progress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errorMessage")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("audioSource")]
        public string? AudioSource { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("avatarImageInput")]
        public object? AvatarImageInput { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shared")]
        public bool? Shared { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AvatarProjectItem" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="createdAt"></param>
        /// <param name="username"></param>
        /// <param name="videoUrl"></param>
        /// <param name="avatarImageUrl"></param>
        /// <param name="aspectRatio"></param>
        /// <param name="text"></param>
        /// <param name="voiceId"></param>
        /// <param name="voiceUrl"></param>
        /// <param name="userId"></param>
        /// <param name="jobType"></param>
        /// <param name="status"></param>
        /// <param name="stage"></param>
        /// <param name="progress"></param>
        /// <param name="errorMessage"></param>
        /// <param name="audioSource"></param>
        /// <param name="avatarImageInput"></param>
        /// <param name="shared">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AvatarProjectItem(
            global::Hedra.AvatarProjectItemAspectRatio aspectRatio,
            string? id,
            global::System.DateTime? createdAt,
            string? username,
            string? videoUrl,
            string? avatarImageUrl,
            string? text,
            string? voiceId,
            string? voiceUrl,
            string? userId,
            string? jobType,
            global::Hedra.AvatarProjectStatus? status,
            string? stage,
            double? progress,
            string? errorMessage,
            string? audioSource,
            object? avatarImageInput,
            bool? shared)
        {
            this.AspectRatio = aspectRatio;
            this.Id = id;
            this.CreatedAt = createdAt;
            this.Username = username;
            this.VideoUrl = videoUrl;
            this.AvatarImageUrl = avatarImageUrl;
            this.Text = text;
            this.VoiceId = voiceId;
            this.VoiceUrl = voiceUrl;
            this.UserId = userId;
            this.JobType = jobType;
            this.Status = status;
            this.Stage = stage;
            this.Progress = progress;
            this.ErrorMessage = errorMessage;
            this.AudioSource = audioSource;
            this.AvatarImageInput = avatarImageInput;
            this.Shared = shared;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AvatarProjectItem" /> class.
        /// </summary>
        public AvatarProjectItem()
        {
        }
    }
}