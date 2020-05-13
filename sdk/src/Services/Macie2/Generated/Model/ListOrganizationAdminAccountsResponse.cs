/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// This is the response object from the ListOrganizationAdminAccounts operation.
    /// </summary>
    public partial class ListOrganizationAdminAccountsResponse : AmazonWebServiceResponse
    {
        private List<AdminAccount> _adminAccounts = new List<AdminAccount>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AdminAccounts. 
        /// <para>
        /// An array of objects, one for each account that's designated as a delegated administrator
        /// of Amazon Macie for the AWS organization. Of those accounts, only one can have a status
        /// of ENABLED.
        /// </para>
        /// </summary>
        public List<AdminAccount> AdminAccounts
        {
            get { return this._adminAccounts; }
            set { this._adminAccounts = value; }
        }

        // Check to see if AdminAccounts property is set
        internal bool IsSetAdminAccounts()
        {
            return this._adminAccounts != null && this._adminAccounts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The string to use in a subsequent request to get the next page of results in a paginated
        /// response. This value is null if there are no additional pages.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}