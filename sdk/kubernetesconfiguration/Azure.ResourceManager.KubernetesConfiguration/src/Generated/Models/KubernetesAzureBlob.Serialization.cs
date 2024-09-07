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

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    public partial class KubernetesAzureBlob : IUtf8JsonSerializable, IJsonModel<KubernetesAzureBlob>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KubernetesAzureBlob>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<KubernetesAzureBlob>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesAzureBlob>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubernetesAzureBlob)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Uri))
            {
                if (Uri != null)
                {
                    writer.WritePropertyName("url"u8);
                    writer.WriteStringValue(Uri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("url");
                }
            }
            if (Optional.IsDefined(ContainerName))
            {
                if (ContainerName != null)
                {
                    writer.WritePropertyName("containerName"u8);
                    writer.WriteStringValue(ContainerName);
                }
                else
                {
                    writer.WriteNull("containerName");
                }
            }
            if (Optional.IsDefined(TimeoutInSeconds))
            {
                if (TimeoutInSeconds != null)
                {
                    writer.WritePropertyName("timeoutInSeconds"u8);
                    writer.WriteNumberValue(TimeoutInSeconds.Value);
                }
                else
                {
                    writer.WriteNull("timeoutInSeconds");
                }
            }
            if (Optional.IsDefined(SyncIntervalInSeconds))
            {
                if (SyncIntervalInSeconds != null)
                {
                    writer.WritePropertyName("syncIntervalInSeconds"u8);
                    writer.WriteNumberValue(SyncIntervalInSeconds.Value);
                }
                else
                {
                    writer.WriteNull("syncIntervalInSeconds");
                }
            }
            if (Optional.IsDefined(ServicePrincipal))
            {
                if (ServicePrincipal != null)
                {
                    writer.WritePropertyName("servicePrincipal"u8);
                    writer.WriteObjectValue(ServicePrincipal, options);
                }
                else
                {
                    writer.WriteNull("servicePrincipal");
                }
            }
            if (Optional.IsDefined(AccountKey))
            {
                if (AccountKey != null)
                {
                    writer.WritePropertyName("accountKey"u8);
                    writer.WriteStringValue(AccountKey);
                }
                else
                {
                    writer.WriteNull("accountKey");
                }
            }
            if (Optional.IsDefined(SasToken))
            {
                if (SasToken != null)
                {
                    writer.WritePropertyName("sasToken"u8);
                    writer.WriteStringValue(SasToken);
                }
                else
                {
                    writer.WriteNull("sasToken");
                }
            }
            if (Optional.IsDefined(ManagedIdentity))
            {
                if (ManagedIdentity != null)
                {
                    writer.WritePropertyName("managedIdentity"u8);
                    writer.WriteObjectValue(ManagedIdentity, options);
                }
                else
                {
                    writer.WriteNull("managedIdentity");
                }
            }
            if (Optional.IsDefined(LocalAuthRef))
            {
                if (LocalAuthRef != null)
                {
                    writer.WritePropertyName("localAuthRef"u8);
                    writer.WriteStringValue(LocalAuthRef);
                }
                else
                {
                    writer.WriteNull("localAuthRef");
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

        KubernetesAzureBlob IJsonModel<KubernetesAzureBlob>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesAzureBlob>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KubernetesAzureBlob)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKubernetesAzureBlob(document.RootElement, options);
        }

        internal static KubernetesAzureBlob DeserializeKubernetesAzureBlob(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Uri url = default;
            string containerName = default;
            long? timeoutInSeconds = default;
            long? syncIntervalInSeconds = default;
            KubernetesServicePrincipal servicePrincipal = default;
            string accountKey = default;
            string sasToken = default;
            KubernetesAzureBlobManagedIdentity managedIdentity = default;
            string localAuthRef = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("url"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        url = null;
                        continue;
                    }
                    url = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("containerName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        containerName = null;
                        continue;
                    }
                    containerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timeoutInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        timeoutInSeconds = null;
                        continue;
                    }
                    timeoutInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("syncIntervalInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        syncIntervalInSeconds = null;
                        continue;
                    }
                    syncIntervalInSeconds = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("servicePrincipal"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        servicePrincipal = null;
                        continue;
                    }
                    servicePrincipal = KubernetesServicePrincipal.DeserializeKubernetesServicePrincipal(property.Value, options);
                    continue;
                }
                if (property.NameEquals("accountKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        accountKey = null;
                        continue;
                    }
                    accountKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sasToken"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        sasToken = null;
                        continue;
                    }
                    sasToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("managedIdentity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        managedIdentity = null;
                        continue;
                    }
                    managedIdentity = KubernetesAzureBlobManagedIdentity.DeserializeKubernetesAzureBlobManagedIdentity(property.Value, options);
                    continue;
                }
                if (property.NameEquals("localAuthRef"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        localAuthRef = null;
                        continue;
                    }
                    localAuthRef = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new KubernetesAzureBlob(
                url,
                containerName,
                timeoutInSeconds,
                syncIntervalInSeconds,
                servicePrincipal,
                accountKey,
                sasToken,
                managedIdentity,
                localAuthRef,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Uri), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  url: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Uri))
                {
                    builder.Append("  url: ");
                    builder.AppendLine($"'{Uri.AbsoluteUri}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ContainerName), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  containerName: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ContainerName))
                {
                    builder.Append("  containerName: ");
                    if (ContainerName.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ContainerName}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ContainerName}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TimeoutInSeconds), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  timeoutInSeconds: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(TimeoutInSeconds))
                {
                    builder.Append("  timeoutInSeconds: ");
                    builder.AppendLine($"'{TimeoutInSeconds.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SyncIntervalInSeconds), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  syncIntervalInSeconds: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SyncIntervalInSeconds))
                {
                    builder.Append("  syncIntervalInSeconds: ");
                    builder.AppendLine($"'{SyncIntervalInSeconds.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ServicePrincipal), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  servicePrincipal: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ServicePrincipal))
                {
                    builder.Append("  servicePrincipal: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ServicePrincipal, options, 2, false, "  servicePrincipal: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AccountKey), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  accountKey: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AccountKey))
                {
                    builder.Append("  accountKey: ");
                    if (AccountKey.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{AccountKey}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{AccountKey}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SasToken), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  sasToken: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SasToken))
                {
                    builder.Append("  sasToken: ");
                    if (SasToken.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{SasToken}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{SasToken}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("ManagedIdentityClientId", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  managedIdentity: ");
                builder.AppendLine("{");
                builder.Append("    clientId: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("  }");
            }
            else
            {
                if (Optional.IsDefined(ManagedIdentity))
                {
                    builder.Append("  managedIdentity: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ManagedIdentity, options, 2, false, "  managedIdentity: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LocalAuthRef), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  localAuthRef: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LocalAuthRef))
                {
                    builder.Append("  localAuthRef: ");
                    if (LocalAuthRef.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{LocalAuthRef}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{LocalAuthRef}'");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<KubernetesAzureBlob>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesAzureBlob>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(KubernetesAzureBlob)} does not support writing '{options.Format}' format.");
            }
        }

        KubernetesAzureBlob IPersistableModel<KubernetesAzureBlob>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KubernetesAzureBlob>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeKubernetesAzureBlob(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(KubernetesAzureBlob)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<KubernetesAzureBlob>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
