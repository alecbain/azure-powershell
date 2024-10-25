// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Peering.Support
{

    public partial struct LegacyPeeringsKind :
        System.IEquatable<LegacyPeeringsKind>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Peering.Support.LegacyPeeringsKind Direct = @"Direct";

        public static Microsoft.Azure.PowerShell.Cmdlets.Peering.Support.LegacyPeeringsKind Exchange = @"Exchange";

        /// <summary>the value for an instance of the <see cref="LegacyPeeringsKind" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to LegacyPeeringsKind</summary>
        /// <param name="value">the value to convert to an instance of <see cref="LegacyPeeringsKind" />.</param>
        internal static object CreateFrom(object value)
        {
            return new LegacyPeeringsKind(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type LegacyPeeringsKind</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Peering.Support.LegacyPeeringsKind e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type LegacyPeeringsKind (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is LegacyPeeringsKind && Equals((LegacyPeeringsKind)obj);
        }

        /// <summary>Returns hashCode for enum LegacyPeeringsKind</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Creates an instance of the <see cref="LegacyPeeringsKind"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private LegacyPeeringsKind(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns string representation for LegacyPeeringsKind</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to LegacyPeeringsKind</summary>
        /// <param name="value">the value to convert to an instance of <see cref="LegacyPeeringsKind" />.</param>

        public static implicit operator LegacyPeeringsKind(string value)
        {
            return new LegacyPeeringsKind(value);
        }

        /// <summary>Implicit operator to convert LegacyPeeringsKind to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="LegacyPeeringsKind" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Peering.Support.LegacyPeeringsKind e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum LegacyPeeringsKind</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Peering.Support.LegacyPeeringsKind e1, Microsoft.Azure.PowerShell.Cmdlets.Peering.Support.LegacyPeeringsKind e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum LegacyPeeringsKind</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Peering.Support.LegacyPeeringsKind e1, Microsoft.Azure.PowerShell.Cmdlets.Peering.Support.LegacyPeeringsKind e2)
        {
            return e2.Equals(e1);
        }
    }
}