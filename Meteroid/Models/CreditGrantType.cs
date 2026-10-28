// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// PAID credit was bought, through Meteroid or outside it, and applies after tax like a payment.
/// PROMOTIONAL credit was given (included with a plan, a coupon, bonus credit, a goodwill grant):
/// it applies before tax, like a discount, so it is spent before paid credit. Credit-unit grants
/// are drawn together, whatever their type.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<CreditGrantType>))]
public readonly partial record struct CreditGrantType(string Value) : IStringEnum<CreditGrantType>
{
    /// <summary><c>PAID</c></summary>
    public static CreditGrantType Paid { get; } = new("PAID");

    /// <summary><c>PROMOTIONAL</c></summary>
    public static CreditGrantType Promotional { get; } = new("PROMOTIONAL");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "PAID" or "PROMOTIONAL";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>PAID</c></summary>
        public const string Paid = "PAID";

        /// <summary><c>PROMOTIONAL</c></summary>
        public const string Promotional = "PROMOTIONAL";
    }

    static CreditGrantType IStringEnum<CreditGrantType>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator CreditGrantType(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
