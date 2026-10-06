// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <remarks>
/// Match on the nested variant records. <see cref="Unrecognized"/> holds variants added to the API
/// after this SDK version, as raw JSON.
/// </remarks>
[JsonConverter(typeof(SubscriptionAddOnCustomizationConverter))]
public abstract partial record SubscriptionAddOnCustomization
{
    private SubscriptionAddOnCustomization() { }

    /// <summary>The <c>type</c> tag of this variant.</summary>
    public abstract string Type { get; }

    /// <summary>The <c>PRICE_OVERRIDE</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record PriceOverride(SubscriptionAddOnPriceOverride Value) : SubscriptionAddOnCustomization
    {
        /// <inheritdoc/>
        public override string Type => "PRICE_OVERRIDE";
    }

    /// <summary>The <c>PARAMETERIZATION</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record Parameterization(SubscriptionAddOnParameterization Value) : SubscriptionAddOnCustomization
    {
        /// <inheritdoc/>
        public override string Type => "PARAMETERIZATION";
    }

    /// <summary>A variant unknown to this SDK version, kept as the raw JSON object.</summary>
    /// <param name="Tag">The <c>type</c> of the variant.</param>
    /// <param name="Raw">The whole JSON object.</param>
    public sealed record Unrecognized(string Tag, JsonElement Raw) : SubscriptionAddOnCustomization
    {
        /// <inheritdoc/>
        public override string Type => Tag;

        /// <inheritdoc/>
        public bool Equals(Unrecognized? other) =>
            other is not null
            && base.Equals(other)
            && Tag == other.Tag
            && global::Meteroid.Equality.Equal(Raw, other.Raw);

        /// <inheritdoc/>
        public override int GetHashCode() => HashCode.Combine(base.GetHashCode(), Tag);
    }
}

internal sealed class SubscriptionAddOnCustomizationConverter : JsonConverter<SubscriptionAddOnCustomization>
{
    public override SubscriptionAddOnCustomization Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        using var document = JsonDocument.ParseValue(ref reader);
        var root = document.RootElement;
        return Json.Tag(root, "type") switch
        {
            "PRICE_OVERRIDE" => new SubscriptionAddOnCustomization.PriceOverride(
                Json.Deserialize<SubscriptionAddOnPriceOverride>(root, options)
            ),
            "PARAMETERIZATION" => new SubscriptionAddOnCustomization.Parameterization(
                Json.Deserialize<SubscriptionAddOnParameterization>(root, options)
            ),
            var tag => new SubscriptionAddOnCustomization.Unrecognized(tag ?? string.Empty, root.Clone()),
        };
    }

    public override void Write(
        Utf8JsonWriter writer,
        SubscriptionAddOnCustomization value,
        JsonSerializerOptions options
    )
    {
        if (value is SubscriptionAddOnCustomization.Unrecognized unrecognized)
        {
            unrecognized.Raw.WriteTo(writer);
            return;
        }
        var fields = new List<KeyValuePair<string, JsonNode?>>();
        switch (value)
        {
            case SubscriptionAddOnCustomization.PriceOverride variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
            case SubscriptionAddOnCustomization.Parameterization variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
        }
        Json.WriteTagged(writer, "type", value.Type, fields, options);
    }
}
