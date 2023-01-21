namespace Battle_Supreme_Game.Classes
{
    /// <summary>
    /// Class <c>Wand</c>
    /// <example>
    /// Wand wand = new Wand("name");
    /// </example>
    /// </summary>
    public class Wand
    {
        string name;
        internal int hitPoints;

        /// <summary>
        ///  Method <c>Wand</c>
        /// /// <param name="name"> string</param>
        /// </summary>
        public Wand(string name, int hitPoints)
        {
            this.name = name;
            this.hitPoints = hitPoints;
        }
    }
}