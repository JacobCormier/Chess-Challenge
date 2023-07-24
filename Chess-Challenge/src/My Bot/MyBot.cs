//Rules
//You may participate alone, or in a group of any size.
//You may submit a maximum of two entries.
//Please only submit a second entry if it is significantly different from your first bot (not just a minor tweak).
//Note: you will need to log in with a second Google account if you want submit a second entry.
//Only the following namespaces are allowed:
//ChessChallenge.API
//System
//System.Numerics
//System.Collections.Generic
//System.Linq
//You may not use the AsParallel() function
//As implied by the allowed namespaces, you may not read data from a file or access the internet, nor may you create any new threads or tasks to run code in parallel/in the background.
//You may not use the unsafe keyword.
//You may not store data inside the name of a variable/function/class etc (to be extracted with nameof(), GetType().ToString(), Environment.StackTracks and so on).
//Very clever ideas though, thank you to #12 and #24.
//If your bot makes an illegal move or runs out of time, it will lose the game.
//Games are played with 1 minute per side by default (this can be changed in the settings class). The final tournament time control is TBD, so your bot should not assume a particular time control, and instead respect the amount of time left on the timer (given in the Think function).
//Your bot may not allocate more than 256mb of memory.
//All of your code/data must be contained within the MyBot.cs file.
//Note: you may create additional scripts for testing/training your bot, but only the MyBot.cs file will be submitted, so it must be able to run without them.
//You may not rename the MyBot struct or Think function contained in the MyBot.cs file.
//The code in MyBot.cs may not exceed the bot brain capacity of 1024 (see below).






//https://seblague.github.io/chess-coding-challenge/documentation/

using ChessChallenge.API;

public class MyBot : IChessBot
{
    public Move Think(Board board, Timer timer)
    {
        Move[] moves = board.GetLegalMoves(true);

        return moves[0];
    }
}