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
 * Do not modify this file. This file is generated from the redshift-2012-12-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Redshift.Model;

namespace Amazon.Redshift
{
    /// <summary>
    /// Interface for accessing Redshift
    ///
    /// Amazon Redshift 
    /// <para>
    ///  <b>Overview</b> 
    /// </para>
    ///  
    /// <para>
    /// This is an interface reference for Amazon Redshift. It contains documentation for
    /// one of the programming or command line interfaces you can use to manage Amazon Redshift
    /// clusters. Note that Amazon Redshift is asynchronous, which means that some interfaces
    /// may require techniques, such as polling or asynchronous callback handlers, to determine
    /// when a command has been applied. In this reference, the parameter descriptions indicate
    /// whether a change is applied immediately, on the next instance reboot, or during the
    /// next maintenance window. For a summary of the Amazon Redshift cluster management interfaces,
    /// go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/using-aws-sdk.html">Using
    /// the Amazon Redshift Management Interfaces</a>.
    /// </para>
    ///  
    /// <para>
    /// Amazon Redshift manages all the work of setting up, operating, and scaling a data
    /// warehouse: provisioning capacity, monitoring and backing up the cluster, and applying
    /// patches and upgrades to the Amazon Redshift engine. You can focus on using your data
    /// to acquire new insights for your business and customers.
    /// </para>
    ///  
    /// <para>
    /// If you are a first-time user of Amazon Redshift, we recommend that you begin by reading
    /// the <a href="https://docs.aws.amazon.com/redshift/latest/gsg/getting-started.html">Amazon
    /// Redshift Getting Started Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// If you are a database developer, the <a href="https://docs.aws.amazon.com/redshift/latest/dg/welcome.html">Amazon
    /// Redshift Database Developer Guide</a> explains how to design, build, query, and maintain
    /// the databases that make up your data warehouse. 
    /// </para>
    /// </summary>
    public partial interface IAmazonRedshift : IAmazonService, IDisposable
    {

        
        #region  AcceptReservedNodeExchange


        /// <summary>
        /// Exchanges a DC1 Reserved Node for a DC2 Reserved Node with no changes to the configuration
        /// (term, payment type, or number of nodes) and no additional costs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptReservedNodeExchange service method.</param>
        /// 
        /// <returns>The response from the AcceptReservedNodeExchange service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceUnavailableException">
        /// Your request cannot be completed because a dependent internal service is temporarily
        /// unavailable. Wait 30 to 60 seconds and try again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidReservedNodeStateException">
        /// Indicates that the Reserved Node being exchanged is not in an active state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeAlreadyExistsException">
        /// User already has a reservation with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeAlreadyMigratedException">
        /// Indicates that the reserved node has already been exchanged.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeNotFoundException">
        /// The specified reserved compute node not found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/AcceptReservedNodeExchange">REST API Reference for AcceptReservedNodeExchange Operation</seealso>
        AcceptReservedNodeExchangeResponse AcceptReservedNodeExchange(AcceptReservedNodeExchangeRequest request);



        /// <summary>
        /// Exchanges a DC1 Reserved Node for a DC2 Reserved Node with no changes to the configuration
        /// (term, payment type, or number of nodes) and no additional costs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptReservedNodeExchange service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptReservedNodeExchange service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceUnavailableException">
        /// Your request cannot be completed because a dependent internal service is temporarily
        /// unavailable. Wait 30 to 60 seconds and try again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidReservedNodeStateException">
        /// Indicates that the Reserved Node being exchanged is not in an active state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeAlreadyExistsException">
        /// User already has a reservation with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeAlreadyMigratedException">
        /// Indicates that the reserved node has already been exchanged.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeNotFoundException">
        /// The specified reserved compute node not found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/AcceptReservedNodeExchange">REST API Reference for AcceptReservedNodeExchange Operation</seealso>
        Task<AcceptReservedNodeExchangeResponse> AcceptReservedNodeExchangeAsync(AcceptReservedNodeExchangeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AuthorizeClusterSecurityGroupIngress


        /// <summary>
        /// Adds an inbound (ingress) rule to an Amazon Redshift security group. Depending on
        /// whether the application accessing your cluster is running on the Internet or an Amazon
        /// EC2 instance, you can authorize inbound access to either a Classless Interdomain Routing
        /// (CIDR)/Internet Protocol (IP) range or to an Amazon EC2 security group. You can add
        /// as many as 20 ingress rules to an Amazon Redshift security group.
        /// 
        ///  
        /// <para>
        /// If you authorize access to an Amazon EC2 security group, specify <i>EC2SecurityGroupName</i>
        /// and <i>EC2SecurityGroupOwnerId</i>. The Amazon EC2 security group and Amazon Redshift
        /// cluster must be in the same AWS Region. 
        /// </para>
        ///  
        /// <para>
        /// If you authorize access to a CIDR/IP address range, specify <i>CIDRIP</i>. For an
        /// overview of CIDR blocks, see the Wikipedia article on <a href="http://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Classless
        /// Inter-Domain Routing</a>. 
        /// </para>
        ///  
        /// <para>
        /// You must also associate the security group with a cluster so that clients running
        /// on these IP addresses or the EC2 instance are authorized to connect to the cluster.
        /// For information about managing security groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Working
        /// with Security Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeClusterSecurityGroupIngress service method.</param>
        /// 
        /// <returns>The response from the AuthorizeClusterSecurityGroupIngress service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.AuthorizationAlreadyExistsException">
        /// The specified CIDR block or EC2 security group is already authorized for the specified
        /// cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.AuthorizationQuotaExceededException">
        /// The authorization quota for the cluster security group has been reached.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSecurityGroupStateException">
        /// The state of the cluster security group is not <code>available</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/AuthorizeClusterSecurityGroupIngress">REST API Reference for AuthorizeClusterSecurityGroupIngress Operation</seealso>
        AuthorizeClusterSecurityGroupIngressResponse AuthorizeClusterSecurityGroupIngress(AuthorizeClusterSecurityGroupIngressRequest request);



        /// <summary>
        /// Adds an inbound (ingress) rule to an Amazon Redshift security group. Depending on
        /// whether the application accessing your cluster is running on the Internet or an Amazon
        /// EC2 instance, you can authorize inbound access to either a Classless Interdomain Routing
        /// (CIDR)/Internet Protocol (IP) range or to an Amazon EC2 security group. You can add
        /// as many as 20 ingress rules to an Amazon Redshift security group.
        /// 
        ///  
        /// <para>
        /// If you authorize access to an Amazon EC2 security group, specify <i>EC2SecurityGroupName</i>
        /// and <i>EC2SecurityGroupOwnerId</i>. The Amazon EC2 security group and Amazon Redshift
        /// cluster must be in the same AWS Region. 
        /// </para>
        ///  
        /// <para>
        /// If you authorize access to a CIDR/IP address range, specify <i>CIDRIP</i>. For an
        /// overview of CIDR blocks, see the Wikipedia article on <a href="http://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Classless
        /// Inter-Domain Routing</a>. 
        /// </para>
        ///  
        /// <para>
        /// You must also associate the security group with a cluster so that clients running
        /// on these IP addresses or the EC2 instance are authorized to connect to the cluster.
        /// For information about managing security groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Working
        /// with Security Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeClusterSecurityGroupIngress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AuthorizeClusterSecurityGroupIngress service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.AuthorizationAlreadyExistsException">
        /// The specified CIDR block or EC2 security group is already authorized for the specified
        /// cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.AuthorizationQuotaExceededException">
        /// The authorization quota for the cluster security group has been reached.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSecurityGroupStateException">
        /// The state of the cluster security group is not <code>available</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/AuthorizeClusterSecurityGroupIngress">REST API Reference for AuthorizeClusterSecurityGroupIngress Operation</seealso>
        Task<AuthorizeClusterSecurityGroupIngressResponse> AuthorizeClusterSecurityGroupIngressAsync(AuthorizeClusterSecurityGroupIngressRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  AuthorizeSnapshotAccess


        /// <summary>
        /// Authorizes the specified AWS customer account to restore the specified snapshot.
        /// 
        ///  
        /// <para>
        ///  For more information about working with snapshots, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon
        /// Redshift Snapshots</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSnapshotAccess service method.</param>
        /// 
        /// <returns>The response from the AuthorizeSnapshotAccess service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.AuthorizationAlreadyExistsException">
        /// The specified CIDR block or EC2 security group is already authorized for the specified
        /// cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.AuthorizationQuotaExceededException">
        /// The authorization quota for the cluster security group has been reached.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceRequestThrottlingException">
        /// The request cannot be completed because a dependent service is throttling requests
        /// made by Amazon Redshift on your behalf. Wait and retry the request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSnapshotStateException">
        /// The specified cluster snapshot is not in the <code>available</code> state, or other
        /// accounts are authorized to access the snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.LimitExceededException">
        /// The encryption key has exceeded its grant limit in AWS KMS.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/AuthorizeSnapshotAccess">REST API Reference for AuthorizeSnapshotAccess Operation</seealso>
        AuthorizeSnapshotAccessResponse AuthorizeSnapshotAccess(AuthorizeSnapshotAccessRequest request);



        /// <summary>
        /// Authorizes the specified AWS customer account to restore the specified snapshot.
        /// 
        ///  
        /// <para>
        ///  For more information about working with snapshots, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon
        /// Redshift Snapshots</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSnapshotAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AuthorizeSnapshotAccess service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.AuthorizationAlreadyExistsException">
        /// The specified CIDR block or EC2 security group is already authorized for the specified
        /// cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.AuthorizationQuotaExceededException">
        /// The authorization quota for the cluster security group has been reached.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceRequestThrottlingException">
        /// The request cannot be completed because a dependent service is throttling requests
        /// made by Amazon Redshift on your behalf. Wait and retry the request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSnapshotStateException">
        /// The specified cluster snapshot is not in the <code>available</code> state, or other
        /// accounts are authorized to access the snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.LimitExceededException">
        /// The encryption key has exceeded its grant limit in AWS KMS.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/AuthorizeSnapshotAccess">REST API Reference for AuthorizeSnapshotAccess Operation</seealso>
        Task<AuthorizeSnapshotAccessResponse> AuthorizeSnapshotAccessAsync(AuthorizeSnapshotAccessRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchDeleteClusterSnapshots


        /// <summary>
        /// Deletes a set of cluster snapshots.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteClusterSnapshots service method.</param>
        /// 
        /// <returns>The response from the BatchDeleteClusterSnapshots service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.BatchDeleteRequestSizeExceededException">
        /// The maximum number for a batch delete of snapshots has been reached. The limit is
        /// 100.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/BatchDeleteClusterSnapshots">REST API Reference for BatchDeleteClusterSnapshots Operation</seealso>
        BatchDeleteClusterSnapshotsResponse BatchDeleteClusterSnapshots(BatchDeleteClusterSnapshotsRequest request);



        /// <summary>
        /// Deletes a set of cluster snapshots.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchDeleteClusterSnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchDeleteClusterSnapshots service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.BatchDeleteRequestSizeExceededException">
        /// The maximum number for a batch delete of snapshots has been reached. The limit is
        /// 100.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/BatchDeleteClusterSnapshots">REST API Reference for BatchDeleteClusterSnapshots Operation</seealso>
        Task<BatchDeleteClusterSnapshotsResponse> BatchDeleteClusterSnapshotsAsync(BatchDeleteClusterSnapshotsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  BatchModifyClusterSnapshots


        /// <summary>
        /// Modifies the settings for a set of cluster snapshots.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchModifyClusterSnapshots service method.</param>
        /// 
        /// <returns>The response from the BatchModifyClusterSnapshots service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.BatchModifyClusterSnapshotsLimitExceededException">
        /// The maximum number for snapshot identifiers has been reached. The limit is 100.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidRetentionPeriodException">
        /// The retention period specified is either in the past or is not a valid value.
        /// 
        ///  
        /// <para>
        /// The value must be either -1 or an integer between 1 and 3,653.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/BatchModifyClusterSnapshots">REST API Reference for BatchModifyClusterSnapshots Operation</seealso>
        BatchModifyClusterSnapshotsResponse BatchModifyClusterSnapshots(BatchModifyClusterSnapshotsRequest request);



        /// <summary>
        /// Modifies the settings for a set of cluster snapshots.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BatchModifyClusterSnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the BatchModifyClusterSnapshots service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.BatchModifyClusterSnapshotsLimitExceededException">
        /// The maximum number for snapshot identifiers has been reached. The limit is 100.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidRetentionPeriodException">
        /// The retention period specified is either in the past or is not a valid value.
        /// 
        ///  
        /// <para>
        /// The value must be either -1 or an integer between 1 and 3,653.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/BatchModifyClusterSnapshots">REST API Reference for BatchModifyClusterSnapshots Operation</seealso>
        Task<BatchModifyClusterSnapshotsResponse> BatchModifyClusterSnapshotsAsync(BatchModifyClusterSnapshotsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CancelResize


        /// <summary>
        /// Cancels a resize operation for a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelResize service method.</param>
        /// 
        /// <returns>The response from the CancelResize service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ResizeNotFoundException">
        /// A resize operation for the specified cluster is not found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CancelResize">REST API Reference for CancelResize Operation</seealso>
        CancelResizeResponse CancelResize(CancelResizeRequest request);



        /// <summary>
        /// Cancels a resize operation for a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelResize service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelResize service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ResizeNotFoundException">
        /// A resize operation for the specified cluster is not found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CancelResize">REST API Reference for CancelResize Operation</seealso>
        Task<CancelResizeResponse> CancelResizeAsync(CancelResizeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CopyClusterSnapshot


        /// <summary>
        /// Copies the specified automated cluster snapshot to a new manual cluster snapshot.
        /// The source must be an automated snapshot and it must be in the available state.
        /// 
        ///  
        /// <para>
        /// When you delete a cluster, Amazon Redshift deletes any automated snapshots of the
        /// cluster. Also, when the retention period of the snapshot expires, Amazon Redshift
        /// automatically deletes it. If you want to keep an automated snapshot for a longer period,
        /// you can make a manual copy of the snapshot. Manual snapshots are retained until you
        /// delete them.
        /// </para>
        ///  
        /// <para>
        ///  For more information about working with snapshots, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon
        /// Redshift Snapshots</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the CopyClusterSnapshot service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotAlreadyExistsException">
        /// The value specified as a snapshot identifier is already used by an existing snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of cluster snapshots.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSnapshotStateException">
        /// The specified cluster snapshot is not in the <code>available</code> state, or other
        /// accounts are authorized to access the snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidRetentionPeriodException">
        /// The retention period specified is either in the past or is not a valid value.
        /// 
        ///  
        /// <para>
        /// The value must be either -1 or an integer between 1 and 3,653.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CopyClusterSnapshot">REST API Reference for CopyClusterSnapshot Operation</seealso>
        CopyClusterSnapshotResponse CopyClusterSnapshot(CopyClusterSnapshotRequest request);



        /// <summary>
        /// Copies the specified automated cluster snapshot to a new manual cluster snapshot.
        /// The source must be an automated snapshot and it must be in the available state.
        /// 
        ///  
        /// <para>
        /// When you delete a cluster, Amazon Redshift deletes any automated snapshots of the
        /// cluster. Also, when the retention period of the snapshot expires, Amazon Redshift
        /// automatically deletes it. If you want to keep an automated snapshot for a longer period,
        /// you can make a manual copy of the snapshot. Manual snapshots are retained until you
        /// delete them.
        /// </para>
        ///  
        /// <para>
        ///  For more information about working with snapshots, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon
        /// Redshift Snapshots</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyClusterSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopyClusterSnapshot service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotAlreadyExistsException">
        /// The value specified as a snapshot identifier is already used by an existing snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of cluster snapshots.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSnapshotStateException">
        /// The specified cluster snapshot is not in the <code>available</code> state, or other
        /// accounts are authorized to access the snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidRetentionPeriodException">
        /// The retention period specified is either in the past or is not a valid value.
        /// 
        ///  
        /// <para>
        /// The value must be either -1 or an integer between 1 and 3,653.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CopyClusterSnapshot">REST API Reference for CopyClusterSnapshot Operation</seealso>
        Task<CopyClusterSnapshotResponse> CopyClusterSnapshotAsync(CopyClusterSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateCluster


        /// <summary>
        /// Creates a new cluster with the specified parameters.
        /// 
        ///  
        /// <para>
        /// To create a cluster in Virtual Private Cloud (VPC), you must provide a cluster subnet
        /// group name. The cluster subnet group identifies the subnets of your VPC that Amazon
        /// Redshift uses when creating the cluster. For more information about managing clusters,
        /// go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
        /// 
        /// <returns>The response from the CreateCluster service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterAlreadyExistsException">
        /// The account already has a cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterQuotaExceededException">
        /// The request would exceed the allowed number of cluster instances for this account.
        /// For information about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceRequestThrottlingException">
        /// The request cannot be completed because a dependent service is throttling requests
        /// made by Amazon Redshift on your behalf. Wait and retry the request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.HsmClientCertificateNotFoundException">
        /// There is no Amazon Redshift HSM client certificate with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.HsmConfigurationNotFoundException">
        /// There is no Amazon Redshift HSM configuration with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InsufficientClusterCapacityException">
        /// The number of nodes specified exceeds the allotted capacity of the cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSubnetGroupStateException">
        /// The cluster subnet group cannot be deleted because it is in use.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterTrackException">
        /// The provided cluster track name is not valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidElasticIpException">
        /// The Elastic IP (EIP) is invalid or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidRetentionPeriodException">
        /// The retention period specified is either in the past or is not a valid value.
        /// 
        ///  
        /// <para>
        /// The value must be either -1 or an integer between 1 and 3,653.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidSubnetException">
        /// The requested subnet is not valid, or not all of the subnets are in the same VPC.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidVPCNetworkStateException">
        /// The cluster subnet group does not cover all Availability Zones.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.LimitExceededException">
        /// The encryption key has exceeded its grant limit in AWS KMS.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.NumberOfNodesPerClusterLimitExceededException">
        /// The operation would exceed the number of nodes allowed for a cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.NumberOfNodesQuotaExceededException">
        /// The operation would exceed the number of nodes allotted to the account. For information
        /// about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotScheduleNotFoundException">
        /// We could not find the specified snapshot schedule.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        CreateClusterResponse CreateCluster(CreateClusterRequest request);



        /// <summary>
        /// Creates a new cluster with the specified parameters.
        /// 
        ///  
        /// <para>
        /// To create a cluster in Virtual Private Cloud (VPC), you must provide a cluster subnet
        /// group name. The cluster subnet group identifies the subnets of your VPC that Amazon
        /// Redshift uses when creating the cluster. For more information about managing clusters,
        /// go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCluster service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterAlreadyExistsException">
        /// The account already has a cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterQuotaExceededException">
        /// The request would exceed the allowed number of cluster instances for this account.
        /// For information about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceRequestThrottlingException">
        /// The request cannot be completed because a dependent service is throttling requests
        /// made by Amazon Redshift on your behalf. Wait and retry the request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.HsmClientCertificateNotFoundException">
        /// There is no Amazon Redshift HSM client certificate with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.HsmConfigurationNotFoundException">
        /// There is no Amazon Redshift HSM configuration with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InsufficientClusterCapacityException">
        /// The number of nodes specified exceeds the allotted capacity of the cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSubnetGroupStateException">
        /// The cluster subnet group cannot be deleted because it is in use.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterTrackException">
        /// The provided cluster track name is not valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidElasticIpException">
        /// The Elastic IP (EIP) is invalid or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidRetentionPeriodException">
        /// The retention period specified is either in the past or is not a valid value.
        /// 
        ///  
        /// <para>
        /// The value must be either -1 or an integer between 1 and 3,653.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidSubnetException">
        /// The requested subnet is not valid, or not all of the subnets are in the same VPC.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidVPCNetworkStateException">
        /// The cluster subnet group does not cover all Availability Zones.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.LimitExceededException">
        /// The encryption key has exceeded its grant limit in AWS KMS.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.NumberOfNodesPerClusterLimitExceededException">
        /// The operation would exceed the number of nodes allowed for a cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.NumberOfNodesQuotaExceededException">
        /// The operation would exceed the number of nodes allotted to the account. For information
        /// about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotScheduleNotFoundException">
        /// We could not find the specified snapshot schedule.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateClusterParameterGroup


        /// <summary>
        /// Creates an Amazon Redshift parameter group.
        /// 
        ///  
        /// <para>
        /// Creating parameter groups is independent of creating clusters. You can associate a
        /// cluster with a parameter group when you create the cluster. You can also associate
        /// an existing cluster with a parameter group after the cluster is created by using <a>ModifyCluster</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Parameters in the parameter group define specific behavior that applies to the databases
        /// you create on the cluster. For more information about parameters and parameter groups,
        /// go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the CreateClusterParameterGroup service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupAlreadyExistsException">
        /// A cluster parameter group with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of cluster parameter
        /// groups. For information about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateClusterParameterGroup">REST API Reference for CreateClusterParameterGroup Operation</seealso>
        CreateClusterParameterGroupResponse CreateClusterParameterGroup(CreateClusterParameterGroupRequest request);



        /// <summary>
        /// Creates an Amazon Redshift parameter group.
        /// 
        ///  
        /// <para>
        /// Creating parameter groups is independent of creating clusters. You can associate a
        /// cluster with a parameter group when you create the cluster. You can also associate
        /// an existing cluster with a parameter group after the cluster is created by using <a>ModifyCluster</a>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Parameters in the parameter group define specific behavior that applies to the databases
        /// you create on the cluster. For more information about parameters and parameter groups,
        /// go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateClusterParameterGroup service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupAlreadyExistsException">
        /// A cluster parameter group with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of cluster parameter
        /// groups. For information about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateClusterParameterGroup">REST API Reference for CreateClusterParameterGroup Operation</seealso>
        Task<CreateClusterParameterGroupResponse> CreateClusterParameterGroupAsync(CreateClusterParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateClusterSecurityGroup


        /// <summary>
        /// Creates a new Amazon Redshift security group. You use security groups to control access
        /// to non-VPC clusters.
        /// 
        ///  
        /// <para>
        ///  For information about managing security groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon
        /// Redshift Cluster Security Groups</a> in the <i>Amazon Redshift Cluster Management
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the CreateClusterSecurityGroup service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupAlreadyExistsException">
        /// A cluster security group with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of cluster security
        /// groups. For information about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateClusterSecurityGroup">REST API Reference for CreateClusterSecurityGroup Operation</seealso>
        CreateClusterSecurityGroupResponse CreateClusterSecurityGroup(CreateClusterSecurityGroupRequest request);



        /// <summary>
        /// Creates a new Amazon Redshift security group. You use security groups to control access
        /// to non-VPC clusters.
        /// 
        ///  
        /// <para>
        ///  For information about managing security groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon
        /// Redshift Cluster Security Groups</a> in the <i>Amazon Redshift Cluster Management
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSecurityGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateClusterSecurityGroup service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupAlreadyExistsException">
        /// A cluster security group with the same name already exists.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of cluster security
        /// groups. For information about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateClusterSecurityGroup">REST API Reference for CreateClusterSecurityGroup Operation</seealso>
        Task<CreateClusterSecurityGroupResponse> CreateClusterSecurityGroupAsync(CreateClusterSecurityGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateClusterSnapshot


        /// <summary>
        /// Creates a manual snapshot of the specified cluster. The cluster must be in the <code>available</code>
        /// state. 
        /// 
        ///  
        /// <para>
        ///  For more information about working with snapshots, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon
        /// Redshift Snapshots</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateClusterSnapshot service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotAlreadyExistsException">
        /// The value specified as a snapshot identifier is already used by an existing snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of cluster snapshots.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidRetentionPeriodException">
        /// The retention period specified is either in the past or is not a valid value.
        /// 
        ///  
        /// <para>
        /// The value must be either -1 or an integer between 1 and 3,653.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateClusterSnapshot">REST API Reference for CreateClusterSnapshot Operation</seealso>
        CreateClusterSnapshotResponse CreateClusterSnapshot(CreateClusterSnapshotRequest request);



        /// <summary>
        /// Creates a manual snapshot of the specified cluster. The cluster must be in the <code>available</code>
        /// state. 
        /// 
        ///  
        /// <para>
        ///  For more information about working with snapshots, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon
        /// Redshift Snapshots</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateClusterSnapshot service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotAlreadyExistsException">
        /// The value specified as a snapshot identifier is already used by an existing snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of cluster snapshots.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidRetentionPeriodException">
        /// The retention period specified is either in the past or is not a valid value.
        /// 
        ///  
        /// <para>
        /// The value must be either -1 or an integer between 1 and 3,653.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateClusterSnapshot">REST API Reference for CreateClusterSnapshot Operation</seealso>
        Task<CreateClusterSnapshotResponse> CreateClusterSnapshotAsync(CreateClusterSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateClusterSubnetGroup


        /// <summary>
        /// Creates a new Amazon Redshift subnet group. You must provide a list of one or more
        /// subnets in your existing Amazon Virtual Private Cloud (Amazon VPC) when creating Amazon
        /// Redshift subnet group.
        /// 
        ///  
        /// <para>
        ///  For information about subnet groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-cluster-subnet-groups.html">Amazon
        /// Redshift Cluster Subnet Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the CreateClusterSubnetGroup service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetGroupAlreadyExistsException">
        /// A <i>ClusterSubnetGroupName</i> is already used by an existing cluster subnet group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetGroupQuotaExceededException">
        /// The request would result in user exceeding the allowed number of cluster subnet groups.
        /// For information about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetQuotaExceededException">
        /// The request would result in user exceeding the allowed number of subnets in a cluster
        /// subnet groups. For information about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceRequestThrottlingException">
        /// The request cannot be completed because a dependent service is throttling requests
        /// made by Amazon Redshift on your behalf. Wait and retry the request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidSubnetException">
        /// The requested subnet is not valid, or not all of the subnets are in the same VPC.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateClusterSubnetGroup">REST API Reference for CreateClusterSubnetGroup Operation</seealso>
        CreateClusterSubnetGroupResponse CreateClusterSubnetGroup(CreateClusterSubnetGroupRequest request);



        /// <summary>
        /// Creates a new Amazon Redshift subnet group. You must provide a list of one or more
        /// subnets in your existing Amazon Virtual Private Cloud (Amazon VPC) when creating Amazon
        /// Redshift subnet group.
        /// 
        ///  
        /// <para>
        ///  For information about subnet groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-cluster-subnet-groups.html">Amazon
        /// Redshift Cluster Subnet Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateClusterSubnetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateClusterSubnetGroup service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetGroupAlreadyExistsException">
        /// A <i>ClusterSubnetGroupName</i> is already used by an existing cluster subnet group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetGroupQuotaExceededException">
        /// The request would result in user exceeding the allowed number of cluster subnet groups.
        /// For information about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetQuotaExceededException">
        /// The request would result in user exceeding the allowed number of subnets in a cluster
        /// subnet groups. For information about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceRequestThrottlingException">
        /// The request cannot be completed because a dependent service is throttling requests
        /// made by Amazon Redshift on your behalf. Wait and retry the request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidSubnetException">
        /// The requested subnet is not valid, or not all of the subnets are in the same VPC.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateClusterSubnetGroup">REST API Reference for CreateClusterSubnetGroup Operation</seealso>
        Task<CreateClusterSubnetGroupResponse> CreateClusterSubnetGroupAsync(CreateClusterSubnetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateEventSubscription


        /// <summary>
        /// Creates an Amazon Redshift event notification subscription. This action requires an
        /// ARN (Amazon Resource Name) of an Amazon SNS topic created by either the Amazon Redshift
        /// console, the Amazon SNS console, or the Amazon SNS API. To obtain an ARN with Amazon
        /// SNS, you must create a topic in Amazon SNS and subscribe to the topic. The ARN is
        /// displayed in the SNS console.
        /// 
        ///  
        /// <para>
        /// You can specify the source type, and lists of Amazon Redshift source IDs, event categories,
        /// and event severities. Notifications will be sent for all events you want that match
        /// those criteria. For example, you can specify source type = cluster, source ID = my-cluster-1
        /// and mycluster2, event categories = Availability, Backup, and severity = ERROR. The
        /// subscription will only send notifications for those ERROR events in the Availability
        /// and Backup categories for the specified clusters.
        /// </para>
        ///  
        /// <para>
        /// If you specify both the source type and source IDs, such as source type = cluster
        /// and source identifier = my-cluster-1, notifications will be sent for all the cluster
        /// events for my-cluster-1. If you specify a source type but do not specify a source
        /// identifier, you will receive notice of the events for the objects of that type in
        /// your AWS account. If you do not specify either the SourceType nor the SourceIdentifier,
        /// you will be notified of events generated from all Amazon Redshift sources belonging
        /// to your AWS account. You must specify a source type if you specify a source ID.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSubscription service method.</param>
        /// 
        /// <returns>The response from the CreateEventSubscription service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.EventSubscriptionQuotaExceededException">
        /// The request would exceed the allowed number of event subscriptions for this account.
        /// For information about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SNSInvalidTopicException">
        /// Amazon SNS has responded that there is a problem with the specified Amazon SNS topic.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SNSNoAuthorizationException">
        /// You do not have permission to publish to the specified Amazon SNS topic.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SNSTopicArnNotFoundException">
        /// An Amazon SNS topic with the specified Amazon Resource Name (ARN) does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SourceNotFoundException">
        /// The specified Amazon Redshift event source could not be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionAlreadyExistException">
        /// There is already an existing event notification subscription with the specified name.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionCategoryNotFoundException">
        /// The value specified for the event category was not one of the allowed values, or it
        /// specified a category that does not apply to the specified source type. The allowed
        /// values are Configuration, Management, Monitoring, and Security.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionEventIdNotFoundException">
        /// An Amazon Redshift event with the specified event ID does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionSeverityNotFoundException">
        /// The value specified for the event severity was not one of the allowed values, or it
        /// specified a severity that does not apply to the specified source type. The allowed
        /// values are ERROR and INFO.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateEventSubscription">REST API Reference for CreateEventSubscription Operation</seealso>
        CreateEventSubscriptionResponse CreateEventSubscription(CreateEventSubscriptionRequest request);



        /// <summary>
        /// Creates an Amazon Redshift event notification subscription. This action requires an
        /// ARN (Amazon Resource Name) of an Amazon SNS topic created by either the Amazon Redshift
        /// console, the Amazon SNS console, or the Amazon SNS API. To obtain an ARN with Amazon
        /// SNS, you must create a topic in Amazon SNS and subscribe to the topic. The ARN is
        /// displayed in the SNS console.
        /// 
        ///  
        /// <para>
        /// You can specify the source type, and lists of Amazon Redshift source IDs, event categories,
        /// and event severities. Notifications will be sent for all events you want that match
        /// those criteria. For example, you can specify source type = cluster, source ID = my-cluster-1
        /// and mycluster2, event categories = Availability, Backup, and severity = ERROR. The
        /// subscription will only send notifications for those ERROR events in the Availability
        /// and Backup categories for the specified clusters.
        /// </para>
        ///  
        /// <para>
        /// If you specify both the source type and source IDs, such as source type = cluster
        /// and source identifier = my-cluster-1, notifications will be sent for all the cluster
        /// events for my-cluster-1. If you specify a source type but do not specify a source
        /// identifier, you will receive notice of the events for the objects of that type in
        /// your AWS account. If you do not specify either the SourceType nor the SourceIdentifier,
        /// you will be notified of events generated from all Amazon Redshift sources belonging
        /// to your AWS account. You must specify a source type if you specify a source ID.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEventSubscription service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.EventSubscriptionQuotaExceededException">
        /// The request would exceed the allowed number of event subscriptions for this account.
        /// For information about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SNSInvalidTopicException">
        /// Amazon SNS has responded that there is a problem with the specified Amazon SNS topic.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SNSNoAuthorizationException">
        /// You do not have permission to publish to the specified Amazon SNS topic.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SNSTopicArnNotFoundException">
        /// An Amazon SNS topic with the specified Amazon Resource Name (ARN) does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SourceNotFoundException">
        /// The specified Amazon Redshift event source could not be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionAlreadyExistException">
        /// There is already an existing event notification subscription with the specified name.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionCategoryNotFoundException">
        /// The value specified for the event category was not one of the allowed values, or it
        /// specified a category that does not apply to the specified source type. The allowed
        /// values are Configuration, Management, Monitoring, and Security.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionEventIdNotFoundException">
        /// An Amazon Redshift event with the specified event ID does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionSeverityNotFoundException">
        /// The value specified for the event severity was not one of the allowed values, or it
        /// specified a severity that does not apply to the specified source type. The allowed
        /// values are ERROR and INFO.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateEventSubscription">REST API Reference for CreateEventSubscription Operation</seealso>
        Task<CreateEventSubscriptionResponse> CreateEventSubscriptionAsync(CreateEventSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateHsmClientCertificate


        /// <summary>
        /// Creates an HSM client certificate that an Amazon Redshift cluster will use to connect
        /// to the client's HSM in order to store and retrieve the keys used to encrypt the cluster
        /// databases.
        /// 
        ///  
        /// <para>
        /// The command returns a public key, which you must store in the HSM. In addition to
        /// creating the HSM certificate, you must create an Amazon Redshift HSM configuration
        /// that provides a cluster the information needed to store and use encryption keys in
        /// the HSM. For more information, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-HSM.html">Hardware
        /// Security Modules</a> in the Amazon Redshift Cluster Management Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHsmClientCertificate service method.</param>
        /// 
        /// <returns>The response from the CreateHsmClientCertificate service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmClientCertificateAlreadyExistsException">
        /// There is already an existing Amazon Redshift HSM client certificate with the specified
        /// identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.HsmClientCertificateQuotaExceededException">
        /// The quota for HSM client certificates has been reached. For information about increasing
        /// your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateHsmClientCertificate">REST API Reference for CreateHsmClientCertificate Operation</seealso>
        CreateHsmClientCertificateResponse CreateHsmClientCertificate(CreateHsmClientCertificateRequest request);



        /// <summary>
        /// Creates an HSM client certificate that an Amazon Redshift cluster will use to connect
        /// to the client's HSM in order to store and retrieve the keys used to encrypt the cluster
        /// databases.
        /// 
        ///  
        /// <para>
        /// The command returns a public key, which you must store in the HSM. In addition to
        /// creating the HSM certificate, you must create an Amazon Redshift HSM configuration
        /// that provides a cluster the information needed to store and use encryption keys in
        /// the HSM. For more information, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-HSM.html">Hardware
        /// Security Modules</a> in the Amazon Redshift Cluster Management Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHsmClientCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateHsmClientCertificate service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmClientCertificateAlreadyExistsException">
        /// There is already an existing Amazon Redshift HSM client certificate with the specified
        /// identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.HsmClientCertificateQuotaExceededException">
        /// The quota for HSM client certificates has been reached. For information about increasing
        /// your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateHsmClientCertificate">REST API Reference for CreateHsmClientCertificate Operation</seealso>
        Task<CreateHsmClientCertificateResponse> CreateHsmClientCertificateAsync(CreateHsmClientCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateHsmConfiguration


        /// <summary>
        /// Creates an HSM configuration that contains the information required by an Amazon Redshift
        /// cluster to store and use database encryption keys in a Hardware Security Module (HSM).
        /// After creating the HSM configuration, you can specify it as a parameter when creating
        /// a cluster. The cluster will then store its encryption keys in the HSM.
        /// 
        ///  
        /// <para>
        /// In addition to creating an HSM configuration, you must also create an HSM client certificate.
        /// For more information, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-HSM.html">Hardware
        /// Security Modules</a> in the Amazon Redshift Cluster Management Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHsmConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateHsmConfiguration service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmConfigurationAlreadyExistsException">
        /// There is already an existing Amazon Redshift HSM configuration with the specified
        /// identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.HsmConfigurationQuotaExceededException">
        /// The quota for HSM configurations has been reached. For information about increasing
        /// your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateHsmConfiguration">REST API Reference for CreateHsmConfiguration Operation</seealso>
        CreateHsmConfigurationResponse CreateHsmConfiguration(CreateHsmConfigurationRequest request);



        /// <summary>
        /// Creates an HSM configuration that contains the information required by an Amazon Redshift
        /// cluster to store and use database encryption keys in a Hardware Security Module (HSM).
        /// After creating the HSM configuration, you can specify it as a parameter when creating
        /// a cluster. The cluster will then store its encryption keys in the HSM.
        /// 
        ///  
        /// <para>
        /// In addition to creating an HSM configuration, you must also create an HSM client certificate.
        /// For more information, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-HSM.html">Hardware
        /// Security Modules</a> in the Amazon Redshift Cluster Management Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateHsmConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateHsmConfiguration service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmConfigurationAlreadyExistsException">
        /// There is already an existing Amazon Redshift HSM configuration with the specified
        /// identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.HsmConfigurationQuotaExceededException">
        /// The quota for HSM configurations has been reached. For information about increasing
        /// your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateHsmConfiguration">REST API Reference for CreateHsmConfiguration Operation</seealso>
        Task<CreateHsmConfigurationResponse> CreateHsmConfigurationAsync(CreateHsmConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateScheduledAction


        /// <summary>
        /// Creates a scheduled action. A scheduled action contains a schedule and an Amazon Redshift
        /// API action. For example, you can create a schedule of when to run the <code>ResizeCluster</code>
        /// API operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScheduledAction service method.</param>
        /// 
        /// <returns>The response from the CreateScheduledAction service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidScheduledActionException">
        /// The scheduled action is not valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidScheduleException">
        /// The schedule you submitted isn't valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ScheduledActionAlreadyExistsException">
        /// The scheduled action already exists.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ScheduledActionQuotaExceededException">
        /// The quota for scheduled actions exceeded.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ScheduledActionTypeUnsupportedException">
        /// The action type specified for a scheduled action is not supported.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateScheduledAction">REST API Reference for CreateScheduledAction Operation</seealso>
        CreateScheduledActionResponse CreateScheduledAction(CreateScheduledActionRequest request);



        /// <summary>
        /// Creates a scheduled action. A scheduled action contains a schedule and an Amazon Redshift
        /// API action. For example, you can create a schedule of when to run the <code>ResizeCluster</code>
        /// API operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScheduledAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateScheduledAction service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidScheduledActionException">
        /// The scheduled action is not valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidScheduleException">
        /// The schedule you submitted isn't valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ScheduledActionAlreadyExistsException">
        /// The scheduled action already exists.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ScheduledActionQuotaExceededException">
        /// The quota for scheduled actions exceeded.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ScheduledActionTypeUnsupportedException">
        /// The action type specified for a scheduled action is not supported.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateScheduledAction">REST API Reference for CreateScheduledAction Operation</seealso>
        Task<CreateScheduledActionResponse> CreateScheduledActionAsync(CreateScheduledActionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateSnapshotCopyGrant


        /// <summary>
        /// Creates a snapshot copy grant that permits Amazon Redshift to use a customer master
        /// key (CMK) from AWS Key Management Service (AWS KMS) to encrypt copied snapshots in
        /// a destination region.
        /// 
        ///  
        /// <para>
        ///  For more information about managing snapshot copy grants, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-db-encryption.html">Amazon
        /// Redshift Database Encryption</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshotCopyGrant service method.</param>
        /// 
        /// <returns>The response from the CreateSnapshotCopyGrant service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceRequestThrottlingException">
        /// The request cannot be completed because a dependent service is throttling requests
        /// made by Amazon Redshift on your behalf. Wait and retry the request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.LimitExceededException">
        /// The encryption key has exceeded its grant limit in AWS KMS.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotCopyGrantAlreadyExistsException">
        /// The snapshot copy grant can't be created because a grant with the same name already
        /// exists.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotCopyGrantQuotaExceededException">
        /// The AWS account has exceeded the maximum number of snapshot copy grants in this region.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateSnapshotCopyGrant">REST API Reference for CreateSnapshotCopyGrant Operation</seealso>
        CreateSnapshotCopyGrantResponse CreateSnapshotCopyGrant(CreateSnapshotCopyGrantRequest request);



        /// <summary>
        /// Creates a snapshot copy grant that permits Amazon Redshift to use a customer master
        /// key (CMK) from AWS Key Management Service (AWS KMS) to encrypt copied snapshots in
        /// a destination region.
        /// 
        ///  
        /// <para>
        ///  For more information about managing snapshot copy grants, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-db-encryption.html">Amazon
        /// Redshift Database Encryption</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshotCopyGrant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSnapshotCopyGrant service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceRequestThrottlingException">
        /// The request cannot be completed because a dependent service is throttling requests
        /// made by Amazon Redshift on your behalf. Wait and retry the request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.LimitExceededException">
        /// The encryption key has exceeded its grant limit in AWS KMS.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotCopyGrantAlreadyExistsException">
        /// The snapshot copy grant can't be created because a grant with the same name already
        /// exists.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotCopyGrantQuotaExceededException">
        /// The AWS account has exceeded the maximum number of snapshot copy grants in this region.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateSnapshotCopyGrant">REST API Reference for CreateSnapshotCopyGrant Operation</seealso>
        Task<CreateSnapshotCopyGrantResponse> CreateSnapshotCopyGrantAsync(CreateSnapshotCopyGrantRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateSnapshotSchedule


        /// <summary>
        /// Creates a snapshot schedule with the rate of every 12 hours.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshotSchedule service method.</param>
        /// 
        /// <returns>The response from the CreateSnapshotSchedule service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidScheduleException">
        /// The schedule you submitted isn't valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ScheduleDefinitionTypeUnsupportedException">
        /// The definition you submitted is not supported.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotScheduleAlreadyExistsException">
        /// The specified snapshot schedule already exists.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotScheduleQuotaExceededException">
        /// You have exceeded the quota of snapshot schedules.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateSnapshotSchedule">REST API Reference for CreateSnapshotSchedule Operation</seealso>
        CreateSnapshotScheduleResponse CreateSnapshotSchedule(CreateSnapshotScheduleRequest request);



        /// <summary>
        /// Creates a snapshot schedule with the rate of every 12 hours.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshotSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSnapshotSchedule service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidScheduleException">
        /// The schedule you submitted isn't valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ScheduleDefinitionTypeUnsupportedException">
        /// The definition you submitted is not supported.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotScheduleAlreadyExistsException">
        /// The specified snapshot schedule already exists.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotScheduleQuotaExceededException">
        /// You have exceeded the quota of snapshot schedules.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateSnapshotSchedule">REST API Reference for CreateSnapshotSchedule Operation</seealso>
        Task<CreateSnapshotScheduleResponse> CreateSnapshotScheduleAsync(CreateSnapshotScheduleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateTags


        /// <summary>
        /// Adds tags to a cluster.
        /// 
        ///  
        /// <para>
        /// A resource can have up to 50 tags. If you try to create more than 50 tags for a resource,
        /// you will receive an error and the attempt will fail.
        /// </para>
        ///  
        /// <para>
        /// If you specify a key that already exists for the resource, the value for that key
        /// will be updated with the new value.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTags service method.</param>
        /// 
        /// <returns>The response from the CreateTags service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateTags">REST API Reference for CreateTags Operation</seealso>
        CreateTagsResponse CreateTags(CreateTagsRequest request);



        /// <summary>
        /// Adds tags to a cluster.
        /// 
        ///  
        /// <para>
        /// A resource can have up to 50 tags. If you try to create more than 50 tags for a resource,
        /// you will receive an error and the attempt will fail.
        /// </para>
        ///  
        /// <para>
        /// If you specify a key that already exists for the resource, the value for that key
        /// will be updated with the new value.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTags service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/CreateTags">REST API Reference for CreateTags Operation</seealso>
        Task<CreateTagsResponse> CreateTagsAsync(CreateTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteCluster


        /// <summary>
        /// Deletes a previously provisioned cluster without its final snapshot being created.
        /// A successful response from the web service indicates that the request was received
        /// correctly. Use <a>DescribeClusters</a> to monitor the status of the deletion. The
        /// delete operation cannot be canceled or reverted once submitted. For more information
        /// about managing clusters, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// 
        ///  
        /// <para>
        /// If you want to shut down the cluster and retain it for future use, set <i>SkipFinalClusterSnapshot</i>
        /// to <code>false</code> and specify a name for <i>FinalClusterSnapshotIdentifier</i>.
        /// You can later restore this snapshot to resume using the cluster. If a final cluster
        /// snapshot is requested, the status of the cluster will be "final-snapshot" while the
        /// snapshot is being taken, then it's "deleting" once Amazon Redshift begins deleting
        /// the cluster. 
        /// </para>
        ///  
        /// <para>
        ///  For more information about managing clusters, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster service method.</param>
        /// 
        /// <returns>The response from the DeleteCluster service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotAlreadyExistsException">
        /// The value specified as a snapshot identifier is already used by an existing snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of cluster snapshots.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidRetentionPeriodException">
        /// The retention period specified is either in the past or is not a valid value.
        /// 
        ///  
        /// <para>
        /// The value must be either -1 or an integer between 1 and 3,653.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        DeleteClusterResponse DeleteCluster(DeleteClusterRequest request);



        /// <summary>
        /// Deletes a previously provisioned cluster without its final snapshot being created.
        /// A successful response from the web service indicates that the request was received
        /// correctly. Use <a>DescribeClusters</a> to monitor the status of the deletion. The
        /// delete operation cannot be canceled or reverted once submitted. For more information
        /// about managing clusters, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// 
        ///  
        /// <para>
        /// If you want to shut down the cluster and retain it for future use, set <i>SkipFinalClusterSnapshot</i>
        /// to <code>false</code> and specify a name for <i>FinalClusterSnapshotIdentifier</i>.
        /// You can later restore this snapshot to resume using the cluster. If a final cluster
        /// snapshot is requested, the status of the cluster will be "final-snapshot" while the
        /// snapshot is being taken, then it's "deleting" once Amazon Redshift begins deleting
        /// the cluster. 
        /// </para>
        ///  
        /// <para>
        ///  For more information about managing clusters, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCluster service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotAlreadyExistsException">
        /// The value specified as a snapshot identifier is already used by an existing snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotQuotaExceededException">
        /// The request would result in the user exceeding the allowed number of cluster snapshots.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidRetentionPeriodException">
        /// The retention period specified is either in the past or is not a valid value.
        /// 
        ///  
        /// <para>
        /// The value must be either -1 or an integer between 1 and 3,653.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        Task<DeleteClusterResponse> DeleteClusterAsync(DeleteClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteClusterParameterGroup


        /// <summary>
        /// Deletes a specified Amazon Redshift parameter group.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot delete a parameter group if it is associated with a cluster.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteClusterParameterGroup service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterParameterGroupStateException">
        /// The cluster parameter group action can not be completed because another task is in
        /// progress that involves the parameter group. Wait a few moments and try the operation
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteClusterParameterGroup">REST API Reference for DeleteClusterParameterGroup Operation</seealso>
        DeleteClusterParameterGroupResponse DeleteClusterParameterGroup(DeleteClusterParameterGroupRequest request);



        /// <summary>
        /// Deletes a specified Amazon Redshift parameter group.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot delete a parameter group if it is associated with a cluster.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteClusterParameterGroup service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterParameterGroupStateException">
        /// The cluster parameter group action can not be completed because another task is in
        /// progress that involves the parameter group. Wait a few moments and try the operation
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteClusterParameterGroup">REST API Reference for DeleteClusterParameterGroup Operation</seealso>
        Task<DeleteClusterParameterGroupResponse> DeleteClusterParameterGroupAsync(DeleteClusterParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteClusterSecurityGroup


        /// <summary>
        /// Deletes an Amazon Redshift security group.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot delete a security group that is associated with any clusters. You cannot
        /// delete the default security group.
        /// </para>
        ///  </note> 
        /// <para>
        ///  For information about managing security groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon
        /// Redshift Cluster Security Groups</a> in the <i>Amazon Redshift Cluster Management
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteClusterSecurityGroup service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSecurityGroupStateException">
        /// The state of the cluster security group is not <code>available</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteClusterSecurityGroup">REST API Reference for DeleteClusterSecurityGroup Operation</seealso>
        DeleteClusterSecurityGroupResponse DeleteClusterSecurityGroup(DeleteClusterSecurityGroupRequest request);



        /// <summary>
        /// Deletes an Amazon Redshift security group.
        /// 
        ///  <note> 
        /// <para>
        /// You cannot delete a security group that is associated with any clusters. You cannot
        /// delete the default security group.
        /// </para>
        ///  </note> 
        /// <para>
        ///  For information about managing security groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon
        /// Redshift Cluster Security Groups</a> in the <i>Amazon Redshift Cluster Management
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSecurityGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteClusterSecurityGroup service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSecurityGroupStateException">
        /// The state of the cluster security group is not <code>available</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteClusterSecurityGroup">REST API Reference for DeleteClusterSecurityGroup Operation</seealso>
        Task<DeleteClusterSecurityGroupResponse> DeleteClusterSecurityGroupAsync(DeleteClusterSecurityGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteClusterSnapshot


        /// <summary>
        /// Deletes the specified manual snapshot. The snapshot must be in the <code>available</code>
        /// state, with no other users authorized to access the snapshot. 
        /// 
        ///  
        /// <para>
        /// Unlike automated snapshots, manual snapshots are retained even after you delete your
        /// cluster. Amazon Redshift does not delete your manual snapshots. You must delete manual
        /// snapshot explicitly to avoid getting charged. If other accounts are authorized to
        /// access the snapshot, you must revoke all of the authorizations before you can delete
        /// the snapshot.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the DeleteClusterSnapshot service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSnapshotStateException">
        /// The specified cluster snapshot is not in the <code>available</code> state, or other
        /// accounts are authorized to access the snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteClusterSnapshot">REST API Reference for DeleteClusterSnapshot Operation</seealso>
        DeleteClusterSnapshotResponse DeleteClusterSnapshot(DeleteClusterSnapshotRequest request);



        /// <summary>
        /// Deletes the specified manual snapshot. The snapshot must be in the <code>available</code>
        /// state, with no other users authorized to access the snapshot. 
        /// 
        ///  
        /// <para>
        /// Unlike automated snapshots, manual snapshots are retained even after you delete your
        /// cluster. Amazon Redshift does not delete your manual snapshots. You must delete manual
        /// snapshot explicitly to avoid getting charged. If other accounts are authorized to
        /// access the snapshot, you must revoke all of the authorizations before you can delete
        /// the snapshot.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteClusterSnapshot service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSnapshotStateException">
        /// The specified cluster snapshot is not in the <code>available</code> state, or other
        /// accounts are authorized to access the snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteClusterSnapshot">REST API Reference for DeleteClusterSnapshot Operation</seealso>
        Task<DeleteClusterSnapshotResponse> DeleteClusterSnapshotAsync(DeleteClusterSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteClusterSubnetGroup


        /// <summary>
        /// Deletes the specified cluster subnet group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteClusterSubnetGroup service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSubnetGroupStateException">
        /// The cluster subnet group cannot be deleted because it is in use.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSubnetStateException">
        /// The state of the subnet is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteClusterSubnetGroup">REST API Reference for DeleteClusterSubnetGroup Operation</seealso>
        DeleteClusterSubnetGroupResponse DeleteClusterSubnetGroup(DeleteClusterSubnetGroupRequest request);



        /// <summary>
        /// Deletes the specified cluster subnet group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteClusterSubnetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteClusterSubnetGroup service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSubnetGroupStateException">
        /// The cluster subnet group cannot be deleted because it is in use.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSubnetStateException">
        /// The state of the subnet is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteClusterSubnetGroup">REST API Reference for DeleteClusterSubnetGroup Operation</seealso>
        Task<DeleteClusterSubnetGroupResponse> DeleteClusterSubnetGroupAsync(DeleteClusterSubnetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteEventSubscription


        /// <summary>
        /// Deletes an Amazon Redshift event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSubscription service method.</param>
        /// 
        /// <returns>The response from the DeleteEventSubscription service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidSubscriptionStateException">
        /// The subscription request is invalid because it is a duplicate request. This subscription
        /// request is already in progress.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionNotFoundException">
        /// An Amazon Redshift event notification subscription with the specified name does not
        /// exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteEventSubscription">REST API Reference for DeleteEventSubscription Operation</seealso>
        DeleteEventSubscriptionResponse DeleteEventSubscription(DeleteEventSubscriptionRequest request);



        /// <summary>
        /// Deletes an Amazon Redshift event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEventSubscription service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidSubscriptionStateException">
        /// The subscription request is invalid because it is a duplicate request. This subscription
        /// request is already in progress.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionNotFoundException">
        /// An Amazon Redshift event notification subscription with the specified name does not
        /// exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteEventSubscription">REST API Reference for DeleteEventSubscription Operation</seealso>
        Task<DeleteEventSubscriptionResponse> DeleteEventSubscriptionAsync(DeleteEventSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteHsmClientCertificate


        /// <summary>
        /// Deletes the specified HSM client certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsmClientCertificate service method.</param>
        /// 
        /// <returns>The response from the DeleteHsmClientCertificate service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmClientCertificateNotFoundException">
        /// There is no Amazon Redshift HSM client certificate with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidHsmClientCertificateStateException">
        /// The specified HSM client certificate is not in the <code>available</code> state, or
        /// it is still in use by one or more Amazon Redshift clusters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteHsmClientCertificate">REST API Reference for DeleteHsmClientCertificate Operation</seealso>
        DeleteHsmClientCertificateResponse DeleteHsmClientCertificate(DeleteHsmClientCertificateRequest request);



        /// <summary>
        /// Deletes the specified HSM client certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsmClientCertificate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteHsmClientCertificate service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmClientCertificateNotFoundException">
        /// There is no Amazon Redshift HSM client certificate with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidHsmClientCertificateStateException">
        /// The specified HSM client certificate is not in the <code>available</code> state, or
        /// it is still in use by one or more Amazon Redshift clusters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteHsmClientCertificate">REST API Reference for DeleteHsmClientCertificate Operation</seealso>
        Task<DeleteHsmClientCertificateResponse> DeleteHsmClientCertificateAsync(DeleteHsmClientCertificateRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteHsmConfiguration


        /// <summary>
        /// Deletes the specified Amazon Redshift HSM configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsmConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteHsmConfiguration service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmConfigurationNotFoundException">
        /// There is no Amazon Redshift HSM configuration with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidHsmConfigurationStateException">
        /// The specified HSM configuration is not in the <code>available</code> state, or it
        /// is still in use by one or more Amazon Redshift clusters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteHsmConfiguration">REST API Reference for DeleteHsmConfiguration Operation</seealso>
        DeleteHsmConfigurationResponse DeleteHsmConfiguration(DeleteHsmConfigurationRequest request);



        /// <summary>
        /// Deletes the specified Amazon Redshift HSM configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteHsmConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteHsmConfiguration service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmConfigurationNotFoundException">
        /// There is no Amazon Redshift HSM configuration with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidHsmConfigurationStateException">
        /// The specified HSM configuration is not in the <code>available</code> state, or it
        /// is still in use by one or more Amazon Redshift clusters.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteHsmConfiguration">REST API Reference for DeleteHsmConfiguration Operation</seealso>
        Task<DeleteHsmConfigurationResponse> DeleteHsmConfigurationAsync(DeleteHsmConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteScheduledAction


        /// <summary>
        /// Deletes a scheduled action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScheduledAction service method.</param>
        /// 
        /// <returns>The response from the DeleteScheduledAction service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ScheduledActionNotFoundException">
        /// The scheduled action cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteScheduledAction">REST API Reference for DeleteScheduledAction Operation</seealso>
        DeleteScheduledActionResponse DeleteScheduledAction(DeleteScheduledActionRequest request);



        /// <summary>
        /// Deletes a scheduled action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScheduledAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteScheduledAction service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ScheduledActionNotFoundException">
        /// The scheduled action cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteScheduledAction">REST API Reference for DeleteScheduledAction Operation</seealso>
        Task<DeleteScheduledActionResponse> DeleteScheduledActionAsync(DeleteScheduledActionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteSnapshotCopyGrant


        /// <summary>
        /// Deletes the specified snapshot copy grant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshotCopyGrant service method.</param>
        /// 
        /// <returns>The response from the DeleteSnapshotCopyGrant service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidSnapshotCopyGrantStateException">
        /// The snapshot copy grant can't be deleted because it is used by one or more clusters.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotCopyGrantNotFoundException">
        /// The specified snapshot copy grant can't be found. Make sure that the name is typed
        /// correctly and that the grant exists in the destination region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteSnapshotCopyGrant">REST API Reference for DeleteSnapshotCopyGrant Operation</seealso>
        DeleteSnapshotCopyGrantResponse DeleteSnapshotCopyGrant(DeleteSnapshotCopyGrantRequest request);



        /// <summary>
        /// Deletes the specified snapshot copy grant.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshotCopyGrant service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSnapshotCopyGrant service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidSnapshotCopyGrantStateException">
        /// The snapshot copy grant can't be deleted because it is used by one or more clusters.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotCopyGrantNotFoundException">
        /// The specified snapshot copy grant can't be found. Make sure that the name is typed
        /// correctly and that the grant exists in the destination region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteSnapshotCopyGrant">REST API Reference for DeleteSnapshotCopyGrant Operation</seealso>
        Task<DeleteSnapshotCopyGrantResponse> DeleteSnapshotCopyGrantAsync(DeleteSnapshotCopyGrantRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteSnapshotSchedule


        /// <summary>
        /// Deletes a snapshot schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshotSchedule service method.</param>
        /// 
        /// <returns>The response from the DeleteSnapshotSchedule service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSnapshotScheduleStateException">
        /// The cluster snapshot schedule state is not valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotScheduleNotFoundException">
        /// We could not find the specified snapshot schedule.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteSnapshotSchedule">REST API Reference for DeleteSnapshotSchedule Operation</seealso>
        DeleteSnapshotScheduleResponse DeleteSnapshotSchedule(DeleteSnapshotScheduleRequest request);



        /// <summary>
        /// Deletes a snapshot schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshotSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSnapshotSchedule service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSnapshotScheduleStateException">
        /// The cluster snapshot schedule state is not valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotScheduleNotFoundException">
        /// We could not find the specified snapshot schedule.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteSnapshotSchedule">REST API Reference for DeleteSnapshotSchedule Operation</seealso>
        Task<DeleteSnapshotScheduleResponse> DeleteSnapshotScheduleAsync(DeleteSnapshotScheduleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteTags


        /// <summary>
        /// Deletes tags from a resource. You must provide the ARN of the resource from which
        /// you want to delete the tag or tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags service method.</param>
        /// 
        /// <returns>The response from the DeleteTags service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        DeleteTagsResponse DeleteTags(DeleteTagsRequest request);



        /// <summary>
        /// Deletes tags from a resource. You must provide the ARN of the resource from which
        /// you want to delete the tag or tags.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTags service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAccountAttributes


        /// <summary>
        /// Returns a list of attributes attached to an account
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        DescribeAccountAttributesResponse DescribeAccountAttributes(DescribeAccountAttributesRequest request);



        /// <summary>
        /// Returns a list of attributes attached to an account
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        Task<DescribeAccountAttributesResponse> DescribeAccountAttributesAsync(DescribeAccountAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeClusterDbRevisions


        /// <summary>
        /// Returns an array of <code>ClusterDbRevision</code> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterDbRevisions service method.</param>
        /// 
        /// <returns>The response from the DescribeClusterDbRevisions service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterDbRevisions">REST API Reference for DescribeClusterDbRevisions Operation</seealso>
        DescribeClusterDbRevisionsResponse DescribeClusterDbRevisions(DescribeClusterDbRevisionsRequest request);



        /// <summary>
        /// Returns an array of <code>ClusterDbRevision</code> objects.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterDbRevisions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusterDbRevisions service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterDbRevisions">REST API Reference for DescribeClusterDbRevisions Operation</seealso>
        Task<DescribeClusterDbRevisionsResponse> DescribeClusterDbRevisionsAsync(DescribeClusterDbRevisionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeClusterParameterGroups


        /// <summary>
        /// Returns a list of Amazon Redshift parameter groups, including parameter groups you
        /// created and the default parameter group. For each parameter group, the response includes
        /// the parameter group name, description, and parameter group family name. You can optionally
        /// specify a name to retrieve the description of a specific parameter group.
        /// 
        ///  
        /// <para>
        ///  For more information about parameters and parameter groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all parameter groups that match any combination of the specified keys and values.
        /// For example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all parameter groups
        /// that have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, parameter groups are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeClusterParameterGroups service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterParameterGroups">REST API Reference for DescribeClusterParameterGroups Operation</seealso>
        DescribeClusterParameterGroupsResponse DescribeClusterParameterGroups();


        /// <summary>
        /// Returns a list of Amazon Redshift parameter groups, including parameter groups you
        /// created and the default parameter group. For each parameter group, the response includes
        /// the parameter group name, description, and parameter group family name. You can optionally
        /// specify a name to retrieve the description of a specific parameter group.
        /// 
        ///  
        /// <para>
        ///  For more information about parameters and parameter groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all parameter groups that match any combination of the specified keys and values.
        /// For example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all parameter groups
        /// that have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, parameter groups are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterParameterGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeClusterParameterGroups service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterParameterGroups">REST API Reference for DescribeClusterParameterGroups Operation</seealso>
        DescribeClusterParameterGroupsResponse DescribeClusterParameterGroups(DescribeClusterParameterGroupsRequest request);


        /// <summary>
        /// Returns a list of Amazon Redshift parameter groups, including parameter groups you
        /// created and the default parameter group. For each parameter group, the response includes
        /// the parameter group name, description, and parameter group family name. You can optionally
        /// specify a name to retrieve the description of a specific parameter group.
        /// 
        ///  
        /// <para>
        ///  For more information about parameters and parameter groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all parameter groups that match any combination of the specified keys and values.
        /// For example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all parameter groups
        /// that have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, parameter groups are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusterParameterGroups service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterParameterGroups">REST API Reference for DescribeClusterParameterGroups Operation</seealso>
        Task<DescribeClusterParameterGroupsResponse> DescribeClusterParameterGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Returns a list of Amazon Redshift parameter groups, including parameter groups you
        /// created and the default parameter group. For each parameter group, the response includes
        /// the parameter group name, description, and parameter group family name. You can optionally
        /// specify a name to retrieve the description of a specific parameter group.
        /// 
        ///  
        /// <para>
        ///  For more information about parameters and parameter groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all parameter groups that match any combination of the specified keys and values.
        /// For example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all parameter groups
        /// that have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, parameter groups are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterParameterGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusterParameterGroups service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterParameterGroups">REST API Reference for DescribeClusterParameterGroups Operation</seealso>
        Task<DescribeClusterParameterGroupsResponse> DescribeClusterParameterGroupsAsync(DescribeClusterParameterGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeClusterParameters


        /// <summary>
        /// Returns a detailed list of parameters contained within the specified Amazon Redshift
        /// parameter group. For each parameter the response includes information such as parameter
        /// name, description, data type, value, whether the parameter value is modifiable, and
        /// so on.
        /// 
        ///  
        /// <para>
        /// You can specify <i>source</i> filter to retrieve parameters of only specific type.
        /// For example, to retrieve parameters that were modified by a user action such as from
        /// <a>ModifyClusterParameterGroup</a>, you can specify <i>source</i> equal to <i>user</i>.
        /// </para>
        ///  
        /// <para>
        ///  For more information about parameters and parameter groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeClusterParameters service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterParameters">REST API Reference for DescribeClusterParameters Operation</seealso>
        DescribeClusterParametersResponse DescribeClusterParameters(DescribeClusterParametersRequest request);



        /// <summary>
        /// Returns a detailed list of parameters contained within the specified Amazon Redshift
        /// parameter group. For each parameter the response includes information such as parameter
        /// name, description, data type, value, whether the parameter value is modifiable, and
        /// so on.
        /// 
        ///  
        /// <para>
        /// You can specify <i>source</i> filter to retrieve parameters of only specific type.
        /// For example, to retrieve parameters that were modified by a user action such as from
        /// <a>ModifyClusterParameterGroup</a>, you can specify <i>source</i> equal to <i>user</i>.
        /// </para>
        ///  
        /// <para>
        ///  For more information about parameters and parameter groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterParameters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusterParameters service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterParameters">REST API Reference for DescribeClusterParameters Operation</seealso>
        Task<DescribeClusterParametersResponse> DescribeClusterParametersAsync(DescribeClusterParametersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeClusters


        /// <summary>
        /// Returns properties of provisioned clusters including general cluster properties, cluster
        /// database properties, maintenance and backup properties, and security and access properties.
        /// This operation supports pagination. For more information about managing clusters,
        /// go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all clusters that match any combination of the specified keys and values. For example,
        /// if you have <code>owner</code> and <code>environment</code> for tag keys, and <code>admin</code>
        /// and <code>test</code> for tag values, all clusters that have any combination of those
        /// values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, clusters are returned regardless
        /// of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeClusters service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusters">REST API Reference for DescribeClusters Operation</seealso>
        DescribeClustersResponse DescribeClusters();


        /// <summary>
        /// Returns properties of provisioned clusters including general cluster properties, cluster
        /// database properties, maintenance and backup properties, and security and access properties.
        /// This operation supports pagination. For more information about managing clusters,
        /// go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all clusters that match any combination of the specified keys and values. For example,
        /// if you have <code>owner</code> and <code>environment</code> for tag keys, and <code>admin</code>
        /// and <code>test</code> for tag values, all clusters that have any combination of those
        /// values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, clusters are returned regardless
        /// of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusters service method.</param>
        /// 
        /// <returns>The response from the DescribeClusters service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusters">REST API Reference for DescribeClusters Operation</seealso>
        DescribeClustersResponse DescribeClusters(DescribeClustersRequest request);


        /// <summary>
        /// Returns properties of provisioned clusters including general cluster properties, cluster
        /// database properties, maintenance and backup properties, and security and access properties.
        /// This operation supports pagination. For more information about managing clusters,
        /// go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all clusters that match any combination of the specified keys and values. For example,
        /// if you have <code>owner</code> and <code>environment</code> for tag keys, and <code>admin</code>
        /// and <code>test</code> for tag values, all clusters that have any combination of those
        /// values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, clusters are returned regardless
        /// of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusters service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusters">REST API Reference for DescribeClusters Operation</seealso>
        Task<DescribeClustersResponse> DescribeClustersAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Returns properties of provisioned clusters including general cluster properties, cluster
        /// database properties, maintenance and backup properties, and security and access properties.
        /// This operation supports pagination. For more information about managing clusters,
        /// go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all clusters that match any combination of the specified keys and values. For example,
        /// if you have <code>owner</code> and <code>environment</code> for tag keys, and <code>admin</code>
        /// and <code>test</code> for tag values, all clusters that have any combination of those
        /// values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, clusters are returned regardless
        /// of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusters service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusters">REST API Reference for DescribeClusters Operation</seealso>
        Task<DescribeClustersResponse> DescribeClustersAsync(DescribeClustersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeClusterSecurityGroups


        /// <summary>
        /// Returns information about Amazon Redshift security groups. If the name of a security
        /// group is specified, the response will contain only information about only that security
        /// group.
        /// 
        ///  
        /// <para>
        ///  For information about managing security groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon
        /// Redshift Cluster Security Groups</a> in the <i>Amazon Redshift Cluster Management
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all security groups that match any combination of the specified keys and values. For
        /// example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all security groups that
        /// have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, security groups are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeClusterSecurityGroups service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterSecurityGroups">REST API Reference for DescribeClusterSecurityGroups Operation</seealso>
        DescribeClusterSecurityGroupsResponse DescribeClusterSecurityGroups();


        /// <summary>
        /// Returns information about Amazon Redshift security groups. If the name of a security
        /// group is specified, the response will contain only information about only that security
        /// group.
        /// 
        ///  
        /// <para>
        ///  For information about managing security groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon
        /// Redshift Cluster Security Groups</a> in the <i>Amazon Redshift Cluster Management
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all security groups that match any combination of the specified keys and values. For
        /// example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all security groups that
        /// have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, security groups are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSecurityGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeClusterSecurityGroups service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterSecurityGroups">REST API Reference for DescribeClusterSecurityGroups Operation</seealso>
        DescribeClusterSecurityGroupsResponse DescribeClusterSecurityGroups(DescribeClusterSecurityGroupsRequest request);


        /// <summary>
        /// Returns information about Amazon Redshift security groups. If the name of a security
        /// group is specified, the response will contain only information about only that security
        /// group.
        /// 
        ///  
        /// <para>
        ///  For information about managing security groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon
        /// Redshift Cluster Security Groups</a> in the <i>Amazon Redshift Cluster Management
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all security groups that match any combination of the specified keys and values. For
        /// example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all security groups that
        /// have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, security groups are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusterSecurityGroups service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterSecurityGroups">REST API Reference for DescribeClusterSecurityGroups Operation</seealso>
        Task<DescribeClusterSecurityGroupsResponse> DescribeClusterSecurityGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Returns information about Amazon Redshift security groups. If the name of a security
        /// group is specified, the response will contain only information about only that security
        /// group.
        /// 
        ///  
        /// <para>
        ///  For information about managing security groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon
        /// Redshift Cluster Security Groups</a> in the <i>Amazon Redshift Cluster Management
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all security groups that match any combination of the specified keys and values. For
        /// example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all security groups that
        /// have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, security groups are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSecurityGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusterSecurityGroups service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterSecurityGroups">REST API Reference for DescribeClusterSecurityGroups Operation</seealso>
        Task<DescribeClusterSecurityGroupsResponse> DescribeClusterSecurityGroupsAsync(DescribeClusterSecurityGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeClusterSnapshots


        /// <summary>
        /// Returns one or more snapshot objects, which contain metadata about your cluster snapshots.
        /// By default, this operation returns information about all snapshots of all clusters
        /// that are owned by you AWS customer account. No information is returned for snapshots
        /// owned by inactive AWS customer accounts.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all snapshots that match any combination of the specified keys and values. For example,
        /// if you have <code>owner</code> and <code>environment</code> for tag keys, and <code>admin</code>
        /// and <code>test</code> for tag values, all snapshots that have any combination of those
        /// values are returned. Only snapshots that you own are returned in the response; shared
        /// snapshots are not returned with the tag key and tag value request parameters.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, snapshots are returned regardless
        /// of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeClusterSnapshots service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterSnapshots">REST API Reference for DescribeClusterSnapshots Operation</seealso>
        DescribeClusterSnapshotsResponse DescribeClusterSnapshots();


        /// <summary>
        /// Returns one or more snapshot objects, which contain metadata about your cluster snapshots.
        /// By default, this operation returns information about all snapshots of all clusters
        /// that are owned by you AWS customer account. No information is returned for snapshots
        /// owned by inactive AWS customer accounts.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all snapshots that match any combination of the specified keys and values. For example,
        /// if you have <code>owner</code> and <code>environment</code> for tag keys, and <code>admin</code>
        /// and <code>test</code> for tag values, all snapshots that have any combination of those
        /// values are returned. Only snapshots that you own are returned in the response; shared
        /// snapshots are not returned with the tag key and tag value request parameters.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, snapshots are returned regardless
        /// of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSnapshots service method.</param>
        /// 
        /// <returns>The response from the DescribeClusterSnapshots service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterSnapshots">REST API Reference for DescribeClusterSnapshots Operation</seealso>
        DescribeClusterSnapshotsResponse DescribeClusterSnapshots(DescribeClusterSnapshotsRequest request);


        /// <summary>
        /// Returns one or more snapshot objects, which contain metadata about your cluster snapshots.
        /// By default, this operation returns information about all snapshots of all clusters
        /// that are owned by you AWS customer account. No information is returned for snapshots
        /// owned by inactive AWS customer accounts.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all snapshots that match any combination of the specified keys and values. For example,
        /// if you have <code>owner</code> and <code>environment</code> for tag keys, and <code>admin</code>
        /// and <code>test</code> for tag values, all snapshots that have any combination of those
        /// values are returned. Only snapshots that you own are returned in the response; shared
        /// snapshots are not returned with the tag key and tag value request parameters.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, snapshots are returned regardless
        /// of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusterSnapshots service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterSnapshots">REST API Reference for DescribeClusterSnapshots Operation</seealso>
        Task<DescribeClusterSnapshotsResponse> DescribeClusterSnapshotsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Returns one or more snapshot objects, which contain metadata about your cluster snapshots.
        /// By default, this operation returns information about all snapshots of all clusters
        /// that are owned by you AWS customer account. No information is returned for snapshots
        /// owned by inactive AWS customer accounts.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all snapshots that match any combination of the specified keys and values. For example,
        /// if you have <code>owner</code> and <code>environment</code> for tag keys, and <code>admin</code>
        /// and <code>test</code> for tag values, all snapshots that have any combination of those
        /// values are returned. Only snapshots that you own are returned in the response; shared
        /// snapshots are not returned with the tag key and tag value request parameters.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, snapshots are returned regardless
        /// of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSnapshots service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusterSnapshots service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterSnapshots">REST API Reference for DescribeClusterSnapshots Operation</seealso>
        Task<DescribeClusterSnapshotsResponse> DescribeClusterSnapshotsAsync(DescribeClusterSnapshotsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeClusterSubnetGroups


        /// <summary>
        /// Returns one or more cluster subnet group objects, which contain metadata about your
        /// cluster subnet groups. By default, this operation returns information about all cluster
        /// subnet groups that are defined in you AWS account.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all subnet groups that match any combination of the specified keys and values. For
        /// example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all subnet groups that
        /// have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, subnet groups are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeClusterSubnetGroups service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterSubnetGroups">REST API Reference for DescribeClusterSubnetGroups Operation</seealso>
        DescribeClusterSubnetGroupsResponse DescribeClusterSubnetGroups();


        /// <summary>
        /// Returns one or more cluster subnet group objects, which contain metadata about your
        /// cluster subnet groups. By default, this operation returns information about all cluster
        /// subnet groups that are defined in you AWS account.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all subnet groups that match any combination of the specified keys and values. For
        /// example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all subnet groups that
        /// have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, subnet groups are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSubnetGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeClusterSubnetGroups service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterSubnetGroups">REST API Reference for DescribeClusterSubnetGroups Operation</seealso>
        DescribeClusterSubnetGroupsResponse DescribeClusterSubnetGroups(DescribeClusterSubnetGroupsRequest request);


        /// <summary>
        /// Returns one or more cluster subnet group objects, which contain metadata about your
        /// cluster subnet groups. By default, this operation returns information about all cluster
        /// subnet groups that are defined in you AWS account.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all subnet groups that match any combination of the specified keys and values. For
        /// example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all subnet groups that
        /// have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, subnet groups are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusterSubnetGroups service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterSubnetGroups">REST API Reference for DescribeClusterSubnetGroups Operation</seealso>
        Task<DescribeClusterSubnetGroupsResponse> DescribeClusterSubnetGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Returns one or more cluster subnet group objects, which contain metadata about your
        /// cluster subnet groups. By default, this operation returns information about all cluster
        /// subnet groups that are defined in you AWS account.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all subnet groups that match any combination of the specified keys and values. For
        /// example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all subnet groups that
        /// have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, subnet groups are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterSubnetGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusterSubnetGroups service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterSubnetGroups">REST API Reference for DescribeClusterSubnetGroups Operation</seealso>
        Task<DescribeClusterSubnetGroupsResponse> DescribeClusterSubnetGroupsAsync(DescribeClusterSubnetGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeClusterTracks


        /// <summary>
        /// Returns a list of all the available maintenance tracks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterTracks service method.</param>
        /// 
        /// <returns>The response from the DescribeClusterTracks service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterTrackException">
        /// The provided cluster track name is not valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterTracks">REST API Reference for DescribeClusterTracks Operation</seealso>
        DescribeClusterTracksResponse DescribeClusterTracks(DescribeClusterTracksRequest request);



        /// <summary>
        /// Returns a list of all the available maintenance tracks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterTracks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusterTracks service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterTrackException">
        /// The provided cluster track name is not valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterTracks">REST API Reference for DescribeClusterTracks Operation</seealso>
        Task<DescribeClusterTracksResponse> DescribeClusterTracksAsync(DescribeClusterTracksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeClusterVersions


        /// <summary>
        /// Returns descriptions of the available Amazon Redshift cluster versions. You can call
        /// this operation even before creating any clusters to learn more about the Amazon Redshift
        /// versions. For more information about managing clusters, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeClusterVersions service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterVersions">REST API Reference for DescribeClusterVersions Operation</seealso>
        DescribeClusterVersionsResponse DescribeClusterVersions();


        /// <summary>
        /// Returns descriptions of the available Amazon Redshift cluster versions. You can call
        /// this operation even before creating any clusters to learn more about the Amazon Redshift
        /// versions. For more information about managing clusters, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterVersions service method.</param>
        /// 
        /// <returns>The response from the DescribeClusterVersions service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterVersions">REST API Reference for DescribeClusterVersions Operation</seealso>
        DescribeClusterVersionsResponse DescribeClusterVersions(DescribeClusterVersionsRequest request);


        /// <summary>
        /// Returns descriptions of the available Amazon Redshift cluster versions. You can call
        /// this operation even before creating any clusters to learn more about the Amazon Redshift
        /// versions. For more information about managing clusters, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusterVersions service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterVersions">REST API Reference for DescribeClusterVersions Operation</seealso>
        Task<DescribeClusterVersionsResponse> DescribeClusterVersionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Returns descriptions of the available Amazon Redshift cluster versions. You can call
        /// this operation even before creating any clusters to learn more about the Amazon Redshift
        /// versions. For more information about managing clusters, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClusterVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeClusterVersions service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeClusterVersions">REST API Reference for DescribeClusterVersions Operation</seealso>
        Task<DescribeClusterVersionsResponse> DescribeClusterVersionsAsync(DescribeClusterVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDefaultClusterParameters


        /// <summary>
        /// Returns a list of parameter settings for the specified parameter group family.
        /// 
        ///  
        /// <para>
        ///  For more information about parameters and parameter groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDefaultClusterParameters service method.</param>
        /// 
        /// <returns>The response from the DescribeDefaultClusterParameters service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeDefaultClusterParameters">REST API Reference for DescribeDefaultClusterParameters Operation</seealso>
        DescribeDefaultClusterParametersResponse DescribeDefaultClusterParameters(DescribeDefaultClusterParametersRequest request);



        /// <summary>
        /// Returns a list of parameter settings for the specified parameter group family.
        /// 
        ///  
        /// <para>
        ///  For more information about parameters and parameter groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDefaultClusterParameters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDefaultClusterParameters service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeDefaultClusterParameters">REST API Reference for DescribeDefaultClusterParameters Operation</seealso>
        Task<DescribeDefaultClusterParametersResponse> DescribeDefaultClusterParametersAsync(DescribeDefaultClusterParametersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEventCategories


        /// <summary>
        /// Displays a list of event categories for all event source types, or for a specified
        /// source type. For a list of the event categories and source types, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-event-notifications.html">Amazon
        /// Redshift Event Notifications</a>.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEventCategories">REST API Reference for DescribeEventCategories Operation</seealso>
        DescribeEventCategoriesResponse DescribeEventCategories();


        /// <summary>
        /// Displays a list of event categories for all event source types, or for a specified
        /// source type. For a list of the event categories and source types, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-event-notifications.html">Amazon
        /// Redshift Event Notifications</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventCategories service method.</param>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEventCategories">REST API Reference for DescribeEventCategories Operation</seealso>
        DescribeEventCategoriesResponse DescribeEventCategories(DescribeEventCategoriesRequest request);


        /// <summary>
        /// Displays a list of event categories for all event source types, or for a specified
        /// source type. For a list of the event categories and source types, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-event-notifications.html">Amazon
        /// Redshift Event Notifications</a>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEventCategories">REST API Reference for DescribeEventCategories Operation</seealso>
        Task<DescribeEventCategoriesResponse> DescribeEventCategoriesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Displays a list of event categories for all event source types, or for a specified
        /// source type. For a list of the event categories and source types, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-event-notifications.html">Amazon
        /// Redshift Event Notifications</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventCategories service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventCategories service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEventCategories">REST API Reference for DescribeEventCategories Operation</seealso>
        Task<DescribeEventCategoriesResponse> DescribeEventCategoriesAsync(DescribeEventCategoriesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEvents


        /// <summary>
        /// Returns events related to clusters, security groups, snapshots, and parameter groups
        /// for the past 14 days. Events specific to a particular cluster, security group, snapshot
        /// or parameter group can be obtained by providing the name as a parameter. By default,
        /// the past hour of events are returned.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        DescribeEventsResponse DescribeEvents();


        /// <summary>
        /// Returns events related to clusters, security groups, snapshots, and parameter groups
        /// for the past 14 days. Events specific to a particular cluster, security group, snapshot
        /// or parameter group can be obtained by providing the name as a parameter. By default,
        /// the past hour of events are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents service method.</param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        DescribeEventsResponse DescribeEvents(DescribeEventsRequest request);


        /// <summary>
        /// Returns events related to clusters, security groups, snapshots, and parameter groups
        /// for the past 14 days. Events specific to a particular cluster, security group, snapshot
        /// or parameter group can be obtained by providing the name as a parameter. By default,
        /// the past hour of events are returned.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        Task<DescribeEventsResponse> DescribeEventsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Returns events related to clusters, security groups, snapshots, and parameter groups
        /// for the past 14 days. Events specific to a particular cluster, security group, snapshot
        /// or parameter group can be obtained by providing the name as a parameter. By default,
        /// the past hour of events are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEvents service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEvents">REST API Reference for DescribeEvents Operation</seealso>
        Task<DescribeEventsResponse> DescribeEventsAsync(DescribeEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeEventSubscriptions


        /// <summary>
        /// Lists descriptions of all the Amazon Redshift event notification subscriptions for
        /// a customer account. If you specify a subscription name, lists the description for
        /// that subscription.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all event notification subscriptions that match any combination of the specified keys
        /// and values. For example, if you have <code>owner</code> and <code>environment</code>
        /// for tag keys, and <code>admin</code> and <code>test</code> for tag values, all subscriptions
        /// that have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, subscriptions are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionNotFoundException">
        /// An Amazon Redshift event notification subscription with the specified name does not
        /// exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEventSubscriptions">REST API Reference for DescribeEventSubscriptions Operation</seealso>
        DescribeEventSubscriptionsResponse DescribeEventSubscriptions();


        /// <summary>
        /// Lists descriptions of all the Amazon Redshift event notification subscriptions for
        /// a customer account. If you specify a subscription name, lists the description for
        /// that subscription.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all event notification subscriptions that match any combination of the specified keys
        /// and values. For example, if you have <code>owner</code> and <code>environment</code>
        /// for tag keys, and <code>admin</code> and <code>test</code> for tag values, all subscriptions
        /// that have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, subscriptions are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSubscriptions service method.</param>
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionNotFoundException">
        /// An Amazon Redshift event notification subscription with the specified name does not
        /// exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEventSubscriptions">REST API Reference for DescribeEventSubscriptions Operation</seealso>
        DescribeEventSubscriptionsResponse DescribeEventSubscriptions(DescribeEventSubscriptionsRequest request);


        /// <summary>
        /// Lists descriptions of all the Amazon Redshift event notification subscriptions for
        /// a customer account. If you specify a subscription name, lists the description for
        /// that subscription.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all event notification subscriptions that match any combination of the specified keys
        /// and values. For example, if you have <code>owner</code> and <code>environment</code>
        /// for tag keys, and <code>admin</code> and <code>test</code> for tag values, all subscriptions
        /// that have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, subscriptions are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionNotFoundException">
        /// An Amazon Redshift event notification subscription with the specified name does not
        /// exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEventSubscriptions">REST API Reference for DescribeEventSubscriptions Operation</seealso>
        Task<DescribeEventSubscriptionsResponse> DescribeEventSubscriptionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Lists descriptions of all the Amazon Redshift event notification subscriptions for
        /// a customer account. If you specify a subscription name, lists the description for
        /// that subscription.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all event notification subscriptions that match any combination of the specified keys
        /// and values. For example, if you have <code>owner</code> and <code>environment</code>
        /// for tag keys, and <code>admin</code> and <code>test</code> for tag values, all subscriptions
        /// that have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, subscriptions are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEventSubscriptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeEventSubscriptions service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionNotFoundException">
        /// An Amazon Redshift event notification subscription with the specified name does not
        /// exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeEventSubscriptions">REST API Reference for DescribeEventSubscriptions Operation</seealso>
        Task<DescribeEventSubscriptionsResponse> DescribeEventSubscriptionsAsync(DescribeEventSubscriptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeHsmClientCertificates


        /// <summary>
        /// Returns information about the specified HSM client certificate. If no certificate
        /// ID is specified, returns information about all the HSM certificates owned by your
        /// AWS customer account.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all HSM client certificates that match any combination of the specified keys and values.
        /// For example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all HSM client certificates
        /// that have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, HSM client certificates
        /// are returned regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeHsmClientCertificates service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmClientCertificateNotFoundException">
        /// There is no Amazon Redshift HSM client certificate with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeHsmClientCertificates">REST API Reference for DescribeHsmClientCertificates Operation</seealso>
        DescribeHsmClientCertificatesResponse DescribeHsmClientCertificates();


        /// <summary>
        /// Returns information about the specified HSM client certificate. If no certificate
        /// ID is specified, returns information about all the HSM certificates owned by your
        /// AWS customer account.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all HSM client certificates that match any combination of the specified keys and values.
        /// For example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all HSM client certificates
        /// that have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, HSM client certificates
        /// are returned regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHsmClientCertificates service method.</param>
        /// 
        /// <returns>The response from the DescribeHsmClientCertificates service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmClientCertificateNotFoundException">
        /// There is no Amazon Redshift HSM client certificate with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeHsmClientCertificates">REST API Reference for DescribeHsmClientCertificates Operation</seealso>
        DescribeHsmClientCertificatesResponse DescribeHsmClientCertificates(DescribeHsmClientCertificatesRequest request);


        /// <summary>
        /// Returns information about the specified HSM client certificate. If no certificate
        /// ID is specified, returns information about all the HSM certificates owned by your
        /// AWS customer account.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all HSM client certificates that match any combination of the specified keys and values.
        /// For example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all HSM client certificates
        /// that have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, HSM client certificates
        /// are returned regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeHsmClientCertificates service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmClientCertificateNotFoundException">
        /// There is no Amazon Redshift HSM client certificate with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeHsmClientCertificates">REST API Reference for DescribeHsmClientCertificates Operation</seealso>
        Task<DescribeHsmClientCertificatesResponse> DescribeHsmClientCertificatesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Returns information about the specified HSM client certificate. If no certificate
        /// ID is specified, returns information about all the HSM certificates owned by your
        /// AWS customer account.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all HSM client certificates that match any combination of the specified keys and values.
        /// For example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all HSM client certificates
        /// that have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, HSM client certificates
        /// are returned regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHsmClientCertificates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeHsmClientCertificates service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmClientCertificateNotFoundException">
        /// There is no Amazon Redshift HSM client certificate with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeHsmClientCertificates">REST API Reference for DescribeHsmClientCertificates Operation</seealso>
        Task<DescribeHsmClientCertificatesResponse> DescribeHsmClientCertificatesAsync(DescribeHsmClientCertificatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeHsmConfigurations


        /// <summary>
        /// Returns information about the specified Amazon Redshift HSM configuration. If no configuration
        /// ID is specified, returns information about all the HSM configurations owned by your
        /// AWS customer account.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all HSM connections that match any combination of the specified keys and values. For
        /// example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all HSM connections that
        /// have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, HSM connections are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeHsmConfigurations service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmConfigurationNotFoundException">
        /// There is no Amazon Redshift HSM configuration with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeHsmConfigurations">REST API Reference for DescribeHsmConfigurations Operation</seealso>
        DescribeHsmConfigurationsResponse DescribeHsmConfigurations();


        /// <summary>
        /// Returns information about the specified Amazon Redshift HSM configuration. If no configuration
        /// ID is specified, returns information about all the HSM configurations owned by your
        /// AWS customer account.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all HSM connections that match any combination of the specified keys and values. For
        /// example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all HSM connections that
        /// have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, HSM connections are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHsmConfigurations service method.</param>
        /// 
        /// <returns>The response from the DescribeHsmConfigurations service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmConfigurationNotFoundException">
        /// There is no Amazon Redshift HSM configuration with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeHsmConfigurations">REST API Reference for DescribeHsmConfigurations Operation</seealso>
        DescribeHsmConfigurationsResponse DescribeHsmConfigurations(DescribeHsmConfigurationsRequest request);


        /// <summary>
        /// Returns information about the specified Amazon Redshift HSM configuration. If no configuration
        /// ID is specified, returns information about all the HSM configurations owned by your
        /// AWS customer account.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all HSM connections that match any combination of the specified keys and values. For
        /// example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all HSM connections that
        /// have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, HSM connections are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeHsmConfigurations service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmConfigurationNotFoundException">
        /// There is no Amazon Redshift HSM configuration with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeHsmConfigurations">REST API Reference for DescribeHsmConfigurations Operation</seealso>
        Task<DescribeHsmConfigurationsResponse> DescribeHsmConfigurationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Returns information about the specified Amazon Redshift HSM configuration. If no configuration
        /// ID is specified, returns information about all the HSM configurations owned by your
        /// AWS customer account.
        /// 
        ///  
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all HSM connections that match any combination of the specified keys and values. For
        /// example, if you have <code>owner</code> and <code>environment</code> for tag keys,
        /// and <code>admin</code> and <code>test</code> for tag values, all HSM connections that
        /// have any combination of those values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, HSM connections are returned
        /// regardless of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHsmConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeHsmConfigurations service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.HsmConfigurationNotFoundException">
        /// There is no Amazon Redshift HSM configuration with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeHsmConfigurations">REST API Reference for DescribeHsmConfigurations Operation</seealso>
        Task<DescribeHsmConfigurationsResponse> DescribeHsmConfigurationsAsync(DescribeHsmConfigurationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeLoggingStatus


        /// <summary>
        /// Describes whether information, such as queries and connection attempts, is being logged
        /// for the specified Amazon Redshift cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoggingStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeLoggingStatus service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeLoggingStatus">REST API Reference for DescribeLoggingStatus Operation</seealso>
        DescribeLoggingStatusResponse DescribeLoggingStatus(DescribeLoggingStatusRequest request);



        /// <summary>
        /// Describes whether information, such as queries and connection attempts, is being logged
        /// for the specified Amazon Redshift cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoggingStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLoggingStatus service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeLoggingStatus">REST API Reference for DescribeLoggingStatus Operation</seealso>
        Task<DescribeLoggingStatusResponse> DescribeLoggingStatusAsync(DescribeLoggingStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeNodeConfigurationOptions


        /// <summary>
        /// Returns properties of possible node configurations such as node type, number of nodes,
        /// and disk usage for the specified action type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNodeConfigurationOptions service method.</param>
        /// 
        /// <returns>The response from the DescribeNodeConfigurationOptions service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.AccessToSnapshotDeniedException">
        /// The owner of the specified snapshot has not authorized your account to access the
        /// snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSnapshotStateException">
        /// The specified cluster snapshot is not in the <code>available</code> state, or other
        /// accounts are authorized to access the snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeNodeConfigurationOptions">REST API Reference for DescribeNodeConfigurationOptions Operation</seealso>
        DescribeNodeConfigurationOptionsResponse DescribeNodeConfigurationOptions(DescribeNodeConfigurationOptionsRequest request);



        /// <summary>
        /// Returns properties of possible node configurations such as node type, number of nodes,
        /// and disk usage for the specified action type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNodeConfigurationOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNodeConfigurationOptions service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.AccessToSnapshotDeniedException">
        /// The owner of the specified snapshot has not authorized your account to access the
        /// snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSnapshotStateException">
        /// The specified cluster snapshot is not in the <code>available</code> state, or other
        /// accounts are authorized to access the snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeNodeConfigurationOptions">REST API Reference for DescribeNodeConfigurationOptions Operation</seealso>
        Task<DescribeNodeConfigurationOptionsResponse> DescribeNodeConfigurationOptionsAsync(DescribeNodeConfigurationOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeOrderableClusterOptions


        /// <summary>
        /// Returns a list of orderable cluster options. Before you create a new cluster you can
        /// use this operation to find what options are available, such as the EC2 Availability
        /// Zones (AZ) in the specific AWS Region that you can specify, and the node types you
        /// can request. The node types differ by available storage, memory, CPU and price. With
        /// the cost involved you might want to obtain a list of cluster options in the specific
        /// region and specify values when creating a cluster. For more information about managing
        /// clusters, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeOrderableClusterOptions service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeOrderableClusterOptions">REST API Reference for DescribeOrderableClusterOptions Operation</seealso>
        DescribeOrderableClusterOptionsResponse DescribeOrderableClusterOptions();


        /// <summary>
        /// Returns a list of orderable cluster options. Before you create a new cluster you can
        /// use this operation to find what options are available, such as the EC2 Availability
        /// Zones (AZ) in the specific AWS Region that you can specify, and the node types you
        /// can request. The node types differ by available storage, memory, CPU and price. With
        /// the cost involved you might want to obtain a list of cluster options in the specific
        /// region and specify values when creating a cluster. For more information about managing
        /// clusters, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableClusterOptions service method.</param>
        /// 
        /// <returns>The response from the DescribeOrderableClusterOptions service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeOrderableClusterOptions">REST API Reference for DescribeOrderableClusterOptions Operation</seealso>
        DescribeOrderableClusterOptionsResponse DescribeOrderableClusterOptions(DescribeOrderableClusterOptionsRequest request);


        /// <summary>
        /// Returns a list of orderable cluster options. Before you create a new cluster you can
        /// use this operation to find what options are available, such as the EC2 Availability
        /// Zones (AZ) in the specific AWS Region that you can specify, and the node types you
        /// can request. The node types differ by available storage, memory, CPU and price. With
        /// the cost involved you might want to obtain a list of cluster options in the specific
        /// region and specify values when creating a cluster. For more information about managing
        /// clusters, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOrderableClusterOptions service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeOrderableClusterOptions">REST API Reference for DescribeOrderableClusterOptions Operation</seealso>
        Task<DescribeOrderableClusterOptionsResponse> DescribeOrderableClusterOptionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Returns a list of orderable cluster options. Before you create a new cluster you can
        /// use this operation to find what options are available, such as the EC2 Availability
        /// Zones (AZ) in the specific AWS Region that you can specify, and the node types you
        /// can request. The node types differ by available storage, memory, CPU and price. With
        /// the cost involved you might want to obtain a list of cluster options in the specific
        /// region and specify values when creating a cluster. For more information about managing
        /// clusters, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOrderableClusterOptions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOrderableClusterOptions service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeOrderableClusterOptions">REST API Reference for DescribeOrderableClusterOptions Operation</seealso>
        Task<DescribeOrderableClusterOptionsResponse> DescribeOrderableClusterOptionsAsync(DescribeOrderableClusterOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeReservedNodeOfferings


        /// <summary>
        /// Returns a list of the available reserved node offerings by Amazon Redshift with their
        /// descriptions including the node type, the fixed and recurring costs of reserving the
        /// node and duration the node will be reserved for you. These descriptions help you determine
        /// which reserve node offering you want to purchase. You then use the unique offering
        /// ID in you call to <a>PurchaseReservedNodeOffering</a> to reserve one or more nodes
        /// for your Amazon Redshift cluster. 
        /// 
        ///  
        /// <para>
        ///  For more information about reserved node offerings, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/purchase-reserved-node-instance.html">Purchasing
        /// Reserved Nodes</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedNodeOfferings service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceUnavailableException">
        /// Your request cannot be completed because a dependent internal service is temporarily
        /// unavailable. Wait 30 to 60 seconds and try again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeReservedNodeOfferings">REST API Reference for DescribeReservedNodeOfferings Operation</seealso>
        DescribeReservedNodeOfferingsResponse DescribeReservedNodeOfferings();


        /// <summary>
        /// Returns a list of the available reserved node offerings by Amazon Redshift with their
        /// descriptions including the node type, the fixed and recurring costs of reserving the
        /// node and duration the node will be reserved for you. These descriptions help you determine
        /// which reserve node offering you want to purchase. You then use the unique offering
        /// ID in you call to <a>PurchaseReservedNodeOffering</a> to reserve one or more nodes
        /// for your Amazon Redshift cluster. 
        /// 
        ///  
        /// <para>
        ///  For more information about reserved node offerings, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/purchase-reserved-node-instance.html">Purchasing
        /// Reserved Nodes</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedNodeOfferings service method.</param>
        /// 
        /// <returns>The response from the DescribeReservedNodeOfferings service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceUnavailableException">
        /// Your request cannot be completed because a dependent internal service is temporarily
        /// unavailable. Wait 30 to 60 seconds and try again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeReservedNodeOfferings">REST API Reference for DescribeReservedNodeOfferings Operation</seealso>
        DescribeReservedNodeOfferingsResponse DescribeReservedNodeOfferings(DescribeReservedNodeOfferingsRequest request);


        /// <summary>
        /// Returns a list of the available reserved node offerings by Amazon Redshift with their
        /// descriptions including the node type, the fixed and recurring costs of reserving the
        /// node and duration the node will be reserved for you. These descriptions help you determine
        /// which reserve node offering you want to purchase. You then use the unique offering
        /// ID in you call to <a>PurchaseReservedNodeOffering</a> to reserve one or more nodes
        /// for your Amazon Redshift cluster. 
        /// 
        ///  
        /// <para>
        ///  For more information about reserved node offerings, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/purchase-reserved-node-instance.html">Purchasing
        /// Reserved Nodes</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedNodeOfferings service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceUnavailableException">
        /// Your request cannot be completed because a dependent internal service is temporarily
        /// unavailable. Wait 30 to 60 seconds and try again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeReservedNodeOfferings">REST API Reference for DescribeReservedNodeOfferings Operation</seealso>
        Task<DescribeReservedNodeOfferingsResponse> DescribeReservedNodeOfferingsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Returns a list of the available reserved node offerings by Amazon Redshift with their
        /// descriptions including the node type, the fixed and recurring costs of reserving the
        /// node and duration the node will be reserved for you. These descriptions help you determine
        /// which reserve node offering you want to purchase. You then use the unique offering
        /// ID in you call to <a>PurchaseReservedNodeOffering</a> to reserve one or more nodes
        /// for your Amazon Redshift cluster. 
        /// 
        ///  
        /// <para>
        ///  For more information about reserved node offerings, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/purchase-reserved-node-instance.html">Purchasing
        /// Reserved Nodes</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedNodeOfferings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedNodeOfferings service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceUnavailableException">
        /// Your request cannot be completed because a dependent internal service is temporarily
        /// unavailable. Wait 30 to 60 seconds and try again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeReservedNodeOfferings">REST API Reference for DescribeReservedNodeOfferings Operation</seealso>
        Task<DescribeReservedNodeOfferingsResponse> DescribeReservedNodeOfferingsAsync(DescribeReservedNodeOfferingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeReservedNodes


        /// <summary>
        /// Returns the descriptions of the reserved nodes.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedNodes service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceUnavailableException">
        /// Your request cannot be completed because a dependent internal service is temporarily
        /// unavailable. Wait 30 to 60 seconds and try again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeNotFoundException">
        /// The specified reserved compute node not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeReservedNodes">REST API Reference for DescribeReservedNodes Operation</seealso>
        DescribeReservedNodesResponse DescribeReservedNodes();


        /// <summary>
        /// Returns the descriptions of the reserved nodes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedNodes service method.</param>
        /// 
        /// <returns>The response from the DescribeReservedNodes service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceUnavailableException">
        /// Your request cannot be completed because a dependent internal service is temporarily
        /// unavailable. Wait 30 to 60 seconds and try again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeNotFoundException">
        /// The specified reserved compute node not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeReservedNodes">REST API Reference for DescribeReservedNodes Operation</seealso>
        DescribeReservedNodesResponse DescribeReservedNodes(DescribeReservedNodesRequest request);


        /// <summary>
        /// Returns the descriptions of the reserved nodes.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedNodes service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceUnavailableException">
        /// Your request cannot be completed because a dependent internal service is temporarily
        /// unavailable. Wait 30 to 60 seconds and try again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeNotFoundException">
        /// The specified reserved compute node not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeReservedNodes">REST API Reference for DescribeReservedNodes Operation</seealso>
        Task<DescribeReservedNodesResponse> DescribeReservedNodesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));



        /// <summary>
        /// Returns the descriptions of the reserved nodes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedNodes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedNodes service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceUnavailableException">
        /// Your request cannot be completed because a dependent internal service is temporarily
        /// unavailable. Wait 30 to 60 seconds and try again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeNotFoundException">
        /// The specified reserved compute node not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeReservedNodes">REST API Reference for DescribeReservedNodes Operation</seealso>
        Task<DescribeReservedNodesResponse> DescribeReservedNodesAsync(DescribeReservedNodesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeResize


        /// <summary>
        /// Returns information about the last resize operation for the specified cluster. If
        /// no resize operation has ever been initiated for the specified cluster, a <code>HTTP
        /// 404</code> error is returned. If a resize operation was initiated and completed, the
        /// status of the resize remains as <code>SUCCEEDED</code> until the next resize. 
        /// 
        ///  
        /// <para>
        /// A resize operation can be requested using <a>ModifyCluster</a> and specifying a different
        /// number or type of nodes for the cluster. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResize service method.</param>
        /// 
        /// <returns>The response from the DescribeResize service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ResizeNotFoundException">
        /// A resize operation for the specified cluster is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeResize">REST API Reference for DescribeResize Operation</seealso>
        DescribeResizeResponse DescribeResize(DescribeResizeRequest request);



        /// <summary>
        /// Returns information about the last resize operation for the specified cluster. If
        /// no resize operation has ever been initiated for the specified cluster, a <code>HTTP
        /// 404</code> error is returned. If a resize operation was initiated and completed, the
        /// status of the resize remains as <code>SUCCEEDED</code> until the next resize. 
        /// 
        ///  
        /// <para>
        /// A resize operation can be requested using <a>ModifyCluster</a> and specifying a different
        /// number or type of nodes for the cluster. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResize service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeResize service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ResizeNotFoundException">
        /// A resize operation for the specified cluster is not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeResize">REST API Reference for DescribeResize Operation</seealso>
        Task<DescribeResizeResponse> DescribeResizeAsync(DescribeResizeRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeScheduledActions


        /// <summary>
        /// Describes properties of scheduled actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledActions service method.</param>
        /// 
        /// <returns>The response from the DescribeScheduledActions service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ScheduledActionNotFoundException">
        /// The scheduled action cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeScheduledActions">REST API Reference for DescribeScheduledActions Operation</seealso>
        DescribeScheduledActionsResponse DescribeScheduledActions(DescribeScheduledActionsRequest request);



        /// <summary>
        /// Describes properties of scheduled actions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeScheduledActions service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ScheduledActionNotFoundException">
        /// The scheduled action cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeScheduledActions">REST API Reference for DescribeScheduledActions Operation</seealso>
        Task<DescribeScheduledActionsResponse> DescribeScheduledActionsAsync(DescribeScheduledActionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeSnapshotCopyGrants


        /// <summary>
        /// Returns a list of snapshot copy grants owned by the AWS account in the destination
        /// region.
        /// 
        ///  
        /// <para>
        ///  For more information about managing snapshot copy grants, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-db-encryption.html">Amazon
        /// Redshift Database Encryption</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotCopyGrants service method.</param>
        /// 
        /// <returns>The response from the DescribeSnapshotCopyGrants service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotCopyGrantNotFoundException">
        /// The specified snapshot copy grant can't be found. Make sure that the name is typed
        /// correctly and that the grant exists in the destination region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeSnapshotCopyGrants">REST API Reference for DescribeSnapshotCopyGrants Operation</seealso>
        DescribeSnapshotCopyGrantsResponse DescribeSnapshotCopyGrants(DescribeSnapshotCopyGrantsRequest request);



        /// <summary>
        /// Returns a list of snapshot copy grants owned by the AWS account in the destination
        /// region.
        /// 
        ///  
        /// <para>
        ///  For more information about managing snapshot copy grants, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-db-encryption.html">Amazon
        /// Redshift Database Encryption</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotCopyGrants service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSnapshotCopyGrants service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotCopyGrantNotFoundException">
        /// The specified snapshot copy grant can't be found. Make sure that the name is typed
        /// correctly and that the grant exists in the destination region.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeSnapshotCopyGrants">REST API Reference for DescribeSnapshotCopyGrants Operation</seealso>
        Task<DescribeSnapshotCopyGrantsResponse> DescribeSnapshotCopyGrantsAsync(DescribeSnapshotCopyGrantsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeSnapshotSchedules


        /// <summary>
        /// Returns a list of snapshot schedules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotSchedules service method.</param>
        /// 
        /// <returns>The response from the DescribeSnapshotSchedules service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeSnapshotSchedules">REST API Reference for DescribeSnapshotSchedules Operation</seealso>
        DescribeSnapshotSchedulesResponse DescribeSnapshotSchedules(DescribeSnapshotSchedulesRequest request);



        /// <summary>
        /// Returns a list of snapshot schedules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotSchedules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSnapshotSchedules service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeSnapshotSchedules">REST API Reference for DescribeSnapshotSchedules Operation</seealso>
        Task<DescribeSnapshotSchedulesResponse> DescribeSnapshotSchedulesAsync(DescribeSnapshotSchedulesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeStorage


        /// <summary>
        /// Returns account level backups storage size and provisional storage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStorage service method.</param>
        /// 
        /// <returns>The response from the DescribeStorage service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeStorage">REST API Reference for DescribeStorage Operation</seealso>
        DescribeStorageResponse DescribeStorage(DescribeStorageRequest request);



        /// <summary>
        /// Returns account level backups storage size and provisional storage.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStorage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeStorage service method, as returned by Redshift.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeStorage">REST API Reference for DescribeStorage Operation</seealso>
        Task<DescribeStorageResponse> DescribeStorageAsync(DescribeStorageRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeTableRestoreStatus


        /// <summary>
        /// Lists the status of one or more table restore requests made using the <a>RestoreTableFromClusterSnapshot</a>
        /// API action. If you don't specify a value for the <code>TableRestoreRequestId</code>
        /// parameter, then <code>DescribeTableRestoreStatus</code> returns the status of all
        /// table restore requests ordered by the date and time of the request in ascending order.
        /// Otherwise <code>DescribeTableRestoreStatus</code> returns the status of the table
        /// specified by <code>TableRestoreRequestId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTableRestoreStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeTableRestoreStatus service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TableRestoreNotFoundException">
        /// The specified <code>TableRestoreRequestId</code> value was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeTableRestoreStatus">REST API Reference for DescribeTableRestoreStatus Operation</seealso>
        DescribeTableRestoreStatusResponse DescribeTableRestoreStatus(DescribeTableRestoreStatusRequest request);



        /// <summary>
        /// Lists the status of one or more table restore requests made using the <a>RestoreTableFromClusterSnapshot</a>
        /// API action. If you don't specify a value for the <code>TableRestoreRequestId</code>
        /// parameter, then <code>DescribeTableRestoreStatus</code> returns the status of all
        /// table restore requests ordered by the date and time of the request in ascending order.
        /// Otherwise <code>DescribeTableRestoreStatus</code> returns the status of the table
        /// specified by <code>TableRestoreRequestId</code>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTableRestoreStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTableRestoreStatus service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TableRestoreNotFoundException">
        /// The specified <code>TableRestoreRequestId</code> value was not found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeTableRestoreStatus">REST API Reference for DescribeTableRestoreStatus Operation</seealso>
        Task<DescribeTableRestoreStatusResponse> DescribeTableRestoreStatusAsync(DescribeTableRestoreStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeTags


        /// <summary>
        /// Returns a list of tags. You can return tags from a specific resource by specifying
        /// an ARN, or you can return all tags for a given type of resource, such as clusters,
        /// snapshots, and so on.
        /// 
        ///  
        /// <para>
        /// The following are limitations for <code>DescribeTags</code>: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You cannot specify an ARN and a resource-type value together in the same request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot use the <code>MaxRecords</code> and <code>Marker</code> parameters together
        /// with the ARN parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>MaxRecords</code> parameter can be a range from 10 to 50 results to return
        /// in a request.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all resources that match any combination of the specified keys and values. For example,
        /// if you have <code>owner</code> and <code>environment</code> for tag keys, and <code>admin</code>
        /// and <code>test</code> for tag values, all resources that have any combination of those
        /// values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, resources are returned regardless
        /// of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method.</param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        DescribeTagsResponse DescribeTags(DescribeTagsRequest request);



        /// <summary>
        /// Returns a list of tags. You can return tags from a specific resource by specifying
        /// an ARN, or you can return all tags for a given type of resource, such as clusters,
        /// snapshots, and so on.
        /// 
        ///  
        /// <para>
        /// The following are limitations for <code>DescribeTags</code>: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You cannot specify an ARN and a resource-type value together in the same request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You cannot use the <code>MaxRecords</code> and <code>Marker</code> parameters together
        /// with the ARN parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>MaxRecords</code> parameter can be a range from 10 to 50 results to return
        /// in a request.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you specify both tag keys and tag values in the same request, Amazon Redshift returns
        /// all resources that match any combination of the specified keys and values. For example,
        /// if you have <code>owner</code> and <code>environment</code> for tag keys, and <code>admin</code>
        /// and <code>test</code> for tag values, all resources that have any combination of those
        /// values are returned.
        /// </para>
        ///  
        /// <para>
        /// If both tag keys and values are omitted from the request, resources are returned regardless
        /// of whether they have tag keys or values associated with them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisableLogging


        /// <summary>
        /// Stops logging information, such as queries and connection attempts, for the specified
        /// Amazon Redshift cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableLogging service method.</param>
        /// 
        /// <returns>The response from the DisableLogging service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DisableLogging">REST API Reference for DisableLogging Operation</seealso>
        DisableLoggingResponse DisableLogging(DisableLoggingRequest request);



        /// <summary>
        /// Stops logging information, such as queries and connection attempts, for the specified
        /// Amazon Redshift cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableLogging service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableLogging service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DisableLogging">REST API Reference for DisableLogging Operation</seealso>
        Task<DisableLoggingResponse> DisableLoggingAsync(DisableLoggingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisableSnapshotCopy


        /// <summary>
        /// Disables the automatic copying of snapshots from one region to another region for
        /// a specified cluster.
        /// 
        ///  
        /// <para>
        /// If your cluster and its snapshots are encrypted using a customer master key (CMK)
        /// from AWS KMS, use <a>DeleteSnapshotCopyGrant</a> to delete the grant that grants Amazon
        /// Redshift permission to the CMK in the destination region. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableSnapshotCopy service method.</param>
        /// 
        /// <returns>The response from the DisableSnapshotCopy service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotCopyAlreadyDisabledException">
        /// The cluster already has cross-region snapshot copy disabled.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DisableSnapshotCopy">REST API Reference for DisableSnapshotCopy Operation</seealso>
        DisableSnapshotCopyResponse DisableSnapshotCopy(DisableSnapshotCopyRequest request);



        /// <summary>
        /// Disables the automatic copying of snapshots from one region to another region for
        /// a specified cluster.
        /// 
        ///  
        /// <para>
        /// If your cluster and its snapshots are encrypted using a customer master key (CMK)
        /// from AWS KMS, use <a>DeleteSnapshotCopyGrant</a> to delete the grant that grants Amazon
        /// Redshift permission to the CMK in the destination region. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableSnapshotCopy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableSnapshotCopy service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotCopyAlreadyDisabledException">
        /// The cluster already has cross-region snapshot copy disabled.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/DisableSnapshotCopy">REST API Reference for DisableSnapshotCopy Operation</seealso>
        Task<DisableSnapshotCopyResponse> DisableSnapshotCopyAsync(DisableSnapshotCopyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  EnableLogging


        /// <summary>
        /// Starts logging information, such as queries and connection attempts, for the specified
        /// Amazon Redshift cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableLogging service method.</param>
        /// 
        /// <returns>The response from the EnableLogging service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.BucketNotFoundException">
        /// Could not find the specified S3 bucket.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InsufficientS3BucketPolicyException">
        /// The cluster does not have read bucket or put object permissions on the S3 bucket specified
        /// when enabling logging.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidS3BucketNameException">
        /// The S3 bucket name is invalid. For more information about naming rules, go to <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/BucketRestrictions.html">Bucket
        /// Restrictions and Limitations</a> in the Amazon Simple Storage Service (S3) Developer
        /// Guide.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidS3KeyPrefixException">
        /// The string specified for the logging S3 key prefix does not comply with the documented
        /// constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/EnableLogging">REST API Reference for EnableLogging Operation</seealso>
        EnableLoggingResponse EnableLogging(EnableLoggingRequest request);



        /// <summary>
        /// Starts logging information, such as queries and connection attempts, for the specified
        /// Amazon Redshift cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableLogging service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableLogging service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.BucketNotFoundException">
        /// Could not find the specified S3 bucket.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InsufficientS3BucketPolicyException">
        /// The cluster does not have read bucket or put object permissions on the S3 bucket specified
        /// when enabling logging.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidS3BucketNameException">
        /// The S3 bucket name is invalid. For more information about naming rules, go to <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/BucketRestrictions.html">Bucket
        /// Restrictions and Limitations</a> in the Amazon Simple Storage Service (S3) Developer
        /// Guide.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidS3KeyPrefixException">
        /// The string specified for the logging S3 key prefix does not comply with the documented
        /// constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/EnableLogging">REST API Reference for EnableLogging Operation</seealso>
        Task<EnableLoggingResponse> EnableLoggingAsync(EnableLoggingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  EnableSnapshotCopy


        /// <summary>
        /// Enables the automatic copy of snapshots from one region to another region for a specified
        /// cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableSnapshotCopy service method.</param>
        /// 
        /// <returns>The response from the EnableSnapshotCopy service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.CopyToRegionDisabledException">
        /// Cross-region snapshot copy was temporarily disabled. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceRequestThrottlingException">
        /// The request cannot be completed because a dependent service is throttling requests
        /// made by Amazon Redshift on your behalf. Wait and retry the request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.IncompatibleOrderableOptionsException">
        /// The specified options are incompatible.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidRetentionPeriodException">
        /// The retention period specified is either in the past or is not a valid value.
        /// 
        ///  
        /// <para>
        /// The value must be either -1 or an integer between 1 and 3,653.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.LimitExceededException">
        /// The encryption key has exceeded its grant limit in AWS KMS.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotCopyAlreadyEnabledException">
        /// The cluster already has cross-region snapshot copy enabled.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotCopyGrantNotFoundException">
        /// The specified snapshot copy grant can't be found. Make sure that the name is typed
        /// correctly and that the grant exists in the destination region.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnknownSnapshotCopyRegionException">
        /// The specified region is incorrect or does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/EnableSnapshotCopy">REST API Reference for EnableSnapshotCopy Operation</seealso>
        EnableSnapshotCopyResponse EnableSnapshotCopy(EnableSnapshotCopyRequest request);



        /// <summary>
        /// Enables the automatic copy of snapshots from one region to another region for a specified
        /// cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableSnapshotCopy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableSnapshotCopy service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.CopyToRegionDisabledException">
        /// Cross-region snapshot copy was temporarily disabled. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceRequestThrottlingException">
        /// The request cannot be completed because a dependent service is throttling requests
        /// made by Amazon Redshift on your behalf. Wait and retry the request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.IncompatibleOrderableOptionsException">
        /// The specified options are incompatible.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidRetentionPeriodException">
        /// The retention period specified is either in the past or is not a valid value.
        /// 
        ///  
        /// <para>
        /// The value must be either -1 or an integer between 1 and 3,653.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.LimitExceededException">
        /// The encryption key has exceeded its grant limit in AWS KMS.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotCopyAlreadyEnabledException">
        /// The cluster already has cross-region snapshot copy enabled.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotCopyGrantNotFoundException">
        /// The specified snapshot copy grant can't be found. Make sure that the name is typed
        /// correctly and that the grant exists in the destination region.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnknownSnapshotCopyRegionException">
        /// The specified region is incorrect or does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/EnableSnapshotCopy">REST API Reference for EnableSnapshotCopy Operation</seealso>
        Task<EnableSnapshotCopyResponse> EnableSnapshotCopyAsync(EnableSnapshotCopyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetClusterCredentials


        /// <summary>
        /// Returns a database user name and temporary password with temporary authorization to
        /// log on to an Amazon Redshift database. The action returns the database user name prefixed
        /// with <code>IAM:</code> if <code>AutoCreate</code> is <code>False</code> or <code>IAMA:</code>
        /// if <code>AutoCreate</code> is <code>True</code>. You can optionally specify one or
        /// more database user groups that the user will join at log on. By default, the temporary
        /// credentials expire in 900 seconds. You can optionally specify a duration between 900
        /// seconds (15 minutes) and 3600 seconds (60 minutes). For more information, see <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/generating-user-credentials.html">Using
        /// IAM Authentication to Generate Database User Credentials</a> in the Amazon Redshift
        /// Cluster Management Guide.
        /// 
        ///  
        /// <para>
        /// The AWS Identity and Access Management (IAM)user or role that executes GetClusterCredentials
        /// must have an IAM policy attached that allows access to all necessary actions and resources.
        /// For more information about permissions, see <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/redshift-iam-access-control-identity-based.html#redshift-policy-resources.getclustercredentials-resources">Resource
        /// Policies for GetClusterCredentials</a> in the Amazon Redshift Cluster Management Guide.
        /// </para>
        ///  
        /// <para>
        /// If the <code>DbGroups</code> parameter is specified, the IAM policy must allow the
        /// <code>redshift:JoinGroup</code> action with access to the listed <code>dbgroups</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// In addition, if the <code>AutoCreate</code> parameter is set to <code>True</code>,
        /// then the policy must include the <code>redshift:CreateClusterUser</code> privilege.
        /// </para>
        ///  
        /// <para>
        /// If the <code>DbName</code> parameter is specified, the IAM policy must allow access
        /// to the resource <code>dbname</code> for the specified database name. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClusterCredentials service method.</param>
        /// 
        /// <returns>The response from the GetClusterCredentials service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/GetClusterCredentials">REST API Reference for GetClusterCredentials Operation</seealso>
        GetClusterCredentialsResponse GetClusterCredentials(GetClusterCredentialsRequest request);



        /// <summary>
        /// Returns a database user name and temporary password with temporary authorization to
        /// log on to an Amazon Redshift database. The action returns the database user name prefixed
        /// with <code>IAM:</code> if <code>AutoCreate</code> is <code>False</code> or <code>IAMA:</code>
        /// if <code>AutoCreate</code> is <code>True</code>. You can optionally specify one or
        /// more database user groups that the user will join at log on. By default, the temporary
        /// credentials expire in 900 seconds. You can optionally specify a duration between 900
        /// seconds (15 minutes) and 3600 seconds (60 minutes). For more information, see <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/generating-user-credentials.html">Using
        /// IAM Authentication to Generate Database User Credentials</a> in the Amazon Redshift
        /// Cluster Management Guide.
        /// 
        ///  
        /// <para>
        /// The AWS Identity and Access Management (IAM)user or role that executes GetClusterCredentials
        /// must have an IAM policy attached that allows access to all necessary actions and resources.
        /// For more information about permissions, see <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/redshift-iam-access-control-identity-based.html#redshift-policy-resources.getclustercredentials-resources">Resource
        /// Policies for GetClusterCredentials</a> in the Amazon Redshift Cluster Management Guide.
        /// </para>
        ///  
        /// <para>
        /// If the <code>DbGroups</code> parameter is specified, the IAM policy must allow the
        /// <code>redshift:JoinGroup</code> action with access to the listed <code>dbgroups</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// In addition, if the <code>AutoCreate</code> parameter is set to <code>True</code>,
        /// then the policy must include the <code>redshift:CreateClusterUser</code> privilege.
        /// </para>
        ///  
        /// <para>
        /// If the <code>DbName</code> parameter is specified, the IAM policy must allow access
        /// to the resource <code>dbname</code> for the specified database name. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetClusterCredentials service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetClusterCredentials service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/GetClusterCredentials">REST API Reference for GetClusterCredentials Operation</seealso>
        Task<GetClusterCredentialsResponse> GetClusterCredentialsAsync(GetClusterCredentialsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetReservedNodeExchangeOfferings


        /// <summary>
        /// Returns an array of DC2 ReservedNodeOfferings that matches the payment type, term,
        /// and usage price of the given DC1 reserved node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReservedNodeExchangeOfferings service method.</param>
        /// 
        /// <returns>The response from the GetReservedNodeExchangeOfferings service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceUnavailableException">
        /// Your request cannot be completed because a dependent internal service is temporarily
        /// unavailable. Wait 30 to 60 seconds and try again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidReservedNodeStateException">
        /// Indicates that the Reserved Node being exchanged is not in an active state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeAlreadyMigratedException">
        /// Indicates that the reserved node has already been exchanged.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeNotFoundException">
        /// The specified reserved compute node not found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/GetReservedNodeExchangeOfferings">REST API Reference for GetReservedNodeExchangeOfferings Operation</seealso>
        GetReservedNodeExchangeOfferingsResponse GetReservedNodeExchangeOfferings(GetReservedNodeExchangeOfferingsRequest request);



        /// <summary>
        /// Returns an array of DC2 ReservedNodeOfferings that matches the payment type, term,
        /// and usage price of the given DC1 reserved node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReservedNodeExchangeOfferings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetReservedNodeExchangeOfferings service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceUnavailableException">
        /// Your request cannot be completed because a dependent internal service is temporarily
        /// unavailable. Wait 30 to 60 seconds and try again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidReservedNodeStateException">
        /// Indicates that the Reserved Node being exchanged is not in an active state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeAlreadyMigratedException">
        /// Indicates that the reserved node has already been exchanged.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeNotFoundException">
        /// The specified reserved compute node not found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/GetReservedNodeExchangeOfferings">REST API Reference for GetReservedNodeExchangeOfferings Operation</seealso>
        Task<GetReservedNodeExchangeOfferingsResponse> GetReservedNodeExchangeOfferingsAsync(GetReservedNodeExchangeOfferingsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifyCluster


        /// <summary>
        /// Modifies the settings for a cluster.
        /// 
        ///  
        /// <para>
        /// You can also change node type and the number of nodes to scale up or down the cluster.
        /// When resizing a cluster, you must specify both the number of nodes and the node type
        /// even if one of the parameters does not change.
        /// </para>
        ///  
        /// <para>
        /// You can add another security or parameter group, or change the master user password.
        /// Resetting a cluster password or modifying the security groups associated with a cluster
        /// do not need a reboot. However, modifying a parameter group requires a reboot for parameters
        /// to take effect. For more information about managing clusters, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyCluster service method.</param>
        /// 
        /// <returns>The response from the ModifyCluster service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterAlreadyExistsException">
        /// The account already has a cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceRequestThrottlingException">
        /// The request cannot be completed because a dependent service is throttling requests
        /// made by Amazon Redshift on your behalf. Wait and retry the request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.HsmClientCertificateNotFoundException">
        /// There is no Amazon Redshift HSM client certificate with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.HsmConfigurationNotFoundException">
        /// There is no Amazon Redshift HSM configuration with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InsufficientClusterCapacityException">
        /// The number of nodes specified exceeds the allotted capacity of the cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSecurityGroupStateException">
        /// The state of the cluster security group is not <code>available</code>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterTrackException">
        /// The provided cluster track name is not valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidElasticIpException">
        /// The Elastic IP (EIP) is invalid or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidRetentionPeriodException">
        /// The retention period specified is either in the past or is not a valid value.
        /// 
        ///  
        /// <para>
        /// The value must be either -1 or an integer between 1 and 3,653.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.LimitExceededException">
        /// The encryption key has exceeded its grant limit in AWS KMS.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.NumberOfNodesPerClusterLimitExceededException">
        /// The operation would exceed the number of nodes allowed for a cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.NumberOfNodesQuotaExceededException">
        /// The operation would exceed the number of nodes allotted to the account. For information
        /// about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TableLimitExceededException">
        /// The number of tables in the cluster exceeds the limit for the requested new cluster
        /// node type.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOptionException">
        /// A request option was specified that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyCluster">REST API Reference for ModifyCluster Operation</seealso>
        ModifyClusterResponse ModifyCluster(ModifyClusterRequest request);



        /// <summary>
        /// Modifies the settings for a cluster.
        /// 
        ///  
        /// <para>
        /// You can also change node type and the number of nodes to scale up or down the cluster.
        /// When resizing a cluster, you must specify both the number of nodes and the node type
        /// even if one of the parameters does not change.
        /// </para>
        ///  
        /// <para>
        /// You can add another security or parameter group, or change the master user password.
        /// Resetting a cluster password or modifying the security groups associated with a cluster
        /// do not need a reboot. However, modifying a parameter group requires a reboot for parameters
        /// to take effect. For more information about managing clusters, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyCluster service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterAlreadyExistsException">
        /// The account already has a cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceRequestThrottlingException">
        /// The request cannot be completed because a dependent service is throttling requests
        /// made by Amazon Redshift on your behalf. Wait and retry the request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.HsmClientCertificateNotFoundException">
        /// There is no Amazon Redshift HSM client certificate with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.HsmConfigurationNotFoundException">
        /// There is no Amazon Redshift HSM configuration with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InsufficientClusterCapacityException">
        /// The number of nodes specified exceeds the allotted capacity of the cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSecurityGroupStateException">
        /// The state of the cluster security group is not <code>available</code>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterTrackException">
        /// The provided cluster track name is not valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidElasticIpException">
        /// The Elastic IP (EIP) is invalid or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidRetentionPeriodException">
        /// The retention period specified is either in the past or is not a valid value.
        /// 
        ///  
        /// <para>
        /// The value must be either -1 or an integer between 1 and 3,653.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.LimitExceededException">
        /// The encryption key has exceeded its grant limit in AWS KMS.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.NumberOfNodesPerClusterLimitExceededException">
        /// The operation would exceed the number of nodes allowed for a cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.NumberOfNodesQuotaExceededException">
        /// The operation would exceed the number of nodes allotted to the account. For information
        /// about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TableLimitExceededException">
        /// The number of tables in the cluster exceeds the limit for the requested new cluster
        /// node type.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOptionException">
        /// A request option was specified that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyCluster">REST API Reference for ModifyCluster Operation</seealso>
        Task<ModifyClusterResponse> ModifyClusterAsync(ModifyClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifyClusterDbRevision


        /// <summary>
        /// Modifies the database revision of a cluster. The database revision is a unique revision
        /// of the database running in a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterDbRevision service method.</param>
        /// 
        /// <returns>The response from the ModifyClusterDbRevision service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterOnLatestRevisionException">
        /// Cluster is already on the latest database revision.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterDbRevision">REST API Reference for ModifyClusterDbRevision Operation</seealso>
        ModifyClusterDbRevisionResponse ModifyClusterDbRevision(ModifyClusterDbRevisionRequest request);



        /// <summary>
        /// Modifies the database revision of a cluster. The database revision is a unique revision
        /// of the database running in a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterDbRevision service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyClusterDbRevision service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterOnLatestRevisionException">
        /// Cluster is already on the latest database revision.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterDbRevision">REST API Reference for ModifyClusterDbRevision Operation</seealso>
        Task<ModifyClusterDbRevisionResponse> ModifyClusterDbRevisionAsync(ModifyClusterDbRevisionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifyClusterIamRoles


        /// <summary>
        /// Modifies the list of AWS Identity and Access Management (IAM) roles that can be used
        /// by the cluster to access other AWS services.
        /// 
        ///  
        /// <para>
        /// A cluster can have up to 10 IAM roles associated at any time.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterIamRoles service method.</param>
        /// 
        /// <returns>The response from the ModifyClusterIamRoles service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterIamRoles">REST API Reference for ModifyClusterIamRoles Operation</seealso>
        ModifyClusterIamRolesResponse ModifyClusterIamRoles(ModifyClusterIamRolesRequest request);



        /// <summary>
        /// Modifies the list of AWS Identity and Access Management (IAM) roles that can be used
        /// by the cluster to access other AWS services.
        /// 
        ///  
        /// <para>
        /// A cluster can have up to 10 IAM roles associated at any time.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterIamRoles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyClusterIamRoles service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterIamRoles">REST API Reference for ModifyClusterIamRoles Operation</seealso>
        Task<ModifyClusterIamRolesResponse> ModifyClusterIamRolesAsync(ModifyClusterIamRolesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifyClusterMaintenance


        /// <summary>
        /// Modifies the maintenance settings of a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterMaintenance service method.</param>
        /// 
        /// <returns>The response from the ModifyClusterMaintenance service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterMaintenance">REST API Reference for ModifyClusterMaintenance Operation</seealso>
        ModifyClusterMaintenanceResponse ModifyClusterMaintenance(ModifyClusterMaintenanceRequest request);



        /// <summary>
        /// Modifies the maintenance settings of a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterMaintenance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyClusterMaintenance service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterMaintenance">REST API Reference for ModifyClusterMaintenance Operation</seealso>
        Task<ModifyClusterMaintenanceResponse> ModifyClusterMaintenanceAsync(ModifyClusterMaintenanceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifyClusterParameterGroup


        /// <summary>
        /// Modifies the parameters of a parameter group.
        /// 
        ///  
        /// <para>
        ///  For more information about parameters and parameter groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyClusterParameterGroup service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterParameterGroupStateException">
        /// The cluster parameter group action can not be completed because another task is in
        /// progress that involves the parameter group. Wait a few moments and try the operation
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterParameterGroup">REST API Reference for ModifyClusterParameterGroup Operation</seealso>
        ModifyClusterParameterGroupResponse ModifyClusterParameterGroup(ModifyClusterParameterGroupRequest request);



        /// <summary>
        /// Modifies the parameters of a parameter group.
        /// 
        ///  
        /// <para>
        ///  For more information about parameters and parameter groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-parameter-groups.html">Amazon
        /// Redshift Parameter Groups</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyClusterParameterGroup service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterParameterGroupStateException">
        /// The cluster parameter group action can not be completed because another task is in
        /// progress that involves the parameter group. Wait a few moments and try the operation
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterParameterGroup">REST API Reference for ModifyClusterParameterGroup Operation</seealso>
        Task<ModifyClusterParameterGroupResponse> ModifyClusterParameterGroupAsync(ModifyClusterParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifyClusterSnapshot


        /// <summary>
        /// Modifies the settings for a snapshot.
        /// 
        ///  
        /// <para>
        /// This exanmple modifies the manual retention period setting for a cluster snapshot.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the ModifyClusterSnapshot service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSnapshotStateException">
        /// The specified cluster snapshot is not in the <code>available</code> state, or other
        /// accounts are authorized to access the snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidRetentionPeriodException">
        /// The retention period specified is either in the past or is not a valid value.
        /// 
        ///  
        /// <para>
        /// The value must be either -1 or an integer between 1 and 3,653.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterSnapshot">REST API Reference for ModifyClusterSnapshot Operation</seealso>
        ModifyClusterSnapshotResponse ModifyClusterSnapshot(ModifyClusterSnapshotRequest request);



        /// <summary>
        /// Modifies the settings for a snapshot.
        /// 
        ///  
        /// <para>
        /// This exanmple modifies the manual retention period setting for a cluster snapshot.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyClusterSnapshot service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSnapshotStateException">
        /// The specified cluster snapshot is not in the <code>available</code> state, or other
        /// accounts are authorized to access the snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidRetentionPeriodException">
        /// The retention period specified is either in the past or is not a valid value.
        /// 
        ///  
        /// <para>
        /// The value must be either -1 or an integer between 1 and 3,653.
        /// </para>
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterSnapshot">REST API Reference for ModifyClusterSnapshot Operation</seealso>
        Task<ModifyClusterSnapshotResponse> ModifyClusterSnapshotAsync(ModifyClusterSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifyClusterSnapshotSchedule


        /// <summary>
        /// Modifies a snapshot schedule for a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterSnapshotSchedule service method.</param>
        /// 
        /// <returns>The response from the ModifyClusterSnapshotSchedule service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSnapshotScheduleStateException">
        /// The cluster snapshot schedule state is not valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotScheduleNotFoundException">
        /// We could not find the specified snapshot schedule.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterSnapshotSchedule">REST API Reference for ModifyClusterSnapshotSchedule Operation</seealso>
        ModifyClusterSnapshotScheduleResponse ModifyClusterSnapshotSchedule(ModifyClusterSnapshotScheduleRequest request);



        /// <summary>
        /// Modifies a snapshot schedule for a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterSnapshotSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyClusterSnapshotSchedule service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSnapshotScheduleStateException">
        /// The cluster snapshot schedule state is not valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotScheduleNotFoundException">
        /// We could not find the specified snapshot schedule.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterSnapshotSchedule">REST API Reference for ModifyClusterSnapshotSchedule Operation</seealso>
        Task<ModifyClusterSnapshotScheduleResponse> ModifyClusterSnapshotScheduleAsync(ModifyClusterSnapshotScheduleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifyClusterSubnetGroup


        /// <summary>
        /// Modifies a cluster subnet group to include the specified list of VPC subnets. The
        /// operation replaces the existing list of subnets with the new list of subnets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterSubnetGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyClusterSubnetGroup service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetQuotaExceededException">
        /// The request would result in user exceeding the allowed number of subnets in a cluster
        /// subnet groups. For information about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceRequestThrottlingException">
        /// The request cannot be completed because a dependent service is throttling requests
        /// made by Amazon Redshift on your behalf. Wait and retry the request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidSubnetException">
        /// The requested subnet is not valid, or not all of the subnets are in the same VPC.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubnetAlreadyInUseException">
        /// A specified subnet is already in use by another cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterSubnetGroup">REST API Reference for ModifyClusterSubnetGroup Operation</seealso>
        ModifyClusterSubnetGroupResponse ModifyClusterSubnetGroup(ModifyClusterSubnetGroupRequest request);



        /// <summary>
        /// Modifies a cluster subnet group to include the specified list of VPC subnets. The
        /// operation replaces the existing list of subnets with the new list of subnets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyClusterSubnetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyClusterSubnetGroup service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetQuotaExceededException">
        /// The request would result in user exceeding the allowed number of subnets in a cluster
        /// subnet groups. For information about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceRequestThrottlingException">
        /// The request cannot be completed because a dependent service is throttling requests
        /// made by Amazon Redshift on your behalf. Wait and retry the request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidSubnetException">
        /// The requested subnet is not valid, or not all of the subnets are in the same VPC.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubnetAlreadyInUseException">
        /// A specified subnet is already in use by another cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyClusterSubnetGroup">REST API Reference for ModifyClusterSubnetGroup Operation</seealso>
        Task<ModifyClusterSubnetGroupResponse> ModifyClusterSubnetGroupAsync(ModifyClusterSubnetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifyEventSubscription


        /// <summary>
        /// Modifies an existing Amazon Redshift event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyEventSubscription service method.</param>
        /// 
        /// <returns>The response from the ModifyEventSubscription service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidSubscriptionStateException">
        /// The subscription request is invalid because it is a duplicate request. This subscription
        /// request is already in progress.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SNSInvalidTopicException">
        /// Amazon SNS has responded that there is a problem with the specified Amazon SNS topic.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SNSNoAuthorizationException">
        /// You do not have permission to publish to the specified Amazon SNS topic.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SNSTopicArnNotFoundException">
        /// An Amazon SNS topic with the specified Amazon Resource Name (ARN) does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SourceNotFoundException">
        /// The specified Amazon Redshift event source could not be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionCategoryNotFoundException">
        /// The value specified for the event category was not one of the allowed values, or it
        /// specified a category that does not apply to the specified source type. The allowed
        /// values are Configuration, Management, Monitoring, and Security.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionEventIdNotFoundException">
        /// An Amazon Redshift event with the specified event ID does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionNotFoundException">
        /// An Amazon Redshift event notification subscription with the specified name does not
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionSeverityNotFoundException">
        /// The value specified for the event severity was not one of the allowed values, or it
        /// specified a severity that does not apply to the specified source type. The allowed
        /// values are ERROR and INFO.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyEventSubscription">REST API Reference for ModifyEventSubscription Operation</seealso>
        ModifyEventSubscriptionResponse ModifyEventSubscription(ModifyEventSubscriptionRequest request);



        /// <summary>
        /// Modifies an existing Amazon Redshift event notification subscription.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyEventSubscription service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyEventSubscription service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidSubscriptionStateException">
        /// The subscription request is invalid because it is a duplicate request. This subscription
        /// request is already in progress.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SNSInvalidTopicException">
        /// Amazon SNS has responded that there is a problem with the specified Amazon SNS topic.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SNSNoAuthorizationException">
        /// You do not have permission to publish to the specified Amazon SNS topic.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SNSTopicArnNotFoundException">
        /// An Amazon SNS topic with the specified Amazon Resource Name (ARN) does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SourceNotFoundException">
        /// The specified Amazon Redshift event source could not be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionCategoryNotFoundException">
        /// The value specified for the event category was not one of the allowed values, or it
        /// specified a category that does not apply to the specified source type. The allowed
        /// values are Configuration, Management, Monitoring, and Security.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionEventIdNotFoundException">
        /// An Amazon Redshift event with the specified event ID does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionNotFoundException">
        /// An Amazon Redshift event notification subscription with the specified name does not
        /// exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SubscriptionSeverityNotFoundException">
        /// The value specified for the event severity was not one of the allowed values, or it
        /// specified a severity that does not apply to the specified source type. The allowed
        /// values are ERROR and INFO.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyEventSubscription">REST API Reference for ModifyEventSubscription Operation</seealso>
        Task<ModifyEventSubscriptionResponse> ModifyEventSubscriptionAsync(ModifyEventSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifyScheduledAction


        /// <summary>
        /// Modifies a scheduled action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyScheduledAction service method.</param>
        /// 
        /// <returns>The response from the ModifyScheduledAction service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidScheduledActionException">
        /// The scheduled action is not valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidScheduleException">
        /// The schedule you submitted isn't valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ScheduledActionNotFoundException">
        /// The scheduled action cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ScheduledActionTypeUnsupportedException">
        /// The action type specified for a scheduled action is not supported.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyScheduledAction">REST API Reference for ModifyScheduledAction Operation</seealso>
        ModifyScheduledActionResponse ModifyScheduledAction(ModifyScheduledActionRequest request);



        /// <summary>
        /// Modifies a scheduled action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyScheduledAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyScheduledAction service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidScheduledActionException">
        /// The scheduled action is not valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidScheduleException">
        /// The schedule you submitted isn't valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ScheduledActionNotFoundException">
        /// The scheduled action cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ScheduledActionTypeUnsupportedException">
        /// The action type specified for a scheduled action is not supported.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifyScheduledAction">REST API Reference for ModifyScheduledAction Operation</seealso>
        Task<ModifyScheduledActionResponse> ModifyScheduledActionAsync(ModifyScheduledActionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifySnapshotCopyRetentionPeriod


        /// <summary>
        /// Modifies the number of days to retain snapshots in the destination AWS Region after
        /// they are copied from the source AWS Region. By default, this operation only changes
        /// the retention period of copied automated snapshots. The retention periods for both
        /// new and existing copied automated snapshots are updated with the new retention period.
        /// You can set the manual option to change only the retention periods of copied manual
        /// snapshots. If you set this option, only newly copied manual snapshots have the new
        /// retention period.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifySnapshotCopyRetentionPeriod service method.</param>
        /// 
        /// <returns>The response from the ModifySnapshotCopyRetentionPeriod service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidRetentionPeriodException">
        /// The retention period specified is either in the past or is not a valid value.
        /// 
        ///  
        /// <para>
        /// The value must be either -1 or an integer between 1 and 3,653.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotCopyDisabledException">
        /// Cross-region snapshot copy was temporarily disabled. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifySnapshotCopyRetentionPeriod">REST API Reference for ModifySnapshotCopyRetentionPeriod Operation</seealso>
        ModifySnapshotCopyRetentionPeriodResponse ModifySnapshotCopyRetentionPeriod(ModifySnapshotCopyRetentionPeriodRequest request);



        /// <summary>
        /// Modifies the number of days to retain snapshots in the destination AWS Region after
        /// they are copied from the source AWS Region. By default, this operation only changes
        /// the retention period of copied automated snapshots. The retention periods for both
        /// new and existing copied automated snapshots are updated with the new retention period.
        /// You can set the manual option to change only the retention periods of copied manual
        /// snapshots. If you set this option, only newly copied manual snapshots have the new
        /// retention period.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifySnapshotCopyRetentionPeriod service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifySnapshotCopyRetentionPeriod service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidRetentionPeriodException">
        /// The retention period specified is either in the past or is not a valid value.
        /// 
        ///  
        /// <para>
        /// The value must be either -1 or an integer between 1 and 3,653.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotCopyDisabledException">
        /// Cross-region snapshot copy was temporarily disabled. Try your request again.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifySnapshotCopyRetentionPeriod">REST API Reference for ModifySnapshotCopyRetentionPeriod Operation</seealso>
        Task<ModifySnapshotCopyRetentionPeriodResponse> ModifySnapshotCopyRetentionPeriodAsync(ModifySnapshotCopyRetentionPeriodRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifySnapshotSchedule


        /// <summary>
        /// Modifies a snapshot schedule. Any schedule associated with a cluster is modified asynchronously.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifySnapshotSchedule service method.</param>
        /// 
        /// <returns>The response from the ModifySnapshotSchedule service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidScheduleException">
        /// The schedule you submitted isn't valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotScheduleNotFoundException">
        /// We could not find the specified snapshot schedule.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotScheduleUpdateInProgressException">
        /// The specified snapshot schedule is already being updated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifySnapshotSchedule">REST API Reference for ModifySnapshotSchedule Operation</seealso>
        ModifySnapshotScheduleResponse ModifySnapshotSchedule(ModifySnapshotScheduleRequest request);



        /// <summary>
        /// Modifies a snapshot schedule. Any schedule associated with a cluster is modified asynchronously.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifySnapshotSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifySnapshotSchedule service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.InvalidScheduleException">
        /// The schedule you submitted isn't valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotScheduleNotFoundException">
        /// We could not find the specified snapshot schedule.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotScheduleUpdateInProgressException">
        /// The specified snapshot schedule is already being updated.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ModifySnapshotSchedule">REST API Reference for ModifySnapshotSchedule Operation</seealso>
        Task<ModifySnapshotScheduleResponse> ModifySnapshotScheduleAsync(ModifySnapshotScheduleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PauseCluster


        /// <summary>
        /// Pauses a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PauseCluster service method.</param>
        /// 
        /// <returns>The response from the PauseCluster service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/PauseCluster">REST API Reference for PauseCluster Operation</seealso>
        PauseClusterResponse PauseCluster(PauseClusterRequest request);



        /// <summary>
        /// Pauses a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PauseCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PauseCluster service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/PauseCluster">REST API Reference for PauseCluster Operation</seealso>
        Task<PauseClusterResponse> PauseClusterAsync(PauseClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PurchaseReservedNodeOffering


        /// <summary>
        /// Allows you to purchase reserved nodes. Amazon Redshift offers a predefined set of
        /// reserved node offerings. You can purchase one or more of the offerings. You can call
        /// the <a>DescribeReservedNodeOfferings</a> API to obtain the available reserved node
        /// offerings. You can call this API by providing a specific reserved node offering and
        /// the number of nodes you want to reserve. 
        /// 
        ///  
        /// <para>
        ///  For more information about reserved node offerings, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/purchase-reserved-node-instance.html">Purchasing
        /// Reserved Nodes</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedNodeOffering service method.</param>
        /// 
        /// <returns>The response from the PurchaseReservedNodeOffering service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeAlreadyExistsException">
        /// User already has a reservation with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeQuotaExceededException">
        /// Request would exceed the user's compute node quota. For information about increasing
        /// your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/PurchaseReservedNodeOffering">REST API Reference for PurchaseReservedNodeOffering Operation</seealso>
        PurchaseReservedNodeOfferingResponse PurchaseReservedNodeOffering(PurchaseReservedNodeOfferingRequest request);



        /// <summary>
        /// Allows you to purchase reserved nodes. Amazon Redshift offers a predefined set of
        /// reserved node offerings. You can purchase one or more of the offerings. You can call
        /// the <a>DescribeReservedNodeOfferings</a> API to obtain the available reserved node
        /// offerings. You can call this API by providing a specific reserved node offering and
        /// the number of nodes you want to reserve. 
        /// 
        ///  
        /// <para>
        ///  For more information about reserved node offerings, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/purchase-reserved-node-instance.html">Purchasing
        /// Reserved Nodes</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedNodeOffering service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PurchaseReservedNodeOffering service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeAlreadyExistsException">
        /// User already has a reservation with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeOfferingNotFoundException">
        /// Specified offering does not exist.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ReservedNodeQuotaExceededException">
        /// Request would exceed the user's compute node quota. For information about increasing
        /// your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/PurchaseReservedNodeOffering">REST API Reference for PurchaseReservedNodeOffering Operation</seealso>
        Task<PurchaseReservedNodeOfferingResponse> PurchaseReservedNodeOfferingAsync(PurchaseReservedNodeOfferingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RebootCluster


        /// <summary>
        /// Reboots a cluster. This action is taken as soon as possible. It results in a momentary
        /// outage to the cluster, during which the cluster status is set to <code>rebooting</code>.
        /// A cluster event is created when the reboot is completed. Any pending cluster modifications
        /// (see <a>ModifyCluster</a>) are applied at this reboot. For more information about
        /// managing clusters, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootCluster service method.</param>
        /// 
        /// <returns>The response from the RebootCluster service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RebootCluster">REST API Reference for RebootCluster Operation</seealso>
        RebootClusterResponse RebootCluster(RebootClusterRequest request);



        /// <summary>
        /// Reboots a cluster. This action is taken as soon as possible. It results in a momentary
        /// outage to the cluster, during which the cluster status is set to <code>rebooting</code>.
        /// A cluster event is created when the reboot is completed. Any pending cluster modifications
        /// (see <a>ModifyCluster</a>) are applied at this reboot. For more information about
        /// managing clusters, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-clusters.html">Amazon
        /// Redshift Clusters</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RebootCluster service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RebootCluster">REST API Reference for RebootCluster Operation</seealso>
        Task<RebootClusterResponse> RebootClusterAsync(RebootClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ResetClusterParameterGroup


        /// <summary>
        /// Sets one or more parameters of the specified parameter group to their default values
        /// and sets the source values of the parameters to "engine-default". To reset the entire
        /// parameter group specify the <i>ResetAllParameters</i> parameter. For parameter changes
        /// to take effect you must reboot any associated clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetClusterParameterGroup service method.</param>
        /// 
        /// <returns>The response from the ResetClusterParameterGroup service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterParameterGroupStateException">
        /// The cluster parameter group action can not be completed because another task is in
        /// progress that involves the parameter group. Wait a few moments and try the operation
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ResetClusterParameterGroup">REST API Reference for ResetClusterParameterGroup Operation</seealso>
        ResetClusterParameterGroupResponse ResetClusterParameterGroup(ResetClusterParameterGroupRequest request);



        /// <summary>
        /// Sets one or more parameters of the specified parameter group to their default values
        /// and sets the source values of the parameters to "engine-default". To reset the entire
        /// parameter group specify the <i>ResetAllParameters</i> parameter. For parameter changes
        /// to take effect you must reboot any associated clusters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetClusterParameterGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetClusterParameterGroup service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterParameterGroupStateException">
        /// The cluster parameter group action can not be completed because another task is in
        /// progress that involves the parameter group. Wait a few moments and try the operation
        /// again.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ResetClusterParameterGroup">REST API Reference for ResetClusterParameterGroup Operation</seealso>
        Task<ResetClusterParameterGroupResponse> ResetClusterParameterGroupAsync(ResetClusterParameterGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ResizeCluster


        /// <summary>
        /// Changes the size of the cluster. You can change the cluster's type, or change the
        /// number or type of nodes. The default behavior is to use the elastic resize method.
        /// With an elastic resize, your cluster is available for read and write operations more
        /// quickly than with the classic resize method. 
        /// 
        ///  
        /// <para>
        /// Elastic resize operations have the following restrictions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can only resize clusters of the following types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// dc2.large
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// dc2.8xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ds2.xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ds2.8xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ra3.16xlarge
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// The type of nodes that you add must match the node type for the cluster.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResizeCluster service method.</param>
        /// 
        /// <returns>The response from the ResizeCluster service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InsufficientClusterCapacityException">
        /// The number of nodes specified exceeds the allotted capacity of the cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.LimitExceededException">
        /// The encryption key has exceeded its grant limit in AWS KMS.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.NumberOfNodesPerClusterLimitExceededException">
        /// The operation would exceed the number of nodes allowed for a cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.NumberOfNodesQuotaExceededException">
        /// The operation would exceed the number of nodes allotted to the account. For information
        /// about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOptionException">
        /// A request option was specified that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ResizeCluster">REST API Reference for ResizeCluster Operation</seealso>
        ResizeClusterResponse ResizeCluster(ResizeClusterRequest request);



        /// <summary>
        /// Changes the size of the cluster. You can change the cluster's type, or change the
        /// number or type of nodes. The default behavior is to use the elastic resize method.
        /// With an elastic resize, your cluster is available for read and write operations more
        /// quickly than with the classic resize method. 
        /// 
        ///  
        /// <para>
        /// Elastic resize operations have the following restrictions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// You can only resize clusters of the following types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// dc2.large
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// dc2.8xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ds2.xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ds2.8xlarge
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ra3.16xlarge
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// The type of nodes that you add must match the node type for the cluster.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResizeCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResizeCluster service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InsufficientClusterCapacityException">
        /// The number of nodes specified exceeds the allotted capacity of the cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.LimitExceededException">
        /// The encryption key has exceeded its grant limit in AWS KMS.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.NumberOfNodesPerClusterLimitExceededException">
        /// The operation would exceed the number of nodes allowed for a cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.NumberOfNodesQuotaExceededException">
        /// The operation would exceed the number of nodes allotted to the account. For information
        /// about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOptionException">
        /// A request option was specified that is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ResizeCluster">REST API Reference for ResizeCluster Operation</seealso>
        Task<ResizeClusterResponse> ResizeClusterAsync(ResizeClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RestoreFromClusterSnapshot


        /// <summary>
        /// Creates a new cluster from a snapshot. By default, Amazon Redshift creates the resulting
        /// cluster with the same configuration as the original cluster from which the snapshot
        /// was created, except that the new cluster is created with the default cluster security
        /// and parameter groups. After Amazon Redshift creates the cluster, you can use the <a>ModifyCluster</a>
        /// API to associate a different security group and different parameter group with the
        /// restored cluster. If you are using a DS node type, you can also choose to change to
        /// another DS node type of the same size during restore.
        /// 
        ///  
        /// <para>
        /// If you restore a cluster into a VPC, you must provide a cluster subnet group where
        /// you want the cluster restored.
        /// </para>
        ///  
        /// <para>
        ///  For more information about working with snapshots, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon
        /// Redshift Snapshots</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreFromClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the RestoreFromClusterSnapshot service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.AccessToSnapshotDeniedException">
        /// The owner of the specified snapshot has not authorized your account to access the
        /// snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterAlreadyExistsException">
        /// The account already has a cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterQuotaExceededException">
        /// The request would exceed the allowed number of cluster instances for this account.
        /// For information about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceRequestThrottlingException">
        /// The request cannot be completed because a dependent service is throttling requests
        /// made by Amazon Redshift on your behalf. Wait and retry the request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.HsmClientCertificateNotFoundException">
        /// There is no Amazon Redshift HSM client certificate with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.HsmConfigurationNotFoundException">
        /// There is no Amazon Redshift HSM configuration with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InsufficientClusterCapacityException">
        /// The number of nodes specified exceeds the allotted capacity of the cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSnapshotStateException">
        /// The specified cluster snapshot is not in the <code>available</code> state, or other
        /// accounts are authorized to access the snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSubnetGroupStateException">
        /// The cluster subnet group cannot be deleted because it is in use.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterTrackException">
        /// The provided cluster track name is not valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidElasticIpException">
        /// The Elastic IP (EIP) is invalid or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidRestoreException">
        /// The restore is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidSubnetException">
        /// The requested subnet is not valid, or not all of the subnets are in the same VPC.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidVPCNetworkStateException">
        /// The cluster subnet group does not cover all Availability Zones.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.LimitExceededException">
        /// The encryption key has exceeded its grant limit in AWS KMS.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.NumberOfNodesPerClusterLimitExceededException">
        /// The operation would exceed the number of nodes allowed for a cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.NumberOfNodesQuotaExceededException">
        /// The operation would exceed the number of nodes allotted to the account. For information
        /// about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotScheduleNotFoundException">
        /// We could not find the specified snapshot schedule.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RestoreFromClusterSnapshot">REST API Reference for RestoreFromClusterSnapshot Operation</seealso>
        RestoreFromClusterSnapshotResponse RestoreFromClusterSnapshot(RestoreFromClusterSnapshotRequest request);



        /// <summary>
        /// Creates a new cluster from a snapshot. By default, Amazon Redshift creates the resulting
        /// cluster with the same configuration as the original cluster from which the snapshot
        /// was created, except that the new cluster is created with the default cluster security
        /// and parameter groups. After Amazon Redshift creates the cluster, you can use the <a>ModifyCluster</a>
        /// API to associate a different security group and different parameter group with the
        /// restored cluster. If you are using a DS node type, you can also choose to change to
        /// another DS node type of the same size during restore.
        /// 
        ///  
        /// <para>
        /// If you restore a cluster into a VPC, you must provide a cluster subnet group where
        /// you want the cluster restored.
        /// </para>
        ///  
        /// <para>
        ///  For more information about working with snapshots, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon
        /// Redshift Snapshots</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreFromClusterSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreFromClusterSnapshot service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.AccessToSnapshotDeniedException">
        /// The owner of the specified snapshot has not authorized your account to access the
        /// snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterAlreadyExistsException">
        /// The account already has a cluster with the given identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterParameterGroupNotFoundException">
        /// The parameter group name does not refer to an existing parameter group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterQuotaExceededException">
        /// The request would exceed the allowed number of cluster instances for this account.
        /// For information about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSubnetGroupNotFoundException">
        /// The cluster subnet group name does not refer to an existing cluster subnet group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceRequestThrottlingException">
        /// The request cannot be completed because a dependent service is throttling requests
        /// made by Amazon Redshift on your behalf. Wait and retry the request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.HsmClientCertificateNotFoundException">
        /// There is no Amazon Redshift HSM client certificate with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.HsmConfigurationNotFoundException">
        /// There is no Amazon Redshift HSM configuration with the specified identifier.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InsufficientClusterCapacityException">
        /// The number of nodes specified exceeds the allotted capacity of the cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSnapshotStateException">
        /// The specified cluster snapshot is not in the <code>available</code> state, or other
        /// accounts are authorized to access the snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSubnetGroupStateException">
        /// The cluster subnet group cannot be deleted because it is in use.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterTrackException">
        /// The provided cluster track name is not valid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidElasticIpException">
        /// The Elastic IP (EIP) is invalid or cannot be found.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidRestoreException">
        /// The restore is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidSubnetException">
        /// The requested subnet is not valid, or not all of the subnets are in the same VPC.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTagException">
        /// The tag is invalid.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidVPCNetworkStateException">
        /// The cluster subnet group does not cover all Availability Zones.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.LimitExceededException">
        /// The encryption key has exceeded its grant limit in AWS KMS.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.NumberOfNodesPerClusterLimitExceededException">
        /// The operation would exceed the number of nodes allowed for a cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.NumberOfNodesQuotaExceededException">
        /// The operation would exceed the number of nodes allotted to the account. For information
        /// about increasing your quota, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/amazon-redshift-limits.html">Limits
        /// in Amazon Redshift</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.SnapshotScheduleNotFoundException">
        /// We could not find the specified snapshot schedule.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.TagLimitExceededException">
        /// You have exceeded the number of tags allowed.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnauthorizedOperationException">
        /// Your account is not authorized to perform the requested operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RestoreFromClusterSnapshot">REST API Reference for RestoreFromClusterSnapshot Operation</seealso>
        Task<RestoreFromClusterSnapshotResponse> RestoreFromClusterSnapshotAsync(RestoreFromClusterSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RestoreTableFromClusterSnapshot


        /// <summary>
        /// Creates a new table from a table in an Amazon Redshift cluster snapshot. You must
        /// create the new table within the Amazon Redshift cluster that the snapshot was taken
        /// from.
        /// 
        ///  
        /// <para>
        /// You cannot use <code>RestoreTableFromClusterSnapshot</code> to restore a table with
        /// the same name as an existing table in an Amazon Redshift cluster. That is, you cannot
        /// overwrite an existing table in a cluster with a restored table. If you want to replace
        /// your original table with a new, restored table, then rename or drop your original
        /// table before you call <code>RestoreTableFromClusterSnapshot</code>. When you have
        /// renamed your original table, then you can pass the original name of the table as the
        /// <code>NewTableName</code> parameter value in the call to <code>RestoreTableFromClusterSnapshot</code>.
        /// This way, you can replace the original table with the table created from the snapshot.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreTableFromClusterSnapshot service method.</param>
        /// 
        /// <returns>The response from the RestoreTableFromClusterSnapshot service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InProgressTableRestoreQuotaExceededException">
        /// You have exceeded the allowed number of table restore requests. Wait for your current
        /// table restore requests to complete before making a new request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSnapshotStateException">
        /// The specified cluster snapshot is not in the <code>available</code> state, or other
        /// accounts are authorized to access the snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTableRestoreArgumentException">
        /// The value specified for the <code>sourceDatabaseName</code>, <code>sourceSchemaName</code>,
        /// or <code>sourceTableName</code> parameter, or a combination of these, doesn't exist
        /// in the snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RestoreTableFromClusterSnapshot">REST API Reference for RestoreTableFromClusterSnapshot Operation</seealso>
        RestoreTableFromClusterSnapshotResponse RestoreTableFromClusterSnapshot(RestoreTableFromClusterSnapshotRequest request);



        /// <summary>
        /// Creates a new table from a table in an Amazon Redshift cluster snapshot. You must
        /// create the new table within the Amazon Redshift cluster that the snapshot was taken
        /// from.
        /// 
        ///  
        /// <para>
        /// You cannot use <code>RestoreTableFromClusterSnapshot</code> to restore a table with
        /// the same name as an existing table in an Amazon Redshift cluster. That is, you cannot
        /// overwrite an existing table in a cluster with a restored table. If you want to replace
        /// your original table with a new, restored table, then rename or drop your original
        /// table before you call <code>RestoreTableFromClusterSnapshot</code>. When you have
        /// renamed your original table, then you can pass the original name of the table as the
        /// <code>NewTableName</code> parameter value in the call to <code>RestoreTableFromClusterSnapshot</code>.
        /// This way, you can replace the original table with the table created from the snapshot.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreTableFromClusterSnapshot service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreTableFromClusterSnapshot service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InProgressTableRestoreQuotaExceededException">
        /// You have exceeded the allowed number of table restore requests. Wait for your current
        /// table restore requests to complete before making a new request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSnapshotStateException">
        /// The specified cluster snapshot is not in the <code>available</code> state, or other
        /// accounts are authorized to access the snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidTableRestoreArgumentException">
        /// The value specified for the <code>sourceDatabaseName</code>, <code>sourceSchemaName</code>,
        /// or <code>sourceTableName</code> parameter, or a combination of these, doesn't exist
        /// in the snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.UnsupportedOperationException">
        /// The requested operation isn't supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RestoreTableFromClusterSnapshot">REST API Reference for RestoreTableFromClusterSnapshot Operation</seealso>
        Task<RestoreTableFromClusterSnapshotResponse> RestoreTableFromClusterSnapshotAsync(RestoreTableFromClusterSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ResumeCluster


        /// <summary>
        /// Resumes a paused cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResumeCluster service method.</param>
        /// 
        /// <returns>The response from the ResumeCluster service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ResumeCluster">REST API Reference for ResumeCluster Operation</seealso>
        ResumeClusterResponse ResumeCluster(ResumeClusterRequest request);



        /// <summary>
        /// Resumes a paused cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResumeCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResumeCluster service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/ResumeCluster">REST API Reference for ResumeCluster Operation</seealso>
        Task<ResumeClusterResponse> ResumeClusterAsync(ResumeClusterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RevokeClusterSecurityGroupIngress


        /// <summary>
        /// Revokes an ingress rule in an Amazon Redshift security group for a previously authorized
        /// IP range or Amazon EC2 security group. To add an ingress rule, see <a>AuthorizeClusterSecurityGroupIngress</a>.
        /// For information about managing security groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon
        /// Redshift Cluster Security Groups</a> in the <i>Amazon Redshift Cluster Management
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeClusterSecurityGroupIngress service method.</param>
        /// 
        /// <returns>The response from the RevokeClusterSecurityGroupIngress service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.AuthorizationNotFoundException">
        /// The specified CIDR IP range or EC2 security group is not authorized for the specified
        /// cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSecurityGroupStateException">
        /// The state of the cluster security group is not <code>available</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RevokeClusterSecurityGroupIngress">REST API Reference for RevokeClusterSecurityGroupIngress Operation</seealso>
        RevokeClusterSecurityGroupIngressResponse RevokeClusterSecurityGroupIngress(RevokeClusterSecurityGroupIngressRequest request);



        /// <summary>
        /// Revokes an ingress rule in an Amazon Redshift security group for a previously authorized
        /// IP range or Amazon EC2 security group. To add an ingress rule, see <a>AuthorizeClusterSecurityGroupIngress</a>.
        /// For information about managing security groups, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-security-groups.html">Amazon
        /// Redshift Cluster Security Groups</a> in the <i>Amazon Redshift Cluster Management
        /// Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeClusterSecurityGroupIngress service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RevokeClusterSecurityGroupIngress service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.AuthorizationNotFoundException">
        /// The specified CIDR IP range or EC2 security group is not authorized for the specified
        /// cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSecurityGroupNotFoundException">
        /// The cluster security group name does not refer to an existing cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterSecurityGroupStateException">
        /// The state of the cluster security group is not <code>available</code>.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RevokeClusterSecurityGroupIngress">REST API Reference for RevokeClusterSecurityGroupIngress Operation</seealso>
        Task<RevokeClusterSecurityGroupIngressResponse> RevokeClusterSecurityGroupIngressAsync(RevokeClusterSecurityGroupIngressRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RevokeSnapshotAccess


        /// <summary>
        /// Removes the ability of the specified AWS customer account to restore the specified
        /// snapshot. If the account is currently restoring the snapshot, the restore will run
        /// to completion.
        /// 
        ///  
        /// <para>
        ///  For more information about working with snapshots, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon
        /// Redshift Snapshots</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeSnapshotAccess service method.</param>
        /// 
        /// <returns>The response from the RevokeSnapshotAccess service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.AccessToSnapshotDeniedException">
        /// The owner of the specified snapshot has not authorized your account to access the
        /// snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.AuthorizationNotFoundException">
        /// The specified CIDR IP range or EC2 security group is not authorized for the specified
        /// cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RevokeSnapshotAccess">REST API Reference for RevokeSnapshotAccess Operation</seealso>
        RevokeSnapshotAccessResponse RevokeSnapshotAccess(RevokeSnapshotAccessRequest request);



        /// <summary>
        /// Removes the ability of the specified AWS customer account to restore the specified
        /// snapshot. If the account is currently restoring the snapshot, the restore will run
        /// to completion.
        /// 
        ///  
        /// <para>
        ///  For more information about working with snapshots, go to <a href="https://docs.aws.amazon.com/redshift/latest/mgmt/working-with-snapshots.html">Amazon
        /// Redshift Snapshots</a> in the <i>Amazon Redshift Cluster Management Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeSnapshotAccess service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RevokeSnapshotAccess service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.AccessToSnapshotDeniedException">
        /// The owner of the specified snapshot has not authorized your account to access the
        /// snapshot.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.AuthorizationNotFoundException">
        /// The specified CIDR IP range or EC2 security group is not authorized for the specified
        /// cluster security group.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.ClusterSnapshotNotFoundException">
        /// The snapshot identifier does not refer to an existing cluster snapshot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RevokeSnapshotAccess">REST API Reference for RevokeSnapshotAccess Operation</seealso>
        Task<RevokeSnapshotAccessResponse> RevokeSnapshotAccessAsync(RevokeSnapshotAccessRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RotateEncryptionKey


        /// <summary>
        /// Rotates the encryption keys for a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RotateEncryptionKey service method.</param>
        /// 
        /// <returns>The response from the RotateEncryptionKey service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceRequestThrottlingException">
        /// The request cannot be completed because a dependent service is throttling requests
        /// made by Amazon Redshift on your behalf. Wait and retry the request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RotateEncryptionKey">REST API Reference for RotateEncryptionKey Operation</seealso>
        RotateEncryptionKeyResponse RotateEncryptionKey(RotateEncryptionKeyRequest request);



        /// <summary>
        /// Rotates the encryption keys for a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RotateEncryptionKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RotateEncryptionKey service method, as returned by Redshift.</returns>
        /// <exception cref="Amazon.Redshift.Model.ClusterNotFoundException">
        /// The <code>ClusterIdentifier</code> parameter does not refer to an existing cluster.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.DependentServiceRequestThrottlingException">
        /// The request cannot be completed because a dependent service is throttling requests
        /// made by Amazon Redshift on your behalf. Wait and retry the request.
        /// </exception>
        /// <exception cref="Amazon.Redshift.Model.InvalidClusterStateException">
        /// The specified cluster is not in the <code>available</code> state.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/redshift-2012-12-01/RotateEncryptionKey">REST API Reference for RotateEncryptionKey Operation</seealso>
        Task<RotateEncryptionKeyResponse> RotateEncryptionKeyAsync(RotateEncryptionKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}