// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Extensions;

    /// <summary>Backup Vault</summary>
    public partial class BackupVault :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IBackupVault,
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IBackupVaultInternal
    {

        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.AlertsState? AzureMonitorAlertsForAllJobFailure { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IMonitoringSettingsInternal)MonitoringSetting).AzureMonitorAlertsForAllJobFailure; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IMonitoringSettingsInternal)MonitoringSetting).AzureMonitorAlertsForAllJobFailure = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.AlertsState)""); }

        /// <summary>CrossSubscriptionRestore state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.CrossSubscriptionRestoreState? CrossSubscriptionRestoreState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IFeatureSettingsInternal)FeatureSetting).CrossSubscriptionRestoreState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IFeatureSettingsInternal)FeatureSetting).CrossSubscriptionRestoreState = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.CrossSubscriptionRestoreState)""); }

        /// <summary>Backing field for <see cref="FeatureSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IFeatureSettings _featureSetting;

        /// <summary>Feature Settings</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IFeatureSettings FeatureSetting { get => (this._featureSetting = this._featureSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.FeatureSettings()); set => this._featureSetting = value; }

        /// <summary>Immutability state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ImmutabilityState? ImmutabilityState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.ISecuritySettingsInternal)SecuritySetting).ImmutabilityState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.ISecuritySettingsInternal)SecuritySetting).ImmutabilityState = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ImmutabilityState)""); }

        /// <summary>Backing field for <see cref="IsVaultProtectedByResourceGuard" /> property.</summary>
        private bool? _isVaultProtectedByResourceGuard;

        /// <summary>Is vault protected by resource guard</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public bool? IsVaultProtectedByResourceGuard { get => this._isVaultProtectedByResourceGuard; }

        /// <summary>Internal Acessors for FeatureSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IFeatureSettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IBackupVaultInternal.FeatureSetting { get => (this._featureSetting = this._featureSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.FeatureSettings()); set { {_featureSetting = value;} } }

        /// <summary>Internal Acessors for FeatureSettingCrossSubscriptionRestoreSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.ICrossSubscriptionRestoreSettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IBackupVaultInternal.FeatureSettingCrossSubscriptionRestoreSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IFeatureSettingsInternal)FeatureSetting).CrossSubscriptionRestoreSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IFeatureSettingsInternal)FeatureSetting).CrossSubscriptionRestoreSetting = value; }

        /// <summary>Internal Acessors for IsVaultProtectedByResourceGuard</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IBackupVaultInternal.IsVaultProtectedByResourceGuard { get => this._isVaultProtectedByResourceGuard; set { {_isVaultProtectedByResourceGuard = value;} } }

        /// <summary>Internal Acessors for MonitoringSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IMonitoringSettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IBackupVaultInternal.MonitoringSetting { get => (this._monitoringSetting = this._monitoringSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.MonitoringSettings()); set { {_monitoringSetting = value;} } }

        /// <summary>Internal Acessors for MonitoringSettingAzureMonitorAlertSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IAzureMonitorAlertSettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IBackupVaultInternal.MonitoringSettingAzureMonitorAlertSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IMonitoringSettingsInternal)MonitoringSetting).AzureMonitorAlertSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IMonitoringSettingsInternal)MonitoringSetting).AzureMonitorAlertSetting = value; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IBackupVaultInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for ResourceMoveDetail</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IResourceMoveDetails Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IBackupVaultInternal.ResourceMoveDetail { get => (this._resourceMoveDetail = this._resourceMoveDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.ResourceMoveDetails()); set { {_resourceMoveDetail = value;} } }

        /// <summary>Internal Acessors for ResourceMoveState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ResourceMoveState? Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IBackupVaultInternal.ResourceMoveState { get => this._resourceMoveState; set { {_resourceMoveState = value;} } }

        /// <summary>Internal Acessors for SecuritySetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.ISecuritySettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IBackupVaultInternal.SecuritySetting { get => (this._securitySetting = this._securitySetting ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.SecuritySettings()); set { {_securitySetting = value;} } }

        /// <summary>Internal Acessors for SecuritySettingImmutabilitySetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IImmutabilitySettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IBackupVaultInternal.SecuritySettingImmutabilitySetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.ISecuritySettingsInternal)SecuritySetting).ImmutabilitySetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.ISecuritySettingsInternal)SecuritySetting).ImmutabilitySetting = value; }

        /// <summary>Internal Acessors for SoftDeleteSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.ISoftDeleteSettings Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IBackupVaultInternal.SoftDeleteSetting { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.ISecuritySettingsInternal)SecuritySetting).SoftDeleteSetting; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.ISecuritySettingsInternal)SecuritySetting).SoftDeleteSetting = value; }

        /// <summary>Backing field for <see cref="MonitoringSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IMonitoringSettings _monitoringSetting;

        /// <summary>Monitoring Settings</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IMonitoringSettings MonitoringSetting { get => (this._monitoringSetting = this._monitoringSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.MonitoringSettings()); set => this._monitoringSetting = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ProvisioningState? _provisioningState;

        /// <summary>Provisioning state of the BackupVault resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ProvisioningState? ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="ResourceMoveDetail" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IResourceMoveDetails _resourceMoveDetail;

        /// <summary>Resource move details for backup vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IResourceMoveDetails ResourceMoveDetail { get => (this._resourceMoveDetail = this._resourceMoveDetail ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.ResourceMoveDetails()); }

        /// <summary>
        /// Completion time in UTC of latest ResourceMove operation attempted. ISO 8601 format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string ResourceMoveDetailCompletionTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IResourceMoveDetailsInternal)ResourceMoveDetail).CompletionTimeUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IResourceMoveDetailsInternal)ResourceMoveDetail).CompletionTimeUtc = value ?? null; }

        /// <summary>CorrelationId of latest ResourceMove operation attempted</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string ResourceMoveDetailOperationId { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IResourceMoveDetailsInternal)ResourceMoveDetail).OperationId; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IResourceMoveDetailsInternal)ResourceMoveDetail).OperationId = value ?? null; }

        /// <summary>ARM resource path of source resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string ResourceMoveDetailSourceResourcePath { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IResourceMoveDetailsInternal)ResourceMoveDetail).SourceResourcePath; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IResourceMoveDetailsInternal)ResourceMoveDetail).SourceResourcePath = value ?? null; }

        /// <summary>Start time in UTC of latest ResourceMove operation attempted. ISO 8601 format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string ResourceMoveDetailStartTimeUtc { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IResourceMoveDetailsInternal)ResourceMoveDetail).StartTimeUtc; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IResourceMoveDetailsInternal)ResourceMoveDetail).StartTimeUtc = value ?? null; }

        /// <summary>ARM resource path of target resource used in latest ResourceMove operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public string ResourceMoveDetailTargetResourcePath { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IResourceMoveDetailsInternal)ResourceMoveDetail).TargetResourcePath; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IResourceMoveDetailsInternal)ResourceMoveDetail).TargetResourcePath = value ?? null; }

        /// <summary>Backing field for <see cref="ResourceMoveState" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ResourceMoveState? _resourceMoveState;

        /// <summary>Resource move state for backup vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ResourceMoveState? ResourceMoveState { get => this._resourceMoveState; }

        /// <summary>Backing field for <see cref="SecuritySetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.ISecuritySettings _securitySetting;

        /// <summary>Security Settings</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.ISecuritySettings SecuritySetting { get => (this._securitySetting = this._securitySetting ?? new Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.SecuritySettings()); set => this._securitySetting = value; }

        /// <summary>Soft delete retention duration</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public double? SoftDeleteRetentionDurationInDay { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.ISecuritySettingsInternal)SecuritySetting).SoftDeleteRetentionDurationInDay; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.ISecuritySettingsInternal)SecuritySetting).SoftDeleteRetentionDurationInDay = value ?? default(double); }

        /// <summary>State of soft delete</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SoftDeleteState? SoftDeleteState { get => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.ISecuritySettingsInternal)SecuritySetting).SoftDeleteState; set => ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.ISecuritySettingsInternal)SecuritySetting).SoftDeleteState = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SoftDeleteState)""); }

        /// <summary>Backing field for <see cref="StorageSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IStorageSetting[] _storageSetting;

        /// <summary>Storage Settings</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Origin(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IStorageSetting[] StorageSetting { get => this._storageSetting; set => this._storageSetting = value; }

        /// <summary>Creates an new <see cref="BackupVault" /> instance.</summary>
        public BackupVault()
        {

        }
    }
    /// Backup Vault
    public partial interface IBackupVault :
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.IJsonSerializable
    {
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"alertsForAllJobFailures",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.AlertsState) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.AlertsState? AzureMonitorAlertsForAllJobFailure { get; set; }
        /// <summary>CrossSubscriptionRestore state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"CrossSubscriptionRestore state",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.CrossSubscriptionRestoreState) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.CrossSubscriptionRestoreState? CrossSubscriptionRestoreState { get; set; }
        /// <summary>Immutability state</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Immutability state",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ImmutabilityState) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ImmutabilityState? ImmutabilityState { get; set; }
        /// <summary>Is vault protected by resource guard</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Is vault protected by resource guard",
        SerializedName = @"isVaultProtectedByResourceGuard",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsVaultProtectedByResourceGuard { get;  }
        /// <summary>Provisioning state of the BackupVault resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Provisioning state of the BackupVault resource",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>
        /// Completion time in UTC of latest ResourceMove operation attempted. ISO 8601 format.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Completion time in UTC of latest ResourceMove operation attempted. ISO 8601 format.",
        SerializedName = @"completionTimeUtc",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceMoveDetailCompletionTimeUtc { get; set; }
        /// <summary>CorrelationId of latest ResourceMove operation attempted</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"CorrelationId of latest ResourceMove operation attempted",
        SerializedName = @"operationId",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceMoveDetailOperationId { get; set; }
        /// <summary>ARM resource path of source resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ARM resource path of source resource",
        SerializedName = @"sourceResourcePath",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceMoveDetailSourceResourcePath { get; set; }
        /// <summary>Start time in UTC of latest ResourceMove operation attempted. ISO 8601 format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Start time in UTC of latest ResourceMove operation attempted. ISO 8601 format.",
        SerializedName = @"startTimeUtc",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceMoveDetailStartTimeUtc { get; set; }
        /// <summary>ARM resource path of target resource used in latest ResourceMove operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ARM resource path of target resource used in latest ResourceMove operation",
        SerializedName = @"targetResourcePath",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceMoveDetailTargetResourcePath { get; set; }
        /// <summary>Resource move state for backup vault</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Resource move state for backup vault",
        SerializedName = @"resourceMoveState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ResourceMoveState) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ResourceMoveState? ResourceMoveState { get;  }
        /// <summary>Soft delete retention duration</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Soft delete retention duration",
        SerializedName = @"retentionDurationInDays",
        PossibleTypes = new [] { typeof(double) })]
        double? SoftDeleteRetentionDurationInDay { get; set; }
        /// <summary>State of soft delete</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"State of soft delete",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SoftDeleteState) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SoftDeleteState? SoftDeleteState { get; set; }
        /// <summary>Storage Settings</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Storage Settings",
        SerializedName = @"storageSettings",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IStorageSetting) })]
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IStorageSetting[] StorageSetting { get; set; }

    }
    /// Backup Vault
    internal partial interface IBackupVaultInternal

    {
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.AlertsState? AzureMonitorAlertsForAllJobFailure { get; set; }
        /// <summary>CrossSubscriptionRestore state</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.CrossSubscriptionRestoreState? CrossSubscriptionRestoreState { get; set; }
        /// <summary>Feature Settings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IFeatureSettings FeatureSetting { get; set; }
        /// <summary>CrossSubscriptionRestore Settings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.ICrossSubscriptionRestoreSettings FeatureSettingCrossSubscriptionRestoreSetting { get; set; }
        /// <summary>Immutability state</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ImmutabilityState? ImmutabilityState { get; set; }
        /// <summary>Is vault protected by resource guard</summary>
        bool? IsVaultProtectedByResourceGuard { get; set; }
        /// <summary>Monitoring Settings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IMonitoringSettings MonitoringSetting { get; set; }
        /// <summary>Settings for Azure Monitor based alerts</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IAzureMonitorAlertSettings MonitoringSettingAzureMonitorAlertSetting { get; set; }
        /// <summary>Provisioning state of the BackupVault resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>Resource move details for backup vault</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IResourceMoveDetails ResourceMoveDetail { get; set; }
        /// <summary>
        /// Completion time in UTC of latest ResourceMove operation attempted. ISO 8601 format.
        /// </summary>
        string ResourceMoveDetailCompletionTimeUtc { get; set; }
        /// <summary>CorrelationId of latest ResourceMove operation attempted</summary>
        string ResourceMoveDetailOperationId { get; set; }
        /// <summary>ARM resource path of source resource</summary>
        string ResourceMoveDetailSourceResourcePath { get; set; }
        /// <summary>Start time in UTC of latest ResourceMove operation attempted. ISO 8601 format.</summary>
        string ResourceMoveDetailStartTimeUtc { get; set; }
        /// <summary>ARM resource path of target resource used in latest ResourceMove operation</summary>
        string ResourceMoveDetailTargetResourcePath { get; set; }
        /// <summary>Resource move state for backup vault</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.ResourceMoveState? ResourceMoveState { get; set; }
        /// <summary>Security Settings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.ISecuritySettings SecuritySetting { get; set; }
        /// <summary>Immutability Settings at vault level</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IImmutabilitySettings SecuritySettingImmutabilitySetting { get; set; }
        /// <summary>Soft delete retention duration</summary>
        double? SoftDeleteRetentionDurationInDay { get; set; }
        /// <summary>Soft delete related settings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.ISoftDeleteSettings SoftDeleteSetting { get; set; }
        /// <summary>State of soft delete</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Support.SoftDeleteState? SoftDeleteState { get; set; }
        /// <summary>Storage Settings</summary>
        Microsoft.Azure.PowerShell.Cmdlets.DataProtection.Models.Api202301.IStorageSetting[] StorageSetting { get; set; }

    }
}