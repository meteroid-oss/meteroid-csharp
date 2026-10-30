// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<LicenseSigningKeyStatus>))]
public readonly partial record struct LicenseSigningKeyStatus(string Value) : IStringEnum<LicenseSigningKeyStatus>
{
    /// <summary><c>ACTIVE</c></summary>
    public static LicenseSigningKeyStatus Active { get; } = new("ACTIVE");

    /// <summary><c>RETIRED</c></summary>
    public static LicenseSigningKeyStatus Retired { get; } = new("RETIRED");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "ACTIVE" or "RETIRED";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>ACTIVE</c></summary>
        public const string Active = "ACTIVE";

        /// <summary><c>RETIRED</c></summary>
        public const string Retired = "RETIRED";
    }

    static LicenseSigningKeyStatus IStringEnum<LicenseSigningKeyStatus>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator LicenseSigningKeyStatus(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
