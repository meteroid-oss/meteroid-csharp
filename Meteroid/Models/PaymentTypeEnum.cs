// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<PaymentTypeEnum>))]
public readonly partial record struct PaymentTypeEnum(string Value) : IStringEnum<PaymentTypeEnum>
{
    /// <summary><c>PAYMENT</c></summary>
    public static PaymentTypeEnum Payment { get; } = new("PAYMENT");

    /// <summary><c>REFUND</c></summary>
    public static PaymentTypeEnum Refund { get; } = new("REFUND");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "PAYMENT" or "REFUND";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>PAYMENT</c></summary>
        public const string Payment = "PAYMENT";

        /// <summary><c>REFUND</c></summary>
        public const string Refund = "REFUND";
    }

    static PaymentTypeEnum IStringEnum<PaymentTypeEnum>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator PaymentTypeEnum(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
