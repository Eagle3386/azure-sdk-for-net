// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ApiManagement
{
    public partial class ServiceWorkspaceCertificateResource : IJsonModel<ApiManagementCertificateData>
    {
        void IJsonModel<ApiManagementCertificateData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ApiManagementCertificateData>)Data).Write(writer, options);

        ApiManagementCertificateData IJsonModel<ApiManagementCertificateData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ApiManagementCertificateData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ApiManagementCertificateData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        ApiManagementCertificateData IPersistableModel<ApiManagementCertificateData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ApiManagementCertificateData>(data, options);

        string IPersistableModel<ApiManagementCertificateData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ApiManagementCertificateData>)Data).GetFormatFromOptions(options);
    }
}
