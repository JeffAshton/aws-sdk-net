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
    /// This is the response object from the GetUsageTotals operation.
    /// </summary>
    public partial class GetUsageTotalsResponse : AmazonWebServiceResponse
    {
        private List<UsageTotal> _usageTotals = new List<UsageTotal>();

        /// <summary>
        /// Gets and sets the property UsageTotals. 
        /// <para>
        /// An array of objects that contains the results of the query. Each object contains the
        /// data for a specific usage metric.
        /// </para>
        /// </summary>
        public List<UsageTotal> UsageTotals
        {
            get { return this._usageTotals; }
            set { this._usageTotals = value; }
        }

        // Check to see if UsageTotals property is set
        internal bool IsSetUsageTotals()
        {
            return this._usageTotals != null && this._usageTotals.Count > 0; 
        }

    }
}