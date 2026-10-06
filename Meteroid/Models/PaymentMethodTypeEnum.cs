// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<PaymentMethodTypeEnum>))]
public readonly partial record struct PaymentMethodTypeEnum(string Value) : IStringEnum<PaymentMethodTypeEnum>
{
    /// <summary><c>CARD</c></summary>
    public static PaymentMethodTypeEnum Card { get; } = new("CARD");

    /// <summary><c>BANK_TRANSFER</c></summary>
    public static PaymentMethodTypeEnum BankTransfer { get; } = new("BANK_TRANSFER");

    /// <summary><c>WALLET</c></summary>
    public static PaymentMethodTypeEnum Wallet { get; } = new("WALLET");

    /// <summary><c>OTHER</c></summary>
    public static PaymentMethodTypeEnum Other { get; } = new("OTHER");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "CARD" or "BANK_TRANSFER" or "WALLET" or "OTHER";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>CARD</c></summary>
        public const string Card = "CARD";

        /// <summary><c>BANK_TRANSFER</c></summary>
        public const string BankTransfer = "BANK_TRANSFER";

        /// <summary><c>WALLET</c></summary>
        public const string Wallet = "WALLET";

        /// <summary><c>OTHER</c></summary>
        public const string Other = "OTHER";
    }

    static PaymentMethodTypeEnum IStringEnum<PaymentMethodTypeEnum>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator PaymentMethodTypeEnum(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
