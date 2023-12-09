Console.WriteLine("****** Welcome To Math Game ******");
Console.Write("Please Enter your Name >> ");
string playerName = Console.ReadLine();
int playerScore = 0;

Console.Clear();

SimulateDelay(3);
PrintMenu();

Console.Write("please Select Game Mode >>");
char selectedMode = Char.Parse(Console.ReadLine().ToLower().Trim());
switch (selectedMode)
{
    case 'a':
        AdditionMode();
        break;
    case 's':
        SubtractionMode();
        break;
    case 'm':
        MultiplicationMode();
        break;
    case 'd':
        DivisionMode();
        break;
    case 'q':
        QuitTheGame();
        break;
    default:
        Console.WriteLine("Incorrect Choice");
        break;
}

void QuitTheGame()
{
    Console.WriteLine("QuitTheGame");
}

void DivisionMode()
{
    Console.WriteLine("DivisionMode");
}

void MultiplicationMode()
{
    Console.WriteLine("MultiplicationMode");
}

void SubtractionMode()
{
    Console.WriteLine("SubtractionMode");
}

void AdditionMode()
{
    Console.Clear();
    string again = "y";
    do
    {

        int firstOperand = generateRondomOperand(0, 9);
        int secondOperand = generateRondomOperand(0, 9);
        string answerStatus = "";
        displayDashboard(answerStatus);
        Console.Write($"{firstOperand} + {secondOperand} = ");
        int answer = int.Parse(Console.ReadLine());
        Console.Clear();

        if (firstOperand + secondOperand == answer)
        {
            playerScore++;
            answerStatus = "Correct!";

        }
        else
        {
            if (playerScore > 0)
            {
                playerScore--;
            }
            answerStatus = "Incorrect!";
        }
        displayDashboard(answerStatus);
        Thread.Sleep(1000);
        Console.Clear();

    } while (playerScore < 10);
    if (playerScore == 10)
    {
        Console.WriteLine("Congrats You've got the Max Score");
    }
    else
    {
        Console.WriteLine("Bye!");
    }
}

void displayDashboard(string answerStatus)
{
    Console.WriteLine("***********************************************");
    Console.WriteLine("***************  Addition Mode  ***************");
    Console.WriteLine("***********************************************");
    Console.WriteLine($"Name: {playerName}\t Score: {playerScore}/10\tAnswer: {answerStatus}");
    Console.WriteLine("***********************************************");

}


void PrintMenu()
{
    Console.WriteLine("A - Addition");
    Console.WriteLine("S - Subtraction");
    Console.WriteLine("M - Multiplication");
    Console.WriteLine("D - Division");
    Console.WriteLine("Q - Quit The Game");
}
void SimulateDelay(int delayInSec)
{
    for (int i = delayInSec; i > 0; i--)
    {
        Console.Write($"Welcome {playerName} the game starts in {i} Seconds");
        Thread.Sleep(1000);
        Console.Clear();
    }
}
int generateRondomOperand(int minValue, int maxValue)
{
    Random random = new Random();
    return random.Next(minValue, maxValue);
}
