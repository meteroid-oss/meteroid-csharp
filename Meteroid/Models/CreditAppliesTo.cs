// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// Which charges credit pays: ALL pays any part of an invoice, USAGE only its usage charges.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<CreditAppliesTo>))]
public readonly partial record struct CreditAppliesTo(string Value) : IStringEnum<CreditAppliesTo>
{
    /// <summary><c>ALL</c></summary>
    public static CreditAppliesTo All { get; } = new("ALL");

    /// <summary><c>USAGE</c></summary>
    public static CreditAppliesTo Usage { get; } = new("USAGE");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "ALL" or "USAGE";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>ALL</c></summary>
        public const string All = "ALL";

        /// <summary><c>USAGE</c></summary>
        public const string Usage = "USAGE";
    }

    static CreditAppliesTo IStringEnum<CreditAppliesTo>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator CreditAppliesTo(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
