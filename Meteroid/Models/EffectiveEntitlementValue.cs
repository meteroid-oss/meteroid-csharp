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
[JsonConverter(typeof(EffectiveEntitlementValueConverter))]
public abstract partial record EffectiveEntitlementValue
{
    private EffectiveEntitlementValue() { }

    /// <summary>The <c>type</c> tag of this variant.</summary>
    public abstract string Type { get; }

    /// <summary>The <c>BOOLEAN</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record Boolean(BooleanEffectiveEntitlementValue Value) : EffectiveEntitlementValue
    {
        /// <inheritdoc/>
        public override string Type => "BOOLEAN";
    }

    /// <summary>The <c>METERED</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record Metered(MeteredEffectiveEntitlementValue Value) : EffectiveEntitlementValue
    {
        /// <inheritdoc/>
        public override string Type => "METERED";
    }

    /// <summary>The <c>CONFIG</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record Config(ConfigEffectiveEntitlementValue Value) : EffectiveEntitlementValue
    {
        /// <inheritdoc/>
        public override string Type => "CONFIG";
    }

    /// <summary>A variant unknown to this SDK version, kept as the raw JSON object.</summary>
    /// <param name="Tag">The <c>type</c> of the variant.</param>
    /// <param name="Raw">The whole JSON object.</param>
    public sealed record Unrecognized(string Tag, JsonElement Raw) : EffectiveEntitlementValue
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

internal sealed class EffectiveEntitlementValueConverter : JsonConverter<EffectiveEntitlementValue>
{
    public override EffectiveEntitlementValue Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        using var document = JsonDocument.ParseValue(ref reader);
        var root = document.RootElement;
        return Json.Tag(root, "type") switch
        {
            "BOOLEAN" => new EffectiveEntitlementValue.Boolean(
                Json.Deserialize<BooleanEffectiveEntitlementValue>(root, options)
            ),
            "METERED" => new EffectiveEntitlementValue.Metered(
                Json.Deserialize<MeteredEffectiveEntitlementValue>(root, options)
            ),
            "CONFIG" => new EffectiveEntitlementValue.Config(
                Json.Deserialize<ConfigEffectiveEntitlementValue>(root, options)
            ),
            var tag => new EffectiveEntitlementValue.Unrecognized(tag ?? string.Empty, root.Clone()),
        };
    }

    public override void Write(Utf8JsonWriter writer, EffectiveEntitlementValue value, JsonSerializerOptions options)
    {
        if (value is EffectiveEntitlementValue.Unrecognized unrecognized)
        {
            unrecognized.Raw.WriteTo(writer);
            return;
        }
        var fields = new List<KeyValuePair<string, JsonNode?>>();
        switch (value)
        {
            case EffectiveEntitlementValue.Boolean variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
            case EffectiveEntitlementValue.Metered variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
            case EffectiveEntitlementValue.Config variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
        }
        Json.WriteTagged(writer, "type", value.Type, fields, options);
    }
}
