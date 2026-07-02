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
