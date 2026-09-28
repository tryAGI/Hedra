#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Hedra
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct GenerateAssetPublicGenerationsPostRequest : global::System.IEquatable<GenerateAssetPublicGenerationsPostRequest>
    {
        /// <summary>
        ///
        /// </summary>
        public global::Hedra.GenerateAssetPublicGenerationsPostRequestDiscriminatorType? Type { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateVideoRequest? Video { get; init; }
#else
        public global::Hedra.GenerateVideoRequest? Video { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Video))]
#endif
        public bool IsVideo => Video != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickVideo(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Hedra.GenerateVideoRequest? value)
        {
            value = Video;
            return IsVideo;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Hedra.GenerateVideoRequest PickVideo() => Video is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Video' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateTextToSpeechRequest? TextToSpeech { get; init; }
#else
        public global::Hedra.GenerateTextToSpeechRequest? TextToSpeech { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextToSpeech))]
#endif
        public bool IsTextToSpeech => TextToSpeech != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTextToSpeech(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Hedra.GenerateTextToSpeechRequest? value)
        {
            value = TextToSpeech;
            return IsTextToSpeech;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Hedra.GenerateTextToSpeechRequest PickTextToSpeech() => TextToSpeech is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextToSpeech' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateTextToSoundRequest? TextToSound { get; init; }
#else
        public global::Hedra.GenerateTextToSoundRequest? TextToSound { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextToSound))]
#endif
        public bool IsTextToSound => TextToSound != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTextToSound(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Hedra.GenerateTextToSoundRequest? value)
        {
            value = TextToSound;
            return IsTextToSound;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Hedra.GenerateTextToSoundRequest PickTextToSound() => TextToSound is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextToSound' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateTextToMusicRequest? TextToMusic { get; init; }
#else
        public global::Hedra.GenerateTextToMusicRequest? TextToMusic { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextToMusic))]
#endif
        public bool IsTextToMusic => TextToMusic != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickTextToMusic(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Hedra.GenerateTextToMusicRequest? value)
        {
            value = TextToMusic;
            return IsTextToMusic;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Hedra.GenerateTextToMusicRequest PickTextToMusic() => TextToMusic is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextToMusic' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateImageRequest? Image { get; init; }
#else
        public global::Hedra.GenerateImageRequest? Image { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Image))]
#endif
        public bool IsImage => Image != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickImage(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Hedra.GenerateImageRequest? value)
        {
            value = Image;
            return IsImage;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Hedra.GenerateImageRequest PickImage() => Image is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Image' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateImageUpscaleRequest? ImageUpscale { get; init; }
#else
        public global::Hedra.GenerateImageUpscaleRequest? ImageUpscale { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ImageUpscale))]
#endif
        public bool IsImageUpscale => ImageUpscale != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickImageUpscale(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Hedra.GenerateImageUpscaleRequest? value)
        {
            value = ImageUpscale;
            return IsImageUpscale;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Hedra.GenerateImageUpscaleRequest PickImageUpscale() => ImageUpscale is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageUpscale' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateVideoUpscaleRequest? VideoUpscale { get; init; }
#else
        public global::Hedra.GenerateVideoUpscaleRequest? VideoUpscale { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VideoUpscale))]
#endif
        public bool IsVideoUpscale => VideoUpscale != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickVideoUpscale(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Hedra.GenerateVideoUpscaleRequest? value)
        {
            value = VideoUpscale;
            return IsVideoUpscale;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Hedra.GenerateVideoUpscaleRequest PickVideoUpscale() => VideoUpscale is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'VideoUpscale' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateIsolatedAudioRequest? AudioIsolation { get; init; }
#else
        public global::Hedra.GenerateIsolatedAudioRequest? AudioIsolation { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioIsolation))]
#endif
        public bool IsAudioIsolation => AudioIsolation != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickAudioIsolation(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Hedra.GenerateIsolatedAudioRequest? value)
        {
            value = AudioIsolation;
            return IsAudioIsolation;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Hedra.GenerateIsolatedAudioRequest PickAudioIsolation() => AudioIsolation is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'AudioIsolation' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateSpeechToSpeechRequest? SpeechToSpeech { get; init; }
#else
        public global::Hedra.GenerateSpeechToSpeechRequest? SpeechToSpeech { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpeechToSpeech))]
#endif
        public bool IsSpeechToSpeech => SpeechToSpeech != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickSpeechToSpeech(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Hedra.GenerateSpeechToSpeechRequest? value)
        {
            value = SpeechToSpeech;
            return IsSpeechToSpeech;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Hedra.GenerateSpeechToSpeechRequest PickSpeechToSpeech() => SpeechToSpeech is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'SpeechToSpeech' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateVoiceCloneRequest? VoiceClone { get; init; }
#else
        public global::Hedra.GenerateVoiceCloneRequest? VoiceClone { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VoiceClone))]
#endif
        public bool IsVoiceClone => VoiceClone != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickVoiceClone(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Hedra.GenerateVoiceCloneRequest? value)
        {
            value = VoiceClone;
            return IsVoiceClone;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Hedra.GenerateVoiceCloneRequest PickVoiceClone() => VoiceClone is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'VoiceClone' but the value was {ToString()}.");

        /// <summary>
        /// Video-to-video edit request for Kling O1 Edit model.<br/>
        /// Transforms videos using natural language while preserving motion.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateVideoToVideoRequest? VideoToVideo { get; init; }
#else
        public global::Hedra.GenerateVideoToVideoRequest? VideoToVideo { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VideoToVideo))]
#endif
        public bool IsVideoToVideo => VideoToVideo != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickVideoToVideo(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Hedra.GenerateVideoToVideoRequest? value)
        {
            value = VideoToVideo;
            return IsVideoToVideo;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Hedra.GenerateVideoToVideoRequest PickVideoToVideo() => VideoToVideo is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'VideoToVideo' but the value was {ToString()}.");

        /// <summary>
        /// Remove a source video's background and return transparent video.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateVideoBackgroundRemovalRequest? VideoBackgroundRemoval { get; init; }
#else
        public global::Hedra.GenerateVideoBackgroundRemovalRequest? VideoBackgroundRemoval { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VideoBackgroundRemoval))]
#endif
        public bool IsVideoBackgroundRemoval => VideoBackgroundRemoval != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickVideoBackgroundRemoval(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Hedra.GenerateVideoBackgroundRemovalRequest? value)
        {
            value = VideoBackgroundRemoval;
            return IsVideoBackgroundRemoval;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Hedra.GenerateVideoBackgroundRemovalRequest PickVideoBackgroundRemoval() => VideoBackgroundRemoval is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'VideoBackgroundRemoval' but the value was {ToString()}.");

        /// <summary>
        /// Motion Control request for transferring motion from a reference video to a character image.<br/>
        /// Processed through V2V infrastructure internally.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateMotionControlRequest? MotionControl { get; init; }
#else
        public global::Hedra.GenerateMotionControlRequest? MotionControl { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MotionControl))]
#endif
        public bool IsMotionControl => MotionControl != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickMotionControl(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Hedra.GenerateMotionControlRequest? value)
        {
            value = MotionControl;
            return IsMotionControl;
        }

        /// <summary>
        ///
        /// </summary>
        public global::Hedra.GenerateMotionControlRequest PickMotionControl() => MotionControl is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'MotionControl' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator GenerateAssetPublicGenerationsPostRequest(global::Hedra.GenerateVideoRequest value) => new GenerateAssetPublicGenerationsPostRequest((global::Hedra.GenerateVideoRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Hedra.GenerateVideoRequest?(GenerateAssetPublicGenerationsPostRequest @this) => @this.Video;

        /// <summary>
        ///
        /// </summary>
        public GenerateAssetPublicGenerationsPostRequest(global::Hedra.GenerateVideoRequest? value)
        {
            Video = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GenerateAssetPublicGenerationsPostRequest FromVideo(global::Hedra.GenerateVideoRequest? value) => new GenerateAssetPublicGenerationsPostRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GenerateAssetPublicGenerationsPostRequest(global::Hedra.GenerateTextToSpeechRequest value) => new GenerateAssetPublicGenerationsPostRequest((global::Hedra.GenerateTextToSpeechRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Hedra.GenerateTextToSpeechRequest?(GenerateAssetPublicGenerationsPostRequest @this) => @this.TextToSpeech;

        /// <summary>
        ///
        /// </summary>
        public GenerateAssetPublicGenerationsPostRequest(global::Hedra.GenerateTextToSpeechRequest? value)
        {
            TextToSpeech = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GenerateAssetPublicGenerationsPostRequest FromTextToSpeech(global::Hedra.GenerateTextToSpeechRequest? value) => new GenerateAssetPublicGenerationsPostRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GenerateAssetPublicGenerationsPostRequest(global::Hedra.GenerateTextToSoundRequest value) => new GenerateAssetPublicGenerationsPostRequest((global::Hedra.GenerateTextToSoundRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Hedra.GenerateTextToSoundRequest?(GenerateAssetPublicGenerationsPostRequest @this) => @this.TextToSound;

        /// <summary>
        ///
        /// </summary>
        public GenerateAssetPublicGenerationsPostRequest(global::Hedra.GenerateTextToSoundRequest? value)
        {
            TextToSound = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GenerateAssetPublicGenerationsPostRequest FromTextToSound(global::Hedra.GenerateTextToSoundRequest? value) => new GenerateAssetPublicGenerationsPostRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GenerateAssetPublicGenerationsPostRequest(global::Hedra.GenerateTextToMusicRequest value) => new GenerateAssetPublicGenerationsPostRequest((global::Hedra.GenerateTextToMusicRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Hedra.GenerateTextToMusicRequest?(GenerateAssetPublicGenerationsPostRequest @this) => @this.TextToMusic;

        /// <summary>
        ///
        /// </summary>
        public GenerateAssetPublicGenerationsPostRequest(global::Hedra.GenerateTextToMusicRequest? value)
        {
            TextToMusic = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GenerateAssetPublicGenerationsPostRequest FromTextToMusic(global::Hedra.GenerateTextToMusicRequest? value) => new GenerateAssetPublicGenerationsPostRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GenerateAssetPublicGenerationsPostRequest(global::Hedra.GenerateImageRequest value) => new GenerateAssetPublicGenerationsPostRequest((global::Hedra.GenerateImageRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Hedra.GenerateImageRequest?(GenerateAssetPublicGenerationsPostRequest @this) => @this.Image;

        /// <summary>
        ///
        /// </summary>
        public GenerateAssetPublicGenerationsPostRequest(global::Hedra.GenerateImageRequest? value)
        {
            Image = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GenerateAssetPublicGenerationsPostRequest FromImage(global::Hedra.GenerateImageRequest? value) => new GenerateAssetPublicGenerationsPostRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GenerateAssetPublicGenerationsPostRequest(global::Hedra.GenerateImageUpscaleRequest value) => new GenerateAssetPublicGenerationsPostRequest((global::Hedra.GenerateImageUpscaleRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Hedra.GenerateImageUpscaleRequest?(GenerateAssetPublicGenerationsPostRequest @this) => @this.ImageUpscale;

        /// <summary>
        ///
        /// </summary>
        public GenerateAssetPublicGenerationsPostRequest(global::Hedra.GenerateImageUpscaleRequest? value)
        {
            ImageUpscale = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GenerateAssetPublicGenerationsPostRequest FromImageUpscale(global::Hedra.GenerateImageUpscaleRequest? value) => new GenerateAssetPublicGenerationsPostRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GenerateAssetPublicGenerationsPostRequest(global::Hedra.GenerateVideoUpscaleRequest value) => new GenerateAssetPublicGenerationsPostRequest((global::Hedra.GenerateVideoUpscaleRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Hedra.GenerateVideoUpscaleRequest?(GenerateAssetPublicGenerationsPostRequest @this) => @this.VideoUpscale;

        /// <summary>
        ///
        /// </summary>
        public GenerateAssetPublicGenerationsPostRequest(global::Hedra.GenerateVideoUpscaleRequest? value)
        {
            VideoUpscale = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GenerateAssetPublicGenerationsPostRequest FromVideoUpscale(global::Hedra.GenerateVideoUpscaleRequest? value) => new GenerateAssetPublicGenerationsPostRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GenerateAssetPublicGenerationsPostRequest(global::Hedra.GenerateIsolatedAudioRequest value) => new GenerateAssetPublicGenerationsPostRequest((global::Hedra.GenerateIsolatedAudioRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Hedra.GenerateIsolatedAudioRequest?(GenerateAssetPublicGenerationsPostRequest @this) => @this.AudioIsolation;

        /// <summary>
        ///
        /// </summary>
        public GenerateAssetPublicGenerationsPostRequest(global::Hedra.GenerateIsolatedAudioRequest? value)
        {
            AudioIsolation = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GenerateAssetPublicGenerationsPostRequest FromAudioIsolation(global::Hedra.GenerateIsolatedAudioRequest? value) => new GenerateAssetPublicGenerationsPostRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GenerateAssetPublicGenerationsPostRequest(global::Hedra.GenerateSpeechToSpeechRequest value) => new GenerateAssetPublicGenerationsPostRequest((global::Hedra.GenerateSpeechToSpeechRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Hedra.GenerateSpeechToSpeechRequest?(GenerateAssetPublicGenerationsPostRequest @this) => @this.SpeechToSpeech;

        /// <summary>
        ///
        /// </summary>
        public GenerateAssetPublicGenerationsPostRequest(global::Hedra.GenerateSpeechToSpeechRequest? value)
        {
            SpeechToSpeech = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GenerateAssetPublicGenerationsPostRequest FromSpeechToSpeech(global::Hedra.GenerateSpeechToSpeechRequest? value) => new GenerateAssetPublicGenerationsPostRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GenerateAssetPublicGenerationsPostRequest(global::Hedra.GenerateVoiceCloneRequest value) => new GenerateAssetPublicGenerationsPostRequest((global::Hedra.GenerateVoiceCloneRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Hedra.GenerateVoiceCloneRequest?(GenerateAssetPublicGenerationsPostRequest @this) => @this.VoiceClone;

        /// <summary>
        ///
        /// </summary>
        public GenerateAssetPublicGenerationsPostRequest(global::Hedra.GenerateVoiceCloneRequest? value)
        {
            VoiceClone = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GenerateAssetPublicGenerationsPostRequest FromVoiceClone(global::Hedra.GenerateVoiceCloneRequest? value) => new GenerateAssetPublicGenerationsPostRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GenerateAssetPublicGenerationsPostRequest(global::Hedra.GenerateVideoToVideoRequest value) => new GenerateAssetPublicGenerationsPostRequest((global::Hedra.GenerateVideoToVideoRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Hedra.GenerateVideoToVideoRequest?(GenerateAssetPublicGenerationsPostRequest @this) => @this.VideoToVideo;

        /// <summary>
        ///
        /// </summary>
        public GenerateAssetPublicGenerationsPostRequest(global::Hedra.GenerateVideoToVideoRequest? value)
        {
            VideoToVideo = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GenerateAssetPublicGenerationsPostRequest FromVideoToVideo(global::Hedra.GenerateVideoToVideoRequest? value) => new GenerateAssetPublicGenerationsPostRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GenerateAssetPublicGenerationsPostRequest(global::Hedra.GenerateVideoBackgroundRemovalRequest value) => new GenerateAssetPublicGenerationsPostRequest((global::Hedra.GenerateVideoBackgroundRemovalRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Hedra.GenerateVideoBackgroundRemovalRequest?(GenerateAssetPublicGenerationsPostRequest @this) => @this.VideoBackgroundRemoval;

        /// <summary>
        ///
        /// </summary>
        public GenerateAssetPublicGenerationsPostRequest(global::Hedra.GenerateVideoBackgroundRemovalRequest? value)
        {
            VideoBackgroundRemoval = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GenerateAssetPublicGenerationsPostRequest FromVideoBackgroundRemoval(global::Hedra.GenerateVideoBackgroundRemovalRequest? value) => new GenerateAssetPublicGenerationsPostRequest(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator GenerateAssetPublicGenerationsPostRequest(global::Hedra.GenerateMotionControlRequest value) => new GenerateAssetPublicGenerationsPostRequest((global::Hedra.GenerateMotionControlRequest?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::Hedra.GenerateMotionControlRequest?(GenerateAssetPublicGenerationsPostRequest @this) => @this.MotionControl;

        /// <summary>
        ///
        /// </summary>
        public GenerateAssetPublicGenerationsPostRequest(global::Hedra.GenerateMotionControlRequest? value)
        {
            MotionControl = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static GenerateAssetPublicGenerationsPostRequest FromMotionControl(global::Hedra.GenerateMotionControlRequest? value) => new GenerateAssetPublicGenerationsPostRequest(value);

        /// <summary>
        ///
        /// </summary>
        public GenerateAssetPublicGenerationsPostRequest(
            global::Hedra.GenerateAssetPublicGenerationsPostRequestDiscriminatorType? type,
            global::Hedra.GenerateVideoRequest? video,
            global::Hedra.GenerateTextToSpeechRequest? textToSpeech,
            global::Hedra.GenerateTextToSoundRequest? textToSound,
            global::Hedra.GenerateTextToMusicRequest? textToMusic,
            global::Hedra.GenerateImageRequest? image,
            global::Hedra.GenerateImageUpscaleRequest? imageUpscale,
            global::Hedra.GenerateVideoUpscaleRequest? videoUpscale,
            global::Hedra.GenerateIsolatedAudioRequest? audioIsolation,
            global::Hedra.GenerateSpeechToSpeechRequest? speechToSpeech,
            global::Hedra.GenerateVoiceCloneRequest? voiceClone,
            global::Hedra.GenerateVideoToVideoRequest? videoToVideo,
            global::Hedra.GenerateVideoBackgroundRemovalRequest? videoBackgroundRemoval,
            global::Hedra.GenerateMotionControlRequest? motionControl
            )
        {
            Type = type;

            Video = video;
            TextToSpeech = textToSpeech;
            TextToSound = textToSound;
            TextToMusic = textToMusic;
            Image = image;
            ImageUpscale = imageUpscale;
            VideoUpscale = videoUpscale;
            AudioIsolation = audioIsolation;
            SpeechToSpeech = speechToSpeech;
            VoiceClone = voiceClone;
            VideoToVideo = videoToVideo;
            VideoBackgroundRemoval = videoBackgroundRemoval;
            MotionControl = motionControl;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            MotionControl as object ??
            VideoBackgroundRemoval as object ??
            VideoToVideo as object ??
            VoiceClone as object ??
            SpeechToSpeech as object ??
            AudioIsolation as object ??
            VideoUpscale as object ??
            ImageUpscale as object ??
            Image as object ??
            TextToMusic as object ??
            TextToSound as object ??
            TextToSpeech as object ??
            Video as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Video?.ToString() ??
            TextToSpeech?.ToString() ??
            TextToSound?.ToString() ??
            TextToMusic?.ToString() ??
            Image?.ToString() ??
            ImageUpscale?.ToString() ??
            VideoUpscale?.ToString() ??
            AudioIsolation?.ToString() ??
            SpeechToSpeech?.ToString() ??
            VoiceClone?.ToString() ??
            VideoToVideo?.ToString() ??
            VideoBackgroundRemoval?.ToString() ??
            MotionControl?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsVideo && !IsTextToSpeech && !IsTextToSound && !IsTextToMusic && !IsImage && !IsImageUpscale && !IsVideoUpscale && !IsAudioIsolation && !IsSpeechToSpeech && !IsVoiceClone && !IsVideoToVideo && !IsVideoBackgroundRemoval && !IsMotionControl || !IsVideo && IsTextToSpeech && !IsTextToSound && !IsTextToMusic && !IsImage && !IsImageUpscale && !IsVideoUpscale && !IsAudioIsolation && !IsSpeechToSpeech && !IsVoiceClone && !IsVideoToVideo && !IsVideoBackgroundRemoval && !IsMotionControl || !IsVideo && !IsTextToSpeech && IsTextToSound && !IsTextToMusic && !IsImage && !IsImageUpscale && !IsVideoUpscale && !IsAudioIsolation && !IsSpeechToSpeech && !IsVoiceClone && !IsVideoToVideo && !IsVideoBackgroundRemoval && !IsMotionControl || !IsVideo && !IsTextToSpeech && !IsTextToSound && IsTextToMusic && !IsImage && !IsImageUpscale && !IsVideoUpscale && !IsAudioIsolation && !IsSpeechToSpeech && !IsVoiceClone && !IsVideoToVideo && !IsVideoBackgroundRemoval && !IsMotionControl || !IsVideo && !IsTextToSpeech && !IsTextToSound && !IsTextToMusic && IsImage && !IsImageUpscale && !IsVideoUpscale && !IsAudioIsolation && !IsSpeechToSpeech && !IsVoiceClone && !IsVideoToVideo && !IsVideoBackgroundRemoval && !IsMotionControl || !IsVideo && !IsTextToSpeech && !IsTextToSound && !IsTextToMusic && !IsImage && IsImageUpscale && !IsVideoUpscale && !IsAudioIsolation && !IsSpeechToSpeech && !IsVoiceClone && !IsVideoToVideo && !IsVideoBackgroundRemoval && !IsMotionControl || !IsVideo && !IsTextToSpeech && !IsTextToSound && !IsTextToMusic && !IsImage && !IsImageUpscale && IsVideoUpscale && !IsAudioIsolation && !IsSpeechToSpeech && !IsVoiceClone && !IsVideoToVideo && !IsVideoBackgroundRemoval && !IsMotionControl || !IsVideo && !IsTextToSpeech && !IsTextToSound && !IsTextToMusic && !IsImage && !IsImageUpscale && !IsVideoUpscale && IsAudioIsolation && !IsSpeechToSpeech && !IsVoiceClone && !IsVideoToVideo && !IsVideoBackgroundRemoval && !IsMotionControl || !IsVideo && !IsTextToSpeech && !IsTextToSound && !IsTextToMusic && !IsImage && !IsImageUpscale && !IsVideoUpscale && !IsAudioIsolation && IsSpeechToSpeech && !IsVoiceClone && !IsVideoToVideo && !IsVideoBackgroundRemoval && !IsMotionControl || !IsVideo && !IsTextToSpeech && !IsTextToSound && !IsTextToMusic && !IsImage && !IsImageUpscale && !IsVideoUpscale && !IsAudioIsolation && !IsSpeechToSpeech && IsVoiceClone && !IsVideoToVideo && !IsVideoBackgroundRemoval && !IsMotionControl || !IsVideo && !IsTextToSpeech && !IsTextToSound && !IsTextToMusic && !IsImage && !IsImageUpscale && !IsVideoUpscale && !IsAudioIsolation && !IsSpeechToSpeech && !IsVoiceClone && IsVideoToVideo && !IsVideoBackgroundRemoval && !IsMotionControl || !IsVideo && !IsTextToSpeech && !IsTextToSound && !IsTextToMusic && !IsImage && !IsImageUpscale && !IsVideoUpscale && !IsAudioIsolation && !IsSpeechToSpeech && !IsVoiceClone && !IsVideoToVideo && IsVideoBackgroundRemoval && !IsMotionControl || !IsVideo && !IsTextToSpeech && !IsTextToSound && !IsTextToMusic && !IsImage && !IsImageUpscale && !IsVideoUpscale && !IsAudioIsolation && !IsSpeechToSpeech && !IsVoiceClone && !IsVideoToVideo && !IsVideoBackgroundRemoval && IsMotionControl;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Hedra.GenerateVideoRequest, TResult>? video = null,
            global::System.Func<global::Hedra.GenerateTextToSpeechRequest, TResult>? textToSpeech = null,
            global::System.Func<global::Hedra.GenerateTextToSoundRequest, TResult>? textToSound = null,
            global::System.Func<global::Hedra.GenerateTextToMusicRequest, TResult>? textToMusic = null,
            global::System.Func<global::Hedra.GenerateImageRequest, TResult>? image = null,
            global::System.Func<global::Hedra.GenerateImageUpscaleRequest, TResult>? imageUpscale = null,
            global::System.Func<global::Hedra.GenerateVideoUpscaleRequest, TResult>? videoUpscale = null,
            global::System.Func<global::Hedra.GenerateIsolatedAudioRequest, TResult>? audioIsolation = null,
            global::System.Func<global::Hedra.GenerateSpeechToSpeechRequest, TResult>? speechToSpeech = null,
            global::System.Func<global::Hedra.GenerateVoiceCloneRequest, TResult>? voiceClone = null,
            global::System.Func<global::Hedra.GenerateVideoToVideoRequest, TResult>? videoToVideo = null,
            global::System.Func<global::Hedra.GenerateVideoBackgroundRemovalRequest, TResult>? videoBackgroundRemoval = null,
            global::System.Func<global::Hedra.GenerateMotionControlRequest, TResult>? motionControl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Video is { } __value0 && video != null)
            {
                return video(__value0);
            }
            else if (TextToSpeech is { } __value1 && textToSpeech != null)
            {
                return textToSpeech(__value1);
            }
            else if (TextToSound is { } __value2 && textToSound != null)
            {
                return textToSound(__value2);
            }
            else if (TextToMusic is { } __value3 && textToMusic != null)
            {
                return textToMusic(__value3);
            }
            else if (Image is { } __value4 && image != null)
            {
                return image(__value4);
            }
            else if (ImageUpscale is { } __value5 && imageUpscale != null)
            {
                return imageUpscale(__value5);
            }
            else if (VideoUpscale is { } __value6 && videoUpscale != null)
            {
                return videoUpscale(__value6);
            }
            else if (AudioIsolation is { } __value7 && audioIsolation != null)
            {
                return audioIsolation(__value7);
            }
            else if (SpeechToSpeech is { } __value8 && speechToSpeech != null)
            {
                return speechToSpeech(__value8);
            }
            else if (VoiceClone is { } __value9 && voiceClone != null)
            {
                return voiceClone(__value9);
            }
            else if (VideoToVideo is { } __value10 && videoToVideo != null)
            {
                return videoToVideo(__value10);
            }
            else if (VideoBackgroundRemoval is { } __value11 && videoBackgroundRemoval != null)
            {
                return videoBackgroundRemoval(__value11);
            }
            else if (MotionControl is { } __value12 && motionControl != null)
            {
                return motionControl(__value12);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::Hedra.GenerateVideoRequest>? video = null,

            global::System.Action<global::Hedra.GenerateTextToSpeechRequest>? textToSpeech = null,

            global::System.Action<global::Hedra.GenerateTextToSoundRequest>? textToSound = null,

            global::System.Action<global::Hedra.GenerateTextToMusicRequest>? textToMusic = null,

            global::System.Action<global::Hedra.GenerateImageRequest>? image = null,

            global::System.Action<global::Hedra.GenerateImageUpscaleRequest>? imageUpscale = null,

            global::System.Action<global::Hedra.GenerateVideoUpscaleRequest>? videoUpscale = null,

            global::System.Action<global::Hedra.GenerateIsolatedAudioRequest>? audioIsolation = null,

            global::System.Action<global::Hedra.GenerateSpeechToSpeechRequest>? speechToSpeech = null,

            global::System.Action<global::Hedra.GenerateVoiceCloneRequest>? voiceClone = null,

            global::System.Action<global::Hedra.GenerateVideoToVideoRequest>? videoToVideo = null,

            global::System.Action<global::Hedra.GenerateVideoBackgroundRemovalRequest>? videoBackgroundRemoval = null,

            global::System.Action<global::Hedra.GenerateMotionControlRequest>? motionControl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Video is { } __value0)
            {
                video?.Invoke(__value0);
            }
            else if (TextToSpeech is { } __value1)
            {
                textToSpeech?.Invoke(__value1);
            }
            else if (TextToSound is { } __value2)
            {
                textToSound?.Invoke(__value2);
            }
            else if (TextToMusic is { } __value3)
            {
                textToMusic?.Invoke(__value3);
            }
            else if (Image is { } __value4)
            {
                image?.Invoke(__value4);
            }
            else if (ImageUpscale is { } __value5)
            {
                imageUpscale?.Invoke(__value5);
            }
            else if (VideoUpscale is { } __value6)
            {
                videoUpscale?.Invoke(__value6);
            }
            else if (AudioIsolation is { } __value7)
            {
                audioIsolation?.Invoke(__value7);
            }
            else if (SpeechToSpeech is { } __value8)
            {
                speechToSpeech?.Invoke(__value8);
            }
            else if (VoiceClone is { } __value9)
            {
                voiceClone?.Invoke(__value9);
            }
            else if (VideoToVideo is { } __value10)
            {
                videoToVideo?.Invoke(__value10);
            }
            else if (VideoBackgroundRemoval is { } __value11)
            {
                videoBackgroundRemoval?.Invoke(__value11);
            }
            else if (MotionControl is { } __value12)
            {
                motionControl?.Invoke(__value12);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::Hedra.GenerateVideoRequest>? video = null,
            global::System.Action<global::Hedra.GenerateTextToSpeechRequest>? textToSpeech = null,
            global::System.Action<global::Hedra.GenerateTextToSoundRequest>? textToSound = null,
            global::System.Action<global::Hedra.GenerateTextToMusicRequest>? textToMusic = null,
            global::System.Action<global::Hedra.GenerateImageRequest>? image = null,
            global::System.Action<global::Hedra.GenerateImageUpscaleRequest>? imageUpscale = null,
            global::System.Action<global::Hedra.GenerateVideoUpscaleRequest>? videoUpscale = null,
            global::System.Action<global::Hedra.GenerateIsolatedAudioRequest>? audioIsolation = null,
            global::System.Action<global::Hedra.GenerateSpeechToSpeechRequest>? speechToSpeech = null,
            global::System.Action<global::Hedra.GenerateVoiceCloneRequest>? voiceClone = null,
            global::System.Action<global::Hedra.GenerateVideoToVideoRequest>? videoToVideo = null,
            global::System.Action<global::Hedra.GenerateVideoBackgroundRemovalRequest>? videoBackgroundRemoval = null,
            global::System.Action<global::Hedra.GenerateMotionControlRequest>? motionControl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Video is { } __value0)
            {
                video?.Invoke(__value0);
            }
            else if (TextToSpeech is { } __value1)
            {
                textToSpeech?.Invoke(__value1);
            }
            else if (TextToSound is { } __value2)
            {
                textToSound?.Invoke(__value2);
            }
            else if (TextToMusic is { } __value3)
            {
                textToMusic?.Invoke(__value3);
            }
            else if (Image is { } __value4)
            {
                image?.Invoke(__value4);
            }
            else if (ImageUpscale is { } __value5)
            {
                imageUpscale?.Invoke(__value5);
            }
            else if (VideoUpscale is { } __value6)
            {
                videoUpscale?.Invoke(__value6);
            }
            else if (AudioIsolation is { } __value7)
            {
                audioIsolation?.Invoke(__value7);
            }
            else if (SpeechToSpeech is { } __value8)
            {
                speechToSpeech?.Invoke(__value8);
            }
            else if (VoiceClone is { } __value9)
            {
                voiceClone?.Invoke(__value9);
            }
            else if (VideoToVideo is { } __value10)
            {
                videoToVideo?.Invoke(__value10);
            }
            else if (VideoBackgroundRemoval is { } __value11)
            {
                videoBackgroundRemoval?.Invoke(__value11);
            }
            else if (MotionControl is { } __value12)
            {
                motionControl?.Invoke(__value12);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Video,
                typeof(global::Hedra.GenerateVideoRequest),
                TextToSpeech,
                typeof(global::Hedra.GenerateTextToSpeechRequest),
                TextToSound,
                typeof(global::Hedra.GenerateTextToSoundRequest),
                TextToMusic,
                typeof(global::Hedra.GenerateTextToMusicRequest),
                Image,
                typeof(global::Hedra.GenerateImageRequest),
                ImageUpscale,
                typeof(global::Hedra.GenerateImageUpscaleRequest),
                VideoUpscale,
                typeof(global::Hedra.GenerateVideoUpscaleRequest),
                AudioIsolation,
                typeof(global::Hedra.GenerateIsolatedAudioRequest),
                SpeechToSpeech,
                typeof(global::Hedra.GenerateSpeechToSpeechRequest),
                VoiceClone,
                typeof(global::Hedra.GenerateVoiceCloneRequest),
                VideoToVideo,
                typeof(global::Hedra.GenerateVideoToVideoRequest),
                VideoBackgroundRemoval,
                typeof(global::Hedra.GenerateVideoBackgroundRemovalRequest),
                MotionControl,
                typeof(global::Hedra.GenerateMotionControlRequest),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        ///
        /// </summary>
        public bool Equals(GenerateAssetPublicGenerationsPostRequest other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateVideoRequest?>.Default.Equals(Video, other.Video) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateTextToSpeechRequest?>.Default.Equals(TextToSpeech, other.TextToSpeech) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateTextToSoundRequest?>.Default.Equals(TextToSound, other.TextToSound) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateTextToMusicRequest?>.Default.Equals(TextToMusic, other.TextToMusic) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateImageRequest?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateImageUpscaleRequest?>.Default.Equals(ImageUpscale, other.ImageUpscale) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateVideoUpscaleRequest?>.Default.Equals(VideoUpscale, other.VideoUpscale) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateIsolatedAudioRequest?>.Default.Equals(AudioIsolation, other.AudioIsolation) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateSpeechToSpeechRequest?>.Default.Equals(SpeechToSpeech, other.SpeechToSpeech) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateVoiceCloneRequest?>.Default.Equals(VoiceClone, other.VoiceClone) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateVideoToVideoRequest?>.Default.Equals(VideoToVideo, other.VideoToVideo) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateVideoBackgroundRemovalRequest?>.Default.Equals(VideoBackgroundRemoval, other.VideoBackgroundRemoval) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateMotionControlRequest?>.Default.Equals(MotionControl, other.MotionControl)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(GenerateAssetPublicGenerationsPostRequest obj1, GenerateAssetPublicGenerationsPostRequest obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GenerateAssetPublicGenerationsPostRequest>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(GenerateAssetPublicGenerationsPostRequest obj1, GenerateAssetPublicGenerationsPostRequest obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GenerateAssetPublicGenerationsPostRequest o && Equals(o);
        }
    }
}
