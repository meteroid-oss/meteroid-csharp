// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<ActorType>))]
public readonly partial record struct ActorType(string Value) : IStringEnum<ActorType>
{
    /// <summary><c>USER</c></summary>
    public static ActorType User { get; } = new("USER");

    /// <summary><c>CUSTOMER</c></summary>
    public static ActorType Customer { get; } = new("CUSTOMER");

    /// <summary><c>SYSTEM</c></summary>
    public static ActorType System { get; } = new("SYSTEM");

    /// <summary><c>API_KEY</c></summary>
    public static ActorType ApiKey { get; } = new("API_KEY");

    /// <summary><c>OAUTH_APP</c></summary>
    public static ActorType OauthApp { get; } = new("OAUTH_APP");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "USER" or "CUSTOMER" or "SYSTEM" or "API_KEY" or "OAUTH_APP";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>USER</c></summary>
        public const string User = "USER";

        /// <summary><c>CUSTOMER</c></summary>
        public const string Customer = "CUSTOMER";

        /// <summary><c>SYSTEM</c></summary>
        public const string System = "SYSTEM";

        /// <summary><c>API_KEY</c></summary>
        public const string ApiKey = "API_KEY";

        /// <summary><c>OAUTH_APP</c></summary>
        public const string OauthApp = "OAUTH_APP";
    }

    static ActorType IStringEnum<ActorType>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator ActorType(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
