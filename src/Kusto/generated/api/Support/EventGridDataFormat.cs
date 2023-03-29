// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support
{

    /// <summary>
    /// The data format of the message. Optionally the data format can be added to each message.
    /// </summary>
    public partial struct EventGridDataFormat :
        System.IEquatable<EventGridDataFormat>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.EventGridDataFormat Apacheavro = @"APACHEAVRO";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.EventGridDataFormat Avro = @"AVRO";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.EventGridDataFormat Csv = @"CSV";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.EventGridDataFormat Json = @"JSON";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.EventGridDataFormat Multijson = @"MULTIJSON";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.EventGridDataFormat Orc = @"ORC";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.EventGridDataFormat Parquet = @"PARQUET";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.EventGridDataFormat Psv = @"PSV";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.EventGridDataFormat Raw = @"RAW";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.EventGridDataFormat Scsv = @"SCSV";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.EventGridDataFormat Singlejson = @"SINGLEJSON";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.EventGridDataFormat Sohsv = @"SOHSV";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.EventGridDataFormat Tsv = @"TSV";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.EventGridDataFormat Tsve = @"TSVE";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.EventGridDataFormat Txt = @"TXT";

        public static Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.EventGridDataFormat W3Clogfile = @"W3CLOGFILE";

        /// <summary>the value for an instance of the <see cref="EventGridDataFormat" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Conversion from arbitrary object to EventGridDataFormat</summary>
        /// <param name="value">the value to convert to an instance of <see cref="EventGridDataFormat" />.</param>
        internal static object CreateFrom(object value)
        {
            return new EventGridDataFormat(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type EventGridDataFormat</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.EventGridDataFormat e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type EventGridDataFormat (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is EventGridDataFormat && Equals((EventGridDataFormat)obj);
        }

        /// <summary>Creates an instance of the <see cref="EventGridDataFormat"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private EventGridDataFormat(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Returns hashCode for enum EventGridDataFormat</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for EventGridDataFormat</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to EventGridDataFormat</summary>
        /// <param name="value">the value to convert to an instance of <see cref="EventGridDataFormat" />.</param>

        public static implicit operator EventGridDataFormat(string value)
        {
            return new EventGridDataFormat(value);
        }

        /// <summary>Implicit operator to convert EventGridDataFormat to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="EventGridDataFormat" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.EventGridDataFormat e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum EventGridDataFormat</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.EventGridDataFormat e1, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.EventGridDataFormat e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum EventGridDataFormat</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.EventGridDataFormat e1, Microsoft.Azure.PowerShell.Cmdlets.Kusto.Support.EventGridDataFormat e2)
        {
            return e2.Equals(e1);
        }
    }
}