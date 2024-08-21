using System;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Keep taking cards up to 21. If you go over, you lose.");

        Random rgen = new Random();

        //game state
        int compScore = rgen.Next(15, 20);
        int playerScore = 0;
        string playerCards = "";
        bool gameOver = false;
        
        //deal 1 card
        int card = rgen.Next(1, 11);
        playerScore += card;
        playerCards += card + " ";
        
        //main loop
        while(!gameOver) {
            //render
            Console.WriteLine("Current Cards: " + playerCards);
            Console.WriteLine("Current Score: " + playerScore);
            Console.Write("Want another card (y or n)? ");

            //get user input
            string cmd = Console.ReadLine().ToUpper();

            //update state
            if(cmd == "Y") {
                card = rgen.Next(1, 11);
                playerScore += card;
                playerCards += card + " ";
            }
            if(playerScore > 21 || cmd != "Y" ) {
                gameOver = true;
            }
        }

        if (playerScore > compScore && playerScore <= 21) {
            Console.WriteLine("Winner Winner Chicken Dinner!");
        } else {
            Console.WriteLine("Wasted!");
        }
    }
}
