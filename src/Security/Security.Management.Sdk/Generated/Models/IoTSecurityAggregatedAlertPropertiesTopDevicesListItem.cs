// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Security.Models
{
    using System.Linq;

    public partial class IoTSecurityAggregatedAlertPropertiesTopDevicesListItem
    {
        /// <summary>
        /// Initializes a new instance of the IoTSecurityAggregatedAlertPropertiesTopDevicesListItem class.
        /// </summary>
        public IoTSecurityAggregatedAlertPropertiesTopDevicesListItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IoTSecurityAggregatedAlertPropertiesTopDevicesListItem class.
        /// </summary>

        /// <param name="deviceId">Name of the device.
        /// </param>

        /// <param name="alertsCount">Number of alerts raised for this device.
        /// </param>

        /// <param name="lastOccurrence">Most recent time this alert was raised for this device, on this day.
        /// </param>
        public IoTSecurityAggregatedAlertPropertiesTopDevicesListItem(string deviceId = default(string), long? alertsCount = default(long?), string lastOccurrence = default(string))

        {
            this.DeviceId = deviceId;
            this.AlertsCount = alertsCount;
            this.LastOccurrence = lastOccurrence;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets name of the device.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "deviceId")]
        public string DeviceId {get; private set; }

        /// <summary>
        /// Gets number of alerts raised for this device.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "alertsCount")]
        public long? AlertsCount {get; private set; }

        /// <summary>
        /// Gets most recent time this alert was raised for this device, on this day.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastOccurrence")]
        public string LastOccurrence {get; private set; }
    }
}