// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<LicenseStatus>))]
public readonly partial record struct LicenseStatus(string Value) : IStringEnum<LicenseStatus>
{
    /// <summary><c>PENDING</c></summary>
    public static LicenseStatus Pending { get; } = new("PENDING");

    /// <summary><c>ACTIVE</c></summary>
    public static LicenseStatus Active { get; } = new("ACTIVE");

    /// <summary><c>REVOKED</c></summary>
    public static LicenseStatus Revoked { get; } = new("REVOKED");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "PENDING" or "ACTIVE" or "REVOKED";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>PENDING</c></summary>
        public const string Pending = "PENDING";

        /// <summary><c>ACTIVE</c></summary>
        public const string Active = "ACTIVE";

        /// <summary><c>REVOKED</c></summary>
        public const string Revoked = "REVOKED";
    }

    static LicenseStatus IStringEnum<LicenseStatus>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator LicenseStatus(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
