// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<TaxExemptionType>))]
public readonly partial record struct TaxExemptionType(string Value) : IStringEnum<TaxExemptionType>
{
    /// <summary><c>REVERSE_CHARGE</c></summary>
    public static TaxExemptionType ReverseCharge { get; } = new("REVERSE_CHARGE");

    /// <summary><c>TAX_EXEMPT</c></summary>
    public static TaxExemptionType TaxExempt { get; } = new("TAX_EXEMPT");

    /// <summary><c>NOT_REGISTERED</c></summary>
    public static TaxExemptionType NotRegistered { get; } = new("NOT_REGISTERED");

    /// <summary><c>EXPORT</c></summary>
    public static TaxExemptionType Export { get; } = new("EXPORT");

    /// <summary><c>NO_VAT_TERRITORY</c></summary>
    public static TaxExemptionType NoVatTerritory { get; } = new("NO_VAT_TERRITORY");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown =>
        Value is "REVERSE_CHARGE" or "TAX_EXEMPT" or "NOT_REGISTERED" or "EXPORT" or "NO_VAT_TERRITORY";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>REVERSE_CHARGE</c></summary>
        public const string ReverseCharge = "REVERSE_CHARGE";

        /// <summary><c>TAX_EXEMPT</c></summary>
        public const string TaxExempt = "TAX_EXEMPT";

        /// <summary><c>NOT_REGISTERED</c></summary>
        public const string NotRegistered = "NOT_REGISTERED";

        /// <summary><c>EXPORT</c></summary>
        public const string Export = "EXPORT";

        /// <summary><c>NO_VAT_TERRITORY</c></summary>
        public const string NoVatTerritory = "NO_VAT_TERRITORY";
    }

    static TaxExemptionType IStringEnum<TaxExemptionType>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator TaxExemptionType(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
