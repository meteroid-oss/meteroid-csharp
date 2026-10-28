// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<TopUpStatus>))]
public readonly partial record struct TopUpStatus(string Value) : IStringEnum<TopUpStatus>
{
    /// <summary><c>SUCCEEDED</c></summary>
    public static TopUpStatus Succeeded { get; } = new("SUCCEEDED");

    /// <summary><c>PENDING</c></summary>
    public static TopUpStatus Pending { get; } = new("PENDING");

    /// <summary><c>REQUIRES_CUSTOMER_ACTION</c></summary>
    public static TopUpStatus RequiresCustomerAction { get; } = new("REQUIRES_CUSTOMER_ACTION");

    /// <summary><c>AWAITING_PAYMENT</c></summary>
    public static TopUpStatus AwaitingPayment { get; } = new("AWAITING_PAYMENT");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "SUCCEEDED" or "PENDING" or "REQUIRES_CUSTOMER_ACTION" or "AWAITING_PAYMENT";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>SUCCEEDED</c></summary>
        public const string Succeeded = "SUCCEEDED";

        /// <summary><c>PENDING</c></summary>
        public const string Pending = "PENDING";

        /// <summary><c>REQUIRES_CUSTOMER_ACTION</c></summary>
        public const string RequiresCustomerAction = "REQUIRES_CUSTOMER_ACTION";

        /// <summary><c>AWAITING_PAYMENT</c></summary>
        public const string AwaitingPayment = "AWAITING_PAYMENT";
    }

    static TopUpStatus IStringEnum<TopUpStatus>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator TopUpStatus(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
