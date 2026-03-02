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
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateVideoRequestOutput? GenerateVideoRequestOutput { get; init; }
#else
        public global::Hedra.GenerateVideoRequestOutput? GenerateVideoRequestOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GenerateVideoRequestOutput))]
#endif
        public bool IsGenerateVideoRequestOutput => GenerateVideoRequestOutput != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateTextToSpeechRequest? GenerateTextToSpeechRequest { get; init; }
#else
        public global::Hedra.GenerateTextToSpeechRequest? GenerateTextToSpeechRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GenerateTextToSpeechRequest))]
#endif
        public bool IsGenerateTextToSpeechRequest => GenerateTextToSpeechRequest != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateTextToSoundRequest? GenerateTextToSoundRequest { get; init; }
#else
        public global::Hedra.GenerateTextToSoundRequest? GenerateTextToSoundRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GenerateTextToSoundRequest))]
#endif
        public bool IsGenerateTextToSoundRequest => GenerateTextToSoundRequest != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateImageRequest? GenerateImageRequest { get; init; }
#else
        public global::Hedra.GenerateImageRequest? GenerateImageRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GenerateImageRequest))]
#endif
        public bool IsGenerateImageRequest => GenerateImageRequest != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateImageUpscaleRequest? GenerateImageUpscaleRequest { get; init; }
#else
        public global::Hedra.GenerateImageUpscaleRequest? GenerateImageUpscaleRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GenerateImageUpscaleRequest))]
#endif
        public bool IsGenerateImageUpscaleRequest => GenerateImageUpscaleRequest != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateVideoUpscaleRequest? GenerateVideoUpscaleRequest { get; init; }
#else
        public global::Hedra.GenerateVideoUpscaleRequest? GenerateVideoUpscaleRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GenerateVideoUpscaleRequest))]
#endif
        public bool IsGenerateVideoUpscaleRequest => GenerateVideoUpscaleRequest != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateIsolatedAudioRequest? GenerateIsolatedAudioRequest { get; init; }
#else
        public global::Hedra.GenerateIsolatedAudioRequest? GenerateIsolatedAudioRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GenerateIsolatedAudioRequest))]
#endif
        public bool IsGenerateIsolatedAudioRequest => GenerateIsolatedAudioRequest != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateSpeechToSpeechRequest? GenerateSpeechToRequest { get; init; }
#else
        public global::Hedra.GenerateSpeechToSpeechRequest? GenerateSpeechToRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GenerateSpeechToRequest))]
#endif
        public bool IsGenerateSpeechToRequest => GenerateSpeechToRequest != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateVoiceCloneRequest? GenerateVoiceCloneRequest { get; init; }
#else
        public global::Hedra.GenerateVoiceCloneRequest? GenerateVoiceCloneRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GenerateVoiceCloneRequest))]
#endif
        public bool IsGenerateVoiceCloneRequest => GenerateVoiceCloneRequest != null;

        /// <summary>
        /// Audio generation request that extracts sound effects from video using Mirelo Studio.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateAudioFromVideoRequest? GenerateAudioFromVideoRequest { get; init; }
#else
        public global::Hedra.GenerateAudioFromVideoRequest? GenerateAudioFromVideoRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GenerateAudioFromVideoRequest))]
#endif
        public bool IsGenerateAudioFromVideoRequest => GenerateAudioFromVideoRequest != null;

        /// <summary>
        /// Video generation request that adds synchronized sound effects to video using Mirelo Studio.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateVideoWithAudioRequest? GenerateVideoWithAudioRequest { get; init; }
#else
        public global::Hedra.GenerateVideoWithAudioRequest? GenerateVideoWithAudioRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GenerateVideoWithAudioRequest))]
#endif
        public bool IsGenerateVideoWithAudioRequest => GenerateVideoWithAudioRequest != null;

        /// <summary>
        /// Video-to-video edit request for Kling O1 Edit model.<br/>
        /// Transforms videos using natural language while preserving motion.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateVideoToVideoRequest? GenerateVideoToRequest { get; init; }
#else
        public global::Hedra.GenerateVideoToVideoRequest? GenerateVideoToRequest { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GenerateVideoToRequest))]
#endif
        public bool IsGenerateVideoToRequest => GenerateVideoToRequest != null;

        /// <summary>
        /// Motion Control request for transferring motion from a reference video to a character image.<br/>
        /// Processed through V2V infrastructure internally.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GenerateMotionControlRequestOutput? GenerateMotionControlRequestOutput { get; init; }
#else
        public global::Hedra.GenerateMotionControlRequestOutput? GenerateMotionControlRequestOutput { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GenerateMotionControlRequestOutput))]
#endif
        public bool IsGenerateMotionControlRequestOutput => GenerateMotionControlRequestOutput != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Input(global::Hedra.GenerateVideoRequestOutput value) => new Input((global::Hedra.GenerateVideoRequestOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateVideoRequestOutput?(Input @this) => @this.GenerateVideoRequestOutput;

        /// <summary>
        /// 
        /// </summary>
        public Input(global::Hedra.GenerateVideoRequestOutput? value)
        {
            GenerateVideoRequestOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Input(global::Hedra.GenerateTextToSpeechRequest value) => new Input((global::Hedra.GenerateTextToSpeechRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateTextToSpeechRequest?(Input @this) => @this.GenerateTextToSpeechRequest;

        /// <summary>
        /// 
        /// </summary>
        public Input(global::Hedra.GenerateTextToSpeechRequest? value)
        {
            GenerateTextToSpeechRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Input(global::Hedra.GenerateTextToSoundRequest value) => new Input((global::Hedra.GenerateTextToSoundRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateTextToSoundRequest?(Input @this) => @this.GenerateTextToSoundRequest;

        /// <summary>
        /// 
        /// </summary>
        public Input(global::Hedra.GenerateTextToSoundRequest? value)
        {
            GenerateTextToSoundRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Input(global::Hedra.GenerateImageRequest value) => new Input((global::Hedra.GenerateImageRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateImageRequest?(Input @this) => @this.GenerateImageRequest;

        /// <summary>
        /// 
        /// </summary>
        public Input(global::Hedra.GenerateImageRequest? value)
        {
            GenerateImageRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Input(global::Hedra.GenerateImageUpscaleRequest value) => new Input((global::Hedra.GenerateImageUpscaleRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateImageUpscaleRequest?(Input @this) => @this.GenerateImageUpscaleRequest;

        /// <summary>
        /// 
        /// </summary>
        public Input(global::Hedra.GenerateImageUpscaleRequest? value)
        {
            GenerateImageUpscaleRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Input(global::Hedra.GenerateVideoUpscaleRequest value) => new Input((global::Hedra.GenerateVideoUpscaleRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateVideoUpscaleRequest?(Input @this) => @this.GenerateVideoUpscaleRequest;

        /// <summary>
        /// 
        /// </summary>
        public Input(global::Hedra.GenerateVideoUpscaleRequest? value)
        {
            GenerateVideoUpscaleRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Input(global::Hedra.GenerateIsolatedAudioRequest value) => new Input((global::Hedra.GenerateIsolatedAudioRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateIsolatedAudioRequest?(Input @this) => @this.GenerateIsolatedAudioRequest;

        /// <summary>
        /// 
        /// </summary>
        public Input(global::Hedra.GenerateIsolatedAudioRequest? value)
        {
            GenerateIsolatedAudioRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Input(global::Hedra.GenerateSpeechToSpeechRequest value) => new Input((global::Hedra.GenerateSpeechToSpeechRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateSpeechToSpeechRequest?(Input @this) => @this.GenerateSpeechToRequest;

        /// <summary>
        /// 
        /// </summary>
        public Input(global::Hedra.GenerateSpeechToSpeechRequest? value)
        {
            GenerateSpeechToRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Input(global::Hedra.GenerateVoiceCloneRequest value) => new Input((global::Hedra.GenerateVoiceCloneRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateVoiceCloneRequest?(Input @this) => @this.GenerateVoiceCloneRequest;

        /// <summary>
        /// 
        /// </summary>
        public Input(global::Hedra.GenerateVoiceCloneRequest? value)
        {
            GenerateVoiceCloneRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Input(global::Hedra.GenerateAudioFromVideoRequest value) => new Input((global::Hedra.GenerateAudioFromVideoRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateAudioFromVideoRequest?(Input @this) => @this.GenerateAudioFromVideoRequest;

        /// <summary>
        /// 
        /// </summary>
        public Input(global::Hedra.GenerateAudioFromVideoRequest? value)
        {
            GenerateAudioFromVideoRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Input(global::Hedra.GenerateVideoWithAudioRequest value) => new Input((global::Hedra.GenerateVideoWithAudioRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateVideoWithAudioRequest?(Input @this) => @this.GenerateVideoWithAudioRequest;

        /// <summary>
        /// 
        /// </summary>
        public Input(global::Hedra.GenerateVideoWithAudioRequest? value)
        {
            GenerateVideoWithAudioRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Input(global::Hedra.GenerateVideoToVideoRequest value) => new Input((global::Hedra.GenerateVideoToVideoRequest?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateVideoToVideoRequest?(Input @this) => @this.GenerateVideoToRequest;

        /// <summary>
        /// 
        /// </summary>
        public Input(global::Hedra.GenerateVideoToVideoRequest? value)
        {
            GenerateVideoToRequest = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Input(global::Hedra.GenerateMotionControlRequestOutput value) => new Input((global::Hedra.GenerateMotionControlRequestOutput?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GenerateMotionControlRequestOutput?(Input @this) => @this.GenerateMotionControlRequestOutput;

        /// <summary>
        /// 
        /// </summary>
        public Input(global::Hedra.GenerateMotionControlRequestOutput? value)
        {
            GenerateMotionControlRequestOutput = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Input(
            global::Hedra.GenerateVideoRequestOutput? generateVideoRequestOutput,
            global::Hedra.GenerateTextToSpeechRequest? generateTextToSpeechRequest,
            global::Hedra.GenerateTextToSoundRequest? generateTextToSoundRequest,
            global::Hedra.GenerateImageRequest? generateImageRequest,
            global::Hedra.GenerateImageUpscaleRequest? generateImageUpscaleRequest,
            global::Hedra.GenerateVideoUpscaleRequest? generateVideoUpscaleRequest,
            global::Hedra.GenerateIsolatedAudioRequest? generateIsolatedAudioRequest,
            global::Hedra.GenerateSpeechToSpeechRequest? generateSpeechToRequest,
            global::Hedra.GenerateVoiceCloneRequest? generateVoiceCloneRequest,
            global::Hedra.GenerateAudioFromVideoRequest? generateAudioFromVideoRequest,
            global::Hedra.GenerateVideoWithAudioRequest? generateVideoWithAudioRequest,
            global::Hedra.GenerateVideoToVideoRequest? generateVideoToRequest,
            global::Hedra.GenerateMotionControlRequestOutput? generateMotionControlRequestOutput
            )
        {
            GenerateVideoRequestOutput = generateVideoRequestOutput;
            GenerateTextToSpeechRequest = generateTextToSpeechRequest;
            GenerateTextToSoundRequest = generateTextToSoundRequest;
            GenerateImageRequest = generateImageRequest;
            GenerateImageUpscaleRequest = generateImageUpscaleRequest;
            GenerateVideoUpscaleRequest = generateVideoUpscaleRequest;
            GenerateIsolatedAudioRequest = generateIsolatedAudioRequest;
            GenerateSpeechToRequest = generateSpeechToRequest;
            GenerateVoiceCloneRequest = generateVoiceCloneRequest;
            GenerateAudioFromVideoRequest = generateAudioFromVideoRequest;
            GenerateVideoWithAudioRequest = generateVideoWithAudioRequest;
            GenerateVideoToRequest = generateVideoToRequest;
            GenerateMotionControlRequestOutput = generateMotionControlRequestOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            GenerateMotionControlRequestOutput as object ??
            GenerateVideoToRequest as object ??
            GenerateVideoWithAudioRequest as object ??
            GenerateAudioFromVideoRequest as object ??
            GenerateVoiceCloneRequest as object ??
            GenerateSpeechToRequest as object ??
            GenerateIsolatedAudioRequest as object ??
            GenerateVideoUpscaleRequest as object ??
            GenerateImageUpscaleRequest as object ??
            GenerateImageRequest as object ??
            GenerateTextToSoundRequest as object ??
            GenerateTextToSpeechRequest as object ??
            GenerateVideoRequestOutput as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            GenerateVideoRequestOutput?.ToString() ??
            GenerateTextToSpeechRequest?.ToString() ??
            GenerateTextToSoundRequest?.ToString() ??
            GenerateImageRequest?.ToString() ??
            GenerateImageUpscaleRequest?.ToString() ??
            GenerateVideoUpscaleRequest?.ToString() ??
            GenerateIsolatedAudioRequest?.ToString() ??
            GenerateSpeechToRequest?.ToString() ??
            GenerateVoiceCloneRequest?.ToString() ??
            GenerateAudioFromVideoRequest?.ToString() ??
            GenerateVideoWithAudioRequest?.ToString() ??
            GenerateVideoToRequest?.ToString() ??
            GenerateMotionControlRequestOutput?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsGenerateVideoRequestOutput && !IsGenerateTextToSpeechRequest && !IsGenerateTextToSoundRequest && !IsGenerateImageRequest && !IsGenerateImageUpscaleRequest && !IsGenerateVideoUpscaleRequest && !IsGenerateIsolatedAudioRequest && !IsGenerateSpeechToRequest && !IsGenerateVoiceCloneRequest && !IsGenerateAudioFromVideoRequest && !IsGenerateVideoWithAudioRequest && !IsGenerateVideoToRequest && !IsGenerateMotionControlRequestOutput || !IsGenerateVideoRequestOutput && IsGenerateTextToSpeechRequest && !IsGenerateTextToSoundRequest && !IsGenerateImageRequest && !IsGenerateImageUpscaleRequest && !IsGenerateVideoUpscaleRequest && !IsGenerateIsolatedAudioRequest && !IsGenerateSpeechToRequest && !IsGenerateVoiceCloneRequest && !IsGenerateAudioFromVideoRequest && !IsGenerateVideoWithAudioRequest && !IsGenerateVideoToRequest && !IsGenerateMotionControlRequestOutput || !IsGenerateVideoRequestOutput && !IsGenerateTextToSpeechRequest && IsGenerateTextToSoundRequest && !IsGenerateImageRequest && !IsGenerateImageUpscaleRequest && !IsGenerateVideoUpscaleRequest && !IsGenerateIsolatedAudioRequest && !IsGenerateSpeechToRequest && !IsGenerateVoiceCloneRequest && !IsGenerateAudioFromVideoRequest && !IsGenerateVideoWithAudioRequest && !IsGenerateVideoToRequest && !IsGenerateMotionControlRequestOutput || !IsGenerateVideoRequestOutput && !IsGenerateTextToSpeechRequest && !IsGenerateTextToSoundRequest && IsGenerateImageRequest && !IsGenerateImageUpscaleRequest && !IsGenerateVideoUpscaleRequest && !IsGenerateIsolatedAudioRequest && !IsGenerateSpeechToRequest && !IsGenerateVoiceCloneRequest && !IsGenerateAudioFromVideoRequest && !IsGenerateVideoWithAudioRequest && !IsGenerateVideoToRequest && !IsGenerateMotionControlRequestOutput || !IsGenerateVideoRequestOutput && !IsGenerateTextToSpeechRequest && !IsGenerateTextToSoundRequest && !IsGenerateImageRequest && IsGenerateImageUpscaleRequest && !IsGenerateVideoUpscaleRequest && !IsGenerateIsolatedAudioRequest && !IsGenerateSpeechToRequest && !IsGenerateVoiceCloneRequest && !IsGenerateAudioFromVideoRequest && !IsGenerateVideoWithAudioRequest && !IsGenerateVideoToRequest && !IsGenerateMotionControlRequestOutput || !IsGenerateVideoRequestOutput && !IsGenerateTextToSpeechRequest && !IsGenerateTextToSoundRequest && !IsGenerateImageRequest && !IsGenerateImageUpscaleRequest && IsGenerateVideoUpscaleRequest && !IsGenerateIsolatedAudioRequest && !IsGenerateSpeechToRequest && !IsGenerateVoiceCloneRequest && !IsGenerateAudioFromVideoRequest && !IsGenerateVideoWithAudioRequest && !IsGenerateVideoToRequest && !IsGenerateMotionControlRequestOutput || !IsGenerateVideoRequestOutput && !IsGenerateTextToSpeechRequest && !IsGenerateTextToSoundRequest && !IsGenerateImageRequest && !IsGenerateImageUpscaleRequest && !IsGenerateVideoUpscaleRequest && IsGenerateIsolatedAudioRequest && !IsGenerateSpeechToRequest && !IsGenerateVoiceCloneRequest && !IsGenerateAudioFromVideoRequest && !IsGenerateVideoWithAudioRequest && !IsGenerateVideoToRequest && !IsGenerateMotionControlRequestOutput || !IsGenerateVideoRequestOutput && !IsGenerateTextToSpeechRequest && !IsGenerateTextToSoundRequest && !IsGenerateImageRequest && !IsGenerateImageUpscaleRequest && !IsGenerateVideoUpscaleRequest && !IsGenerateIsolatedAudioRequest && IsGenerateSpeechToRequest && !IsGenerateVoiceCloneRequest && !IsGenerateAudioFromVideoRequest && !IsGenerateVideoWithAudioRequest && !IsGenerateVideoToRequest && !IsGenerateMotionControlRequestOutput || !IsGenerateVideoRequestOutput && !IsGenerateTextToSpeechRequest && !IsGenerateTextToSoundRequest && !IsGenerateImageRequest && !IsGenerateImageUpscaleRequest && !IsGenerateVideoUpscaleRequest && !IsGenerateIsolatedAudioRequest && !IsGenerateSpeechToRequest && IsGenerateVoiceCloneRequest && !IsGenerateAudioFromVideoRequest && !IsGenerateVideoWithAudioRequest && !IsGenerateVideoToRequest && !IsGenerateMotionControlRequestOutput || !IsGenerateVideoRequestOutput && !IsGenerateTextToSpeechRequest && !IsGenerateTextToSoundRequest && !IsGenerateImageRequest && !IsGenerateImageUpscaleRequest && !IsGenerateVideoUpscaleRequest && !IsGenerateIsolatedAudioRequest && !IsGenerateSpeechToRequest && !IsGenerateVoiceCloneRequest && IsGenerateAudioFromVideoRequest && !IsGenerateVideoWithAudioRequest && !IsGenerateVideoToRequest && !IsGenerateMotionControlRequestOutput || !IsGenerateVideoRequestOutput && !IsGenerateTextToSpeechRequest && !IsGenerateTextToSoundRequest && !IsGenerateImageRequest && !IsGenerateImageUpscaleRequest && !IsGenerateVideoUpscaleRequest && !IsGenerateIsolatedAudioRequest && !IsGenerateSpeechToRequest && !IsGenerateVoiceCloneRequest && !IsGenerateAudioFromVideoRequest && IsGenerateVideoWithAudioRequest && !IsGenerateVideoToRequest && !IsGenerateMotionControlRequestOutput || !IsGenerateVideoRequestOutput && !IsGenerateTextToSpeechRequest && !IsGenerateTextToSoundRequest && !IsGenerateImageRequest && !IsGenerateImageUpscaleRequest && !IsGenerateVideoUpscaleRequest && !IsGenerateIsolatedAudioRequest && !IsGenerateSpeechToRequest && !IsGenerateVoiceCloneRequest && !IsGenerateAudioFromVideoRequest && !IsGenerateVideoWithAudioRequest && IsGenerateVideoToRequest && !IsGenerateMotionControlRequestOutput || !IsGenerateVideoRequestOutput && !IsGenerateTextToSpeechRequest && !IsGenerateTextToSoundRequest && !IsGenerateImageRequest && !IsGenerateImageUpscaleRequest && !IsGenerateVideoUpscaleRequest && !IsGenerateIsolatedAudioRequest && !IsGenerateSpeechToRequest && !IsGenerateVoiceCloneRequest && !IsGenerateAudioFromVideoRequest && !IsGenerateVideoWithAudioRequest && !IsGenerateVideoToRequest && IsGenerateMotionControlRequestOutput;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Hedra.GenerateVideoRequestOutput?, TResult>? generateVideoRequestOutput = null,
            global::System.Func<global::Hedra.GenerateTextToSpeechRequest?, TResult>? generateTextToSpeechRequest = null,
            global::System.Func<global::Hedra.GenerateTextToSoundRequest?, TResult>? generateTextToSoundRequest = null,
            global::System.Func<global::Hedra.GenerateImageRequest?, TResult>? generateImageRequest = null,
            global::System.Func<global::Hedra.GenerateImageUpscaleRequest?, TResult>? generateImageUpscaleRequest = null,
            global::System.Func<global::Hedra.GenerateVideoUpscaleRequest?, TResult>? generateVideoUpscaleRequest = null,
            global::System.Func<global::Hedra.GenerateIsolatedAudioRequest?, TResult>? generateIsolatedAudioRequest = null,
            global::System.Func<global::Hedra.GenerateSpeechToSpeechRequest?, TResult>? generateSpeechToRequest = null,
            global::System.Func<global::Hedra.GenerateVoiceCloneRequest?, TResult>? generateVoiceCloneRequest = null,
            global::System.Func<global::Hedra.GenerateAudioFromVideoRequest?, TResult>? generateAudioFromVideoRequest = null,
            global::System.Func<global::Hedra.GenerateVideoWithAudioRequest?, TResult>? generateVideoWithAudioRequest = null,
            global::System.Func<global::Hedra.GenerateVideoToVideoRequest?, TResult>? generateVideoToRequest = null,
            global::System.Func<global::Hedra.GenerateMotionControlRequestOutput?, TResult>? generateMotionControlRequestOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGenerateVideoRequestOutput && generateVideoRequestOutput != null)
            {
                return generateVideoRequestOutput(GenerateVideoRequestOutput!);
            }
            else if (IsGenerateTextToSpeechRequest && generateTextToSpeechRequest != null)
            {
                return generateTextToSpeechRequest(GenerateTextToSpeechRequest!);
            }
            else if (IsGenerateTextToSoundRequest && generateTextToSoundRequest != null)
            {
                return generateTextToSoundRequest(GenerateTextToSoundRequest!);
            }
            else if (IsGenerateImageRequest && generateImageRequest != null)
            {
                return generateImageRequest(GenerateImageRequest!);
            }
            else if (IsGenerateImageUpscaleRequest && generateImageUpscaleRequest != null)
            {
                return generateImageUpscaleRequest(GenerateImageUpscaleRequest!);
            }
            else if (IsGenerateVideoUpscaleRequest && generateVideoUpscaleRequest != null)
            {
                return generateVideoUpscaleRequest(GenerateVideoUpscaleRequest!);
            }
            else if (IsGenerateIsolatedAudioRequest && generateIsolatedAudioRequest != null)
            {
                return generateIsolatedAudioRequest(GenerateIsolatedAudioRequest!);
            }
            else if (IsGenerateSpeechToRequest && generateSpeechToRequest != null)
            {
                return generateSpeechToRequest(GenerateSpeechToRequest!);
            }
            else if (IsGenerateVoiceCloneRequest && generateVoiceCloneRequest != null)
            {
                return generateVoiceCloneRequest(GenerateVoiceCloneRequest!);
            }
            else if (IsGenerateAudioFromVideoRequest && generateAudioFromVideoRequest != null)
            {
                return generateAudioFromVideoRequest(GenerateAudioFromVideoRequest!);
            }
            else if (IsGenerateVideoWithAudioRequest && generateVideoWithAudioRequest != null)
            {
                return generateVideoWithAudioRequest(GenerateVideoWithAudioRequest!);
            }
            else if (IsGenerateVideoToRequest && generateVideoToRequest != null)
            {
                return generateVideoToRequest(GenerateVideoToRequest!);
            }
            else if (IsGenerateMotionControlRequestOutput && generateMotionControlRequestOutput != null)
            {
                return generateMotionControlRequestOutput(GenerateMotionControlRequestOutput!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Hedra.GenerateVideoRequestOutput?>? generateVideoRequestOutput = null,
            global::System.Action<global::Hedra.GenerateTextToSpeechRequest?>? generateTextToSpeechRequest = null,
            global::System.Action<global::Hedra.GenerateTextToSoundRequest?>? generateTextToSoundRequest = null,
            global::System.Action<global::Hedra.GenerateImageRequest?>? generateImageRequest = null,
            global::System.Action<global::Hedra.GenerateImageUpscaleRequest?>? generateImageUpscaleRequest = null,
            global::System.Action<global::Hedra.GenerateVideoUpscaleRequest?>? generateVideoUpscaleRequest = null,
            global::System.Action<global::Hedra.GenerateIsolatedAudioRequest?>? generateIsolatedAudioRequest = null,
            global::System.Action<global::Hedra.GenerateSpeechToSpeechRequest?>? generateSpeechToRequest = null,
            global::System.Action<global::Hedra.GenerateVoiceCloneRequest?>? generateVoiceCloneRequest = null,
            global::System.Action<global::Hedra.GenerateAudioFromVideoRequest?>? generateAudioFromVideoRequest = null,
            global::System.Action<global::Hedra.GenerateVideoWithAudioRequest?>? generateVideoWithAudioRequest = null,
            global::System.Action<global::Hedra.GenerateVideoToVideoRequest?>? generateVideoToRequest = null,
            global::System.Action<global::Hedra.GenerateMotionControlRequestOutput?>? generateMotionControlRequestOutput = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsGenerateVideoRequestOutput)
            {
                generateVideoRequestOutput?.Invoke(GenerateVideoRequestOutput!);
            }
            else if (IsGenerateTextToSpeechRequest)
            {
                generateTextToSpeechRequest?.Invoke(GenerateTextToSpeechRequest!);
            }
            else if (IsGenerateTextToSoundRequest)
            {
                generateTextToSoundRequest?.Invoke(GenerateTextToSoundRequest!);
            }
            else if (IsGenerateImageRequest)
            {
                generateImageRequest?.Invoke(GenerateImageRequest!);
            }
            else if (IsGenerateImageUpscaleRequest)
            {
                generateImageUpscaleRequest?.Invoke(GenerateImageUpscaleRequest!);
            }
            else if (IsGenerateVideoUpscaleRequest)
            {
                generateVideoUpscaleRequest?.Invoke(GenerateVideoUpscaleRequest!);
            }
            else if (IsGenerateIsolatedAudioRequest)
            {
                generateIsolatedAudioRequest?.Invoke(GenerateIsolatedAudioRequest!);
            }
            else if (IsGenerateSpeechToRequest)
            {
                generateSpeechToRequest?.Invoke(GenerateSpeechToRequest!);
            }
            else if (IsGenerateVoiceCloneRequest)
            {
                generateVoiceCloneRequest?.Invoke(GenerateVoiceCloneRequest!);
            }
            else if (IsGenerateAudioFromVideoRequest)
            {
                generateAudioFromVideoRequest?.Invoke(GenerateAudioFromVideoRequest!);
            }
            else if (IsGenerateVideoWithAudioRequest)
            {
                generateVideoWithAudioRequest?.Invoke(GenerateVideoWithAudioRequest!);
            }
            else if (IsGenerateVideoToRequest)
            {
                generateVideoToRequest?.Invoke(GenerateVideoToRequest!);
            }
            else if (IsGenerateMotionControlRequestOutput)
            {
                generateMotionControlRequestOutput?.Invoke(GenerateMotionControlRequestOutput!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                GenerateVideoRequestOutput,
                typeof(global::Hedra.GenerateVideoRequestOutput),
                GenerateTextToSpeechRequest,
                typeof(global::Hedra.GenerateTextToSpeechRequest),
                GenerateTextToSoundRequest,
                typeof(global::Hedra.GenerateTextToSoundRequest),
                GenerateImageRequest,
                typeof(global::Hedra.GenerateImageRequest),
                GenerateImageUpscaleRequest,
                typeof(global::Hedra.GenerateImageUpscaleRequest),
                GenerateVideoUpscaleRequest,
                typeof(global::Hedra.GenerateVideoUpscaleRequest),
                GenerateIsolatedAudioRequest,
                typeof(global::Hedra.GenerateIsolatedAudioRequest),
                GenerateSpeechToRequest,
                typeof(global::Hedra.GenerateSpeechToSpeechRequest),
                GenerateVoiceCloneRequest,
                typeof(global::Hedra.GenerateVoiceCloneRequest),
                GenerateAudioFromVideoRequest,
                typeof(global::Hedra.GenerateAudioFromVideoRequest),
                GenerateVideoWithAudioRequest,
                typeof(global::Hedra.GenerateVideoWithAudioRequest),
                GenerateVideoToRequest,
                typeof(global::Hedra.GenerateVideoToVideoRequest),
                GenerateMotionControlRequestOutput,
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
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateVideoRequestOutput?>.Default.Equals(GenerateVideoRequestOutput, other.GenerateVideoRequestOutput) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateTextToSpeechRequest?>.Default.Equals(GenerateTextToSpeechRequest, other.GenerateTextToSpeechRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateTextToSoundRequest?>.Default.Equals(GenerateTextToSoundRequest, other.GenerateTextToSoundRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateImageRequest?>.Default.Equals(GenerateImageRequest, other.GenerateImageRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateImageUpscaleRequest?>.Default.Equals(GenerateImageUpscaleRequest, other.GenerateImageUpscaleRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateVideoUpscaleRequest?>.Default.Equals(GenerateVideoUpscaleRequest, other.GenerateVideoUpscaleRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateIsolatedAudioRequest?>.Default.Equals(GenerateIsolatedAudioRequest, other.GenerateIsolatedAudioRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateSpeechToSpeechRequest?>.Default.Equals(GenerateSpeechToRequest, other.GenerateSpeechToRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateVoiceCloneRequest?>.Default.Equals(GenerateVoiceCloneRequest, other.GenerateVoiceCloneRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateAudioFromVideoRequest?>.Default.Equals(GenerateAudioFromVideoRequest, other.GenerateAudioFromVideoRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateVideoWithAudioRequest?>.Default.Equals(GenerateVideoWithAudioRequest, other.GenerateVideoWithAudioRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateVideoToVideoRequest?>.Default.Equals(GenerateVideoToRequest, other.GenerateVideoToRequest) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GenerateMotionControlRequestOutput?>.Default.Equals(GenerateMotionControlRequestOutput, other.GenerateMotionControlRequestOutput) 
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
