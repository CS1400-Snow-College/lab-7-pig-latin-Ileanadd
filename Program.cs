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
    string newWord = word;
    string pigWord = "";
    string punctuation = "";

    if (!char.IsLetter(newWord[newWord.Length - 1]))
    {
        punctuation = newWord[newWord.Length - 1].ToString();
        newWord = newWord.Substring(0, newWord.Length - 1);
        
    }

    if (vowels.Contains(word[0]))
    {
        pigWord = newWord + "way";
    }
    else
    {
        int constant = 0;

        while (constant < newWord.Length && !vowels.Contains(newWord[constant]))
        {
            constant++;
        }
        string beginning = newWord.Substring(0, constant);
        string rest = newWord.Substring(constant);

        pigWord = rest + beginning + "ay";
    }

    pigWord += punctuation; 
    pigLatin += pigWord + " ";
}

Console.WriteLine("In pig latin that's: " + pigLatin);

Random rand = new Random();
int offset = rand.Next(1,26);

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