// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<ExtraRecurringBillingTypeEnum>))]
public readonly partial record struct ExtraRecurringBillingTypeEnum(string Value)
    : IStringEnum<ExtraRecurringBillingTypeEnum>
{
    /// <summary><c>ADVANCE</c></summary>
    public static ExtraRecurringBillingTypeEnum Advance { get; } = new("ADVANCE");

    /// <summary><c>ARREARS</c></summary>
    public static ExtraRecurringBillingTypeEnum Arrears { get; } = new("ARREARS");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "ADVANCE" or "ARREARS";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>ADVANCE</c></summary>
        public const string Advance = "ADVANCE";

        /// <summary><c>ARREARS</c></summary>
        public const string Arrears = "ARREARS";
    }

    static ExtraRecurringBillingTypeEnum IStringEnum<ExtraRecurringBillingTypeEnum>.FromValue(string value) =>
        new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator ExtraRecurringBillingTypeEnum(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
