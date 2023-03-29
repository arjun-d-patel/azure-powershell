//
// Copyright (c) Microsoft and contributors.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//
// See the License for the specific language governing permissions and
// limitations under the License.
//

// Warning: This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using Microsoft.Azure.Commands.Compute.Automation.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Management.Compute;
using Microsoft.Azure.Management.Compute.Models;
using Microsoft.WindowsAzure.Commands.Utilities.Common;
using Microsoft.Azure.Commands.Common.Strategies;
using Microsoft.Azure.Commands.Compute.Models;
using Microsoft.WindowsAzure.Commands.Common.CustomAttributes;

namespace Microsoft.Azure.Commands.Compute.Automation
{
    [GenericBreakingChange("Starting in May 2023 the \"New-AzDisk\" cmdlet will deploy with the Trusted Launch configuration by default. This includes defaulting the \"HyperVGeneration\" parameter to \"v2\". To know more about Trusted Launch, please visit https://learn.microsoft.com/en-us/azure/virtual-machines/trusted-launch")]
    [Cmdlet(VerbsCommon.New, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "Disk", DefaultParameterSetName = "DefaultParameter", SupportsShouldProcess = true)]
    [OutputType(typeof(PSDisk))]
    public partial class NewAzureRmDisk : ComputeAutomationBaseCmdlet
    {
        public override void ExecuteCmdlet()
        {
            base.ExecuteCmdlet();
            ExecuteClientAction(() =>
            {
                if (ShouldProcess(this.DiskName, VerbsCommon.New))
                {
                    string resourceGroupName = this.ResourceGroupName;
                    string diskName = this.DiskName;
                    Disk disk = new Disk();
                    ComputeAutomationAutoMapperProfile.Mapper.Map<PSDisk, Disk>(this.Disk, disk);

                    Dictionary<string, List<string>> auxAuthHeader = null;
                    if (!string.IsNullOrEmpty(disk.CreationData?.GalleryImageReference?.Id))
                    {
                        var resourceId = ResourceId.TryParse(disk.CreationData.GalleryImageReference.Id);

                        if (string.Equals("galleries", resourceId?.ResourceType?.Provider, StringComparison.OrdinalIgnoreCase)
                         && !string.Equals(this.ComputeClient?.ComputeManagementClient?.SubscriptionId, resourceId?.SubscriptionId, StringComparison.OrdinalIgnoreCase))
                        {
                            List<string> resourceIds = new List<string>();
                            resourceIds.Add(disk.CreationData.GalleryImageReference.Id);
                            var auxHeaderDictionary = GetAuxilaryAuthHeaderFromResourceIds(resourceIds);
                            if (auxHeaderDictionary != null && auxHeaderDictionary.Count > 0)
                            {
                                auxAuthHeader = new Dictionary<string, List<string>>(auxHeaderDictionary);
                            }
                        }
                    }

                    Disk result;
                    if (auxAuthHeader != null)
                    {
                        var res = this.DisksClient.CreateOrUpdateWithHttpMessagesAsync(
                            this.ResourceGroupName,
                            diskName,
                            disk,
                            auxAuthHeader).GetAwaiter().GetResult();

                        result = res.Body;
                    }
                    else
                    {
                        result = DisksClient.CreateOrUpdate(resourceGroupName, diskName, disk);
                    }
                    var psObject = new PSDisk();
                    ComputeAutomationAutoMapperProfile.Mapper.Map<Disk, PSDisk>(result, psObject);
                    WriteObject(psObject);
                }
            });
        }

        [Parameter(
            ParameterSetName = "DefaultParameter",
            Position = 0,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        [ResourceGroupCompleter]
        public string ResourceGroupName { get; set; }

        [Parameter(
            ParameterSetName = "DefaultParameter",
            Position = 1,
            Mandatory = true,
            ValueFromPipelineByPropertyName = true)]
        [Alias("Name")]
        public string DiskName { get; set; }

        [Parameter(
            ParameterSetName = "DefaultParameter",
            Position = 2,
            Mandatory = true,
            ValueFromPipeline = true)]
        public PSDisk Disk { get; set; }

        [Parameter(Mandatory = false, HelpMessage = "Run cmdlet in the background")]
        public SwitchParameter AsJob { get; set; }
    }
}
