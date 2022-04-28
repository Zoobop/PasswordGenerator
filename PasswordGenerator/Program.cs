
Console.ForegroundColor = ConsoleColor.Yellow;
var length = 0;

// Loop to validate input
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

// Display information
var password = PasswordGenerator.Generate(length);

Console.WriteLine($"Your new password: {password}\n");

Console.WriteLine("To use this password, copy the text, then press any key to close out.");
Console.ReadKey();