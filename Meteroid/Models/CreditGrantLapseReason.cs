// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// Why a credit grant's unspent credit lapsed.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<CreditGrantLapseReason>))]
public readonly partial record struct CreditGrantLapseReason(string Value) : IStringEnum<CreditGrantLapseReason>
{
    /// <summary><c>EXPIRED</c></summary>
    public static CreditGrantLapseReason Expired { get; } = new("EXPIRED");

    /// <summary><c>SUBSCRIPTION_ENDED</c></summary>
    public static CreditGrantLapseReason SubscriptionEnded { get; } = new("SUBSCRIPTION_ENDED");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "EXPIRED" or "SUBSCRIPTION_ENDED";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>EXPIRED</c></summary>
        public const string Expired = "EXPIRED";

        /// <summary><c>SUBSCRIPTION_ENDED</c></summary>
        public const string SubscriptionEnded = "SUBSCRIPTION_ENDED";
    }

    static CreditGrantLapseReason IStringEnum<CreditGrantLapseReason>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator CreditGrantLapseReason(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
