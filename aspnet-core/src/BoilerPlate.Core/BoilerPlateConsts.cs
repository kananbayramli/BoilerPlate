using BoilerPlate.Debugging;

namespace BoilerPlate
{
    public class BoilerPlateConsts
    {
        public const string LocalizationSourceName = "BoilerPlate";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "c6b37383c17e4fa5bf26eff631daebec";
    }
}
