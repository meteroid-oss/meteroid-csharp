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
/// Online (card/direct debit), BankTransfer, or External.
/// </summary>
/// <remarks>
/// Match on the nested variant records. <see cref="Unrecognized"/> holds variants added to the API
/// after this SDK version, as raw JSON.
/// </remarks>
[JsonConverter(typeof(PaymentMethodsConfigConverter))]
public abstract partial record PaymentMethodsConfig
{
    private PaymentMethodsConfig() { }

    /// <summary>The <c>type</c> tag of this variant.</summary>
    public abstract string Type { get; }

    /// <summary>The <c>online</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record Online(OnlinePaymentMethodConfig Value) : PaymentMethodsConfig
    {
        /// <inheritdoc/>
        public override string Type => "online";
    }

    /// <summary>The <c>bank_transfer</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record BankTransfer(BankTransferPaymentMethodConfig Value) : PaymentMethodsConfig
    {
        /// <inheritdoc/>
        public override string Type => "bank_transfer";
    }

    /// <summary>The <c>external</c> variant.</summary>
    /// <param name="Value">The fields of the variant.</param>
    public sealed record External(ExternalPaymentMethodConfig Value) : PaymentMethodsConfig
    {
        /// <inheritdoc/>
        public override string Type => "external";
    }

    /// <summary>A variant unknown to this SDK version, kept as the raw JSON object.</summary>
    /// <param name="Tag">The <c>type</c> of the variant.</param>
    /// <param name="Raw">The whole JSON object.</param>
    public sealed record Unrecognized(string Tag, JsonElement Raw) : PaymentMethodsConfig
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

internal sealed class PaymentMethodsConfigConverter : JsonConverter<PaymentMethodsConfig>
{
    public override PaymentMethodsConfig Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        using var document = JsonDocument.ParseValue(ref reader);
        var root = document.RootElement;
        return Json.Tag(root, "type") switch
        {
            "online" => new PaymentMethodsConfig.Online(Json.Deserialize<OnlinePaymentMethodConfig>(root, options)),
            "bank_transfer" => new PaymentMethodsConfig.BankTransfer(
                Json.Deserialize<BankTransferPaymentMethodConfig>(root, options)
            ),
            "external" => new PaymentMethodsConfig.External(
                Json.Deserialize<ExternalPaymentMethodConfig>(root, options)
            ),
            var tag => new PaymentMethodsConfig.Unrecognized(tag ?? string.Empty, root.Clone()),
        };
    }

    public override void Write(Utf8JsonWriter writer, PaymentMethodsConfig value, JsonSerializerOptions options)
    {
        if (value is PaymentMethodsConfig.Unrecognized unrecognized)
        {
            unrecognized.Raw.WriteTo(writer);
            return;
        }
        var fields = new List<KeyValuePair<string, JsonNode?>>();
        switch (value)
        {
            case PaymentMethodsConfig.Online variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
            case PaymentMethodsConfig.BankTransfer variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
            case PaymentMethodsConfig.External variant:
                fields.AddRange(Json.ToObject(variant.Value, options));
                break;
        }
        Json.WriteTagged(writer, "type", value.Type, fields, options);
    }
}
