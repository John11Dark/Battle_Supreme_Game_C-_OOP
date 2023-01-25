using System;

namespace DraftHA.Classes
{
    /// </summary>
    /// The Mage class represents a character in the game that has special abilities and attributes.
    /// </summary>
    public class Mage : Character
    {
        private Wand wand;
        private int powerLevel;
        private int currentStamina;
        private readonly Random _random = new Random();


        /// <summary>
        /// Initializes a new instance of the <see cref="Mage"/> class with default values.
        /// </summary>
        public Mage() : base("")
        {
            this.powerLevel = _random.Next(0, 5);
            this.currentStamina = 10;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Mage"/> class with the given name.
        /// </summary>
        /// <param name="name">The name of the mage.</param>
        public Mage(string name) : base(name)
        {
            this.powerLevel = _random.Next(0, 5);
            this.currentStamina = 10;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Mage"/> class with the given name, power level, and current stamina.
        /// </summary>
        /// <param name="name">The name of the mage.</param>
        /// <param name="powerLevel">The power level of the mage.</param>
        /// <param name="currentStamina">The current stamina of the mage.</param>
        public Mage(string name, int powerLevel, int currentStamina) : base(name)
        {
            this.powerLevel = powerLevel;
            this.currentStamina = currentStamina;
        }

        /// <summary>
        /// This method is used to set the wand property of the Mage.
        /// It checks if the provided parameter is a valid instance of the Mage class.
        /// </summary>
        /// <param name="wand">The wand to be set for the mage.</param>
        public void setWand(Wand wand)
        {
            if (wand.GetType() == typeof(Wand))
            {
                this.wand = wand;
            }
            else
            {
                throw new ArgumentException("wand parameter must be a valid instance of Wand..");
            }
        }


        /// <summary>
        /// <c>battle</c>
        /// This method is used to simulate a battle between a Mage and another character.
        /// It overrides the base battle method from the <seealso cref="Character.battle(bool, Character)"/> class and adds additional functionality specific to the Mage.
        /// </summary>
        /// <param name="win">A boolean value indicating whether the mage wins the battle.</param>
        /// <param name="opponent">The opponent character in the battle.</param>
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