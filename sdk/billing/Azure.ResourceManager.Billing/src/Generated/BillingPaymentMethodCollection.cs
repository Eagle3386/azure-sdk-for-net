// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Billing
{
    /// <summary>
    /// A class representing a collection of <see cref="BillingPaymentMethodResource"/> and their operations.
    /// Each <see cref="BillingPaymentMethodResource"/> in the collection will belong to the same instance of <see cref="TenantResource"/>.
    /// To get a <see cref="BillingPaymentMethodCollection"/> instance call the GetBillingPaymentMethods method from an instance of <see cref="TenantResource"/>.
    /// </summary>
    public partial class BillingPaymentMethodCollection : ArmCollection, IEnumerable<BillingPaymentMethodResource>, IAsyncEnumerable<BillingPaymentMethodResource>
    {
        private readonly ClientDiagnostics _billingPaymentMethodPaymentMethodsClientDiagnostics;
        private readonly PaymentMethodsRestOperations _billingPaymentMethodPaymentMethodsRestClient;

        /// <summary> Initializes a new instance of the <see cref="BillingPaymentMethodCollection"/> class for mocking. </summary>
        protected BillingPaymentMethodCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BillingPaymentMethodCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal BillingPaymentMethodCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _billingPaymentMethodPaymentMethodsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Billing", BillingPaymentMethodResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(BillingPaymentMethodResource.ResourceType, out string billingPaymentMethodPaymentMethodsApiVersion);
            _billingPaymentMethodPaymentMethodsRestClient = new PaymentMethodsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, billingPaymentMethodPaymentMethodsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != TenantResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, TenantResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a payment method owned by the caller.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/paymentMethods/{paymentMethodName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PaymentMethods_GetByUser</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingPaymentMethodResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="paymentMethodName"> The ID that uniquely identifies a payment method. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="paymentMethodName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="paymentMethodName"/> is null. </exception>
        public virtual async Task<Response<BillingPaymentMethodResource>> GetAsync(string paymentMethodName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(paymentMethodName, nameof(paymentMethodName));

            using var scope = _billingPaymentMethodPaymentMethodsClientDiagnostics.CreateScope("BillingPaymentMethodCollection.Get");
            scope.Start();
            try
            {
                var response = await _billingPaymentMethodPaymentMethodsRestClient.GetByUserAsync(paymentMethodName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingPaymentMethodResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a payment method owned by the caller.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/paymentMethods/{paymentMethodName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PaymentMethods_GetByUser</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingPaymentMethodResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="paymentMethodName"> The ID that uniquely identifies a payment method. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="paymentMethodName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="paymentMethodName"/> is null. </exception>
        public virtual Response<BillingPaymentMethodResource> Get(string paymentMethodName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(paymentMethodName, nameof(paymentMethodName));

            using var scope = _billingPaymentMethodPaymentMethodsClientDiagnostics.CreateScope("BillingPaymentMethodCollection.Get");
            scope.Start();
            try
            {
                var response = _billingPaymentMethodPaymentMethodsRestClient.GetByUser(paymentMethodName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new BillingPaymentMethodResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the payment methods owned by the caller.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/paymentMethods</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PaymentMethods_ListByUser</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingPaymentMethodResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="BillingPaymentMethodResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<BillingPaymentMethodResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _billingPaymentMethodPaymentMethodsRestClient.CreateListByUserRequest();
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _billingPaymentMethodPaymentMethodsRestClient.CreateListByUserNextPageRequest(nextLink);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new BillingPaymentMethodResource(Client, BillingPaymentMethodData.DeserializeBillingPaymentMethodData(e)), _billingPaymentMethodPaymentMethodsClientDiagnostics, Pipeline, "BillingPaymentMethodCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the payment methods owned by the caller.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/paymentMethods</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PaymentMethods_ListByUser</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingPaymentMethodResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="BillingPaymentMethodResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<BillingPaymentMethodResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _billingPaymentMethodPaymentMethodsRestClient.CreateListByUserRequest();
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _billingPaymentMethodPaymentMethodsRestClient.CreateListByUserNextPageRequest(nextLink);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new BillingPaymentMethodResource(Client, BillingPaymentMethodData.DeserializeBillingPaymentMethodData(e)), _billingPaymentMethodPaymentMethodsClientDiagnostics, Pipeline, "BillingPaymentMethodCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/paymentMethods/{paymentMethodName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PaymentMethods_GetByUser</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingPaymentMethodResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="paymentMethodName"> The ID that uniquely identifies a payment method. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="paymentMethodName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="paymentMethodName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string paymentMethodName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(paymentMethodName, nameof(paymentMethodName));

            using var scope = _billingPaymentMethodPaymentMethodsClientDiagnostics.CreateScope("BillingPaymentMethodCollection.Exists");
            scope.Start();
            try
            {
                var response = await _billingPaymentMethodPaymentMethodsRestClient.GetByUserAsync(paymentMethodName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/paymentMethods/{paymentMethodName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PaymentMethods_GetByUser</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingPaymentMethodResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="paymentMethodName"> The ID that uniquely identifies a payment method. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="paymentMethodName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="paymentMethodName"/> is null. </exception>
        public virtual Response<bool> Exists(string paymentMethodName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(paymentMethodName, nameof(paymentMethodName));

            using var scope = _billingPaymentMethodPaymentMethodsClientDiagnostics.CreateScope("BillingPaymentMethodCollection.Exists");
            scope.Start();
            try
            {
                var response = _billingPaymentMethodPaymentMethodsRestClient.GetByUser(paymentMethodName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/paymentMethods/{paymentMethodName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PaymentMethods_GetByUser</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingPaymentMethodResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="paymentMethodName"> The ID that uniquely identifies a payment method. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="paymentMethodName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="paymentMethodName"/> is null. </exception>
        public virtual async Task<NullableResponse<BillingPaymentMethodResource>> GetIfExistsAsync(string paymentMethodName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(paymentMethodName, nameof(paymentMethodName));

            using var scope = _billingPaymentMethodPaymentMethodsClientDiagnostics.CreateScope("BillingPaymentMethodCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _billingPaymentMethodPaymentMethodsRestClient.GetByUserAsync(paymentMethodName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<BillingPaymentMethodResource>(response.GetRawResponse());
                return Response.FromValue(new BillingPaymentMethodResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Billing/paymentMethods/{paymentMethodName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>PaymentMethods_GetByUser</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2024-04-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="BillingPaymentMethodResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="paymentMethodName"> The ID that uniquely identifies a payment method. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="paymentMethodName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="paymentMethodName"/> is null. </exception>
        public virtual NullableResponse<BillingPaymentMethodResource> GetIfExists(string paymentMethodName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(paymentMethodName, nameof(paymentMethodName));

            using var scope = _billingPaymentMethodPaymentMethodsClientDiagnostics.CreateScope("BillingPaymentMethodCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _billingPaymentMethodPaymentMethodsRestClient.GetByUser(paymentMethodName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<BillingPaymentMethodResource>(response.GetRawResponse());
                return Response.FromValue(new BillingPaymentMethodResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<BillingPaymentMethodResource> IEnumerable<BillingPaymentMethodResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<BillingPaymentMethodResource> IAsyncEnumerable<BillingPaymentMethodResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
