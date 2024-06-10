using System;

while (true)
{
    Console.WriteLine("Hello, this program Calculate IELTS score ! ");

    Console.Write("Enter reading score : 📖  ");
    string userReadingInput = Console.ReadLine();
    double readingScore = Convert.ToDouble(userReadingInput);

    Console.Write("Enter listening score : 🎧  ");
    string userListeningInput = Console.ReadLine();
    double listeningScore = Convert.ToDouble(userListeningInput);

    Console.Write("Enter writing score : 🖋  ");
    string userWritingInput = Console.ReadLine();
    double writingScore = Convert.ToDouble(userWritingInput);

    Console.Write("Enter speaking score : 🗣  ");
    string userSpeakingInput = Console.ReadLine();
    double speakingScore = Convert.ToDouble(userSpeakingInput);

    double scoreIELTS = (readingScore + listeningScore + writingScore + speakingScore) / 4;

    if (scoreIELTS > 3.7 && scoreIELTS < 4.2)
    {
        scoreIELTS = 4.0;
    }
    else if (scoreIELTS > 4.2 && scoreIELTS < 4.7)
    {
        scoreIELTS = 4.5;
    }
    else if (scoreIELTS > 4.7 && scoreIELTS < 5.2)
    {
        scoreIELTS = 5;
    }
    else if (scoreIELTS > 5.2 && scoreIELTS < 5.7)
    {
        scoreIELTS = 5.5;
    }
    else if (scoreIELTS > 5.7 && scoreIELTS < 6.2)
    {
        scoreIELTS = 6;
    }
    else if (scoreIELTS > 6.2 && scoreIELTS < 6.7)
    {
        scoreIELTS = 6.5;
    }
    else if (scoreIELTS > 6.7 && scoreIELTS < 7.2)
    {
        scoreIELTS = 7;
    }
    else if (scoreIELTS > 7.2 && scoreIELTS < 7.7)
    {
        scoreIELTS = 7.5;
    }
    else if (scoreIELTS > 7.7 && scoreIELTS < 8.2)
    {
        scoreIELTS = 8;
    }
    else if (scoreIELTS > 8.2 && scoreIELTS < 8.7)
    {
        scoreIELTS = 8.5;
    }
    else if (scoreIELTS > 8.7 && scoreIELTS < 9.2)
    {
        scoreIELTS = 9;
    }
    else
    {
        Console.WriteLine("You entered an incorrect number or action");
    }

    switch (scoreIELTS)
    {
        case 4:
            Console.WriteLine("You still have to study !!! 🤏");
            break;
        case 4.5:
            Console.WriteLine("You still have to study !!! 🤏");
            break;
        case 5:
            Console.WriteLine($"{scoreIELTS} - Modest 😒!");
            break;
        case 5.5:
            Console.WriteLine($"{scoreIELTS} - Modest 😒!");
            break;
        case 6:
            Console.WriteLine($"{scoreIELTS} - Competent 👍!");
            break;
        case 6.5:
            Console.WriteLine($"{scoreIELTS} - Competent 👍!");
            break;
        case 7:
            Console.WriteLine($"{scoreIELTS} - Good 👍!!");
            break;
        case 7.5:
            Console.WriteLine($"{scoreIELTS} - Good 👍!!");
            break;
        case 8:
            Console.WriteLine($"{scoreIELTS} - Very good 🫡 !!!");
            break;
        case 8.5:
            Console.WriteLine($"{scoreIELTS} - Very good 🫡 !!!");
            break;
        case 9:
            Console.WriteLine($"{scoreIELTS} - Expert 🫡 !!!");
            break;
        default:
            Console.WriteLine("This is not a game 🤬 !");
            break;
    }

    Console.WriteLine("Do you want to use the program again? 👉 y/n 👈");
    string answer = Console.ReadLine();

    if (answer.ToLower() != "y")
    {
        break;
    }
    else
    {
        Console.WriteLine("Thank you for using the program 🤝");
    }
}