// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>The <c>CustomPropertyDefinition</c> object.</summary>
public sealed partial record CustomPropertyDefinition
{
    /// <summary>The <c>archived</c> property.</summary>
    [JsonPropertyName("archived")]
    public required bool Archived { get; init; }

    /// <summary>The <c>config</c> property.</summary>
    [JsonPropertyName("config")]
    public required PropertyConfig Config { get; init; }

    /// <summary>The <c>default_value</c> property.</summary>
    [JsonPropertyName("default_value")]
    public JsonNode? DefaultValue { get; init; }

    /// <summary>The <c>description</c> property.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; init; }

    /// <summary>The <c>display_order</c> property.</summary>
    [JsonPropertyName("display_order")]
    public required int DisplayOrder { get; init; }

    /// <summary>The <c>entity_type</c> property.</summary>
    [JsonPropertyName("entity_type")]
    public required CustomPropertyEntityType EntityType { get; init; }

    /// <summary>The <c>id</c> property.</summary>
    [JsonPropertyName("id")]
    public required string Id { get; init; }

    /// <summary>The <c>key</c> property.</summary>
    [JsonPropertyName("key")]
    public required string Key { get; init; }

    /// <summary>The <c>name</c> property.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; init; }

    /// <summary>The <c>property_type</c> property.</summary>
    [JsonPropertyName("property_type")]
    public required CustomPropertyType PropertyType { get; init; }

    /// <summary>The <c>required</c> property.</summary>
    [JsonPropertyName("required")]
    public required bool Required { get; init; }

    /// <summary>The properties of the JSON object this SDK version does not know, sent back as they came.</summary>
    [JsonExtensionData]
    public IDictionary<string, JsonElement>? AdditionalProperties { get; set; }

    /// <summary>Whether <paramref name="other"/> holds the same values, collections and JSON compared by content.</summary>
    /// <param name="other">The record to compare with.</param>
    /// <returns>Whether the records are equal.</returns>
    public bool Equals(CustomPropertyDefinition? other) =>
        other is not null
        && global::Meteroid.Equality.Equal(Archived, other.Archived)
        && global::Meteroid.Equality.Equal(Config, other.Config)
        && global::Meteroid.Equality.Equal(DefaultValue, other.DefaultValue)
        && global::Meteroid.Equality.Equal(Description, other.Description)
        && global::Meteroid.Equality.Equal(DisplayOrder, other.DisplayOrder)
        && global::Meteroid.Equality.Equal(EntityType, other.EntityType)
        && global::Meteroid.Equality.Equal(Id, other.Id)
        && global::Meteroid.Equality.Equal(Key, other.Key)
        && global::Meteroid.Equality.Equal(Name, other.Name)
        && global::Meteroid.Equality.Equal(PropertyType, other.PropertyType)
        && global::Meteroid.Equality.Equal(Required, other.Required)
        && global::Meteroid.Equality.Equal(AdditionalProperties, other.AdditionalProperties);

    /// <inheritdoc/>
    public override int GetHashCode()
    {
        var hash = new HashCode();
        hash.Add(global::Meteroid.Equality.Hash(Archived));
        hash.Add(global::Meteroid.Equality.Hash(Config));
        hash.Add(global::Meteroid.Equality.Hash(DefaultValue));
        hash.Add(global::Meteroid.Equality.Hash(Description));
        hash.Add(global::Meteroid.Equality.Hash(DisplayOrder));
        hash.Add(global::Meteroid.Equality.Hash(EntityType));
        hash.Add(global::Meteroid.Equality.Hash(Id));
        hash.Add(global::Meteroid.Equality.Hash(Key));
        hash.Add(global::Meteroid.Equality.Hash(Name));
        hash.Add(global::Meteroid.Equality.Hash(PropertyType));
        hash.Add(global::Meteroid.Equality.Hash(Required));
        hash.Add(global::Meteroid.Equality.Hash(AdditionalProperties));
        return hash.ToHashCode();
    }
}
