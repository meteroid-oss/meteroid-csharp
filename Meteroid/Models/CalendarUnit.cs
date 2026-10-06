// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<CalendarUnit>))]
public readonly partial record struct CalendarUnit(string Value) : IStringEnum<CalendarUnit>
{
    /// <summary><c>HOUR</c></summary>
    public static CalendarUnit Hour { get; } = new("HOUR");

    /// <summary><c>DAY</c></summary>
    public static CalendarUnit Day { get; } = new("DAY");

    /// <summary><c>WEEK</c></summary>
    public static CalendarUnit Week { get; } = new("WEEK");

    /// <summary><c>MONTH</c></summary>
    public static CalendarUnit Month { get; } = new("MONTH");

    /// <summary><c>YEAR</c></summary>
    public static CalendarUnit Year { get; } = new("YEAR");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "HOUR" or "DAY" or "WEEK" or "MONTH" or "YEAR";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>HOUR</c></summary>
        public const string Hour = "HOUR";

        /// <summary><c>DAY</c></summary>
        public const string Day = "DAY";

        /// <summary><c>WEEK</c></summary>
        public const string Week = "WEEK";

        /// <summary><c>MONTH</c></summary>
        public const string Month = "MONTH";

        /// <summary><c>YEAR</c></summary>
        public const string Year = "YEAR";
    }

    static CalendarUnit IStringEnum<CalendarUnit>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator CalendarUnit(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
