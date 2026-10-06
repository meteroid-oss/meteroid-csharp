// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<CheckoutSessionStatus>))]
public readonly partial record struct CheckoutSessionStatus(string Value) : IStringEnum<CheckoutSessionStatus>
{
    /// <summary><c>CREATED</c></summary>
    public static CheckoutSessionStatus Created { get; } = new("CREATED");

    /// <summary><c>AWAITING_PAYMENT</c></summary>
    public static CheckoutSessionStatus AwaitingPayment { get; } = new("AWAITING_PAYMENT");

    /// <summary><c>COMPLETED</c></summary>
    public static CheckoutSessionStatus Completed { get; } = new("COMPLETED");

    /// <summary><c>EXPIRED</c></summary>
    public static CheckoutSessionStatus Expired { get; } = new("EXPIRED");

    /// <summary><c>CANCELLED</c></summary>
    public static CheckoutSessionStatus Cancelled { get; } = new("CANCELLED");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "CREATED" or "AWAITING_PAYMENT" or "COMPLETED" or "EXPIRED" or "CANCELLED";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>CREATED</c></summary>
        public const string Created = "CREATED";

        /// <summary><c>AWAITING_PAYMENT</c></summary>
        public const string AwaitingPayment = "AWAITING_PAYMENT";

        /// <summary><c>COMPLETED</c></summary>
        public const string Completed = "COMPLETED";

        /// <summary><c>EXPIRED</c></summary>
        public const string Expired = "EXPIRED";

        /// <summary><c>CANCELLED</c></summary>
        public const string Cancelled = "CANCELLED";
    }

    static CheckoutSessionStatus IStringEnum<CheckoutSessionStatus>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator CheckoutSessionStatus(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
