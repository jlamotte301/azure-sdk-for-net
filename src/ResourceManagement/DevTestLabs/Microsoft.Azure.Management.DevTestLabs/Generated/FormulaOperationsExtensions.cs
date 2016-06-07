// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DevTestLabs
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure.OData;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for FormulaOperations.
    /// </summary>
    public static partial class FormulaOperationsExtensions
    {
            /// <summary>
            /// List formulas in a given lab.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<Formula> List(this IFormulaOperations operations, string resourceGroupName, string labName, ODataQuery<Formula> odataQuery = default(ODataQuery<Formula>))
            {
                return Task.Factory.StartNew(s => ((IFormulaOperations)s).ListAsync(resourceGroupName, labName, odataQuery), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// List formulas in a given lab.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Formula>> ListAsync(this IFormulaOperations operations, string resourceGroupName, string labName, ODataQuery<Formula> odataQuery = default(ODataQuery<Formula>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, labName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get formula.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the formula.
            /// </param>
            public static Formula GetResource(this IFormulaOperations operations, string resourceGroupName, string labName, string name)
            {
                return Task.Factory.StartNew(s => ((IFormulaOperations)s).GetResourceAsync(resourceGroupName, labName, name), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get formula.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the formula.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Formula> GetResourceAsync(this IFormulaOperations operations, string resourceGroupName, string labName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetResourceWithHttpMessagesAsync(resourceGroupName, labName, name, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or replace an existing Formula. This operation can take a while to
            /// complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the formula.
            /// </param>
            /// <param name='formula'>
            /// </param>
            public static Formula CreateOrUpdateResource(this IFormulaOperations operations, string resourceGroupName, string labName, string name, Formula formula)
            {
                return Task.Factory.StartNew(s => ((IFormulaOperations)s).CreateOrUpdateResourceAsync(resourceGroupName, labName, name, formula), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or replace an existing Formula. This operation can take a while to
            /// complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the formula.
            /// </param>
            /// <param name='formula'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Formula> CreateOrUpdateResourceAsync(this IFormulaOperations operations, string resourceGroupName, string labName, string name, Formula formula, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateResourceWithHttpMessagesAsync(resourceGroupName, labName, name, formula, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or replace an existing Formula. This operation can take a while to
            /// complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the formula.
            /// </param>
            /// <param name='formula'>
            /// </param>
            public static Formula BeginCreateOrUpdateResource(this IFormulaOperations operations, string resourceGroupName, string labName, string name, Formula formula)
            {
                return Task.Factory.StartNew(s => ((IFormulaOperations)s).BeginCreateOrUpdateResourceAsync(resourceGroupName, labName, name, formula), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or replace an existing Formula. This operation can take a while to
            /// complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the formula.
            /// </param>
            /// <param name='formula'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Formula> BeginCreateOrUpdateResourceAsync(this IFormulaOperations operations, string resourceGroupName, string labName, string name, Formula formula, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateResourceWithHttpMessagesAsync(resourceGroupName, labName, name, formula, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete formula.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the formula.
            /// </param>
            public static void DeleteResource(this IFormulaOperations operations, string resourceGroupName, string labName, string name)
            {
                Task.Factory.StartNew(s => ((IFormulaOperations)s).DeleteResourceAsync(resourceGroupName, labName, name), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete formula.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='name'>
            /// The name of the formula.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteResourceAsync(this IFormulaOperations operations, string resourceGroupName, string labName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteResourceWithHttpMessagesAsync(resourceGroupName, labName, name, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// List formulas in a given lab.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Formula> ListNext(this IFormulaOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IFormulaOperations)s).ListNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// List formulas in a given lab.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Formula>> ListNextAsync(this IFormulaOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
