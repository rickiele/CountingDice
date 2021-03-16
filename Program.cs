using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make new players

            // ROUND ONE
            // One Higher Player
            OneHigherPlayer highPlayer = new OneHigherPlayer();
            highPlayer.Name = "High Kite Kyle";

            // Smack Talking Player
            SmackTalkingPlayer smackPlayer = new SmackTalkingPlayer()
            {
                Name = "Smacktalking Smoochie Susan",
                Taunt = "\"You're gonna eat my lips!!!\""
            };

            // Smack Talking Player plays the High Roller
            smackPlayer.Play(highPlayer);

            Console.WriteLine("-------------------");

            // ROUND TWO: Creative Smack Talking Player vs Smack Talking Player
            // Creative Smack Talking Player
            CreativeSmackTalkingPlayer creativePlayer = new CreativeSmackTalkingPlayer()
            {
                Name = "Mean Bean Jim"
            };

            creativePlayer.Play(smackPlayer);

            Console.WriteLine("-------------------");

            // ROUND Three: Always Higher Player vs Large Dice Player
            Player largePlayer = new LargeDicePlayer()
            {
                Name = "Big Booty Roller"
            };

            highPlayer.Play(largePlayer);

            Console.WriteLine("-------------------");

            // ROUND Four: Human Player vs Sore Loser Player
            HumanPlayer humanPlayer = new HumanPlayer()
            {
                Name = "Human Manny"
            };

            SoreLoserPlayer sorePlayer = new SoreLoserPlayer()
            {
                Name = "Sore Sunny"
            };

            humanPlayer.Play(sorePlayer);

            List<Player> players = new List<Player>() {
                highPlayer, smackPlayer, creativePlayer, largePlayer, humanPlayer, sorePlayer
            };

            PlayMany(players);
        }

        static void PlayMany(List<Player> players)
        {
            Console.WriteLine();
            Console.WriteLine("Let's play a bunch of times, shall we?");

            // We "order" the players by a random number
            // This has the effect of shuffling them randomly
            Random randomNumberGenerator = new Random();
            List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

            // We are going to match players against each other
            // This means we need an even number of players
            int maxIndex = shuffledPlayers.Count;
            if (maxIndex % 2 != 0)
            {
                maxIndex = maxIndex - 1;
            }

            // Loop over the players 2 at a time
            for (int i = 0; i < maxIndex; i += 2)
            {
                Console.WriteLine("-------------------");

                // Make adjacent players play one another
                Player player1 = shuffledPlayers[i];
                Player player2 = shuffledPlayers[i + 1];
                player1.Play(player2);
            }
        }
    }
}