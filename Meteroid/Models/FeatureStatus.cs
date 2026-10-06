// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// Lifecycle status of a feature.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<FeatureStatus>))]
public readonly partial record struct FeatureStatus(string Value) : IStringEnum<FeatureStatus>
{
    /// <summary><c>ACTIVE</c></summary>
    public static FeatureStatus Active { get; } = new("ACTIVE");

    /// <summary><c>DISABLED</c></summary>
    public static FeatureStatus Disabled { get; } = new("DISABLED");

    /// <summary><c>ARCHIVED</c></summary>
    public static FeatureStatus Archived { get; } = new("ARCHIVED");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "ACTIVE" or "DISABLED" or "ARCHIVED";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>ACTIVE</c></summary>
        public const string Active = "ACTIVE";

        /// <summary><c>DISABLED</c></summary>
        public const string Disabled = "DISABLED";

        /// <summary><c>ARCHIVED</c></summary>
        public const string Archived = "ARCHIVED";
    }

    static FeatureStatus IStringEnum<FeatureStatus>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator FeatureStatus(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
