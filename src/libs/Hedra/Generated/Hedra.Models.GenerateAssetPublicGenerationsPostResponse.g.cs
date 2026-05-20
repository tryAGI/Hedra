#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Hedra
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct GenerateAssetPublicGenerationsPostResponse : global::System.IEquatable<GenerateAssetPublicGenerationsPostResponse>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Hedra.GenerateAssetPublicGenerationsPostResponseDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateVideoResponse? Video { get; init; }
#else
        public global::Hedra.GenerateVideoResponse? Video { get; }
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
            out global::Hedra.GenerateVideoResponse? value)
        {
            value = Video;
            return IsVideo;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Hedra.GenerateVideoResponse PickVideo() => IsVideo
            ? Video!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Video' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateTextToSpeechResponse? TextToSpeech { get; init; }
#else
        public global::Hedra.GenerateTextToSpeechResponse? TextToSpeech { get; }
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
            out global::Hedra.GenerateTextToSpeechResponse? value)
        {
            value = TextToSpeech;
            return IsTextToSpeech;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Hedra.GenerateTextToSpeechResponse PickTextToSpeech() => IsTextToSpeech
            ? TextToSpeech!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextToSpeech' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateTextToSoundResponse? TextToSound { get; init; }
#else
        public global::Hedra.GenerateTextToSoundResponse? TextToSound { get; }
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
            out global::Hedra.GenerateTextToSoundResponse? value)
        {
            value = TextToSound;
            return IsTextToSound;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Hedra.GenerateTextToSoundResponse PickTextToSound() => IsTextToSound
            ? TextToSound!
            : throw new global::System.InvalidOperationException($"Expected union variant 'TextToSound' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateImageResponse? Image { get; init; }
#else
        public global::Hedra.GenerateImageResponse? Image { get; }
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
            out global::Hedra.GenerateImageResponse? value)
        {
            value = Image;
            return IsImage;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Hedra.GenerateImageResponse PickImage() => IsImage
            ? Image!
            : throw new global::System.InvalidOperationException($"Expected union variant 'Image' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateImageUpscaleResponse? ImageUpscale { get; init; }
#else
        public global::Hedra.GenerateImageUpscaleResponse? ImageUpscale { get; }
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
            out global::Hedra.GenerateImageUpscaleResponse? value)
        {
            value = ImageUpscale;
            return IsImageUpscale;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Hedra.GenerateImageUpscaleResponse PickImageUpscale() => IsImageUpscale
            ? ImageUpscale!
            : throw new global::System.InvalidOperationException($"Expected union variant 'ImageUpscale' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateVideoUpscaleResponse? VideoUpscale { get; init; }
#else
        public global::Hedra.GenerateVideoUpscaleResponse? VideoUpscale { get; }
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
            out global::Hedra.GenerateVideoUpscaleResponse? value)
        {
            value = VideoUpscale;
            return IsVideoUpscale;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Hedra.GenerateVideoUpscaleResponse PickVideoUpscale() => IsVideoUpscale
            ? VideoUpscale!
            : throw new global::System.InvalidOperationException($"Expected union variant 'VideoUpscale' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateIsolatedAudioResponse? AudioIsolation { get; init; }
#else
        public global::Hedra.GenerateIsolatedAudioResponse? AudioIsolation { get; }
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
            out global::Hedra.GenerateIsolatedAudioResponse? value)
        {
            value = AudioIsolation;
            return IsAudioIsolation;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Hedra.GenerateIsolatedAudioResponse PickAudioIsolation() => IsAudioIsolation
            ? AudioIsolation!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AudioIsolation' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateSpeechToSpeechResponse? SpeechToSpeech { get; init; }
#else
        public global::Hedra.GenerateSpeechToSpeechResponse? SpeechToSpeech { get; }
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
            out global::Hedra.GenerateSpeechToSpeechResponse? value)
        {
            value = SpeechToSpeech;
            return IsSpeechToSpeech;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Hedra.GenerateSpeechToSpeechResponse PickSpeechToSpeech() => IsSpeechToSpeech
            ? SpeechToSpeech!
            : throw new global::System.InvalidOperationException($"Expected union variant 'SpeechToSpeech' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateVoiceCloneResponse? VoiceClone { get; init; }
#else
        public global::Hedra.GenerateVoiceCloneResponse? VoiceClone { get; }
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
            out global::Hedra.GenerateVoiceCloneResponse? value)
        {
            value = VoiceClone;
            return IsVoiceClone;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Hedra.GenerateVoiceCloneResponse PickVoiceClone() => IsVoiceClone
            ? VoiceClone!
            : throw new global::System.InvalidOperationException($"Expected union variant 'VoiceClone' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateAudioFromVideoResponse? AudioFromVideo { get; init; }
#else
        public global::Hedra.GenerateAudioFromVideoResponse? AudioFromVideo { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioFromVideo))]
#endif
        public bool IsAudioFromVideo => AudioFromVideo != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickAudioFromVideo(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Hedra.GenerateAudioFromVideoResponse? value)
        {
            value = AudioFromVideo;
            return IsAudioFromVideo;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Hedra.GenerateAudioFromVideoResponse PickAudioFromVideo() => IsAudioFromVideo
            ? AudioFromVideo!
            : throw new global::System.InvalidOperationException($"Expected union variant 'AudioFromVideo' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateVideoWithAudioResponse? VideoWithAudio { get; init; }
#else
        public global::Hedra.GenerateVideoWithAudioResponse? VideoWithAudio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VideoWithAudio))]
#endif
        public bool IsVideoWithAudio => VideoWithAudio != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickVideoWithAudio(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Hedra.GenerateVideoWithAudioResponse? value)
        {
            value = VideoWithAudio;
            return IsVideoWithAudio;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Hedra.GenerateVideoWithAudioResponse PickVideoWithAudio() => IsVideoWithAudio
            ? VideoWithAudio!
            : throw new global::System.InvalidOperationException($"Expected union variant 'VideoWithAudio' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateVideoToVideoResponse? VideoToVideo { get; init; }
#else
        public global::Hedra.GenerateVideoToVideoResponse? VideoToVideo { get; }
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
            out global::Hedra.GenerateVideoToVideoResponse? value)
        {
            value = VideoToVideo;
            return IsVideoToVideo;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Hedra.GenerateVideoToVideoResponse PickVideoToVideo() => IsVideoToVideo
            ? VideoToVideo!
            : throw new global::System.InvalidOperationException($"Expected union variant 'VideoToVideo' but the value was {ToString()}.");

        /// <summary>
        /// Response for Motion Control generations.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateMotionControlResponse? MotionControl { get; init; }
#else
        public global::Hedra.GenerateMotionControlResponse? MotionControl { get; }
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
            out global::Hedra.GenerateMotionControlResponse? value)
        {
            value = MotionControl;
            return IsMotionControl;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Hedra.GenerateMotionControlResponse PickMotionControl() => IsMotionControl
            ? MotionControl!
            : throw new global::System.InvalidOperationException($"Expected union variant 'MotionControl' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateAssetPublicGenerationsPostResponse(global::Hedra.GenerateVideoResponse value) => new GenerateAssetPublicGenerationsPostResponse((global::Hedra.GenerateVideoResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateVideoResponse?(GenerateAssetPublicGenerationsPostResponse @this) => @this.Video;

        /// <summary>
        /// 
        /// </summary>
        public GenerateAssetPublicGenerationsPostResponse(global::Hedra.GenerateVideoResponse? value)
        {
            Video = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GenerateAssetPublicGenerationsPostResponse FromVideo(global::Hedra.GenerateVideoResponse? value) => new GenerateAssetPublicGenerationsPostResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateAssetPublicGenerationsPostResponse(global::Hedra.GenerateTextToSpeechResponse value) => new GenerateAssetPublicGenerationsPostResponse((global::Hedra.GenerateTextToSpeechResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateTextToSpeechResponse?(GenerateAssetPublicGenerationsPostResponse @this) => @this.TextToSpeech;

        /// <summary>
        /// 
        /// </summary>
        public GenerateAssetPublicGenerationsPostResponse(global::Hedra.GenerateTextToSpeechResponse? value)
        {
            TextToSpeech = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GenerateAssetPublicGenerationsPostResponse FromTextToSpeech(global::Hedra.GenerateTextToSpeechResponse? value) => new GenerateAssetPublicGenerationsPostResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateAssetPublicGenerationsPostResponse(global::Hedra.GenerateTextToSoundResponse value) => new GenerateAssetPublicGenerationsPostResponse((global::Hedra.GenerateTextToSoundResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateTextToSoundResponse?(GenerateAssetPublicGenerationsPostResponse @this) => @this.TextToSound;

        /// <summary>
        /// 
        /// </summary>
        public GenerateAssetPublicGenerationsPostResponse(global::Hedra.GenerateTextToSoundResponse? value)
        {
            TextToSound = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GenerateAssetPublicGenerationsPostResponse FromTextToSound(global::Hedra.GenerateTextToSoundResponse? value) => new GenerateAssetPublicGenerationsPostResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateAssetPublicGenerationsPostResponse(global::Hedra.GenerateImageResponse value) => new GenerateAssetPublicGenerationsPostResponse((global::Hedra.GenerateImageResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateImageResponse?(GenerateAssetPublicGenerationsPostResponse @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public GenerateAssetPublicGenerationsPostResponse(global::Hedra.GenerateImageResponse? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GenerateAssetPublicGenerationsPostResponse FromImage(global::Hedra.GenerateImageResponse? value) => new GenerateAssetPublicGenerationsPostResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateAssetPublicGenerationsPostResponse(global::Hedra.GenerateImageUpscaleResponse value) => new GenerateAssetPublicGenerationsPostResponse((global::Hedra.GenerateImageUpscaleResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateImageUpscaleResponse?(GenerateAssetPublicGenerationsPostResponse @this) => @this.ImageUpscale;

        /// <summary>
        /// 
        /// </summary>
        public GenerateAssetPublicGenerationsPostResponse(global::Hedra.GenerateImageUpscaleResponse? value)
        {
            ImageUpscale = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GenerateAssetPublicGenerationsPostResponse FromImageUpscale(global::Hedra.GenerateImageUpscaleResponse? value) => new GenerateAssetPublicGenerationsPostResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateAssetPublicGenerationsPostResponse(global::Hedra.GenerateVideoUpscaleResponse value) => new GenerateAssetPublicGenerationsPostResponse((global::Hedra.GenerateVideoUpscaleResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateVideoUpscaleResponse?(GenerateAssetPublicGenerationsPostResponse @this) => @this.VideoUpscale;

        /// <summary>
        /// 
        /// </summary>
        public GenerateAssetPublicGenerationsPostResponse(global::Hedra.GenerateVideoUpscaleResponse? value)
        {
            VideoUpscale = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GenerateAssetPublicGenerationsPostResponse FromVideoUpscale(global::Hedra.GenerateVideoUpscaleResponse? value) => new GenerateAssetPublicGenerationsPostResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateAssetPublicGenerationsPostResponse(global::Hedra.GenerateIsolatedAudioResponse value) => new GenerateAssetPublicGenerationsPostResponse((global::Hedra.GenerateIsolatedAudioResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateIsolatedAudioResponse?(GenerateAssetPublicGenerationsPostResponse @this) => @this.AudioIsolation;

        /// <summary>
        /// 
        /// </summary>
        public GenerateAssetPublicGenerationsPostResponse(global::Hedra.GenerateIsolatedAudioResponse? value)
        {
            AudioIsolation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GenerateAssetPublicGenerationsPostResponse FromAudioIsolation(global::Hedra.GenerateIsolatedAudioResponse? value) => new GenerateAssetPublicGenerationsPostResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateAssetPublicGenerationsPostResponse(global::Hedra.GenerateSpeechToSpeechResponse value) => new GenerateAssetPublicGenerationsPostResponse((global::Hedra.GenerateSpeechToSpeechResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateSpeechToSpeechResponse?(GenerateAssetPublicGenerationsPostResponse @this) => @this.SpeechToSpeech;

        /// <summary>
        /// 
        /// </summary>
        public GenerateAssetPublicGenerationsPostResponse(global::Hedra.GenerateSpeechToSpeechResponse? value)
        {
            SpeechToSpeech = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GenerateAssetPublicGenerationsPostResponse FromSpeechToSpeech(global::Hedra.GenerateSpeechToSpeechResponse? value) => new GenerateAssetPublicGenerationsPostResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateAssetPublicGenerationsPostResponse(global::Hedra.GenerateVoiceCloneResponse value) => new GenerateAssetPublicGenerationsPostResponse((global::Hedra.GenerateVoiceCloneResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateVoiceCloneResponse?(GenerateAssetPublicGenerationsPostResponse @this) => @this.VoiceClone;

        /// <summary>
        /// 
        /// </summary>
        public GenerateAssetPublicGenerationsPostResponse(global::Hedra.GenerateVoiceCloneResponse? value)
        {
            VoiceClone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GenerateAssetPublicGenerationsPostResponse FromVoiceClone(global::Hedra.GenerateVoiceCloneResponse? value) => new GenerateAssetPublicGenerationsPostResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateAssetPublicGenerationsPostResponse(global::Hedra.GenerateAudioFromVideoResponse value) => new GenerateAssetPublicGenerationsPostResponse((global::Hedra.GenerateAudioFromVideoResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateAudioFromVideoResponse?(GenerateAssetPublicGenerationsPostResponse @this) => @this.AudioFromVideo;

        /// <summary>
        /// 
        /// </summary>
        public GenerateAssetPublicGenerationsPostResponse(global::Hedra.GenerateAudioFromVideoResponse? value)
        {
            AudioFromVideo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GenerateAssetPublicGenerationsPostResponse FromAudioFromVideo(global::Hedra.GenerateAudioFromVideoResponse? value) => new GenerateAssetPublicGenerationsPostResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateAssetPublicGenerationsPostResponse(global::Hedra.GenerateVideoWithAudioResponse value) => new GenerateAssetPublicGenerationsPostResponse((global::Hedra.GenerateVideoWithAudioResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateVideoWithAudioResponse?(GenerateAssetPublicGenerationsPostResponse @this) => @this.VideoWithAudio;

        /// <summary>
        /// 
        /// </summary>
        public GenerateAssetPublicGenerationsPostResponse(global::Hedra.GenerateVideoWithAudioResponse? value)
        {
            VideoWithAudio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GenerateAssetPublicGenerationsPostResponse FromVideoWithAudio(global::Hedra.GenerateVideoWithAudioResponse? value) => new GenerateAssetPublicGenerationsPostResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateAssetPublicGenerationsPostResponse(global::Hedra.GenerateVideoToVideoResponse value) => new GenerateAssetPublicGenerationsPostResponse((global::Hedra.GenerateVideoToVideoResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateVideoToVideoResponse?(GenerateAssetPublicGenerationsPostResponse @this) => @this.VideoToVideo;

        /// <summary>
        /// 
        /// </summary>
        public GenerateAssetPublicGenerationsPostResponse(global::Hedra.GenerateVideoToVideoResponse? value)
        {
            VideoToVideo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GenerateAssetPublicGenerationsPostResponse FromVideoToVideo(global::Hedra.GenerateVideoToVideoResponse? value) => new GenerateAssetPublicGenerationsPostResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateAssetPublicGenerationsPostResponse(global::Hedra.GenerateMotionControlResponse value) => new GenerateAssetPublicGenerationsPostResponse((global::Hedra.GenerateMotionControlResponse?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateMotionControlResponse?(GenerateAssetPublicGenerationsPostResponse @this) => @this.MotionControl;

        /// <summary>
        /// 
        /// </summary>
        public GenerateAssetPublicGenerationsPostResponse(global::Hedra.GenerateMotionControlResponse? value)
        {
            MotionControl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static GenerateAssetPublicGenerationsPostResponse FromMotionControl(global::Hedra.GenerateMotionControlResponse? value) => new GenerateAssetPublicGenerationsPostResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public GenerateAssetPublicGenerationsPostResponse(
            global::Hedra.GenerateAssetPublicGenerationsPostResponseDiscriminatorType? type,
            global::Hedra.GenerateVideoResponse? video,
            global::Hedra.GenerateTextToSpeechResponse? textToSpeech,
            global::Hedra.GenerateTextToSoundResponse? textToSound,
            global::Hedra.GenerateImageResponse? image,
            global::Hedra.GenerateImageUpscaleResponse? imageUpscale,
            global::Hedra.GenerateVideoUpscaleResponse? videoUpscale,
            global::Hedra.GenerateIsolatedAudioResponse? audioIsolation,
            global::Hedra.GenerateSpeechToSpeechResponse? speechToSpeech,
            global::Hedra.GenerateVoiceCloneResponse? voiceClone,
            global::Hedra.GenerateAudioFromVideoResponse? audioFromVideo,
            global::Hedra.GenerateVideoWithAudioResponse? videoWithAudio,
            global::Hedra.GenerateVideoToVideoResponse? videoToVideo,
            global::Hedra.GenerateMotionControlResponse? motionControl
            )
        {
            Type = type;

            Video = video;
            TextToSpeech = textToSpeech;
            TextToSound = textToSound;
            Image = image;
            ImageUpscale = imageUpscale;
            VideoUpscale = videoUpscale;
            AudioIsolation = audioIsolation;
            SpeechToSpeech = speechToSpeech;
            VoiceClone = voiceClone;
            AudioFromVideo = audioFromVideo;
            VideoWithAudio = videoWithAudio;
            VideoToVideo = videoToVideo;
            MotionControl = motionControl;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MotionControl as object ??
            VideoToVideo as object ??
            VideoWithAudio as object ??
            AudioFromVideo as object ??
            VoiceClone as object ??
            SpeechToSpeech as object ??
            AudioIsolation as object ??
            VideoUpscale as object ??
            ImageUpscale as object ??
            Image as object ??
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
            Image?.ToString() ??
            ImageUpscale?.ToString() ??
            VideoUpscale?.ToString() ??
            AudioIsolation?.ToString() ??
            SpeechToSpeech?.ToString() ??
            VoiceClone?.ToString() ??
            AudioFromVideo?.ToString() ??
            VideoWithAudio?.ToString() ??
            VideoToVideo?.ToString() ??
            MotionControl?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsVideo && !IsTextToSpeech && !IsTextToSound && !IsImage && !IsImageUpscale && !IsVideoUpscale && !IsAudioIsolation && !IsSpeechToSpeech && !IsVoiceClone && !IsAudioFromVideo && !IsVideoWithAudio && !IsVideoToVideo && !IsMotionControl || !IsVideo && IsTextToSpeech && !IsTextToSound && !IsImage && !IsImageUpscale && !IsVideoUpscale && !IsAudioIsolation && !IsSpeechToSpeech && !IsVoiceClone && !IsAudioFromVideo && !IsVideoWithAudio && !IsVideoToVideo && !IsMotionControl || !IsVideo && !IsTextToSpeech && IsTextToSound && !IsImage && !IsImageUpscale && !IsVideoUpscale && !IsAudioIsolation && !IsSpeechToSpeech && !IsVoiceClone && !IsAudioFromVideo && !IsVideoWithAudio && !IsVideoToVideo && !IsMotionControl || !IsVideo && !IsTextToSpeech && !IsTextToSound && IsImage && !IsImageUpscale && !IsVideoUpscale && !IsAudioIsolation && !IsSpeechToSpeech && !IsVoiceClone && !IsAudioFromVideo && !IsVideoWithAudio && !IsVideoToVideo && !IsMotionControl || !IsVideo && !IsTextToSpeech && !IsTextToSound && !IsImage && IsImageUpscale && !IsVideoUpscale && !IsAudioIsolation && !IsSpeechToSpeech && !IsVoiceClone && !IsAudioFromVideo && !IsVideoWithAudio && !IsVideoToVideo && !IsMotionControl || !IsVideo && !IsTextToSpeech && !IsTextToSound && !IsImage && !IsImageUpscale && IsVideoUpscale && !IsAudioIsolation && !IsSpeechToSpeech && !IsVoiceClone && !IsAudioFromVideo && !IsVideoWithAudio && !IsVideoToVideo && !IsMotionControl || !IsVideo && !IsTextToSpeech && !IsTextToSound && !IsImage && !IsImageUpscale && !IsVideoUpscale && IsAudioIsolation && !IsSpeechToSpeech && !IsVoiceClone && !IsAudioFromVideo && !IsVideoWithAudio && !IsVideoToVideo && !IsMotionControl || !IsVideo && !IsTextToSpeech && !IsTextToSound && !IsImage && !IsImageUpscale && !IsVideoUpscale && !IsAudioIsolation && IsSpeechToSpeech && !IsVoiceClone && !IsAudioFromVideo && !IsVideoWithAudio && !IsVideoToVideo && !IsMotionControl || !IsVideo && !IsTextToSpeech && !IsTextToSound && !IsImage && !IsImageUpscale && !IsVideoUpscale && !IsAudioIsolation && !IsSpeechToSpeech && IsVoiceClone && !IsAudioFromVideo && !IsVideoWithAudio && !IsVideoToVideo && !IsMotionControl || !IsVideo && !IsTextToSpeech && !IsTextToSound && !IsImage && !IsImageUpscale && !IsVideoUpscale && !IsAudioIsolation && !IsSpeechToSpeech && !IsVoiceClone && IsAudioFromVideo && !IsVideoWithAudio && !IsVideoToVideo && !IsMotionControl || !IsVideo && !IsTextToSpeech && !IsTextToSound && !IsImage && !IsImageUpscale && !IsVideoUpscale && !IsAudioIsolation && !IsSpeechToSpeech && !IsVoiceClone && !IsAudioFromVideo && IsVideoWithAudio && !IsVideoToVideo && !IsMotionControl || !IsVideo && !IsTextToSpeech && !IsTextToSound && !IsImage && !IsImageUpscale && !IsVideoUpscale && !IsAudioIsolation && !IsSpeechToSpeech && !IsVoiceClone && !IsAudioFromVideo && !IsVideoWithAudio && IsVideoToVideo && !IsMotionControl || !IsVideo && !IsTextToSpeech && !IsTextToSound && !IsImage && !IsImageUpscale && !IsVideoUpscale && !IsAudioIsolation && !IsSpeechToSpeech && !IsVoiceClone && !IsAudioFromVideo && !IsVideoWithAudio && !IsVideoToVideo && IsMotionControl;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Hedra.GenerateVideoResponse, TResult>? video = null,
            global::System.Func<global::Hedra.GenerateTextToSpeechResponse, TResult>? textToSpeech = null,
            global::System.Func<global::Hedra.GenerateTextToSoundResponse, TResult>? textToSound = null,
            global::System.Func<global::Hedra.GenerateImageResponse, TResult>? image = null,
            global::System.Func<global::Hedra.GenerateImageUpscaleResponse, TResult>? imageUpscale = null,
            global::System.Func<global::Hedra.GenerateVideoUpscaleResponse, TResult>? videoUpscale = null,
            global::System.Func<global::Hedra.GenerateIsolatedAudioResponse, TResult>? audioIsolation = null,
            global::System.Func<global::Hedra.GenerateSpeechToSpeechResponse, TResult>? speechToSpeech = null,
            global::System.Func<global::Hedra.GenerateVoiceCloneResponse, TResult>? voiceClone = null,
            global::System.Func<global::Hedra.GenerateAudioFromVideoResponse, TResult>? audioFromVideo = null,
            global::System.Func<global::Hedra.GenerateVideoWithAudioResponse, TResult>? videoWithAudio = null,
            global::System.Func<global::Hedra.GenerateVideoToVideoResponse, TResult>? videoToVideo = null,
            global::System.Func<global::Hedra.GenerateMotionControlResponse, TResult>? motionControl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVideo && video != null)
            {
                return video(Video!);
            }
            else if (IsTextToSpeech && textToSpeech != null)
            {
                return textToSpeech(TextToSpeech!);
            }
            else if (IsTextToSound && textToSound != null)
            {
                return textToSound(TextToSound!);
            }
            else if (IsImage && image != null)
            {
                return image(Image!);
            }
            else if (IsImageUpscale && imageUpscale != null)
            {
                return imageUpscale(ImageUpscale!);
            }
            else if (IsVideoUpscale && videoUpscale != null)
            {
                return videoUpscale(VideoUpscale!);
            }
            else if (IsAudioIsolation && audioIsolation != null)
            {
                return audioIsolation(AudioIsolation!);
            }
            else if (IsSpeechToSpeech && speechToSpeech != null)
            {
                return speechToSpeech(SpeechToSpeech!);
            }
            else if (IsVoiceClone && voiceClone != null)
            {
                return voiceClone(VoiceClone!);
            }
            else if (IsAudioFromVideo && audioFromVideo != null)
            {
                return audioFromVideo(AudioFromVideo!);
            }
            else if (IsVideoWithAudio && videoWithAudio != null)
            {
                return videoWithAudio(VideoWithAudio!);
            }
            else if (IsVideoToVideo && videoToVideo != null)
            {
                return videoToVideo(VideoToVideo!);
            }
            else if (IsMotionControl && motionControl != null)
            {
                return motionControl(MotionControl!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Hedra.GenerateVideoResponse>? video = null,

            global::System.Action<global::Hedra.GenerateTextToSpeechResponse>? textToSpeech = null,

            global::System.Action<global::Hedra.GenerateTextToSoundResponse>? textToSound = null,

            global::System.Action<global::Hedra.GenerateImageResponse>? image = null,

            global::System.Action<global::Hedra.GenerateImageUpscaleResponse>? imageUpscale = null,

            global::System.Action<global::Hedra.GenerateVideoUpscaleResponse>? videoUpscale = null,

            global::System.Action<global::Hedra.GenerateIsolatedAudioResponse>? audioIsolation = null,

            global::System.Action<global::Hedra.GenerateSpeechToSpeechResponse>? speechToSpeech = null,

            global::System.Action<global::Hedra.GenerateVoiceCloneResponse>? voiceClone = null,

            global::System.Action<global::Hedra.GenerateAudioFromVideoResponse>? audioFromVideo = null,

            global::System.Action<global::Hedra.GenerateVideoWithAudioResponse>? videoWithAudio = null,

            global::System.Action<global::Hedra.GenerateVideoToVideoResponse>? videoToVideo = null,

            global::System.Action<global::Hedra.GenerateMotionControlResponse>? motionControl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVideo)
            {
                video?.Invoke(Video!);
            }
            else if (IsTextToSpeech)
            {
                textToSpeech?.Invoke(TextToSpeech!);
            }
            else if (IsTextToSound)
            {
                textToSound?.Invoke(TextToSound!);
            }
            else if (IsImage)
            {
                image?.Invoke(Image!);
            }
            else if (IsImageUpscale)
            {
                imageUpscale?.Invoke(ImageUpscale!);
            }
            else if (IsVideoUpscale)
            {
                videoUpscale?.Invoke(VideoUpscale!);
            }
            else if (IsAudioIsolation)
            {
                audioIsolation?.Invoke(AudioIsolation!);
            }
            else if (IsSpeechToSpeech)
            {
                speechToSpeech?.Invoke(SpeechToSpeech!);
            }
            else if (IsVoiceClone)
            {
                voiceClone?.Invoke(VoiceClone!);
            }
            else if (IsAudioFromVideo)
            {
                audioFromVideo?.Invoke(AudioFromVideo!);
            }
            else if (IsVideoWithAudio)
            {
                videoWithAudio?.Invoke(VideoWithAudio!);
            }
            else if (IsVideoToVideo)
            {
                videoToVideo?.Invoke(VideoToVideo!);
            }
            else if (IsMotionControl)
            {
                motionControl?.Invoke(MotionControl!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Hedra.GenerateVideoResponse>? video = null,
            global::System.Action<global::Hedra.GenerateTextToSpeechResponse>? textToSpeech = null,
            global::System.Action<global::Hedra.GenerateTextToSoundResponse>? textToSound = null,
            global::System.Action<global::Hedra.GenerateImageResponse>? image = null,
            global::System.Action<global::Hedra.GenerateImageUpscaleResponse>? imageUpscale = null,
            global::System.Action<global::Hedra.GenerateVideoUpscaleResponse>? videoUpscale = null,
            global::System.Action<global::Hedra.GenerateIsolatedAudioResponse>? audioIsolation = null,
            global::System.Action<global::Hedra.GenerateSpeechToSpeechResponse>? speechToSpeech = null,
            global::System.Action<global::Hedra.GenerateVoiceCloneResponse>? voiceClone = null,
            global::System.Action<global::Hedra.GenerateAudioFromVideoResponse>? audioFromVideo = null,
            global::System.Action<global::Hedra.GenerateVideoWithAudioResponse>? videoWithAudio = null,
            global::System.Action<global::Hedra.GenerateVideoToVideoResponse>? videoToVideo = null,
            global::System.Action<global::Hedra.GenerateMotionControlResponse>? motionControl = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVideo)
            {
                video?.Invoke(Video!);
            }
            else if (IsTextToSpeech)
            {
                textToSpeech?.Invoke(TextToSpeech!);
            }
            else if (IsTextToSound)
            {
                textToSound?.Invoke(TextToSound!);
            }
            else if (IsImage)
            {
                image?.Invoke(Image!);
            }
            else if (IsImageUpscale)
            {
                imageUpscale?.Invoke(ImageUpscale!);
            }
            else if (IsVideoUpscale)
            {
                videoUpscale?.Invoke(VideoUpscale!);
            }
            else if (IsAudioIsolation)
            {
                audioIsolation?.Invoke(AudioIsolation!);
            }
            else if (IsSpeechToSpeech)
            {
                speechToSpeech?.Invoke(SpeechToSpeech!);
            }
            else if (IsVoiceClone)
            {
                voiceClone?.Invoke(VoiceClone!);
            }
            else if (IsAudioFromVideo)
            {
                audioFromVideo?.Invoke(AudioFromVideo!);
            }
            else if (IsVideoWithAudio)
            {
                videoWithAudio?.Invoke(VideoWithAudio!);
            }
            else if (IsVideoToVideo)
            {
                videoToVideo?.Invoke(VideoToVideo!);
            }
            else if (IsMotionControl)
            {
                motionControl?.Invoke(MotionControl!);
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
                typeof(global::Hedra.GenerateVideoResponse),
                TextToSpeech,
                typeof(global::Hedra.GenerateTextToSpeechResponse),
                TextToSound,
                typeof(global::Hedra.GenerateTextToSoundResponse),
                Image,
                typeof(global::Hedra.GenerateImageResponse),
                ImageUpscale,
                typeof(global::Hedra.GenerateImageUpscaleResponse),
                VideoUpscale,
                typeof(global::Hedra.GenerateVideoUpscaleResponse),
                AudioIsolation,
                typeof(global::Hedra.GenerateIsolatedAudioResponse),
                SpeechToSpeech,
                typeof(global::Hedra.GenerateSpeechToSpeechResponse),
                VoiceClone,
                typeof(global::Hedra.GenerateVoiceCloneResponse),
                AudioFromVideo,
                typeof(global::Hedra.GenerateAudioFromVideoResponse),
                VideoWithAudio,
                typeof(global::Hedra.GenerateVideoWithAudioResponse),
                VideoToVideo,
                typeof(global::Hedra.GenerateVideoToVideoResponse),
                MotionControl,
                typeof(global::Hedra.GenerateMotionControlResponse),
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
        public bool Equals(GenerateAssetPublicGenerationsPostResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateVideoResponse?>.Default.Equals(Video, other.Video) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateTextToSpeechResponse?>.Default.Equals(TextToSpeech, other.TextToSpeech) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateTextToSoundResponse?>.Default.Equals(TextToSound, other.TextToSound) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateImageResponse?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateImageUpscaleResponse?>.Default.Equals(ImageUpscale, other.ImageUpscale) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateVideoUpscaleResponse?>.Default.Equals(VideoUpscale, other.VideoUpscale) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateIsolatedAudioResponse?>.Default.Equals(AudioIsolation, other.AudioIsolation) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateSpeechToSpeechResponse?>.Default.Equals(SpeechToSpeech, other.SpeechToSpeech) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateVoiceCloneResponse?>.Default.Equals(VoiceClone, other.VoiceClone) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateAudioFromVideoResponse?>.Default.Equals(AudioFromVideo, other.AudioFromVideo) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateVideoWithAudioResponse?>.Default.Equals(VideoWithAudio, other.VideoWithAudio) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateVideoToVideoResponse?>.Default.Equals(VideoToVideo, other.VideoToVideo) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateMotionControlResponse?>.Default.Equals(MotionControl, other.MotionControl) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(GenerateAssetPublicGenerationsPostResponse obj1, GenerateAssetPublicGenerationsPostResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<GenerateAssetPublicGenerationsPostResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(GenerateAssetPublicGenerationsPostResponse obj1, GenerateAssetPublicGenerationsPostResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is GenerateAssetPublicGenerationsPostResponse o && Equals(o);
        }
    }
}
