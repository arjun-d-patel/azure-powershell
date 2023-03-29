// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Websites.Support
{

    /// <summary>Operation type.</summary>
    public partial struct BackupRestoreOperationType :
        System.IEquatable<BackupRestoreOperationType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.BackupRestoreOperationType Clone = @"Clone";

        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.BackupRestoreOperationType CloudFs = @"CloudFS";

        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.BackupRestoreOperationType Default = @"Default";

        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.BackupRestoreOperationType Relocation = @"Relocation";

        public static Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.BackupRestoreOperationType Snapshot = @"Snapshot";

        /// <summary>
        /// the value for an instance of the <see cref="BackupRestoreOperationType" /> Enum.
        /// </summary>
        private string _value { get; set; }

        /// <summary>Creates an instance of the <see cref="BackupRestoreOperationType"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private BackupRestoreOperationType(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to BackupRestoreOperationType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="BackupRestoreOperationType" />.</param>
        internal static object CreateFrom(object value)
        {
            return new BackupRestoreOperationType(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type BackupRestoreOperationType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.BackupRestoreOperationType e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type BackupRestoreOperationType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is BackupRestoreOperationType && Equals((BackupRestoreOperationType)obj);
        }

        /// <summary>Returns hashCode for enum BackupRestoreOperationType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for BackupRestoreOperationType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to BackupRestoreOperationType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="BackupRestoreOperationType" />.</param>

        public static implicit operator BackupRestoreOperationType(string value)
        {
            return new BackupRestoreOperationType(value);
        }

        /// <summary>Implicit operator to convert BackupRestoreOperationType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="BackupRestoreOperationType" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.BackupRestoreOperationType e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum BackupRestoreOperationType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.BackupRestoreOperationType e1, Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.BackupRestoreOperationType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum BackupRestoreOperationType</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.BackupRestoreOperationType e1, Microsoft.Azure.PowerShell.Cmdlets.Websites.Support.BackupRestoreOperationType e2)
        {
            return e2.Equals(e1);
        }
    }
}