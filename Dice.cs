/* Dice Class */
namespace DiceRollGame;
class Dice
{
    const int MAX = 7;
    const int ROUND = 3;
    public int NumberOfTries {  get;  set ;} = ROUND;
    public int TotalCount { get;  set ;}
    public bool IsValidNumber { get; private set ;}
    public Random RandomNumber = new Random();

    public Dice(bool isValid, Random random)
    {
       // incase we need it.
        TotalCount = 0;
        IsValidNumber = isValid;
        RandomNumber = random;
    }
    public Dice()
    {
        //empty overload
    }


    public int GuessNumber(string userInput, out bool isValid)
    {
        bool isParse = int.TryParse(userInput, out int result);
        isValid = isParse;

        return result;
    }
    public int RandomNumberGenerator() => RandomNumber.Next(1, MAX);
    public bool Validator() => IsValidNumber;





}
