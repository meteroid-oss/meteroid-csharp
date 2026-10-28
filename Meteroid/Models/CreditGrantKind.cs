// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// The group a grant is shown in, from where it came from and what it pays:
/// - INCLUDED: credit a subscription's plan includes, which renews with it;
/// - PREPAID: credit bought (purchases, top-ups, paid packs, credit paid for outside Meteroid);
/// - BONUS: credit given (the bonus part of discounted credit, promo codes, welcome credit);
/// - ACCOUNT_BALANCE: the customer's money that pays any invoice (credit notes, returned invoices,
///   the balance carried from before credit grants, credit added for any charge).
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<CreditGrantKind>))]
public readonly partial record struct CreditGrantKind(string Value) : IStringEnum<CreditGrantKind>
{
    /// <summary><c>INCLUDED</c></summary>
    public static CreditGrantKind Included { get; } = new("INCLUDED");

    /// <summary><c>PREPAID</c></summary>
    public static CreditGrantKind Prepaid { get; } = new("PREPAID");

    /// <summary><c>BONUS</c></summary>
    public static CreditGrantKind Bonus { get; } = new("BONUS");

    /// <summary><c>ACCOUNT_BALANCE</c></summary>
    public static CreditGrantKind AccountBalance { get; } = new("ACCOUNT_BALANCE");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "INCLUDED" or "PREPAID" or "BONUS" or "ACCOUNT_BALANCE";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>INCLUDED</c></summary>
        public const string Included = "INCLUDED";

        /// <summary><c>PREPAID</c></summary>
        public const string Prepaid = "PREPAID";

        /// <summary><c>BONUS</c></summary>
        public const string Bonus = "BONUS";

        /// <summary><c>ACCOUNT_BALANCE</c></summary>
        public const string AccountBalance = "ACCOUNT_BALANCE";
    }

    static CreditGrantKind IStringEnum<CreditGrantKind>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator CreditGrantKind(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
