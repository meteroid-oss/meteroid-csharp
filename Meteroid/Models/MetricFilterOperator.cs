// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// Operator of a pre-aggregation [<c>MetricFilter</c>]. <c>EQUAL</c>/<c>NOT_EQUAL</c> are the single-value
/// forms of <c>IN</c>/<c>NOT_IN</c>. Negation (<c>NOT_EQUAL</c>/<c>NOT_IN</c>) is presence-required: an event
/// missing the property is excluded.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<MetricFilterOperator>))]
public readonly partial record struct MetricFilterOperator(string Value) : IStringEnum<MetricFilterOperator>
{
    /// <summary><c>EQUAL</c></summary>
    public static MetricFilterOperator Equal { get; } = new("EQUAL");

    /// <summary><c>NOT_EQUAL</c></summary>
    public static MetricFilterOperator NotEqual { get; } = new("NOT_EQUAL");

    /// <summary><c>IN</c></summary>
    public static MetricFilterOperator In { get; } = new("IN");

    /// <summary><c>NOT_IN</c></summary>
    public static MetricFilterOperator NotIn { get; } = new("NOT_IN");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "EQUAL" or "NOT_EQUAL" or "IN" or "NOT_IN";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>EQUAL</c></summary>
        public const string Equal = "EQUAL";

        /// <summary><c>NOT_EQUAL</c></summary>
        public const string NotEqual = "NOT_EQUAL";

        /// <summary><c>IN</c></summary>
        public const string In = "IN";

        /// <summary><c>NOT_IN</c></summary>
        public const string NotIn = "NOT_IN";
    }

    static MetricFilterOperator IStringEnum<MetricFilterOperator>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator MetricFilterOperator(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
