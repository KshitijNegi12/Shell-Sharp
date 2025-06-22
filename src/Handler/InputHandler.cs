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
                switch (parts[0])
                {
                    case "exit":
                        return Basic.HandleExit(parts);

                    case "echo":
                        return Basic.HandleEcho(parts);

                    default:
                        return Basic.HandleDefault(parts);

                }
            }
            return false;
        }
    }
}
