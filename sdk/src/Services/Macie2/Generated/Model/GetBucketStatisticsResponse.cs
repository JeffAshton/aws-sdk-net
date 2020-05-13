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
    /// This is the response object from the GetBucketStatistics operation.
    /// </summary>
    public partial class GetBucketStatisticsResponse : AmazonWebServiceResponse
    {
        private long? _bucketCount;
        private BucketCountByEffectivePermission _bucketCountByEffectivePermission;
        private BucketCountByEncryptionType _bucketCountByEncryptionType;
        private BucketCountBySharedAccessType _bucketCountBySharedAccessType;
        private long? _classifiableObjectCount;
        private DateTime? _lastUpdated;
        private long? _objectCount;
        private long? _sizeInBytes;
        private long? _sizeInBytesCompressed;

        /// <summary>
        /// Gets and sets the property BucketCount. 
        /// <para>
        /// The total number of buckets.
        /// </para>
        /// </summary>
        public long BucketCount
        {
            get { return this._bucketCount.GetValueOrDefault(); }
            set { this._bucketCount = value; }
        }

        // Check to see if BucketCount property is set
        internal bool IsSetBucketCount()
        {
            return this._bucketCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BucketCountByEffectivePermission. 
        /// <para>
        /// The total number of buckets that are publicly accessible, based on a combination of
        /// permissions settings for each bucket.
        /// </para>
        /// </summary>
        public BucketCountByEffectivePermission BucketCountByEffectivePermission
        {
            get { return this._bucketCountByEffectivePermission; }
            set { this._bucketCountByEffectivePermission = value; }
        }

        // Check to see if BucketCountByEffectivePermission property is set
        internal bool IsSetBucketCountByEffectivePermission()
        {
            return this._bucketCountByEffectivePermission != null;
        }

        /// <summary>
        /// Gets and sets the property BucketCountByEncryptionType. 
        /// <para>
        /// The total number of buckets, grouped by server-side encryption type. This object also
        /// reports the total number of buckets that aren't encrypted.
        /// </para>
        /// </summary>
        public BucketCountByEncryptionType BucketCountByEncryptionType
        {
            get { return this._bucketCountByEncryptionType; }
            set { this._bucketCountByEncryptionType = value; }
        }

        // Check to see if BucketCountByEncryptionType property is set
        internal bool IsSetBucketCountByEncryptionType()
        {
            return this._bucketCountByEncryptionType != null;
        }

        /// <summary>
        /// Gets and sets the property BucketCountBySharedAccessType. 
        /// <para>
        /// The total number of buckets that are shared with another AWS account or configured
        /// to support cross-origin resource sharing (CORS).
        /// </para>
        /// </summary>
        public BucketCountBySharedAccessType BucketCountBySharedAccessType
        {
            get { return this._bucketCountBySharedAccessType; }
            set { this._bucketCountBySharedAccessType = value; }
        }

        // Check to see if BucketCountBySharedAccessType property is set
        internal bool IsSetBucketCountBySharedAccessType()
        {
            return this._bucketCountBySharedAccessType != null;
        }

        /// <summary>
        /// Gets and sets the property ClassifiableObjectCount. 
        /// <para>
        /// The total number of objects that Amazon Macie can monitor and analyze in all the buckets.
        /// These objects use a file format, file extension, or content type that Amazon Macie
        /// supports.
        /// </para>
        /// </summary>
        public long ClassifiableObjectCount
        {
            get { return this._classifiableObjectCount.GetValueOrDefault(); }
            set { this._classifiableObjectCount = value; }
        }

        // Check to see if ClassifiableObjectCount property is set
        internal bool IsSetClassifiableObjectCount()
        {
            return this._classifiableObjectCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdated. 
        /// <para>
        /// The date and time, in UTC and extended ISO 8601 format, when Amazon Macie last analyzed
        /// the buckets.
        /// </para>
        /// </summary>
        public DateTime LastUpdated
        {
            get { return this._lastUpdated.GetValueOrDefault(); }
            set { this._lastUpdated = value; }
        }

        // Check to see if LastUpdated property is set
        internal bool IsSetLastUpdated()
        {
            return this._lastUpdated.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ObjectCount. 
        /// <para>
        /// The total number of objects in all the buckets.
        /// </para>
        /// </summary>
        public long ObjectCount
        {
            get { return this._objectCount.GetValueOrDefault(); }
            set { this._objectCount = value; }
        }

        // Check to see if ObjectCount property is set
        internal bool IsSetObjectCount()
        {
            return this._objectCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SizeInBytes. 
        /// <para>
        /// The total storage size, in bytes, of all the buckets.
        /// </para>
        /// </summary>
        public long SizeInBytes
        {
            get { return this._sizeInBytes.GetValueOrDefault(); }
            set { this._sizeInBytes = value; }
        }

        // Check to see if SizeInBytes property is set
        internal bool IsSetSizeInBytes()
        {
            return this._sizeInBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SizeInBytesCompressed. 
        /// <para>
        /// The total compressed storage size, in bytes, of all the buckets.
        /// </para>
        /// </summary>
        public long SizeInBytesCompressed
        {
            get { return this._sizeInBytesCompressed.GetValueOrDefault(); }
            set { this._sizeInBytesCompressed = value; }
        }

        // Check to see if SizeInBytesCompressed property is set
        internal bool IsSetSizeInBytesCompressed()
        {
            return this._sizeInBytesCompressed.HasValue; 
        }

    }
}