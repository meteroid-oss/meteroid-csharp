// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<CreditNoteStatus>))]
public readonly partial record struct CreditNoteStatus(string Value) : IStringEnum<CreditNoteStatus>
{
    /// <summary><c>DRAFT</c></summary>
    public static CreditNoteStatus Draft { get; } = new("DRAFT");

    /// <summary><c>FINALIZED</c></summary>
    public static CreditNoteStatus Finalized { get; } = new("FINALIZED");

    /// <summary><c>VOIDED</c></summary>
    public static CreditNoteStatus Voided { get; } = new("VOIDED");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "DRAFT" or "FINALIZED" or "VOIDED";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>DRAFT</c></summary>
        public const string Draft = "DRAFT";

        /// <summary><c>FINALIZED</c></summary>
        public const string Finalized = "FINALIZED";

        /// <summary><c>VOIDED</c></summary>
        public const string Voided = "VOIDED";
    }

    static CreditNoteStatus IStringEnum<CreditNoteStatus>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator CreditNoteStatus(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
