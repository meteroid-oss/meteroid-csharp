// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<CreditGrantSource>))]
public readonly partial record struct CreditGrantSource(string Value) : IStringEnum<CreditGrantSource>
{
    /// <summary><c>MANUAL</c></summary>
    public static CreditGrantSource Manual { get; } = new("MANUAL");

    /// <summary><c>PURCHASE</c></summary>
    public static CreditGrantSource Purchase { get; } = new("PURCHASE");

    /// <summary><c>PLAN</c></summary>
    public static CreditGrantSource Plan { get; } = new("PLAN");

    /// <summary><c>CREDIT_NOTE</c></summary>
    public static CreditGrantSource CreditNote { get; } = new("CREDIT_NOTE");

    /// <summary><c>ADJUSTMENT</c></summary>
    public static CreditGrantSource Adjustment { get; } = new("ADJUSTMENT");

    /// <summary><c>MIGRATED</c></summary>
    public static CreditGrantSource Migrated { get; } = new("MIGRATED");

    /// <summary><c>ROLLOVER</c></summary>
    public static CreditGrantSource Rollover { get; } = new("ROLLOVER");

    /// <summary><c>COUPON</c></summary>
    public static CreditGrantSource Coupon { get; } = new("COUPON");

    /// <summary><c>OVERPAYMENT</c></summary>
    public static CreditGrantSource Overpayment { get; } = new("OVERPAYMENT");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown =>
        Value
            is "MANUAL"
                or "PURCHASE"
                or "PLAN"
                or "CREDIT_NOTE"
                or "ADJUSTMENT"
                or "MIGRATED"
                or "ROLLOVER"
                or "COUPON"
                or "OVERPAYMENT";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>MANUAL</c></summary>
        public const string Manual = "MANUAL";

        /// <summary><c>PURCHASE</c></summary>
        public const string Purchase = "PURCHASE";

        /// <summary><c>PLAN</c></summary>
        public const string Plan = "PLAN";

        /// <summary><c>CREDIT_NOTE</c></summary>
        public const string CreditNote = "CREDIT_NOTE";

        /// <summary><c>ADJUSTMENT</c></summary>
        public const string Adjustment = "ADJUSTMENT";

        /// <summary><c>MIGRATED</c></summary>
        public const string Migrated = "MIGRATED";

        /// <summary><c>ROLLOVER</c></summary>
        public const string Rollover = "ROLLOVER";

        /// <summary><c>COUPON</c></summary>
        public const string Coupon = "COUPON";

        /// <summary><c>OVERPAYMENT</c></summary>
        public const string Overpayment = "OVERPAYMENT";
    }

    static CreditGrantSource IStringEnum<CreditGrantSource>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator CreditGrantSource(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
