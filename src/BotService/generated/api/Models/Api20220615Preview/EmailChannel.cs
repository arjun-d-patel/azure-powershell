// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Extensions;

    /// <summary>Email channel definition</summary>
    public partial class EmailChannel :
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IEmailChannel,
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IEmailChannelInternal,
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IChannel"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IChannel __channel = new Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.Channel();

        /// <summary>Email channel auth method. 0 Password (Default); 1 Graph.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inlined)]
        public float? AuthMethod { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IEmailChannelPropertiesInternal)Property).AuthMethod; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IEmailChannelPropertiesInternal)Property).AuthMethod = value ?? default(float); }

        /// <summary>The email address</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inlined)]
        public string EmailAddress { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IEmailChannelPropertiesInternal)Property).EmailAddress; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IEmailChannelPropertiesInternal)Property).EmailAddress = value ?? null; }

        /// <summary>Entity Tag of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inherited)]
        public string Etag { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IChannelInternal)__channel).Etag; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IChannelInternal)__channel).Etag = value ?? null; }

        /// <summary>Whether this channel is enabled for the bot</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inlined)]
        public bool? IsEnabled { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IEmailChannelPropertiesInternal)Property).IsEnabled; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IEmailChannelPropertiesInternal)Property).IsEnabled = value ?? default(bool); }

        /// <summary>Specifies the location of the resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inherited)]
        public string Location { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IChannelInternal)__channel).Location; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IChannelInternal)__channel).Location = value ?? null; }

        /// <summary>The magic code for setting up the modern authentication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inlined)]
        public string MagicCode { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IEmailChannelPropertiesInternal)Property).MagicCode; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IEmailChannelPropertiesInternal)Property).MagicCode = value ?? null; }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IChannelInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IChannelInternal)__channel).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IChannelInternal)__channel).ProvisioningState = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IEmailChannelProperties Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IEmailChannelInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.EmailChannelProperties()); set { {_property = value;} } }

        /// <summary>The channel name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IChannelInternal)__channel).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IChannelInternal)__channel).Name = value ; }

        /// <summary>
        /// The password for the email address. Value only returned through POST to the action Channel List API, otherwise empty.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inlined)]
        public string Password { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IEmailChannelPropertiesInternal)Property).Password; set => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IEmailChannelPropertiesInternal)Property).Password = value ?? null; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IEmailChannelProperties _property;

        /// <summary>The set of properties specific to email channel resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IEmailChannelProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.EmailChannelProperties()); set => this._property = value; }

        /// <summary>Provisioning state of the resource</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Origin(Microsoft.Azure.PowerShell.Cmdlets.BotService.PropertyOrigin.Inherited)]
        public string ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IChannelInternal)__channel).ProvisioningState; }

        /// <summary>Creates an new <see cref="EmailChannel" /> instance.</summary>
        public EmailChannel()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__channel), __channel);
            await eventListener.AssertObjectIsValid(nameof(__channel), __channel);
        }
    }
    /// Email channel definition
    public partial interface IEmailChannel :
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IChannel
    {
        /// <summary>Email channel auth method. 0 Password (Default); 1 Graph.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Email channel auth method. 0 Password (Default); 1 Graph.",
        SerializedName = @"authMethod",
        PossibleTypes = new [] { typeof(float) })]
        float? AuthMethod { get; set; }
        /// <summary>The email address</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The email address",
        SerializedName = @"emailAddress",
        PossibleTypes = new [] { typeof(string) })]
        string EmailAddress { get; set; }
        /// <summary>Whether this channel is enabled for the bot</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Whether this channel is enabled for the bot",
        SerializedName = @"isEnabled",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsEnabled { get; set; }
        /// <summary>The magic code for setting up the modern authentication.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The magic code for setting up the modern authentication.",
        SerializedName = @"magicCode",
        PossibleTypes = new [] { typeof(string) })]
        string MagicCode { get; set; }
        /// <summary>
        /// The password for the email address. Value only returned through POST to the action Channel List API, otherwise empty.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.BotService.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The password for the email address. Value only returned through POST to the action Channel List API, otherwise empty.",
        SerializedName = @"password",
        PossibleTypes = new [] { typeof(string) })]
        string Password { get; set; }

    }
    /// Email channel definition
    internal partial interface IEmailChannelInternal :
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IChannelInternal
    {
        /// <summary>Email channel auth method. 0 Password (Default); 1 Graph.</summary>
        float? AuthMethod { get; set; }
        /// <summary>The email address</summary>
        string EmailAddress { get; set; }
        /// <summary>Whether this channel is enabled for the bot</summary>
        bool? IsEnabled { get; set; }
        /// <summary>The magic code for setting up the modern authentication.</summary>
        string MagicCode { get; set; }
        /// <summary>
        /// The password for the email address. Value only returned through POST to the action Channel List API, otherwise empty.
        /// </summary>
        string Password { get; set; }
        /// <summary>The set of properties specific to email channel resource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.BotService.Models.Api20220615Preview.IEmailChannelProperties Property { get; set; }

    }
}