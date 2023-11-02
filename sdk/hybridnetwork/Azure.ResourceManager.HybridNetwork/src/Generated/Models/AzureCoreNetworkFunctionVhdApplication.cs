// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> Azure core network function vhd application definition. </summary>
    public partial class AzureCoreNetworkFunctionVhdApplication : AzureCoreNetworkFunctionApplication
    {
        /// <summary> Initializes a new instance of AzureCoreNetworkFunctionVhdApplication. </summary>
        public AzureCoreNetworkFunctionVhdApplication()
        {
            ArtifactType = AzureCoreArtifactType.VhdImageFile;
        }

        /// <summary> Initializes a new instance of AzureCoreNetworkFunctionVhdApplication. </summary>
        /// <param name="name"> The name of the network function application. </param>
        /// <param name="dependsOnProfile"> Depends on profile definition. </param>
        /// <param name="artifactType"> The artifact type. </param>
        /// <param name="artifactProfile"> Azure vhd image artifact profile. </param>
        /// <param name="deployParametersMappingRuleProfile"> Deploy mapping rule profile. </param>
        internal AzureCoreNetworkFunctionVhdApplication(string name, DependsOnProfile dependsOnProfile, AzureCoreArtifactType artifactType, AzureCoreVhdImageArtifactProfile artifactProfile, AzureCoreVhdImageDeployMappingRuleProfile deployParametersMappingRuleProfile) : base(name, dependsOnProfile, artifactType)
        {
            ArtifactProfile = artifactProfile;
            DeployParametersMappingRuleProfile = deployParametersMappingRuleProfile;
            ArtifactType = artifactType;
        }

        /// <summary> Azure vhd image artifact profile. </summary>
        public AzureCoreVhdImageArtifactProfile ArtifactProfile { get; set; }
        /// <summary> Deploy mapping rule profile. </summary>
        public AzureCoreVhdImageDeployMappingRuleProfile DeployParametersMappingRuleProfile { get; set; }
    }
}
