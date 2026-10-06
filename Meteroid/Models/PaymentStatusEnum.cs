// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<PaymentStatusEnum>))]
public readonly partial record struct PaymentStatusEnum(string Value) : IStringEnum<PaymentStatusEnum>
{
    /// <summary><c>READY</c></summary>
    public static PaymentStatusEnum Ready { get; } = new("READY");

    /// <summary><c>PENDING</c></summary>
    public static PaymentStatusEnum Pending { get; } = new("PENDING");

    /// <summary><c>SETTLED</c></summary>
    public static PaymentStatusEnum Settled { get; } = new("SETTLED");

    /// <summary><c>CANCELLED</c></summary>
    public static PaymentStatusEnum Cancelled { get; } = new("CANCELLED");

    /// <summary><c>FAILED</c></summary>
    public static PaymentStatusEnum Failed { get; } = new("FAILED");

    /// <summary><c>REFUNDED</c></summary>
    public static PaymentStatusEnum Refunded { get; } = new("REFUNDED");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "READY" or "PENDING" or "SETTLED" or "CANCELLED" or "FAILED" or "REFUNDED";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>READY</c></summary>
        public const string Ready = "READY";

        /// <summary><c>PENDING</c></summary>
        public const string Pending = "PENDING";

        /// <summary><c>SETTLED</c></summary>
        public const string Settled = "SETTLED";

        /// <summary><c>CANCELLED</c></summary>
        public const string Cancelled = "CANCELLED";

        /// <summary><c>FAILED</c></summary>
        public const string Failed = "FAILED";

        /// <summary><c>REFUNDED</c></summary>
        public const string Refunded = "REFUNDED";
    }

    static PaymentStatusEnum IStringEnum<PaymentStatusEnum>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator PaymentStatusEnum(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
