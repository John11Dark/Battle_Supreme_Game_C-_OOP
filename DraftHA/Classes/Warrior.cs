using System;

namespace DraftHA.Classes
{
    public class Warrior : Character
    {
        private Weapon weapon;

        /// <summary>
        /// This is the default constructor for the <see cref="Warrior"/> class, it inherits the base constructor from the <seealso cref="Character"/> class and sets the default values for the name.
        /// </summary>
        public Warrior() : base("")
        {
        }

        /// <summary>
        /// This constructor takes in a name as an argument, and sets the name property accordingly.
        /// It inherits the base constructor from the <seealso cref="Character"/> class.
        /// </summary>
        /// <param type="string" name="name">The name of the warrior.</param>
        public Warrior(string name) : base(name)
        {
        }

        /// <summary>
        /// <c>battle</c>
        /// This method is used to simulate a battle between a warrior and another character.
        /// It overrides the base battle method from the <seealso cref="Character.battle(bool, Character)"/> class and adds additional functionality specific to the warrior.
        /// </summary>
        /// <param type="bool" name="win">A boolean value indicating whether the warrior wins or loses the battle.</param>
        /// <param type="Character" name="opponent">The opponent character in the battle.</param>
        public new void battle(bool win, Character opponent)
        {
            base.battle(win, opponent);

            if (win)
            {
                opponent.health -= weapon.hitPoints;
            }
            else
            {
                weapon.damage += (opponent.level * 2);
                if (weapon.damage >= 100)
                {
                    weapon.hitPoints = 0;
                }
            }
        }

        /// <summary>
        /// <c>setWeapon</c>
        /// This method is used to set the weapon property of the warrior.
        /// It checks if the provided parameter is a valid instance of the Weapon class.
        /// </summary>
        /// <param type="Weapon" name="weapon">The weapon instance to be set for the warrior.</param>
        public void setWeapon(Weapon weapon)
        {
            if (weapon != null && weapon.GetType() == typeof(Weapon))
            {
                this.weapon = weapon;
            }
            else
            {
                Console.WriteLine(@"weapon parameter must be a valid instance of Weapon..");
            }
        }
    }
}