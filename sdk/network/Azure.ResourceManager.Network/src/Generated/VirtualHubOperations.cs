// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the operations that can be performed over a specific VirtualHub. </summary>
    public partial class VirtualHubOperations : ResourceOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private VirtualHubsRestOperations _restClient { get; }

        /// <summary> Initializes a new instance of the <see cref="VirtualHubOperations"/> class for mocking. </summary>
        protected VirtualHubOperations()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VirtualHubOperations"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        protected internal VirtualHubOperations(ResourceOperations options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new VirtualHubsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/virtualHubs";
        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> Retrieves the details of a VirtualHub. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<VirtualHub>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualHubOperations.Get");
            scope.Start();
            try
            {
                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VirtualHub(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the details of a VirtualHub. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VirtualHub> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualHubOperations.Get");
            scope.Start();
            try
            {
                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualHub(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<Location>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<Location> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// <summary> Deletes a VirtualHub. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> DeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualHubOperations.Delete");
            scope.Start();
            try
            {
                var operation = await StartDeleteAsync(cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a VirtualHub. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualHubOperations.Delete");
            scope.Start();
            try
            {
                var operation = StartDelete(cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a VirtualHub. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<VirtualHubsDeleteOperation> StartDeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualHubOperations.StartDelete");
            scope.Start();
            try
            {
                var response = await _restClient.DeleteAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                return new VirtualHubsDeleteOperation(_clientDiagnostics, Pipeline, _restClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a VirtualHub. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VirtualHubsDeleteOperation StartDelete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualHubOperations.StartDelete");
            scope.Start();
            try
            {
                var response = _restClient.Delete(Id.ResourceGroupName, Id.Name, cancellationToken);
                return new VirtualHubsDeleteOperation(_clientDiagnostics, Pipeline, _restClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
        /// <summary> Updates VirtualHub tags. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<VirtualHub>> UpdateTagsAsync(IDictionary<string, string> tags = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualHubOperations.UpdateTags");
            scope.Start();
            try
            {
                var response = await _restClient.UpdateTagsAsync(Id.ResourceGroupName, Id.Name, tags, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new VirtualHub(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates VirtualHub tags. </summary>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VirtualHub> UpdateTags(IDictionary<string, string> tags = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualHubOperations.UpdateTags");
            scope.Start();
            try
            {
                var response = _restClient.UpdateTags(Id.ResourceGroupName, Id.Name, tags, cancellationToken);
                return Response.FromValue(new VirtualHub(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the effective routes configured for the Virtual Hub resource or the specified resource . </summary>
        /// <param name="resourceId"> The resource whose effective routes are being requested. </param>
        /// <param name="virtualWanResourceType"> The type of the specified resource like RouteTable, ExpressRouteConnection, HubVirtualNetworkConnection, VpnConnection and P2SConnection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> GetEffectiveVirtualHubRoutesAsync(string resourceId = null, string virtualWanResourceType = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualHubOperations.GetEffectiveVirtualHubRoutes");
            scope.Start();
            try
            {
                var operation = await StartGetEffectiveVirtualHubRoutesAsync(resourceId, virtualWanResourceType, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the effective routes configured for the Virtual Hub resource or the specified resource . </summary>
        /// <param name="resourceId"> The resource whose effective routes are being requested. </param>
        /// <param name="virtualWanResourceType"> The type of the specified resource like RouteTable, ExpressRouteConnection, HubVirtualNetworkConnection, VpnConnection and P2SConnection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response GetEffectiveVirtualHubRoutes(string resourceId = null, string virtualWanResourceType = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualHubOperations.GetEffectiveVirtualHubRoutes");
            scope.Start();
            try
            {
                var operation = StartGetEffectiveVirtualHubRoutes(resourceId, virtualWanResourceType, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the effective routes configured for the Virtual Hub resource or the specified resource . </summary>
        /// <param name="resourceId"> The resource whose effective routes are being requested. </param>
        /// <param name="virtualWanResourceType"> The type of the specified resource like RouteTable, ExpressRouteConnection, HubVirtualNetworkConnection, VpnConnection and P2SConnection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<VirtualHubsGetEffectiveVirtualHubRoutesOperation> StartGetEffectiveVirtualHubRoutesAsync(string resourceId = null, string virtualWanResourceType = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualHubOperations.StartGetEffectiveVirtualHubRoutes");
            scope.Start();
            try
            {
                var response = await _restClient.GetEffectiveVirtualHubRoutesAsync(Id.ResourceGroupName, Id.Name, resourceId, virtualWanResourceType, cancellationToken).ConfigureAwait(false);
                return new VirtualHubsGetEffectiveVirtualHubRoutesOperation(_clientDiagnostics, Pipeline, _restClient.CreateGetEffectiveVirtualHubRoutesRequest(Id.ResourceGroupName, Id.Name, resourceId, virtualWanResourceType).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the effective routes configured for the Virtual Hub resource or the specified resource . </summary>
        /// <param name="resourceId"> The resource whose effective routes are being requested. </param>
        /// <param name="virtualWanResourceType"> The type of the specified resource like RouteTable, ExpressRouteConnection, HubVirtualNetworkConnection, VpnConnection and P2SConnection. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VirtualHubsGetEffectiveVirtualHubRoutesOperation StartGetEffectiveVirtualHubRoutes(string resourceId = null, string virtualWanResourceType = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualHubOperations.StartGetEffectiveVirtualHubRoutes");
            scope.Start();
            try
            {
                var response = _restClient.GetEffectiveVirtualHubRoutes(Id.ResourceGroupName, Id.Name, resourceId, virtualWanResourceType, cancellationToken);
                return new VirtualHubsGetEffectiveVirtualHubRoutesOperation(_clientDiagnostics, Pipeline, _restClient.CreateGetEffectiveVirtualHubRoutesRequest(Id.ResourceGroupName, Id.Name, resourceId, virtualWanResourceType).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets a list of HubVirtualNetworkConnections in the VirtualHub. </summary>
        /// <returns> An object representing collection of HubVirtualNetworkConnections and their operations over a VirtualHub. </returns>
        public HubVirtualNetworkConnectionContainer GetHubVirtualNetworkConnections()
        {
            return new HubVirtualNetworkConnectionContainer(this);
        }

        /// <summary> Gets a list of VirtualHubRouteTableV2s in the VirtualHub. </summary>
        /// <returns> An object representing collection of VirtualHubRouteTableV2s and their operations over a VirtualHub. </returns>
        public VirtualHubRouteTableV2Container GetVirtualHubRouteTableV2s()
        {
            return new VirtualHubRouteTableV2Container(this);
        }

        /// <summary> Gets a list of BgpConnections in the VirtualHub. </summary>
        /// <returns> An object representing collection of BgpConnections and their operations over a VirtualHub. </returns>
        public BgpConnectionContainer GetBgpConnections()
        {
            return new BgpConnectionContainer(this);
        }

        /// <summary> Gets a list of HubIpConfigurations in the VirtualHub. </summary>
        /// <returns> An object representing collection of HubIpConfigurations and their operations over a VirtualHub. </returns>
        public HubIpConfigurationContainer GetHubIpConfigurations()
        {
            return new HubIpConfigurationContainer(this);
        }

        /// <summary> Gets a list of HubRouteTables in the VirtualHub. </summary>
        /// <returns> An object representing collection of HubRouteTables and their operations over a VirtualHub. </returns>
        public HubRouteTableContainer GetHubRouteTables()
        {
            return new HubRouteTableContainer(this);
        }
    }
}
