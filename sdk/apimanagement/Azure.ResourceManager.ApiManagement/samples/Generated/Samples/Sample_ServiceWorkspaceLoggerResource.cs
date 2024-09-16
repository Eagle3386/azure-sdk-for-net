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
    public partial class Sample_ServiceWorkspaceLoggerResource
    {
        // ApiManagementHeadWorkspaceLogger
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetEntityTag_ApiManagementHeadWorkspaceLogger()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementHeadWorkspaceLogger.json
            // this example is just showing the usage of "WorkspaceLogger_GetEntityTag" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceLoggerResource created on azure
            // for more information of creating ServiceWorkspaceLoggerResource, please refer to the document of ServiceWorkspaceLoggerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string loggerId = "templateLogger";
            ResourceIdentifier serviceWorkspaceLoggerResourceId = ServiceWorkspaceLoggerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, loggerId);
            ServiceWorkspaceLoggerResource serviceWorkspaceLogger = client.GetServiceWorkspaceLoggerResource(serviceWorkspaceLoggerResourceId);

            // invoke the operation
            bool result = await serviceWorkspaceLogger.GetEntityTagAsync();

            Console.WriteLine($"Succeeded: {result}");
        }

        // ApiManagementGetWorkspaceLogger
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_ApiManagementGetWorkspaceLogger()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementGetWorkspaceLogger.json
            // this example is just showing the usage of "WorkspaceLogger_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceLoggerResource created on azure
            // for more information of creating ServiceWorkspaceLoggerResource, please refer to the document of ServiceWorkspaceLoggerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string loggerId = "templateLogger";
            ResourceIdentifier serviceWorkspaceLoggerResourceId = ServiceWorkspaceLoggerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, loggerId);
            ServiceWorkspaceLoggerResource serviceWorkspaceLogger = client.GetServiceWorkspaceLoggerResource(serviceWorkspaceLoggerResourceId);

            // invoke the operation
            ServiceWorkspaceLoggerResource result = await serviceWorkspaceLogger.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiManagementLoggerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementUpdateWorkspaceLogger
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_ApiManagementUpdateWorkspaceLogger()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementUpdateWorkspaceLogger.json
            // this example is just showing the usage of "WorkspaceLogger_Update" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceLoggerResource created on azure
            // for more information of creating ServiceWorkspaceLoggerResource, please refer to the document of ServiceWorkspaceLoggerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string loggerId = "eh1";
            ResourceIdentifier serviceWorkspaceLoggerResourceId = ServiceWorkspaceLoggerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, loggerId);
            ServiceWorkspaceLoggerResource serviceWorkspaceLogger = client.GetServiceWorkspaceLoggerResource(serviceWorkspaceLoggerResourceId);

            // invoke the operation
            ETag ifMatch = new ETag("*");
            LoggerUpdateContract loggerUpdateContract = new LoggerUpdateContract()
            {
                LoggerType = LoggerType.AzureEventHub,
                Description = "updating description",
            };
            ServiceWorkspaceLoggerResource result = await serviceWorkspaceLogger.UpdateAsync(ifMatch, loggerUpdateContract);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ApiManagementLoggerData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // ApiManagementDeleteWorkspaceLogger
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_ApiManagementDeleteWorkspaceLogger()
        {
            // Generated from example definition: specification/apimanagement/resource-manager/Microsoft.ApiManagement/stable/2024-05-01/examples/ApiManagementDeleteWorkspaceLogger.json
            // this example is just showing the usage of "WorkspaceLogger_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ServiceWorkspaceLoggerResource created on azure
            // for more information of creating ServiceWorkspaceLoggerResource, please refer to the document of ServiceWorkspaceLoggerResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "rg1";
            string serviceName = "apimService1";
            string workspaceId = "wks1";
            string loggerId = "loggerId";
            ResourceIdentifier serviceWorkspaceLoggerResourceId = ServiceWorkspaceLoggerResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, serviceName, workspaceId, loggerId);
            ServiceWorkspaceLoggerResource serviceWorkspaceLogger = client.GetServiceWorkspaceLoggerResource(serviceWorkspaceLoggerResourceId);

            // invoke the operation
            ETag ifMatch = new ETag("*");
            await serviceWorkspaceLogger.DeleteAsync(WaitUntil.Completed, ifMatch);

            Console.WriteLine($"Succeeded");
        }
    }
}
