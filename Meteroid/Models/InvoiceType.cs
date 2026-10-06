// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<InvoiceType>))]
public readonly partial record struct InvoiceType(string Value) : IStringEnum<InvoiceType>
{
    /// <summary><c>RECURRING</c></summary>
    public static InvoiceType Recurring { get; } = new("RECURRING");

    /// <summary><c>ONE_OFF</c></summary>
    public static InvoiceType OneOff { get; } = new("ONE_OFF");

    /// <summary><c>ADJUSTMENT</c></summary>
    public static InvoiceType Adjustment { get; } = new("ADJUSTMENT");

    /// <summary><c>USAGE_THRESHOLD</c></summary>
    public static InvoiceType UsageThreshold { get; } = new("USAGE_THRESHOLD");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "RECURRING" or "ONE_OFF" or "ADJUSTMENT" or "USAGE_THRESHOLD";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>RECURRING</c></summary>
        public const string Recurring = "RECURRING";

        /// <summary><c>ONE_OFF</c></summary>
        public const string OneOff = "ONE_OFF";

        /// <summary><c>ADJUSTMENT</c></summary>
        public const string Adjustment = "ADJUSTMENT";

        /// <summary><c>USAGE_THRESHOLD</c></summary>
        public const string UsageThreshold = "USAGE_THRESHOLD";
    }

    static InvoiceType IStringEnum<InvoiceType>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator InvoiceType(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
