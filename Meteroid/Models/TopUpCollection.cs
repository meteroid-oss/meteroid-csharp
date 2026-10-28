// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// How a top-up is paid: CHARGE a saved payment method now, or SEND_INVOICE and grant the credit
/// once the invoice is paid.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<TopUpCollection>))]
public readonly partial record struct TopUpCollection(string Value) : IStringEnum<TopUpCollection>
{
    /// <summary><c>CHARGE</c></summary>
    public static TopUpCollection Charge { get; } = new("CHARGE");

    /// <summary><c>SEND_INVOICE</c></summary>
    public static TopUpCollection SendInvoice { get; } = new("SEND_INVOICE");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "CHARGE" or "SEND_INVOICE";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>CHARGE</c></summary>
        public const string Charge = "CHARGE";

        /// <summary><c>SEND_INVOICE</c></summary>
        public const string SendInvoice = "SEND_INVOICE";
    }

    static TopUpCollection IStringEnum<TopUpCollection>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator TopUpCollection(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
