// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ApiManagement
{
    public partial class ServiceWorkspaceBackendResource : IJsonModel<ApiManagementBackendData>
    {
        void IJsonModel<ApiManagementBackendData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ApiManagementBackendData>)Data).Write(writer, options);

        ApiManagementBackendData IJsonModel<ApiManagementBackendData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ApiManagementBackendData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ApiManagementBackendData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        ApiManagementBackendData IPersistableModel<ApiManagementBackendData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ApiManagementBackendData>(data, options);

        string IPersistableModel<ApiManagementBackendData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ApiManagementBackendData>)Data).GetFormatFromOptions(options);
    }
}
