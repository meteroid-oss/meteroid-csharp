// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<AutoTopUpStatus>))]
public readonly partial record struct AutoTopUpStatus(string Value) : IStringEnum<AutoTopUpStatus>
{
    /// <summary><c>ACTIVE</c></summary>
    public static AutoTopUpStatus Active { get; } = new("ACTIVE");

    /// <summary><c>DISABLED</c></summary>
    public static AutoTopUpStatus Disabled { get; } = new("DISABLED");

    /// <summary><c>SUSPENDED</c></summary>
    public static AutoTopUpStatus Suspended { get; } = new("SUSPENDED");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "ACTIVE" or "DISABLED" or "SUSPENDED";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>ACTIVE</c></summary>
        public const string Active = "ACTIVE";

        /// <summary><c>DISABLED</c></summary>
        public const string Disabled = "DISABLED";

        /// <summary><c>SUSPENDED</c></summary>
        public const string Suspended = "SUSPENDED";
    }

    static AutoTopUpStatus IStringEnum<AutoTopUpStatus>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator AutoTopUpStatus(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
