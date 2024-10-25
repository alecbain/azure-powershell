// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support
{

    public partial struct FileExtensionsType :
        System.IEquatable<FileExtensionsType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.FileExtensionsType Avro = @"AVRO";

        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.FileExtensionsType Csv = @"CSV";

        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.FileExtensionsType Doc = @"DOC";

        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.FileExtensionsType Docm = @"DOCM";

        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.FileExtensionsType Documents = @"Documents";

        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.FileExtensionsType Docx = @"DOCX";

        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.FileExtensionsType Dot = @"DOT";

        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.FileExtensionsType Gz = @"GZ";

        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.FileExtensionsType Json = @"JSON";

        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.FileExtensionsType Odp = @"ODP";

        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.FileExtensionsType Ods = @"ODS";

        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.FileExtensionsType Odt = @"ODT";

        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.FileExtensionsType Orc = @"ORC";

        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.FileExtensionsType Parquet = @"PARQUET";

        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.FileExtensionsType Pdf = @"PDF";

        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.FileExtensionsType Pot = @"POT";

        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.FileExtensionsType Pps = @"PPS";

        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.FileExtensionsType Ppsx = @"PPSX";

        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.FileExtensionsType Ppt = @"PPT";

        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.FileExtensionsType Pptm = @"PPTM";

        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.FileExtensionsType Pptx = @"PPTX";

        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.FileExtensionsType Psv = @"PSV";

        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.FileExtensionsType Ssv = @"SSV";

        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.FileExtensionsType Tsv = @"TSV";

        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.FileExtensionsType Txt = @"TXT";

        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.FileExtensionsType Xlc = @"XLC";

        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.FileExtensionsType Xls = @"XLS";

        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.FileExtensionsType Xlsb = @"XLSB";

        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.FileExtensionsType Xlsm = @"XLSM";

        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.FileExtensionsType Xlsx = @"XLSX";

        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.FileExtensionsType Xlt = @"XLT";

        public static Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.FileExtensionsType Xml = @"XML";

        /// <summary>the value for an instance of the <see cref="FileExtensionsType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to FileExtensionsType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="FileExtensionsType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new FileExtensionsType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type FileExtensionsType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.FileExtensionsType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type FileExtensionsType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is FileExtensionsType && Equals((FileExtensionsType)obj);
        }

        /// <summary>Creates an instance of the <see cref="FileExtensionsType"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private FileExtensionsType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns hashCode for enum FileExtensionsType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for FileExtensionsType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to FileExtensionsType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="FileExtensionsType" />.</param>

        public static implicit operator FileExtensionsType(string value)
        {
            return new FileExtensionsType(value);
        }

        /// <summary>Implicit operator to convert FileExtensionsType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="FileExtensionsType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.FileExtensionsType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum FileExtensionsType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.FileExtensionsType e1, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.FileExtensionsType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum FileExtensionsType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.FileExtensionsType e1, Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.FileExtensionsType e2)
        {
            return e2.Equals(e1);
        }
    }
}