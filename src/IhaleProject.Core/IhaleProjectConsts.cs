using IhaleProject.Debugging;

namespace IhaleProject
{
    public class IhaleProjectConsts
    {
        public const string LocalizationSourceName = "IhaleProject";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = false;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "228fae4f79664722aef35c31497403ae";
    }
}
