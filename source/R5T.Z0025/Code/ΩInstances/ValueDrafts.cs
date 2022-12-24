using System;


namespace R5T.Z0025
{
    public class ValueDrafts : IValueDrafts
    {
        #region Infrastructure

        public static IValueDrafts Instance { get; } = new ValueDrafts();


        private ValueDrafts()
        {
        }

        #endregion
    }
}
