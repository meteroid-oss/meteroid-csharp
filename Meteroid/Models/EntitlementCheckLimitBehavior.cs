// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<EntitlementCheckLimitBehavior>))]
public readonly partial record struct EntitlementCheckLimitBehavior(string Value)
    : IStringEnum<EntitlementCheckLimitBehavior>
{
    /// <summary><c>TRACK</c></summary>
    public static EntitlementCheckLimitBehavior Track { get; } = new("TRACK");

    /// <summary><c>SOFT</c></summary>
    public static EntitlementCheckLimitBehavior Soft { get; } = new("SOFT");

    /// <summary><c>HARD</c></summary>
    public static EntitlementCheckLimitBehavior Hard { get; } = new("HARD");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "TRACK" or "SOFT" or "HARD";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>TRACK</c></summary>
        public const string Track = "TRACK";

        /// <summary><c>SOFT</c></summary>
        public const string Soft = "SOFT";

        /// <summary><c>HARD</c></summary>
        public const string Hard = "HARD";
    }

    static EntitlementCheckLimitBehavior IStringEnum<EntitlementCheckLimitBehavior>.FromValue(string value) =>
        new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator EntitlementCheckLimitBehavior(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
