// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<InvoiceStatus>))]
public readonly partial record struct InvoiceStatus(string Value) : IStringEnum<InvoiceStatus>
{
    /// <summary><c>DRAFT</c></summary>
    public static InvoiceStatus Draft { get; } = new("DRAFT");

    /// <summary><c>FINALIZED</c></summary>
    public static InvoiceStatus Finalized { get; } = new("FINALIZED");

    /// <summary><c>UNCOLLECTIBLE</c></summary>
    public static InvoiceStatus Uncollectible { get; } = new("UNCOLLECTIBLE");

    /// <summary><c>VOID</c></summary>
    public static InvoiceStatus Void { get; } = new("VOID");

    /// <summary><c>CLOSED</c></summary>
    public static InvoiceStatus Closed { get; } = new("CLOSED");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "DRAFT" or "FINALIZED" or "UNCOLLECTIBLE" or "VOID" or "CLOSED";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>DRAFT</c></summary>
        public const string Draft = "DRAFT";

        /// <summary><c>FINALIZED</c></summary>
        public const string Finalized = "FINALIZED";

        /// <summary><c>UNCOLLECTIBLE</c></summary>
        public const string Uncollectible = "UNCOLLECTIBLE";

        /// <summary><c>VOID</c></summary>
        public const string Void = "VOID";

        /// <summary><c>CLOSED</c></summary>
        public const string Closed = "CLOSED";
    }

    static InvoiceStatus IStringEnum<InvoiceStatus>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator InvoiceStatus(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
