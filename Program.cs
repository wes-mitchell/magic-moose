using System;
using System.Collections.Generic;

List<string> MooseResponses = new List<string>()
{
    "As I see it, yes.",
    "Ask again later.",
    "Better not tell you now.",
    "Cannot predict now.",
    "Concentrate and ask again.",
    "Don’t count on it.",
    "It is certain.",
    "It is decidedly so.",
    "Most likely.",
    "My reply is no.",
    "My sources say no.",
    "Outlook not so good.",
    "Outlook good.",
    "Reply hazy, try again.",
    "Signs point to yes.",
    "Very doubtful.",
    "Without a doubt.",
    "Yes.",
    "Yes – definitely.",
    "You may rely on it."
};

Main();

void Main()
{
Console.WriteLine("Welcome to the Magic Moose Simulator!");
Console.WriteLine("-------------------------------------");
Console.WriteLine();

MooseSays("Sup Dawg, I'm enthusiastic.");
MagicMoose();


void MooseSays(string message)
{
      Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}

}

void MagicMoose()
{
    Console.WriteLine($"Ask the moose a question: ");
    string question = Console.ReadLine().ToLower();

    if (string.IsNullOrWhiteSpace(question))
    {
        Console.Write("goodbye");
    } 

    else if (!string.IsNullOrWhiteSpace(question))
    {
        Random response = new Random();
        int genRand = response.Next(0, MooseResponses.Count);
        Console.WriteLine(MooseResponses[genRand]);
        MagicMoose();
    }
}