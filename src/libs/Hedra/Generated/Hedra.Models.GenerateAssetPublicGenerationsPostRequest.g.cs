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
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateVideoRequestInput? VideoInput { get; init; }
#else
        public global::Hedra.GenerateVideoRequestInput? VideoInput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VideoInput))]
#endif
        public bool IsVideoInput => VideoInput != null;

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
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateIsolatedAudioRequest? IsolatedAudio { get; init; }
#else
        public global::Hedra.GenerateIsolatedAudioRequest? IsolatedAudio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(IsolatedAudio))]
#endif
        public bool IsIsolatedAudio => IsolatedAudio != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateSpeechToSpeechRequest? SpeechTo { get; init; }
#else
        public global::Hedra.GenerateSpeechToSpeechRequest? SpeechTo { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SpeechTo))]
#endif
        public bool IsSpeechTo => SpeechTo != null;

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
        /// Audio generation request that extracts sound effects from video using Mirelo Studio.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateAudioFromVideoRequest? AudioFromVideo { get; init; }
#else
        public global::Hedra.GenerateAudioFromVideoRequest? AudioFromVideo { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AudioFromVideo))]
#endif
        public bool IsAudioFromVideo => AudioFromVideo != null;

        /// <summary>
        /// Video generation request that adds synchronized sound effects to video using Mirelo Studio.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateVideoWithAudioRequest? VideoWithAudio { get; init; }
#else
        public global::Hedra.GenerateVideoWithAudioRequest? VideoWithAudio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VideoWithAudio))]
#endif
        public bool IsVideoWithAudio => VideoWithAudio != null;

        /// <summary>
        /// Video-to-video edit request for Kling O1 Edit model.<br/>
        /// Transforms videos using natural language while preserving motion.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateVideoToVideoRequest? VideoTo { get; init; }
#else
        public global::Hedra.GenerateVideoToVideoRequest? VideoTo { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(VideoTo))]
#endif
        public bool IsVideoTo => VideoTo != null;

        /// <summary>
        /// Motion Control request for transferring motion from a reference video to a character image.<br/>
        /// Processed through V2V infrastructure internally.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateMotionControlRequestInput? MotionControlInput { get; init; }
#else
        public global::Hedra.GenerateMotionControlRequestInput? MotionControlInput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(MotionControlInput))]
#endif
        public bool IsMotionControlInput => MotionControlInput != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateAssetPublicGenerationsPostRequest(global::Hedra.GenerateVideoRequestInput value) => new GenerateAssetPublicGenerationsPostRequest((global::Hedra.GenerateVideoRequestInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateVideoRequestInput?(GenerateAssetPublicGenerationsPostRequest @this) => @this.VideoInput;

        /// <summary>
        /// 
        /// </summary>
        public GenerateAssetPublicGenerationsPostRequest(global::Hedra.GenerateVideoRequestInput? value)
        {
            VideoInput = value;
        }

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
        public static implicit operator GenerateAssetPublicGenerationsPostRequest(global::Hedra.GenerateIsolatedAudioRequest value) => new GenerateAssetPublicGenerationsPostRequest((global::Hedra.GenerateIsolatedAudioRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateIsolatedAudioRequest?(GenerateAssetPublicGenerationsPostRequest @this) => @this.IsolatedAudio;

        /// <summary>
        /// 
        /// </summary>
        public GenerateAssetPublicGenerationsPostRequest(global::Hedra.GenerateIsolatedAudioRequest? value)
        {
            IsolatedAudio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateAssetPublicGenerationsPostRequest(global::Hedra.GenerateSpeechToSpeechRequest value) => new GenerateAssetPublicGenerationsPostRequest((global::Hedra.GenerateSpeechToSpeechRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateSpeechToSpeechRequest?(GenerateAssetPublicGenerationsPostRequest @this) => @this.SpeechTo;

        /// <summary>
        /// 
        /// </summary>
        public GenerateAssetPublicGenerationsPostRequest(global::Hedra.GenerateSpeechToSpeechRequest? value)
        {
            SpeechTo = value;
        }

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
        public static implicit operator GenerateAssetPublicGenerationsPostRequest(global::Hedra.GenerateAudioFromVideoRequest value) => new GenerateAssetPublicGenerationsPostRequest((global::Hedra.GenerateAudioFromVideoRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateAudioFromVideoRequest?(GenerateAssetPublicGenerationsPostRequest @this) => @this.AudioFromVideo;

        /// <summary>
        /// 
        /// </summary>
        public GenerateAssetPublicGenerationsPostRequest(global::Hedra.GenerateAudioFromVideoRequest? value)
        {
            AudioFromVideo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateAssetPublicGenerationsPostRequest(global::Hedra.GenerateVideoWithAudioRequest value) => new GenerateAssetPublicGenerationsPostRequest((global::Hedra.GenerateVideoWithAudioRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateVideoWithAudioRequest?(GenerateAssetPublicGenerationsPostRequest @this) => @this.VideoWithAudio;

        /// <summary>
        /// 
        /// </summary>
        public GenerateAssetPublicGenerationsPostRequest(global::Hedra.GenerateVideoWithAudioRequest? value)
        {
            VideoWithAudio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateAssetPublicGenerationsPostRequest(global::Hedra.GenerateVideoToVideoRequest value) => new GenerateAssetPublicGenerationsPostRequest((global::Hedra.GenerateVideoToVideoRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateVideoToVideoRequest?(GenerateAssetPublicGenerationsPostRequest @this) => @this.VideoTo;

        /// <summary>
        /// 
        /// </summary>
        public GenerateAssetPublicGenerationsPostRequest(global::Hedra.GenerateVideoToVideoRequest? value)
        {
            VideoTo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator GenerateAssetPublicGenerationsPostRequest(global::Hedra.GenerateMotionControlRequestInput value) => new GenerateAssetPublicGenerationsPostRequest((global::Hedra.GenerateMotionControlRequestInput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateMotionControlRequestInput?(GenerateAssetPublicGenerationsPostRequest @this) => @this.MotionControlInput;

        /// <summary>
        /// 
        /// </summary>
        public GenerateAssetPublicGenerationsPostRequest(global::Hedra.GenerateMotionControlRequestInput? value)
        {
            MotionControlInput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public GenerateAssetPublicGenerationsPostRequest(
            global::Hedra.GenerateVideoRequestInput? videoInput,
            global::Hedra.GenerateTextToSpeechRequest? textToSpeech,
            global::Hedra.GenerateTextToSoundRequest? textToSound,
            global::Hedra.GenerateImageRequest? image,
            global::Hedra.GenerateImageUpscaleRequest? imageUpscale,
            global::Hedra.GenerateVideoUpscaleRequest? videoUpscale,
            global::Hedra.GenerateIsolatedAudioRequest? isolatedAudio,
            global::Hedra.GenerateSpeechToSpeechRequest? speechTo,
            global::Hedra.GenerateVoiceCloneRequest? voiceClone,
            global::Hedra.GenerateAudioFromVideoRequest? audioFromVideo,
            global::Hedra.GenerateVideoWithAudioRequest? videoWithAudio,
            global::Hedra.GenerateVideoToVideoRequest? videoTo,
            global::Hedra.GenerateMotionControlRequestInput? motionControlInput
            )
        {
            VideoInput = videoInput;
            TextToSpeech = textToSpeech;
            TextToSound = textToSound;
            Image = image;
            ImageUpscale = imageUpscale;
            VideoUpscale = videoUpscale;
            IsolatedAudio = isolatedAudio;
            SpeechTo = speechTo;
            VoiceClone = voiceClone;
            AudioFromVideo = audioFromVideo;
            VideoWithAudio = videoWithAudio;
            VideoTo = videoTo;
            MotionControlInput = motionControlInput;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            MotionControlInput as object ??
            VideoTo as object ??
            VideoWithAudio as object ??
            AudioFromVideo as object ??
            VoiceClone as object ??
            SpeechTo as object ??
            IsolatedAudio as object ??
            VideoUpscale as object ??
            ImageUpscale as object ??
            Image as object ??
            TextToSound as object ??
            TextToSpeech as object ??
            VideoInput as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            VideoInput?.ToString() ??
            TextToSpeech?.ToString() ??
            TextToSound?.ToString() ??
            Image?.ToString() ??
            ImageUpscale?.ToString() ??
            VideoUpscale?.ToString() ??
            IsolatedAudio?.ToString() ??
            SpeechTo?.ToString() ??
            VoiceClone?.ToString() ??
            AudioFromVideo?.ToString() ??
            VideoWithAudio?.ToString() ??
            VideoTo?.ToString() ??
            MotionControlInput?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsVideoInput && !IsTextToSpeech && !IsTextToSound && !IsImage && !IsImageUpscale && !IsVideoUpscale && !IsIsolatedAudio && !IsSpeechTo && !IsVoiceClone && !IsAudioFromVideo && !IsVideoWithAudio && !IsVideoTo && !IsMotionControlInput || !IsVideoInput && IsTextToSpeech && !IsTextToSound && !IsImage && !IsImageUpscale && !IsVideoUpscale && !IsIsolatedAudio && !IsSpeechTo && !IsVoiceClone && !IsAudioFromVideo && !IsVideoWithAudio && !IsVideoTo && !IsMotionControlInput || !IsVideoInput && !IsTextToSpeech && IsTextToSound && !IsImage && !IsImageUpscale && !IsVideoUpscale && !IsIsolatedAudio && !IsSpeechTo && !IsVoiceClone && !IsAudioFromVideo && !IsVideoWithAudio && !IsVideoTo && !IsMotionControlInput || !IsVideoInput && !IsTextToSpeech && !IsTextToSound && IsImage && !IsImageUpscale && !IsVideoUpscale && !IsIsolatedAudio && !IsSpeechTo && !IsVoiceClone && !IsAudioFromVideo && !IsVideoWithAudio && !IsVideoTo && !IsMotionControlInput || !IsVideoInput && !IsTextToSpeech && !IsTextToSound && !IsImage && IsImageUpscale && !IsVideoUpscale && !IsIsolatedAudio && !IsSpeechTo && !IsVoiceClone && !IsAudioFromVideo && !IsVideoWithAudio && !IsVideoTo && !IsMotionControlInput || !IsVideoInput && !IsTextToSpeech && !IsTextToSound && !IsImage && !IsImageUpscale && IsVideoUpscale && !IsIsolatedAudio && !IsSpeechTo && !IsVoiceClone && !IsAudioFromVideo && !IsVideoWithAudio && !IsVideoTo && !IsMotionControlInput || !IsVideoInput && !IsTextToSpeech && !IsTextToSound && !IsImage && !IsImageUpscale && !IsVideoUpscale && IsIsolatedAudio && !IsSpeechTo && !IsVoiceClone && !IsAudioFromVideo && !IsVideoWithAudio && !IsVideoTo && !IsMotionControlInput || !IsVideoInput && !IsTextToSpeech && !IsTextToSound && !IsImage && !IsImageUpscale && !IsVideoUpscale && !IsIsolatedAudio && IsSpeechTo && !IsVoiceClone && !IsAudioFromVideo && !IsVideoWithAudio && !IsVideoTo && !IsMotionControlInput || !IsVideoInput && !IsTextToSpeech && !IsTextToSound && !IsImage && !IsImageUpscale && !IsVideoUpscale && !IsIsolatedAudio && !IsSpeechTo && IsVoiceClone && !IsAudioFromVideo && !IsVideoWithAudio && !IsVideoTo && !IsMotionControlInput || !IsVideoInput && !IsTextToSpeech && !IsTextToSound && !IsImage && !IsImageUpscale && !IsVideoUpscale && !IsIsolatedAudio && !IsSpeechTo && !IsVoiceClone && IsAudioFromVideo && !IsVideoWithAudio && !IsVideoTo && !IsMotionControlInput || !IsVideoInput && !IsTextToSpeech && !IsTextToSound && !IsImage && !IsImageUpscale && !IsVideoUpscale && !IsIsolatedAudio && !IsSpeechTo && !IsVoiceClone && !IsAudioFromVideo && IsVideoWithAudio && !IsVideoTo && !IsMotionControlInput || !IsVideoInput && !IsTextToSpeech && !IsTextToSound && !IsImage && !IsImageUpscale && !IsVideoUpscale && !IsIsolatedAudio && !IsSpeechTo && !IsVoiceClone && !IsAudioFromVideo && !IsVideoWithAudio && IsVideoTo && !IsMotionControlInput || !IsVideoInput && !IsTextToSpeech && !IsTextToSound && !IsImage && !IsImageUpscale && !IsVideoUpscale && !IsIsolatedAudio && !IsSpeechTo && !IsVoiceClone && !IsAudioFromVideo && !IsVideoWithAudio && !IsVideoTo && IsMotionControlInput;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Hedra.GenerateVideoRequestInput?, TResult>? videoInput = null,
            global::System.Func<global::Hedra.GenerateTextToSpeechRequest?, TResult>? textToSpeech = null,
            global::System.Func<global::Hedra.GenerateTextToSoundRequest?, TResult>? textToSound = null,
            global::System.Func<global::Hedra.GenerateImageRequest?, TResult>? image = null,
            global::System.Func<global::Hedra.GenerateImageUpscaleRequest?, TResult>? imageUpscale = null,
            global::System.Func<global::Hedra.GenerateVideoUpscaleRequest?, TResult>? videoUpscale = null,
            global::System.Func<global::Hedra.GenerateIsolatedAudioRequest?, TResult>? isolatedAudio = null,
            global::System.Func<global::Hedra.GenerateSpeechToSpeechRequest?, TResult>? speechTo = null,
            global::System.Func<global::Hedra.GenerateVoiceCloneRequest?, TResult>? voiceClone = null,
            global::System.Func<global::Hedra.GenerateAudioFromVideoRequest?, TResult>? audioFromVideo = null,
            global::System.Func<global::Hedra.GenerateVideoWithAudioRequest?, TResult>? videoWithAudio = null,
            global::System.Func<global::Hedra.GenerateVideoToVideoRequest?, TResult>? videoTo = null,
            global::System.Func<global::Hedra.GenerateMotionControlRequestInput?, TResult>? motionControlInput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVideoInput && videoInput != null)
            {
                return videoInput(VideoInput!);
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
            else if (IsIsolatedAudio && isolatedAudio != null)
            {
                return isolatedAudio(IsolatedAudio!);
            }
            else if (IsSpeechTo && speechTo != null)
            {
                return speechTo(SpeechTo!);
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
            else if (IsVideoTo && videoTo != null)
            {
                return videoTo(VideoTo!);
            }
            else if (IsMotionControlInput && motionControlInput != null)
            {
                return motionControlInput(MotionControlInput!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Hedra.GenerateVideoRequestInput?>? videoInput = null,
            global::System.Action<global::Hedra.GenerateTextToSpeechRequest?>? textToSpeech = null,
            global::System.Action<global::Hedra.GenerateTextToSoundRequest?>? textToSound = null,
            global::System.Action<global::Hedra.GenerateImageRequest?>? image = null,
            global::System.Action<global::Hedra.GenerateImageUpscaleRequest?>? imageUpscale = null,
            global::System.Action<global::Hedra.GenerateVideoUpscaleRequest?>? videoUpscale = null,
            global::System.Action<global::Hedra.GenerateIsolatedAudioRequest?>? isolatedAudio = null,
            global::System.Action<global::Hedra.GenerateSpeechToSpeechRequest?>? speechTo = null,
            global::System.Action<global::Hedra.GenerateVoiceCloneRequest?>? voiceClone = null,
            global::System.Action<global::Hedra.GenerateAudioFromVideoRequest?>? audioFromVideo = null,
            global::System.Action<global::Hedra.GenerateVideoWithAudioRequest?>? videoWithAudio = null,
            global::System.Action<global::Hedra.GenerateVideoToVideoRequest?>? videoTo = null,
            global::System.Action<global::Hedra.GenerateMotionControlRequestInput?>? motionControlInput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsVideoInput)
            {
                videoInput?.Invoke(VideoInput!);
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
            else if (IsIsolatedAudio)
            {
                isolatedAudio?.Invoke(IsolatedAudio!);
            }
            else if (IsSpeechTo)
            {
                speechTo?.Invoke(SpeechTo!);
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
            else if (IsVideoTo)
            {
                videoTo?.Invoke(VideoTo!);
            }
            else if (IsMotionControlInput)
            {
                motionControlInput?.Invoke(MotionControlInput!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                VideoInput,
                typeof(global::Hedra.GenerateVideoRequestInput),
                TextToSpeech,
                typeof(global::Hedra.GenerateTextToSpeechRequest),
                TextToSound,
                typeof(global::Hedra.GenerateTextToSoundRequest),
                Image,
                typeof(global::Hedra.GenerateImageRequest),
                ImageUpscale,
                typeof(global::Hedra.GenerateImageUpscaleRequest),
                VideoUpscale,
                typeof(global::Hedra.GenerateVideoUpscaleRequest),
                IsolatedAudio,
                typeof(global::Hedra.GenerateIsolatedAudioRequest),
                SpeechTo,
                typeof(global::Hedra.GenerateSpeechToSpeechRequest),
                VoiceClone,
                typeof(global::Hedra.GenerateVoiceCloneRequest),
                AudioFromVideo,
                typeof(global::Hedra.GenerateAudioFromVideoRequest),
                VideoWithAudio,
                typeof(global::Hedra.GenerateVideoWithAudioRequest),
                VideoTo,
                typeof(global::Hedra.GenerateVideoToVideoRequest),
                MotionControlInput,
                typeof(global::Hedra.GenerateMotionControlRequestInput),
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
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateVideoRequestInput?>.Default.Equals(VideoInput, other.VideoInput) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateTextToSpeechRequest?>.Default.Equals(TextToSpeech, other.TextToSpeech) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateTextToSoundRequest?>.Default.Equals(TextToSound, other.TextToSound) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateImageRequest?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateImageUpscaleRequest?>.Default.Equals(ImageUpscale, other.ImageUpscale) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateVideoUpscaleRequest?>.Default.Equals(VideoUpscale, other.VideoUpscale) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateIsolatedAudioRequest?>.Default.Equals(IsolatedAudio, other.IsolatedAudio) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateSpeechToSpeechRequest?>.Default.Equals(SpeechTo, other.SpeechTo) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateVoiceCloneRequest?>.Default.Equals(VoiceClone, other.VoiceClone) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateAudioFromVideoRequest?>.Default.Equals(AudioFromVideo, other.AudioFromVideo) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateVideoWithAudioRequest?>.Default.Equals(VideoWithAudio, other.VideoWithAudio) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateVideoToVideoRequest?>.Default.Equals(VideoTo, other.VideoTo) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateMotionControlRequestInput?>.Default.Equals(MotionControlInput, other.MotionControlInput) 
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
