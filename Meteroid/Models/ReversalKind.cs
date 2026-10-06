// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// Why a payment was involuntarily clawed back.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<ReversalKind>))]
public readonly partial record struct ReversalKind(string Value) : IStringEnum<ReversalKind>
{
    /// <summary><c>REFUND</c></summary>
    public static ReversalKind Refund { get; } = new("REFUND");

    /// <summary><c>CHARGEBACK</c></summary>
    public static ReversalKind Chargeback { get; } = new("CHARGEBACK");

    /// <summary><c>DEBTOR_RECALL</c></summary>
    public static ReversalKind DebtorRecall { get; } = new("DEBTOR_RECALL");

    /// <summary><c>INSUFFICIENT_FUNDS</c></summary>
    public static ReversalKind InsufficientFunds { get; } = new("INSUFFICIENT_FUNDS");

    /// <summary><c>MANDATE_INVALID</c></summary>
    public static ReversalKind MandateInvalid { get; } = new("MANDATE_INVALID");

    /// <summary><c>RETURNED</c></summary>
    public static ReversalKind Returned { get; } = new("RETURNED");

    /// <summary><c>DISPUTE</c></summary>
    public static ReversalKind Dispute { get; } = new("DISPUTE");

    /// <summary><c>OTHER</c></summary>
    public static ReversalKind Other { get; } = new("OTHER");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown =>
        Value
            is "REFUND"
                or "CHARGEBACK"
                or "DEBTOR_RECALL"
                or "INSUFFICIENT_FUNDS"
                or "MANDATE_INVALID"
                or "RETURNED"
                or "DISPUTE"
                or "OTHER";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>REFUND</c></summary>
        public const string Refund = "REFUND";

        /// <summary><c>CHARGEBACK</c></summary>
        public const string Chargeback = "CHARGEBACK";

        /// <summary><c>DEBTOR_RECALL</c></summary>
        public const string DebtorRecall = "DEBTOR_RECALL";

        /// <summary><c>INSUFFICIENT_FUNDS</c></summary>
        public const string InsufficientFunds = "INSUFFICIENT_FUNDS";

        /// <summary><c>MANDATE_INVALID</c></summary>
        public const string MandateInvalid = "MANDATE_INVALID";

        /// <summary><c>RETURNED</c></summary>
        public const string Returned = "RETURNED";

        /// <summary><c>DISPUTE</c></summary>
        public const string Dispute = "DISPUTE";

        /// <summary><c>OTHER</c></summary>
        public const string Other = "OTHER";
    }

    static ReversalKind IStringEnum<ReversalKind>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator ReversalKind(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
