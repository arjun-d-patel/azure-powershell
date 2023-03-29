// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>HyperVReplicaAzure specific enable protection input.</summary>
    public partial class HyperVReplicaAzureEnableProtectionInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVReplicaAzureEnableProtectionInput,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVReplicaAzureEnableProtectionInputInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IEnableProtectionProviderSpecificInput"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IEnableProtectionProviderSpecificInput __enableProtectionProviderSpecificInput = new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.EnableProtectionProviderSpecificInput();

        /// <summary>Backing field for <see cref="DiskEncryptionSetId" /> property.</summary>
        private string _diskEncryptionSetId;

        /// <summary>The DiskEncryptionSet ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string DiskEncryptionSetId { get => this._diskEncryptionSetId; set => this._diskEncryptionSetId = value; }

        /// <summary>Backing field for <see cref="DiskType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskAccountType? _diskType;

        /// <summary>The DiskType.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskAccountType? DiskType { get => this._diskType; set => this._diskType = value; }

        /// <summary>Backing field for <see cref="DisksToInclude" /> property.</summary>
        private string[] _disksToInclude;

        /// <summary>The list of VHD Ids of disks to be protected.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string[] DisksToInclude { get => this._disksToInclude; set => this._disksToInclude = value; }

        /// <summary>Backing field for <see cref="DisksToIncludeForManagedDisk" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVReplicaAzureDiskInputDetails[] _disksToIncludeForManagedDisk;

        /// <summary>The disks to include list for managed disks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVReplicaAzureDiskInputDetails[] DisksToIncludeForManagedDisk { get => this._disksToIncludeForManagedDisk; set => this._disksToIncludeForManagedDisk = value; }

        /// <summary>Backing field for <see cref="EnableRdpOnTargetOption" /> property.</summary>
        private string _enableRdpOnTargetOption;

        /// <summary>
        /// The selected option to enable RDP\SSH on target vm after failover. String value of SrsDataContract.EnableRDPOnTargetOption
        /// enum.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string EnableRdpOnTargetOption { get => this._enableRdpOnTargetOption; set => this._enableRdpOnTargetOption = value; }

        /// <summary>Backing field for <see cref="HvHostVMId" /> property.</summary>
        private string _hvHostVMId;

        /// <summary>The Hyper-V host VM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string HvHostVMId { get => this._hvHostVMId; set => this._hvHostVMId = value; }

        /// <summary>The class type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Inherited)]
        public string InstanceType { get => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IEnableProtectionProviderSpecificInputInternal)__enableProtectionProviderSpecificInput).InstanceType; set => ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IEnableProtectionProviderSpecificInputInternal)__enableProtectionProviderSpecificInput).InstanceType = value ; }

        /// <summary>Backing field for <see cref="LicenseType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.LicenseType? _licenseType;

        /// <summary>License type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.LicenseType? LicenseType { get => this._licenseType; set => this._licenseType = value; }

        /// <summary>Backing field for <see cref="LogStorageAccountId" /> property.</summary>
        private string _logStorageAccountId;

        /// <summary>The storage account to be used for logging during replication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string LogStorageAccountId { get => this._logStorageAccountId; set => this._logStorageAccountId = value; }

        /// <summary>Backing field for <see cref="OSType" /> property.</summary>
        private string _oSType;

        /// <summary>The OS type associated with VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string OSType { get => this._oSType; set => this._oSType = value; }

        /// <summary>Backing field for <see cref="SeedManagedDiskTag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVReplicaAzureEnableProtectionInputSeedManagedDiskTags _seedManagedDiskTag;

        /// <summary>The tags for the seed managed disks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVReplicaAzureEnableProtectionInputSeedManagedDiskTags SeedManagedDiskTag { get => (this._seedManagedDiskTag = this._seedManagedDiskTag ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.HyperVReplicaAzureEnableProtectionInputSeedManagedDiskTags()); set => this._seedManagedDiskTag = value; }

        /// <summary>Backing field for <see cref="SqlServerLicenseType" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.SqlServerLicenseType? _sqlServerLicenseType;

        /// <summary>The SQL Server license type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.SqlServerLicenseType? SqlServerLicenseType { get => this._sqlServerLicenseType; set => this._sqlServerLicenseType = value; }

        /// <summary>Backing field for <see cref="TargetAvailabilitySetId" /> property.</summary>
        private string _targetAvailabilitySetId;

        /// <summary>The target availability set ARM Id for resource manager deployment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetAvailabilitySetId { get => this._targetAvailabilitySetId; set => this._targetAvailabilitySetId = value; }

        /// <summary>Backing field for <see cref="TargetAvailabilityZone" /> property.</summary>
        private string _targetAvailabilityZone;

        /// <summary>The target availability zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetAvailabilityZone { get => this._targetAvailabilityZone; set => this._targetAvailabilityZone = value; }

        /// <summary>Backing field for <see cref="TargetAzureNetworkId" /> property.</summary>
        private string _targetAzureNetworkId;

        /// <summary>The selected target Azure network Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetAzureNetworkId { get => this._targetAzureNetworkId; set => this._targetAzureNetworkId = value; }

        /// <summary>Backing field for <see cref="TargetAzureSubnetId" /> property.</summary>
        private string _targetAzureSubnetId;

        /// <summary>The selected target Azure subnet Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetAzureSubnetId { get => this._targetAzureSubnetId; set => this._targetAzureSubnetId = value; }

        /// <summary>Backing field for <see cref="TargetAzureV1ResourceGroupId" /> property.</summary>
        private string _targetAzureV1ResourceGroupId;

        /// <summary>
        /// The Id of the target resource group (for classic deployment) in which the failover VM is to be created.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetAzureV1ResourceGroupId { get => this._targetAzureV1ResourceGroupId; set => this._targetAzureV1ResourceGroupId = value; }

        /// <summary>Backing field for <see cref="TargetAzureV2ResourceGroupId" /> property.</summary>
        private string _targetAzureV2ResourceGroupId;

        /// <summary>
        /// The Id of the target resource group (for resource manager deployment) in which the failover VM is to be created.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetAzureV2ResourceGroupId { get => this._targetAzureV2ResourceGroupId; set => this._targetAzureV2ResourceGroupId = value; }

        /// <summary>Backing field for <see cref="TargetAzureVMName" /> property.</summary>
        private string _targetAzureVMName;

        /// <summary>The target azure VM Name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetAzureVMName { get => this._targetAzureVMName; set => this._targetAzureVMName = value; }

        /// <summary>Backing field for <see cref="TargetManagedDiskTag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVReplicaAzureEnableProtectionInputTargetManagedDiskTags _targetManagedDiskTag;

        /// <summary>The tags for the target managed disks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVReplicaAzureEnableProtectionInputTargetManagedDiskTags TargetManagedDiskTag { get => (this._targetManagedDiskTag = this._targetManagedDiskTag ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.HyperVReplicaAzureEnableProtectionInputTargetManagedDiskTags()); set => this._targetManagedDiskTag = value; }

        /// <summary>Backing field for <see cref="TargetNicTag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVReplicaAzureEnableProtectionInputTargetNicTags _targetNicTag;

        /// <summary>The tags for the target NICs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVReplicaAzureEnableProtectionInputTargetNicTags TargetNicTag { get => (this._targetNicTag = this._targetNicTag ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.HyperVReplicaAzureEnableProtectionInputTargetNicTags()); set => this._targetNicTag = value; }

        /// <summary>Backing field for <see cref="TargetProximityPlacementGroupId" /> property.</summary>
        private string _targetProximityPlacementGroupId;

        /// <summary>The proximity placement group ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetProximityPlacementGroupId { get => this._targetProximityPlacementGroupId; set => this._targetProximityPlacementGroupId = value; }

        /// <summary>Backing field for <see cref="TargetStorageAccountId" /> property.</summary>
        private string _targetStorageAccountId;

        /// <summary>The storage account Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetStorageAccountId { get => this._targetStorageAccountId; set => this._targetStorageAccountId = value; }

        /// <summary>Backing field for <see cref="TargetVMSize" /> property.</summary>
        private string _targetVMSize;

        /// <summary>The target VM size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string TargetVMSize { get => this._targetVMSize; set => this._targetVMSize = value; }

        /// <summary>Backing field for <see cref="TargetVMTag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVReplicaAzureEnableProtectionInputTargetVmtags _targetVMTag;

        /// <summary>The target VM tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVReplicaAzureEnableProtectionInputTargetVmtags TargetVMTag { get => (this._targetVMTag = this._targetVMTag ?? new Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.HyperVReplicaAzureEnableProtectionInputTargetVmtags()); set => this._targetVMTag = value; }

        /// <summary>Backing field for <see cref="UseManagedDisk" /> property.</summary>
        private string _useManagedDisk;

        /// <summary>A value indicating whether managed disks should be used during failover.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string UseManagedDisk { get => this._useManagedDisk; set => this._useManagedDisk = value; }

        /// <summary>Backing field for <see cref="UseManagedDisksForReplication" /> property.</summary>
        private string _useManagedDisksForReplication;

        /// <summary>A value indicating whether managed disks should be used during replication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string UseManagedDisksForReplication { get => this._useManagedDisksForReplication; set => this._useManagedDisksForReplication = value; }

        /// <summary>Backing field for <see cref="VMName" /> property.</summary>
        private string _vMName;

        /// <summary>The VM Name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string VMName { get => this._vMName; set => this._vMName = value; }

        /// <summary>Backing field for <see cref="VhdId" /> property.</summary>
        private string _vhdId;

        /// <summary>The OS disk VHD id associated with VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string VhdId { get => this._vhdId; set => this._vhdId = value; }

        /// <summary>Creates an new <see cref="HyperVReplicaAzureEnableProtectionInput" /> instance.</summary>
        public HyperVReplicaAzureEnableProtectionInput()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__enableProtectionProviderSpecificInput), __enableProtectionProviderSpecificInput);
            await eventListener.AssertObjectIsValid(nameof(__enableProtectionProviderSpecificInput), __enableProtectionProviderSpecificInput);
        }
    }
    /// HyperVReplicaAzure specific enable protection input.
    public partial interface IHyperVReplicaAzureEnableProtectionInput :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IEnableProtectionProviderSpecificInput
    {
        /// <summary>The DiskEncryptionSet ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The DiskEncryptionSet ARM Id.",
        SerializedName = @"diskEncryptionSetId",
        PossibleTypes = new [] { typeof(string) })]
        string DiskEncryptionSetId { get; set; }
        /// <summary>The DiskType.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The DiskType.",
        SerializedName = @"diskType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskAccountType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskAccountType? DiskType { get; set; }
        /// <summary>The list of VHD Ids of disks to be protected.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The list of VHD Ids of disks to be protected.",
        SerializedName = @"disksToInclude",
        PossibleTypes = new [] { typeof(string) })]
        string[] DisksToInclude { get; set; }
        /// <summary>The disks to include list for managed disks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The disks to include list for managed disks.",
        SerializedName = @"disksToIncludeForManagedDisks",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVReplicaAzureDiskInputDetails) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVReplicaAzureDiskInputDetails[] DisksToIncludeForManagedDisk { get; set; }
        /// <summary>
        /// The selected option to enable RDP\SSH on target vm after failover. String value of SrsDataContract.EnableRDPOnTargetOption
        /// enum.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The selected option to enable RDP\SSH on target vm after failover. String value of SrsDataContract.EnableRDPOnTargetOption enum.",
        SerializedName = @"enableRdpOnTargetOption",
        PossibleTypes = new [] { typeof(string) })]
        string EnableRdpOnTargetOption { get; set; }
        /// <summary>The Hyper-V host VM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Hyper-V host VM Id.",
        SerializedName = @"hvHostVmId",
        PossibleTypes = new [] { typeof(string) })]
        string HvHostVMId { get; set; }
        /// <summary>License type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"License type.",
        SerializedName = @"licenseType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.LicenseType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.LicenseType? LicenseType { get; set; }
        /// <summary>The storage account to be used for logging during replication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The storage account to be used for logging during replication.",
        SerializedName = @"logStorageAccountId",
        PossibleTypes = new [] { typeof(string) })]
        string LogStorageAccountId { get; set; }
        /// <summary>The OS type associated with VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The OS type associated with VM.",
        SerializedName = @"osType",
        PossibleTypes = new [] { typeof(string) })]
        string OSType { get; set; }
        /// <summary>The tags for the seed managed disks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The tags for the seed managed disks.",
        SerializedName = @"seedManagedDiskTags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVReplicaAzureEnableProtectionInputSeedManagedDiskTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVReplicaAzureEnableProtectionInputSeedManagedDiskTags SeedManagedDiskTag { get; set; }
        /// <summary>The SQL Server license type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The SQL Server license type.",
        SerializedName = @"sqlServerLicenseType",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.SqlServerLicenseType) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.SqlServerLicenseType? SqlServerLicenseType { get; set; }
        /// <summary>The target availability set ARM Id for resource manager deployment.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target availability set ARM Id for resource manager deployment.",
        SerializedName = @"targetAvailabilitySetId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetAvailabilitySetId { get; set; }
        /// <summary>The target availability zone.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target availability zone.",
        SerializedName = @"targetAvailabilityZone",
        PossibleTypes = new [] { typeof(string) })]
        string TargetAvailabilityZone { get; set; }
        /// <summary>The selected target Azure network Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The selected target Azure network Id.",
        SerializedName = @"targetAzureNetworkId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetAzureNetworkId { get; set; }
        /// <summary>The selected target Azure subnet Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The selected target Azure subnet Id.",
        SerializedName = @"targetAzureSubnetId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetAzureSubnetId { get; set; }
        /// <summary>
        /// The Id of the target resource group (for classic deployment) in which the failover VM is to be created.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Id of the target resource group (for classic deployment) in which the failover VM is to be created.",
        SerializedName = @"targetAzureV1ResourceGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetAzureV1ResourceGroupId { get; set; }
        /// <summary>
        /// The Id of the target resource group (for resource manager deployment) in which the failover VM is to be created.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Id of the target resource group (for resource manager deployment) in which the failover VM is to be created.",
        SerializedName = @"targetAzureV2ResourceGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetAzureV2ResourceGroupId { get; set; }
        /// <summary>The target azure VM Name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target azure VM Name.",
        SerializedName = @"targetAzureVmName",
        PossibleTypes = new [] { typeof(string) })]
        string TargetAzureVMName { get; set; }
        /// <summary>The tags for the target managed disks.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The tags for the target managed disks.",
        SerializedName = @"targetManagedDiskTags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVReplicaAzureEnableProtectionInputTargetManagedDiskTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVReplicaAzureEnableProtectionInputTargetManagedDiskTags TargetManagedDiskTag { get; set; }
        /// <summary>The tags for the target NICs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The tags for the target NICs.",
        SerializedName = @"targetNicTags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVReplicaAzureEnableProtectionInputTargetNicTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVReplicaAzureEnableProtectionInputTargetNicTags TargetNicTag { get; set; }
        /// <summary>The proximity placement group ARM Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The proximity placement group ARM Id.",
        SerializedName = @"targetProximityPlacementGroupId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetProximityPlacementGroupId { get; set; }
        /// <summary>The storage account Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The storage account Id.",
        SerializedName = @"targetStorageAccountId",
        PossibleTypes = new [] { typeof(string) })]
        string TargetStorageAccountId { get; set; }
        /// <summary>The target VM size.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target VM size.",
        SerializedName = @"targetVmSize",
        PossibleTypes = new [] { typeof(string) })]
        string TargetVMSize { get; set; }
        /// <summary>The target VM tags.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target VM tags.",
        SerializedName = @"targetVmTags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVReplicaAzureEnableProtectionInputTargetVmtags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVReplicaAzureEnableProtectionInputTargetVmtags TargetVMTag { get; set; }
        /// <summary>A value indicating whether managed disks should be used during failover.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A value indicating whether managed disks should be used during failover.",
        SerializedName = @"useManagedDisks",
        PossibleTypes = new [] { typeof(string) })]
        string UseManagedDisk { get; set; }
        /// <summary>A value indicating whether managed disks should be used during replication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A value indicating whether managed disks should be used during replication.",
        SerializedName = @"useManagedDisksForReplication",
        PossibleTypes = new [] { typeof(string) })]
        string UseManagedDisksForReplication { get; set; }
        /// <summary>The VM Name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The VM Name.",
        SerializedName = @"vmName",
        PossibleTypes = new [] { typeof(string) })]
        string VMName { get; set; }
        /// <summary>The OS disk VHD id associated with VM.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The OS disk VHD id associated with VM.",
        SerializedName = @"vhdId",
        PossibleTypes = new [] { typeof(string) })]
        string VhdId { get; set; }

    }
    /// HyperVReplicaAzure specific enable protection input.
    internal partial interface IHyperVReplicaAzureEnableProtectionInputInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IEnableProtectionProviderSpecificInputInternal
    {
        /// <summary>The DiskEncryptionSet ARM Id.</summary>
        string DiskEncryptionSetId { get; set; }
        /// <summary>The DiskType.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.DiskAccountType? DiskType { get; set; }
        /// <summary>The list of VHD Ids of disks to be protected.</summary>
        string[] DisksToInclude { get; set; }
        /// <summary>The disks to include list for managed disks.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVReplicaAzureDiskInputDetails[] DisksToIncludeForManagedDisk { get; set; }
        /// <summary>
        /// The selected option to enable RDP\SSH on target vm after failover. String value of SrsDataContract.EnableRDPOnTargetOption
        /// enum.
        /// </summary>
        string EnableRdpOnTargetOption { get; set; }
        /// <summary>The Hyper-V host VM Id.</summary>
        string HvHostVMId { get; set; }
        /// <summary>License type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.LicenseType? LicenseType { get; set; }
        /// <summary>The storage account to be used for logging during replication.</summary>
        string LogStorageAccountId { get; set; }
        /// <summary>The OS type associated with VM.</summary>
        string OSType { get; set; }
        /// <summary>The tags for the seed managed disks.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVReplicaAzureEnableProtectionInputSeedManagedDiskTags SeedManagedDiskTag { get; set; }
        /// <summary>The SQL Server license type.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Support.SqlServerLicenseType? SqlServerLicenseType { get; set; }
        /// <summary>The target availability set ARM Id for resource manager deployment.</summary>
        string TargetAvailabilitySetId { get; set; }
        /// <summary>The target availability zone.</summary>
        string TargetAvailabilityZone { get; set; }
        /// <summary>The selected target Azure network Id.</summary>
        string TargetAzureNetworkId { get; set; }
        /// <summary>The selected target Azure subnet Id.</summary>
        string TargetAzureSubnetId { get; set; }
        /// <summary>
        /// The Id of the target resource group (for classic deployment) in which the failover VM is to be created.
        /// </summary>
        string TargetAzureV1ResourceGroupId { get; set; }
        /// <summary>
        /// The Id of the target resource group (for resource manager deployment) in which the failover VM is to be created.
        /// </summary>
        string TargetAzureV2ResourceGroupId { get; set; }
        /// <summary>The target azure VM Name.</summary>
        string TargetAzureVMName { get; set; }
        /// <summary>The tags for the target managed disks.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVReplicaAzureEnableProtectionInputTargetManagedDiskTags TargetManagedDiskTag { get; set; }
        /// <summary>The tags for the target NICs.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVReplicaAzureEnableProtectionInputTargetNicTags TargetNicTag { get; set; }
        /// <summary>The proximity placement group ARM Id.</summary>
        string TargetProximityPlacementGroupId { get; set; }
        /// <summary>The storage account Id.</summary>
        string TargetStorageAccountId { get; set; }
        /// <summary>The target VM size.</summary>
        string TargetVMSize { get; set; }
        /// <summary>The target VM tags.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20220501.IHyperVReplicaAzureEnableProtectionInputTargetVmtags TargetVMTag { get; set; }
        /// <summary>A value indicating whether managed disks should be used during failover.</summary>
        string UseManagedDisk { get; set; }
        /// <summary>A value indicating whether managed disks should be used during replication.</summary>
        string UseManagedDisksForReplication { get; set; }
        /// <summary>The VM Name.</summary>
        string VMName { get; set; }
        /// <summary>The OS disk VHD id associated with VM.</summary>
        string VhdId { get; set; }

    }
}