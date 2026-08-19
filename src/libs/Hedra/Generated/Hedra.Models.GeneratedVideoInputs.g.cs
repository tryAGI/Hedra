
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Hedra
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GeneratedVideoInputs
    {
        /// <summary>
        /// Prompt for video generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TextPrompt { get; set; }

        /// <summary>
        /// Deprecated. Use `model_slug` to identify the model used for generation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ai_model_id")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Guid? AiModelId { get; set; }

        /// <summary>
        /// The slug of the model used for generation. Alternative to `ai_model_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_slug")]
        public string? ModelSlug { get; set; }

        /// <summary>
        /// Resolution for the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolution")]
        public string? Resolution { get; set; }

        /// <summary>
        /// Aspect ratio for the video.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aspect_ratio")]
        public string? AspectRatio { get; set; }

        /// <summary>
        /// Duration of the video in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        public int? DurationMs { get; set; }

        /// <summary>
        /// Whether to generate native audio, for models with an audio toggle. None preserves the legacy default (audio on); an explicit false is forwarded to the provider and charges the model's audio-off price.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generate_audio")]
        public bool? GenerateAudio { get; set; }

        /// <summary>
        /// Seed for reproducible output, for models whose provider accepts one. None leaves the argument out of the provider request entirely, so the provider's own random-seed behavior applies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// What to avoid in the generated video, for models whose provider accepts it. None leaves the argument out of the provider request entirely, so the provider's own default applies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative_prompt")]
        public string? NegativePrompt { get; set; }

        /// <summary>
        /// Normalized coordinates for speaker position(s). A single point for single-speaker; a list for multi-speaker (one per speaker, same length as audio_id list).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bounding_box_target")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Hedra.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>, object>))]
        public global::Hedra.AnyOf<global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>, object>? BoundingBoxTarget { get; set; }

        /// <summary>
        /// For motion control models: 'video' matches reference video orientation (better for complex motions, max 30s), 'image' preserves character image orientation (better for camera movements, max 10s).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("character_orientation")]
        public global::Hedra.GeneratedVideoInputsCharacterOrientation2? CharacterOrientation { get; set; }

        /// <summary>
        /// If true, automatically enhance the prompt before generation.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enhance_prompt")]
        public bool? EnhancePrompt { get; set; }

        /// <summary>
        /// List of shots for multi-shot video generation. When provided, text_prompt is ignored and total duration is the sum of shot durations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("multi_prompt")]
        public global::System.Collections.Generic.IList<global::Hedra.VideoShot>? MultiPrompt { get; set; }

        /// <summary>
        /// Shot type for multi-shot generation: 'customize' uses each shot's declared duration, 'intelligent' lets the model determine the shot structure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shot_type")]
        public global::Hedra.GeneratedVideoInputsShotType2? ShotType { get; set; }

        /// <summary>
        /// How closely the model follows the prompt, for models whose provider accepts it. None leaves the argument out of the provider request entirely, so the provider's own default applies. Per-model bounds are published on each model's input schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cfg_scale")]
        public double? CfgScale { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratedVideoInputs" /> class.
        /// </summary>
        /// <param name="textPrompt">
        /// Prompt for video generation.
        /// </param>
        /// <param name="modelSlug">
        /// The slug of the model used for generation. Alternative to `ai_model_id`.
        /// </param>
        /// <param name="resolution">
        /// Resolution for the video.
        /// </param>
        /// <param name="aspectRatio">
        /// Aspect ratio for the video.
        /// </param>
        /// <param name="durationMs">
        /// Duration of the video in milliseconds.
        /// </param>
        /// <param name="generateAudio">
        /// Whether to generate native audio, for models with an audio toggle. None preserves the legacy default (audio on); an explicit false is forwarded to the provider and charges the model's audio-off price.
        /// </param>
        /// <param name="seed">
        /// Seed for reproducible output, for models whose provider accepts one. None leaves the argument out of the provider request entirely, so the provider's own random-seed behavior applies.
        /// </param>
        /// <param name="negativePrompt">
        /// What to avoid in the generated video, for models whose provider accepts it. None leaves the argument out of the provider request entirely, so the provider's own default applies.
        /// </param>
        /// <param name="boundingBoxTarget">
        /// Normalized coordinates for speaker position(s). A single point for single-speaker; a list for multi-speaker (one per speaker, same length as audio_id list).
        /// </param>
        /// <param name="characterOrientation">
        /// For motion control models: 'video' matches reference video orientation (better for complex motions, max 30s), 'image' preserves character image orientation (better for camera movements, max 10s).
        /// </param>
        /// <param name="enhancePrompt">
        /// If true, automatically enhance the prompt before generation.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="multiPrompt">
        /// List of shots for multi-shot video generation. When provided, text_prompt is ignored and total duration is the sum of shot durations.
        /// </param>
        /// <param name="shotType">
        /// Shot type for multi-shot generation: 'customize' uses each shot's declared duration, 'intelligent' lets the model determine the shot structure.
        /// </param>
        /// <param name="cfgScale">
        /// How closely the model follows the prompt, for models whose provider accepts it. None leaves the argument out of the provider request entirely, so the provider's own default applies. Per-model bounds are published on each model's input schema.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GeneratedVideoInputs(
            string textPrompt,
            string? modelSlug,
            string? resolution,
            string? aspectRatio,
            int? durationMs,
            bool? generateAudio,
            int? seed,
            string? negativePrompt,
            global::Hedra.AnyOf<global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>, object>? boundingBoxTarget,
            global::Hedra.GeneratedVideoInputsCharacterOrientation2? characterOrientation,
            bool? enhancePrompt,
            global::System.Collections.Generic.IList<global::Hedra.VideoShot>? multiPrompt,
            global::Hedra.GeneratedVideoInputsShotType2? shotType,
            double? cfgScale)
        {
            this.TextPrompt = textPrompt ?? throw new global::System.ArgumentNullException(nameof(textPrompt));
            this.ModelSlug = modelSlug;
            this.Resolution = resolution;
            this.AspectRatio = aspectRatio;
            this.DurationMs = durationMs;
            this.GenerateAudio = generateAudio;
            this.Seed = seed;
            this.NegativePrompt = negativePrompt;
            this.BoundingBoxTarget = boundingBoxTarget;
            this.CharacterOrientation = characterOrientation;
            this.EnhancePrompt = enhancePrompt;
            this.MultiPrompt = multiPrompt;
            this.ShotType = shotType;
            this.CfgScale = cfgScale;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratedVideoInputs" /> class.
        /// </summary>
        public GeneratedVideoInputs()
        {
        }

    }
}