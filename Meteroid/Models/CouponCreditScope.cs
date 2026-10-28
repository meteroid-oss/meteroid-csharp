// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// Which subscriptions a promotional credit coupon's credit pays.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<CouponCreditScope>))]
public readonly partial record struct CouponCreditScope(string Value) : IStringEnum<CouponCreditScope>
{
    /// <summary><c>CUSTOMER</c></summary>
    public static CouponCreditScope Customer { get; } = new("CUSTOMER");

    /// <summary><c>SUBSCRIPTION</c></summary>
    public static CouponCreditScope Subscription { get; } = new("SUBSCRIPTION");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "CUSTOMER" or "SUBSCRIPTION";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>CUSTOMER</c></summary>
        public const string Customer = "CUSTOMER";

        /// <summary><c>SUBSCRIPTION</c></summary>
        public const string Subscription = "SUBSCRIPTION";
    }

    static CouponCreditScope IStringEnum<CouponCreditScope>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator CouponCreditScope(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
