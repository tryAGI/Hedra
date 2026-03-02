#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Hedra
{
    /// <summary>
    /// The asset itself.
    /// </summary>
    public readonly partial struct Asset1 : global::System.IEquatable<Asset1>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::Hedra.AssetAsset1DiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.UploadedImage? UploadedImage { get; init; }
#else
        public global::Hedra.UploadedImage? UploadedImage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UploadedImage))]
#endif
        public bool IsUploadedImage => UploadedImage != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.UploadedAudio? UploadedAudio { get; init; }
#else
        public global::Hedra.UploadedAudio? UploadedAudio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UploadedAudio))]
#endif
        public bool IsUploadedAudio => UploadedAudio != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.UploadedVideo? UploadedVideo { get; init; }
#else
        public global::Hedra.UploadedVideo? UploadedVideo { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(UploadedVideo))]
#endif
        public bool IsUploadedVideo => UploadedVideo != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GeneratedAudio? GeneratedAudio { get; init; }
#else
        public global::Hedra.GeneratedAudio? GeneratedAudio { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GeneratedAudio))]
#endif
        public bool IsGeneratedAudio => GeneratedAudio != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GeneratedImage? GeneratedImage { get; init; }
#else
        public global::Hedra.GeneratedImage? GeneratedImage { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GeneratedImage))]
#endif
        public bool IsGeneratedImage => GeneratedImage != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.GeneratedVideo? GeneratedVideo { get; init; }
#else
        public global::Hedra.GeneratedVideo? GeneratedVideo { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(GeneratedVideo))]
#endif
        public bool IsGeneratedVideo => GeneratedVideo != null;

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hedra.Voice? Voice { get; init; }
#else
        public global::Hedra.Voice? Voice { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Voice))]
#endif
        public bool IsVoice => Voice != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Asset1(global::Hedra.UploadedImage value) => new Asset1((global::Hedra.UploadedImage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.UploadedImage?(Asset1 @this) => @this.UploadedImage;

        /// <summary>
        /// 
        /// </summary>
        public Asset1(global::Hedra.UploadedImage? value)
        {
            UploadedImage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Asset1(global::Hedra.UploadedAudio value) => new Asset1((global::Hedra.UploadedAudio?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.UploadedAudio?(Asset1 @this) => @this.UploadedAudio;

        /// <summary>
        /// 
        /// </summary>
        public Asset1(global::Hedra.UploadedAudio? value)
        {
            UploadedAudio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Asset1(global::Hedra.UploadedVideo value) => new Asset1((global::Hedra.UploadedVideo?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.UploadedVideo?(Asset1 @this) => @this.UploadedVideo;

        /// <summary>
        /// 
        /// </summary>
        public Asset1(global::Hedra.UploadedVideo? value)
        {
            UploadedVideo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Asset1(global::Hedra.GeneratedAudio value) => new Asset1((global::Hedra.GeneratedAudio?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GeneratedAudio?(Asset1 @this) => @this.GeneratedAudio;

        /// <summary>
        /// 
        /// </summary>
        public Asset1(global::Hedra.GeneratedAudio? value)
        {
            GeneratedAudio = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Asset1(global::Hedra.GeneratedImage value) => new Asset1((global::Hedra.GeneratedImage?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GeneratedImage?(Asset1 @this) => @this.GeneratedImage;

        /// <summary>
        /// 
        /// </summary>
        public Asset1(global::Hedra.GeneratedImage? value)
        {
            GeneratedImage = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Asset1(global::Hedra.GeneratedVideo value) => new Asset1((global::Hedra.GeneratedVideo?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.GeneratedVideo?(Asset1 @this) => @this.GeneratedVideo;

        /// <summary>
        /// 
        /// </summary>
        public Asset1(global::Hedra.GeneratedVideo? value)
        {
            GeneratedVideo = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator Asset1(global::Hedra.Voice value) => new Asset1((global::Hedra.Voice?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hedra.Voice?(Asset1 @this) => @this.Voice;

        /// <summary>
        /// 
        /// </summary>
        public Asset1(global::Hedra.Voice? value)
        {
            Voice = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public Asset1(
            global::Hedra.AssetAsset1DiscriminatorType? type,
            global::Hedra.UploadedImage? uploadedImage,
            global::Hedra.UploadedAudio? uploadedAudio,
            global::Hedra.UploadedVideo? uploadedVideo,
            global::Hedra.GeneratedAudio? generatedAudio,
            global::Hedra.GeneratedImage? generatedImage,
            global::Hedra.GeneratedVideo? generatedVideo,
            global::Hedra.Voice? voice
            )
        {
            Type = type;

            UploadedImage = uploadedImage;
            UploadedAudio = uploadedAudio;
            UploadedVideo = uploadedVideo;
            GeneratedAudio = generatedAudio;
            GeneratedImage = generatedImage;
            GeneratedVideo = generatedVideo;
            Voice = voice;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            Voice as object ??
            GeneratedVideo as object ??
            GeneratedImage as object ??
            GeneratedAudio as object ??
            UploadedVideo as object ??
            UploadedAudio as object ??
            UploadedImage as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            UploadedImage?.ToString() ??
            UploadedAudio?.ToString() ??
            UploadedVideo?.ToString() ??
            GeneratedAudio?.ToString() ??
            GeneratedImage?.ToString() ??
            GeneratedVideo?.ToString() ??
            Voice?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsUploadedImage && !IsUploadedAudio && !IsUploadedVideo && !IsGeneratedAudio && !IsGeneratedImage && !IsGeneratedVideo && !IsVoice || !IsUploadedImage && IsUploadedAudio && !IsUploadedVideo && !IsGeneratedAudio && !IsGeneratedImage && !IsGeneratedVideo && !IsVoice || !IsUploadedImage && !IsUploadedAudio && IsUploadedVideo && !IsGeneratedAudio && !IsGeneratedImage && !IsGeneratedVideo && !IsVoice || !IsUploadedImage && !IsUploadedAudio && !IsUploadedVideo && IsGeneratedAudio && !IsGeneratedImage && !IsGeneratedVideo && !IsVoice || !IsUploadedImage && !IsUploadedAudio && !IsUploadedVideo && !IsGeneratedAudio && IsGeneratedImage && !IsGeneratedVideo && !IsVoice || !IsUploadedImage && !IsUploadedAudio && !IsUploadedVideo && !IsGeneratedAudio && !IsGeneratedImage && IsGeneratedVideo && !IsVoice || !IsUploadedImage && !IsUploadedAudio && !IsUploadedVideo && !IsGeneratedAudio && !IsGeneratedImage && !IsGeneratedVideo && IsVoice;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Hedra.UploadedImage?, TResult>? uploadedImage = null,
            global::System.Func<global::Hedra.UploadedAudio?, TResult>? uploadedAudio = null,
            global::System.Func<global::Hedra.UploadedVideo?, TResult>? uploadedVideo = null,
            global::System.Func<global::Hedra.GeneratedAudio?, TResult>? generatedAudio = null,
            global::System.Func<global::Hedra.GeneratedImage?, TResult>? generatedImage = null,
            global::System.Func<global::Hedra.GeneratedVideo?, TResult>? generatedVideo = null,
            global::System.Func<global::Hedra.Voice?, TResult>? voice = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUploadedImage && uploadedImage != null)
            {
                return uploadedImage(UploadedImage!);
            }
            else if (IsUploadedAudio && uploadedAudio != null)
            {
                return uploadedAudio(UploadedAudio!);
            }
            else if (IsUploadedVideo && uploadedVideo != null)
            {
                return uploadedVideo(UploadedVideo!);
            }
            else if (IsGeneratedAudio && generatedAudio != null)
            {
                return generatedAudio(GeneratedAudio!);
            }
            else if (IsGeneratedImage && generatedImage != null)
            {
                return generatedImage(GeneratedImage!);
            }
            else if (IsGeneratedVideo && generatedVideo != null)
            {
                return generatedVideo(GeneratedVideo!);
            }
            else if (IsVoice && voice != null)
            {
                return voice(Voice!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Hedra.UploadedImage?>? uploadedImage = null,
            global::System.Action<global::Hedra.UploadedAudio?>? uploadedAudio = null,
            global::System.Action<global::Hedra.UploadedVideo?>? uploadedVideo = null,
            global::System.Action<global::Hedra.GeneratedAudio?>? generatedAudio = null,
            global::System.Action<global::Hedra.GeneratedImage?>? generatedImage = null,
            global::System.Action<global::Hedra.GeneratedVideo?>? generatedVideo = null,
            global::System.Action<global::Hedra.Voice?>? voice = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsUploadedImage)
            {
                uploadedImage?.Invoke(UploadedImage!);
            }
            else if (IsUploadedAudio)
            {
                uploadedAudio?.Invoke(UploadedAudio!);
            }
            else if (IsUploadedVideo)
            {
                uploadedVideo?.Invoke(UploadedVideo!);
            }
            else if (IsGeneratedAudio)
            {
                generatedAudio?.Invoke(GeneratedAudio!);
            }
            else if (IsGeneratedImage)
            {
                generatedImage?.Invoke(GeneratedImage!);
            }
            else if (IsGeneratedVideo)
            {
                generatedVideo?.Invoke(GeneratedVideo!);
            }
            else if (IsVoice)
            {
                voice?.Invoke(Voice!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                UploadedImage,
                typeof(global::Hedra.UploadedImage),
                UploadedAudio,
                typeof(global::Hedra.UploadedAudio),
                UploadedVideo,
                typeof(global::Hedra.UploadedVideo),
                GeneratedAudio,
                typeof(global::Hedra.GeneratedAudio),
                GeneratedImage,
                typeof(global::Hedra.GeneratedImage),
                GeneratedVideo,
                typeof(global::Hedra.GeneratedVideo),
                Voice,
                typeof(global::Hedra.Voice),
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
        public bool Equals(Asset1 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Hedra.UploadedImage?>.Default.Equals(UploadedImage, other.UploadedImage) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.UploadedAudio?>.Default.Equals(UploadedAudio, other.UploadedAudio) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.UploadedVideo?>.Default.Equals(UploadedVideo, other.UploadedVideo) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GeneratedAudio?>.Default.Equals(GeneratedAudio, other.GeneratedAudio) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GeneratedImage?>.Default.Equals(GeneratedImage, other.GeneratedImage) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.GeneratedVideo?>.Default.Equals(GeneratedVideo, other.GeneratedVideo) &&
                global::System.Collections.Generic.EqualityComparer<global::Hedra.Voice?>.Default.Equals(Voice, other.Voice) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(Asset1 obj1, Asset1 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<Asset1>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(Asset1 obj1, Asset1 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is Asset1 o && Equals(o);
        }
    }
}
