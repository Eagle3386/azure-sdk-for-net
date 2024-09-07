// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Billing.Models;

namespace Azure.ResourceManager.Billing
{
    internal partial class ReservationOrdersRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of ReservationOrdersRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public ReservationOrdersRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2024-04-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateGetByBillingAccountRequestUri(string billingAccountName, string reservationOrderId, string expand)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Billing/billingAccounts/", false);
            uri.AppendPath(billingAccountName, true);
            uri.AppendPath("/reservationOrders/", false);
            uri.AppendPath(reservationOrderId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (expand != null)
            {
                uri.AppendQuery("expand", expand, true);
            }
            return uri;
        }

        internal HttpMessage CreateGetByBillingAccountRequest(string billingAccountName, string reservationOrderId, string expand)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Billing/billingAccounts/", false);
            uri.AppendPath(billingAccountName, true);
            uri.AppendPath("/reservationOrders/", false);
            uri.AppendPath(reservationOrderId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (expand != null)
            {
                uri.AppendQuery("expand", expand, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get the details of the ReservationOrder in the billing account. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="expand"> May be used to expand the detail information of some properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/> or <paramref name="reservationOrderId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountName"/> or <paramref name="reservationOrderId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<BillingReservationOrderData>> GetByBillingAccountAsync(string billingAccountName, string reservationOrderId, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingAccountName, nameof(billingAccountName));
            Argument.AssertNotNullOrEmpty(reservationOrderId, nameof(reservationOrderId));

            using var message = CreateGetByBillingAccountRequest(billingAccountName, reservationOrderId, expand);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BillingReservationOrderData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = BillingReservationOrderData.DeserializeBillingReservationOrderData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((BillingReservationOrderData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get the details of the ReservationOrder in the billing account. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="expand"> May be used to expand the detail information of some properties. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/> or <paramref name="reservationOrderId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountName"/> or <paramref name="reservationOrderId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<BillingReservationOrderData> GetByBillingAccount(string billingAccountName, string reservationOrderId, string expand = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingAccountName, nameof(billingAccountName));
            Argument.AssertNotNullOrEmpty(reservationOrderId, nameof(reservationOrderId));

            using var message = CreateGetByBillingAccountRequest(billingAccountName, reservationOrderId, expand);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BillingReservationOrderData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = BillingReservationOrderData.DeserializeBillingReservationOrderData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((BillingReservationOrderData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListByBillingAccountRequestUri(string billingAccountName, string filter, string orderBy, float? skiptoken)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Billing/billingAccounts/", false);
            uri.AppendPath(billingAccountName, true);
            uri.AppendPath("/reservationOrders", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (filter != null)
            {
                uri.AppendQuery("filter", filter, true);
            }
            if (orderBy != null)
            {
                uri.AppendQuery("orderBy", orderBy, true);
            }
            if (skiptoken != null)
            {
                uri.AppendQuery("skiptoken", skiptoken.Value, true);
            }
            return uri;
        }

        internal HttpMessage CreateListByBillingAccountRequest(string billingAccountName, string filter, string orderBy, float? skiptoken)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/providers/Microsoft.Billing/billingAccounts/", false);
            uri.AppendPath(billingAccountName, true);
            uri.AppendPath("/reservationOrders", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (filter != null)
            {
                uri.AppendQuery("filter", filter, true);
            }
            if (orderBy != null)
            {
                uri.AppendQuery("orderBy", orderBy, true);
            }
            if (skiptoken != null)
            {
                uri.AppendQuery("skiptoken", skiptoken.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List all the `ReservationOrders in the billing account. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="filter"> The filter query option allows clients to filter a collection of resources that are addressed by a request URL. </param>
        /// <param name="orderBy"> The orderby query option allows clients to request resources in a particular order. </param>
        /// <param name="skiptoken"> The number of reservations to skip from the list before returning results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ReservationOrderList>> ListByBillingAccountAsync(string billingAccountName, string filter = null, string orderBy = null, float? skiptoken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingAccountName, nameof(billingAccountName));

            using var message = CreateListByBillingAccountRequest(billingAccountName, filter, orderBy, skiptoken);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationOrderList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ReservationOrderList.DeserializeReservationOrderList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List all the `ReservationOrders in the billing account. </summary>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="filter"> The filter query option allows clients to filter a collection of resources that are addressed by a request URL. </param>
        /// <param name="orderBy"> The orderby query option allows clients to request resources in a particular order. </param>
        /// <param name="skiptoken"> The number of reservations to skip from the list before returning results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="billingAccountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ReservationOrderList> ListByBillingAccount(string billingAccountName, string filter = null, string orderBy = null, float? skiptoken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(billingAccountName, nameof(billingAccountName));

            using var message = CreateListByBillingAccountRequest(billingAccountName, filter, orderBy, skiptoken);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationOrderList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ReservationOrderList.DeserializeReservationOrderList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListByBillingAccountNextPageRequestUri(string nextLink, string billingAccountName, string filter, string orderBy, float? skiptoken)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListByBillingAccountNextPageRequest(string nextLink, string billingAccountName, string filter, string orderBy, float? skiptoken)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List all the `ReservationOrders in the billing account. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="filter"> The filter query option allows clients to filter a collection of resources that are addressed by a request URL. </param>
        /// <param name="orderBy"> The orderby query option allows clients to request resources in a particular order. </param>
        /// <param name="skiptoken"> The number of reservations to skip from the list before returning results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="billingAccountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<ReservationOrderList>> ListByBillingAccountNextPageAsync(string nextLink, string billingAccountName, string filter = null, string orderBy = null, float? skiptoken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(billingAccountName, nameof(billingAccountName));

            using var message = CreateListByBillingAccountNextPageRequest(nextLink, billingAccountName, filter, orderBy, skiptoken);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationOrderList value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = ReservationOrderList.DeserializeReservationOrderList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List all the `ReservationOrders in the billing account. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="billingAccountName"> The ID that uniquely identifies a billing account. </param>
        /// <param name="filter"> The filter query option allows clients to filter a collection of resources that are addressed by a request URL. </param>
        /// <param name="orderBy"> The orderby query option allows clients to request resources in a particular order. </param>
        /// <param name="skiptoken"> The number of reservations to skip from the list before returning results. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/> or <paramref name="billingAccountName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="billingAccountName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<ReservationOrderList> ListByBillingAccountNextPage(string nextLink, string billingAccountName, string filter = null, string orderBy = null, float? skiptoken = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(billingAccountName, nameof(billingAccountName));

            using var message = CreateListByBillingAccountNextPageRequest(nextLink, billingAccountName, filter, orderBy, skiptoken);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        ReservationOrderList value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = ReservationOrderList.DeserializeReservationOrderList(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
