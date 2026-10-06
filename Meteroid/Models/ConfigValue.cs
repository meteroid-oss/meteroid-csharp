// this file is @generated
#pragma warning disable CS0612, CS0618 // generated code may use deprecated API
#pragma warning disable CA1707, CA1711, CA1716, CA1720 // identifiers follow the API's own names
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Meteroid.Models;

/// <summary>
/// A static, typed configuration value carried by a Config entitlement. Resolved synchronously
/// through the entitlement hierarchy — no metric, no usage counter.
/// </summary>
/// <remarks>
/// Match on the nested variant records. <see cref="Unrecognized"/> holds variants added to the API
/// after this SDK version, as raw JSON.
/// </remarks>
[JsonConverter(typeof(ConfigValueConverter))]
public abstract partial record ConfigValue
{
    private ConfigValue() { }

    /// <summary>The <c>kind</c> tag of this variant.</summary>
    public abstract string Kind { get; }

    /// <summary>The <c>NUMBER</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record Number(NumberConfigValue Value) : ConfigValue
    {
        /// <inheritdoc/>
        public override string Kind => "NUMBER";
    }

    /// <summary>The <c>BOOLEAN</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record Boolean(BooleanConfigValue Value) : ConfigValue
    {
        /// <inheritdoc/>
        public override string Kind => "BOOLEAN";
    }

    /// <summary>The <c>TEXT</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record Text(TextConfigValue Value) : ConfigValue
    {
        /// <inheritdoc/>
        public override string Kind => "TEXT";
    }

    /// <summary>The <c>JSON</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record Json(JsonConfigValue Value) : ConfigValue
    {
        /// <inheritdoc/>
        public override string Kind => "JSON";
    }

    /// <summary>A variant unknown to this SDK version, kept as the raw JSON object.</summary>
    /// <param name="Tag">The <c>kind</c> of the variant.</param>
    /// <param name="Raw">The whole JSON object.</param>
    public sealed record Unrecognized(string Tag, JsonElement Raw) : ConfigValue
    {
        /// <inheritdoc/>
        public override string Kind => Tag;

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

internal sealed class ConfigValueConverter : JsonConverter<ConfigValue>
{
    public override ConfigValue Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using var document = JsonDocument.ParseValue(ref reader);
        var root = document.RootElement;
        return Json.Tag(root, "kind") switch
        {
            "NUMBER" => new ConfigValue.Number(Json.Deserialize<NumberConfigValue>(root, options)),
            "BOOLEAN" => new ConfigValue.Boolean(Json.Deserialize<BooleanConfigValue>(root, options)),
            "TEXT" => new ConfigValue.Text(Json.Deserialize<TextConfigValue>(root, options)),
            "JSON" => new ConfigValue.Json(Json.Deserialize<JsonConfigValue>(root, options)),
            var tag => new ConfigValue.Unrecognized(tag ?? string.Empty, root.Clone()),
        };
    }

    public override void Write(Utf8JsonWriter writer, ConfigValue value, JsonSerializerOptions options)
    {
        if (value is ConfigValue.Unrecognized unrecognized)
        {
            unrecognized.Raw.WriteTo(writer);
            return;
        }
        var fields = new List<KeyValuePair<string, JsonNode?>>();
        switch (value)
        {
            case ConfigValue.Number variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
            case ConfigValue.Boolean variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
            case ConfigValue.Text variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
            case ConfigValue.Json variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
        }
        Json.WriteTagged(writer, "kind", value.Kind, fields, options);
    }
}
