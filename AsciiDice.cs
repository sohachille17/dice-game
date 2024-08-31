class AsciiDice
{
    public string? DiceLogo {get ; private set; }

    public void GetLogo()
    {
         DiceLogo = @"//    _______
        /\ o o o\
        /o \ o o o\_______
        <    >------>   o /|
        \ o/  o   /_____/o|
        \/______/     |oo|
                |   o   |o/
                |_______|/";

        Console.WriteLine(DiceLogo);
    }
}