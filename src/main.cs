using System.Net;
using System.Net.Sockets;
using ShellSharp.src.Handler;

while (true)
{
    Console.Write("$ ");
    string? input = Console.ReadLine();
    if (!InputHandler.IsInputValid(input))
    {
        break;
    }
}
