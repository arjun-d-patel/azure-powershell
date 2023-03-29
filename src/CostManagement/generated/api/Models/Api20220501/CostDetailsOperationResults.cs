// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Extensions;

    /// <summary>The result of the long running operation for cost details Api.</summary>
    public partial class CostDetailsOperationResults :
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.ICostDetailsOperationResults,
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.ICostDetailsOperationResultsInternal
    {

        /// <summary>Error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Inlined)]
        public string Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IErrorDetailsInternal)Error).Code; }

        /// <summary>Backing field for <see cref="Error" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IErrorDetails _error;

        /// <summary>The details of the error.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IErrorDetails Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.ErrorDetails()); set => this._error = value; }

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The id of the long running operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Backing field for <see cref="Manifest" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.IReportManifest _manifest;

        /// <summary>The manifest of the report generated by the operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.IReportManifest Manifest { get => (this._manifest = this._manifest ?? new Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.ReportManifest()); set => this._manifest = value; }

        /// <summary>List of blob information generated by this operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.IBlobInfo[] ManifestBlob { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.IReportManifestInternal)Manifest).Blob; set => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.IReportManifestInternal)Manifest).Blob = value ?? null /* arrayOf */; }

        /// <summary>The total number of blobs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Inlined)]
        public int? ManifestBlobCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.IReportManifestInternal)Manifest).BlobCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.IReportManifestInternal)Manifest).BlobCount = value ?? default(int); }

        /// <summary>The total number of bytes in all blobs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Inlined)]
        public long? ManifestByteCount { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.IReportManifestInternal)Manifest).ByteCount; set => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.IReportManifestInternal)Manifest).ByteCount = value ?? default(long); }

        /// <summary>Is the data in compressed format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Inlined)]
        public bool? ManifestCompressData { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.IReportManifestInternal)Manifest).CompressData; set => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.IReportManifestInternal)Manifest).CompressData = value ?? default(bool); }

        /// <summary>The data format of the report</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.CostDetailsDataFormat? ManifestDataFormat { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.IReportManifestInternal)Manifest).DataFormat; set => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.IReportManifestInternal)Manifest).DataFormat = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.CostDetailsDataFormat)""); }

        /// <summary>The Manifest version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Inlined)]
        public string ManifestVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.IReportManifestInternal)Manifest).ManifestVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.IReportManifestInternal)Manifest).ManifestVersion = value ?? null; }

        /// <summary>Error message indicating why the operation failed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Inlined)]
        public string Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IErrorDetailsInternal)Error).Message; }

        /// <summary>Internal Acessors for Code</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.ICostDetailsOperationResultsInternal.Code { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IErrorDetailsInternal)Error).Code; set => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IErrorDetailsInternal)Error).Code = value; }

        /// <summary>Internal Acessors for Error</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IErrorDetails Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.ICostDetailsOperationResultsInternal.Error { get => (this._error = this._error ?? new Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.ErrorDetails()); set { {_error = value;} } }

        /// <summary>Internal Acessors for Manifest</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.IReportManifest Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.ICostDetailsOperationResultsInternal.Manifest { get => (this._manifest = this._manifest ?? new Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.ReportManifest()); set { {_manifest = value;} } }

        /// <summary>Internal Acessors for ManifestRequestContext</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.IRequestContext Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.ICostDetailsOperationResultsInternal.ManifestRequestContext { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.IReportManifestInternal)Manifest).RequestContext; set => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.IReportManifestInternal)Manifest).RequestContext = value; }

        /// <summary>Internal Acessors for Message</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.ICostDetailsOperationResultsInternal.Message { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IErrorDetailsInternal)Error).Message; set => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IErrorDetailsInternal)Error).Message = value; }

        /// <summary>Internal Acessors for RequestBodyTimePeriod</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.ICostDetailsTimePeriod Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.ICostDetailsOperationResultsInternal.RequestBodyTimePeriod { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.IReportManifestInternal)Manifest).RequestBodyTimePeriod; set => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.IReportManifestInternal)Manifest).RequestBodyTimePeriod = value; }

        /// <summary>Internal Acessors for RequestContextRequestBody</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.IGenerateCostDetailsReportRequestDefinition Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.ICostDetailsOperationResultsInternal.RequestContextRequestBody { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.IReportManifestInternal)Manifest).RequestContextRequestBody; set => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.IReportManifestInternal)Manifest).RequestContextRequestBody = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name of the long running operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>
        /// This parameter can be used only by Enterprise Agreement customers. Use the YearMonth(e.g. 202008) format. This parameter
        /// cannot be used alongside either the invoiceId or timePeriod parameters. If a timePeriod, invoiceId or billingPeriod parameter
        /// is not provided in the request body the API will return the current month's cost.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Inlined)]
        public string RequestBodyBillingPeriod { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.IReportManifestInternal)Manifest).RequestBodyBillingPeriod; set => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.IReportManifestInternal)Manifest).RequestBodyBillingPeriod = value ?? null; }

        /// <summary>
        /// This parameter can only be used by Microsoft Customer Agreement customers. Additionally, it can only be used at the Billing
        /// Profile or Customer scope. This parameter cannot be used alongside either the billingPeriod or timePeriod parameters.
        /// If a timePeriod, invoiceId or billingPeriod parameter is not provided in the request body the API will return the current
        /// month's cost.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Inlined)]
        public string RequestBodyInvoiceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.IReportManifestInternal)Manifest).RequestBodyInvoiceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.IReportManifestInternal)Manifest).RequestBodyInvoiceId = value ?? null; }

        /// <summary>The type of the detailed report. By default ActualCost is provided</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.CostDetailsMetricType? RequestBodyMetric { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.IReportManifestInternal)Manifest).RequestBodyMetric; set => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.IReportManifestInternal)Manifest).RequestBodyMetric = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.CostDetailsMetricType)""); }

        /// <summary>The request scope of the request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Inlined)]
        public string RequestContextRequestScope { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.IReportManifestInternal)Manifest).RequestContextRequestScope; set => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.IReportManifestInternal)Manifest).RequestContextRequestScope = value ?? null; }

        /// <summary>Backing field for <see cref="Status" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.CostDetailsStatusType? _status;

        /// <summary>The status of the cost details operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.CostDetailsStatusType? Status { get => this._status; set => this._status = value; }

        /// <summary>The end date to pull data to. example format 2020-03-15</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Inlined)]
        public string TimePeriodEnd { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.IReportManifestInternal)Manifest).TimePeriodEnd; set => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.IReportManifestInternal)Manifest).TimePeriodEnd = value ?? null; }

        /// <summary>The start date to pull data from. example format 2020-03-15</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Inlined)]
        public string TimePeriodStart { get => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.IReportManifestInternal)Manifest).TimePeriodStart; set => ((Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.IReportManifestInternal)Manifest).TimePeriodStart = value ?? null; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>The type of the long running operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Owned)]
        public string Type { get => this._type; set => this._type = value; }

        /// <summary>Backing field for <see cref="ValidTill" /> property.</summary>
        private global::System.DateTime? _validTill;

        /// <summary>
        /// The time at which report URL becomes invalid/expires in UTC e.g. 2020-12-08T05:55:59.4394737Z.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Origin(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.PropertyOrigin.Owned)]
        public global::System.DateTime? ValidTill { get => this._validTill; set => this._validTill = value; }

        /// <summary>Creates an new <see cref="CostDetailsOperationResults" /> instance.</summary>
        public CostDetailsOperationResults()
        {

        }
    }
    /// The result of the long running operation for cost details Api.
    public partial interface ICostDetailsOperationResults :
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.IJsonSerializable
    {
        /// <summary>Error code.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Error code.",
        SerializedName = @"code",
        PossibleTypes = new [] { typeof(string) })]
        string Code { get;  }
        /// <summary>The id of the long running operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The id of the long running operation.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }
        /// <summary>List of blob information generated by this operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of blob information generated by this operation.",
        SerializedName = @"blobs",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.IBlobInfo) })]
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.IBlobInfo[] ManifestBlob { get; set; }
        /// <summary>The total number of blobs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The total number of blobs.",
        SerializedName = @"blobCount",
        PossibleTypes = new [] { typeof(int) })]
        int? ManifestBlobCount { get; set; }
        /// <summary>The total number of bytes in all blobs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The total number of bytes in all blobs.",
        SerializedName = @"byteCount",
        PossibleTypes = new [] { typeof(long) })]
        long? ManifestByteCount { get; set; }
        /// <summary>Is the data in compressed format.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Is the data in compressed format.",
        SerializedName = @"compressData",
        PossibleTypes = new [] { typeof(bool) })]
        bool? ManifestCompressData { get; set; }
        /// <summary>The data format of the report</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The data format of the report",
        SerializedName = @"dataFormat",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.CostDetailsDataFormat) })]
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.CostDetailsDataFormat? ManifestDataFormat { get; set; }
        /// <summary>The Manifest version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Manifest version.",
        SerializedName = @"manifestVersion",
        PossibleTypes = new [] { typeof(string) })]
        string ManifestVersion { get; set; }
        /// <summary>Error message indicating why the operation failed.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Error message indicating why the operation failed.",
        SerializedName = @"message",
        PossibleTypes = new [] { typeof(string) })]
        string Message { get;  }
        /// <summary>The name of the long running operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The name of the long running operation.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>
        /// This parameter can be used only by Enterprise Agreement customers. Use the YearMonth(e.g. 202008) format. This parameter
        /// cannot be used alongside either the invoiceId or timePeriod parameters. If a timePeriod, invoiceId or billingPeriod parameter
        /// is not provided in the request body the API will return the current month's cost.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This parameter can be used only by Enterprise Agreement customers. Use the YearMonth(e.g. 202008) format. This parameter cannot be used alongside either the invoiceId or timePeriod parameters. If a timePeriod, invoiceId or billingPeriod parameter is not provided in the request body the API will return the current month's cost.",
        SerializedName = @"billingPeriod",
        PossibleTypes = new [] { typeof(string) })]
        string RequestBodyBillingPeriod { get; set; }
        /// <summary>
        /// This parameter can only be used by Microsoft Customer Agreement customers. Additionally, it can only be used at the Billing
        /// Profile or Customer scope. This parameter cannot be used alongside either the billingPeriod or timePeriod parameters.
        /// If a timePeriod, invoiceId or billingPeriod parameter is not provided in the request body the API will return the current
        /// month's cost.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"This parameter can only be used by Microsoft Customer Agreement customers. Additionally, it can only be used at the Billing Profile or Customer scope. This parameter cannot be used alongside either the billingPeriod or timePeriod parameters. If a timePeriod, invoiceId or billingPeriod parameter is not provided in the request body the API will return the current month's cost.",
        SerializedName = @"invoiceId",
        PossibleTypes = new [] { typeof(string) })]
        string RequestBodyInvoiceId { get; set; }
        /// <summary>The type of the detailed report. By default ActualCost is provided</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of the detailed report. By default ActualCost is provided",
        SerializedName = @"metric",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.CostDetailsMetricType) })]
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.CostDetailsMetricType? RequestBodyMetric { get; set; }
        /// <summary>The request scope of the request.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The request scope of the request.",
        SerializedName = @"requestScope",
        PossibleTypes = new [] { typeof(string) })]
        string RequestContextRequestScope { get; set; }
        /// <summary>The status of the cost details operation</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The status of the cost details operation",
        SerializedName = @"status",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.CostDetailsStatusType) })]
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.CostDetailsStatusType? Status { get; set; }
        /// <summary>The end date to pull data to. example format 2020-03-15</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The end date to pull data to. example format 2020-03-15",
        SerializedName = @"end",
        PossibleTypes = new [] { typeof(string) })]
        string TimePeriodEnd { get; set; }
        /// <summary>The start date to pull data from. example format 2020-03-15</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The start date to pull data from. example format 2020-03-15",
        SerializedName = @"start",
        PossibleTypes = new [] { typeof(string) })]
        string TimePeriodStart { get; set; }
        /// <summary>The type of the long running operation.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The type of the long running operation.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get; set; }
        /// <summary>
        /// The time at which report URL becomes invalid/expires in UTC e.g. 2020-12-08T05:55:59.4394737Z.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The time at which report URL becomes invalid/expires in UTC e.g. 2020-12-08T05:55:59.4394737Z.",
        SerializedName = @"validTill",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ValidTill { get; set; }

    }
    /// The result of the long running operation for cost details Api.
    public partial interface ICostDetailsOperationResultsInternal

    {
        /// <summary>Error code.</summary>
        string Code { get; set; }
        /// <summary>The details of the error.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20211001.IErrorDetails Error { get; set; }
        /// <summary>The id of the long running operation.</summary>
        string Id { get; set; }
        /// <summary>The manifest of the report generated by the operation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.IReportManifest Manifest { get; set; }
        /// <summary>List of blob information generated by this operation.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.IBlobInfo[] ManifestBlob { get; set; }
        /// <summary>The total number of blobs.</summary>
        int? ManifestBlobCount { get; set; }
        /// <summary>The total number of bytes in all blobs.</summary>
        long? ManifestByteCount { get; set; }
        /// <summary>Is the data in compressed format.</summary>
        bool? ManifestCompressData { get; set; }
        /// <summary>The data format of the report</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.CostDetailsDataFormat? ManifestDataFormat { get; set; }
        /// <summary>The context of the Cost Details request.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.IRequestContext ManifestRequestContext { get; set; }
        /// <summary>The Manifest version.</summary>
        string ManifestVersion { get; set; }
        /// <summary>Error message indicating why the operation failed.</summary>
        string Message { get; set; }
        /// <summary>The name of the long running operation.</summary>
        string Name { get; set; }
        /// <summary>
        /// This parameter can be used only by Enterprise Agreement customers. Use the YearMonth(e.g. 202008) format. This parameter
        /// cannot be used alongside either the invoiceId or timePeriod parameters. If a timePeriod, invoiceId or billingPeriod parameter
        /// is not provided in the request body the API will return the current month's cost.
        /// </summary>
        string RequestBodyBillingPeriod { get; set; }
        /// <summary>
        /// This parameter can only be used by Microsoft Customer Agreement customers. Additionally, it can only be used at the Billing
        /// Profile or Customer scope. This parameter cannot be used alongside either the billingPeriod or timePeriod parameters.
        /// If a timePeriod, invoiceId or billingPeriod parameter is not provided in the request body the API will return the current
        /// month's cost.
        /// </summary>
        string RequestBodyInvoiceId { get; set; }
        /// <summary>The type of the detailed report. By default ActualCost is provided</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.CostDetailsMetricType? RequestBodyMetric { get; set; }
        /// <summary>
        /// The specific date range of cost details requested for the report. This parameter cannot be used alongside either the invoiceId
        /// or billingPeriod parameters. If a timePeriod, invoiceId or billingPeriod parameter is not provided in the request body
        /// the API will return the current month's cost. API only allows data to be pulled for 1 month or less and no older than
        /// 13 months. If no timePeriod or billingPeriod or invoiceId is provided the API defaults to the open month time period
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.ICostDetailsTimePeriod RequestBodyTimePeriod { get; set; }
        /// <summary>The request payload body provided in Cost Details call</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Models.Api20220501.IGenerateCostDetailsReportRequestDefinition RequestContextRequestBody { get; set; }
        /// <summary>The request scope of the request.</summary>
        string RequestContextRequestScope { get; set; }
        /// <summary>The status of the cost details operation</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.CostDetailsStatusType? Status { get; set; }
        /// <summary>The end date to pull data to. example format 2020-03-15</summary>
        string TimePeriodEnd { get; set; }
        /// <summary>The start date to pull data from. example format 2020-03-15</summary>
        string TimePeriodStart { get; set; }
        /// <summary>The type of the long running operation.</summary>
        string Type { get; set; }
        /// <summary>
        /// The time at which report URL becomes invalid/expires in UTC e.g. 2020-12-08T05:55:59.4394737Z.
        /// </summary>
        global::System.DateTime? ValidTill { get; set; }

    }
}