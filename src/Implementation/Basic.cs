using System.IO;

namespace ShellSharp.src.Implementation
{
    internal class Basic
    {
        public static bool HandleExit(string[] args)
        {
            return false;
        }

        public static bool HandleEcho(string[] args)
        {
            string res = string.Join(" ", args, 1, args.Length - 1);
            Console.WriteLine(res);
            return true;
        }

        public static bool HandleDefault(string[] args)
        {
            Console.WriteLine($"{args[0]}: command not found");
            return true;
        }
    }
}
