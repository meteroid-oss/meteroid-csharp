// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>CreatePlanRequest</c> object.</summary>
public sealed partial record CreatePlanRequest
{
    /// <summary>The <c>add_ons</c> property.</summary>
    [JsonPropertyName("add_ons")]
    public IReadOnlyList<PlanAddOnInput>? AddOns { get; init; }

    /// <summary>The <c>billing</c> property.</summary>
    [JsonPropertyName("billing")]
    public BillingConfig? Billing { get; init; }

    /// <summary>The <c>components</c> property.</summary>
    [JsonPropertyName("components")]
    public required IReadOnlyList<PriceComponentInput> Components { get; init; }

    /// <summary>The <c>currency</c> property.</summary>
    [JsonPropertyName("currency")]
    public required string Currency { get; init; }

    /// <summary>The <c>description</c> property.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>
    /// Entitlements to attach to this plan's version. Replacing a published plan creates a
    /// new version, and entitlements belong to a version, so passing them here keeps them
    /// attached to whichever version the call produces.
    /// </summary>
    [JsonPropertyName("entitlements")]
    public IReadOnlyList<EntitlementSpecRequest>? Entitlements { get; init; }

    /// <summary>The <c>name</c> property.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>The <c>plan_type</c> property.</summary>
    [JsonPropertyName("plan_type")]
    public required PlanTypeEnum PlanType { get; init; }

    /// <summary>The <c>product_family_id</c> property.</summary>
    [JsonPropertyName("product_family_id")]
    public required string ProductFamilyId { get; init; }

    /// <summary>The <c>self_service_rank</c> property.</summary>
    [JsonPropertyName("self_service_rank")]
    public int? SelfServiceRank { get; init; }

    /// <summary>The <c>status</c> property.</summary>
    [JsonPropertyName("status")]
    public required PlanStatusEnum Status { get; init; }

    /// <summary>
    /// The plan's amounts are quoted tax-included ("9.99 incl. VAT"): tax is carved out of
    /// them at invoice time instead of being added on top, so the customer pays the quoted
    /// price whatever rate applies. A customer who bears no tax (reverse charge, exempt,
    /// export) still pays it in full. Defaults to <c>false</c>.
    /// </summary>
    [JsonPropertyName("tax_inclusive")]
    public bool? TaxInclusive { get; init; }

    /// <summary>The <c>trial</c> property.</summary>
    [JsonPropertyName("trial")]
    public TrialConfig? Trial { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(CreatePlanRequest? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(AddOns, other.AddOns)
        && global::Meteroid.Equality.Equal(Billing, other.Billing)
        && global::Meteroid.Equality.Equal(Components, other.Components)
        && global::Meteroid.Equality.Equal(Currency, other.Currency)
        && global::Meteroid.Equality.Equal(Description, other.Description)
        && global::Meteroid.Equality.Equal(Entitlements, other.Entitlements)
        && global::Meteroid.Equality.Equal(Name, other.Name)
        && global::Meteroid.Equality.Equal(PlanType, other.PlanType)
        && global::Meteroid.Equality.Equal(ProductFamilyId, other.ProductFamilyId)
        && global::Meteroid.Equality.Equal(SelfServiceRank, other.SelfServiceRank)
        && global::Meteroid.Equality.Equal(Status, other.Status)
        && global::Meteroid.Equality.Equal(TaxInclusive, other.TaxInclusive)
        && global::Meteroid.Equality.Equal(Trial, other.Trial)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(AddOns));
        hash.Add(global::Meteroid.Equality.Hash(Billing));
        hash.Add(global::Meteroid.Equality.Hash(Components));
        hash.Add(global::Meteroid.Equality.Hash(Currency));
        hash.Add(global::Meteroid.Equality.Hash(Description));
        hash.Add(global::Meteroid.Equality.Hash(Entitlements));
        hash.Add(global::Meteroid.Equality.Hash(Name));
        hash.Add(global::Meteroid.Equality.Hash(PlanType));
        hash.Add(global::Meteroid.Equality.Hash(ProductFamilyId));
        hash.Add(global::Meteroid.Equality.Hash(SelfServiceRank));
        hash.Add(global::Meteroid.Equality.Hash(Status));
        hash.Add(global::Meteroid.Equality.Hash(TaxInclusive));
        hash.Add(global::Meteroid.Equality.Hash(Trial));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
