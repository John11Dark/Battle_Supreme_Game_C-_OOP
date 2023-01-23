namespace DraftHA.Classes
{
    public class Character
    {
        internal string name;
        internal int health;
        internal int level;
        private int points;
        private int victories;
        private int loses;

        protected Character(string name)
        {
            this.name = name;
            this.health = 100;
            this.level = 1;
            this.points = 0;
            this.victories = 0;
            this.loses = 0;
        }

        /// <summary>
        /// <c>Battle</c>
        /// This method handles the battle between the current character and an opponent character.
        /// </summary>
        /// <param name="isWining">A boolean indicating whether the current character wins the battle or not.</param>
        /// <param name="opponent">The character object representing the opponent in the battle.</param>W
        public void battle(bool isWining, Character opponent)
        {
            if (isWining)
            {
                this.victories++;
                setPoints(opponent.level * 10);
                if ((this.points % 100) == 0)
                {
                    this.level++;
                }
            }
            else
            {
                this.loses++;
                this.health -= (opponent.level * 5);


                if (this.health <= 0)
                {
                    this.health = 0;
                }
            }
        }

        public int getVictories()
        {
            return this.victories;
        }

        public int getLoses()
        {
            return this.loses;
        }

        public int getPoints()
        {
            return this.points;
        }

        public void setPoints(int points)
        {
            this.points = points;
        }
    }
}