// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Logic;
    using Microsoft.Azure.Management.Logic.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The integration account sku.
    /// </summary>
    public partial class IntegrationAccountSku
    {
        /// <summary>
        /// Initializes a new instance of the IntegrationAccountSku class.
        /// </summary>
        public IntegrationAccountSku()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IntegrationAccountSku class.
        /// </summary>
        /// <param name="name">The sku name. Possible values include:
        /// 'NotSpecified', 'Free', 'Standard'</param>
        public IntegrationAccountSku(IntegrationAccountSkuName name)
        {
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the sku name. Possible values include: 'NotSpecified',
        /// 'Free', 'Standard'
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public IntegrationAccountSkuName Name { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
