using System;
using System.IO;

namespace app.Utils
{
    public class StaticHelpers
    {
        public static string Getwwwroot(string path = "/")
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, path);
        }
    }
}