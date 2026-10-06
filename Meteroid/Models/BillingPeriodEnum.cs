// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<BillingPeriodEnum>))]
public readonly partial record struct BillingPeriodEnum(string Value) : IStringEnum<BillingPeriodEnum>
{
    /// <summary><c>MONTHLY</c></summary>
    public static BillingPeriodEnum Monthly { get; } = new("MONTHLY");

    /// <summary><c>QUARTERLY</c></summary>
    public static BillingPeriodEnum Quarterly { get; } = new("QUARTERLY");

    /// <summary><c>SEMIANNUAL</c></summary>
    public static BillingPeriodEnum Semiannual { get; } = new("SEMIANNUAL");

    /// <summary><c>ANNUAL</c></summary>
    public static BillingPeriodEnum Annual { get; } = new("ANNUAL");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "MONTHLY" or "QUARTERLY" or "SEMIANNUAL" or "ANNUAL";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>MONTHLY</c></summary>
        public const string Monthly = "MONTHLY";

        /// <summary><c>QUARTERLY</c></summary>
        public const string Quarterly = "QUARTERLY";

        /// <summary><c>SEMIANNUAL</c></summary>
        public const string Semiannual = "SEMIANNUAL";

        /// <summary><c>ANNUAL</c></summary>
        public const string Annual = "ANNUAL";
    }

    static BillingPeriodEnum IStringEnum<BillingPeriodEnum>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator BillingPeriodEnum(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
