namespace Battle_Supreme_Game.Classes
{
    public class Character
    {
        internal string name;
        internal int health;
        internal int points;
        internal int level;
        internal int wons;
        internal int loses;

        public Character(string name)
        {
            this.name = name;
            this.health = 100;
            this.level = 1;
            this.points = 0;
            this.wons = 0;
            this.loses = 0;
        }

        public void Battle(bool win, Character opponent)
        {
            if (win)
            {
                this.wons++;
                this.points = (opponent.level * 10);
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
    }
}