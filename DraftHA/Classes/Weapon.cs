namespace DraftHA.Classes
{
    public class Weapon
    {
        string name;
        public int damage;
        public int hitPoints;

        /// <summary>
        /// <c>Weapon</c>
        /// This is the default constructor for the Weapon class.
        /// It sets the default values for the name, hitPoints and damage properties.
        /// </summary>
        public Weapon()
        {
            this.name = "";
            this.hitPoints = 0;
            this.damage = 0;
        }

        /// <summary>
        /// <c>Weapon</c>
        /// This constructor takes in a name and hitPoints as arguments, and sets the name and hitPoints properties accordingly.
        /// The damage property is set to 0 by default.
        /// </summary>
        /// <param type="string" name="name">The name of the weapon. </param>
        /// <param type="int" name="hitPoints">The hitPoints of the weapon.</param>
        public Weapon(string name, int hitPoints)
        {
            this.name = name;
            this.hitPoints = hitPoints;
            this.damage = 0;
        }
    }
}