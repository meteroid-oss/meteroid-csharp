// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// Status of a connected account
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<ConnectionStatus>))]
public readonly partial record struct ConnectionStatus(string Value) : IStringEnum<ConnectionStatus>
{
    /// <summary><c>pending</c></summary>
    public static ConnectionStatus Pending { get; } = new("pending");

    /// <summary><c>active</c></summary>
    public static ConnectionStatus Active { get; } = new("active");

    /// <summary><c>revoked</c></summary>
    public static ConnectionStatus Revoked { get; } = new("revoked");

    /// <summary><c>suspended</c></summary>
    public static ConnectionStatus Suspended { get; } = new("suspended");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "pending" or "active" or "revoked" or "suspended";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>pending</c></summary>
        public const string Pending = "pending";

        /// <summary><c>active</c></summary>
        public const string Active = "active";

        /// <summary><c>revoked</c></summary>
        public const string Revoked = "revoked";

        /// <summary><c>suspended</c></summary>
        public const string Suspended = "suspended";
    }

    static ConnectionStatus IStringEnum<ConnectionStatus>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator ConnectionStatus(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
