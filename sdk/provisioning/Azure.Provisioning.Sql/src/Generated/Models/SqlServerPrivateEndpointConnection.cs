// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// A private endpoint connection under a server.
/// </summary>
public partial class SqlServerPrivateEndpointConnection : ProvisioningConstruct
{
    /// <summary>
    /// Resource ID.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Private endpoint connection properties.
    /// </summary>
    public BicepValue<ServerPrivateEndpointConnectionProperties> Properties { get => _properties; }
    private readonly BicepValue<ServerPrivateEndpointConnectionProperties> _properties;

    /// <summary>
    /// Creates a new SqlServerPrivateEndpointConnection.
    /// </summary>
    public SqlServerPrivateEndpointConnection()
    {
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _properties = BicepValue<ServerPrivateEndpointConnectionProperties>.DefineProperty(this, "Properties", ["properties"], isOutput: true);
    }
}
