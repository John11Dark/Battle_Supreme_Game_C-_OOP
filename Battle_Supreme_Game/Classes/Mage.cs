namespace Battle_Supreme_Game.Classes
{
    public class Mage : Character
    {
        private  Wand _wand;
        int powerLevel;
        int currentStamina;

        public void setWand(Wand wand)
        {
            this._wand = wand;
        }
        public Mage() : base("")
        {
            
        }
        public Mage(string name, Wand wand, int powerLevel, int currentStamina) : base(name)
        {
            this._wand = wand;
            this.powerLevel = powerLevel;
            this.currentStamina = currentStamina;
        }

        public new void Battle(bool win, Character opponent)
        {
            base.Battle(win, opponent);


            if (win)
            {
                opponent.health -= _wand.hitPoints + (powerLevel * currentStamina);
            }

            if (currentStamina != 0)
            {
                currentStamina--;
            }
        }
    }
}