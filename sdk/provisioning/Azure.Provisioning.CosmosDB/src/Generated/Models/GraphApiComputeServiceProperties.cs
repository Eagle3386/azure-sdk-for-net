// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// Properties for GraphAPIComputeServiceResource.
/// </summary>
public partial class GraphApiComputeServiceProperties : CosmosDBServiceProperties
{
    /// <summary>
    /// GraphAPICompute endpoint for the service.
    /// </summary>
    public BicepValue<string> GraphApiComputeEndpoint { get => _graphApiComputeEndpoint; set => _graphApiComputeEndpoint.Assign(value); }
    private readonly BicepValue<string> _graphApiComputeEndpoint;

    /// <summary>
    /// An array that contains all of the locations for the service.
    /// </summary>
    public BicepList<GraphApiComputeRegionalService> Locations { get => _locations; }
    private readonly BicepList<GraphApiComputeRegionalService> _locations;

    /// <summary>
    /// Creates a new GraphApiComputeServiceProperties.
    /// </summary>
    public GraphApiComputeServiceProperties() : base()
    {
        BicepValue<string>.DefineProperty(this, "serviceType", ["serviceType"], defaultValue: "GraphAPICompute");
        _graphApiComputeEndpoint = BicepValue<string>.DefineProperty(this, "GraphApiComputeEndpoint", ["graphApiComputeEndpoint"]);
        _locations = BicepList<GraphApiComputeRegionalService>.DefineProperty(this, "Locations", ["locations"], isOutput: true);
    }
}
