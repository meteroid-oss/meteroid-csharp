// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<LedgerEntryType>))]
public readonly partial record struct LedgerEntryType(string Value) : IStringEnum<LedgerEntryType>
{
    /// <summary><c>CREDIT</c></summary>
    public static LedgerEntryType Credit { get; } = new("CREDIT");

    /// <summary><c>INVOICE_APPLICATION</c></summary>
    public static LedgerEntryType InvoiceApplication { get; } = new("INVOICE_APPLICATION");

    /// <summary><c>INVOICE_RETURN</c></summary>
    public static LedgerEntryType InvoiceReturn { get; } = new("INVOICE_RETURN");

    /// <summary><c>CREDIT_REVERSAL</c></summary>
    public static LedgerEntryType CreditReversal { get; } = new("CREDIT_REVERSAL");

    /// <summary><c>CREDIT_REINSTATEMENT</c></summary>
    public static LedgerEntryType CreditReinstatement { get; } = new("CREDIT_REINSTATEMENT");

    /// <summary><c>CREDIT_EXPIRY</c></summary>
    public static LedgerEntryType CreditExpiry { get; } = new("CREDIT_EXPIRY");

    /// <summary><c>CREDIT_ROLLOVER</c></summary>
    public static LedgerEntryType CreditRollover { get; } = new("CREDIT_ROLLOVER");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown =>
        Value
            is "CREDIT"
                or "INVOICE_APPLICATION"
                or "INVOICE_RETURN"
                or "CREDIT_REVERSAL"
                or "CREDIT_REINSTATEMENT"
                or "CREDIT_EXPIRY"
                or "CREDIT_ROLLOVER";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>CREDIT</c></summary>
        public const string Credit = "CREDIT";

        /// <summary><c>INVOICE_APPLICATION</c></summary>
        public const string InvoiceApplication = "INVOICE_APPLICATION";

        /// <summary><c>INVOICE_RETURN</c></summary>
        public const string InvoiceReturn = "INVOICE_RETURN";

        /// <summary><c>CREDIT_REVERSAL</c></summary>
        public const string CreditReversal = "CREDIT_REVERSAL";

        /// <summary><c>CREDIT_REINSTATEMENT</c></summary>
        public const string CreditReinstatement = "CREDIT_REINSTATEMENT";

        /// <summary><c>CREDIT_EXPIRY</c></summary>
        public const string CreditExpiry = "CREDIT_EXPIRY";

        /// <summary><c>CREDIT_ROLLOVER</c></summary>
        public const string CreditRollover = "CREDIT_ROLLOVER";
    }

    static LedgerEntryType IStringEnum<LedgerEntryType>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator LedgerEntryType(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
