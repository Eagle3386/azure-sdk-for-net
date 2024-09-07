// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Resources;

/// <summary>
/// Deployment operation parameters.
/// </summary>
public partial class ArmDeploymentContent : ProvisioningConstruct
{
    /// <summary>
    /// The location to store the deployment data.
    /// </summary>
    public BicepValue<AzureLocation> Location { get => _location; set => _location.Assign(value); }
    private readonly BicepValue<AzureLocation> _location;

    /// <summary>
    /// The deployment properties.
    /// </summary>
    public BicepValue<ArmDeploymentProperties> Properties { get => _properties; }
    private readonly BicepValue<ArmDeploymentProperties> _properties;

    /// <summary>
    /// Deployment tags.
    /// </summary>
    public BicepDictionary<string> Tags { get => _tags; set => _tags.Assign(value); }
    private readonly BicepDictionary<string> _tags;

    /// <summary>
    /// Creates a new ArmDeploymentContent.
    /// </summary>
    public ArmDeploymentContent()
    {
        _location = BicepValue<AzureLocation>.DefineProperty(this, "Location", ["location"]);
        _properties = BicepValue<ArmDeploymentProperties>.DefineProperty(this, "Properties", ["properties"], isOutput: true);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["tags"]);
    }
}
