namespace DraftHA.Classes
{
    /// <summary>
    /// Represents a character in the game, with properties such as name, health, level, points, victories, and loses.
    /// </summary>
    public class Character
    {
        /// <summary>
        /// The name of the character.
        /// </summary>
        public string name;

        /// <summary>
        /// The health of the character.
        /// </summary>
        public int health;

        /// <summary>
        /// The level of the character.
        /// </summary>
        public int level;

        private int points;
        private int victories;
        private int loses;

        /// <summary>
        /// <c>Character</c>
        /// Creates a new instance of the Character class.
        /// </summary>
        /// <param name="name">The name of the character.</param>
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
        /// <c>battle</c>
        /// Executes the battle functionality for the character.
        /// </summary>
        /// <param name="isWining">A boolean value indicating if the character is winning the battle.</param>
        /// <param name="opponent">The opponent character.</param>
        public void battle(bool isWining, Character opponent)
        {
            if (isWining)
            {
                this.victories++;
                setPoints(opponent.level * 10);

                /*if ((this.points % 100) == 0)
                {
                    this.level++;
                }*/

                this.level += points % 100 == 0 ? 1 : 0;
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


        /// <summary>
        /// Gets the number of victories of the character.
        /// </summary>
        /// <returns>An integer representing the number of victories.</returns>
        public int getVictories()
        {
            return this.victories;
        }

        /// <summary>
        /// Gets the number of loses of the character.
        /// </summary>
        /// <returns>An integer representing the number of loses.</returns>
        public int getLoses()
        {
            return this.loses;
        }

        /// <summary>
        /// Gets the number of points of the character.
        /// </summary>
        /// <returns>An integer representing the number of points.</returns>
        public int getPoints()
        {
            return this.points;

        }

        /// <summary>
        /// set the points of the character.
        /// </summary>
        /// <param name="points">The points value of character.</param>
        public void setPoints(int points)
        {
            this.points += points;
        }
    }
}