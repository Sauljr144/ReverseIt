string playAgain = "Y";
bool isValid;
int number;
int remainder;
int revNumber = 0;
string myWord;

while (playAgain != "N")
{
    //-----With string---//

    Console.WriteLine("Hello there! Please enter a word.");
    myWord = Console.ReadLine();

    for (int i = myWord.Length -1; i >= 0; i--)
        {
            Console.WriteLine(myWord[i]);
        }


    //----With int----//

    //-----User Input-----//

    Console.WriteLine("Hello there! Please enter a number!");
    isValid = int.TryParse(Console.ReadLine(), out number);

    if(!isValid)
    {
        Console.WriteLine("Please enter a valid number.");
    }

    else
    {
        ReverseNum();

        Console.WriteLine("Do you want to play again? Y/N");
        playAgain = Console.ReadLine().ToUpper();

    }

}

Console.WriteLine("Bye!");

//-----Function-----//s

void ReverseNum()
{
    for(; number > 0; number = number /10)
    {
        remainder = number % 10;

        revNumber = (revNumber * 10) + remainder;
    }

    Console.WriteLine($"Reversed Number is: {revNumber}");
}