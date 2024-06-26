// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Support
{

    /// <summary>Appliance’s health and state of connection to on-prem</summary>
    [System.ComponentModel.TypeConverter(typeof(Microsoft.Azure.PowerShell.Cmdlets.ArcResourceBridge.Support.StatusTypeConverter))]
    public partial struct Status :
        System.Management.Automation.IArgumentCompleter
    {

        /// <summary>
        /// Implementations of this function are called by PowerShell to complete arguments.
        /// </summary>
        /// <param name="commandName">The name of the command that needs argument completion.</param>
        /// <param name="parameterName">The name of the parameter that needs argument completion.</param>
        /// <param name="wordToComplete">The (possibly empty) word being completed.</param>
        /// <param name="commandAst">The command ast in case it is needed for completion.</param>
        /// <param name="fakeBoundParameters">This parameter is similar to $PSBoundParameters, except that sometimes PowerShell cannot
        /// or will not attempt to evaluate an argument, in which case you may need to use commandAst.</param>
        /// <returns>
        /// A collection of completion results, most like with ResultType set to ParameterValue.
        /// </returns>
        public global::System.Collections.Generic.IEnumerable<global::System.Management.Automation.CompletionResult> CompleteArgument(global::System.String commandName, global::System.String parameterName, global::System.String wordToComplete, global::System.Management.Automation.Language.CommandAst commandAst, global::System.Collections.IDictionary fakeBoundParameters)
        {
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "WaitingForHeartbeat".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'WaitingForHeartbeat'", "WaitingForHeartbeat", global::System.Management.Automation.CompletionResultType.ParameterValue, "WaitingForHeartbeat");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Validating".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Validating'", "Validating", global::System.Management.Automation.CompletionResultType.ParameterValue, "Validating");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Connecting".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Connecting'", "Connecting", global::System.Management.Automation.CompletionResultType.ParameterValue, "Connecting");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Connected".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Connected'", "Connected", global::System.Management.Automation.CompletionResultType.ParameterValue, "Connected");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Running".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Running'", "Running", global::System.Management.Automation.CompletionResultType.ParameterValue, "Running");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "PreparingForUpgrade".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'PreparingForUpgrade'", "PreparingForUpgrade", global::System.Management.Automation.CompletionResultType.ParameterValue, "PreparingForUpgrade");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "UpgradePrerequisitesCompleted".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'UpgradePrerequisitesCompleted'", "UpgradePrerequisitesCompleted", global::System.Management.Automation.CompletionResultType.ParameterValue, "UpgradePrerequisitesCompleted");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "PreUpgrade".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'PreUpgrade'", "PreUpgrade", global::System.Management.Automation.CompletionResultType.ParameterValue, "PreUpgrade");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "UpgradingKVAIO".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'UpgradingKVAIO'", "UpgradingKVAIO", global::System.Management.Automation.CompletionResultType.ParameterValue, "UpgradingKVAIO");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "WaitingForKVAIO".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'WaitingForKVAIO'", "WaitingForKVAIO", global::System.Management.Automation.CompletionResultType.ParameterValue, "WaitingForKVAIO");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ImagePending".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'ImagePending'", "ImagePending", global::System.Management.Automation.CompletionResultType.ParameterValue, "ImagePending");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ImageProvisioning".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'ImageProvisioning'", "ImageProvisioning", global::System.Management.Automation.CompletionResultType.ParameterValue, "ImageProvisioning");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ImageProvisioned".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'ImageProvisioned'", "ImageProvisioned", global::System.Management.Automation.CompletionResultType.ParameterValue, "ImageProvisioned");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ImageDownloading".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'ImageDownloading'", "ImageDownloading", global::System.Management.Automation.CompletionResultType.ParameterValue, "ImageDownloading");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ImageDownloaded".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'ImageDownloaded'", "ImageDownloaded", global::System.Management.Automation.CompletionResultType.ParameterValue, "ImageDownloaded");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ImageDeprovisioning".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'ImageDeprovisioning'", "ImageDeprovisioning", global::System.Management.Automation.CompletionResultType.ParameterValue, "ImageDeprovisioning");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "ImageUnknown".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'ImageUnknown'", "ImageUnknown", global::System.Management.Automation.CompletionResultType.ParameterValue, "ImageUnknown");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "UpdatingCloudOperator".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'UpdatingCloudOperator'", "UpdatingCloudOperator", global::System.Management.Automation.CompletionResultType.ParameterValue, "UpdatingCloudOperator");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "WaitingForCloudOperator".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'WaitingForCloudOperator'", "WaitingForCloudOperator", global::System.Management.Automation.CompletionResultType.ParameterValue, "WaitingForCloudOperator");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "UpdatingCAPI".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'UpdatingCAPI'", "UpdatingCAPI", global::System.Management.Automation.CompletionResultType.ParameterValue, "UpdatingCAPI");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "UpdatingCluster".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'UpdatingCluster'", "UpdatingCluster", global::System.Management.Automation.CompletionResultType.ParameterValue, "UpdatingCluster");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "PostUpgrade".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'PostUpgrade'", "PostUpgrade", global::System.Management.Automation.CompletionResultType.ParameterValue, "PostUpgrade");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "UpgradeComplete".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'UpgradeComplete'", "UpgradeComplete", global::System.Management.Automation.CompletionResultType.ParameterValue, "UpgradeComplete");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "UpgradeClusterExtensionFailedToDelete".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'UpgradeClusterExtensionFailedToDelete'", "UpgradeClusterExtensionFailedToDelete", global::System.Management.Automation.CompletionResultType.ParameterValue, "UpgradeClusterExtensionFailedToDelete");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "UpgradeFailed".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'UpgradeFailed'", "UpgradeFailed", global::System.Management.Automation.CompletionResultType.ParameterValue, "UpgradeFailed");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "Offline".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'Offline'", "Offline", global::System.Management.Automation.CompletionResultType.ParameterValue, "Offline");
            }
            if (global::System.String.IsNullOrEmpty(wordToComplete) || "None".StartsWith(wordToComplete, global::System.StringComparison.InvariantCultureIgnoreCase))
            {
                yield return new global::System.Management.Automation.CompletionResult("'None'", "None", global::System.Management.Automation.CompletionResultType.ParameterValue, "None");
            }
        }
    }
}