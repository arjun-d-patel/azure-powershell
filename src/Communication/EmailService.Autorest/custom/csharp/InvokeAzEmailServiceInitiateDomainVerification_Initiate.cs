// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.PowerShell.Cmdlets.EmailService.Cmdlets;
using Microsoft.Azure.PowerShell.Cmdlets.EmailService.Models;

namespace Microsoft.Azure.PowerShell.Cmdlets.EmailService.Cmdlets
{
    
    public partial class InvokeAzEmailServiceInitiateDomainVerification_Initiate
    {
        partial void overrideOnDefault(global::System.Net.Http.HttpResponseMessage responseMessage, global::System.Threading.Tasks.Task<Microsoft.Azure.PowerShell.Cmdlets.EmailService.Models.IErrorResponse> response, ref global::System.Threading.Tasks.Task<bool> returnNow)
        {
            if(responseMessage.ReasonPhrase == "OK")
            {
                returnNow = global::System.Threading.Tasks.Task<bool>.FromResult(true);
            }
        }        
    }
}   