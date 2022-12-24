using System;


namespace R5T.Z0025
{
    public class ExperimentDrafts : IExperimentDrafts
    {
        #region Infrastructure

        public static IExperimentDrafts Instance { get; } = new ExperimentDrafts();


        private ExperimentDrafts()
        {
        }

        #endregion
    }
}
