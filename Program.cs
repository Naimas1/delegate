using System;
namespace DelegateExample;
public class Program
{
    public delegate void MessageDelegate(string message);

    public class Prog
    {
        static void Main(string[] args)
        {
            MessageDelegate messageDelegate = ShowMessage;

            messageDelegate("Привіт!");
            messageDelegate("Це текстове повідомлення.");

            Console.ReadKey();
        }
        static void ShowMessage(string message)
        {
            Console.WriteLine("Повідомлення: " + message);
        }
    }
}
