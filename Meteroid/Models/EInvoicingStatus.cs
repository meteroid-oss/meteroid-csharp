// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// Whether the structured e-invoice was produced with the accounting PDF. Absent when the
/// invoicing entity had not opted in at the time the invoice was issued.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<EInvoicingStatus>))]
public readonly partial record struct EInvoicingStatus(string Value) : IStringEnum<EInvoicingStatus>
{
    /// <summary><c>GENERATED</c></summary>
    public static EInvoicingStatus Generated { get; } = new("GENERATED");

    /// <summary><c>FAILED</c></summary>
    public static EInvoicingStatus Failed { get; } = new("FAILED");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "GENERATED" or "FAILED";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>GENERATED</c></summary>
        public const string Generated = "GENERATED";

        /// <summary><c>FAILED</c></summary>
        public const string Failed = "FAILED";
    }

    static EInvoicingStatus IStringEnum<EInvoicingStatus>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator EInvoicingStatus(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
