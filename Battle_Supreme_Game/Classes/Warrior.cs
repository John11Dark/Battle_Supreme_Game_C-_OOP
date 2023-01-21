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
        private  Weapon _weapon;

        public void setWeapon(Weapon weapon)
        {
            this._weapon = weapon;
        }

        public Warrior() : base("")
        {
            
        }
        public Warrior(string name) : base(name)
        {
        }

        public new void Battle(bool win, Character opponent)
        {
            base.Battle(win, opponent);

            if (win)
            {
                opponent.health -= _weapon.hitPoints;
            }
            else
            {
                _weapon.damage += (opponent.level * 2);
                if (_weapon.damage >= 100)
                {
                    _weapon.hitPoints = 0;
                }
            }
        }
    }
}