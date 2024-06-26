// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Security.Models
{
    using System.Linq;

    /// <summary>
    /// Statistical information about the number of alerts per device during last
    /// set number of days.
    /// </summary>
    public partial class IoTSecurityAlertedDevice
    {
        /// <summary>
        /// Initializes a new instance of the IoTSecurityAlertedDevice class.
        /// </summary>
        public IoTSecurityAlertedDevice()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IoTSecurityAlertedDevice class.
        /// </summary>

        /// <param name="deviceId">Device identifier.
        /// </param>

        /// <param name="alertsCount">Number of alerts raised for this device.
        /// </param>
        public IoTSecurityAlertedDevice(string deviceId = default(string), long? alertsCount = default(long?))

        {
            this.DeviceId = deviceId;
            this.AlertsCount = alertsCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets device identifier.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "deviceId")]
        public string DeviceId {get; private set; }

        /// <summary>
        /// Gets number of alerts raised for this device.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "alertsCount")]
        public long? AlertsCount {get; private set; }
    }
}