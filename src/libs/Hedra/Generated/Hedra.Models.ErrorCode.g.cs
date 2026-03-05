
#nullable enable

namespace Hedra
{
    /// <summary>
    /// Universal error code space. Modeled after gRPC status codes.<br/>
    /// Every exception in the system carries an ErrorCode. SDK clients map<br/>
    /// 3rd-party errors to these codes at the lowest level. Retry logic,<br/>
    /// HTTP status mapping, and OTEL metrics all key off this enum.<br/>
    /// NOTE: The semantic meaning of these error codes is roughly mapped from the<br/>
    ///     semantic of the gRPC status codes: see<br/>
    ///     https://grpc.io/docs/guides/status-codes/ for details.
    /// </summary>
    public enum ErrorCode
    {
        /// <summary>
        /// 
        /// </summary>
        Unknown,
        /// <summary>
        /// 
        /// </summary>
        InvalidArgument,
        /// <summary>
        /// 
        /// </summary>
        NotFound,
        /// <summary>
        /// 
        /// </summary>
        AlreadyExists,
        /// <summary>
        /// 
        /// </summary>
        PermissionDenied,
        /// <summary>
        /// 
        /// </summary>
        MissingCredits,
        /// <summary>
        /// 
        /// </summary>
        ModerationFailed,
        /// <summary>
        /// 
        /// </summary>
        FailedPrecondition,
        /// <summary>
        /// 
        /// </summary>
        DeadlineExceeded,
        /// <summary>
        /// 
        /// </summary>
        ResourceExhausted,
        /// <summary>
        /// 
        /// </summary>
        Unavailable,
        /// <summary>
        /// 
        /// </summary>
        Internal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ErrorCodeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ErrorCode value)
        {
            return value switch
            {
                ErrorCode.Unknown => "UNKNOWN",
                ErrorCode.InvalidArgument => "INVALID_ARGUMENT",
                ErrorCode.NotFound => "NOT_FOUND",
                ErrorCode.AlreadyExists => "ALREADY_EXISTS",
                ErrorCode.PermissionDenied => "PERMISSION_DENIED",
                ErrorCode.MissingCredits => "MISSING_CREDITS",
                ErrorCode.ModerationFailed => "MODERATION_FAILED",
                ErrorCode.FailedPrecondition => "FAILED_PRECONDITION",
                ErrorCode.DeadlineExceeded => "DEADLINE_EXCEEDED",
                ErrorCode.ResourceExhausted => "RESOURCE_EXHAUSTED",
                ErrorCode.Unavailable => "UNAVAILABLE",
                ErrorCode.Internal => "INTERNAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ErrorCode? ToEnum(string value)
        {
            return value switch
            {
                "UNKNOWN" => ErrorCode.Unknown,
                "INVALID_ARGUMENT" => ErrorCode.InvalidArgument,
                "NOT_FOUND" => ErrorCode.NotFound,
                "ALREADY_EXISTS" => ErrorCode.AlreadyExists,
                "PERMISSION_DENIED" => ErrorCode.PermissionDenied,
                "MISSING_CREDITS" => ErrorCode.MissingCredits,
                "MODERATION_FAILED" => ErrorCode.ModerationFailed,
                "FAILED_PRECONDITION" => ErrorCode.FailedPrecondition,
                "DEADLINE_EXCEEDED" => ErrorCode.DeadlineExceeded,
                "RESOURCE_EXHAUSTED" => ErrorCode.ResourceExhausted,
                "UNAVAILABLE" => ErrorCode.Unavailable,
                "INTERNAL" => ErrorCode.Internal,
                _ => null,
            };
        }
    }
}