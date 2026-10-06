// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<SubscriptionActivationConditionEnum>))]
public readonly partial record struct SubscriptionActivationConditionEnum(string Value)
    : IStringEnum<SubscriptionActivationConditionEnum>
{
    /// <summary><c>ON_START</c></summary>
    public static SubscriptionActivationConditionEnum OnStart { get; } = new("ON_START");

    /// <summary><c>ON_CHECKOUT</c></summary>
    public static SubscriptionActivationConditionEnum OnCheckout { get; } = new("ON_CHECKOUT");

    /// <summary><c>MANUAL</c></summary>
    public static SubscriptionActivationConditionEnum Manual { get; } = new("MANUAL");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "ON_START" or "ON_CHECKOUT" or "MANUAL";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>ON_START</c></summary>
        public const string OnStart = "ON_START";

        /// <summary><c>ON_CHECKOUT</c></summary>
        public const string OnCheckout = "ON_CHECKOUT";

        /// <summary><c>MANUAL</c></summary>
        public const string Manual = "MANUAL";
    }

    static SubscriptionActivationConditionEnum IStringEnum<SubscriptionActivationConditionEnum>.FromValue(
        string value
    ) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator SubscriptionActivationConditionEnum(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
