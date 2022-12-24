using System;


namespace R5T.Z0025
{
    public class DemonstrationDrafts : IDemonstrationDrafts
    {
        #region Infrastructure

        public static IDemonstrationDrafts Instance { get; } = new DemonstrationDrafts();


        private DemonstrationDrafts()
        {
        }

        #endregion
    }
}
