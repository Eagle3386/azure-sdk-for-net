// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// Certificate resource specific properties.
/// </summary>
public partial class ManagedCertificateProperties : ProvisioningConstruct
{
    /// <summary>
    /// Provisioning state of the certificate.
    /// </summary>
    public BicepValue<ContainerAppCertificateProvisioningState> ProvisioningState { get => _provisioningState; }
    private readonly BicepValue<ContainerAppCertificateProvisioningState> _provisioningState;

    /// <summary>
    /// Subject name of the certificate.
    /// </summary>
    public BicepValue<string> SubjectName { get => _subjectName; set => _subjectName.Assign(value); }
    private readonly BicepValue<string> _subjectName;

    /// <summary>
    /// Any error occurred during the certificate provision.
    /// </summary>
    public BicepValue<string> Error { get => _error; }
    private readonly BicepValue<string> _error;

    /// <summary>
    /// Selected type of domain control validation for managed certificates.
    /// </summary>
    public BicepValue<ManagedCertificateDomainControlValidation> DomainControlValidation { get => _domainControlValidation; set => _domainControlValidation.Assign(value); }
    private readonly BicepValue<ManagedCertificateDomainControlValidation> _domainControlValidation;

    /// <summary>
    /// A TXT token used for DNS TXT domain control validation when issuing
    /// this type of managed certificates.
    /// </summary>
    public BicepValue<string> ValidationToken { get => _validationToken; }
    private readonly BicepValue<string> _validationToken;

    /// <summary>
    /// Creates a new ManagedCertificateProperties.
    /// </summary>
    public ManagedCertificateProperties()
    {
        _provisioningState = BicepValue<ContainerAppCertificateProvisioningState>.DefineProperty(this, "ProvisioningState", ["provisioningState"], isOutput: true);
        _subjectName = BicepValue<string>.DefineProperty(this, "SubjectName", ["subjectName"]);
        _error = BicepValue<string>.DefineProperty(this, "Error", ["error"], isOutput: true);
        _domainControlValidation = BicepValue<ManagedCertificateDomainControlValidation>.DefineProperty(this, "DomainControlValidation", ["domainControlValidation"]);
        _validationToken = BicepValue<string>.DefineProperty(this, "ValidationToken", ["validationToken"], isOutput: true);
    }
}
