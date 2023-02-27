using StackDemo;

namespace StackDemo
{
    static void Main(string[] args)
    {
        var stack = new MyStack(40);

        stack.Push(4);
        stack.Push(5);
        stack.Push(1);


        Console.WriteLine(stack.ToString());

        string word = "Reliefpfeiler";
        Console.WriteLine($"Ist das Wort \"{word}\" ein Palindrom? {IsPalindrome(word)}");


        // Ich habe nun die ganze Implementierungg vollständig gemacht. Jedoch verstehe ich nicht, wie man Testings durchführt. Muss ich dafür jedes mal eine einzelen Klasse erstellen? Wie kann ich schauen ob es positif oder negativ ist? Ich werde Sie das nächstes mal Fragen kommen.
    }
}



class Program
{
   

    static bool IsPalindrome(string word)
    {
        MyStack stack = new MyStack(word.Length);

        // Legen Sie die Buchstaben des Wortes auf den Stack
        foreach (char c in word)
        {
            stack.Push(c);
        }

        // Vergleichen Sie die Buchstaben des Wortes mit denen auf dem Stack
        foreach (char c in word)
        {
            if (c != stack.Pop())
            {
                return false;
            }
        }

        return true;
    }
}