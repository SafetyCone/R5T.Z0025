using System;


namespace R5T.Z0025
{
    public class Values : IValues
    {
        #region Infrastructure

        public static IValues Instance { get; } = new Values();


        private Values()
        {
        }

        #endregion
    }
}
