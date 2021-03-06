// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.CustomerInsights.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.CustomerInsights;
    using Microsoft.Azure.Management.CustomerInsights.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Hub resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class HubInner : Microsoft.Azure.Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the HubInner class.
        /// </summary>
        public HubInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HubInner class.
        /// </summary>
        /// <param name="apiEndpoint">API endpoint URL of the hub.</param>
        /// <param name="webEndpoint">Web endpoint URL of the hub.</param>
        /// <param name="provisioningState">Provisioning state of the
        /// hub.</param>
        /// <param name="tenantFeatures">The bit flags for enabled hub
        /// features. Bit 0 is set to 1 indicates graph is enabled, or disabled
        /// if set to 0. Bit 1 is set to 1 indicates the hub is disabled, or
        /// enabled if set to 0.</param>
        /// <param name="hubBillingInfo">Billing settings of the hub.</param>
        public HubInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string apiEndpoint = default(string), string webEndpoint = default(string), string provisioningState = default(string), int? tenantFeatures = default(int?), HubBillingInfoFormat hubBillingInfo = default(HubBillingInfoFormat))
            : base(location, id, name, type, tags)
        {
            ApiEndpoint = apiEndpoint;
            WebEndpoint = webEndpoint;
            ProvisioningState = provisioningState;
            TenantFeatures = tenantFeatures;
            HubBillingInfo = hubBillingInfo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets API endpoint URL of the hub.
        /// </summary>
        [JsonProperty(PropertyName = "properties.apiEndpoint")]
        public string ApiEndpoint { get; private set; }

        /// <summary>
        /// Gets web endpoint URL of the hub.
        /// </summary>
        [JsonProperty(PropertyName = "properties.webEndpoint")]
        public string WebEndpoint { get; private set; }

        /// <summary>
        /// Gets provisioning state of the hub.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets or sets the bit flags for enabled hub features. Bit 0 is set
        /// to 1 indicates graph is enabled, or disabled if set to 0. Bit 1 is
        /// set to 1 indicates the hub is disabled, or enabled if set to 0.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tenantFeatures")]
        public int? TenantFeatures { get; set; }

        /// <summary>
        /// Gets or sets billing settings of the hub.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hubBillingInfo")]
        public HubBillingInfoFormat HubBillingInfo { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (HubBillingInfo != null)
            {
                HubBillingInfo.Validate();
            }
        }
    }
}
