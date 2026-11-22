// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<ScheduledEventType>))]
public readonly partial record struct ScheduledEventType(string Value) : IStringEnum<ScheduledEventType>
{
    /// <summary><c>PLAN_CHANGE</c></summary>
    public static ScheduledEventType PlanChange { get; } = new("PLAN_CHANGE");

    /// <summary><c>CANCEL</c></summary>
    public static ScheduledEventType Cancel { get; } = new("CANCEL");

    /// <summary><c>AMENDMENT</c></summary>
    public static ScheduledEventType Amendment { get; } = new("AMENDMENT");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "PLAN_CHANGE" or "CANCEL" or "AMENDMENT";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>PLAN_CHANGE</c></summary>
        public const string PlanChange = "PLAN_CHANGE";

        /// <summary><c>CANCEL</c></summary>
        public const string Cancel = "CANCEL";

        /// <summary><c>AMENDMENT</c></summary>
        public const string Amendment = "AMENDMENT";
    }

    static ScheduledEventType IStringEnum<ScheduledEventType>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator ScheduledEventType(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
