using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PetEmote
{
    class Version
    {
        public static string[][][] Titles
        {
            get
            {
                return new string[][][] {
                    new string[][] {
                        new string [] { "First Try" }
                    },
                    new string[][] {
                        new string [] { "" },
                        new string [] { "" },
                        new string [] { "", "" },
                        new string [] { "", "" },
                        new string [] { "Random Emotes", "" },
                        new string [] { "Warlocks", "Editor", "Chance", "Help" },
                        new string [] { "Feed me" }
                    },
                };
            }
        }
        
        public static string Latest
        {
            get {
                int major = Version.Titles.Length - 1;
                int minor = Version.Titles[major].Length - 1;
                int build = Version.Titles[major][minor].Length - 1;
                return String.Concat(major, ".", minor, ".", build);
            }
        }

        public static bool Exists (string version)
        {
            int[] path;

            try {
                path = Version.GetPath(version);
            }
            catch (FormatException ex) {
                throw ex;
            }

            if (Version.Titles[path[0]][path[1]][path[2]] != null)
                return true;

            return false;
        }

        public static string GetTitle (string version)
        {
            int[] path;

            try {
                path = Version.GetPath(version);
            }
            catch (FormatException ex) {
                throw ex;
            }

            if (Version.Titles[path[0]][path[1]][path[2]] == null)
                throw new Exception(String.Concat("The version ", version, " does not exist."));

            return Version.Titles[path[0]][path[1]][path[2]];
        }

        private static int[] GetPath (string version)
        {
            string[] splitted = version.Split('.');
            int[] path = new int[splitted.Length];

            try {
                for (int i = 0; i < splitted.Length; i++) path[i] = int.Parse(splitted[i]);
            }
            catch (FormatException ex) {
                throw ex;
            }

            return path;
        }
    }
}
