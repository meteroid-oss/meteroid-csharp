// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<ProductFeeTypeEnum>))]
public readonly partial record struct ProductFeeTypeEnum(string Value) : IStringEnum<ProductFeeTypeEnum>
{
    /// <summary><c>RATE</c></summary>
    public static ProductFeeTypeEnum Rate { get; } = new("RATE");

    /// <summary><c>SLOT</c></summary>
    public static ProductFeeTypeEnum Slot { get; } = new("SLOT");

    /// <summary><c>CAPACITY</c></summary>
    public static ProductFeeTypeEnum Capacity { get; } = new("CAPACITY");

    /// <summary><c>USAGE</c></summary>
    public static ProductFeeTypeEnum Usage { get; } = new("USAGE");

    /// <summary><c>EXTRA_RECURRING</c></summary>
    public static ProductFeeTypeEnum ExtraRecurring { get; } = new("EXTRA_RECURRING");

    /// <summary><c>ONE_TIME</c></summary>
    public static ProductFeeTypeEnum OneTime { get; } = new("ONE_TIME");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "RATE" or "SLOT" or "CAPACITY" or "USAGE" or "EXTRA_RECURRING" or "ONE_TIME";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>RATE</c></summary>
        public const string Rate = "RATE";

        /// <summary><c>SLOT</c></summary>
        public const string Slot = "SLOT";

        /// <summary><c>CAPACITY</c></summary>
        public const string Capacity = "CAPACITY";

        /// <summary><c>USAGE</c></summary>
        public const string Usage = "USAGE";

        /// <summary><c>EXTRA_RECURRING</c></summary>
        public const string ExtraRecurring = "EXTRA_RECURRING";

        /// <summary><c>ONE_TIME</c></summary>
        public const string OneTime = "ONE_TIME";
    }

    static ProductFeeTypeEnum IStringEnum<ProductFeeTypeEnum>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator ProductFeeTypeEnum(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
