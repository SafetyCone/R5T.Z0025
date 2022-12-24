using System;

using R5T.T0131;


namespace R5T.Z0025
{
    [ValuesMarker]
    public partial interface IValues : IValuesMarker
    {
        /// <summary>
        /// Here is a value.
        /// </summary>
        public string Value01 => "Value01";
    }
}
