namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //some variables
            bool validInput = false;
            int number = 0;
            float fNumb = 0.0f;
            //console
            Console.Write("enter an intiger:");

            //test some while loops
            while (!validInput)
            {                
                string input = Console.ReadLine();                
                //we are testing the parse before we actually parse the userinput
                //this helps with edgecases and prevents crashes
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
           
            //do while loop
            do
            {
                Console.Write("enter a float:");
                string input = Console.ReadLine();
                //2nd way we parse the user input, this shows another way but does the same thing
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

            //play with some for loops
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