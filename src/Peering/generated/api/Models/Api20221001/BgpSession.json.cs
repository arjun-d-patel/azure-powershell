// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Extensions;

    /// <summary>The properties that define a BGP session.</summary>
    public partial class BgpSession
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonObject into a new instance of <see cref="BgpSession" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal BgpSession(Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_sessionPrefixV4 = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonString>("sessionPrefixV4"), out var __jsonSessionPrefixV4) ? (string)__jsonSessionPrefixV4 : (string)SessionPrefixV4;}
            {_sessionPrefixV6 = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonString>("sessionPrefixV6"), out var __jsonSessionPrefixV6) ? (string)__jsonSessionPrefixV6 : (string)SessionPrefixV6;}
            {_microsoftSessionIPv4Address = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonString>("microsoftSessionIPv4Address"), out var __jsonMicrosoftSessionIPv4Address) ? (string)__jsonMicrosoftSessionIPv4Address : (string)MicrosoftSessionIPv4Address;}
            {_microsoftSessionIPv6Address = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonString>("microsoftSessionIPv6Address"), out var __jsonMicrosoftSessionIPv6Address) ? (string)__jsonMicrosoftSessionIPv6Address : (string)MicrosoftSessionIPv6Address;}
            {_peerSessionIPv4Address = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonString>("peerSessionIPv4Address"), out var __jsonPeerSessionIPv4Address) ? (string)__jsonPeerSessionIPv4Address : (string)PeerSessionIPv4Address;}
            {_peerSessionIPv6Address = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonString>("peerSessionIPv6Address"), out var __jsonPeerSessionIPv6Address) ? (string)__jsonPeerSessionIPv6Address : (string)PeerSessionIPv6Address;}
            {_sessionStateV4 = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonString>("sessionStateV4"), out var __jsonSessionStateV4) ? (string)__jsonSessionStateV4 : (string)SessionStateV4;}
            {_sessionStateV6 = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonString>("sessionStateV6"), out var __jsonSessionStateV6) ? (string)__jsonSessionStateV6 : (string)SessionStateV6;}
            {_maxPrefixesAdvertisedV4 = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonNumber>("maxPrefixesAdvertisedV4"), out var __jsonMaxPrefixesAdvertisedV4) ? (int?)__jsonMaxPrefixesAdvertisedV4 : MaxPrefixesAdvertisedV4;}
            {_maxPrefixesAdvertisedV6 = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonNumber>("maxPrefixesAdvertisedV6"), out var __jsonMaxPrefixesAdvertisedV6) ? (int?)__jsonMaxPrefixesAdvertisedV6 : MaxPrefixesAdvertisedV6;}
            {_md5AuthenticationKey = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonString>("md5AuthenticationKey"), out var __jsonMd5AuthenticationKey) ? (string)__jsonMd5AuthenticationKey : (string)Md5AuthenticationKey;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IBgpSession.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IBgpSession.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IBgpSession FromJson(Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonObject json ? new BgpSession(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="BgpSession" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="BgpSession" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != (((object)this._sessionPrefixV4)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonString(this._sessionPrefixV4.ToString()) : null, "sessionPrefixV4" ,container.Add );
            AddIf( null != (((object)this._sessionPrefixV6)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonString(this._sessionPrefixV6.ToString()) : null, "sessionPrefixV6" ,container.Add );
            AddIf( null != (((object)this._microsoftSessionIPv4Address)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonString(this._microsoftSessionIPv4Address.ToString()) : null, "microsoftSessionIPv4Address" ,container.Add );
            AddIf( null != (((object)this._microsoftSessionIPv6Address)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonString(this._microsoftSessionIPv6Address.ToString()) : null, "microsoftSessionIPv6Address" ,container.Add );
            AddIf( null != (((object)this._peerSessionIPv4Address)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonString(this._peerSessionIPv4Address.ToString()) : null, "peerSessionIPv4Address" ,container.Add );
            AddIf( null != (((object)this._peerSessionIPv6Address)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonString(this._peerSessionIPv6Address.ToString()) : null, "peerSessionIPv6Address" ,container.Add );
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._sessionStateV4)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonString(this._sessionStateV4.ToString()) : null, "sessionStateV4" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)this._sessionStateV6)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonString(this._sessionStateV6.ToString()) : null, "sessionStateV6" ,container.Add );
            }
            AddIf( null != this._maxPrefixesAdvertisedV4 ? (Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonNumber((int)this._maxPrefixesAdvertisedV4) : null, "maxPrefixesAdvertisedV4" ,container.Add );
            AddIf( null != this._maxPrefixesAdvertisedV6 ? (Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonNode)new Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonNumber((int)this._maxPrefixesAdvertisedV6) : null, "maxPrefixesAdvertisedV6" ,container.Add );
            AddIf( null != (((object)this._md5AuthenticationKey)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Json.JsonString(this._md5AuthenticationKey.ToString()) : null, "md5AuthenticationKey" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}