

class Play
{
    private Dice dice1 = new Dice();
    private AsciiDice diceLogo = new AsciiDice();


    public void Run()
    {
        Console.WriteLine("Welcome to our =>Dice rolling<= game");
        Console.WriteLine($"You just have {dice1.NumberOfTries} chance to win good luck!!");
        Console.WriteLine($"Dice rolled. Guess what number it shows in {dice1.NumberOfTries} tries.");
        Console.WriteLine("\t");
        diceLogo.GetLogo();

        do
        {
            Console.WriteLine("Enter a number!!");

            string?  userInput = Console.ReadLine();
            bool isNumberValid;
            dice1.NumberOfTries--;
            
            if(dice1.GuessNumber(userInput!, out isNumberValid) == dice1.RandomNumberGenerator())
            {
                dice1.TotalCount++;

                Console.WriteLine("You Win!!");
                //Console.WriteLine($"Your score {dice1.TotalCount}");
                

            }else
            {
                 Console.WriteLine("You loose :-(");
                 Console.WriteLine("\t");
                 //Console.WriteLine($"Your score {dice1.TotalCount}");
            }
            
            if(!isNumberValid)
            {
                Console.WriteLine("Enter a valid number!!");
            }
            if(dice1.NumberOfTries == 0)
            {
                Console.WriteLine($"You scored is {dice1.TotalCount} / {dice1.NumberOfTries}");
            }


        }while(dice1.NumberOfTries > 0);
    }
}