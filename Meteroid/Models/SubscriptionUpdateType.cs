// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// Identifies which mutation triggered a <c>subscription.updated</c> webhook.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<SubscriptionUpdateType>))]
public readonly partial record struct SubscriptionUpdateType(string Value) : IStringEnum<SubscriptionUpdateType>
{
    /// <summary><c>activated</c></summary>
    public static SubscriptionUpdateType Activated { get; } = new("activated");

    /// <summary><c>trial_ended</c></summary>
    public static SubscriptionUpdateType TrialEnded { get; } = new("trial_ended");

    /// <summary><c>billing_configuration_updated</c></summary>
    public static SubscriptionUpdateType BillingConfigurationUpdated { get; } = new("billing_configuration_updated");

    /// <summary><c>plan_changed</c></summary>
    public static SubscriptionUpdateType PlanChanged { get; } = new("plan_changed");

    /// <summary><c>amended</c></summary>
    public static SubscriptionUpdateType Amended { get; } = new("amended");

    /// <summary><c>units_changed</c></summary>
    public static SubscriptionUpdateType UnitsChanged { get; } = new("units_changed");

    /// <summary><c>paused</c></summary>
    public static SubscriptionUpdateType Paused { get; } = new("paused");

    /// <summary><c>cancellation_scheduled</c></summary>
    public static SubscriptionUpdateType CancellationScheduled { get; } = new("cancellation_scheduled");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown =>
        Value
            is "activated"
                or "trial_ended"
                or "billing_configuration_updated"
                or "plan_changed"
                or "amended"
                or "units_changed"
                or "paused"
                or "cancellation_scheduled";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>activated</c></summary>
        public const string Activated = "activated";

        /// <summary><c>trial_ended</c></summary>
        public const string TrialEnded = "trial_ended";

        /// <summary><c>billing_configuration_updated</c></summary>
        public const string BillingConfigurationUpdated = "billing_configuration_updated";

        /// <summary><c>plan_changed</c></summary>
        public const string PlanChanged = "plan_changed";

        /// <summary><c>amended</c></summary>
        public const string Amended = "amended";

        /// <summary><c>units_changed</c></summary>
        public const string UnitsChanged = "units_changed";

        /// <summary><c>paused</c></summary>
        public const string Paused = "paused";

        /// <summary><c>cancellation_scheduled</c></summary>
        public const string CancellationScheduled = "cancellation_scheduled";
    }

    static SubscriptionUpdateType IStringEnum<SubscriptionUpdateType>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator SubscriptionUpdateType(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
