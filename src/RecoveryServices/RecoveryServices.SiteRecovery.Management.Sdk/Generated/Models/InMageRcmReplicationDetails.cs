// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// InMageRcm provider specific details.
    /// </summary>
    [Newtonsoft.Json.JsonObject("InMageRcm")]
    public partial class InMageRcmReplicationDetails : ReplicationProviderSpecificSettings
    {
        /// <summary>
        /// Initializes a new instance of the InMageRcmReplicationDetails
        /// class.
        /// </summary>
        public InMageRcmReplicationDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InMageRcmReplicationDetails
        /// class.
        /// </summary>
        /// <param name="internalIdentifier">The virtual machine internal
        /// identifier.</param>
        /// <param name="fabricDiscoveryMachineId">The ARM Id of the discovered
        /// VM.</param>
        /// <param name="multiVmGroupName">The multi VM group name.</param>
        /// <param name="discoveryType">The type of the discovered VM.</param>
        /// <param name="processServerId">The process server Id.</param>
        /// <param name="processorCoreCount">The processor core count.</param>
        /// <param name="allocatedMemoryInMB">The allocated memory in
        /// MB.</param>
        /// <param name="processServerName">The process server name.</param>
        /// <param name="runAsAccountId">The run-as account Id.</param>
        /// <param name="osType">The type of the OS on the VM.</param>
        /// <param name="firmwareType">The firmware type.</param>
        /// <param name="primaryNicIpAddress">The IP address of the primary
        /// network interface.</param>
        /// <param name="targetGeneration">The target generation.</param>
        /// <param name="licenseType">License Type of the VM to be
        /// used.</param>
        /// <param name="storageAccountId">The replication storage account ARM
        /// Id. This is applicable only for the blob based replication test
        /// hook.</param>
        /// <param name="targetVmName">Target VM name.</param>
        /// <param name="targetVmSize">The target VM size.</param>
        /// <param name="targetResourceGroupId">The target resource group
        /// Id.</param>
        /// <param name="targetLocation">The target location.</param>
        /// <param name="targetAvailabilitySetId">The target availability set
        /// Id.</param>
        /// <param name="targetAvailabilityZone">The target availability
        /// zone.</param>
        /// <param name="targetProximityPlacementGroupId">The target proximity
        /// placement group Id.</param>
        /// <param name="targetBootDiagnosticsStorageAccountId">The target boot
        /// diagnostics storage account ARM Id.</param>
        /// <param name="targetNetworkId">The target network Id.</param>
        /// <param name="testNetworkId">The test network Id.</param>
        /// <param name="failoverRecoveryPointId">The recovery point Id to
        /// which the VM was failed over.</param>
        /// <param name="lastRecoveryPointReceived">The last recovery point
        /// received time.</param>
        /// <param name="lastRpoInSeconds">The last recovery point objective
        /// value.</param>
        /// <param name="lastRpoCalculatedTime">The last recovery point
        /// objective calculated time.</param>
        /// <param name="lastRecoveryPointId">The last recovery point
        /// Id.</param>
        /// <param name="initialReplicationProgressPercentage">The initial
        /// replication progress percentage. This is calculated based on total
        /// bytes processed for all disks in the source VM.</param>
        /// <param name="initialReplicationProcessedBytes">The initial
        /// replication processed bytes. This includes sum of total bytes
        /// transferred and matched bytes on all selected disks in source
        /// VM.</param>
        /// <param name="initialReplicationTransferredBytes">The initial
        /// replication transferred bytes from source VM to azure for all
        /// selected disks on source VM.</param>
        /// <param name="initialReplicationProgressHealth">The initial
        /// replication progress health. Possible values include: 'None',
        /// 'InProgress', 'SlowProgress', 'NoProgress'</param>
        /// <param name="resyncProgressPercentage">The resync progress
        /// percentage. This is calculated based on total bytes processed for
        /// all disks in the source VM.</param>
        /// <param name="resyncProcessedBytes">The resync processed bytes. This
        /// includes sum of total bytes transferred and matched bytes on all
        /// selected disks in source VM.</param>
        /// <param name="resyncTransferredBytes">The resync transferred bytes
        /// from source VM to azure for all selected disks on source
        /// VM.</param>
        /// <param name="resyncProgressHealth">The resync progress health.
        /// Possible values include: 'None', 'InProgress', 'SlowProgress',
        /// 'NoProgress'</param>
        /// <param name="resyncRequired">A value indicating whether resync is
        /// required.</param>
        /// <param name="resyncState">The resync state. Possible values
        /// include: 'None', 'PreparedForResynchronization',
        /// 'StartedResynchronization'</param>
        /// <param name="agentUpgradeState">The agent auto upgrade state.
        /// Possible values include: 'None', 'Started', 'Completed',
        /// 'Commit'</param>
        /// <param name="lastAgentUpgradeType">The last agent upgrade
        /// type.</param>
        /// <param name="agentUpgradeJobId">The agent upgrade job Id.</param>
        /// <param name="agentUpgradeAttemptToVersion">The agent version to
        /// which last agent upgrade was attempted.</param>
        /// <param name="protectedDisks">The list of protected disks.</param>
        /// <param name="isLastUpgradeSuccessful">A value indicating whether
        /// last agent upgrade was successful or not.</param>
        /// <param name="isAgentRegistrationSuccessfulAfterFailover">A value
        /// indicating whether agent registration was successful after
        /// failover.</param>
        /// <param name="mobilityAgentDetails">The mobility agent
        /// information.</param>
        /// <param name="lastAgentUpgradeErrorDetails">The last agent upgrade
        /// error information.</param>
        /// <param name="agentUpgradeBlockingErrorDetails">The agent upgrade
        /// blocking error information.</param>
        /// <param name="vmNics">The network details.</param>
        /// <param name="discoveredVmDetails">The discovered VM
        /// details.</param>
        public InMageRcmReplicationDetails(string internalIdentifier = default(string), string fabricDiscoveryMachineId = default(string), string multiVmGroupName = default(string), string discoveryType = default(string), string processServerId = default(string), int? processorCoreCount = default(int?), double? allocatedMemoryInMB = default(double?), string processServerName = default(string), string runAsAccountId = default(string), string osType = default(string), string firmwareType = default(string), string primaryNicIpAddress = default(string), string targetGeneration = default(string), string licenseType = default(string), string storageAccountId = default(string), string targetVmName = default(string), string targetVmSize = default(string), string targetResourceGroupId = default(string), string targetLocation = default(string), string targetAvailabilitySetId = default(string), string targetAvailabilityZone = default(string), string targetProximityPlacementGroupId = default(string), string targetBootDiagnosticsStorageAccountId = default(string), string targetNetworkId = default(string), string testNetworkId = default(string), string failoverRecoveryPointId = default(string), System.DateTime? lastRecoveryPointReceived = default(System.DateTime?), long? lastRpoInSeconds = default(long?), System.DateTime? lastRpoCalculatedTime = default(System.DateTime?), string lastRecoveryPointId = default(string), int? initialReplicationProgressPercentage = default(int?), long? initialReplicationProcessedBytes = default(long?), long? initialReplicationTransferredBytes = default(long?), string initialReplicationProgressHealth = default(string), int? resyncProgressPercentage = default(int?), long? resyncProcessedBytes = default(long?), long? resyncTransferredBytes = default(long?), string resyncProgressHealth = default(string), string resyncRequired = default(string), string resyncState = default(string), string agentUpgradeState = default(string), string lastAgentUpgradeType = default(string), string agentUpgradeJobId = default(string), string agentUpgradeAttemptToVersion = default(string), IList<InMageRcmProtectedDiskDetails> protectedDisks = default(IList<InMageRcmProtectedDiskDetails>), string isLastUpgradeSuccessful = default(string), bool? isAgentRegistrationSuccessfulAfterFailover = default(bool?), InMageRcmMobilityAgentDetails mobilityAgentDetails = default(InMageRcmMobilityAgentDetails), IList<InMageRcmLastAgentUpgradeErrorDetails> lastAgentUpgradeErrorDetails = default(IList<InMageRcmLastAgentUpgradeErrorDetails>), IList<InMageRcmAgentUpgradeBlockingErrorDetails> agentUpgradeBlockingErrorDetails = default(IList<InMageRcmAgentUpgradeBlockingErrorDetails>), IList<InMageRcmNicDetails> vmNics = default(IList<InMageRcmNicDetails>), InMageRcmDiscoveredProtectedVmDetails discoveredVmDetails = default(InMageRcmDiscoveredProtectedVmDetails))
        {
            InternalIdentifier = internalIdentifier;
            FabricDiscoveryMachineId = fabricDiscoveryMachineId;
            MultiVmGroupName = multiVmGroupName;
            DiscoveryType = discoveryType;
            ProcessServerId = processServerId;
            ProcessorCoreCount = processorCoreCount;
            AllocatedMemoryInMB = allocatedMemoryInMB;
            ProcessServerName = processServerName;
            RunAsAccountId = runAsAccountId;
            OsType = osType;
            FirmwareType = firmwareType;
            PrimaryNicIpAddress = primaryNicIpAddress;
            TargetGeneration = targetGeneration;
            LicenseType = licenseType;
            StorageAccountId = storageAccountId;
            TargetVmName = targetVmName;
            TargetVmSize = targetVmSize;
            TargetResourceGroupId = targetResourceGroupId;
            TargetLocation = targetLocation;
            TargetAvailabilitySetId = targetAvailabilitySetId;
            TargetAvailabilityZone = targetAvailabilityZone;
            TargetProximityPlacementGroupId = targetProximityPlacementGroupId;
            TargetBootDiagnosticsStorageAccountId = targetBootDiagnosticsStorageAccountId;
            TargetNetworkId = targetNetworkId;
            TestNetworkId = testNetworkId;
            FailoverRecoveryPointId = failoverRecoveryPointId;
            LastRecoveryPointReceived = lastRecoveryPointReceived;
            LastRpoInSeconds = lastRpoInSeconds;
            LastRpoCalculatedTime = lastRpoCalculatedTime;
            LastRecoveryPointId = lastRecoveryPointId;
            InitialReplicationProgressPercentage = initialReplicationProgressPercentage;
            InitialReplicationProcessedBytes = initialReplicationProcessedBytes;
            InitialReplicationTransferredBytes = initialReplicationTransferredBytes;
            InitialReplicationProgressHealth = initialReplicationProgressHealth;
            ResyncProgressPercentage = resyncProgressPercentage;
            ResyncProcessedBytes = resyncProcessedBytes;
            ResyncTransferredBytes = resyncTransferredBytes;
            ResyncProgressHealth = resyncProgressHealth;
            ResyncRequired = resyncRequired;
            ResyncState = resyncState;
            AgentUpgradeState = agentUpgradeState;
            LastAgentUpgradeType = lastAgentUpgradeType;
            AgentUpgradeJobId = agentUpgradeJobId;
            AgentUpgradeAttemptToVersion = agentUpgradeAttemptToVersion;
            ProtectedDisks = protectedDisks;
            IsLastUpgradeSuccessful = isLastUpgradeSuccessful;
            IsAgentRegistrationSuccessfulAfterFailover = isAgentRegistrationSuccessfulAfterFailover;
            MobilityAgentDetails = mobilityAgentDetails;
            LastAgentUpgradeErrorDetails = lastAgentUpgradeErrorDetails;
            AgentUpgradeBlockingErrorDetails = agentUpgradeBlockingErrorDetails;
            VmNics = vmNics;
            DiscoveredVmDetails = discoveredVmDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the virtual machine internal identifier.
        /// </summary>
        [JsonProperty(PropertyName = "internalIdentifier")]
        public string InternalIdentifier { get; private set; }

        /// <summary>
        /// Gets the ARM Id of the discovered VM.
        /// </summary>
        [JsonProperty(PropertyName = "fabricDiscoveryMachineId")]
        public string FabricDiscoveryMachineId { get; private set; }

        /// <summary>
        /// Gets the multi VM group name.
        /// </summary>
        [JsonProperty(PropertyName = "multiVmGroupName")]
        public string MultiVmGroupName { get; private set; }

        /// <summary>
        /// Gets the type of the discovered VM.
        /// </summary>
        [JsonProperty(PropertyName = "discoveryType")]
        public string DiscoveryType { get; private set; }

        /// <summary>
        /// Gets the process server Id.
        /// </summary>
        [JsonProperty(PropertyName = "processServerId")]
        public string ProcessServerId { get; private set; }

        /// <summary>
        /// Gets the processor core count.
        /// </summary>
        [JsonProperty(PropertyName = "processorCoreCount")]
        public int? ProcessorCoreCount { get; private set; }

        /// <summary>
        /// Gets the allocated memory in MB.
        /// </summary>
        [JsonProperty(PropertyName = "allocatedMemoryInMB")]
        public double? AllocatedMemoryInMB { get; private set; }

        /// <summary>
        /// Gets the process server name.
        /// </summary>
        [JsonProperty(PropertyName = "processServerName")]
        public string ProcessServerName { get; private set; }

        /// <summary>
        /// Gets the run-as account Id.
        /// </summary>
        [JsonProperty(PropertyName = "runAsAccountId")]
        public string RunAsAccountId { get; private set; }

        /// <summary>
        /// Gets the type of the OS on the VM.
        /// </summary>
        [JsonProperty(PropertyName = "osType")]
        public string OsType { get; private set; }

        /// <summary>
        /// Gets the firmware type.
        /// </summary>
        [JsonProperty(PropertyName = "firmwareType")]
        public string FirmwareType { get; private set; }

        /// <summary>
        /// Gets the IP address of the primary network interface.
        /// </summary>
        [JsonProperty(PropertyName = "primaryNicIpAddress")]
        public string PrimaryNicIpAddress { get; private set; }

        /// <summary>
        /// Gets the target generation.
        /// </summary>
        [JsonProperty(PropertyName = "targetGeneration")]
        public string TargetGeneration { get; private set; }

        /// <summary>
        /// Gets or sets license Type of the VM to be used.
        /// </summary>
        [JsonProperty(PropertyName = "licenseType")]
        public string LicenseType { get; set; }

        /// <summary>
        /// Gets the replication storage account ARM Id. This is applicable
        /// only for the blob based replication test hook.
        /// </summary>
        [JsonProperty(PropertyName = "storageAccountId")]
        public string StorageAccountId { get; private set; }

        /// <summary>
        /// Gets or sets target VM name.
        /// </summary>
        [JsonProperty(PropertyName = "targetVmName")]
        public string TargetVmName { get; set; }

        /// <summary>
        /// Gets or sets the target VM size.
        /// </summary>
        [JsonProperty(PropertyName = "targetVmSize")]
        public string TargetVmSize { get; set; }

        /// <summary>
        /// Gets or sets the target resource group Id.
        /// </summary>
        [JsonProperty(PropertyName = "targetResourceGroupId")]
        public string TargetResourceGroupId { get; set; }

        /// <summary>
        /// Gets or sets the target location.
        /// </summary>
        [JsonProperty(PropertyName = "targetLocation")]
        public string TargetLocation { get; set; }

        /// <summary>
        /// Gets or sets the target availability set Id.
        /// </summary>
        [JsonProperty(PropertyName = "targetAvailabilitySetId")]
        public string TargetAvailabilitySetId { get; set; }

        /// <summary>
        /// Gets or sets the target availability zone.
        /// </summary>
        [JsonProperty(PropertyName = "targetAvailabilityZone")]
        public string TargetAvailabilityZone { get; set; }

        /// <summary>
        /// Gets or sets the target proximity placement group Id.
        /// </summary>
        [JsonProperty(PropertyName = "targetProximityPlacementGroupId")]
        public string TargetProximityPlacementGroupId { get; set; }

        /// <summary>
        /// Gets or sets the target boot diagnostics storage account ARM Id.
        /// </summary>
        [JsonProperty(PropertyName = "targetBootDiagnosticsStorageAccountId")]
        public string TargetBootDiagnosticsStorageAccountId { get; set; }

        /// <summary>
        /// Gets or sets the target network Id.
        /// </summary>
        [JsonProperty(PropertyName = "targetNetworkId")]
        public string TargetNetworkId { get; set; }

        /// <summary>
        /// Gets or sets the test network Id.
        /// </summary>
        [JsonProperty(PropertyName = "testNetworkId")]
        public string TestNetworkId { get; set; }

        /// <summary>
        /// Gets the recovery point Id to which the VM was failed over.
        /// </summary>
        [JsonProperty(PropertyName = "failoverRecoveryPointId")]
        public string FailoverRecoveryPointId { get; private set; }

        /// <summary>
        /// Gets the last recovery point received time.
        /// </summary>
        [JsonProperty(PropertyName = "lastRecoveryPointReceived")]
        public System.DateTime? LastRecoveryPointReceived { get; private set; }

        /// <summary>
        /// Gets the last recovery point objective value.
        /// </summary>
        [JsonProperty(PropertyName = "lastRpoInSeconds")]
        public long? LastRpoInSeconds { get; private set; }

        /// <summary>
        /// Gets the last recovery point objective calculated time.
        /// </summary>
        [JsonProperty(PropertyName = "lastRpoCalculatedTime")]
        public System.DateTime? LastRpoCalculatedTime { get; private set; }

        /// <summary>
        /// Gets the last recovery point Id.
        /// </summary>
        [JsonProperty(PropertyName = "lastRecoveryPointId")]
        public string LastRecoveryPointId { get; private set; }

        /// <summary>
        /// Gets the initial replication progress percentage. This is
        /// calculated based on total bytes processed for all disks in the
        /// source VM.
        /// </summary>
        [JsonProperty(PropertyName = "initialReplicationProgressPercentage")]
        public int? InitialReplicationProgressPercentage { get; private set; }

        /// <summary>
        /// Gets the initial replication processed bytes. This includes sum of
        /// total bytes transferred and matched bytes on all selected disks in
        /// source VM.
        /// </summary>
        [JsonProperty(PropertyName = "initialReplicationProcessedBytes")]
        public long? InitialReplicationProcessedBytes { get; private set; }

        /// <summary>
        /// Gets the initial replication transferred bytes from source VM to
        /// azure for all selected disks on source VM.
        /// </summary>
        [JsonProperty(PropertyName = "initialReplicationTransferredBytes")]
        public long? InitialReplicationTransferredBytes { get; private set; }

        /// <summary>
        /// Gets the initial replication progress health. Possible values
        /// include: 'None', 'InProgress', 'SlowProgress', 'NoProgress'
        /// </summary>
        [JsonProperty(PropertyName = "initialReplicationProgressHealth")]
        public string InitialReplicationProgressHealth { get; private set; }

        /// <summary>
        /// Gets the resync progress percentage. This is calculated based on
        /// total bytes processed for all disks in the source VM.
        /// </summary>
        [JsonProperty(PropertyName = "resyncProgressPercentage")]
        public int? ResyncProgressPercentage { get; private set; }

        /// <summary>
        /// Gets the resync processed bytes. This includes sum of total bytes
        /// transferred and matched bytes on all selected disks in source VM.
        /// </summary>
        [JsonProperty(PropertyName = "resyncProcessedBytes")]
        public long? ResyncProcessedBytes { get; private set; }

        /// <summary>
        /// Gets the resync transferred bytes from source VM to azure for all
        /// selected disks on source VM.
        /// </summary>
        [JsonProperty(PropertyName = "resyncTransferredBytes")]
        public long? ResyncTransferredBytes { get; private set; }

        /// <summary>
        /// Gets the resync progress health. Possible values include: 'None',
        /// 'InProgress', 'SlowProgress', 'NoProgress'
        /// </summary>
        [JsonProperty(PropertyName = "resyncProgressHealth")]
        public string ResyncProgressHealth { get; private set; }

        /// <summary>
        /// Gets a value indicating whether resync is required.
        /// </summary>
        [JsonProperty(PropertyName = "resyncRequired")]
        public string ResyncRequired { get; private set; }

        /// <summary>
        /// Gets the resync state. Possible values include: 'None',
        /// 'PreparedForResynchronization', 'StartedResynchronization'
        /// </summary>
        [JsonProperty(PropertyName = "resyncState")]
        public string ResyncState { get; private set; }

        /// <summary>
        /// Gets the agent auto upgrade state. Possible values include: 'None',
        /// 'Started', 'Completed', 'Commit'
        /// </summary>
        [JsonProperty(PropertyName = "agentUpgradeState")]
        public string AgentUpgradeState { get; private set; }

        /// <summary>
        /// Gets the last agent upgrade type.
        /// </summary>
        [JsonProperty(PropertyName = "lastAgentUpgradeType")]
        public string LastAgentUpgradeType { get; private set; }

        /// <summary>
        /// Gets the agent upgrade job Id.
        /// </summary>
        [JsonProperty(PropertyName = "agentUpgradeJobId")]
        public string AgentUpgradeJobId { get; private set; }

        /// <summary>
        /// Gets the agent version to which last agent upgrade was attempted.
        /// </summary>
        [JsonProperty(PropertyName = "agentUpgradeAttemptToVersion")]
        public string AgentUpgradeAttemptToVersion { get; private set; }

        /// <summary>
        /// Gets or sets the list of protected disks.
        /// </summary>
        [JsonProperty(PropertyName = "protectedDisks")]
        public IList<InMageRcmProtectedDiskDetails> ProtectedDisks { get; set; }

        /// <summary>
        /// Gets a value indicating whether last agent upgrade was successful
        /// or not.
        /// </summary>
        [JsonProperty(PropertyName = "isLastUpgradeSuccessful")]
        public string IsLastUpgradeSuccessful { get; private set; }

        /// <summary>
        /// Gets a value indicating whether agent registration was successful
        /// after failover.
        /// </summary>
        [JsonProperty(PropertyName = "isAgentRegistrationSuccessfulAfterFailover")]
        public bool? IsAgentRegistrationSuccessfulAfterFailover { get; private set; }

        /// <summary>
        /// Gets or sets the mobility agent information.
        /// </summary>
        [JsonProperty(PropertyName = "mobilityAgentDetails")]
        public InMageRcmMobilityAgentDetails MobilityAgentDetails { get; set; }

        /// <summary>
        /// Gets or sets the last agent upgrade error information.
        /// </summary>
        [JsonProperty(PropertyName = "lastAgentUpgradeErrorDetails")]
        public IList<InMageRcmLastAgentUpgradeErrorDetails> LastAgentUpgradeErrorDetails { get; set; }

        /// <summary>
        /// Gets or sets the agent upgrade blocking error information.
        /// </summary>
        [JsonProperty(PropertyName = "agentUpgradeBlockingErrorDetails")]
        public IList<InMageRcmAgentUpgradeBlockingErrorDetails> AgentUpgradeBlockingErrorDetails { get; set; }

        /// <summary>
        /// Gets or sets the network details.
        /// </summary>
        [JsonProperty(PropertyName = "vmNics")]
        public IList<InMageRcmNicDetails> VmNics { get; set; }

        /// <summary>
        /// Gets or sets the discovered VM details.
        /// </summary>
        [JsonProperty(PropertyName = "discoveredVmDetails")]
        public InMageRcmDiscoveredProtectedVmDetails DiscoveredVmDetails { get; set; }

    }
}
