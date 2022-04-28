public static class PasswordGenerator
{
    private static readonly string _alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private static readonly string _numbers = "0123456789";
    private static readonly string _symbols = "~!@#$%^&*?><`_+-=";
    
    private const int DefaultLength = 12;
    
    // Generates the new password
    public static string Generate(int length = DefaultLength)
    {
        var password = string.Empty;
        for (var i = 0; i < length; i++)
        {
            // Randomly selects a character to add to the password string
            var selector = Random.Shared.Next(0, 3);
            password += selector switch
            {
                1 => GetRandomNumber(),
                2 => GetRandomSymbol(),
                _ => GetRandomLetter()
            };
        }

        return password;
    }

    private static char GetRandomLetter() => _alphabet[Random.Shared.Next(0, _alphabet.Length - 1)];
    private static char GetRandomNumber() => _numbers[Random.Shared.Next(0, _numbers.Length - 1)];
    private static char GetRandomSymbol() => _symbols[Random.Shared.Next(0, _symbols.Length - 1)];
}