// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<CustomPropertyEntityType>))]
public readonly partial record struct CustomPropertyEntityType(string Value) : IStringEnum<CustomPropertyEntityType>
{
    /// <summary><c>CUSTOMER</c></summary>
    public static CustomPropertyEntityType Customer { get; } = new("CUSTOMER");

    /// <summary><c>SUBSCRIPTION</c></summary>
    public static CustomPropertyEntityType Subscription { get; } = new("SUBSCRIPTION");

    /// <summary><c>INVOICE</c></summary>
    public static CustomPropertyEntityType Invoice { get; } = new("INVOICE");

    /// <summary><c>CREDIT_NOTE</c></summary>
    public static CustomPropertyEntityType CreditNote { get; } = new("CREDIT_NOTE");

    /// <summary><c>QUOTE</c></summary>
    public static CustomPropertyEntityType Quote { get; } = new("QUOTE");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "CUSTOMER" or "SUBSCRIPTION" or "INVOICE" or "CREDIT_NOTE" or "QUOTE";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>CUSTOMER</c></summary>
        public const string Customer = "CUSTOMER";

        /// <summary><c>SUBSCRIPTION</c></summary>
        public const string Subscription = "SUBSCRIPTION";

        /// <summary><c>INVOICE</c></summary>
        public const string Invoice = "INVOICE";

        /// <summary><c>CREDIT_NOTE</c></summary>
        public const string CreditNote = "CREDIT_NOTE";

        /// <summary><c>QUOTE</c></summary>
        public const string Quote = "QUOTE";
    }

    static CustomPropertyEntityType IStringEnum<CustomPropertyEntityType>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator CustomPropertyEntityType(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
