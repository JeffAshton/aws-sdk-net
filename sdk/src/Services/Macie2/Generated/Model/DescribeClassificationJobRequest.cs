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
    /// Container for the parameters to the DescribeClassificationJob operation.
    /// Retrieves information about the status and settings for a classification job.
    /// </summary>
    public partial class DescribeClassificationJobRequest : AmazonMacie2Request
    {
        private string _jobId;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The unique identifier for the classification job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

    }
}