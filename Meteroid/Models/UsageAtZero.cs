// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// What a customer's usage does once the credit it can use runs out: what the subscription's plan
/// says (<c>FOLLOW_PLAN</c>), or always or never refused for this customer.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<UsageAtZero>))]
public readonly partial record struct UsageAtZero(string Value) : IStringEnum<UsageAtZero>
{
    /// <summary><c>FOLLOW_PLAN</c></summary>
    public static UsageAtZero FollowPlan { get; } = new("FOLLOW_PLAN");

    /// <summary><c>ALWAYS_PAUSE</c></summary>
    public static UsageAtZero AlwaysPause { get; } = new("ALWAYS_PAUSE");

    /// <summary><c>NEVER_PAUSE</c></summary>
    public static UsageAtZero NeverPause { get; } = new("NEVER_PAUSE");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "FOLLOW_PLAN" or "ALWAYS_PAUSE" or "NEVER_PAUSE";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>FOLLOW_PLAN</c></summary>
        public const string FollowPlan = "FOLLOW_PLAN";

        /// <summary><c>ALWAYS_PAUSE</c></summary>
        public const string AlwaysPause = "ALWAYS_PAUSE";

        /// <summary><c>NEVER_PAUSE</c></summary>
        public const string NeverPause = "NEVER_PAUSE";
    }

    static UsageAtZero IStringEnum<UsageAtZero>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator UsageAtZero(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
