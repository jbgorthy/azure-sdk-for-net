// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ApplicationInsights.Management.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ApplicationInsights;
    using Microsoft.Azure.Management.ApplicationInsights.Management;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An Application Insights component Continuous Export configuration
    /// request definition.
    /// </summary>
    public partial class ApplicationInsightsComponentExportRequest
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationInsightsComponentExportRequest class.
        /// </summary>
        public ApplicationInsightsComponentExportRequest()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ApplicationInsightsComponentExportRequest class.
        /// </summary>
        /// <param name="recordTypes">The document types to be exported, as
        /// comma separated values. Allowed values include 'Requests', 'Event',
        /// 'Exceptions', 'Metrics', 'PageViews', 'PageViewPerformance', 'Rdd',
        /// 'PerformanceCounters', 'Availability', 'Messages'.</param>
        /// <param name="destinationType">The Continuous Export destination
        /// type. This has to be 'Blob'.</param>
        /// <param name="destinationAddress">The SAS URL for the destination
        /// storage container. It must grant write permission.</param>
        /// <param name="isEnabled">Set to 'true' to create a Continuous Export
        /// configuration as enabled, otherwise set it to 'false'.</param>
        /// <param name="notificationQueueEnabled">Deprecated</param>
        /// <param name="notificationQueueUri">Deprecated</param>
        /// <param name="destinationStorageSubscriptionId">The subscription ID
        /// of the destination storage container.</param>
        /// <param name="destinationStorageLocationId">The location ID of the
        /// destination storage container.</param>
        /// <param name="destinationAccountId">The name of destination storage
        /// account.</param>
        public ApplicationInsightsComponentExportRequest(string recordTypes = default(string), string destinationType = default(string), string destinationAddress = default(string), string isEnabled = default(string), string notificationQueueEnabled = default(string), string notificationQueueUri = default(string), string destinationStorageSubscriptionId = default(string), string destinationStorageLocationId = default(string), string destinationAccountId = default(string))
        {
            RecordTypes = recordTypes;
            DestinationType = destinationType;
            DestinationAddress = destinationAddress;
            IsEnabled = isEnabled;
            NotificationQueueEnabled = notificationQueueEnabled;
            NotificationQueueUri = notificationQueueUri;
            DestinationStorageSubscriptionId = destinationStorageSubscriptionId;
            DestinationStorageLocationId = destinationStorageLocationId;
            DestinationAccountId = destinationAccountId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the document types to be exported, as comma separated
        /// values. Allowed values include 'Requests', 'Event', 'Exceptions',
        /// 'Metrics', 'PageViews', 'PageViewPerformance', 'Rdd',
        /// 'PerformanceCounters', 'Availability', 'Messages'.
        /// </summary>
        [JsonProperty(PropertyName = "RecordTypes")]
        public string RecordTypes { get; set; }

        /// <summary>
        /// Gets or sets the Continuous Export destination type. This has to be
        /// 'Blob'.
        /// </summary>
        [JsonProperty(PropertyName = "DestinationType")]
        public string DestinationType { get; set; }

        /// <summary>
        /// Gets or sets the SAS URL for the destination storage container. It
        /// must grant write permission.
        /// </summary>
        [JsonProperty(PropertyName = "DestinationAddress")]
        public string DestinationAddress { get; set; }

        /// <summary>
        /// Gets or sets set to 'true' to create a Continuous Export
        /// configuration as enabled, otherwise set it to 'false'.
        /// </summary>
        [JsonProperty(PropertyName = "IsEnabled")]
        public string IsEnabled { get; set; }

        /// <summary>
        /// Gets or sets deprecated
        /// </summary>
        [JsonProperty(PropertyName = "NotificationQueueEnabled")]
        public string NotificationQueueEnabled { get; set; }

        /// <summary>
        /// Gets or sets deprecated
        /// </summary>
        [JsonProperty(PropertyName = "NotificationQueueUri")]
        public string NotificationQueueUri { get; set; }

        /// <summary>
        /// Gets or sets the subscription ID of the destination storage
        /// container.
        /// </summary>
        [JsonProperty(PropertyName = "DestinationStorageSubscriptionId")]
        public string DestinationStorageSubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets the location ID of the destination storage container.
        /// </summary>
        [JsonProperty(PropertyName = "DestinationStorageLocationId")]
        public string DestinationStorageLocationId { get; set; }

        /// <summary>
        /// Gets or sets the name of destination storage account.
        /// </summary>
        [JsonProperty(PropertyName = "DestinationAccountId")]
        public string DestinationAccountId { get; set; }

    }
}
