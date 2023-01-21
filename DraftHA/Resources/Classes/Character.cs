public class Character
{
    string name;
    int health;
    int points;
    int level;
    int wons;
    int loses;

    public Character(string name)
    {
        this.name = name;
        this.health = 100;
        this.level = 1;
        this.points = 0;
        this.won = 0;
        this.loses = 0;
    }

    public void Battel(bool win, Character opponent)
    {
        if (win)
        {
            this.won++;
            this.points = (opponent.level * 10);
            if ((this.points % 100) == 0)
            {
                this.level++;
            }
        }
        else
        {
            this.loses++;
            this.health -= (opponent.level * 5)


            if (this.health <= 0)
            {
                this.health == 0
            }

        }

    }
}