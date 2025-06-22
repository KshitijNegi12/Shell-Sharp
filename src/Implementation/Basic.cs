using System.IO;

namespace ShellSharp.src.Implementation
{
    internal class Basic
    {
        private static readonly List<string> _validCmds;

        static Basic()
        {
            _validCmds = new List<string>()
            {
                "echo", "exit"
            };
        }

        public static bool HandleExit(string[] args)
        {
            return false;
        }

        public static bool HandleEcho(string[] args)
        {
            string res = string.Join(" ", args);
            Console.WriteLine(res);
            return true;
        }

        public static bool HandleType(string[] args)
        {
            if(args.Length == 1)
            {
                if (_validCmds.Contains(args[0]))
                {
                    Console.WriteLine($"{args[0]} is a shell builtin");
                }
                else
                {
                    Console.WriteLine($"{args[0]}: not found");
                }
                return true;
            }
            return false;
        }

        public static bool HandleDefault(string cmd, string[] args)
        {
            Console.WriteLine($"{cmd}: command not found");
            return true;
        }
    }
}
