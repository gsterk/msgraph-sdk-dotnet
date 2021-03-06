// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type BaseItemRequestBuilder.
    /// </summary>
    public partial class BaseItemRequestBuilder : EntityRequestBuilder, IBaseItemRequestBuilder
    {

        /// <summary>
        /// Constructs a new BaseItemRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public BaseItemRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IBaseItemRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IBaseItemRequest Request(IEnumerable<Option> options)
        {
            return new BaseItemRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for CreatedByUser.
        /// </summary>
        /// <returns>The <see cref="IUserWithReferenceRequestBuilder"/>.</returns>
        public IUserWithReferenceRequestBuilder CreatedByUser
        {
            get
            {
                return new UserWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("createdByUser"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for LastModifiedByUser.
        /// </summary>
        /// <returns>The <see cref="IUserWithReferenceRequestBuilder"/>.</returns>
        public IUserWithReferenceRequestBuilder LastModifiedByUser
        {
            get
            {
                return new UserWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("lastModifiedByUser"), this.Client);
            }
        }
    
    }
}
