// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Extensions;

    /// <summary>Properties that contain a workbook.</summary>
    public partial class WorkbookProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookProperties,
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookPropertiesInternal
    {

        /// <summary>Backing field for <see cref="Category" /> property.</summary>
        private string _category;

        /// <summary>Workbook category, as defined by the user at creation time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.FormatTable(Index = 5)]
        public string Category { get => this._category; set => this._category = value; }

        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>The description of the workbook.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.DoNotFormat]
        public string Description { get => this._description; set => this._description = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>The user-defined name (display name) of the workbook.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.FormatTable(Index = 2)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Internal Acessors for Revision</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookPropertiesInternal.Revision { get => this._revision; set { {_revision = value;} } }

        /// <summary>Internal Acessors for TimeModified</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookPropertiesInternal.TimeModified { get => this._timeModified; set { {_timeModified = value;} } }

        /// <summary>Internal Acessors for UserId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Models.Api20220401.IWorkbookPropertiesInternal.UserId { get => this._userId; set { {_userId = value;} } }

        /// <summary>Backing field for <see cref="Revision" /> property.</summary>
        private string _revision;

        /// <summary>The unique revision id for this workbook definition</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.DoNotFormat]
        public string Revision { get => this._revision; }

        /// <summary>Backing field for <see cref="SerializedData" /> property.</summary>
        private string _serializedData;

        /// <summary>
        /// Configuration of this particular workbook. Configuration data is a string containing valid JSON
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.DoNotFormat]
        public string SerializedData { get => this._serializedData; set => this._serializedData = value; }

        /// <summary>Backing field for <see cref="SourceId" /> property.</summary>
        private string _sourceId;

        /// <summary>ResourceId for a source resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.DoNotFormat]
        public string SourceId { get => this._sourceId; set => this._sourceId = value; }

        /// <summary>Backing field for <see cref="StorageUri" /> property.</summary>
        private string _storageUri;

        /// <summary>The resourceId to the storage account when bring your own storage is used</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.DoNotFormat]
        public string StorageUri { get => this._storageUri; set => this._storageUri = value; }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private string[] _tag;

        /// <summary>Being deprecated, please use the other tags field</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.DoNotFormat]
        public string[] Tag { get => this._tag; set => this._tag = value; }

        /// <summary>Backing field for <see cref="TimeModified" /> property.</summary>
        private global::System.DateTime? _timeModified;

        /// <summary>
        /// Date and time in UTC of the last modification that was made to this workbook definition.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.DoNotFormat]
        public global::System.DateTime? TimeModified { get => this._timeModified; }

        /// <summary>Backing field for <see cref="UserId" /> property.</summary>
        private string _userId;

        /// <summary>Unique user id of the specific user that owns this workbook.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.DoNotFormat]
        public string UserId { get => this._userId; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private string _version;

        /// <summary>
        /// Workbook schema version format, like 'Notebook/1.0', which should match the workbook in serializedData
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Origin(Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.PropertyOrigin.Owned)]
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.DoNotFormat]
        public string Version { get => this._version; set => this._version = value; }

        /// <summary>Creates an new <see cref="WorkbookProperties" /> instance.</summary>
        public WorkbookProperties()
        {

        }
    }
    /// Properties that contain a workbook.
    public partial interface IWorkbookProperties :
        Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.IJsonSerializable
    {
        /// <summary>Workbook category, as defined by the user at creation time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Workbook category, as defined by the user at creation time.",
        SerializedName = @"category",
        PossibleTypes = new [] { typeof(string) })]
        string Category { get; set; }
        /// <summary>The description of the workbook.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The description of the workbook.",
        SerializedName = @"description",
        PossibleTypes = new [] { typeof(string) })]
        string Description { get; set; }
        /// <summary>The user-defined name (display name) of the workbook.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"The user-defined name (display name) of the workbook.",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>The unique revision id for this workbook definition</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The unique revision id for this workbook definition",
        SerializedName = @"revision",
        PossibleTypes = new [] { typeof(string) })]
        string Revision { get;  }
        /// <summary>
        /// Configuration of this particular workbook. Configuration data is a string containing valid JSON
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Configuration of this particular workbook. Configuration data is a string containing valid JSON",
        SerializedName = @"serializedData",
        PossibleTypes = new [] { typeof(string) })]
        string SerializedData { get; set; }
        /// <summary>ResourceId for a source resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ResourceId for a source resource.",
        SerializedName = @"sourceId",
        PossibleTypes = new [] { typeof(string) })]
        string SourceId { get; set; }
        /// <summary>The resourceId to the storage account when bring your own storage is used</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resourceId to the storage account when bring your own storage is used",
        SerializedName = @"storageUri",
        PossibleTypes = new [] { typeof(string) })]
        string StorageUri { get; set; }
        /// <summary>Being deprecated, please use the other tags field</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Being deprecated, please use the other tags field",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(string) })]
        string[] Tag { get; set; }
        /// <summary>
        /// Date and time in UTC of the last modification that was made to this workbook definition.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Date and time in UTC of the last modification that was made to this workbook definition.",
        SerializedName = @"timeModified",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? TimeModified { get;  }
        /// <summary>Unique user id of the specific user that owns this workbook.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Unique user id of the specific user that owns this workbook.",
        SerializedName = @"userId",
        PossibleTypes = new [] { typeof(string) })]
        string UserId { get;  }
        /// <summary>
        /// Workbook schema version format, like 'Notebook/1.0', which should match the workbook in serializedData
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.ApplicationInsights.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Workbook schema version format, like 'Notebook/1.0', which should match the workbook in serializedData",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(string) })]
        string Version { get; set; }

    }
    /// Properties that contain a workbook.
    internal partial interface IWorkbookPropertiesInternal

    {
        /// <summary>Workbook category, as defined by the user at creation time.</summary>
        string Category { get; set; }
        /// <summary>The description of the workbook.</summary>
        string Description { get; set; }
        /// <summary>The user-defined name (display name) of the workbook.</summary>
        string DisplayName { get; set; }
        /// <summary>The unique revision id for this workbook definition</summary>
        string Revision { get; set; }
        /// <summary>
        /// Configuration of this particular workbook. Configuration data is a string containing valid JSON
        /// </summary>
        string SerializedData { get; set; }
        /// <summary>ResourceId for a source resource.</summary>
        string SourceId { get; set; }
        /// <summary>The resourceId to the storage account when bring your own storage is used</summary>
        string StorageUri { get; set; }
        /// <summary>Being deprecated, please use the other tags field</summary>
        string[] Tag { get; set; }
        /// <summary>
        /// Date and time in UTC of the last modification that was made to this workbook definition.
        /// </summary>
        global::System.DateTime? TimeModified { get; set; }
        /// <summary>Unique user id of the specific user that owns this workbook.</summary>
        string UserId { get; set; }
        /// <summary>
        /// Workbook schema version format, like 'Notebook/1.0', which should match the workbook in serializedData
        /// </summary>
        string Version { get; set; }

    }
}