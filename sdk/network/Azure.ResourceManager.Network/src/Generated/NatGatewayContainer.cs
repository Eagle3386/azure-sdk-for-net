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
    /// <summary> A class representing collection of NatGateway and their operations over a ResourceGroup. </summary>
    public partial class NatGatewayContainer : ResourceContainer
    {
        /// <summary> Initializes a new instance of the <see cref="NatGatewayContainer"/> class for mocking. </summary>
        protected NatGatewayContainer()
        {
        }

        /// <summary> Initializes a new instance of NatGatewayContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal NatGatewayContainer(ResourceOperations parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private NatGatewaysRestOperations _restClient => new NatGatewaysRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroupOperations.ResourceType;

        // Container level operations.

        /// <summary> Creates or updates a nat gateway. </summary>
        /// <param name="natGatewayName"> The name of the nat gateway. </param>
        /// <param name="parameters"> Parameters supplied to the create or update nat gateway operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="natGatewayName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual Response<NatGateway> CreateOrUpdate(string natGatewayName, NatGatewayData parameters, CancellationToken cancellationToken = default)
        {
            if (natGatewayName == null)
            {
                throw new ArgumentNullException(nameof(natGatewayName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("NatGatewayContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(natGatewayName, parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a nat gateway. </summary>
        /// <param name="natGatewayName"> The name of the nat gateway. </param>
        /// <param name="parameters"> Parameters supplied to the create or update nat gateway operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="natGatewayName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<NatGateway>> CreateOrUpdateAsync(string natGatewayName, NatGatewayData parameters, CancellationToken cancellationToken = default)
        {
            if (natGatewayName == null)
            {
                throw new ArgumentNullException(nameof(natGatewayName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("NatGatewayContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(natGatewayName, parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a nat gateway. </summary>
        /// <param name="natGatewayName"> The name of the nat gateway. </param>
        /// <param name="parameters"> Parameters supplied to the create or update nat gateway operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="natGatewayName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual NatGatewaysCreateOrUpdateOperation StartCreateOrUpdate(string natGatewayName, NatGatewayData parameters, CancellationToken cancellationToken = default)
        {
            if (natGatewayName == null)
            {
                throw new ArgumentNullException(nameof(natGatewayName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("NatGatewayContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, natGatewayName, parameters, cancellationToken);
                return new NatGatewaysCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, natGatewayName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a nat gateway. </summary>
        /// <param name="natGatewayName"> The name of the nat gateway. </param>
        /// <param name="parameters"> Parameters supplied to the create or update nat gateway operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="natGatewayName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<NatGatewaysCreateOrUpdateOperation> StartCreateOrUpdateAsync(string natGatewayName, NatGatewayData parameters, CancellationToken cancellationToken = default)
        {
            if (natGatewayName == null)
            {
                throw new ArgumentNullException(nameof(natGatewayName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("NatGatewayContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, natGatewayName, parameters, cancellationToken).ConfigureAwait(false);
                return new NatGatewaysCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, natGatewayName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="natGatewayName"> The name of the nat gateway. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<NatGateway> Get(string natGatewayName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NatGatewayContainer.Get");
            scope.Start();
            try
            {
                if (natGatewayName == null)
                {
                    throw new ArgumentNullException(nameof(natGatewayName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, natGatewayName, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NatGateway(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="natGatewayName"> The name of the nat gateway. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<NatGateway>> GetAsync(string natGatewayName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NatGatewayContainer.Get");
            scope.Start();
            try
            {
                if (natGatewayName == null)
                {
                    throw new ArgumentNullException(nameof(natGatewayName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, natGatewayName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new NatGateway(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="natGatewayName"> The name of the nat gateway. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<NatGateway> GetIfExists(string natGatewayName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NatGatewayContainer.GetIfExists");
            scope.Start();
            try
            {
                if (natGatewayName == null)
                {
                    throw new ArgumentNullException(nameof(natGatewayName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, natGatewayName, expand, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<NatGateway>(null, response.GetRawResponse())
                    : Response.FromValue(new NatGateway(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="natGatewayName"> The name of the nat gateway. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<NatGateway>> GetIfExistsAsync(string natGatewayName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NatGatewayContainer.GetIfExists");
            scope.Start();
            try
            {
                if (natGatewayName == null)
                {
                    throw new ArgumentNullException(nameof(natGatewayName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, natGatewayName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<NatGateway>(null, response.GetRawResponse())
                    : Response.FromValue(new NatGateway(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="natGatewayName"> The name of the nat gateway. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string natGatewayName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NatGatewayContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (natGatewayName == null)
                {
                    throw new ArgumentNullException(nameof(natGatewayName));
                }

                var response = GetIfExists(natGatewayName, expand, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="natGatewayName"> The name of the nat gateway. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string natGatewayName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NatGatewayContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (natGatewayName == null)
                {
                    throw new ArgumentNullException(nameof(natGatewayName));
                }

                var response = await GetIfExistsAsync(natGatewayName, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all nat gateways in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NatGateway" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<NatGateway> GetAll(CancellationToken cancellationToken = default)
        {
            Page<NatGateway> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NatGatewayContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAll(Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NatGateway(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<NatGateway> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NatGatewayContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllNextPage(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new NatGateway(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all nat gateways in a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NatGateway" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<NatGateway> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<NatGateway>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NatGatewayContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllAsync(Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NatGateway(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<NatGateway>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("NatGatewayContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllNextPageAsync(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new NatGateway(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="NatGateway" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<GenericResourceExpanded> GetAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NatGatewayContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(NatGatewayOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="NatGateway" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<GenericResourceExpanded> GetAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("NatGatewayContainer.GetAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(NatGatewayOperations.ResourceType);
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
        // public ArmBuilder<ResourceIdentifier, NatGateway, NatGatewayData> Construct() { }
    }
}
