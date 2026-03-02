
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
        UNKNOWN,
        /// <summary>
        /// 
        /// </summary>
        INVALIDARGUMENT,
        /// <summary>
        /// 
        /// </summary>
        NOTFOUND,
        /// <summary>
        /// 
        /// </summary>
        ALREADYEXISTS,
        /// <summary>
        /// 
        /// </summary>
        PERMISSIONDENIED,
        /// <summary>
        /// 
        /// </summary>
        MISSINGCREDITS,
        /// <summary>
        /// 
        /// </summary>
        MODERATIONFAILED,
        /// <summary>
        /// 
        /// </summary>
        FAILEDPRECONDITION,
        /// <summary>
        /// 
        /// </summary>
        DEADLINEEXCEEDED,
        /// <summary>
        /// 
        /// </summary>
        RESOURCEEXHAUSTED,
        /// <summary>
        /// 
        /// </summary>
        UNAVAILABLE,
        /// <summary>
        /// 
        /// </summary>
        INTERNAL,
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
                ErrorCode.UNKNOWN => "UNKNOWN",
                ErrorCode.INVALIDARGUMENT => "INVALID_ARGUMENT",
                ErrorCode.NOTFOUND => "NOT_FOUND",
                ErrorCode.ALREADYEXISTS => "ALREADY_EXISTS",
                ErrorCode.PERMISSIONDENIED => "PERMISSION_DENIED",
                ErrorCode.MISSINGCREDITS => "MISSING_CREDITS",
                ErrorCode.MODERATIONFAILED => "MODERATION_FAILED",
                ErrorCode.FAILEDPRECONDITION => "FAILED_PRECONDITION",
                ErrorCode.DEADLINEEXCEEDED => "DEADLINE_EXCEEDED",
                ErrorCode.RESOURCEEXHAUSTED => "RESOURCE_EXHAUSTED",
                ErrorCode.UNAVAILABLE => "UNAVAILABLE",
                ErrorCode.INTERNAL => "INTERNAL",
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
                "UNKNOWN" => ErrorCode.UNKNOWN,
                "INVALID_ARGUMENT" => ErrorCode.INVALIDARGUMENT,
                "NOT_FOUND" => ErrorCode.NOTFOUND,
                "ALREADY_EXISTS" => ErrorCode.ALREADYEXISTS,
                "PERMISSION_DENIED" => ErrorCode.PERMISSIONDENIED,
                "MISSING_CREDITS" => ErrorCode.MISSINGCREDITS,
                "MODERATION_FAILED" => ErrorCode.MODERATIONFAILED,
                "FAILED_PRECONDITION" => ErrorCode.FAILEDPRECONDITION,
                "DEADLINE_EXCEEDED" => ErrorCode.DEADLINEEXCEEDED,
                "RESOURCE_EXHAUSTED" => ErrorCode.RESOURCEEXHAUSTED,
                "UNAVAILABLE" => ErrorCode.UNAVAILABLE,
                "INTERNAL" => ErrorCode.INTERNAL,
                _ => null,
            };
        }
    }
}