// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<PlanStatusEnum>))]
public readonly partial record struct PlanStatusEnum(string Value) : IStringEnum<PlanStatusEnum>
{
    /// <summary><c>DRAFT</c></summary>
    public static PlanStatusEnum Draft { get; } = new("DRAFT");

    /// <summary><c>ACTIVE</c></summary>
    public static PlanStatusEnum Active { get; } = new("ACTIVE");

    /// <summary><c>INACTIVE</c></summary>
    public static PlanStatusEnum Inactive { get; } = new("INACTIVE");

    /// <summary><c>ARCHIVED</c></summary>
    public static PlanStatusEnum Archived { get; } = new("ARCHIVED");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "DRAFT" or "ACTIVE" or "INACTIVE" or "ARCHIVED";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>DRAFT</c></summary>
        public const string Draft = "DRAFT";

        /// <summary><c>ACTIVE</c></summary>
        public const string Active = "ACTIVE";

        /// <summary><c>INACTIVE</c></summary>
        public const string Inactive = "INACTIVE";

        /// <summary><c>ARCHIVED</c></summary>
        public const string Archived = "ARCHIVED";
    }

    static PlanStatusEnum IStringEnum<PlanStatusEnum>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator PlanStatusEnum(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
