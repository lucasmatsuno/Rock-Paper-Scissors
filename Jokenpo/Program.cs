// See https://aka.ms/new-console-template for more information

//Rock, paper or scissors
string YeNo = "Y";
string escolha = "";
int pc = 0;
do
{
    escolha = "";
    pc = 0;
    while (escolha != "ROCK" && escolha !="PAPER" && escolha != "SCISSORS")
    {
        Console.Write("Enter ROCK, PAPER or SCISSORS: ");
        escolha = Console.ReadLine();
        escolha = escolha.ToUpper(); ;
    }

    Console.WriteLine($"You chose {escolha}");

    Random ger = new Random();
    pc = ger.Next(1, 4);

    switch (pc)
    {
        case 1:
            Console.WriteLine("The computer chose ROCK");
            break;
        case 2:
            Console.WriteLine("The computer chose PAPER");
            break;
        case 3:
            Console.WriteLine("The computer chose SCISSORS");
            break;
    }

    if (pc == 1 && escolha == "ROCK")
    {
        Console.WriteLine("It's a TIE!");
    }
    else if (pc == 1 && escolha == "PAPER")
    {
        Console.WriteLine("You WIN!");
    }
    else if (pc == 1 && escolha == "SCISSORS")
    {
        Console.WriteLine("You LOSE!");
    }
    if (pc == 2 && escolha == "ROCK")
    {
        Console.WriteLine("You LOSE!");
    }
    else if (pc == 2 && escolha == "PAPER")
    {
        Console.WriteLine("It's a TIE!");
    }
    else if (pc == 2 && escolha == "SCISSORS")
    {
        Console.WriteLine("You WIN!");
    }
    if (pc == 3 && escolha == "ROCK")
    {
        Console.WriteLine("You WIN!");
    }
    else if (pc == 3 && escolha == "PAPER")
    {
        Console.WriteLine("You LOSE!");
    }
    else if (pc == 3 && escolha == "SCISSORS")
    {
        Console.WriteLine("It's a TIE!");
    }
    Console.Write("Do you wanna play again? [Y/N]");

    string answer = Console.ReadLine();
    YeNo = answer.ToUpper(); ;
} while (YeNo == "Y" || YeNo =="y");


