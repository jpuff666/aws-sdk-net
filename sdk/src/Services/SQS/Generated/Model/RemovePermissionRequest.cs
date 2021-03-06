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
 * Do not modify this file. This file is generated from the sqs-2012-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SQS.Model
{
    /// <summary>
    /// Container for the parameters to the RemovePermission operation.
    /// Revokes any permissions in the queue policy that matches the specified <code>Label</code>
    /// parameter.
    /// 
    ///  <note> 
    /// <para>
    /// Only the owner of a queue can remove permissions from it.
    /// </para>
    ///  
    /// <para>
    /// Cross-account permissions don't apply to this action. For more information, see see
    /// <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-customer-managed-policy-examples.html#grant-cross-account-permissions-to-role-and-user-name">Grant
    /// Cross-Account Permissions to a Role and a User Name</a> in the <i>Amazon Simple Queue
    /// Service Developer Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class RemovePermissionRequest : AmazonSQSRequest
    {
        private string _label;
        private string _queueUrl;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public RemovePermissionRequest() { }

        /// <summary>
        /// Instantiates RemovePermissionRequest with the parameterized properties
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue from which permissions are removed. Queue URLs and names are case-sensitive.</param>
        /// <param name="label">The identification of the permission to remove. This is the label added using the <code> <a>AddPermission</a> </code> action.</param>
        public RemovePermissionRequest(string queueUrl, string label)
        {
            _queueUrl = queueUrl;
            _label = label;
        }

        /// <summary>
        /// Gets and sets the property Label. 
        /// <para>
        /// The identification of the permission to remove. This is the label added using the
        /// <code> <a>AddPermission</a> </code> action.
        /// </para>
        /// </summary>
        public string Label
        {
            get { return this._label; }
            set { this._label = value; }
        }

        // Check to see if Label property is set
        internal bool IsSetLabel()
        {
            return this._label != null;
        }

        /// <summary>
        /// Gets and sets the property QueueUrl. 
        /// <para>
        /// The URL of the Amazon SQS queue from which permissions are removed.
        /// </para>
        ///  
        /// <para>
        /// Queue URLs and names are case-sensitive.
        /// </para>
        /// </summary>
        public string QueueUrl
        {
            get { return this._queueUrl; }
            set { this._queueUrl = value; }
        }

        // Check to see if QueueUrl property is set
        internal bool IsSetQueueUrl()
        {
            return this._queueUrl != null;
        }

    }
}