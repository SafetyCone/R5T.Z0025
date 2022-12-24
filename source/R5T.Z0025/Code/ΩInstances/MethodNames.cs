using System;


namespace R5T.Z0025
{
    public class MethodNames : IMethodNames
    {
        #region Infrastructure

        public static IMethodNames Instance { get; } = new MethodNames();


        private MethodNames()
        {
        }

        #endregion
    }
}
