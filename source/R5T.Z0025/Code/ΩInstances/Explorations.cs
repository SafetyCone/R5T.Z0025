using System;


namespace R5T.Z0025
{
    public class Explorations : IExplorations
    {
        #region Infrastructure

        public static IExplorations Instance { get; } = new Explorations();


        private Explorations()
        {
        }

        #endregion
    }
}
