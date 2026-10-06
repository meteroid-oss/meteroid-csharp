// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<CouponFilter>))]
public readonly partial record struct CouponFilter(string Value) : IStringEnum<CouponFilter>
{
    /// <summary><c>ALL</c></summary>
    public static CouponFilter All { get; } = new("ALL");

    /// <summary><c>ACTIVE</c></summary>
    public static CouponFilter Active { get; } = new("ACTIVE");

    /// <summary><c>INACTIVE</c></summary>
    public static CouponFilter Inactive { get; } = new("INACTIVE");

    /// <summary><c>ARCHIVED</c></summary>
    public static CouponFilter Archived { get; } = new("ARCHIVED");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "ALL" or "ACTIVE" or "INACTIVE" or "ARCHIVED";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>ALL</c></summary>
        public const string All = "ALL";

        /// <summary><c>ACTIVE</c></summary>
        public const string Active = "ACTIVE";

        /// <summary><c>INACTIVE</c></summary>
        public const string Inactive = "INACTIVE";

        /// <summary><c>ARCHIVED</c></summary>
        public const string Archived = "ARCHIVED";
    }

    static CouponFilter IStringEnum<CouponFilter>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator CouponFilter(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
