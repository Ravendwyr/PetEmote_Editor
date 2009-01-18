using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PetEmote.Emotes
{
    class LuaTableWriter
    {
        public const int EmptyLinesBetweenTables = 1;

        protected StreamWriter writer;
        protected ArrayList stack = new ArrayList();
        protected int emptyLinesBetweenTables = 1;

        public LuaTableWriter (string path) {
            this.writer = new StreamWriter(path, false, Encoding.UTF8);
            this.writer.AutoFlush = false;
        }

        public void Write (string[] content)
        {
            foreach (string line in content)
                this.writer.WriteLine(line);

            this.writer.Flush();
        }

        public void Close ()
        {
            this.writer.Close();
        }

        public static string[] Table (string container, string title, string[] content)
        {
            string[] result = new string[content.Length + 2 + LuaTableWriter.EmptyLinesBetweenTables];
            LuaTableWriter.IndentLines(ref content);

            result[0] = container + "[\"" + title + "\"] = {";
            content.CopyTo(result, 1);
            result[content.Length + 1] = "}";

            return result;
        }

        public static string[] List (int index, string[] content)
        {
            string[] result = new string[content.Length + 2];
            LuaTableWriter.IndentLines(ref content);

            result[0] = "[" + index.ToString() + "] = {";
            content.CopyTo(result, 1);
            result[content.Length + 1] = "},";

            return result;
        }

        public static string[] List (string index, string[] content)
        {
            string[] result = new string[content.Length + 2];
            LuaTableWriter.IndentLines(ref content);

            result[0] = "[\"" + index + "\"] = {";
            content.CopyTo(result, 1);
            result[content.Length + 1] = "},";

            return result;
        }

        public static string Item (int index, int content)
        {
            return "[" + index.ToString() + "] = " + content.ToString() + ",";
        }

        public static string Item (int index, int[] content)
        {
            string result = "[" + index.ToString() + "] = { ";
            for (int i = 0; i < content.Length; i++)
                result += (i > 0 ? ", " : "") + content[i].ToString();
            return result + " },";
        }

        public static string Item (int index, string content)
        {
            return "[" + index.ToString() + "] = \"" + content + "\",";
        }

        public static string Item (int index, string[] content)
        {
            string result = "[" + index.ToString() + "] = { ";
            for (int i = 0; i < content.Length; i++)
                result += (i > 0 ? ", " : "") + "\"" + content[i] + "\"";
            return result + " },";
        }

        public static string Item (int index, EmoteNodeProperties.EmoteCondition content)
        {
            return "[" + index.ToString() + "] = " + Enum.GetName(content.GetType(), content) + ",";
        }

        public static string Item (string index, int content)
        {
            return "[\"" + index + "\"] = " + content.ToString() + ",";
        }

        public static string Item (string index, int[] content)
        {
            string result = "[\"" + index + "\"] = { ";
            for (int i = 0; i < content.Length; i++)
                result += (i > 0 ? ", " : "") + content[i].ToString();
            return result + " },";
        }

        public static string Item (string index, string content)
        {
            return "[\"" + index + "\"] = \"" + content + "\",";
        }

        public static string Item (string index, string[] content)
        {
            string result = "[\"" + index + "\"] = { ";
            for (int i = 0; i < content.Length; i++)
                result += (i > 0 ? ", " : "") + "\"" + content[i] + "\"";
            return result + " },";
        }

        public static string Item (string index, EmoteNodeProperties.EmoteCondition content)
        {
            return "[\"" + index + "\"] = " + Enum.GetName(content.GetType(), content) + ",";
        }

        public static void IndentLines (ref string[] lines)
        {
            for (int i = 0; i < lines.Length; i++)
                lines[i] = "\t" + lines[i];
        }
    }
}
