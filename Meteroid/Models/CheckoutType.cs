// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<CheckoutType>))]
public readonly partial record struct CheckoutType(string Value) : IStringEnum<CheckoutType>
{
    /// <summary><c>SELF_SERVE</c></summary>
    public static CheckoutType SelfServe { get; } = new("SELF_SERVE");

    /// <summary><c>SUBSCRIPTION_ACTIVATION</c></summary>
    public static CheckoutType SubscriptionActivation { get; } = new("SUBSCRIPTION_ACTIVATION");

    /// <summary><c>PLAN_CHANGE</c></summary>
    public static CheckoutType PlanChange { get; } = new("PLAN_CHANGE");

    /// <summary><c>ADDON_PURCHASE</c></summary>
    public static CheckoutType AddonPurchase { get; } = new("ADDON_PURCHASE");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "SELF_SERVE" or "SUBSCRIPTION_ACTIVATION" or "PLAN_CHANGE" or "ADDON_PURCHASE";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>SELF_SERVE</c></summary>
        public const string SelfServe = "SELF_SERVE";

        /// <summary><c>SUBSCRIPTION_ACTIVATION</c></summary>
        public const string SubscriptionActivation = "SUBSCRIPTION_ACTIVATION";

        /// <summary><c>PLAN_CHANGE</c></summary>
        public const string PlanChange = "PLAN_CHANGE";

        /// <summary><c>ADDON_PURCHASE</c></summary>
        public const string AddonPurchase = "ADDON_PURCHASE";
    }

    static CheckoutType IStringEnum<CheckoutType>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator CheckoutType(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
