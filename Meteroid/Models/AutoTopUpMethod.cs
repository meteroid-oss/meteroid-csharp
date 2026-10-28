// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<AutoTopUpMethod>))]
public readonly partial record struct AutoTopUpMethod(string Value) : IStringEnum<AutoTopUpMethod>
{
    /// <summary><c>FIXED</c></summary>
    public static AutoTopUpMethod Fixed { get; } = new("FIXED");

    /// <summary><c>TO_TARGET</c></summary>
    public static AutoTopUpMethod ToTarget { get; } = new("TO_TARGET");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "FIXED" or "TO_TARGET";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>FIXED</c></summary>
        public const string Fixed = "FIXED";

        /// <summary><c>TO_TARGET</c></summary>
        public const string ToTarget = "TO_TARGET";
    }

    static AutoTopUpMethod IStringEnum<AutoTopUpMethod>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator AutoTopUpMethod(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
