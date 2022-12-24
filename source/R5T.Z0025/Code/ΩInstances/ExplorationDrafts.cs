using System;


namespace R5T.Z0025
{
    public class ExplorationDrafts : IExplorationDrafts
    {
        #region Infrastructure

        public static IExplorationDrafts Instance { get; } = new ExplorationDrafts();


        private ExplorationDrafts()
        {
        }

        #endregion
    }
}
