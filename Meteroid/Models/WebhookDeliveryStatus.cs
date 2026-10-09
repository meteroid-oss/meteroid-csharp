// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<WebhookDeliveryStatus>))]
public readonly partial record struct WebhookDeliveryStatus(string Value) : IStringEnum<WebhookDeliveryStatus>
{
    /// <summary><c>PENDING</c></summary>
    public static WebhookDeliveryStatus Pending { get; } = new("PENDING");

    /// <summary><c>IN_FLIGHT</c></summary>
    public static WebhookDeliveryStatus InFlight { get; } = new("IN_FLIGHT");

    /// <summary><c>SUCCEEDED</c></summary>
    public static WebhookDeliveryStatus Succeeded { get; } = new("SUCCEEDED");

    /// <summary><c>FAILED</c></summary>
    public static WebhookDeliveryStatus Failed { get; } = new("FAILED");

    /// <summary><c>CANCELLED</c></summary>
    public static WebhookDeliveryStatus Cancelled { get; } = new("CANCELLED");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "PENDING" or "IN_FLIGHT" or "SUCCEEDED" or "FAILED" or "CANCELLED";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>PENDING</c></summary>
        public const string Pending = "PENDING";

        /// <summary><c>IN_FLIGHT</c></summary>
        public const string InFlight = "IN_FLIGHT";

        /// <summary><c>SUCCEEDED</c></summary>
        public const string Succeeded = "SUCCEEDED";

        /// <summary><c>FAILED</c></summary>
        public const string Failed = "FAILED";

        /// <summary><c>CANCELLED</c></summary>
        public const string Cancelled = "CANCELLED";
    }

    static WebhookDeliveryStatus IStringEnum<WebhookDeliveryStatus>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator WebhookDeliveryStatus(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
