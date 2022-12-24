using System;

using R5T.T0131;


namespace R5T.Z0025
{
    [DraftValuesMarker]
    public partial interface IValueDrafts : IDraftValuesMarker
    {
        /// <summary>
        /// Here is a draft value.
        /// </summary>
        public string ValueDraft01 => "ValueDraft01";
    }
}
