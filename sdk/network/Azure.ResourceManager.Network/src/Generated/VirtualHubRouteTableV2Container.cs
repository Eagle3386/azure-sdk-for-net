// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of VirtualHubRouteTableV2 and their operations over a VirtualHub. </summary>
    public partial class VirtualHubRouteTableV2Container : ResourceContainer
    {
        /// <summary> Initializes a new instance of the <see cref="VirtualHubRouteTableV2Container"/> class for mocking. </summary>
        protected VirtualHubRouteTableV2Container()
        {
        }

        /// <summary> Initializes a new instance of VirtualHubRouteTableV2Container class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal VirtualHubRouteTableV2Container(ResourceOperations parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private VirtualHubRouteTableV2SRestOperations _restClient => new VirtualHubRouteTableV2SRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => VirtualHubOperations.ResourceType;

        // Container level operations.

        /// <summary> Creates a VirtualHubRouteTableV2 resource if it doesn&apos;t exist else updates the existing VirtualHubRouteTableV2. </summary>
        /// <param name="routeTableName"> The name of the VirtualHubRouteTableV2. </param>
        /// <param name="virtualHubRouteTableV2Parameters"> Parameters supplied to create or update VirtualHubRouteTableV2. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeTableName"/> or <paramref name="virtualHubRouteTableV2Parameters"/> is null. </exception>
        public virtual Response<VirtualHubRouteTableV2> CreateOrUpdate(string routeTableName, VirtualHubRouteTableV2Data virtualHubRouteTableV2Parameters, CancellationToken cancellationToken = default)
        {
            if (routeTableName == null)
            {
                throw new ArgumentNullException(nameof(routeTableName));
            }
            if (virtualHubRouteTableV2Parameters == null)
            {
                throw new ArgumentNullException(nameof(virtualHubRouteTableV2Parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualHubRouteTableV2Container.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(routeTableName, virtualHubRouteTableV2Parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a VirtualHubRouteTableV2 resource if it doesn&apos;t exist else updates the existing VirtualHubRouteTableV2. </summary>
        /// <param name="routeTableName"> The name of the VirtualHubRouteTableV2. </param>
        /// <param name="virtualHubRouteTableV2Parameters"> Parameters supplied to create or update VirtualHubRouteTableV2. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeTableName"/> or <paramref name="virtualHubRouteTableV2Parameters"/> is null. </exception>
        public async virtual Task<Response<VirtualHubRouteTableV2>> CreateOrUpdateAsync(string routeTableName, VirtualHubRouteTableV2Data virtualHubRouteTableV2Parameters, CancellationToken cancellationToken = default)
        {
            if (routeTableName == null)
            {
                throw new ArgumentNullException(nameof(routeTableName));
            }
            if (virtualHubRouteTableV2Parameters == null)
            {
                throw new ArgumentNullException(nameof(virtualHubRouteTableV2Parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualHubRouteTableV2Container.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(routeTableName, virtualHubRouteTableV2Parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a VirtualHubRouteTableV2 resource if it doesn&apos;t exist else updates the existing VirtualHubRouteTableV2. </summary>
        /// <param name="routeTableName"> The name of the VirtualHubRouteTableV2. </param>
        /// <param name="virtualHubRouteTableV2Parameters"> Parameters supplied to create or update VirtualHubRouteTableV2. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeTableName"/> or <paramref name="virtualHubRouteTableV2Parameters"/> is null. </exception>
        public virtual VirtualHubRouteTableV2SCreateOrUpdateOperation StartCreateOrUpdate(string routeTableName, VirtualHubRouteTableV2Data virtualHubRouteTableV2Parameters, CancellationToken cancellationToken = default)
        {
            if (routeTableName == null)
            {
                throw new ArgumentNullException(nameof(routeTableName));
            }
            if (virtualHubRouteTableV2Parameters == null)
            {
                throw new ArgumentNullException(nameof(virtualHubRouteTableV2Parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualHubRouteTableV2Container.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, Id.Name, routeTableName, virtualHubRouteTableV2Parameters, cancellationToken);
                return new VirtualHubRouteTableV2SCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, routeTableName, virtualHubRouteTableV2Parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a VirtualHubRouteTableV2 resource if it doesn&apos;t exist else updates the existing VirtualHubRouteTableV2. </summary>
        /// <param name="routeTableName"> The name of the VirtualHubRouteTableV2. </param>
        /// <param name="virtualHubRouteTableV2Parameters"> Parameters supplied to create or update VirtualHubRouteTableV2. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="routeTableName"/> or <paramref name="virtualHubRouteTableV2Parameters"/> is null. </exception>
        public async virtual Task<VirtualHubRouteTableV2SCreateOrUpdateOperation> StartCreateOrUpdateAsync(string routeTableName, VirtualHubRouteTableV2Data virtualHubRouteTableV2Parameters, CancellationToken cancellationToken = default)
        {
            if (routeTableName == null)
            {
                throw new ArgumentNullException(nameof(routeTableName));
            }
            if (virtualHubRouteTableV2Parameters == null)
            {
                throw new ArgumentNullException(nameof(virtualHubRouteTableV2Parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualHubRouteTableV2Container.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Name, routeTableName, virtualHubRouteTableV2Parameters, cancellationToken).ConfigureAwait(false);
                return new VirtualHubRouteTableV2SCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, routeTableName, virtualHubRouteTableV2Parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="routeTableName"> The name of the VirtualHubRouteTableV2. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<VirtualHubRouteTableV2> Get(string routeTableName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualHubRouteTableV2Container.Get");
            scope.Start();
            try
            {
                if (routeTableName == null)
                {
                    throw new ArgumentNullException(nameof(routeTableName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, routeTableName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new VirtualHubRouteTableV2(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="routeTableName"> The name of the VirtualHubRouteTableV2. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<VirtualHubRouteTableV2>> GetAsync(string routeTableName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualHubRouteTableV2Container.Get");
            scope.Start();
            try
            {
                if (routeTableName == null)
                {
                    throw new ArgumentNullException(nameof(routeTableName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, routeTableName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new VirtualHubRouteTableV2(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="routeTableName"> The name of the VirtualHubRouteTableV2. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<VirtualHubRouteTableV2> GetIfExists(string routeTableName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualHubRouteTableV2Container.GetIfExists");
            scope.Start();
            try
            {
                if (routeTableName == null)
                {
                    throw new ArgumentNullException(nameof(routeTableName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, routeTableName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<VirtualHubRouteTableV2>(null, response.GetRawResponse())
                    : Response.FromValue(new VirtualHubRouteTableV2(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="routeTableName"> The name of the VirtualHubRouteTableV2. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<VirtualHubRouteTableV2>> GetIfExistsAsync(string routeTableName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualHubRouteTableV2Container.GetIfExists");
            scope.Start();
            try
            {
                if (routeTableName == null)
                {
                    throw new ArgumentNullException(nameof(routeTableName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, routeTableName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<VirtualHubRouteTableV2>(null, response.GetRawResponse())
                    : Response.FromValue(new VirtualHubRouteTableV2(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="routeTableName"> The name of the VirtualHubRouteTableV2. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string routeTableName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualHubRouteTableV2Container.CheckIfExists");
            scope.Start();
            try
            {
                if (routeTableName == null)
                {
                    throw new ArgumentNullException(nameof(routeTableName));
                }

                var response = GetIfExists(routeTableName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="routeTableName"> The name of the VirtualHubRouteTableV2. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string routeTableName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualHubRouteTableV2Container.CheckIfExists");
            scope.Start();
            try
            {
                if (routeTableName == null)
                {
                    throw new ArgumentNullException(nameof(routeTableName));
                }

                var response = await GetIfExistsAsync(routeTableName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the details of all VirtualHubRouteTableV2s. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="VirtualHubRouteTableV2" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<VirtualHubRouteTableV2> GetAll(CancellationToken cancellationToken = default)
        {
            Page<VirtualHubRouteTableV2> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualHubRouteTableV2Container.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAll(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualHubRouteTableV2(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualHubRouteTableV2> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualHubRouteTableV2Container.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllNextPage(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualHubRouteTableV2(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Retrieves the details of all VirtualHubRouteTableV2s. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="VirtualHubRouteTableV2" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<VirtualHubRouteTableV2> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<VirtualHubRouteTableV2>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualHubRouteTableV2Container.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualHubRouteTableV2(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualHubRouteTableV2>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualHubRouteTableV2Container.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllNextPageAsync(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new VirtualHubRouteTableV2(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="VirtualHubRouteTableV2" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> GetAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualHubRouteTableV2Container.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualHubRouteTableV2Operations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="VirtualHubRouteTableV2" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> GetAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualHubRouteTableV2Container.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(VirtualHubRouteTableV2Operations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, VirtualHubRouteTableV2, VirtualHubRouteTableV2Data> Construct() { }
    }
}
