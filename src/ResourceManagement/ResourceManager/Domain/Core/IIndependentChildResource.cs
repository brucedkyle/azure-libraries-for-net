// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.ResourceManager.Fluent.Core
{
    /// <summary>
    /// Interface for the child resource which can be CRUDed independently from the parent resource.
    /// </summary>
    public interface IIndependentChildResource<ManagerT, InnerT>  :
        IGroupableResource<ManagerT, InnerT>,
        IIndependentChild<ManagerT>
    {
    }
}