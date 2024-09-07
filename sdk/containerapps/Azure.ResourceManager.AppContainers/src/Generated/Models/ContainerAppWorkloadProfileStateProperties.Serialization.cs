// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppWorkloadProfileStateProperties : IUtf8JsonSerializable, IJsonModel<ContainerAppWorkloadProfileStateProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppWorkloadProfileStateProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerAppWorkloadProfileStateProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppWorkloadProfileStateProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppWorkloadProfileStateProperties)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(MinimumCount))
            {
                writer.WritePropertyName("minimumCount"u8);
                writer.WriteNumberValue(MinimumCount.Value);
            }
            if (Optional.IsDefined(MaximumCount))
            {
                writer.WritePropertyName("maximumCount"u8);
                writer.WriteNumberValue(MaximumCount.Value);
            }
            if (Optional.IsDefined(CurrentCount))
            {
                writer.WritePropertyName("currentCount"u8);
                writer.WriteNumberValue(CurrentCount.Value);
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
        }

        ContainerAppWorkloadProfileStateProperties IJsonModel<ContainerAppWorkloadProfileStateProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppWorkloadProfileStateProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppWorkloadProfileStateProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppWorkloadProfileStateProperties(document.RootElement, options);
        }

        internal static ContainerAppWorkloadProfileStateProperties DeserializeContainerAppWorkloadProfileStateProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? minimumCount = default;
            int? maximumCount = default;
            int? currentCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minimumCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minimumCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maximumCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maximumCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("currentCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    currentCount = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerAppWorkloadProfileStateProperties(minimumCount, maximumCount, currentCount, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MinimumCount), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  minimumCount: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MinimumCount))
                {
                    builder.Append("  minimumCount: ");
                    builder.AppendLine($"{MinimumCount.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MaximumCount), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  maximumCount: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MaximumCount))
                {
                    builder.Append("  maximumCount: ");
                    builder.AppendLine($"{MaximumCount.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CurrentCount), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  currentCount: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CurrentCount))
                {
                    builder.Append("  currentCount: ");
                    builder.AppendLine($"{CurrentCount.Value}");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ContainerAppWorkloadProfileStateProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppWorkloadProfileStateProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppWorkloadProfileStateProperties)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerAppWorkloadProfileStateProperties IPersistableModel<ContainerAppWorkloadProfileStateProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppWorkloadProfileStateProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppWorkloadProfileStateProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppWorkloadProfileStateProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppWorkloadProfileStateProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
