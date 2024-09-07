// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Resources;

/// <summary>
/// (Optional) The ID of the parent management group used during creation.
/// </summary>
public partial class ManagementGroupParentCreateOptions : ProvisioningConstruct
{
    /// <summary>
    /// The fully qualified ID for the parent management group.  For example,
    /// /providers/Microsoft.Management/managementGroups/0000000-0000-0000-0000-000000000000.
    /// </summary>
    public BicepValue<string> Id { get => _id; set => _id.Assign(value); }
    private readonly BicepValue<string> _id;

    /// <summary>
    /// The name of the parent management group.
    /// </summary>
    public BicepValue<string> Name { get => _name; }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The friendly name of the parent management group.
    /// </summary>
    public BicepValue<string> DisplayName { get => _displayName; }
    private readonly BicepValue<string> _displayName;

    /// <summary>
    /// Creates a new ManagementGroupParentCreateOptions.
    /// </summary>
    public ManagementGroupParentCreateOptions()
    {
        _id = BicepValue<string>.DefineProperty(this, "Id", ["id"]);
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isOutput: true);
        _displayName = BicepValue<string>.DefineProperty(this, "DisplayName", ["displayName"], isOutput: true);
    }
}
