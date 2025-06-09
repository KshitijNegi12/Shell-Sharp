using System.Net;
using System.Net.Sockets;

while(true){
    Console.Write("$ ");
    var command = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(command)) break;

    var parts = command.Split(' ');
    if (parts.Length > 0 && parts[0] == "exit") break;

    Console.WriteLine($"{parts[0]}: command not found");
}
