// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// Onboarding mode for connected accounts
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<OnboardingMode>))]
public readonly partial record struct OnboardingMode(string Value) : IStringEnum<OnboardingMode>
{
    /// <summary><c>express</c></summary>
    public static OnboardingMode Express { get; } = new("express");

    /// <summary><c>full</c></summary>
    public static OnboardingMode Full { get; } = new("full");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown => Value is "express" or "full";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>express</c></summary>
        public const string Express = "express";

        /// <summary><c>full</c></summary>
        public const string Full = "full";
    }

    static OnboardingMode IStringEnum<OnboardingMode>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator OnboardingMode(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
