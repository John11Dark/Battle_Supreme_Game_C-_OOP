namespace DraftHA.Classes
{
    public class Weapon
    {
        string name;
        internal int damage;
        internal int hitPoints;

        public Weapon()
        {
            this.name = "";
            this.hitPoints = 0;
            this.damage = 0;
        }
        public Weapon(string name, int hitPoints)
        {
            this.name = name;
            this.hitPoints = hitPoints;
            this.damage = 0;
        }
    }
}