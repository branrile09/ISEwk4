namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool validInput = false;
            int number = 0;
            float fNumb = 0.0f;

            Console.Write("enter an intiger:");
            while (!validInput)
            {
                string input = Console.ReadLine();                
                if (int.TryParse(input, out number))
                {                   
                    validInput = true;
                    Console.WriteLine($"you entered {number}");
                }
                else
                {
                    Console.Clear();
                    Console.Write("Bad input, enter an intiger:");
                }
            }
           
            do
            {
                Console.Write("enter a float:");
                string input = Console.ReadLine();
                if (float.TryParse(input, out float result))
                {
                    //fNumb = float.Parse(input);
                    fNumb = result;
                    validInput = true;
                    Console.WriteLine($"you entered {number}");

                }
                else
                {
                    validInput = false;
                    Console.Clear();
                    Console.Write("Bad input, enter an intiger:");
                }


            } while (!validInput);


            Console.WriteLine($"lets count to {number}");
            // loops
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Computers start at 0!!!");
            Console.WriteLine("lets try that again");
            Console.WriteLine($"lets count to {fNumb}");


            for (int i = 0; i < fNumb + 1; i++)
            {
                Console.WriteLine(i);
            }



        }
    }
}