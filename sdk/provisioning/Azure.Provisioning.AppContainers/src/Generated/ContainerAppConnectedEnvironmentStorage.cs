// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// ContainerAppConnectedEnvironmentStorage.
/// </summary>
public partial class ContainerAppConnectedEnvironmentStorage : Resource
{
    /// <summary>
    /// Name of the storage.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// Azure file properties.
    /// </summary>
    public BicepValue<ContainerAppAzureFileProperties> ConnectedEnvironmentStorageAzureFile { get => _connectedEnvironmentStorageAzureFile; set => _connectedEnvironmentStorageAzureFile.Assign(value); }
    private readonly BicepValue<ContainerAppAzureFileProperties> _connectedEnvironmentStorageAzureFile;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent ContainerAppConnectedEnvironment.
    /// </summary>
    public ContainerAppConnectedEnvironment? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<ContainerAppConnectedEnvironment> _parent;

    /// <summary>
    /// Creates a new ContainerAppConnectedEnvironmentStorage.
    /// </summary>
    /// <param name="resourceName">Name of the ContainerAppConnectedEnvironmentStorage.</param>
    /// <param name="resourceVersion">Version of the ContainerAppConnectedEnvironmentStorage.</param>
    /// <param name="context">Provisioning context for this resource.</param>
    public ContainerAppConnectedEnvironmentStorage(string resourceName, string? resourceVersion = default, ProvisioningContext? context = default)
        : base(resourceName, "Microsoft.App/connectedEnvironments/storages", resourceVersion, context)
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _connectedEnvironmentStorageAzureFile = BicepValue<ContainerAppAzureFileProperties>.DefineProperty(this, "ConnectedEnvironmentStorageAzureFile", ["properties", "azureFile"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<ContainerAppConnectedEnvironment>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Creates a reference to an existing
    /// ContainerAppConnectedEnvironmentStorage.
    /// </summary>
    /// <param name="resourceName">Name of the ContainerAppConnectedEnvironmentStorage.</param>
    /// <param name="resourceVersion">Version of the ContainerAppConnectedEnvironmentStorage.</param>
    /// <returns>The existing ContainerAppConnectedEnvironmentStorage resource.</returns>
    public static ContainerAppConnectedEnvironmentStorage FromExisting(string resourceName, string? resourceVersion = default) =>
        new(resourceName, resourceVersion) { IsExistingResource = true };
}
