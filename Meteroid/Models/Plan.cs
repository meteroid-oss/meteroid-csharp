// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>Plan</c> object.</summary>
public sealed partial record Plan
{
    /// <summary>The <c>available_parameters</c> property.</summary>
    [JsonPropertyName("available_parameters")]
    public required AvailableParameters AvailableParameters { get; init; }

    /// <summary>The <c>billing_cycles</c> property.</summary>
    [JsonPropertyName("billing_cycles")]
    public int? BillingCycles { get; init; }

    /// <summary>The <c>created_at</c> property.</summary>
    [JsonPropertyName("created_at")]
    public required DateTimeOffset CreatedAt { get; init; }

    /// <summary>The <c>currency</c> property.</summary>
    [JsonPropertyName("currency")]
    public required string Currency { get; init; }

    /// <summary>The <c>description</c> property.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>The <c>entitlements</c> property.</summary>
    [JsonPropertyName("entitlements")]
    public IReadOnlyList<Entitlement>? Entitlements { get; init; }

    /// <summary>The <c>id</c> property.</summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>The <c>minimum_commitment</c> property.</summary>
    [JsonPropertyName("minimum_commitment")]
    public MinimumCommitment? MinimumCommitment { get; init; }

    /// <summary>The <c>name</c> property.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>The <c>net_terms</c> property.</summary>
    [JsonPropertyName("net_terms")]
    public required int NetTerms { get; init; }

    /// <summary>The <c>period_start_day</c> property.</summary>
    [JsonPropertyName("period_start_day")]
    public int? PeriodStartDay { get; init; }

    /// <summary>The <c>plan_type</c> property.</summary>
    [JsonPropertyName("plan_type")]
    public required PlanTypeEnum PlanType { get; init; }

    /// <summary>The <c>price_components</c> property.</summary>
    [JsonPropertyName("price_components")]
    public required IReadOnlyList<PriceComponent> PriceComponents { get; init; }

    /// <summary>The <c>product_family</c> property.</summary>
    [JsonPropertyName("product_family")]
    public required ProductFamily ProductFamily { get; init; }

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
    public required bool TaxInclusive { get; init; }

    /// <summary>The <c>trial</c> property.</summary>
    [JsonPropertyName("trial")]
    public TrialConfig? Trial { get; init; }

    /// <summary>The <c>version</c> property.</summary>
    [JsonPropertyName("version")]
    public required int Version { get; init; }

    /// <summary>The <c>version_id</c> property.</summary>
    [JsonPropertyName("version_id")]
    public required string VersionId { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(Plan? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(AvailableParameters, other.AvailableParameters)
        && global::Meteroid.Equality.Equal(BillingCycles, other.BillingCycles)
        && global::Meteroid.Equality.Equal(CreatedAt, other.CreatedAt)
        && global::Meteroid.Equality.Equal(Currency, other.Currency)
        && global::Meteroid.Equality.Equal(Description, other.Description)
        && global::Meteroid.Equality.Equal(Entitlements, other.Entitlements)
        && global::Meteroid.Equality.Equal(Id, other.Id)
        && global::Meteroid.Equality.Equal(MinimumCommitment, other.MinimumCommitment)
        && global::Meteroid.Equality.Equal(Name, other.Name)
        && global::Meteroid.Equality.Equal(NetTerms, other.NetTerms)
        && global::Meteroid.Equality.Equal(PeriodStartDay, other.PeriodStartDay)
        && global::Meteroid.Equality.Equal(PlanType, other.PlanType)
        && global::Meteroid.Equality.Equal(PriceComponents, other.PriceComponents)
        && global::Meteroid.Equality.Equal(ProductFamily, other.ProductFamily)
        && global::Meteroid.Equality.Equal(SelfServiceRank, other.SelfServiceRank)
        && global::Meteroid.Equality.Equal(Status, other.Status)
        && global::Meteroid.Equality.Equal(TaxInclusive, other.TaxInclusive)
        && global::Meteroid.Equality.Equal(Trial, other.Trial)
        && global::Meteroid.Equality.Equal(Version, other.Version)
        && global::Meteroid.Equality.Equal(VersionId, other.VersionId)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(AvailableParameters));
        hash.Add(global::Meteroid.Equality.Hash(BillingCycles));
        hash.Add(global::Meteroid.Equality.Hash(CreatedAt));
        hash.Add(global::Meteroid.Equality.Hash(Currency));
        hash.Add(global::Meteroid.Equality.Hash(Description));
        hash.Add(global::Meteroid.Equality.Hash(Entitlements));
        hash.Add(global::Meteroid.Equality.Hash(Id));
        hash.Add(global::Meteroid.Equality.Hash(MinimumCommitment));
        hash.Add(global::Meteroid.Equality.Hash(Name));
        hash.Add(global::Meteroid.Equality.Hash(NetTerms));
        hash.Add(global::Meteroid.Equality.Hash(PeriodStartDay));
        hash.Add(global::Meteroid.Equality.Hash(PlanType));
        hash.Add(global::Meteroid.Equality.Hash(PriceComponents));
        hash.Add(global::Meteroid.Equality.Hash(ProductFamily));
        hash.Add(global::Meteroid.Equality.Hash(SelfServiceRank));
        hash.Add(global::Meteroid.Equality.Hash(Status));
        hash.Add(global::Meteroid.Equality.Hash(TaxInclusive));
        hash.Add(global::Meteroid.Equality.Hash(Trial));
        hash.Add(global::Meteroid.Equality.Hash(Version));
        hash.Add(global::Meteroid.Equality.Hash(VersionId));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
