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
/// What usage does once the credit it draws on runs out, for every denomination (currency or
/// credit unit) the plan charges usage in. A customer's wallet can override it.
/// </summary>
/// <remarks>
/// Match on the nested variant records. <see cref="Unrecognized"/> holds variants added to the API
/// after this SDK version, as raw JSON.
/// </remarks>
[JsonConverter(typeof(CreditExhaustedRuleConverter))]
public abstract partial record CreditExhaustedRule
{
    private CreditExhaustedRule() { }

    /// <summary>The <c>type</c> tag of this variant.</summary>
    public abstract string Type { get; }

    /// <summary>The <c>invoice</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record Invoice(CreditExhaustedRuleInvoiceVariant Value) : CreditExhaustedRule
    {
        /// <inheritdoc/>
        public override string Type => "invoice";
    }

    /// <summary>The <c>pause</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record Pause(CreditExhaustedRulePauseVariant Value) : CreditExhaustedRule
    {
        /// <inheritdoc/>
        public override string Type => "pause";
    }

    /// <summary>The <c>invoice_up_to</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record InvoiceUpTo(CreditCaps Value) : CreditExhaustedRule
    {
        /// <inheritdoc/>
        public override string Type => "invoice_up_to";
    }

    /// <summary>A variant unknown to this SDK version, kept as the raw JSON object.</summary>
    /// <param name="Tag">The <c>type</c> of the variant.</param>
    /// <param name="Raw">The whole JSON object.</param>
    public sealed record Unrecognized(string Tag, JsonElement Raw) : CreditExhaustedRule
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

internal sealed class CreditExhaustedRuleConverter : JsonConverter<CreditExhaustedRule>
{
    public override CreditExhaustedRule Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        using var document = JsonDocument.ParseValue(ref reader);
        var root = document.RootElement;
        return Json.Tag(root, "type") switch
        {
            "invoice" => new CreditExhaustedRule.Invoice(
                Json.Deserialize<CreditExhaustedRuleInvoiceVariant>(root, options)
            ),
            "pause" => new CreditExhaustedRule.Pause(Json.Deserialize<CreditExhaustedRulePauseVariant>(root, options)),
            "invoice_up_to" => new CreditExhaustedRule.InvoiceUpTo(Json.Deserialize<CreditCaps>(root, options)),
            var tag => new CreditExhaustedRule.Unrecognized(tag ?? string.Empty, root.Clone()),
        };
    }

    public override void Write(Utf8JsonWriter writer, CreditExhaustedRule value, JsonSerializerOptions options)
    {
        if (value is CreditExhaustedRule.Unrecognized unrecognized)
        {
            unrecognized.Raw.WriteTo(writer);
            return;
        }
        var fields = new List<KeyValuePair<string, JsonNode?>>();
        switch (value)
        {
            case CreditExhaustedRule.Invoice variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
            case CreditExhaustedRule.Pause variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
            case CreditExhaustedRule.InvoiceUpTo variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
        }
        Json.WriteTagged(writer, "type", value.Type, fields, options);
    }
}
