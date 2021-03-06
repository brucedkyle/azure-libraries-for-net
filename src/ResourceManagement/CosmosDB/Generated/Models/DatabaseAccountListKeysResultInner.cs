// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.CosmosDB.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.CosmosDB;
    using Microsoft.Azure.Management.CosmosDB.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The access keys for the given database account.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class DatabaseAccountListKeysResultInner
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DatabaseAccountListKeysResultInner class.
        /// </summary>
        public DatabaseAccountListKeysResultInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// DatabaseAccountListKeysResultInner class.
        /// </summary>
        /// <param name="primaryMasterKey">Base 64 encoded value of the primary
        /// read-write key.</param>
        /// <param name="secondaryMasterKey">Base 64 encoded value of the
        /// secondary read-write key.</param>
        /// <param name="primaryReadonlyMasterKey">Base 64 encoded value of the
        /// primary read-only key.</param>
        /// <param name="secondaryReadonlyMasterKey">Base 64 encoded value of
        /// the secondary read-only key.</param>
        public DatabaseAccountListKeysResultInner(string primaryMasterKey = default(string), string secondaryMasterKey = default(string), string primaryReadonlyMasterKey = default(string), string secondaryReadonlyMasterKey = default(string))
        {
            PrimaryMasterKey = primaryMasterKey;
            SecondaryMasterKey = secondaryMasterKey;
            PrimaryReadonlyMasterKey = primaryReadonlyMasterKey;
            SecondaryReadonlyMasterKey = secondaryReadonlyMasterKey;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets base 64 encoded value of the primary read-write key.
        /// </summary>
        [JsonProperty(PropertyName = "primaryMasterKey")]
        public string PrimaryMasterKey { get; private set; }

        /// <summary>
        /// Gets base 64 encoded value of the secondary read-write key.
        /// </summary>
        [JsonProperty(PropertyName = "secondaryMasterKey")]
        public string SecondaryMasterKey { get; private set; }

        /// <summary>
        /// Gets base 64 encoded value of the primary read-only key.
        /// </summary>
        [JsonProperty(PropertyName = "properties.primaryReadonlyMasterKey")]
        public string PrimaryReadonlyMasterKey { get; private set; }

        /// <summary>
        /// Gets base 64 encoded value of the secondary read-only key.
        /// </summary>
        [JsonProperty(PropertyName = "properties.secondaryReadonlyMasterKey")]
        public string SecondaryReadonlyMasterKey { get; private set; }

    }
}
