using System;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello, input your string: ");
            string text = Console.ReadLine();
            Console.Write("Input your key: ");
            int key = int.Parse(Console.ReadLine());
            Console.WriteLine("Select method(0 - Cesar, 1 - XOR, 2 - Scytale): ");
            int method = int.Parse(Console.ReadLine());

            switch (method)
            {
                case 0:
                    Algorithms algorithms = new Cesar();
                    Code code = new Code(algorithms);
                    string secret = code.Encode(text, key);
                    Console.WriteLine(secret);
                    Console.WriteLine(code.Decode(secret, key));
                    break;
                case 1:
                    algorithms = new XOR();
                    code = new Code(algorithms);
                    secret = code.Encode(text, key);
                    Console.WriteLine(secret);
                    Console.WriteLine(code.Decode(secret, key));
                    break;
                case 2:
                    algorithms = new Scytale();
                    code = new Code(algorithms);
                    secret = code.Encode(text, key);
                    Console.WriteLine(secret);
                    Console.WriteLine(code.Decode(secret, key));
                    break;
            }

            
        }
    }
}