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

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.Azure.Management.Resources.Models;

namespace Microsoft.Azure.Commands.ResourceManager.Cmdlets.SdkModels
{
    public class TemplateValidationInfo
    {
        public TemplateValidationInfo(DeploymentValidateResult validationResult)
        {
            Errors = new List<ErrorResponse>();
            RequiredProviders = new List<Provider>();
            Diagnostics = new List<DeploymentDiagnosticsDefinition>();

            if (validationResult.Error != null)
            {
                Errors.Add(validationResult.Error);
            }

            if (validationResult.Properties != null &&
                validationResult.Properties.Providers != null)
            {
                RequiredProviders.AddRange(validationResult.Properties.Providers);
            }

            if (validationResult.Properties != null &&
                validationResult.Properties.Diagnostics != null)
            {
                Diagnostics.AddRange(validationResult.Properties.Diagnostics);
            }
        }

        public List<ErrorResponse> Errors { get; set; }

        public List<Provider> RequiredProviders { get; set; }

        public List<DeploymentDiagnosticsDefinition> Diagnostics { get; set; }
    }
}
