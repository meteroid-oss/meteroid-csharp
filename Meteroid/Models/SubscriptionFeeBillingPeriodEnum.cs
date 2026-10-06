// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<SubscriptionFeeBillingPeriodEnum>))]
public readonly partial record struct SubscriptionFeeBillingPeriodEnum(string Value)
    : IStringEnum<SubscriptionFeeBillingPeriodEnum>
{
    /// <summary><c>ONE_TIME</c></summary>
    public static SubscriptionFeeBillingPeriodEnum OneTime { get; } = new("ONE_TIME");

    /// <summary><c>MONTHLY</c></summary>
    public static SubscriptionFeeBillingPeriodEnum Monthly { get; } = new("MONTHLY");

    /// <summary><c>QUARTERLY</c></summary>
    public static SubscriptionFeeBillingPeriodEnum Quarterly { get; } = new("QUARTERLY");

    /// <summary><c>SEMIANNUAL</c></summary>
    public static SubscriptionFeeBillingPeriodEnum Semiannual { get; } = new("SEMIANNUAL");

    /// <summary><c>ANNUAL</c></summary>
    public static SubscriptionFeeBillingPeriodEnum Annual { get; } = new("ANNUAL");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "ONE_TIME" or "MONTHLY" or "QUARTERLY" or "SEMIANNUAL" or "ANNUAL";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>ONE_TIME</c></summary>
        public const string OneTime = "ONE_TIME";

        /// <summary><c>MONTHLY</c></summary>
        public const string Monthly = "MONTHLY";

        /// <summary><c>QUARTERLY</c></summary>
        public const string Quarterly = "QUARTERLY";

        /// <summary><c>SEMIANNUAL</c></summary>
        public const string Semiannual = "SEMIANNUAL";

        /// <summary><c>ANNUAL</c></summary>
        public const string Annual = "ANNUAL";
    }

    static SubscriptionFeeBillingPeriodEnum IStringEnum<SubscriptionFeeBillingPeriodEnum>.FromValue(string value) =>
        new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator SubscriptionFeeBillingPeriodEnum(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
