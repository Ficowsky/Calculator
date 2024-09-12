namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            string userInput2;
            string userInput3;
            double number;
            double number2;
            double suma;
            Console.WriteLine("paste number");
            userInput = Console.ReadLine();
            bool fine = double.TryParse(userInput, out number);

            if (fine)
            {
                Console.WriteLine("kolejna liczba");

            }
            else
            {
                Console.WriteLine("wrong number");
                return;

            }
            Console.WriteLine("paste number");

            userInput2 = Console.ReadLine();
            bool fine2 = double.TryParse(userInput2, out number2);

            if (fine2)
            {
                Console.WriteLine("next number");

            }
            else
            {
                Console.WriteLine("wrong number");

            }
            Console.WriteLine("Select which switch is available -,+,/,* ?");
            userInput3 = Console.ReadLine();

            switch (userInput3)
            {
                case "-":
                    suma = number - number2;
                    Console.WriteLine(suma);
                    break;

                case "+":
                    suma = number + number2;
                    Console.WriteLine(suma);
                    break;
                case "/":
                    suma = number / number2;
                    Console.WriteLine(suma);
                    break;
                case "*":
                    suma = number * number;
                    Console.WriteLine(suma);
                    break;

                default:
                    Console.WriteLine("wrong asnewar pls try again");
                    return;
            }

            Console.Read();
        }
    }
}
