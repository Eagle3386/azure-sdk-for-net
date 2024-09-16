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
using Azure.ResourceManager.ApiManagement.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    public partial class ApiManagementBackendData : IUtf8JsonSerializable, IJsonModel<ApiManagementBackendData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApiManagementBackendData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ApiManagementBackendData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementBackendData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiManagementBackendData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Title))
            {
                writer.WritePropertyName("title"u8);
                writer.WriteStringValue(Title);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(ResourceUri))
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceUri.AbsoluteUri);
            }
            if (Optional.IsDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteObjectValue(Properties, options);
            }
            if (Optional.IsDefined(Credentials))
            {
                writer.WritePropertyName("credentials"u8);
                writer.WriteObjectValue(Credentials, options);
            }
            if (Optional.IsDefined(Proxy))
            {
                writer.WritePropertyName("proxy"u8);
                writer.WriteObjectValue(Proxy, options);
            }
            if (Optional.IsDefined(Tls))
            {
                writer.WritePropertyName("tls"u8);
                writer.WriteObjectValue(Tls, options);
            }
            if (Optional.IsDefined(CircuitBreaker))
            {
                writer.WritePropertyName("circuitBreaker"u8);
                writer.WriteObjectValue(CircuitBreaker, options);
            }
            if (Optional.IsDefined(Pool))
            {
                writer.WritePropertyName("pool"u8);
                writer.WriteObjectValue(Pool, options);
            }
            if (Optional.IsDefined(TypePropertiesType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(TypePropertiesType.Value.ToString());
            }
            if (Optional.IsDefined(Uri))
            {
                writer.WritePropertyName("url"u8);
                writer.WriteStringValue(Uri.AbsoluteUri);
            }
            if (Optional.IsDefined(Protocol))
            {
                writer.WritePropertyName("protocol"u8);
                writer.WriteStringValue(Protocol.Value.ToString());
            }
            writer.WriteEndObject();
        }

        ApiManagementBackendData IJsonModel<ApiManagementBackendData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementBackendData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ApiManagementBackendData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApiManagementBackendData(document.RootElement, options);
        }

        internal static ApiManagementBackendData DeserializeApiManagementBackendData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string title = default;
            string description = default;
            Uri resourceId = default;
            BackendProperties properties = default;
            BackendCredentialsContract credentials = default;
            BackendProxyContract proxy = default;
            BackendTlsProperties tls = default;
            BackendCircuitBreaker circuitBreaker = default;
            BackendBaseParametersPool pool = default;
            BackendType? type0 = default;
            Uri uri = default;
            BackendProtocol? protocol = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("title"u8))
                        {
                            title = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("resourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            resourceId = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("properties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            properties = BackendProperties.DeserializeBackendProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("credentials"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            credentials = BackendCredentialsContract.DeserializeBackendCredentialsContract(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("proxy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            proxy = BackendProxyContract.DeserializeBackendProxyContract(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("tls"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tls = BackendTlsProperties.DeserializeBackendTlsProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("circuitBreaker"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            circuitBreaker = BackendCircuitBreaker.DeserializeBackendCircuitBreaker(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("pool"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            pool = BackendBaseParametersPool.DeserializeBackendBaseParametersPool(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("type"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            type0 = new BackendType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("url"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            uri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("protocol"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            protocol = new BackendProtocol(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ApiManagementBackendData(
                id,
                name,
                type,
                systemData,
                title,
                description,
                resourceId,
                properties,
                credentials,
                proxy,
                tls,
                circuitBreaker,
                pool,
                type0,
                uri,
                protocol,
                serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Id), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  id: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Id))
                {
                    builder.Append("  id: ");
                    builder.AppendLine($"'{Id.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SystemData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  systemData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SystemData))
                {
                    builder.Append("  systemData: ");
                    builder.AppendLine($"'{SystemData.ToString()}'");
                }
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Title), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    title: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Title))
                {
                    builder.Append("    title: ");
                    if (Title.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Title}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Title}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Description), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    description: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Description))
                {
                    builder.Append("    description: ");
                    if (Description.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Description}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Description}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ResourceUri), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    resourceId: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ResourceUri))
                {
                    builder.Append("    resourceId: ");
                    builder.AppendLine($"'{ResourceUri.AbsoluteUri}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("BackendServiceFabricCluster", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    properties: ");
                builder.AppendLine("{");
                builder.AppendLine("      properties: {");
                builder.Append("        serviceFabricCluster: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("      }");
                builder.AppendLine("    }");
            }
            else
            {
                if (Optional.IsDefined(Properties))
                {
                    builder.Append("    properties: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Properties, options, 4, false, "    properties: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Credentials), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    credentials: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Credentials))
                {
                    builder.Append("    credentials: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Credentials, options, 4, false, "    credentials: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Proxy), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    proxy: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Proxy))
                {
                    builder.Append("    proxy: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Proxy, options, 4, false, "    proxy: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Tls), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    tls: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Tls))
                {
                    builder.Append("    tls: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Tls, options, 4, false, "    tls: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("CircuitBreakerRules", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    circuitBreaker: ");
                builder.AppendLine("{");
                builder.AppendLine("      circuitBreaker: {");
                builder.Append("        rules: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("      }");
                builder.AppendLine("    }");
            }
            else
            {
                if (Optional.IsDefined(CircuitBreaker))
                {
                    builder.Append("    circuitBreaker: ");
                    BicepSerializationHelpers.AppendChildObject(builder, CircuitBreaker, options, 4, false, "    circuitBreaker: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("PoolServices", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    pool: ");
                builder.AppendLine("{");
                builder.AppendLine("      pool: {");
                builder.Append("        services: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("      }");
                builder.AppendLine("    }");
            }
            else
            {
                if (Optional.IsDefined(Pool))
                {
                    builder.Append("    pool: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Pool, options, 4, false, "    pool: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TypePropertiesType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    type: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TypePropertiesType))
                {
                    builder.Append("    type: ");
                    builder.AppendLine($"'{TypePropertiesType.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Uri), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    url: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Uri))
                {
                    builder.Append("    url: ");
                    builder.AppendLine($"'{Uri.AbsoluteUri}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Protocol), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    protocol: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Protocol))
                {
                    builder.Append("    protocol: ");
                    builder.AppendLine($"'{Protocol.Value.ToString()}'");
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ApiManagementBackendData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementBackendData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ApiManagementBackendData)} does not support writing '{options.Format}' format.");
            }
        }

        ApiManagementBackendData IPersistableModel<ApiManagementBackendData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiManagementBackendData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeApiManagementBackendData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ApiManagementBackendData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApiManagementBackendData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
