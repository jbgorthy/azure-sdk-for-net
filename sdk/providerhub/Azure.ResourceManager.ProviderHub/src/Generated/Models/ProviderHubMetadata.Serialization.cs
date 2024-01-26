// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ProviderHub.Models
{
    public partial class ProviderHubMetadata : IUtf8JsonSerializable, IJsonModel<ProviderHubMetadata>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ProviderHubMetadata>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ProviderHubMetadata>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProviderHubMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProviderHubMetadata)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ProviderAuthorizations))
            {
                writer.WritePropertyName("providerAuthorizations"u8);
                writer.WriteStartArray();
                foreach (var item in ProviderAuthorizations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ProviderAuthentication))
            {
                writer.WritePropertyName("providerAuthentication"u8);
                writer.WriteObjectValue(ProviderAuthentication);
            }
            if (Optional.IsDefined(ThirdPartyProviderAuthorization))
            {
                writer.WritePropertyName("thirdPartyProviderAuthorization"u8);
                writer.WriteObjectValue(ThirdPartyProviderAuthorization);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        ProviderHubMetadata IJsonModel<ProviderHubMetadata>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProviderHubMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ProviderHubMetadata)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeProviderHubMetadata(document.RootElement, options);
        }

        internal static ProviderHubMetadata DeserializeProviderHubMetadata(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<ResourceProviderAuthorization>> providerAuthorizations = default;
            Optional<ResourceProviderAuthentication> providerAuthentication = default;
            Optional<ThirdPartyProviderAuthorization> thirdPartyProviderAuthorization = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("providerAuthorizations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceProviderAuthorization> array = new List<ResourceProviderAuthorization>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceProviderAuthorization.DeserializeResourceProviderAuthorization(item));
                    }
                    providerAuthorizations = array;
                    continue;
                }
                if (property.NameEquals("providerAuthentication"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    providerAuthentication = ResourceProviderAuthentication.DeserializeResourceProviderAuthentication(property.Value);
                    continue;
                }
                if (property.NameEquals("thirdPartyProviderAuthorization"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    thirdPartyProviderAuthorization = ThirdPartyProviderAuthorization.DeserializeThirdPartyProviderAuthorization(property.Value);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ProviderHubMetadata(Optional.ToList(providerAuthorizations), providerAuthentication.Value, thirdPartyProviderAuthorization.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ProviderHubMetadata>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProviderHubMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ProviderHubMetadata)} does not support '{options.Format}' format.");
            }
        }

        ProviderHubMetadata IPersistableModel<ProviderHubMetadata>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ProviderHubMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeProviderHubMetadata(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ProviderHubMetadata)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ProviderHubMetadata>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
