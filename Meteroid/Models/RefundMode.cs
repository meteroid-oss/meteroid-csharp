// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// How a voluntary refund was issued: through the provider, or recorded after a wire or cash
/// movement made outside Meteroid.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<RefundMode>))]
public readonly partial record struct RefundMode(string Value) : IStringEnum<RefundMode>
{
    /// <summary><c>ONLINE</c></summary>
    public static RefundMode Online { get; } = new("ONLINE");

    /// <summary><c>OFFLINE</c></summary>
    public static RefundMode Offline { get; } = new("OFFLINE");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "ONLINE" or "OFFLINE";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>ONLINE</c></summary>
        public const string Online = "ONLINE";

        /// <summary><c>OFFLINE</c></summary>
        public const string Offline = "OFFLINE";
    }

    static RefundMode IStringEnum<RefundMode>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator RefundMode(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
