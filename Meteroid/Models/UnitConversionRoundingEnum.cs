// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<UnitConversionRoundingEnum>))]
public readonly partial record struct UnitConversionRoundingEnum(string Value) : IStringEnum<UnitConversionRoundingEnum>
{
    /// <summary><c>UP</c></summary>
    public static UnitConversionRoundingEnum Up { get; } = new("UP");

    /// <summary><c>DOWN</c></summary>
    public static UnitConversionRoundingEnum Down { get; } = new("DOWN");

    /// <summary><c>NEAREST</c></summary>
    public static UnitConversionRoundingEnum Nearest { get; } = new("NEAREST");

    /// <summary><c>NEAREST_HALF</c></summary>
    public static UnitConversionRoundingEnum NearestHalf { get; } = new("NEAREST_HALF");

    /// <summary><c>NEAREST_DECILE</c></summary>
    public static UnitConversionRoundingEnum NearestDecile { get; } = new("NEAREST_DECILE");

    /// <summary><c>NONE</c></summary>
    public static UnitConversionRoundingEnum None { get; } = new("NONE");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "UP" or "DOWN" or "NEAREST" or "NEAREST_HALF" or "NEAREST_DECILE" or "NONE";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>UP</c></summary>
        public const string Up = "UP";

        /// <summary><c>DOWN</c></summary>
        public const string Down = "DOWN";

        /// <summary><c>NEAREST</c></summary>
        public const string Nearest = "NEAREST";

        /// <summary><c>NEAREST_HALF</c></summary>
        public const string NearestHalf = "NEAREST_HALF";

        /// <summary><c>NEAREST_DECILE</c></summary>
        public const string NearestDecile = "NEAREST_DECILE";

        /// <summary><c>NONE</c></summary>
        public const string None = "NONE";
    }

    static UnitConversionRoundingEnum IStringEnum<UnitConversionRoundingEnum>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator UnitConversionRoundingEnum(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
