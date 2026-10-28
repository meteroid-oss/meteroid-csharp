// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<CreditExpiryUnit>))]
public readonly partial record struct CreditExpiryUnit(string Value) : IStringEnum<CreditExpiryUnit>
{
    /// <summary><c>DAY</c></summary>
    public static CreditExpiryUnit Day { get; } = new("DAY");

    /// <summary><c>MONTH</c></summary>
    public static CreditExpiryUnit Month { get; } = new("MONTH");

    /// <summary><c>BILLING_PERIOD</c></summary>
    public static CreditExpiryUnit BillingPeriod { get; } = new("BILLING_PERIOD");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "DAY" or "MONTH" or "BILLING_PERIOD";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>DAY</c></summary>
        public const string Day = "DAY";

        /// <summary><c>MONTH</c></summary>
        public const string Month = "MONTH";

        /// <summary><c>BILLING_PERIOD</c></summary>
        public const string BillingPeriod = "BILLING_PERIOD";
    }

    static CreditExpiryUnit IStringEnum<CreditExpiryUnit>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator CreditExpiryUnit(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
