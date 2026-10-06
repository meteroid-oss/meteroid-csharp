// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// OAuth 2.0 error codes as per RFC 6749
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<OAuthErrorCode>))]
public readonly partial record struct OAuthErrorCode(string Value) : IStringEnum<OAuthErrorCode>
{
    /// <summary><c>invalid_request</c></summary>
    public static OAuthErrorCode InvalidRequest { get; } = new("invalid_request");

    /// <summary><c>unauthorized_client</c></summary>
    public static OAuthErrorCode UnauthorizedClient { get; } = new("unauthorized_client");

    /// <summary><c>access_denied</c></summary>
    public static OAuthErrorCode AccessDenied { get; } = new("access_denied");

    /// <summary><c>unsupported_response_type</c></summary>
    public static OAuthErrorCode UnsupportedResponseType { get; } = new("unsupported_response_type");

    /// <summary><c>invalid_scope</c></summary>
    public static OAuthErrorCode InvalidScope { get; } = new("invalid_scope");

    /// <summary><c>server_error</c></summary>
    public static OAuthErrorCode ServerError { get; } = new("server_error");

    /// <summary><c>temporarily_unavailable</c></summary>
    public static OAuthErrorCode TemporarilyUnavailable { get; } = new("temporarily_unavailable");

    /// <summary><c>invalid_grant</c></summary>
    public static OAuthErrorCode InvalidGrant { get; } = new("invalid_grant");

    /// <summary><c>invalid_client</c></summary>
    public static OAuthErrorCode InvalidClient { get; } = new("invalid_client");

    /// <summary><c>unsupported_grant_type</c></summary>
    public static OAuthErrorCode UnsupportedGrantType { get; } = new("unsupported_grant_type");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown =>
        Value
            is "invalid_request"
                or "unauthorized_client"
                or "access_denied"
                or "unsupported_response_type"
                or "invalid_scope"
                or "server_error"
                or "temporarily_unavailable"
                or "invalid_grant"
                or "invalid_client"
                or "unsupported_grant_type";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>invalid_request</c></summary>
        public const string InvalidRequest = "invalid_request";

        /// <summary><c>unauthorized_client</c></summary>
        public const string UnauthorizedClient = "unauthorized_client";

        /// <summary><c>access_denied</c></summary>
        public const string AccessDenied = "access_denied";

        /// <summary><c>unsupported_response_type</c></summary>
        public const string UnsupportedResponseType = "unsupported_response_type";

        /// <summary><c>invalid_scope</c></summary>
        public const string InvalidScope = "invalid_scope";

        /// <summary><c>server_error</c></summary>
        public const string ServerError = "server_error";

        /// <summary><c>temporarily_unavailable</c></summary>
        public const string TemporarilyUnavailable = "temporarily_unavailable";

        /// <summary><c>invalid_grant</c></summary>
        public const string InvalidGrant = "invalid_grant";

        /// <summary><c>invalid_client</c></summary>
        public const string InvalidClient = "invalid_client";

        /// <summary><c>unsupported_grant_type</c></summary>
        public const string UnsupportedGrantType = "unsupported_grant_type";
    }

    static OAuthErrorCode IStringEnum<OAuthErrorCode>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator OAuthErrorCode(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
