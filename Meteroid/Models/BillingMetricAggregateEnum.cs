// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<BillingMetricAggregateEnum>))]
public readonly partial record struct BillingMetricAggregateEnum(string Value) : IStringEnum<BillingMetricAggregateEnum>
{
    /// <summary><c>COUNT</c></summary>
    public static BillingMetricAggregateEnum Count { get; } = new("COUNT");

    /// <summary><c>LATEST</c></summary>
    public static BillingMetricAggregateEnum Latest { get; } = new("LATEST");

    /// <summary><c>MAX</c></summary>
    public static BillingMetricAggregateEnum Max { get; } = new("MAX");

    /// <summary><c>MIN</c></summary>
    public static BillingMetricAggregateEnum Min { get; } = new("MIN");

    /// <summary><c>MEAN</c></summary>
    public static BillingMetricAggregateEnum Mean { get; } = new("MEAN");

    /// <summary><c>SUM</c></summary>
    public static BillingMetricAggregateEnum Sum { get; } = new("SUM");

    /// <summary><c>COUNT_DISTINCT</c></summary>
    public static BillingMetricAggregateEnum CountDistinct { get; } = new("COUNT_DISTINCT");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "COUNT" or "LATEST" or "MAX" or "MIN" or "MEAN" or "SUM" or "COUNT_DISTINCT";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>COUNT</c></summary>
        public const string Count = "COUNT";

        /// <summary><c>LATEST</c></summary>
        public const string Latest = "LATEST";

        /// <summary><c>MAX</c></summary>
        public const string Max = "MAX";

        /// <summary><c>MIN</c></summary>
        public const string Min = "MIN";

        /// <summary><c>MEAN</c></summary>
        public const string Mean = "MEAN";

        /// <summary><c>SUM</c></summary>
        public const string Sum = "SUM";

        /// <summary><c>COUNT_DISTINCT</c></summary>
        public const string CountDistinct = "COUNT_DISTINCT";
    }

    static BillingMetricAggregateEnum IStringEnum<BillingMetricAggregateEnum>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator BillingMetricAggregateEnum(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
