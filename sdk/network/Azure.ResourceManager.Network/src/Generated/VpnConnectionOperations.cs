// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the operations that can be performed over a specific VpnConnection. </summary>
    public partial class VpnConnectionOperations : ResourceOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private VpnConnectionsRestOperations _restClient { get; }
        private VpnLinkConnectionsRestOperations _vpnLinkConnectionsRestClient { get; }
        private VpnSiteLinkConnectionsRestOperations _vpnSiteLinkConnectionsRestClient { get; }

        /// <summary> Initializes a new instance of the <see cref="VpnConnectionOperations"/> class for mocking. </summary>
        protected VpnConnectionOperations()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="VpnConnectionOperations"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        protected internal VpnConnectionOperations(ResourceOperations options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new VpnConnectionsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
            _vpnLinkConnectionsRestClient = new VpnLinkConnectionsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
            _vpnSiteLinkConnectionsRestClient = new VpnSiteLinkConnectionsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Network/vpnGateways/vpnConnections";
        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> Retrieves the details of a vpn connection. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<VpnConnection>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnConnectionOperations.Get");
            scope.Start();
            try
            {
                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VpnConnection(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the details of a vpn connection. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VpnConnection> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnConnectionOperations.Get");
            scope.Start();
            try
            {
                var response = _restClient.Get(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VpnConnection(this, response.Value), response.GetRawResponse());
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

        /// <summary> Deletes a vpn connection. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> DeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnConnectionOperations.Delete");
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

        /// <summary> Deletes a vpn connection. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Delete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnConnectionOperations.Delete");
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

        /// <summary> Deletes a vpn connection. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<VpnConnectionsDeleteOperation> StartDeleteAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnConnectionOperations.StartDelete");
            scope.Start();
            try
            {
                var response = await _restClient.DeleteAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return new VpnConnectionsDeleteOperation(_clientDiagnostics, Pipeline, _restClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a vpn connection. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VpnConnectionsDeleteOperation StartDelete(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnConnectionOperations.StartDelete");
            scope.Start();
            try
            {
                var response = _restClient.Delete(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return new VpnConnectionsDeleteOperation(_clientDiagnostics, Pipeline, _restClient.CreateDeleteRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves all vpn site link connections for a particular virtual wan vpn gateway vpn connection. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VpnSiteLinkConnection" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<VpnSiteLinkConnection> GetVpnLinkConnections(CancellationToken cancellationToken = default)
        {
            Page<VpnSiteLinkConnection> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnConnectionOperations.GetVpnLinkConnections");
                scope.Start();
                try
                {
                    var response = _vpnLinkConnectionsRestClient.GetByVpnConnection(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VpnSiteLinkConnection> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnConnectionOperations.GetVpnLinkConnections");
                scope.Start();
                try
                {
                    var response = _vpnLinkConnectionsRestClient.GetByVpnConnectionNextPage(nextLink, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Retrieves all vpn site link connections for a particular virtual wan vpn gateway vpn connection. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VpnSiteLinkConnection" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<VpnSiteLinkConnection> GetVpnLinkConnectionsAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VpnSiteLinkConnection>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnConnectionOperations.GetVpnLinkConnections");
                scope.Start();
                try
                {
                    var response = await _vpnLinkConnectionsRestClient.GetByVpnConnectionAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VpnSiteLinkConnection>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VpnConnectionOperations.GetVpnLinkConnections");
                scope.Start();
                try
                {
                    var response = await _vpnLinkConnectionsRestClient.GetByVpnConnectionNextPageAsync(nextLink, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }
        /// <summary> Retrieves the details of a vpn site link connection. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<VpnSiteLinkConnection>> GetVpnSiteLinkConnectionAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnConnectionOperations.GetVpnSiteLinkConnection");
            scope.Start();
            try
            {
                var response = await _vpnSiteLinkConnectionsRestClient.GetAsync(Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the details of a vpn site link connection. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VpnSiteLinkConnection> GetVpnSiteLinkConnection(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnConnectionOperations.GetVpnSiteLinkConnection");
            scope.Start();
            try
            {
                var response = _vpnSiteLinkConnectionsRestClient.Get(Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Starts packet capture on Vpn connection in the specified resource group. </summary>
        /// <param name="filterData"> Start Packet capture parameters on vpn connection. </param>
        /// <param name="linkConnectionNames"> List of site link connection names. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<string>> StartPacketCaptureAsync(string filterData = null, IEnumerable<string> linkConnectionNames = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnConnectionOperations.StartPacketCapture");
            scope.Start();
            try
            {
                var operation = await StartStartPacketCaptureAsync(filterData, linkConnectionNames, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Starts packet capture on Vpn connection in the specified resource group. </summary>
        /// <param name="filterData"> Start Packet capture parameters on vpn connection. </param>
        /// <param name="linkConnectionNames"> List of site link connection names. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<string> StartPacketCapture(string filterData = null, IEnumerable<string> linkConnectionNames = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnConnectionOperations.StartPacketCapture");
            scope.Start();
            try
            {
                var operation = StartStartPacketCapture(filterData, linkConnectionNames, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Starts packet capture on Vpn connection in the specified resource group. </summary>
        /// <param name="filterData"> Start Packet capture parameters on vpn connection. </param>
        /// <param name="linkConnectionNames"> List of site link connection names. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<VpnConnectionsStartPacketCaptureOperation> StartStartPacketCaptureAsync(string filterData = null, IEnumerable<string> linkConnectionNames = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnConnectionOperations.StartStartPacketCapture");
            scope.Start();
            try
            {
                var response = await _restClient.StartPacketCaptureAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, filterData, linkConnectionNames, cancellationToken).ConfigureAwait(false);
                return new VpnConnectionsStartPacketCaptureOperation(_clientDiagnostics, Pipeline, _restClient.CreateStartPacketCaptureRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name, filterData, linkConnectionNames).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Starts packet capture on Vpn connection in the specified resource group. </summary>
        /// <param name="filterData"> Start Packet capture parameters on vpn connection. </param>
        /// <param name="linkConnectionNames"> List of site link connection names. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VpnConnectionsStartPacketCaptureOperation StartStartPacketCapture(string filterData = null, IEnumerable<string> linkConnectionNames = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnConnectionOperations.StartStartPacketCapture");
            scope.Start();
            try
            {
                var response = _restClient.StartPacketCapture(Id.ResourceGroupName, Id.Parent.Name, Id.Name, filterData, linkConnectionNames, cancellationToken);
                return new VpnConnectionsStartPacketCaptureOperation(_clientDiagnostics, Pipeline, _restClient.CreateStartPacketCaptureRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name, filterData, linkConnectionNames).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Stops packet capture on Vpn connection in the specified resource group. </summary>
        /// <param name="sasUrl"> SAS url for packet capture on vpn connection. </param>
        /// <param name="linkConnectionNames"> List of site link connection names. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<string>> StopPacketCaptureAsync(string sasUrl = null, IEnumerable<string> linkConnectionNames = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnConnectionOperations.StopPacketCapture");
            scope.Start();
            try
            {
                var operation = await StartStopPacketCaptureAsync(sasUrl, linkConnectionNames, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Stops packet capture on Vpn connection in the specified resource group. </summary>
        /// <param name="sasUrl"> SAS url for packet capture on vpn connection. </param>
        /// <param name="linkConnectionNames"> List of site link connection names. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<string> StopPacketCapture(string sasUrl = null, IEnumerable<string> linkConnectionNames = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnConnectionOperations.StopPacketCapture");
            scope.Start();
            try
            {
                var operation = StartStopPacketCapture(sasUrl, linkConnectionNames, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Stops packet capture on Vpn connection in the specified resource group. </summary>
        /// <param name="sasUrl"> SAS url for packet capture on vpn connection. </param>
        /// <param name="linkConnectionNames"> List of site link connection names. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<VpnConnectionsStopPacketCaptureOperation> StartStopPacketCaptureAsync(string sasUrl = null, IEnumerable<string> linkConnectionNames = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnConnectionOperations.StartStopPacketCapture");
            scope.Start();
            try
            {
                var response = await _restClient.StopPacketCaptureAsync(Id.ResourceGroupName, Id.Parent.Name, Id.Name, sasUrl, linkConnectionNames, cancellationToken).ConfigureAwait(false);
                return new VpnConnectionsStopPacketCaptureOperation(_clientDiagnostics, Pipeline, _restClient.CreateStopPacketCaptureRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name, sasUrl, linkConnectionNames).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Stops packet capture on Vpn connection in the specified resource group. </summary>
        /// <param name="sasUrl"> SAS url for packet capture on vpn connection. </param>
        /// <param name="linkConnectionNames"> List of site link connection names. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VpnConnectionsStopPacketCaptureOperation StartStopPacketCapture(string sasUrl = null, IEnumerable<string> linkConnectionNames = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VpnConnectionOperations.StartStopPacketCapture");
            scope.Start();
            try
            {
                var response = _restClient.StopPacketCapture(Id.ResourceGroupName, Id.Parent.Name, Id.Name, sasUrl, linkConnectionNames, cancellationToken);
                return new VpnConnectionsStopPacketCaptureOperation(_clientDiagnostics, Pipeline, _restClient.CreateStopPacketCaptureRequest(Id.ResourceGroupName, Id.Parent.Name, Id.Name, sasUrl, linkConnectionNames).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
