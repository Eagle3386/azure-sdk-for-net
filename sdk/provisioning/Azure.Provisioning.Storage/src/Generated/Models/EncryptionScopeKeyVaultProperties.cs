// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Storage;

/// <summary>
/// The key vault properties for the encryption scope. This is a required field
/// if encryption scope &apos;source&apos; attribute is set to
/// &apos;Microsoft.KeyVault&apos;.
/// </summary>
public partial class EncryptionScopeKeyVaultProperties : ProvisioningConstruct
{
    /// <summary>
    /// The object identifier for a key vault key object. When applied, the
    /// encryption scope will use the key referenced by the identifier to
    /// enable customer-managed key support on this encryption scope.
    /// </summary>
    public BicepValue<Uri> KeyUri { get => _keyUri; set => _keyUri.Assign(value); }
    private readonly BicepValue<Uri> _keyUri;

    /// <summary>
    /// The object identifier of the current versioned Key Vault Key in use.
    /// </summary>
    public BicepValue<string> CurrentVersionedKeyIdentifier { get => _currentVersionedKeyIdentifier; }
    private readonly BicepValue<string> _currentVersionedKeyIdentifier;

    /// <summary>
    /// Timestamp of last rotation of the Key Vault Key.
    /// </summary>
    public BicepValue<DateTimeOffset> LastKeyRotationTimestamp { get => _lastKeyRotationTimestamp; }
    private readonly BicepValue<DateTimeOffset> _lastKeyRotationTimestamp;

    /// <summary>
    /// Creates a new EncryptionScopeKeyVaultProperties.
    /// </summary>
    public EncryptionScopeKeyVaultProperties()
    {
        _keyUri = BicepValue<Uri>.DefineProperty(this, "KeyUri", ["keyUri"]);
        _currentVersionedKeyIdentifier = BicepValue<string>.DefineProperty(this, "CurrentVersionedKeyIdentifier", ["currentVersionedKeyIdentifier"], isOutput: true);
        _lastKeyRotationTimestamp = BicepValue<DateTimeOffset>.DefineProperty(this, "LastKeyRotationTimestamp", ["lastKeyRotationTimestamp"], isOutput: true);
    }
}
