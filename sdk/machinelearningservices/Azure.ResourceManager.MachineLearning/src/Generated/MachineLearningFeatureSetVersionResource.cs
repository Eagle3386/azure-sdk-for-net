// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.MachineLearning.Models;

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary>
    /// A Class representing a MachineLearningFeatureSetVersion along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="MachineLearningFeatureSetVersionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetMachineLearningFeatureSetVersionResource method.
    /// Otherwise you can get one from its parent resource <see cref="MachineLearningFeatureSetContainerResource" /> using the GetMachineLearningFeatureSetVersion method.
    /// </summary>
    public partial class MachineLearningFeatureSetVersionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="MachineLearningFeatureSetVersionResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="workspaceName"> The workspaceName. </param>
        /// <param name="name"> The name. </param>
        /// <param name="version"> The version. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string workspaceName, string name, string version)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featuresets/{name}/versions/{version}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _machineLearningFeatureSetVersionFeaturesetVersionsClientDiagnostics;
        private readonly FeaturesetVersionsRestOperations _machineLearningFeatureSetVersionFeaturesetVersionsRestClient;
        private readonly MachineLearningFeatureSetVersionData _data;

        /// <summary> Initializes a new instance of the <see cref="MachineLearningFeatureSetVersionResource"/> class for mocking. </summary>
        protected MachineLearningFeatureSetVersionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "MachineLearningFeatureSetVersionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal MachineLearningFeatureSetVersionResource(ArmClient client, MachineLearningFeatureSetVersionData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="MachineLearningFeatureSetVersionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MachineLearningFeatureSetVersionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _machineLearningFeatureSetVersionFeaturesetVersionsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MachineLearning", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string machineLearningFeatureSetVersionFeaturesetVersionsApiVersion);
            _machineLearningFeatureSetVersionFeaturesetVersionsRestClient = new FeaturesetVersionsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, machineLearningFeatureSetVersionFeaturesetVersionsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.MachineLearningServices/workspaces/featuresets/versions";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual MachineLearningFeatureSetVersionData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary> Gets a collection of MachineLearningFeatureResources in the MachineLearningFeatureSetVersion. </summary>
        /// <returns> An object representing collection of MachineLearningFeatureResources and their operations over a MachineLearningFeatureResource. </returns>
        public virtual MachineLearningFeatureCollection GetMachineLearningFeatures()
        {
            return GetCachedClient(client => new MachineLearningFeatureCollection(client, Id));
        }

        /// <summary>
        /// Get feature.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featuresets/{featuresetName}/versions/{featuresetVersion}/features/{featureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Features_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="featureName"> Feature Name. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="featureName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="featureName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<MachineLearningFeatureResource>> GetMachineLearningFeatureAsync(string featureName, CancellationToken cancellationToken = default)
        {
            return await GetMachineLearningFeatures().GetAsync(featureName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get feature.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featuresets/{featuresetName}/versions/{featuresetVersion}/features/{featureName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Features_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="featureName"> Feature Name. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="featureName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="featureName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<MachineLearningFeatureResource> GetMachineLearningFeature(string featureName, CancellationToken cancellationToken = default)
        {
            return GetMachineLearningFeatures().Get(featureName, cancellationToken);
        }

        /// <summary>
        /// Get version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featuresets/{name}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturesetVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<MachineLearningFeatureSetVersionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _machineLearningFeatureSetVersionFeaturesetVersionsClientDiagnostics.CreateScope("MachineLearningFeatureSetVersionResource.Get");
            scope.Start();
            try
            {
                var response = await _machineLearningFeatureSetVersionFeaturesetVersionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningFeatureSetVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featuresets/{name}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturesetVersions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<MachineLearningFeatureSetVersionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _machineLearningFeatureSetVersionFeaturesetVersionsClientDiagnostics.CreateScope("MachineLearningFeatureSetVersionResource.Get");
            scope.Start();
            try
            {
                var response = _machineLearningFeatureSetVersionFeaturesetVersionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningFeatureSetVersionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featuresets/{name}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturesetVersions_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _machineLearningFeatureSetVersionFeaturesetVersionsClientDiagnostics.CreateScope("MachineLearningFeatureSetVersionResource.Delete");
            scope.Start();
            try
            {
                var response = await _machineLearningFeatureSetVersionFeaturesetVersionsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation(_machineLearningFeatureSetVersionFeaturesetVersionsClientDiagnostics, Pipeline, _machineLearningFeatureSetVersionFeaturesetVersionsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featuresets/{name}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturesetVersions_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _machineLearningFeatureSetVersionFeaturesetVersionsClientDiagnostics.CreateScope("MachineLearningFeatureSetVersionResource.Delete");
            scope.Start();
            try
            {
                var response = _machineLearningFeatureSetVersionFeaturesetVersionsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new MachineLearningArmOperation(_machineLearningFeatureSetVersionFeaturesetVersionsClientDiagnostics, Pipeline, _machineLearningFeatureSetVersionFeaturesetVersionsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featuresets/{name}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturesetVersions_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Version entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MachineLearningFeatureSetVersionResource>> UpdateAsync(WaitUntil waitUntil, MachineLearningFeatureSetVersionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineLearningFeatureSetVersionFeaturesetVersionsClientDiagnostics.CreateScope("MachineLearningFeatureSetVersionResource.Update");
            scope.Start();
            try
            {
                var response = await _machineLearningFeatureSetVersionFeaturesetVersionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation<MachineLearningFeatureSetVersionResource>(new MachineLearningFeatureSetVersionOperationSource(Client), _machineLearningFeatureSetVersionFeaturesetVersionsClientDiagnostics, Pipeline, _machineLearningFeatureSetVersionFeaturesetVersionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.OriginalUri);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update version.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featuresets/{name}/versions/{version}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturesetVersions_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Version entity to create or update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MachineLearningFeatureSetVersionResource> Update(WaitUntil waitUntil, MachineLearningFeatureSetVersionData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineLearningFeatureSetVersionFeaturesetVersionsClientDiagnostics.CreateScope("MachineLearningFeatureSetVersionResource.Update");
            scope.Start();
            try
            {
                var response = _machineLearningFeatureSetVersionFeaturesetVersionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new MachineLearningArmOperation<MachineLearningFeatureSetVersionResource>(new MachineLearningFeatureSetVersionOperationSource(Client), _machineLearningFeatureSetVersionFeaturesetVersionsClientDiagnostics, Pipeline, _machineLearningFeatureSetVersionFeaturesetVersionsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.OriginalUri);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Backfill.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featuresets/{name}/versions/{version}/backfill</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturesetVersions_Backfill</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Feature set version backfill request entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<MachineLearningFeatureSetJob>> BackfillAsync(WaitUntil waitUntil, FeatureSetVersionBackfillContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _machineLearningFeatureSetVersionFeaturesetVersionsClientDiagnostics.CreateScope("MachineLearningFeatureSetVersionResource.Backfill");
            scope.Start();
            try
            {
                var response = await _machineLearningFeatureSetVersionFeaturesetVersionsRestClient.BackfillAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation<MachineLearningFeatureSetJob>(new MachineLearningFeatureSetJobOperationSource(), _machineLearningFeatureSetVersionFeaturesetVersionsClientDiagnostics, Pipeline, _machineLearningFeatureSetVersionFeaturesetVersionsRestClient.CreateBackfillRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Backfill.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featuresets/{name}/versions/{version}/backfill</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturesetVersions_Backfill</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Feature set version backfill request entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<MachineLearningFeatureSetJob> Backfill(WaitUntil waitUntil, FeatureSetVersionBackfillContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _machineLearningFeatureSetVersionFeaturesetVersionsClientDiagnostics.CreateScope("MachineLearningFeatureSetVersionResource.Backfill");
            scope.Start();
            try
            {
                var response = _machineLearningFeatureSetVersionFeaturesetVersionsRestClient.Backfill(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content, cancellationToken);
                var operation = new MachineLearningArmOperation<MachineLearningFeatureSetJob>(new MachineLearningFeatureSetJobOperationSource(), _machineLearningFeatureSetVersionFeaturesetVersionsClientDiagnostics, Pipeline, _machineLearningFeatureSetVersionFeaturesetVersionsRestClient.CreateBackfillRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, content).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List materialization Jobs.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featuresets/{name}/versions/{version}/listMaterializationJobs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturesetVersions_ListMaterializationJobs</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="filters"> Comma-separated list of tag names (and optionally values). Example: tag1,tag2=value2. </param>
        /// <param name="featureWindowStart"> Start time of the feature window to filter materialization jobs. </param>
        /// <param name="featureWindowEnd"> End time of the feature window to filter materialization jobs. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MachineLearningFeatureSetJob" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MachineLearningFeatureSetJob> GetMaterializationJobsAsync(string skip = null, string filters = null, string featureWindowStart = null, string featureWindowEnd = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _machineLearningFeatureSetVersionFeaturesetVersionsRestClient.CreateListMaterializationJobsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, skip, filters, featureWindowStart, featureWindowEnd);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _machineLearningFeatureSetVersionFeaturesetVersionsRestClient.CreateListMaterializationJobsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, skip, filters, featureWindowStart, featureWindowEnd);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, MachineLearningFeatureSetJob.DeserializeMachineLearningFeatureSetJob, _machineLearningFeatureSetVersionFeaturesetVersionsClientDiagnostics, Pipeline, "MachineLearningFeatureSetVersionResource.GetMaterializationJobs", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List materialization Jobs.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/featuresets/{name}/versions/{version}/listMaterializationJobs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FeaturesetVersions_ListMaterializationJobs</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="filters"> Comma-separated list of tag names (and optionally values). Example: tag1,tag2=value2. </param>
        /// <param name="featureWindowStart"> Start time of the feature window to filter materialization jobs. </param>
        /// <param name="featureWindowEnd"> End time of the feature window to filter materialization jobs. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MachineLearningFeatureSetJob" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MachineLearningFeatureSetJob> GetMaterializationJobs(string skip = null, string filters = null, string featureWindowStart = null, string featureWindowEnd = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _machineLearningFeatureSetVersionFeaturesetVersionsRestClient.CreateListMaterializationJobsRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, skip, filters, featureWindowStart, featureWindowEnd);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _machineLearningFeatureSetVersionFeaturesetVersionsRestClient.CreateListMaterializationJobsNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, skip, filters, featureWindowStart, featureWindowEnd);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, MachineLearningFeatureSetJob.DeserializeMachineLearningFeatureSetJob, _machineLearningFeatureSetVersionFeaturesetVersionsClientDiagnostics, Pipeline, "MachineLearningFeatureSetVersionResource.GetMaterializationJobs", "value", "nextLink", cancellationToken);
        }
    }
}
