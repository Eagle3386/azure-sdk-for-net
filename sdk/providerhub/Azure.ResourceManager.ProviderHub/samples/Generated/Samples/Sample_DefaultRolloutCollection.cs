// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using System.Xml;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ProviderHub.Models;

namespace Azure.ResourceManager.ProviderHub.Samples
{
    public partial class Sample_DefaultRolloutCollection
    {
        // DefaultRollouts_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_DefaultRolloutsGet()
        {
            // Generated from example definition: specification/providerhub/resource-manager/Microsoft.ProviderHub/preview/2023-04-01-preview/examples/DefaultRollouts_Get.json
            // this example is just showing the usage of "DefaultRollouts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProviderRegistrationResource created on azure
            // for more information of creating ProviderRegistrationResource, please refer to the document of ProviderRegistrationResource
            string subscriptionId = "ab7a8701-f7ef-471a-a2f4-d0ebbf494f77";
            string providerNamespace = "Microsoft.Contoso";
            ResourceIdentifier providerRegistrationResourceId = ProviderRegistrationResource.CreateResourceIdentifier(subscriptionId, providerNamespace);
            ProviderRegistrationResource providerRegistration = client.GetProviderRegistrationResource(providerRegistrationResourceId);

            // get the collection of this DefaultRolloutResource
            DefaultRolloutCollection collection = providerRegistration.GetDefaultRollouts();

            // invoke the operation
            string rolloutName = "2020week10";
            DefaultRolloutResource result = await collection.GetAsync(rolloutName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DefaultRolloutData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DefaultRollouts_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_DefaultRolloutsGet()
        {
            // Generated from example definition: specification/providerhub/resource-manager/Microsoft.ProviderHub/preview/2023-04-01-preview/examples/DefaultRollouts_Get.json
            // this example is just showing the usage of "DefaultRollouts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProviderRegistrationResource created on azure
            // for more information of creating ProviderRegistrationResource, please refer to the document of ProviderRegistrationResource
            string subscriptionId = "ab7a8701-f7ef-471a-a2f4-d0ebbf494f77";
            string providerNamespace = "Microsoft.Contoso";
            ResourceIdentifier providerRegistrationResourceId = ProviderRegistrationResource.CreateResourceIdentifier(subscriptionId, providerNamespace);
            ProviderRegistrationResource providerRegistration = client.GetProviderRegistrationResource(providerRegistrationResourceId);

            // get the collection of this DefaultRolloutResource
            DefaultRolloutCollection collection = providerRegistration.GetDefaultRollouts();

            // invoke the operation
            string rolloutName = "2020week10";
            bool result = await collection.ExistsAsync(rolloutName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // DefaultRollouts_Get
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetIfExists_DefaultRolloutsGet()
        {
            // Generated from example definition: specification/providerhub/resource-manager/Microsoft.ProviderHub/preview/2023-04-01-preview/examples/DefaultRollouts_Get.json
            // this example is just showing the usage of "DefaultRollouts_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProviderRegistrationResource created on azure
            // for more information of creating ProviderRegistrationResource, please refer to the document of ProviderRegistrationResource
            string subscriptionId = "ab7a8701-f7ef-471a-a2f4-d0ebbf494f77";
            string providerNamespace = "Microsoft.Contoso";
            ResourceIdentifier providerRegistrationResourceId = ProviderRegistrationResource.CreateResourceIdentifier(subscriptionId, providerNamespace);
            ProviderRegistrationResource providerRegistration = client.GetProviderRegistrationResource(providerRegistrationResourceId);

            // get the collection of this DefaultRolloutResource
            DefaultRolloutCollection collection = providerRegistration.GetDefaultRollouts();

            // invoke the operation
            string rolloutName = "2020week10";
            NullableResponse<DefaultRolloutResource> response = await collection.GetIfExistsAsync(rolloutName);
            DefaultRolloutResource result = response.HasValue ? response.Value : null;

            if (result == null)
            {
                Console.WriteLine($"Succeeded with null as result");
            }
            else
            {
                // the variable result is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DefaultRolloutData resourceData = result.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }
        }

        // DefaultRollouts_CreateOrUpdate
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_DefaultRolloutsCreateOrUpdate()
        {
            // Generated from example definition: specification/providerhub/resource-manager/Microsoft.ProviderHub/preview/2023-04-01-preview/examples/DefaultRollouts_CreateOrUpdate.json
            // this example is just showing the usage of "DefaultRollouts_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProviderRegistrationResource created on azure
            // for more information of creating ProviderRegistrationResource, please refer to the document of ProviderRegistrationResource
            string subscriptionId = "ab7a8701-f7ef-471a-a2f4-d0ebbf494f77";
            string providerNamespace = "Microsoft.Contoso";
            ResourceIdentifier providerRegistrationResourceId = ProviderRegistrationResource.CreateResourceIdentifier(subscriptionId, providerNamespace);
            ProviderRegistrationResource providerRegistration = client.GetProviderRegistrationResource(providerRegistrationResourceId);

            // get the collection of this DefaultRolloutResource
            DefaultRolloutCollection collection = providerRegistration.GetDefaultRollouts();

            // invoke the operation
            string rolloutName = "2020week10";
            DefaultRolloutData data = new DefaultRolloutData()
            {
                Properties = new DefaultRolloutProperties()
                {
                    Specification = new DefaultRolloutSpecification()
                    {
                        ExpeditedRolloutEnabled = true,
                        Canary = new CanaryTrafficRegionRolloutConfiguration()
                        {
                            SkipRegions =
{
new AzureLocation("eastus2euap")
},
                        },
                        RestOfTheWorldGroupTwo = new TrafficRegionRolloutConfiguration()
                        {
                            WaitDuration = XmlConvert.ToTimeSpan("PT4H"),
                        },
                    },
                },
            };
            ArmOperation<DefaultRolloutResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, rolloutName, data);
            DefaultRolloutResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            DefaultRolloutData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // DefaultRollouts_ListByProviderRegistration
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_DefaultRolloutsListByProviderRegistration()
        {
            // Generated from example definition: specification/providerhub/resource-manager/Microsoft.ProviderHub/preview/2023-04-01-preview/examples/DefaultRollouts_ListByProviderRegistration.json
            // this example is just showing the usage of "DefaultRollouts_ListByProviderRegistration" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ProviderRegistrationResource created on azure
            // for more information of creating ProviderRegistrationResource, please refer to the document of ProviderRegistrationResource
            string subscriptionId = "ab7a8701-f7ef-471a-a2f4-d0ebbf494f77";
            string providerNamespace = "Microsoft.Contoso";
            ResourceIdentifier providerRegistrationResourceId = ProviderRegistrationResource.CreateResourceIdentifier(subscriptionId, providerNamespace);
            ProviderRegistrationResource providerRegistration = client.GetProviderRegistrationResource(providerRegistrationResourceId);

            // get the collection of this DefaultRolloutResource
            DefaultRolloutCollection collection = providerRegistration.GetDefaultRollouts();

            // invoke the operation and iterate over the result
            await foreach (DefaultRolloutResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                DefaultRolloutData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
