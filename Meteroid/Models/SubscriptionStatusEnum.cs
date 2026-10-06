// this file is @generated
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// One of the known values below, or any other string a newer API version sends.
/// </summary>
/// <param name="Value">The JSON value.</param>
[JsonConverter(typeof(StringEnumConverter<SubscriptionStatusEnum>))]
public readonly partial record struct SubscriptionStatusEnum(string Value) : IStringEnum<SubscriptionStatusEnum>
{
    /// <summary><c>PENDING_ACTIVATION</c></summary>
    public static SubscriptionStatusEnum PendingActivation { get; } = new("PENDING_ACTIVATION");

    /// <summary><c>PENDING_CHARGE</c></summary>
    public static SubscriptionStatusEnum PendingCharge { get; } = new("PENDING_CHARGE");

    /// <summary><c>TRIAL_ACTIVE</c></summary>
    public static SubscriptionStatusEnum TrialActive { get; } = new("TRIAL_ACTIVE");

    /// <summary><c>ACTIVE</c></summary>
    public static SubscriptionStatusEnum Active { get; } = new("ACTIVE");

    /// <summary><c>TRIAL_EXPIRED</c></summary>
    public static SubscriptionStatusEnum TrialExpired { get; } = new("TRIAL_EXPIRED");

    /// <summary><c>PAUSED</c></summary>
    public static SubscriptionStatusEnum Paused { get; } = new("PAUSED");

    /// <summary><c>SUSPENDED</c></summary>
    public static SubscriptionStatusEnum Suspended { get; } = new("SUSPENDED");

    /// <summary><c>CANCELLED</c></summary>
    public static SubscriptionStatusEnum Cancelled { get; } = new("CANCELLED");

    /// <summary><c>ABORTED</c></summary>
    public static SubscriptionStatusEnum Aborted { get; } = new("ABORTED");

    /// <summary><c>COMPLETED</c></summary>
    public static SubscriptionStatusEnum Completed { get; } = new("COMPLETED");

    /// <summary><c>SUPERSEDED</c></summary>
    public static SubscriptionStatusEnum Superseded { get; } = new("SUPERSEDED");

    /// <summary><c>ERRORED</c></summary>
    public static SubscriptionStatusEnum Errored { get; } = new("ERRORED");

    /// <summary>Whether this SDK version knows the value.</summary>
    public bool IsKnown =>
        Value
            is "PENDING_ACTIVATION"
                or "PENDING_CHARGE"
                or "TRIAL_ACTIVE"
                or "ACTIVE"
                or "TRIAL_EXPIRED"
                or "PAUSED"
                or "SUSPENDED"
                or "CANCELLED"
                or "ABORTED"
                or "COMPLETED"
                or "SUPERSEDED"
                or "ERRORED";

    /// <summary>The known values as constants, to <c>switch</c> on <see cref="Value"/>.</summary>
    public static class Values
    {
        /// <summary><c>PENDING_ACTIVATION</c></summary>
        public const string PendingActivation = "PENDING_ACTIVATION";

        /// <summary><c>PENDING_CHARGE</c></summary>
        public const string PendingCharge = "PENDING_CHARGE";

        /// <summary><c>TRIAL_ACTIVE</c></summary>
        public const string TrialActive = "TRIAL_ACTIVE";

        /// <summary><c>ACTIVE</c></summary>
        public const string Active = "ACTIVE";

        /// <summary><c>TRIAL_EXPIRED</c></summary>
        public const string TrialExpired = "TRIAL_EXPIRED";

        /// <summary><c>PAUSED</c></summary>
        public const string Paused = "PAUSED";

        /// <summary><c>SUSPENDED</c></summary>
        public const string Suspended = "SUSPENDED";

        /// <summary><c>CANCELLED</c></summary>
        public const string Cancelled = "CANCELLED";

        /// <summary><c>ABORTED</c></summary>
        public const string Aborted = "ABORTED";

        /// <summary><c>COMPLETED</c></summary>
        public const string Completed = "COMPLETED";

        /// <summary><c>SUPERSEDED</c></summary>
        public const string Superseded = "SUPERSEDED";

        /// <summary><c>ERRORED</c></summary>
        public const string Errored = "ERRORED";
    }

    static SubscriptionStatusEnum IStringEnum<SubscriptionStatusEnum>.FromValue(string value) => new(value);

    /// <summary>The value <paramref name="value"/>, known or not.</summary>
    /// <param name="value">The JSON value.</param>
    public static implicit operator SubscriptionStatusEnum(string value) => new(value);

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
}
