// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<WebhookEndpointDisabledReason>))]
public readonly partial record struct WebhookEndpointDisabledReason(string Value)
    : IStringEnum<WebhookEndpointDisabledReason>
{
    /// <summary><c>MANUAL</c></summary>
    public static WebhookEndpointDisabledReason Manual { get; } = new("MANUAL");

    /// <summary><c>AUTO_FAILURES</c></summary>
    public static WebhookEndpointDisabledReason AutoFailures { get; } = new("AUTO_FAILURES");

    /// <summary><c>GONE</c></summary>
    public static WebhookEndpointDisabledReason Gone { get; } = new("GONE");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "MANUAL" or "AUTO_FAILURES" or "GONE";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>MANUAL</c></summary>
        public const string Manual = "MANUAL";

        /// <summary><c>AUTO_FAILURES</c></summary>
        public const string AutoFailures = "AUTO_FAILURES";

        /// <summary><c>GONE</c></summary>
        public const string Gone = "GONE";
    }

    static WebhookEndpointDisabledReason IStringEnum<WebhookEndpointDisabledReason>.FromValue(string value) =>
        new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator WebhookEndpointDisabledReason(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
