
Console.ForegroundColor = ConsoleColor.Yellow;
var length = 0;

while (true)
{
    Console.Clear();
    Console.Write("Enter password length: ");

    var input = Console.ReadLine();
    if (int.TryParse(input, out length))
    {
        break;
    }
}

var password = PasswordGenerator.Generate(length);

Console.WriteLine($"Your new password: {password}");