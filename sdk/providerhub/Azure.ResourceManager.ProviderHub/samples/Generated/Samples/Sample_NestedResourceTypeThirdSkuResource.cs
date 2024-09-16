// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.ProviderHub.Models;

namespace Azure.ResourceManager.ProviderHub.Samples
{
    public partial class Sample_NestedResourceTypeThirdSkuResource
    {
        // Skus_GetNestedResourceTypeThird
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_SkusGetNestedResourceTypeThird()
        {
            // Generated from example definition: specification/providerhub/resource-manager/Microsoft.ProviderHub/preview/2023-04-01-preview/examples/Skus_GetNestedResourceTypeThird.json
            // this example is just showing the usage of "Skus_GetNestedResourceTypeThird" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NestedResourceTypeThirdSkuResource created on azure
            // for more information of creating NestedResourceTypeThirdSkuResource, please refer to the document of NestedResourceTypeThirdSkuResource
            string subscriptionId = "ab7a8701-f7ef-471a-a2f4-d0ebbf494f77";
            string providerNamespace = "Microsoft.Contoso";
            string resourceType = "testResourceType";
            string nestedResourceTypeFirst = "nestedResourceTypeFirst";
            string nestedResourceTypeSecond = "nestedResourceTypeSecond";
            string nestedResourceTypeThird = "nestedResourceTypeThird";
            string sku = "testSku";
            ResourceIdentifier nestedResourceTypeThirdSkuResourceId = NestedResourceTypeThirdSkuResource.CreateResourceIdentifier(subscriptionId, providerNamespace, resourceType, nestedResourceTypeFirst, nestedResourceTypeSecond, nestedResourceTypeThird, sku);
            NestedResourceTypeThirdSkuResource nestedResourceTypeThirdSku = client.GetNestedResourceTypeThirdSkuResource(nestedResourceTypeThirdSkuResourceId);

            // invoke the operation
            NestedResourceTypeThirdSkuResource result = await nestedResourceTypeThirdSku.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ResourceTypeSkuData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Skus_CreateOrUpdateNestedResourceTypeThird
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_SkusCreateOrUpdateNestedResourceTypeThird()
        {
            // Generated from example definition: specification/providerhub/resource-manager/Microsoft.ProviderHub/preview/2023-04-01-preview/examples/Skus_CreateOrUpdateNestedResourceTypeThird.json
            // this example is just showing the usage of "Skus_CreateOrUpdateNestedResourceTypeThird" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NestedResourceTypeThirdSkuResource created on azure
            // for more information of creating NestedResourceTypeThirdSkuResource, please refer to the document of NestedResourceTypeThirdSkuResource
            string subscriptionId = "ab7a8701-f7ef-471a-a2f4-d0ebbf494f77";
            string providerNamespace = "Microsoft.Contoso";
            string resourceType = "testResourceType";
            string nestedResourceTypeFirst = "nestedResourceTypeFirst";
            string nestedResourceTypeSecond = "nestedResourceTypeSecond";
            string nestedResourceTypeThird = "nestedResourceTypeThird";
            string sku = "testSku";
            ResourceIdentifier nestedResourceTypeThirdSkuResourceId = NestedResourceTypeThirdSkuResource.CreateResourceIdentifier(subscriptionId, providerNamespace, resourceType, nestedResourceTypeFirst, nestedResourceTypeSecond, nestedResourceTypeThird, sku);
            NestedResourceTypeThirdSkuResource nestedResourceTypeThirdSku = client.GetNestedResourceTypeThirdSkuResource(nestedResourceTypeThirdSkuResourceId);

            // invoke the operation
            ResourceTypeSkuData data = new ResourceTypeSkuData()
            {
                Properties = new ResourceTypeSkuProperties(new ResourceTypeSkuSetting[]
            {
new ResourceTypeSkuSetting("freeSku")
{
Tier = "Tier1",
Kind = "Standard",
},new ResourceTypeSkuSetting("premiumSku")
{
Tier = "Tier2",
Kind = "Premium",
Costs =
{
new ResourceTypeSkuCost("xxx")
},
}
            }),
            };
            ArmOperation<NestedResourceTypeThirdSkuResource> lro = await nestedResourceTypeThirdSku.UpdateAsync(WaitUntil.Completed, data);
            NestedResourceTypeThirdSkuResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ResourceTypeSkuData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Skus_DeleteNestedResourceTypeThird
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_SkusDeleteNestedResourceTypeThird()
        {
            // Generated from example definition: specification/providerhub/resource-manager/Microsoft.ProviderHub/preview/2023-04-01-preview/examples/Skus_DeleteNestedResourceTypeThird.json
            // this example is just showing the usage of "Skus_DeleteNestedResourceTypeThird" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this NestedResourceTypeThirdSkuResource created on azure
            // for more information of creating NestedResourceTypeThirdSkuResource, please refer to the document of NestedResourceTypeThirdSkuResource
            string subscriptionId = "ab7a8701-f7ef-471a-a2f4-d0ebbf494f77";
            string providerNamespace = "Microsoft.Contoso";
            string resourceType = "testResourceType";
            string nestedResourceTypeFirst = "nestedResourceTypeFirst";
            string nestedResourceTypeSecond = "nestedResourceTypeSecond";
            string nestedResourceTypeThird = "nestedResourceTypeThird";
            string sku = "testSku";
            ResourceIdentifier nestedResourceTypeThirdSkuResourceId = NestedResourceTypeThirdSkuResource.CreateResourceIdentifier(subscriptionId, providerNamespace, resourceType, nestedResourceTypeFirst, nestedResourceTypeSecond, nestedResourceTypeThird, sku);
            NestedResourceTypeThirdSkuResource nestedResourceTypeThirdSku = client.GetNestedResourceTypeThirdSkuResource(nestedResourceTypeThirdSkuResourceId);

            // invoke the operation
            await nestedResourceTypeThirdSku.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }
    }
}
