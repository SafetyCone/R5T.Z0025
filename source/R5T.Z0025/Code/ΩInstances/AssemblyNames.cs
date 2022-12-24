using System;


namespace R5T.Z0025
{
    public class AssemblyNames : IAssemblyNames
    {
        #region Infrastructure

        public static IAssemblyNames Instance { get; } = new AssemblyNames();


        private AssemblyNames()
        {
        }

        #endregion
    }
}
