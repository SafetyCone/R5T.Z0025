using System;


namespace R5T.Z0025
{
    public class Functionality : IFunctionality
    {
        #region Infrastructure

        public static IFunctionality Instance { get; } = new Functionality();


        private Functionality()
        {
        }

        #endregion
    }
}
