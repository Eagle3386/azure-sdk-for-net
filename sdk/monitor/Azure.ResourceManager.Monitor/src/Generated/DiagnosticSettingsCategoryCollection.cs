// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Monitor.Models;

namespace Azure.ResourceManager.Monitor
{
    /// <summary> A class representing collection of DiagnosticSettingsCategory and their operations over its parent. </summary>
    public partial class DiagnosticSettingsCategoryCollection : ArmCollection, IEnumerable<DiagnosticSettingsCategory>, IAsyncEnumerable<DiagnosticSettingsCategory>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly DiagnosticSettingsCategoryRestOperations _diagnosticSettingsCategoryRestClient;

        /// <summary> Initializes a new instance of the <see cref="DiagnosticSettingsCategoryCollection"/> class for mocking. </summary>
        protected DiagnosticSettingsCategoryCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DiagnosticSettingsCategoryCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal DiagnosticSettingsCategoryCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            ClientOptions.TryGetApiVersion(DiagnosticSettingsCategory.ResourceType, out string apiVersion);
            _diagnosticSettingsCategoryRestClient = new DiagnosticSettingsCategoryRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri, apiVersion);
        }

        // Collection level operations.

        /// RequestPath: /{resourceUri}/providers/Microsoft.Insights/diagnosticSettingsCategories/{name}
        /// ContextualPath: /{resourceUri}
        /// OperationId: DiagnosticSettingsCategory_Get
        /// <summary> Gets the diagnostic settings category for the specified resource. </summary>
        /// <param name="name"> The name of the diagnostic setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<DiagnosticSettingsCategory> Get(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("DiagnosticSettingsCategoryCollection.Get");
            scope.Start();
            try
            {
                var response = _diagnosticSettingsCategoryRestClient.Get(Id, name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DiagnosticSettingsCategory(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /{resourceUri}/providers/Microsoft.Insights/diagnosticSettingsCategories/{name}
        /// ContextualPath: /{resourceUri}
        /// OperationId: DiagnosticSettingsCategory_Get
        /// <summary> Gets the diagnostic settings category for the specified resource. </summary>
        /// <param name="name"> The name of the diagnostic setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async virtual Task<Response<DiagnosticSettingsCategory>> GetAsync(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("DiagnosticSettingsCategoryCollection.Get");
            scope.Start();
            try
            {
                var response = await _diagnosticSettingsCategoryRestClient.GetAsync(Id, name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new DiagnosticSettingsCategory(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> The name of the diagnostic setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<DiagnosticSettingsCategory> GetIfExists(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("DiagnosticSettingsCategoryCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _diagnosticSettingsCategoryRestClient.Get(Id, name, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<DiagnosticSettingsCategory>(null, response.GetRawResponse());
                return Response.FromValue(new DiagnosticSettingsCategory(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> The name of the diagnostic setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async virtual Task<Response<DiagnosticSettingsCategory>> GetIfExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("DiagnosticSettingsCategoryCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _diagnosticSettingsCategoryRestClient.GetAsync(Id, name, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<DiagnosticSettingsCategory>(null, response.GetRawResponse());
                return Response.FromValue(new DiagnosticSettingsCategory(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> The name of the diagnostic setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public virtual Response<bool> Exists(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("DiagnosticSettingsCategoryCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(name, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="name"> The name of the diagnostic setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string name, CancellationToken cancellationToken = default)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            using var scope = _clientDiagnostics.CreateScope("DiagnosticSettingsCategoryCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(name, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /{resourceUri}/providers/Microsoft.Insights/diagnosticSettingsCategories
        /// ContextualPath: /{resourceUri}
        /// OperationId: DiagnosticSettingsCategory_List
        /// <summary> Lists the diagnostic settings categories for the specified resource. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DiagnosticSettingsCategory" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DiagnosticSettingsCategory> GetAll(CancellationToken cancellationToken = default)
        {
            Page<DiagnosticSettingsCategory> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DiagnosticSettingsCategoryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _diagnosticSettingsCategoryRestClient.List(Id, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DiagnosticSettingsCategory(this, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, null);
        }

        /// RequestPath: /{resourceUri}/providers/Microsoft.Insights/diagnosticSettingsCategories
        /// ContextualPath: /{resourceUri}
        /// OperationId: DiagnosticSettingsCategory_List
        /// <summary> Lists the diagnostic settings categories for the specified resource. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DiagnosticSettingsCategory" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DiagnosticSettingsCategory> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<DiagnosticSettingsCategory>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DiagnosticSettingsCategoryCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _diagnosticSettingsCategoryRestClient.ListAsync(Id, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DiagnosticSettingsCategory(this, value)), null, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, null);
        }

        IEnumerator<DiagnosticSettingsCategory> IEnumerable<DiagnosticSettingsCategory>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DiagnosticSettingsCategory> IAsyncEnumerable<DiagnosticSettingsCategory>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, DiagnosticSettingsCategory, DiagnosticSettingsCategoryData> Construct() { }
    }
}
