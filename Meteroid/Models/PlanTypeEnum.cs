// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<PlanTypeEnum>))]
public readonly partial record struct PlanTypeEnum(string Value) : IStringEnum<PlanTypeEnum>
{
    /// <summary><c>STANDARD</c></summary>
    public static PlanTypeEnum Standard { get; } = new("STANDARD");

    /// <summary><c>FREE</c></summary>
    public static PlanTypeEnum Free { get; } = new("FREE");

    /// <summary><c>CUSTOM</c></summary>
    public static PlanTypeEnum Custom { get; } = new("CUSTOM");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "STANDARD" or "FREE" or "CUSTOM";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>STANDARD</c></summary>
        public const string Standard = "STANDARD";

        /// <summary><c>FREE</c></summary>
        public const string Free = "FREE";

        /// <summary><c>CUSTOM</c></summary>
        public const string Custom = "CUSTOM";
    }

    static PlanTypeEnum IStringEnum<PlanTypeEnum>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator PlanTypeEnum(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
