#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Hedra
{
    /// <summary>
    /// Inputs for the generation
    /// </summary>
    public readonly partial struct Input : global::System.IEquatable<Input>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Hedra.GenerationInputDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateVideoRequestOutput? Video { get; init; }
#else
        public global::Hedra.GenerateVideoRequestOutput? Video { get; }
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
        /// Motion Control request for transferring motion from a reference video to a character image.<br/>
        /// Processed through V2V infrastructure internally.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateMotionControlRequestOutput? MotionControl { get; init; }
#else
        public global::Hedra.GenerateMotionControlRequestOutput? MotionControl { get; }
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
        public static implicit operator Input(global::Hedra.GenerateVideoRequestOutput value) => new Input((global::Hedra.GenerateVideoRequestOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateVideoRequestOutput?(Input @this) => @this.Video;

        /// <summary>
        /// 
        /// </summary>
        public Input(global::Hedra.GenerateVideoRequestOutput? value)
        {
            Video = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Input(global::Hedra.GenerateTextToSpeechRequest value) => new Input((global::Hedra.GenerateTextToSpeechRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateTextToSpeechRequest?(Input @this) => @this.TextToSpeech;

        /// <summary>
        /// 
        /// </summary>
        public Input(global::Hedra.GenerateTextToSpeechRequest? value)
        {
            TextToSpeech = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Input(global::Hedra.GenerateTextToSoundRequest value) => new Input((global::Hedra.GenerateTextToSoundRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateTextToSoundRequest?(Input @this) => @this.TextToSound;

        /// <summary>
        /// 
        /// </summary>
        public Input(global::Hedra.GenerateTextToSoundRequest? value)
        {
            TextToSound = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Input(global::Hedra.GenerateImageRequest value) => new Input((global::Hedra.GenerateImageRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateImageRequest?(Input @this) => @this.Image;

        /// <summary>
        /// 
        /// </summary>
        public Input(global::Hedra.GenerateImageRequest? value)
        {
            Image = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Input(global::Hedra.GenerateImageUpscaleRequest value) => new Input((global::Hedra.GenerateImageUpscaleRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateImageUpscaleRequest?(Input @this) => @this.ImageUpscale;

        /// <summary>
        /// 
        /// </summary>
        public Input(global::Hedra.GenerateImageUpscaleRequest? value)
        {
            ImageUpscale = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Input(global::Hedra.GenerateVideoUpscaleRequest value) => new Input((global::Hedra.GenerateVideoUpscaleRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateVideoUpscaleRequest?(Input @this) => @this.VideoUpscale;

        /// <summary>
        /// 
        /// </summary>
        public Input(global::Hedra.GenerateVideoUpscaleRequest? value)
        {
            VideoUpscale = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Input(global::Hedra.GenerateIsolatedAudioRequest value) => new Input((global::Hedra.GenerateIsolatedAudioRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateIsolatedAudioRequest?(Input @this) => @this.AudioIsolation;

        /// <summary>
        /// 
        /// </summary>
        public Input(global::Hedra.GenerateIsolatedAudioRequest? value)
        {
            AudioIsolation = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Input(global::Hedra.GenerateSpeechToSpeechRequest value) => new Input((global::Hedra.GenerateSpeechToSpeechRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateSpeechToSpeechRequest?(Input @this) => @this.SpeechToSpeech;

        /// <summary>
        /// 
        /// </summary>
        public Input(global::Hedra.GenerateSpeechToSpeechRequest? value)
        {
            SpeechToSpeech = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Input(global::Hedra.GenerateVoiceCloneRequest value) => new Input((global::Hedra.GenerateVoiceCloneRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateVoiceCloneRequest?(Input @this) => @this.VoiceClone;

        /// <summary>
        /// 
        /// </summary>
        public Input(global::Hedra.GenerateVoiceCloneRequest? value)
        {
            VoiceClone = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Input(global::Hedra.GenerateAudioFromVideoRequest value) => new Input((global::Hedra.GenerateAudioFromVideoRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateAudioFromVideoRequest?(Input @this) => @this.AudioFromVideo;

        /// <summary>
        /// 
        /// </summary>
        public Input(global::Hedra.GenerateAudioFromVideoRequest? value)
        {
            AudioFromVideo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Input(global::Hedra.GenerateVideoWithAudioRequest value) => new Input((global::Hedra.GenerateVideoWithAudioRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateVideoWithAudioRequest?(Input @this) => @this.VideoWithAudio;

        /// <summary>
        /// 
        /// </summary>
        public Input(global::Hedra.GenerateVideoWithAudioRequest? value)
        {
            VideoWithAudio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Input(global::Hedra.GenerateVideoToVideoRequest value) => new Input((global::Hedra.GenerateVideoToVideoRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateVideoToVideoRequest?(Input @this) => @this.VideoToVideo;

        /// <summary>
        /// 
        /// </summary>
        public Input(global::Hedra.GenerateVideoToVideoRequest? value)
        {
            VideoToVideo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Input(global::Hedra.GenerateMotionControlRequestOutput value) => new Input((global::Hedra.GenerateMotionControlRequestOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateMotionControlRequestOutput?(Input @this) => @this.MotionControl;

        /// <summary>
        /// 
        /// </summary>
        public Input(global::Hedra.GenerateMotionControlRequestOutput? value)
        {
            MotionControl = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Input(
            global::Hedra.GenerationInputDiscriminatorType? type,
            global::Hedra.GenerateVideoRequestOutput? video,
            global::Hedra.GenerateTextToSpeechRequest? textToSpeech,
            global::Hedra.GenerateTextToSoundRequest? textToSound,
            global::Hedra.GenerateImageRequest? image,
            global::Hedra.GenerateImageUpscaleRequest? imageUpscale,
            global::Hedra.GenerateVideoUpscaleRequest? videoUpscale,
            global::Hedra.GenerateIsolatedAudioRequest? audioIsolation,
            global::Hedra.GenerateSpeechToSpeechRequest? speechToSpeech,
            global::Hedra.GenerateVoiceCloneRequest? voiceClone,
            global::Hedra.GenerateAudioFromVideoRequest? audioFromVideo,
            global::Hedra.GenerateVideoWithAudioRequest? videoWithAudio,
            global::Hedra.GenerateVideoToVideoRequest? videoToVideo,
            global::Hedra.GenerateMotionControlRequestOutput? motionControl
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
            global::System.Func<global::Hedra.GenerateVideoRequestOutput?, TResult>? video = null,
            global::System.Func<global::Hedra.GenerateTextToSpeechRequest?, TResult>? textToSpeech = null,
            global::System.Func<global::Hedra.GenerateTextToSoundRequest?, TResult>? textToSound = null,
            global::System.Func<global::Hedra.GenerateImageRequest?, TResult>? image = null,
            global::System.Func<global::Hedra.GenerateImageUpscaleRequest?, TResult>? imageUpscale = null,
            global::System.Func<global::Hedra.GenerateVideoUpscaleRequest?, TResult>? videoUpscale = null,
            global::System.Func<global::Hedra.GenerateIsolatedAudioRequest?, TResult>? audioIsolation = null,
            global::System.Func<global::Hedra.GenerateSpeechToSpeechRequest?, TResult>? speechToSpeech = null,
            global::System.Func<global::Hedra.GenerateVoiceCloneRequest?, TResult>? voiceClone = null,
            global::System.Func<global::Hedra.GenerateAudioFromVideoRequest?, TResult>? audioFromVideo = null,
            global::System.Func<global::Hedra.GenerateVideoWithAudioRequest?, TResult>? videoWithAudio = null,
            global::System.Func<global::Hedra.GenerateVideoToVideoRequest?, TResult>? videoToVideo = null,
            global::System.Func<global::Hedra.GenerateMotionControlRequestOutput?, TResult>? motionControl = null,
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
            global::System.Action<global::Hedra.GenerateVideoRequestOutput?>? video = null,
            global::System.Action<global::Hedra.GenerateTextToSpeechRequest?>? textToSpeech = null,
            global::System.Action<global::Hedra.GenerateTextToSoundRequest?>? textToSound = null,
            global::System.Action<global::Hedra.GenerateImageRequest?>? image = null,
            global::System.Action<global::Hedra.GenerateImageUpscaleRequest?>? imageUpscale = null,
            global::System.Action<global::Hedra.GenerateVideoUpscaleRequest?>? videoUpscale = null,
            global::System.Action<global::Hedra.GenerateIsolatedAudioRequest?>? audioIsolation = null,
            global::System.Action<global::Hedra.GenerateSpeechToSpeechRequest?>? speechToSpeech = null,
            global::System.Action<global::Hedra.GenerateVoiceCloneRequest?>? voiceClone = null,
            global::System.Action<global::Hedra.GenerateAudioFromVideoRequest?>? audioFromVideo = null,
            global::System.Action<global::Hedra.GenerateVideoWithAudioRequest?>? videoWithAudio = null,
            global::System.Action<global::Hedra.GenerateVideoToVideoRequest?>? videoToVideo = null,
            global::System.Action<global::Hedra.GenerateMotionControlRequestOutput?>? motionControl = null,
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
                typeof(global::Hedra.GenerateVideoRequestOutput),
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
                AudioIsolation,
                typeof(global::Hedra.GenerateIsolatedAudioRequest),
                SpeechToSpeech,
                typeof(global::Hedra.GenerateSpeechToSpeechRequest),
                VoiceClone,
                typeof(global::Hedra.GenerateVoiceCloneRequest),
                AudioFromVideo,
                typeof(global::Hedra.GenerateAudioFromVideoRequest),
                VideoWithAudio,
                typeof(global::Hedra.GenerateVideoWithAudioRequest),
                VideoToVideo,
                typeof(global::Hedra.GenerateVideoToVideoRequest),
                MotionControl,
                typeof(global::Hedra.GenerateMotionControlRequestOutput),
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
        public bool Equals(Input other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateVideoRequestOutput?>.Default.Equals(Video, other.Video) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateTextToSpeechRequest?>.Default.Equals(TextToSpeech, other.TextToSpeech) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateTextToSoundRequest?>.Default.Equals(TextToSound, other.TextToSound) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateImageRequest?>.Default.Equals(Image, other.Image) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateImageUpscaleRequest?>.Default.Equals(ImageUpscale, other.ImageUpscale) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateVideoUpscaleRequest?>.Default.Equals(VideoUpscale, other.VideoUpscale) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateIsolatedAudioRequest?>.Default.Equals(AudioIsolation, other.AudioIsolation) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateSpeechToSpeechRequest?>.Default.Equals(SpeechToSpeech, other.SpeechToSpeech) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateVoiceCloneRequest?>.Default.Equals(VoiceClone, other.VoiceClone) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateAudioFromVideoRequest?>.Default.Equals(AudioFromVideo, other.AudioFromVideo) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateVideoWithAudioRequest?>.Default.Equals(VideoWithAudio, other.VideoWithAudio) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateVideoToVideoRequest?>.Default.Equals(VideoToVideo, other.VideoToVideo) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateMotionControlRequestOutput?>.Default.Equals(MotionControl, other.MotionControl) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Input obj1, Input obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Input>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Input obj1, Input obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Input o && Equals(o);
        }
    }
}
