// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// What a cost is counted in.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<UsageCostUnit>))]
public readonly partial record struct UsageCostUnit(string Value) : IStringEnum<UsageCostUnit>
{
    /// <summary><c>CURRENCY</c></summary>
    public static UsageCostUnit Currency { get; } = new("CURRENCY");

    /// <summary><c>CREDIT_UNIT</c></summary>
    public static UsageCostUnit CreditUnit { get; } = new("CREDIT_UNIT");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "CURRENCY" or "CREDIT_UNIT";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>CURRENCY</c></summary>
        public const string Currency = "CURRENCY";

        /// <summary><c>CREDIT_UNIT</c></summary>
        public const string CreditUnit = "CREDIT_UNIT";
    }

    static UsageCostUnit IStringEnum<UsageCostUnit>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator UsageCostUnit(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
