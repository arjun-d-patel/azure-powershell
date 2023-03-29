// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support
{

    /// <summary>The type of the detailed report. By default ActualCost is provided</summary>
    public partial struct CostDetailsMetricType :
        System.IEquatable<CostDetailsMetricType>
    {
        /// <summary>Actual cost data.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.CostDetailsMetricType ActualCost = @"ActualCost";

        /// <summary>Amortized cost data.</summary>
        public static Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.CostDetailsMetricType AmortizedCost = @"AmortizedCost";

        /// <summary>the value for an instance of the <see cref="CostDetailsMetricType" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Creates an instance of the <see cref="CostDetailsMetricType"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private CostDetailsMetricType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to CostDetailsMetricType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="CostDetailsMetricType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new CostDetailsMetricType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type CostDetailsMetricType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.CostDetailsMetricType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type CostDetailsMetricType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is CostDetailsMetricType && Equals((CostDetailsMetricType)obj);
        }

        /// <summary>Returns hashCode for enum CostDetailsMetricType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for CostDetailsMetricType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to CostDetailsMetricType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="CostDetailsMetricType" />.</param>

        public static implicit operator CostDetailsMetricType(string value)
        {
            return new CostDetailsMetricType(value);
        }

        /// <summary>Implicit operator to convert CostDetailsMetricType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="CostDetailsMetricType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.CostDetailsMetricType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum CostDetailsMetricType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.CostDetailsMetricType e1, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.CostDetailsMetricType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum CostDetailsMetricType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.CostDetailsMetricType e1, Microsoft.Azure.PowerShell.Cmdlets.CostManagement.Support.CostDetailsMetricType e2)
        {
            return e2.Equals(e1);
        }
    }
}