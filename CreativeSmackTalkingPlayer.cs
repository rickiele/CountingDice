using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {

        // Make a list of taunts to use
        public List<string> AllTaunts { get; } = new List<string>()
        {
            "You look like a poopoo platter, and not the good kind!",
            "Eat my cheeks you filthy tarantula!",
            "Your grandma rolls better than you! I know cause I MADE her roll down the stairs!",
            "You got a problem with me squirt head??!",
            "Don't make me stab you with a really sharp jolly rancher!!"
        };

        public override void Play(Player other)
        {
            // Get the method from Play
            base.Play(other);

            // Randomize the taunt
            int randomTaunt = new Random().Next(5) + 1;

            // String which contains randomized taunt
            Console.WriteLine($"{Name} expresses with vexation: {AllTaunts[randomTaunt]} ");
        }


    }
}