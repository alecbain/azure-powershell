// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Extensions;

    /// <summary>Function App runtime settings.</summary>
    public partial class FunctionAppRuntimeSettings :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppRuntimeSettings,
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppRuntimeSettingsInternal
    {

        /// <summary>
        /// <code>true</code> if Application Insights is disabled by default for the stack; otherwise, <code>false</code>.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public bool? AppInsightSettingIsDefaultOff { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IAppInsightsWebAppStackSettingsInternal)AppInsightsSetting).IsDefaultOff; }

        /// <summary>
        /// <code>true</code> if remote Application Insights is supported for the stack; otherwise, <code>false</code>.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public bool? AppInsightSettingIsSupported { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IAppInsightsWebAppStackSettingsInternal)AppInsightsSetting).IsSupported; }

        /// <summary>Backing field for <see cref="AppInsightsSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IAppInsightsWebAppStackSettings _appInsightsSetting;

        /// <summary>Application Insights settings associated with the minor version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IAppInsightsWebAppStackSettings AppInsightsSetting { get => (this._appInsightsSetting = this._appInsightsSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.AppInsightsWebAppStackSettings()); }

        /// <summary>Backing field for <see cref="AppSettingsDictionary" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppRuntimeSettingsAppSettingsDictionary _appSettingsDictionary;

        /// <summary>Application settings associated with the minor version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppRuntimeSettingsAppSettingsDictionary AppSettingsDictionary { get => (this._appSettingsDictionary = this._appSettingsDictionary ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.FunctionAppRuntimeSettingsAppSettingsDictionary()); }

        /// <summary>Backing field for <see cref="EndOfLifeDate" /> property.</summary>
        private global::System.DateTime? _endOfLifeDate;

        /// <summary>End-of-life date for the minor version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public global::System.DateTime? EndOfLifeDate { get => this._endOfLifeDate; }

        /// <summary>Backing field for <see cref="GitHubActionSetting" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IGitHubActionWebAppStackSettings _gitHubActionSetting;

        /// <summary>GitHub Actions settings associated with the minor version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IGitHubActionWebAppStackSettings GitHubActionSetting { get => (this._gitHubActionSetting = this._gitHubActionSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.GitHubActionWebAppStackSettings()); }

        /// <summary>
        /// <code>true</code> if GitHub Actions is supported for the stack; otherwise, <code>false</code>.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public bool? GitHubActionSettingIsSupported { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IGitHubActionWebAppStackSettingsInternal)GitHubActionSetting).IsSupported; }

        /// <summary>The minor version that is supported for GitHub Actions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public string GitHubActionSettingSupportedVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IGitHubActionWebAppStackSettingsInternal)GitHubActionSetting).SupportedVersion; }

        /// <summary>Backing field for <see cref="IsAutoUpdate" /> property.</summary>
        private bool? _isAutoUpdate;

        /// <summary>
        /// <code>true</code> if the stack version is auto-updated; otherwise, <code>false</code>.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public bool? IsAutoUpdate { get => this._isAutoUpdate; }

        /// <summary>Backing field for <see cref="IsDefault" /> property.</summary>
        private bool? _isDefault;

        /// <summary>
        /// <code>true</code> if the minor version the default; otherwise, <code>false</code>.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public bool? IsDefault { get => this._isDefault; }

        /// <summary>Backing field for <see cref="IsDeprecated" /> property.</summary>
        private bool? _isDeprecated;

        /// <summary><code>true</code> if the stack is deprecated; otherwise, <code>false</code>.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public bool? IsDeprecated { get => this._isDeprecated; }

        /// <summary>Backing field for <see cref="IsEarlyAccess" /> property.</summary>
        private bool? _isEarlyAccess;

        /// <summary>
        /// <code>true</code> if the minor version is early-access; otherwise, <code>false</code>.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public bool? IsEarlyAccess { get => this._isEarlyAccess; }

        /// <summary>Backing field for <see cref="IsHidden" /> property.</summary>
        private bool? _isHidden;

        /// <summary><code>true</code> if the stack should be hidden; otherwise, <code>false</code>.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public bool? IsHidden { get => this._isHidden; }

        /// <summary>Backing field for <see cref="IsPreview" /> property.</summary>
        private bool? _isPreview;

        /// <summary><code>true</code> if the stack is in preview; otherwise, <code>false</code>.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public bool? IsPreview { get => this._isPreview; }

        /// <summary>Internal Acessors for AppInsightSettingIsDefaultOff</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppRuntimeSettingsInternal.AppInsightSettingIsDefaultOff { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IAppInsightsWebAppStackSettingsInternal)AppInsightsSetting).IsDefaultOff; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IAppInsightsWebAppStackSettingsInternal)AppInsightsSetting).IsDefaultOff = value; }

        /// <summary>Internal Acessors for AppInsightSettingIsSupported</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppRuntimeSettingsInternal.AppInsightSettingIsSupported { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IAppInsightsWebAppStackSettingsInternal)AppInsightsSetting).IsSupported; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IAppInsightsWebAppStackSettingsInternal)AppInsightsSetting).IsSupported = value; }

        /// <summary>Internal Acessors for AppInsightsSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IAppInsightsWebAppStackSettings Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppRuntimeSettingsInternal.AppInsightsSetting { get => (this._appInsightsSetting = this._appInsightsSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.AppInsightsWebAppStackSettings()); set { {_appInsightsSetting = value;} } }

        /// <summary>Internal Acessors for AppSettingsDictionary</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppRuntimeSettingsAppSettingsDictionary Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppRuntimeSettingsInternal.AppSettingsDictionary { get => (this._appSettingsDictionary = this._appSettingsDictionary ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.FunctionAppRuntimeSettingsAppSettingsDictionary()); set { {_appSettingsDictionary = value;} } }

        /// <summary>Internal Acessors for EndOfLifeDate</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppRuntimeSettingsInternal.EndOfLifeDate { get => this._endOfLifeDate; set { {_endOfLifeDate = value;} } }

        /// <summary>Internal Acessors for GitHubActionSetting</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IGitHubActionWebAppStackSettings Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppRuntimeSettingsInternal.GitHubActionSetting { get => (this._gitHubActionSetting = this._gitHubActionSetting ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.GitHubActionWebAppStackSettings()); set { {_gitHubActionSetting = value;} } }

        /// <summary>Internal Acessors for GitHubActionSettingIsSupported</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppRuntimeSettingsInternal.GitHubActionSettingIsSupported { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IGitHubActionWebAppStackSettingsInternal)GitHubActionSetting).IsSupported; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IGitHubActionWebAppStackSettingsInternal)GitHubActionSetting).IsSupported = value; }

        /// <summary>Internal Acessors for GitHubActionSettingSupportedVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppRuntimeSettingsInternal.GitHubActionSettingSupportedVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IGitHubActionWebAppStackSettingsInternal)GitHubActionSetting).SupportedVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IGitHubActionWebAppStackSettingsInternal)GitHubActionSetting).SupportedVersion = value; }

        /// <summary>Internal Acessors for IsAutoUpdate</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppRuntimeSettingsInternal.IsAutoUpdate { get => this._isAutoUpdate; set { {_isAutoUpdate = value;} } }

        /// <summary>Internal Acessors for IsDefault</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppRuntimeSettingsInternal.IsDefault { get => this._isDefault; set { {_isDefault = value;} } }

        /// <summary>Internal Acessors for IsDeprecated</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppRuntimeSettingsInternal.IsDeprecated { get => this._isDeprecated; set { {_isDeprecated = value;} } }

        /// <summary>Internal Acessors for IsEarlyAccess</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppRuntimeSettingsInternal.IsEarlyAccess { get => this._isEarlyAccess; set { {_isEarlyAccess = value;} } }

        /// <summary>Internal Acessors for IsHidden</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppRuntimeSettingsInternal.IsHidden { get => this._isHidden; set { {_isHidden = value;} } }

        /// <summary>Internal Acessors for IsPreview</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppRuntimeSettingsInternal.IsPreview { get => this._isPreview; set { {_isPreview = value;} } }

        /// <summary>Internal Acessors for RemoteDebuggingSupported</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppRuntimeSettingsInternal.RemoteDebuggingSupported { get => this._remoteDebuggingSupported; set { {_remoteDebuggingSupported = value;} } }

        /// <summary>Internal Acessors for RuntimeVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppRuntimeSettingsInternal.RuntimeVersion { get => this._runtimeVersion; set { {_runtimeVersion = value;} } }

        /// <summary>Internal Acessors for SiteConfigPropertiesDictionary</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteConfigPropertiesDictionary Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppRuntimeSettingsInternal.SiteConfigPropertiesDictionary { get => (this._siteConfigPropertiesDictionary = this._siteConfigPropertiesDictionary ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.SiteConfigPropertiesDictionary()); set { {_siteConfigPropertiesDictionary = value;} } }

        /// <summary>Internal Acessors for SiteConfigPropertyDictionaryJavaVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppRuntimeSettingsInternal.SiteConfigPropertyDictionaryJavaVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteConfigPropertiesDictionaryInternal)SiteConfigPropertiesDictionary).JavaVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteConfigPropertiesDictionaryInternal)SiteConfigPropertiesDictionary).JavaVersion = value; }

        /// <summary>Internal Acessors for SiteConfigPropertyDictionaryLinuxFxVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppRuntimeSettingsInternal.SiteConfigPropertyDictionaryLinuxFxVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteConfigPropertiesDictionaryInternal)SiteConfigPropertiesDictionary).LinuxFxVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteConfigPropertiesDictionaryInternal)SiteConfigPropertiesDictionary).LinuxFxVersion = value; }

        /// <summary>Internal Acessors for SiteConfigPropertyDictionaryPowerShellVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppRuntimeSettingsInternal.SiteConfigPropertyDictionaryPowerShellVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteConfigPropertiesDictionaryInternal)SiteConfigPropertiesDictionary).PowerShellVersion; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteConfigPropertiesDictionaryInternal)SiteConfigPropertiesDictionary).PowerShellVersion = value; }

        /// <summary>Internal Acessors for SiteConfigPropertyDictionaryUse32BitWorkerProcess</summary>
        bool? Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppRuntimeSettingsInternal.SiteConfigPropertyDictionaryUse32BitWorkerProcess { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteConfigPropertiesDictionaryInternal)SiteConfigPropertiesDictionary).Use32BitWorkerProcess; set => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteConfigPropertiesDictionaryInternal)SiteConfigPropertiesDictionary).Use32BitWorkerProcess = value; }

        /// <summary>Internal Acessors for SupportedFunctionsExtensionVersion</summary>
        string[] Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppRuntimeSettingsInternal.SupportedFunctionsExtensionVersion { get => this._supportedFunctionsExtensionVersion; set { {_supportedFunctionsExtensionVersion = value;} } }

        /// <summary>Backing field for <see cref="RemoteDebuggingSupported" /> property.</summary>
        private bool? _remoteDebuggingSupported;

        /// <summary>
        /// <code>true</code> if remote debugging is supported for the stack; otherwise, <code>false</code>.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public bool? RemoteDebuggingSupported { get => this._remoteDebuggingSupported; }

        /// <summary>Backing field for <see cref="RuntimeVersion" /> property.</summary>
        private string _runtimeVersion;

        /// <summary>Function App stack minor version (runtime only).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public string RuntimeVersion { get => this._runtimeVersion; }

        /// <summary>Backing field for <see cref="SiteConfigPropertiesDictionary" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteConfigPropertiesDictionary _siteConfigPropertiesDictionary;

        /// <summary>Configuration settings associated with the minor version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteConfigPropertiesDictionary SiteConfigPropertiesDictionary { get => (this._siteConfigPropertiesDictionary = this._siteConfigPropertiesDictionary ?? new Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.SiteConfigPropertiesDictionary()); }

        /// <summary>JavaVersion configuration setting.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public string SiteConfigPropertyDictionaryJavaVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteConfigPropertiesDictionaryInternal)SiteConfigPropertiesDictionary).JavaVersion; }

        /// <summary>LinuxFxVersion configuration setting.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public string SiteConfigPropertyDictionaryLinuxFxVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteConfigPropertiesDictionaryInternal)SiteConfigPropertiesDictionary).LinuxFxVersion; }

        /// <summary>PowerShellVersion configuration setting.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public string SiteConfigPropertyDictionaryPowerShellVersion { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteConfigPropertiesDictionaryInternal)SiteConfigPropertiesDictionary).PowerShellVersion; }

        /// <summary>
        /// <code>true</code> if use32BitWorkerProcess should be set to true for the stack; otherwise, <code>false</code>.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Inlined)]
        public bool? SiteConfigPropertyDictionaryUse32BitWorkerProcess { get => ((Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteConfigPropertiesDictionaryInternal)SiteConfigPropertiesDictionary).Use32BitWorkerProcess; }

        /// <summary>Backing field for <see cref="SupportedFunctionsExtensionVersion" /> property.</summary>
        private string[] _supportedFunctionsExtensionVersion;

        /// <summary>List of supported Functions extension versions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Origin(Microsoft.Azure.PowerShell.Cmdlets.Functions.PropertyOrigin.Owned)]
        public string[] SupportedFunctionsExtensionVersion { get => this._supportedFunctionsExtensionVersion; }

        /// <summary>Creates an new <see cref="FunctionAppRuntimeSettings" /> instance.</summary>
        public FunctionAppRuntimeSettings()
        {

        }
    }
    /// Function App runtime settings.
    public partial interface IFunctionAppRuntimeSettings :
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.IJsonSerializable
    {
        /// <summary>
        /// <code>true</code> if Application Insights is disabled by default for the stack; otherwise, <code>false</code>.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"<code>true</code> if Application Insights is disabled by default for the stack; otherwise, <code>false</code>.",
        SerializedName = @"isDefaultOff",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AppInsightSettingIsDefaultOff { get;  }
        /// <summary>
        /// <code>true</code> if remote Application Insights is supported for the stack; otherwise, <code>false</code>.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"<code>true</code> if remote Application Insights is supported for the stack; otherwise, <code>false</code>.",
        SerializedName = @"isSupported",
        PossibleTypes = new [] { typeof(bool) })]
        bool? AppInsightSettingIsSupported { get;  }
        /// <summary>Application settings associated with the minor version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Application settings associated with the minor version.",
        SerializedName = @"appSettingsDictionary",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppRuntimeSettingsAppSettingsDictionary) })]
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppRuntimeSettingsAppSettingsDictionary AppSettingsDictionary { get;  }
        /// <summary>End-of-life date for the minor version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"End-of-life date for the minor version.",
        SerializedName = @"endOfLifeDate",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? EndOfLifeDate { get;  }
        /// <summary>
        /// <code>true</code> if GitHub Actions is supported for the stack; otherwise, <code>false</code>.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"<code>true</code> if GitHub Actions is supported for the stack; otherwise, <code>false</code>.",
        SerializedName = @"isSupported",
        PossibleTypes = new [] { typeof(bool) })]
        bool? GitHubActionSettingIsSupported { get;  }
        /// <summary>The minor version that is supported for GitHub Actions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The minor version that is supported for GitHub Actions.",
        SerializedName = @"supportedVersion",
        PossibleTypes = new [] { typeof(string) })]
        string GitHubActionSettingSupportedVersion { get;  }
        /// <summary>
        /// <code>true</code> if the stack version is auto-updated; otherwise, <code>false</code>.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"<code>true</code> if the stack version is auto-updated; otherwise, <code>false</code>.",
        SerializedName = @"isAutoUpdate",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsAutoUpdate { get;  }
        /// <summary>
        /// <code>true</code> if the minor version the default; otherwise, <code>false</code>.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"<code>true</code> if the minor version the default; otherwise, <code>false</code>.",
        SerializedName = @"isDefault",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsDefault { get;  }
        /// <summary><code>true</code> if the stack is deprecated; otherwise, <code>false</code>.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"<code>true</code> if the stack is deprecated; otherwise, <code>false</code>.",
        SerializedName = @"isDeprecated",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsDeprecated { get;  }
        /// <summary>
        /// <code>true</code> if the minor version is early-access; otherwise, <code>false</code>.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"<code>true</code> if the minor version is early-access; otherwise, <code>false</code>.",
        SerializedName = @"isEarlyAccess",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsEarlyAccess { get;  }
        /// <summary><code>true</code> if the stack should be hidden; otherwise, <code>false</code>.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"<code>true</code> if the stack should be hidden; otherwise, <code>false</code>.",
        SerializedName = @"isHidden",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsHidden { get;  }
        /// <summary><code>true</code> if the stack is in preview; otherwise, <code>false</code>.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"<code>true</code> if the stack is in preview; otherwise, <code>false</code>.",
        SerializedName = @"isPreview",
        PossibleTypes = new [] { typeof(bool) })]
        bool? IsPreview { get;  }
        /// <summary>
        /// <code>true</code> if remote debugging is supported for the stack; otherwise, <code>false</code>.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"<code>true</code> if remote debugging is supported for the stack; otherwise, <code>false</code>.",
        SerializedName = @"remoteDebuggingSupported",
        PossibleTypes = new [] { typeof(bool) })]
        bool? RemoteDebuggingSupported { get;  }
        /// <summary>Function App stack minor version (runtime only).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Function App stack minor version (runtime only).",
        SerializedName = @"runtimeVersion",
        PossibleTypes = new [] { typeof(string) })]
        string RuntimeVersion { get;  }
        /// <summary>JavaVersion configuration setting.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"JavaVersion configuration setting.",
        SerializedName = @"javaVersion",
        PossibleTypes = new [] { typeof(string) })]
        string SiteConfigPropertyDictionaryJavaVersion { get;  }
        /// <summary>LinuxFxVersion configuration setting.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"LinuxFxVersion configuration setting.",
        SerializedName = @"linuxFxVersion",
        PossibleTypes = new [] { typeof(string) })]
        string SiteConfigPropertyDictionaryLinuxFxVersion { get;  }
        /// <summary>PowerShellVersion configuration setting.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"PowerShellVersion configuration setting.",
        SerializedName = @"powerShellVersion",
        PossibleTypes = new [] { typeof(string) })]
        string SiteConfigPropertyDictionaryPowerShellVersion { get;  }
        /// <summary>
        /// <code>true</code> if use32BitWorkerProcess should be set to true for the stack; otherwise, <code>false</code>.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"<code>true</code> if use32BitWorkerProcess should be set to true for the stack; otherwise, <code>false</code>.",
        SerializedName = @"use32BitWorkerProcess",
        PossibleTypes = new [] { typeof(bool) })]
        bool? SiteConfigPropertyDictionaryUse32BitWorkerProcess { get;  }
        /// <summary>List of supported Functions extension versions.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Functions.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of supported Functions extension versions.",
        SerializedName = @"supportedFunctionsExtensionVersions",
        PossibleTypes = new [] { typeof(string) })]
        string[] SupportedFunctionsExtensionVersion { get;  }

    }
    /// Function App runtime settings.
    internal partial interface IFunctionAppRuntimeSettingsInternal

    {
        /// <summary>
        /// <code>true</code> if Application Insights is disabled by default for the stack; otherwise, <code>false</code>.
        /// </summary>
        bool? AppInsightSettingIsDefaultOff { get; set; }
        /// <summary>
        /// <code>true</code> if remote Application Insights is supported for the stack; otherwise, <code>false</code>.
        /// </summary>
        bool? AppInsightSettingIsSupported { get; set; }
        /// <summary>Application Insights settings associated with the minor version.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IAppInsightsWebAppStackSettings AppInsightsSetting { get; set; }
        /// <summary>Application settings associated with the minor version.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IFunctionAppRuntimeSettingsAppSettingsDictionary AppSettingsDictionary { get; set; }
        /// <summary>End-of-life date for the minor version.</summary>
        global::System.DateTime? EndOfLifeDate { get; set; }
        /// <summary>GitHub Actions settings associated with the minor version.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.IGitHubActionWebAppStackSettings GitHubActionSetting { get; set; }
        /// <summary>
        /// <code>true</code> if GitHub Actions is supported for the stack; otherwise, <code>false</code>.
        /// </summary>
        bool? GitHubActionSettingIsSupported { get; set; }
        /// <summary>The minor version that is supported for GitHub Actions.</summary>
        string GitHubActionSettingSupportedVersion { get; set; }
        /// <summary>
        /// <code>true</code> if the stack version is auto-updated; otherwise, <code>false</code>.
        /// </summary>
        bool? IsAutoUpdate { get; set; }
        /// <summary>
        /// <code>true</code> if the minor version the default; otherwise, <code>false</code>.
        /// </summary>
        bool? IsDefault { get; set; }
        /// <summary><code>true</code> if the stack is deprecated; otherwise, <code>false</code>.</summary>
        bool? IsDeprecated { get; set; }
        /// <summary>
        /// <code>true</code> if the minor version is early-access; otherwise, <code>false</code>.
        /// </summary>
        bool? IsEarlyAccess { get; set; }
        /// <summary><code>true</code> if the stack should be hidden; otherwise, <code>false</code>.</summary>
        bool? IsHidden { get; set; }
        /// <summary><code>true</code> if the stack is in preview; otherwise, <code>false</code>.</summary>
        bool? IsPreview { get; set; }
        /// <summary>
        /// <code>true</code> if remote debugging is supported for the stack; otherwise, <code>false</code>.
        /// </summary>
        bool? RemoteDebuggingSupported { get; set; }
        /// <summary>Function App stack minor version (runtime only).</summary>
        string RuntimeVersion { get; set; }
        /// <summary>Configuration settings associated with the minor version.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Functions.Models.Api20231201.ISiteConfigPropertiesDictionary SiteConfigPropertiesDictionary { get; set; }
        /// <summary>JavaVersion configuration setting.</summary>
        string SiteConfigPropertyDictionaryJavaVersion { get; set; }
        /// <summary>LinuxFxVersion configuration setting.</summary>
        string SiteConfigPropertyDictionaryLinuxFxVersion { get; set; }
        /// <summary>PowerShellVersion configuration setting.</summary>
        string SiteConfigPropertyDictionaryPowerShellVersion { get; set; }
        /// <summary>
        /// <code>true</code> if use32BitWorkerProcess should be set to true for the stack; otherwise, <code>false</code>.
        /// </summary>
        bool? SiteConfigPropertyDictionaryUse32BitWorkerProcess { get; set; }
        /// <summary>List of supported Functions extension versions.</summary>
        string[] SupportedFunctionsExtensionVersion { get; set; }

    }
}