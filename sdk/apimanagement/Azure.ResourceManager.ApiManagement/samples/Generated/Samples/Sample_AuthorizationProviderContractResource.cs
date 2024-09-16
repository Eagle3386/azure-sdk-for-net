// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ApiManagement.Models;

namespace Azure.ResourceManager.ApiManagement.Samples
{
    public partial class Sample_AuthorizationProviderContractResource
    {
        // ApiManagementGetAuthorizationProvider
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ApiManagementGetAuthorizationProvider()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementGetAuthorizationProvider.json
            // this example is just showing the usage of "AuthorizationProvider_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AuthorizationProviderContractResource created on azure
            // for more information of creating AuthorizationProviderContractResource, please refer to the document of AuthorizationProviderContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string authorizationProviderId = "aadwithauthcode";
            ResourceIdentifier authorizationProviderContractResourceId = AuthorizationProviderContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, authorizationProviderId);
            AuthorizationProviderContractResource authorizationProviderContract = client.GetAuthorizationProviderContractResource(authorizationProviderContractResourceId);

            // invoke the operation
            AuthorizationProviderContractResource result = await authorizationProviderContract.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AuthorizationProviderContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementCreateAuthorizationProviderAADAuthCode
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ApiManagementCreateAuthorizationProviderAADAuthCode()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementCreateAuthorizationProviderAADAuthCode.json
            // this example is just showing the usage of "AuthorizationProvider_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AuthorizationProviderContractResource created on azure
            // for more information of creating AuthorizationProviderContractResource, please refer to the document of AuthorizationProviderContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string authorizationProviderId = "aadwithauthcode";
            ResourceIdentifier authorizationProviderContractResourceId = AuthorizationProviderContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, authorizationProviderId);
            AuthorizationProviderContractResource authorizationProviderContract = client.GetAuthorizationProviderContractResource(authorizationProviderContractResourceId);

            // invoke the operation
            AuthorizationProviderContractData data = new AuthorizationProviderContractData()
            {
                DisplayName = "aadwithauthcode",
                IdentityProvider = "aad",
                Oauth2 = new AuthorizationProviderOAuth2Settings()
                {
                    RedirectUri = new Uri("https://authorization-manager.consent.azure-apim.net/redirect/apim/apimService1"),
                    GrantTypes = new AuthorizationProviderOAuth2GrantTypes()
                    {
                        AuthorizationCode =
{
["clientId"] = "clientsecretid",
["clientSecret"] = "clientsecretvalue",
["resourceUri"] = "https://graph.microsoft.com",
["scopes"] = "User.Read.All Group.Read.All",
},
                    },
                },
            };
            ArmOperation<AuthorizationProviderContractResource> lro = await authorizationProviderContract.UpdateAsync(WaitUntil.Completed, data);
            AuthorizationProviderContractResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AuthorizationProviderContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementCreateAuthorizationProviderAADClientCred
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ApiManagementCreateAuthorizationProviderAADClientCred()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementCreateAuthorizationProviderAADClientCred.json
            // this example is just showing the usage of "AuthorizationProvider_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AuthorizationProviderContractResource created on azure
            // for more information of creating AuthorizationProviderContractResource, please refer to the document of AuthorizationProviderContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string authorizationProviderId = "aadwithclientcred";
            ResourceIdentifier authorizationProviderContractResourceId = AuthorizationProviderContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, authorizationProviderId);
            AuthorizationProviderContractResource authorizationProviderContract = client.GetAuthorizationProviderContractResource(authorizationProviderContractResourceId);

            // invoke the operation
            AuthorizationProviderContractData data = new AuthorizationProviderContractData()
            {
                DisplayName = "aadwithclientcred",
                IdentityProvider = "aad",
                Oauth2 = new AuthorizationProviderOAuth2Settings()
                {
                    RedirectUri = new Uri("https://authorization-manager.consent.azure-apim.net/redirect/apim/apimService1"),
                    GrantTypes = new AuthorizationProviderOAuth2GrantTypes()
                    {
                        AuthorizationCode =
{
["resourceUri"] = "https://graph.microsoft.com",
["scopes"] = "User.Read.All Group.Read.All",
},
                    },
                },
            };
            ArmOperation<AuthorizationProviderContractResource> lro = await authorizationProviderContract.UpdateAsync(WaitUntil.Completed, data);
            AuthorizationProviderContractResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AuthorizationProviderContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementCreateAuthorizationProviderGenericOAuth2
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ApiManagementCreateAuthorizationProviderGenericOAuth2()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementCreateAuthorizationProviderGenericOAuth2.json
            // this example is just showing the usage of "AuthorizationProvider_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AuthorizationProviderContractResource created on azure
            // for more information of creating AuthorizationProviderContractResource, please refer to the document of AuthorizationProviderContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string authorizationProviderId = "eventbrite";
            ResourceIdentifier authorizationProviderContractResourceId = AuthorizationProviderContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, authorizationProviderId);
            AuthorizationProviderContractResource authorizationProviderContract = client.GetAuthorizationProviderContractResource(authorizationProviderContractResourceId);

            // invoke the operation
            AuthorizationProviderContractData data = new AuthorizationProviderContractData()
            {
                DisplayName = "eventbrite",
                IdentityProvider = "oauth2",
                Oauth2 = new AuthorizationProviderOAuth2Settings()
                {
                    RedirectUri = new Uri("https://authorization-manager.consent.azure-apim.net/redirect/apim/apimService1"),
                    GrantTypes = new AuthorizationProviderOAuth2GrantTypes()
                    {
                        AuthorizationCode =
{
["authorizationUrl"] = "https://www.eventbrite.com/oauth/authorize",
["clientId"] = "clientid",
["clientSecret"] = "clientsecretvalue",
["refreshUrl"] = "https://www.eventbrite.com/oauth/token",
["scopes"] = null,
["tokenUrl"] = "https://www.eventbrite.com/oauth/token",
},
                    },
                },
            };
            ArmOperation<AuthorizationProviderContractResource> lro = await authorizationProviderContract.UpdateAsync(WaitUntil.Completed, data);
            AuthorizationProviderContractResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AuthorizationProviderContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementCreateAuthorizationProviderOOBGoogle
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ApiManagementCreateAuthorizationProviderOOBGoogle()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementCreateAuthorizationProviderOOBGoogle.json
            // this example is just showing the usage of "AuthorizationProvider_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AuthorizationProviderContractResource created on azure
            // for more information of creating AuthorizationProviderContractResource, please refer to the document of AuthorizationProviderContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string authorizationProviderId = "google";
            ResourceIdentifier authorizationProviderContractResourceId = AuthorizationProviderContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, authorizationProviderId);
            AuthorizationProviderContractResource authorizationProviderContract = client.GetAuthorizationProviderContractResource(authorizationProviderContractResourceId);

            // invoke the operation
            AuthorizationProviderContractData data = new AuthorizationProviderContractData()
            {
                DisplayName = "google",
                IdentityProvider = "google",
                Oauth2 = new AuthorizationProviderOAuth2Settings()
                {
                    RedirectUri = new Uri("https://authorization-manager.consent.azure-apim.net/redirect/apim/apimService1"),
                    GrantTypes = new AuthorizationProviderOAuth2GrantTypes()
                    {
                        AuthorizationCode =
{
["clientId"] = "99999999-xxxxxxxxxxxxxxxxxxxxxxxx.apps.googleusercontent.com",
["clientSecret"] = "clientsecretvalue",
["scopes"] = "openid https://www.googleapis.com/auth/userinfo.profile https://www.googleapis.com/auth/userinfo.email",
},
                    },
                },
            };
            ArmOperation<AuthorizationProviderContractResource> lro = await authorizationProviderContract.UpdateAsync(WaitUntil.Completed, data);
            AuthorizationProviderContractResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            AuthorizationProviderContractData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementDeleteAuthorizationProvider
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_ApiManagementDeleteAuthorizationProvider()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementDeleteAuthorizationProvider.json
            // this example is just showing the usage of "AuthorizationProvider_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this AuthorizationProviderContractResource created on azure
            // for more information of creating AuthorizationProviderContractResource, please refer to the document of AuthorizationProviderContractResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string authorizationProviderId = "aadwithauthcode";
            ResourceIdentifier authorizationProviderContractResourceId = AuthorizationProviderContractResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, authorizationProviderId);
            AuthorizationProviderContractResource authorizationProviderContract = client.GetAuthorizationProviderContractResource(authorizationProviderContractResourceId);

            // invoke the operation
            ETag ifMatch = new ETag("*");
            await authorizationProviderContract.DeleteAsync(WaitUntil.Completed, ifMatch);

            Console.WriteLine($"Succeeded");
        }
    }
}
