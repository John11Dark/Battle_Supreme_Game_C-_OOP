namespace DraftHA.Classes
{
    public class Wand
    {
        public string name;
        public int hitPoints;

        /// <summary>
        /// <c>Wand</c>
        /// This constructor takes in a name and hitPoints as arguments, and sets the name and hitPoints properties accordingly.
        /// </summary>
        /// <param type="string" name="name">The name of the Wand.</param>
        /// <param type="int" name="hitPoints">The hitPoints of the Wand.</param>
        public Wand(string name, int hitPoints)
        {
            this.name = name;
            this.hitPoints = hitPoints;
        }
    }
}