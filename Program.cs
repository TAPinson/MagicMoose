using System;
using System.Collections;

namespace EnthusiasticMoose
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Magic Moose!");
            Console.WriteLine("---------------------------");
            Console.WriteLine();
            MooseSays("Ask a question and receive an answer!");
        }

        static void MooseSays(string message)
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
            string question = Console.ReadLine();
            if (question != "")
            {
                MooseReplies();
            }
            else
            {
                Console.WriteLine("GoodBye");
            }
        }

        static void MooseReplies()
        {
            ArrayList responseList = new ArrayList();
            responseList.Add("As I see it, yes.");
            responseList.Add("Ask again later.");
            responseList.Add("Better not tell you now.");
            responseList.Add("Cannot predict now.");
            responseList.Add("Concentrate and ask again.");
            responseList.Add("Don’t count on it.");
            responseList.Add("It is certain.");
            responseList.Add("It is decidedly so.");
            responseList.Add("Most likely.");
            responseList.Add("My reply is no.");
            responseList.Add("My sources say no.");
            responseList.Add("Outlook not so good.");
            responseList.Add("Outlook good.");
            responseList.Add("Reply hazy, try again.");
            responseList.Add("Signs point to yes.");
            responseList.Add("Very doubtful.");
            responseList.Add("Without a doubt.");
            responseList.Add("Yes.");
            responseList.Add("Yes – definitely.");
            responseList.Add("You may rely on it.");
            Random r = new Random();
            int secretNumber = r.Next(0, 19);
            object message = responseList[secretNumber];
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
            System.Threading.Thread.Sleep(5000);
            MooseSays("Ask a question and receive an answer!");
        }
    }
}