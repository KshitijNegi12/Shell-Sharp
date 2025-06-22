using ShellSharp.src.Implementation;

namespace ShellSharp.src.Handler
{
    internal class InputHandler
    {
        public static bool IsInputValid(string? input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }

            var parts = input.Split(' ');
            if (parts.Length > 0)
            {
                var cmd = parts[0];
                var args = parts[1..];
                switch (cmd)
                {
                    case "exit":
                        return Basic.HandleExit(args);

                    case "echo":
                        return Basic.HandleEcho(args);

                    case "type":
                        return Basic.HandleType(args);

                    default:
                        return Basic.HandleDefault(cmd, args);

                }
            }
            return false;
        }
    }
}
