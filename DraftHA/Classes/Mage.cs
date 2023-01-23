using System;

namespace DraftHA.Classes
{
    public class Mage : Character
    {
        private Wand wand;
        private int powerLevel;
        private int currentStamina;
        private readonly Random _random = new Random();

        public Mage() : base("")
        {
            this.powerLevel = _random.Next(0, 5);
            this.currentStamina = 10;
        }

        public Mage(string name) : base(name)
        {
            this.powerLevel = _random.Next(0, 5);
            this.currentStamina = 10;
        }

        public Mage(string name, int powerLevel, int currentStamina) : base(name)
        {
            this.powerLevel = powerLevel;
            this.currentStamina = currentStamina;
        }

        public void setWand(Wand wand)
        {
            if (wand != null && wand.GetType() == typeof(Wand))
            {
                this.wand = wand;
            }
            else
            {
                Console.WriteLine(@"Wand parameter must be a valid instance of Wand..");
            }
        }

        public new void battle(bool win, Character opponent)
        {
            base.battle(win, opponent);


            if (win)
            {
                opponent.health -= wand.hitPoints + (powerLevel * currentStamina);
            }

            if (currentStamina != 0)
            {
                currentStamina--;
            }
        }
    }
}