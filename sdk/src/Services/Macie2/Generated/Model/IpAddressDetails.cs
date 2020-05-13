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
    /// The IP address of the device that the entity used to perform the action on the affected
    /// resource. This object also provides information such as the owner and geographical
    /// location for the IP address.
    /// </summary>
    public partial class IpAddressDetails
    {
        private string _ipAddressV4;
        private IpCity _ipCity;
        private IpCountry _ipCountry;
        private IpGeoLocation _ipGeoLocation;
        private IpOwner _ipOwner;

        /// <summary>
        /// Gets and sets the property IpAddressV4. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public string IpAddressV4
        {
            get { return this._ipAddressV4; }
            set { this._ipAddressV4 = value; }
        }

        // Check to see if IpAddressV4 property is set
        internal bool IsSetIpAddressV4()
        {
            return this._ipAddressV4 != null;
        }

        /// <summary>
        /// Gets and sets the property IpCity. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public IpCity IpCity
        {
            get { return this._ipCity; }
            set { this._ipCity = value; }
        }

        // Check to see if IpCity property is set
        internal bool IsSetIpCity()
        {
            return this._ipCity != null;
        }

        /// <summary>
        /// Gets and sets the property IpCountry. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public IpCountry IpCountry
        {
            get { return this._ipCountry; }
            set { this._ipCountry = value; }
        }

        // Check to see if IpCountry property is set
        internal bool IsSetIpCountry()
        {
            return this._ipCountry != null;
        }

        /// <summary>
        /// Gets and sets the property IpGeoLocation. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public IpGeoLocation IpGeoLocation
        {
            get { return this._ipGeoLocation; }
            set { this._ipGeoLocation = value; }
        }

        // Check to see if IpGeoLocation property is set
        internal bool IsSetIpGeoLocation()
        {
            return this._ipGeoLocation != null;
        }

        /// <summary>
        /// Gets and sets the property IpOwner. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public IpOwner IpOwner
        {
            get { return this._ipOwner; }
            set { this._ipOwner = value; }
        }

        // Check to see if IpOwner property is set
        internal bool IsSetIpOwner()
        {
            return this._ipOwner != null;
        }

    }
}