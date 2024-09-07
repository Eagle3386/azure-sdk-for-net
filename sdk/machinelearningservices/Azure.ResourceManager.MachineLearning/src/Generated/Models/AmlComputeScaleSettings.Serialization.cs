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

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class AmlComputeScaleSettings : IUtf8JsonSerializable, IJsonModel<AmlComputeScaleSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AmlComputeScaleSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AmlComputeScaleSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AmlComputeScaleSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AmlComputeScaleSettings)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("maxNodeCount"u8);
            writer.WriteNumberValue(MaxNodeCount);
            if (Optional.IsDefined(MinNodeCount))
            {
                writer.WritePropertyName("minNodeCount"u8);
                writer.WriteNumberValue(MinNodeCount.Value);
            }
            if (Optional.IsDefined(NodeIdleTimeBeforeScaleDown))
            {
                if (NodeIdleTimeBeforeScaleDown != null)
                {
                    writer.WritePropertyName("nodeIdleTimeBeforeScaleDown"u8);
                    writer.WriteStringValue(NodeIdleTimeBeforeScaleDown.Value, "P");
                }
                else
                {
                    writer.WriteNull("nodeIdleTimeBeforeScaleDown");
                }
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

        AmlComputeScaleSettings IJsonModel<AmlComputeScaleSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AmlComputeScaleSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AmlComputeScaleSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAmlComputeScaleSettings(document.RootElement, options);
        }

        internal static AmlComputeScaleSettings DeserializeAmlComputeScaleSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int maxNodeCount = default;
            int? minNodeCount = default;
            TimeSpan? nodeIdleTimeBeforeScaleDown = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("maxNodeCount"u8))
                {
                    maxNodeCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minNodeCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minNodeCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("nodeIdleTimeBeforeScaleDown"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        nodeIdleTimeBeforeScaleDown = null;
                        continue;
                    }
                    nodeIdleTimeBeforeScaleDown = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AmlComputeScaleSettings(maxNodeCount, minNodeCount, nodeIdleTimeBeforeScaleDown, serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MaxNodeCount), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  maxNodeCount: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  maxNodeCount: ");
                builder.AppendLine($"{MaxNodeCount}");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MinNodeCount), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  minNodeCount: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MinNodeCount))
                {
                    builder.Append("  minNodeCount: ");
                    builder.AppendLine($"{MinNodeCount.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(NodeIdleTimeBeforeScaleDown), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  nodeIdleTimeBeforeScaleDown: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(NodeIdleTimeBeforeScaleDown))
                {
                    builder.Append("  nodeIdleTimeBeforeScaleDown: ");
                    var formattedTimeSpan = TypeFormatters.ToString(NodeIdleTimeBeforeScaleDown.Value, "P");
                    builder.AppendLine($"'{formattedTimeSpan}'");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<AmlComputeScaleSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AmlComputeScaleSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(AmlComputeScaleSettings)} does not support writing '{options.Format}' format.");
            }
        }

        AmlComputeScaleSettings IPersistableModel<AmlComputeScaleSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AmlComputeScaleSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAmlComputeScaleSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AmlComputeScaleSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AmlComputeScaleSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
