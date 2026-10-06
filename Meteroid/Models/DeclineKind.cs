// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// Why the payment provider declined a charge.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<DeclineKind>))]
public readonly partial record struct DeclineKind(string Value) : IStringEnum<DeclineKind>
{
    /// <summary><c>INSUFFICIENT_FUNDS</c></summary>
    public static DeclineKind InsufficientFunds { get; } = new("INSUFFICIENT_FUNDS");

    /// <summary><c>DO_NOT_HONOR</c></summary>
    public static DeclineKind DoNotHonor { get; } = new("DO_NOT_HONOR");

    /// <summary><c>CARD_EXPIRED</c></summary>
    public static DeclineKind CardExpired { get; } = new("CARD_EXPIRED");

    /// <summary><c>AUTHENTICATION_REQUIRED</c></summary>
    public static DeclineKind AuthenticationRequired { get; } = new("AUTHENTICATION_REQUIRED");

    /// <summary><c>MANDATE_INACTIVE</c></summary>
    public static DeclineKind MandateInactive { get; } = new("MANDATE_INACTIVE");

    /// <summary><c>FRAUD</c></summary>
    public static DeclineKind Fraud { get; } = new("FRAUD");

    /// <summary><c>PROCESSING_ERROR</c></summary>
    public static DeclineKind ProcessingError { get; } = new("PROCESSING_ERROR");

    /// <summary><c>OTHER</c></summary>
    public static DeclineKind Other { get; } = new("OTHER");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown =>
        Value
            is "INSUFFICIENT_FUNDS"
                or "DO_NOT_HONOR"
                or "CARD_EXPIRED"
                or "AUTHENTICATION_REQUIRED"
                or "MANDATE_INACTIVE"
                or "FRAUD"
                or "PROCESSING_ERROR"
                or "OTHER";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>INSUFFICIENT_FUNDS</c></summary>
        public const string InsufficientFunds = "INSUFFICIENT_FUNDS";

        /// <summary><c>DO_NOT_HONOR</c></summary>
        public const string DoNotHonor = "DO_NOT_HONOR";

        /// <summary><c>CARD_EXPIRED</c></summary>
        public const string CardExpired = "CARD_EXPIRED";

        /// <summary><c>AUTHENTICATION_REQUIRED</c></summary>
        public const string AuthenticationRequired = "AUTHENTICATION_REQUIRED";

        /// <summary><c>MANDATE_INACTIVE</c></summary>
        public const string MandateInactive = "MANDATE_INACTIVE";

        /// <summary><c>FRAUD</c></summary>
        public const string Fraud = "FRAUD";

        /// <summary><c>PROCESSING_ERROR</c></summary>
        public const string ProcessingError = "PROCESSING_ERROR";

        /// <summary><c>OTHER</c></summary>
        public const string Other = "OTHER";
    }

    static DeclineKind IStringEnum<DeclineKind>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator DeclineKind(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
