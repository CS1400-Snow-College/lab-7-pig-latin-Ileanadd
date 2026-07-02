// Lab 07 - Pig Latin
// Ileana Gonzalez 06/26

Console.Clear();

// Ask the user to introduce the message they want to manipulate
Console.WriteLine("Let's manipulate your phrase!");
Console.Write("Please write your message: ");
string message = Console.ReadLine()!;

string[] words = message.Split(' ');

string pigLatin = "";
string encryptedM = "";

string vowels = "aeiouAEIOU";

foreach (string word in words)
{
    string pigWord = "";

    if (vowels.Contains(word[0]))
    {
        pigWord = word + "way";
    }
    else
    {
        int constant = 0;

        while (constant < word.Length && !vowels.Contains(word[constant]))
        {
            constant++;
        }
        string beginning = word.Substring(0, constant);
        string rest = word.Substring(constant);

        pigWord = rest + beginning + "ay";
    }

    pigLatin += pigWord + " ";
}

Console.WriteLine("In pig latin that's: " + pigLatin);

int offset = 5;

foreach (char letter in pigLatin)
{
    if (letter >= 'a' && letter <= 'z')
    {
        char encrypted = (char)(letter + offset);

        if (encrypted > 'z')
        {
            encrypted = (char)(encrypted - 26);
        }

        encryptedM += encrypted;
    }
    else if (letter >= 'A' && letter <= 'Z')
    {
        char encrypted = (char)(letter + offset);

        if (encrypted > 'Z')
        {
            encrypted = (char)(encrypted - 26);
        }

        encryptedM += encrypted;
    }
    else
    {
        encryptedM += letter;
    }
}

Console.WriteLine("We can encrypt that as: " + encryptedM);