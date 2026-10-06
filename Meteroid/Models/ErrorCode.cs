// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<ErrorCode>))]
public readonly partial record struct ErrorCode(string Value) : IStringEnum<ErrorCode>
{
    /// <summary><c>BAD_REQUEST</c></summary>
    public static ErrorCode BadRequest { get; } = new("BAD_REQUEST");

    /// <summary><c>NOT_FOUND</c></summary>
    public static ErrorCode NotFound { get; } = new("NOT_FOUND");

    /// <summary><c>CONFLICT</c></summary>
    public static ErrorCode Conflict { get; } = new("CONFLICT");

    /// <summary><c>FORBIDDEN</c></summary>
    public static ErrorCode Forbidden { get; } = new("FORBIDDEN");

    /// <summary><c>UNAUTHORIZED</c></summary>
    public static ErrorCode Unauthorized { get; } = new("UNAUTHORIZED");

    /// <summary><c>TOKEN_EXPIRED</c></summary>
    public static ErrorCode TokenExpired { get; } = new("TOKEN_EXPIRED");

    /// <summary><c>TOO_MANY_REQUESTS</c></summary>
    public static ErrorCode TooManyRequests { get; } = new("TOO_MANY_REQUESTS");

    /// <summary><c>INTERNAL_SERVER_ERROR</c></summary>
    public static ErrorCode InternalServerError { get; } = new("INTERNAL_SERVER_ERROR");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown =>
        Value
            is "BAD_REQUEST"
                or "NOT_FOUND"
                or "CONFLICT"
                or "FORBIDDEN"
                or "UNAUTHORIZED"
                or "TOKEN_EXPIRED"
                or "TOO_MANY_REQUESTS"
                or "INTERNAL_SERVER_ERROR";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>BAD_REQUEST</c></summary>
        public const string BadRequest = "BAD_REQUEST";

        /// <summary><c>NOT_FOUND</c></summary>
        public const string NotFound = "NOT_FOUND";

        /// <summary><c>CONFLICT</c></summary>
        public const string Conflict = "CONFLICT";

        /// <summary><c>FORBIDDEN</c></summary>
        public const string Forbidden = "FORBIDDEN";

        /// <summary><c>UNAUTHORIZED</c></summary>
        public const string Unauthorized = "UNAUTHORIZED";

        /// <summary><c>TOKEN_EXPIRED</c></summary>
        public const string TokenExpired = "TOKEN_EXPIRED";

        /// <summary><c>TOO_MANY_REQUESTS</c></summary>
        public const string TooManyRequests = "TOO_MANY_REQUESTS";

        /// <summary><c>INTERNAL_SERVER_ERROR</c></summary>
        public const string InternalServerError = "INTERNAL_SERVER_ERROR";
    }

    static ErrorCode IStringEnum<ErrorCode>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator ErrorCode(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
