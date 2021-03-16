using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; set; }

        public override void Play(Player other)
        {
            // base refers to a entire method. in this case, for Play.
            base.Play(other);
            Console.WriteLine($"{Name} taunts with: {Taunt}");
        }
    }
}