﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.Network.Models;
using System;
using System.Management.Automation;
using MNM = Microsoft.Azure.Management.Network.Models;

namespace Microsoft.Azure.Commands.Network
{
    [Cmdlet("New", ResourceManager.Common.AzureRMConstants.AzureRMPrefix + "VpnClientIpsecPolicy"), OutputType(typeof(PSIpsecPolicy))]
    public class NewAzureRmVpnClientIpsecPolicyCommand : NetworkBaseCmdlet
    {
        [Parameter(
            Mandatory = false,
            HelpMessage = "The VpnClient IPSec Security Association (also called Quick Mode or Phase 2 SA) lifetime in seconds")]
        [ValidateRange(300, 172799)]
        public int SALifeTime { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = "The VpnClient IPSec Security Association (also called Quick Mode or Phase 2 SA) payload size in KB")]
        [ValidateRange(1024, int.MaxValue)]
        public int SADataSize { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = "The VpnClient IPSec encryption algorithm (IKE Phase 1)")]
        [ValidateNotNullOrEmpty]
        [ValidateSet(
            MNM.IpsecEncryption.Gcmaes256,
            MNM.IpsecEncryption.Gcmaes128,
            MNM.IpsecEncryption.AES256,
            MNM.IpsecEncryption.AES128)]
        public string IpsecEncryption { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = "The VpnClient IPSec integrity algorithm (IKE Phase 1)")]
        [ValidateNotNullOrEmpty]
        [ValidateSet(
            MNM.IpsecIntegrity.Gcmaes256,
            MNM.IpsecIntegrity.Gcmaes128,
            MNM.IpsecIntegrity.SHA256)]
        public string IpsecIntegrity { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = "The VpnClient IKE encryption algorithm (IKE Phase 2)")]
        [ValidateNotNullOrEmpty]
        [ValidateSet(
            MNM.IkeEncryption.Gcmaes256,
            MNM.IkeEncryption.Gcmaes128,
            MNM.IkeEncryption.AES256,
            MNM.IkeEncryption.AES128)]
        public string IkeEncryption { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = "The VpnClient IKE integrity algorithm (IKE Phase 2)")]
        [ValidateNotNullOrEmpty]
        [ValidateSet(
            MNM.IkeIntegrity.SHA384,
            MNM.IkeIntegrity.SHA256)]
        public string IkeIntegrity { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = "The VpnClient DH Groups used in IKE Phase 1 for initial SA")]
        [ValidateNotNullOrEmpty]
        [ValidateSet(
            MNM.DhGroup.DHGroup24,
            MNM.DhGroup.ECP384,
            MNM.DhGroup.ECP256,
            MNM.DhGroup.DHGroup14,
            MNM.DhGroup.DHGroup2)]
        public string DhGroup { get; set; }

        [Parameter(
            Mandatory = false,
            HelpMessage = "The VpnClient PFS Groups used in IKE Phase 2 for new child SA")]
        [ValidateNotNullOrEmpty]
        [ValidateSet(
            MNM.PfsGroup.PFS24,
            MNM.PfsGroup.Pfsmm,
            MNM.PfsGroup.ECP384,
            MNM.PfsGroup.ECP256,
            MNM.PfsGroup.PFS14,
            MNM.PfsGroup.PFS2,
            MNM.PfsGroup.None)]
        public string PfsGroup { get; set; }

        public override void Execute()
        {
            base.Execute();

            var vpnclientIpsecPolicy = new PSIpsecPolicy();

            // default SA values
            vpnclientIpsecPolicy.SALifeTimeSeconds = (!this.MyInvocation.BoundParameters.ContainsKey("SALifeTime")) ? 7200 : this.SALifeTime;
            vpnclientIpsecPolicy.SADataSizeKilobytes = (!this.MyInvocation.BoundParameters.ContainsKey("SADataSize")) ? 104857600 : this.SADataSize;

            vpnclientIpsecPolicy.IpsecEncryption = (!this.MyInvocation.BoundParameters.ContainsKey("IpsecEncryption")) ? MNM.IpsecEncryption.Gcmaes256 : this.IpsecEncryption;
            vpnclientIpsecPolicy.IpsecIntegrity = (!this.MyInvocation.BoundParameters.ContainsKey("IpsecIntegrity")) ? MNM.IpsecIntegrity.Gcmaes256 : this.IpsecIntegrity;

            // GCM matching check
            if ((vpnclientIpsecPolicy.IpsecEncryption.Contains("GCM") || vpnclientIpsecPolicy.IpsecIntegrity.Contains("GCM"))
                && vpnclientIpsecPolicy.IpsecEncryption != vpnclientIpsecPolicy.IpsecIntegrity)
            {
                throw new ArgumentException("VpnClient IpsecEncryption and IpsecIntegrity must use matching GCM algorithms");
            }

            vpnclientIpsecPolicy.IkeEncryption = (!this.MyInvocation.BoundParameters.ContainsKey("IkeEncryption")) ? MNM.IkeEncryption.AES256 : this.IkeEncryption;
            vpnclientIpsecPolicy.IkeIntegrity = (!this.MyInvocation.BoundParameters.ContainsKey("IkeIntegrity")) ? MNM.IkeIntegrity.SHA256 : this.IkeIntegrity;
            vpnclientIpsecPolicy.DhGroup = (!this.MyInvocation.BoundParameters.ContainsKey("DhGroup")) ? MNM.DhGroup.DHGroup24 : this.DhGroup;
            vpnclientIpsecPolicy.PfsGroup = (!this.MyInvocation.BoundParameters.ContainsKey("PfsGroup")) ? MNM.PfsGroup.PFS24 : this.PfsGroup;

            WriteObject(vpnclientIpsecPolicy);
        }
    }
}
