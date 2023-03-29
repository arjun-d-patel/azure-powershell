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
    using System.Linq;

    /// <summary>
    /// InMageAzureV2 protected disk details.
    /// </summary>
    public partial class InMageAzureV2ProtectedDiskDetails
    {
        /// <summary>
        /// Initializes a new instance of the InMageAzureV2ProtectedDiskDetails
        /// class.
        /// </summary>
        public InMageAzureV2ProtectedDiskDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InMageAzureV2ProtectedDiskDetails
        /// class.
        /// </summary>
        /// <param name="diskId">The disk id.</param>
        /// <param name="diskName">The disk name.</param>
        /// <param name="protectionStage">The protection stage.</param>
        /// <param name="healthErrorCode">The health error code for the
        /// disk.</param>
        /// <param name="rpoInSeconds">The RPO in seconds.</param>
        /// <param name="resyncRequired">A value indicating whether resync is
        /// required for this disk.</param>
        /// <param name="resyncProgressPercentage">The resync progress
        /// percentage.</param>
        /// <param name="resyncDurationInSeconds">The resync duration in
        /// seconds.</param>
        /// <param name="diskCapacityInBytes">The disk capacity in
        /// bytes.</param>
        /// <param name="fileSystemCapacityInBytes">The disk file system
        /// capacity in bytes.</param>
        /// <param name="sourceDataInMegaBytes">The source data transit in
        /// MB.</param>
        /// <param name="psDataInMegaBytes">The PS data transit in MB.</param>
        /// <param name="targetDataInMegaBytes">The target data transit in
        /// MB.</param>
        /// <param name="diskResized">A value indicating whether disk is
        /// resized.</param>
        /// <param name="lastRpoCalculatedTime">The last RPO calculated
        /// time.</param>
        /// <param name="resyncProcessedBytes">The resync processed
        /// bytes.</param>
        /// <param name="resyncTotalTransferredBytes">The resync total
        /// transferred bytes.</param>
        /// <param name="resyncLast15MinutesTransferredBytes">The resync last
        /// 15 minutes transferred bytes.</param>
        /// <param name="resyncLastDataTransferTimeUTC">The last data transfer
        /// time in UTC.</param>
        /// <param name="resyncStartTime">The resync start time.</param>
        /// <param name="progressHealth">The Progress Health.</param>
        /// <param name="progressStatus">The Progress Status.</param>
        /// <param name="secondsToTakeSwitchProvider">The seconds to take for
        /// switch provider.</param>
        public InMageAzureV2ProtectedDiskDetails(string diskId = default(string), string diskName = default(string), string protectionStage = default(string), string healthErrorCode = default(string), long? rpoInSeconds = default(long?), string resyncRequired = default(string), int? resyncProgressPercentage = default(int?), long? resyncDurationInSeconds = default(long?), long? diskCapacityInBytes = default(long?), long? fileSystemCapacityInBytes = default(long?), double? sourceDataInMegaBytes = default(double?), double? psDataInMegaBytes = default(double?), double? targetDataInMegaBytes = default(double?), string diskResized = default(string), System.DateTime? lastRpoCalculatedTime = default(System.DateTime?), long? resyncProcessedBytes = default(long?), long? resyncTotalTransferredBytes = default(long?), long? resyncLast15MinutesTransferredBytes = default(long?), System.DateTime? resyncLastDataTransferTimeUTC = default(System.DateTime?), System.DateTime? resyncStartTime = default(System.DateTime?), string progressHealth = default(string), string progressStatus = default(string), long? secondsToTakeSwitchProvider = default(long?))
        {
            DiskId = diskId;
            DiskName = diskName;
            ProtectionStage = protectionStage;
            HealthErrorCode = healthErrorCode;
            RpoInSeconds = rpoInSeconds;
            ResyncRequired = resyncRequired;
            ResyncProgressPercentage = resyncProgressPercentage;
            ResyncDurationInSeconds = resyncDurationInSeconds;
            DiskCapacityInBytes = diskCapacityInBytes;
            FileSystemCapacityInBytes = fileSystemCapacityInBytes;
            SourceDataInMegaBytes = sourceDataInMegaBytes;
            PsDataInMegaBytes = psDataInMegaBytes;
            TargetDataInMegaBytes = targetDataInMegaBytes;
            DiskResized = diskResized;
            LastRpoCalculatedTime = lastRpoCalculatedTime;
            ResyncProcessedBytes = resyncProcessedBytes;
            ResyncTotalTransferredBytes = resyncTotalTransferredBytes;
            ResyncLast15MinutesTransferredBytes = resyncLast15MinutesTransferredBytes;
            ResyncLastDataTransferTimeUTC = resyncLastDataTransferTimeUTC;
            ResyncStartTime = resyncStartTime;
            ProgressHealth = progressHealth;
            ProgressStatus = progressStatus;
            SecondsToTakeSwitchProvider = secondsToTakeSwitchProvider;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the disk id.
        /// </summary>
        [JsonProperty(PropertyName = "diskId")]
        public string DiskId { get; set; }

        /// <summary>
        /// Gets or sets the disk name.
        /// </summary>
        [JsonProperty(PropertyName = "diskName")]
        public string DiskName { get; set; }

        /// <summary>
        /// Gets or sets the protection stage.
        /// </summary>
        [JsonProperty(PropertyName = "protectionStage")]
        public string ProtectionStage { get; set; }

        /// <summary>
        /// Gets or sets the health error code for the disk.
        /// </summary>
        [JsonProperty(PropertyName = "healthErrorCode")]
        public string HealthErrorCode { get; set; }

        /// <summary>
        /// Gets or sets the RPO in seconds.
        /// </summary>
        [JsonProperty(PropertyName = "rpoInSeconds")]
        public long? RpoInSeconds { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether resync is required for this
        /// disk.
        /// </summary>
        [JsonProperty(PropertyName = "resyncRequired")]
        public string ResyncRequired { get; set; }

        /// <summary>
        /// Gets or sets the resync progress percentage.
        /// </summary>
        [JsonProperty(PropertyName = "resyncProgressPercentage")]
        public int? ResyncProgressPercentage { get; set; }

        /// <summary>
        /// Gets or sets the resync duration in seconds.
        /// </summary>
        [JsonProperty(PropertyName = "resyncDurationInSeconds")]
        public long? ResyncDurationInSeconds { get; set; }

        /// <summary>
        /// Gets or sets the disk capacity in bytes.
        /// </summary>
        [JsonProperty(PropertyName = "diskCapacityInBytes")]
        public long? DiskCapacityInBytes { get; set; }

        /// <summary>
        /// Gets or sets the disk file system capacity in bytes.
        /// </summary>
        [JsonProperty(PropertyName = "fileSystemCapacityInBytes")]
        public long? FileSystemCapacityInBytes { get; set; }

        /// <summary>
        /// Gets or sets the source data transit in MB.
        /// </summary>
        [JsonProperty(PropertyName = "sourceDataInMegaBytes")]
        public double? SourceDataInMegaBytes { get; set; }

        /// <summary>
        /// Gets or sets the PS data transit in MB.
        /// </summary>
        [JsonProperty(PropertyName = "psDataInMegaBytes")]
        public double? PsDataInMegaBytes { get; set; }

        /// <summary>
        /// Gets or sets the target data transit in MB.
        /// </summary>
        [JsonProperty(PropertyName = "targetDataInMegaBytes")]
        public double? TargetDataInMegaBytes { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether disk is resized.
        /// </summary>
        [JsonProperty(PropertyName = "diskResized")]
        public string DiskResized { get; set; }

        /// <summary>
        /// Gets or sets the last RPO calculated time.
        /// </summary>
        [JsonProperty(PropertyName = "lastRpoCalculatedTime")]
        public System.DateTime? LastRpoCalculatedTime { get; set; }

        /// <summary>
        /// Gets or sets the resync processed bytes.
        /// </summary>
        [JsonProperty(PropertyName = "resyncProcessedBytes")]
        public long? ResyncProcessedBytes { get; set; }

        /// <summary>
        /// Gets or sets the resync total transferred bytes.
        /// </summary>
        [JsonProperty(PropertyName = "resyncTotalTransferredBytes")]
        public long? ResyncTotalTransferredBytes { get; set; }

        /// <summary>
        /// Gets or sets the resync last 15 minutes transferred bytes.
        /// </summary>
        [JsonProperty(PropertyName = "resyncLast15MinutesTransferredBytes")]
        public long? ResyncLast15MinutesTransferredBytes { get; set; }

        /// <summary>
        /// Gets or sets the last data transfer time in UTC.
        /// </summary>
        [JsonProperty(PropertyName = "resyncLastDataTransferTimeUTC")]
        public System.DateTime? ResyncLastDataTransferTimeUTC { get; set; }

        /// <summary>
        /// Gets or sets the resync start time.
        /// </summary>
        [JsonProperty(PropertyName = "resyncStartTime")]
        public System.DateTime? ResyncStartTime { get; set; }

        /// <summary>
        /// Gets or sets the Progress Health.
        /// </summary>
        [JsonProperty(PropertyName = "progressHealth")]
        public string ProgressHealth { get; set; }

        /// <summary>
        /// Gets or sets the Progress Status.
        /// </summary>
        [JsonProperty(PropertyName = "progressStatus")]
        public string ProgressStatus { get; set; }

        /// <summary>
        /// Gets or sets the seconds to take for switch provider.
        /// </summary>
        [JsonProperty(PropertyName = "secondsToTakeSwitchProvider")]
        public long? SecondsToTakeSwitchProvider { get; set; }

    }
}
