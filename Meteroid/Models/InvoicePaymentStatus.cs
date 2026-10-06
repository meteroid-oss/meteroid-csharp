// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<InvoicePaymentStatus>))]
public readonly partial record struct InvoicePaymentStatus(string Value) : IStringEnum<InvoicePaymentStatus>
{
    /// <summary><c>UNPAID</c></summary>
    public static InvoicePaymentStatus Unpaid { get; } = new("UNPAID");

    /// <summary><c>PARTIALLY_PAID</c></summary>
    public static InvoicePaymentStatus PartiallyPaid { get; } = new("PARTIALLY_PAID");

    /// <summary><c>PAID</c></summary>
    public static InvoicePaymentStatus Paid { get; } = new("PAID");

    /// <summary><c>ERRORED</c></summary>
    public static InvoicePaymentStatus Errored { get; } = new("ERRORED");

    /// <summary><c>PROCESSING</c></summary>
    public static InvoicePaymentStatus Processing { get; } = new("PROCESSING");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "UNPAID" or "PARTIALLY_PAID" or "PAID" or "ERRORED" or "PROCESSING";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>UNPAID</c></summary>
        public const string Unpaid = "UNPAID";

        /// <summary><c>PARTIALLY_PAID</c></summary>
        public const string PartiallyPaid = "PARTIALLY_PAID";

        /// <summary><c>PAID</c></summary>
        public const string Paid = "PAID";

        /// <summary><c>ERRORED</c></summary>
        public const string Errored = "ERRORED";

        /// <summary><c>PROCESSING</c></summary>
        public const string Processing = "PROCESSING";
    }

    static InvoicePaymentStatus IStringEnum<InvoicePaymentStatus>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator InvoicePaymentStatus(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
