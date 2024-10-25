// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models
{
    using Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.PowerShell;

    /// <summary>MaintenanceWindow resource properties</summary>
    [System.ComponentModel.TypeConverter(typeof(MaintenanceWindowTypeConverter))]
    public partial class MaintenanceWindow
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// <c>OverrideToString</c> will be called if it is implemented. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="stringResult">/// instance serialized to a string, normally it is a Json</param>
        /// <param name="returnNow">/// set returnNow to true if you provide a customized OverrideToString function</param>

        partial void OverrideToString(ref string stringResult, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.MaintenanceWindow"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindow" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindow DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new MaintenanceWindow(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.MaintenanceWindow"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindow" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindow DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new MaintenanceWindow(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="MaintenanceWindow" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="MaintenanceWindow" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindow FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.MaintenanceWindow"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal MaintenanceWindow(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Preference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindowInternal)this).Preference = (string) content.GetValueForProperty("Preference",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindowInternal)this).Preference, global::System.Convert.ToString);
            }
            if (content.Contains("Month"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindowInternal)this).Month = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMonth>) content.GetValueForProperty("Month",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindowInternal)this).Month, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMonth>(__y, Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.MonthTypeConverter.ConvertFrom));
            }
            if (content.Contains("WeeksOfMonth"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindowInternal)this).WeeksOfMonth = (System.Collections.Generic.List<int>) content.GetValueForProperty("WeeksOfMonth",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindowInternal)this).WeeksOfMonth, __y => TypeConverterExtensions.SelectToList<int>(__y, (__w)=> (int) global::System.Convert.ChangeType(__w, typeof(int))));
            }
            if (content.Contains("DaysOfWeek"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindowInternal)this).DaysOfWeek = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IDayOfWeek>) content.GetValueForProperty("DaysOfWeek",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindowInternal)this).DaysOfWeek, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IDayOfWeek>(__y, Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.DayOfWeekTypeConverter.ConvertFrom));
            }
            if (content.Contains("HoursOfDay"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindowInternal)this).HoursOfDay = (System.Collections.Generic.List<int>) content.GetValueForProperty("HoursOfDay",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindowInternal)this).HoursOfDay, __y => TypeConverterExtensions.SelectToList<int>(__y, (__w)=> (int) global::System.Convert.ChangeType(__w, typeof(int))));
            }
            if (content.Contains("LeadTimeInWeek"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindowInternal)this).LeadTimeInWeek = (int?) content.GetValueForProperty("LeadTimeInWeek",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindowInternal)this).LeadTimeInWeek, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("PatchingMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindowInternal)this).PatchingMode = (string) content.GetValueForProperty("PatchingMode",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindowInternal)this).PatchingMode, global::System.Convert.ToString);
            }
            if (content.Contains("CustomActionTimeoutInMin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindowInternal)this).CustomActionTimeoutInMin = (int?) content.GetValueForProperty("CustomActionTimeoutInMin",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindowInternal)this).CustomActionTimeoutInMin, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("IsCustomActionTimeoutEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindowInternal)this).IsCustomActionTimeoutEnabled = (bool?) content.GetValueForProperty("IsCustomActionTimeoutEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindowInternal)this).IsCustomActionTimeoutEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsMonthlyPatchingEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindowInternal)this).IsMonthlyPatchingEnabled = (bool?) content.GetValueForProperty("IsMonthlyPatchingEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindowInternal)this).IsMonthlyPatchingEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.MaintenanceWindow"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal MaintenanceWindow(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Preference"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindowInternal)this).Preference = (string) content.GetValueForProperty("Preference",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindowInternal)this).Preference, global::System.Convert.ToString);
            }
            if (content.Contains("Month"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindowInternal)this).Month = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMonth>) content.GetValueForProperty("Month",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindowInternal)this).Month, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMonth>(__y, Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.MonthTypeConverter.ConvertFrom));
            }
            if (content.Contains("WeeksOfMonth"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindowInternal)this).WeeksOfMonth = (System.Collections.Generic.List<int>) content.GetValueForProperty("WeeksOfMonth",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindowInternal)this).WeeksOfMonth, __y => TypeConverterExtensions.SelectToList<int>(__y, (__w)=> (int) global::System.Convert.ChangeType(__w, typeof(int))));
            }
            if (content.Contains("DaysOfWeek"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindowInternal)this).DaysOfWeek = (System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IDayOfWeek>) content.GetValueForProperty("DaysOfWeek",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindowInternal)this).DaysOfWeek, __y => TypeConverterExtensions.SelectToList<Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IDayOfWeek>(__y, Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.DayOfWeekTypeConverter.ConvertFrom));
            }
            if (content.Contains("HoursOfDay"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindowInternal)this).HoursOfDay = (System.Collections.Generic.List<int>) content.GetValueForProperty("HoursOfDay",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindowInternal)this).HoursOfDay, __y => TypeConverterExtensions.SelectToList<int>(__y, (__w)=> (int) global::System.Convert.ChangeType(__w, typeof(int))));
            }
            if (content.Contains("LeadTimeInWeek"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindowInternal)this).LeadTimeInWeek = (int?) content.GetValueForProperty("LeadTimeInWeek",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindowInternal)this).LeadTimeInWeek, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("PatchingMode"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindowInternal)this).PatchingMode = (string) content.GetValueForProperty("PatchingMode",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindowInternal)this).PatchingMode, global::System.Convert.ToString);
            }
            if (content.Contains("CustomActionTimeoutInMin"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindowInternal)this).CustomActionTimeoutInMin = (int?) content.GetValueForProperty("CustomActionTimeoutInMin",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindowInternal)this).CustomActionTimeoutInMin, (__y)=> (int) global::System.Convert.ChangeType(__y, typeof(int)));
            }
            if (content.Contains("IsCustomActionTimeoutEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindowInternal)this).IsCustomActionTimeoutEnabled = (bool?) content.GetValueForProperty("IsCustomActionTimeoutEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindowInternal)this).IsCustomActionTimeoutEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            if (content.Contains("IsMonthlyPatchingEnabled"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindowInternal)this).IsMonthlyPatchingEnabled = (bool?) content.GetValueForProperty("IsMonthlyPatchingEnabled",((Microsoft.Azure.PowerShell.Cmdlets.Oracle.Models.IMaintenanceWindowInternal)this).IsMonthlyPatchingEnabled, (__y)=> (bool) global::System.Convert.ChangeType(__y, typeof(bool)));
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Oracle.Runtime.SerializationMode.IncludeAll)?.ToString();

        public override string ToString()
        {
            var returnNow = false;
            var result = global::System.String.Empty;
            OverrideToString(ref result, ref returnNow);
            if (returnNow)
            {
                return result;
            }
            return ToJsonString();
        }
    }
    /// MaintenanceWindow resource properties
    [System.ComponentModel.TypeConverter(typeof(MaintenanceWindowTypeConverter))]
    public partial interface IMaintenanceWindow

    {

    }
}