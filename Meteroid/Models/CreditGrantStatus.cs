// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<CreditGrantStatus>))]
public readonly partial record struct CreditGrantStatus(string Value) : IStringEnum<CreditGrantStatus>
{
    /// <summary><c>PENDING</c></summary>
    public static CreditGrantStatus Pending { get; } = new("PENDING");

    /// <summary><c>ACTIVE</c></summary>
    public static CreditGrantStatus Active { get; } = new("ACTIVE");

    /// <summary><c>DEPLETED</c></summary>
    public static CreditGrantStatus Depleted { get; } = new("DEPLETED");

    /// <summary><c>EXPIRED</c></summary>
    public static CreditGrantStatus Expired { get; } = new("EXPIRED");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "PENDING" or "ACTIVE" or "DEPLETED" or "EXPIRED";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>PENDING</c></summary>
        public const string Pending = "PENDING";

        /// <summary><c>ACTIVE</c></summary>
        public const string Active = "ACTIVE";

        /// <summary><c>DEPLETED</c></summary>
        public const string Depleted = "DEPLETED";

        /// <summary><c>EXPIRED</c></summary>
        public const string Expired = "EXPIRED";
    }

    static CreditGrantStatus IStringEnum<CreditGrantStatus>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator CreditGrantStatus(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
