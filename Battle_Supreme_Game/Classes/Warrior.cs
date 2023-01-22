using System;

namespace Battle_Supreme_Game.Classes
{
    //Warrior 
    //  Warrior is a type of Character and has the same attributes as that of the Character as well as a Weapon attribute.  
    //  There is some differences in how the Battle() functionality is executed. This method takes the same input (opponent and win),
    //  but functionality is performed as follows: 
    //	First the exact same functionality as that defined by the Character type is executed 
    //	Then a check is made for the win parameter o If win is true: 
    //	The opponent’s health is deducted by the weapon’s hit points o If win is false: 
    //	The weapon’s damage is increased by the opponent’s level * 2 
    //	Another check is performed so that if the weapon’s damage
    //  is greater or equal to 100, then its hit points should be set to 0 


    public class Warrior : Character
    {
        private Weapon weapon;

        public Warrior() : base("")
        {
        }

        public Warrior(string name) : base(name)
        {
        }

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