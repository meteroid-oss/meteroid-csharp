// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<UsageModelEnum>))]
public readonly partial record struct UsageModelEnum(string Value) : IStringEnum<UsageModelEnum>
{
    /// <summary><c>PER_UNIT</c></summary>
    public static UsageModelEnum PerUnit { get; } = new("PER_UNIT");

    /// <summary><c>TIERED</c></summary>
    public static UsageModelEnum Tiered { get; } = new("TIERED");

    /// <summary><c>VOLUME</c></summary>
    public static UsageModelEnum Volume { get; } = new("VOLUME");

    /// <summary><c>PACKAGE</c></summary>
    public static UsageModelEnum Package { get; } = new("PACKAGE");

    /// <summary><c>MATRIX</c></summary>
    public static UsageModelEnum Matrix { get; } = new("MATRIX");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "PER_UNIT" or "TIERED" or "VOLUME" or "PACKAGE" or "MATRIX";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>PER_UNIT</c></summary>
        public const string PerUnit = "PER_UNIT";

        /// <summary><c>TIERED</c></summary>
        public const string Tiered = "TIERED";

        /// <summary><c>VOLUME</c></summary>
        public const string Volume = "VOLUME";

        /// <summary><c>PACKAGE</c></summary>
        public const string Package = "PACKAGE";

        /// <summary><c>MATRIX</c></summary>
        public const string Matrix = "MATRIX";
    }

    static UsageModelEnum IStringEnum<UsageModelEnum>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator UsageModelEnum(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
