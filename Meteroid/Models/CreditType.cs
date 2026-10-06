// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<CreditType>))]
public readonly partial record struct CreditType(string Value) : IStringEnum<CreditType>
{
    /// <summary><c>CREDIT_TO_BALANCE</c></summary>
    public static CreditType CreditToBalance { get; } = new("CREDIT_TO_BALANCE");

    /// <summary><c>REFUND</c></summary>
    public static CreditType Refund { get; } = new("REFUND");

    /// <summary><c>DEBT_CANCELLATION</c></summary>
    public static CreditType DebtCancellation { get; } = new("DEBT_CANCELLATION");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "CREDIT_TO_BALANCE" or "REFUND" or "DEBT_CANCELLATION";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>CREDIT_TO_BALANCE</c></summary>
        public const string CreditToBalance = "CREDIT_TO_BALANCE";

        /// <summary><c>REFUND</c></summary>
        public const string Refund = "REFUND";

        /// <summary><c>DEBT_CANCELLATION</c></summary>
        public const string DebtCancellation = "DEBT_CANCELLATION";
    }

    static CreditType IStringEnum<CreditType>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator CreditType(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
