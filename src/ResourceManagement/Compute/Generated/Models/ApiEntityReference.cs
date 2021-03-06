// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Compute;
    using Microsoft.Azure.Management.Compute.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The API entity reference.
    /// </summary>
    public partial class ApiEntityReference
    {
        /// <summary>
        /// Initializes a new instance of the ApiEntityReference class.
        /// </summary>
        public ApiEntityReference()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ApiEntityReference class.
        /// </summary>
        /// <param name="id">The ARM resource id in the form of
        /// /subscriptions/{SubcriptionId}/resourceGroups/{ResourceGroupName}/...</param>
        public ApiEntityReference(string id = default(string))
        {
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ARM resource id in the form of
        /// /subscriptions/{SubcriptionId}/resourceGroups/{ResourceGroupName}/...
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

    }
}
